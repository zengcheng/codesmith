﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using CodeSmith.CustomProperties;
using CodeSmith.Engine;
using CodeSmith.SchemaHelper;

using SchemaExplorer;

using Configuration=CodeSmith.SchemaHelper.Configuration;

namespace QuickStart
{
    public class EntityCodeTemplate : CSLABaseTemplate
    {
        #region Private Member(s)

        private TableSchema _table;
        private StringCollection _ignoreExpressions;
        private StringCollection _cleanExpressions;
        private bool _silverlightSupport;
        private FrameworkVersion frameworkVersion;

        #endregion

        #region Constructor(s)

        public EntityCodeTemplate()
        {
            DataAccessImplementation = DataAccessMethod.ParameterizedSQL;
            UseLazyLoading = true;

            CleanExpressions = new StringCollection();
            IgnoreExpressions = new StringCollection();
        }

        #endregion

        #region Public Properties

        #region 1. DataSource

        [Category("1. DataSource")]
        [Description("Source Table")]
        public TableSchema SourceTable
        {
            get
            {
                return _table;
            }
            set
            {
                if(value != null && _table != value)
                {
                    _table = value;
                    OnTableChanged();
                }
            }
        }

        [Category("1. DataSource")]
        [Description("List of regular expressions to clean table, view and column names.")]
        [Optional]
        [DefaultValue("^(sp|tbl|udf|vw)_")]
        public CodeSmith.CustomProperties.StringCollection CleanExpressions
        {
            get
            {
                return _cleanExpressions;
            }
            set
            {
                _cleanExpressions = value;

                Configuration.Instance.CleanExpressions = new List<Regex>();
                foreach (string clean in _cleanExpressions)
                {
                    if (!string.IsNullOrEmpty(clean))
                    {
                        Configuration.Instance.CleanExpressions.Add(new Regex(clean, RegexOptions.IgnoreCase));
                    }
                }

                if (SourceTable != null)
                    Entity = new Entity(SourceTable);
            }
        }

        [Category("1. DataSource")]
        [Description("List of regular expressions to ignore tables when generating.")]
        [Optional]
        [DefaultValue("sysdiagrams$")]
        public CodeSmith.CustomProperties.StringCollection IgnoreExpressions
        {
            get
            {
                return _ignoreExpressions;
            }
            set
            {
                _ignoreExpressions = value;

                Configuration.Instance.IgnoreExpressions = new List<Regex>();
                foreach (string ignore in _ignoreExpressions)
                {
                    if (!string.IsNullOrEmpty(ignore))
                    {
                        Configuration.Instance.IgnoreExpressions.Add(new Regex(ignore, RegexOptions.IgnoreCase));
                    }
                }

                if(SourceTable != null)
                    Entity = new Entity(SourceTable);
            }
        }

        [Browsable(false)]
        public Entity Entity { get; internal set; }

        #endregion

        #region 2. Solution

        [Editor(typeof(System.Windows.Forms.Design.FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Optional, NotChecked]
        [Category("2. Solution")]
        [Description("The path to the Solution location.")]
        [DefaultValue(".\\")]
        public string Location { get; set; }

        [Optional]
        [Category("2. Solution")]
        [Description("The .NET Framework Version. If you use v40 then CSLA 4.0 will be used. If you use v35 then CSLA 3.8 will be used.")]
        public FrameworkVersion FrameworkVersion
        {
            get
            {
                return this.frameworkVersion;
            }
            set
            {
                this.frameworkVersion = value;
                Configuration.Instance.FrameworkVersion = value;
            }
        }

        #endregion

        #region 3. Business Project

        [Category("3. Business Project")]
        [Description("The namespace for the business project.")]
        public string BusinessProjectName { get; set; }

        [Category("3. Business Project")]
        [Description("The name of the business class.")]
        public string BusinessClassName { get; set; }

        [Browsable(false)]
        public string ChildBusinessClassName
        {
            get
            {
                if (string.IsNullOrEmpty(BusinessClassName))
                    return BusinessClassName;

                if (BusinessClassName.Equals(Entity.ClassName, StringComparison.InvariantCultureIgnoreCase))
                    return BusinessClassName;

                if (BusinessClassNameExists("ListList", 4))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 4);

                if (BusinessClassNameExists("InfoList", 8))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 8);

                if (BusinessClassNameExists("NameValueList", 13))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 13);

                if (BusinessClassNameExists("List", 4))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 4);

                if (BusinessClassNameExists("Info", 4))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 4);

                if (BusinessClassNameExists("Criteria", 8))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 8);

                return BusinessClassName;
            }
        }

        private string _criteriaClassName = string.Empty;

        [Category("3. Business Project")]
        [Description("The name of the criteria business class.")]
        public string CriteriaClassName
        {
            get
            {
                if(string.IsNullOrEmpty(_criteriaClassName))
                    _criteriaClassName = ResolveTargetClassName(ChildBusinessClassName, "Criteria");

                return _criteriaClassName;
            }
            set
            {
                if(value.EndsWith("Criteria", StringComparison.InvariantCultureIgnoreCase))
                    _criteriaClassName = value;
            }
        }

        /// <summary>
        /// Gets the Root BusinessName + the suffix.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        [Browsable(false)]
        public string ResolveTargetClassName(string className, string suffix)
        {
            return ResolveTargetClassName(className, suffix, true);
        }

        /// <summary>
        /// Gets the Root BusinessName + the suffix.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="suffix"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        [Browsable(false)]
        public string ResolveTargetClassName(string className, string suffix, bool expression)
        {
            // We will use these eventually..
            //bool isReadOnly;
            //bool searchingForCriteriaObject = suffix.Equals("criteria", StringComparison.InvariantCultureIgnoreCase);
         
            if(string.IsNullOrEmpty(className))
                className = Entity != null ? Entity.ClassName : string.Empty;

            if (Entity != null)
            {
                var temp = className.Replace(Entity.ClassName, string.Empty);
                if (temp.Equals("criteria", StringComparison.InvariantCultureIgnoreCase) ||
                    temp.Equals("list", StringComparison.InvariantCultureIgnoreCase))
                {
                    className = Entity.ClassName;
                }

                // Try to detect if we are generating a read only object..
                if (temp.Equals("info", StringComparison.InvariantCultureIgnoreCase) ||
                    temp.Equals("infolist", StringComparison.InvariantCultureIgnoreCase))
                {
                    // Try to detect double endings.
                    if (suffix.Equals("info", StringComparison.InvariantCultureIgnoreCase)) return string.Format("{0}Info", Entity.ClassName);

                    //isReadOnly = true;
                    className = string.Format("{0}Info", Entity.ClassName);
                }
            }

            // If the keys are 0 then that means they are not generating from the entities.csp.
            if ((BusinessObjectExists(suffix) && expression) || ContextData.Keys.Count == 0)
                return string.Concat(className, suffix);

            return expression ? string.Concat(className, suffix.Trim()) : className;
        }

        [Category("3. Business Project")]
        [Description("Uses private member backing variables for properties.")]
        [DefaultValue(false)]
        public bool UseMemberVariables { get; set; }

        [Category("3. Business Project")]
        [Description("Changes how the Business Objects are deleted, defaults to immediate deletion.")]
        [DefaultValue(false)]
        public bool UseDeferredDeletion { get; set; }

        [Category("3. Business Project")]
        [Description("If enabled Silverlight support will be added to the project..")]
        [DefaultValue(false)]
        public bool IncludeSilverlightSupport
        {
            get
            {
                return _silverlightSupport;
            }
            set
            {
                if (!IsCSLA40)
                    Console.WriteLine("In order to include Silverlight support you must target CSLA 4.0.");

                _silverlightSupport = value;
                Configuration.Instance.IncludeSilverlightSupport = value;
            }
        }

        #endregion
        
        #region 4. Data Project

        [Category("4. Data Project")]
        [Description("Changes how the Business Data Access Methods and Data Access Layer are implemented.")]
        public DataAccessMethod DataAccessImplementation { get; set; }

        [Category("4. Data Project")]
        [Description("The value all sql parameters should be prefixed with.")]
        [DefaultValue("@p_")]
        public string ParameterPrefix
        {
            get
            {
                return Configuration.Instance.ParameterPrefix;
            }
            set
            {
                Configuration.Instance.ParameterPrefix = value;
            }
        }

        [Category("4. Data Project")]
        [Description("Changes how the business layer and data acces layer is implemented.")]
        [DefaultValue(true)]
        public bool UseLazyLoading { get; set; }

        [Category("4. Data Project")]
        [Description("Prefix to use for all generated procedure names.")]
        public string ProcedurePrefix { get; set; }

        [Category("4. Data Project")]
        [Description("Whether or not to immediately execute the script on the target database.")]
        [DefaultValue(false)]
        public bool AutoExecuteStoredProcedures { get; set; }

        [Category("4. Data Project")]
        [Description("Isolation level to use in the generated procedures.")]
        [DefaultValue(0)] //ReadCommitted
        public TransactionIsolationLevelEnum IsolationLevel { get; set; }

        #endregion

        #region public virtual properties

        [Browsable(false)]
        public bool RenderOptionalContent { get; set; }

        #endregion

        #endregion

        #region Public Virtual Methods

        public virtual void OnTableChanged()
        {
            Entity = new Entity(SourceTable);

            if (string.IsNullOrEmpty(BusinessClassName))
                BusinessClassName = Entity.ClassName;

            if (string.IsNullOrEmpty(CriteriaClassName) || CriteriaClassName.Equals("Criteria", StringComparison.InvariantCultureIgnoreCase))
                BusinessClassName = String.Concat(Entity.ClassName, "Criteria");

            if (string.IsNullOrEmpty(BusinessProjectName))
                BusinessProjectName = String.Concat(SourceTable.Namespace(), ".Business");

            if (string.IsNullOrEmpty(Location))
                Location = ".\\";

            if (string.IsNullOrEmpty(ProcedurePrefix))
                ProcedurePrefix = "CSLA_";
        }

        public virtual string GetTableOwner()
        {
            return GetTableOwner(true);
        }

        public virtual string GetTableOwner(bool includeDot)
        {
            if (SourceTable.Owner.Length > 0)
                return includeDot
                           ? string.Format("[{0}].", SourceTable.Owner)
                           : string.Format("[{0}]", SourceTable.Owner);

            return string.Empty;
        }

        #endregion

        #region Public Method(s)

        [Browsable(false)]
        public override bool IsCSLA40
        {
            get
            {
                return this.frameworkVersion == FrameworkVersion.v40;
            }
        }

        public override void RegisterReferences()
        {
            RegisterReference(!IsCSLA40
                                  ? Path.GetFullPath(Path.Combine(CodeTemplateInfo.DirectoryName, @"..\..\Common\Csla\3.8\Client\Csla.dll"))
                                  : Path.GetFullPath(Path.Combine(CodeTemplateInfo.DirectoryName, @"..\..\Common\Csla\4.0\Client\Csla.dll")));
        }

        public bool IsReadOnlyBusinessObject(string suffix)
        {
            string key = string.Format("{0}{1}", this._table.Name, suffix);
            if (ContextData.Get(key) == null) return false;

            var value = ContextData[key];
            switch (value)
            {
                case Constants.ReadOnlyChild:
                case Constants.ReadOnlyRoot:
                case Constants.ReadOnlyChildList:
                case Constants.ReadOnlyList:
                    return true;
            }

            return false;
        }

        public bool IsReadOnlyBusinessObject(Association association, string suffix)
        {
            if (association.Count <= 0)
                return false;

            string key = string.Format("{0}{1}", association.TableKey, suffix);
            if (ContextData.Get(key) == null) return false;

            var value = ContextData[key];
            switch (value)
            {
                case Constants.ReadOnlyChild:
                case Constants.ReadOnlyRoot:
                case Constants.ReadOnlyChildList:
                case Constants.ReadOnlyList:
                    return true;
            }

            return false;
        }

        public bool IsChildBusinessObject(string suffix)
        {
            string key = string.Format("{0}{1}", this._table.Name, suffix);
            if (ContextData.Get(key) == null) return false;

            var value = ContextData[key];
            switch (value)
            {
                case Constants.EditableChild:
                case Constants.ReadOnlyChild:
                case Constants.EditableChildList:
                case Constants.ReadOnlyChildList:
                    return true;
            }

            return false;
        }

        public bool IsChildBusinessObject(Association association)
        {
            return IsChildBusinessObject(association, string.Empty); 
        }

        public bool IsChildBusinessObject(Association association, string suffix)
        {
            if (association.Count <= 0)
                return false;

            string key = string.Format("{0}{1}", association.TableKey, suffix);
            if (ContextData.Get(key) == null) return false;

            var value = ContextData[key];
            switch (value)
            {
                case Constants.EditableChild:
                case Constants.ReadOnlyChild:
                case Constants.EditableChildList:
                case Constants.ReadOnlyChildList:
                    return true;
            }

            return false;
        }

        public bool IsNameValueListBusinessObject(Association association)
        {
            return IsNameValueListBusinessObject(association, string.Empty);
        }

        public bool IsNameValueListBusinessObject(Association association, string suffix)
        {
            if (association.Count <= 0)
                return false;

            string key = string.Format("{0}{1}", association.TableKey, suffix);
            if (ContextData.Get(key) == null) return false;

            var value = ContextData[key];
            switch (value)
            {
                case Constants.NameValueList:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Checks to see if a Business Object exists without a suffix.
        /// </summary>
        /// <param name="suffix">The Suffix</param>
        /// <param name="length"></param>
        /// <returns></returns>
        public bool BusinessClassNameExists(string suffix, int length)
        {
            if(!BusinessClassName.EndsWith(suffix, true, CultureInfo.InvariantCulture))
                return false;

            if (Entity.ClassName == BusinessClassName.Substring(0, BusinessClassName.Length - length))
                return BusinessObjectExists(string.Empty);

            return BusinessObjectExists(BusinessClassName.Substring(BusinessClassName.Length - length, length));
        }

        /// <summary>
        /// This is used to detect to see if the context data contains a class. It is used in the case where we want to see if a read-write class exists before a read only..
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        public bool BusinessObjectExists(string suffix)
        {
            if (_table == null)
                return false;

            string key = string.Format("{0}{1}", _table.Name, suffix);

            return ContextData.Get(key) != null;
        }

        /// <summary>
        /// This is used to detect to see if the context data contains a class. It is used in the case where we want to see if a read-write class exists before a read only..
        /// </summary>
        /// <param name="association"></param>
        /// <returns></returns>
        public bool BusinessObjectExists(Association association)
        {
            return BusinessObjectExists(association, string.Empty);
        }

        /// <summary>
        /// This is used to detect to see if the context data contains a class. It is used in the case where we want to see if a read-write class exists before a read only..
        /// </summary>
        /// <param name="association"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        public bool BusinessObjectExists(Association association, string suffix)
        {
            if (association.Count <= 0)
                return false;

            string key = string.Format("{0}{1}", association.TableKey, suffix);

            return ContextData.Get(key) != null;
        }

        #endregion

        #region Procedure Naming

        public virtual string GetInsertStoredProcedureName()
        {
            return String.Format("{0}[{1}{2}_Insert]", GetTableOwner(), ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetInsertStoredProcedureShortName()
        {
            return String.Format("{0}{1}_Insert", ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetUpdateStoredProcedureName()
        {
            return String.Format("{0}[{1}{2}_Update]", GetTableOwner(), ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetUpdateStoredProcedureShortName()
        {
            return String.Format("{0}{1}_Update", ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetDeleteStoredProcedureName()
        {
            return String.Format("{0}[{1}{2}_Delete]", GetTableOwner(), ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetDeleteStoredProcedureShortName()
        {
            return String.Format("{0}{1}_Delete", ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetSelectStoredProcedureName()
        {
            return String.Format("{0}[{1}{2}_Select]", GetTableOwner(), ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetSelectStoredProcedureShortName()
        {
            return String.Format("{0}{1}_Select", ProcedurePrefix, Entity.ClassName);
        }

        #endregion
    }
}
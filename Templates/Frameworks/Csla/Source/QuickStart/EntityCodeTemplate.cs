﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

        #endregion

        #region Constructor(s)

        public EntityCodeTemplate()
        {
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
        [DefaultValue("^\\w+_")]
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

                if (BusinessClassName.EndsWith("ListList", true, CultureInfo.InvariantCulture))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 4);

                if (BusinessClassName.EndsWith("List", true, CultureInfo.InvariantCulture))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 4);

                if (BusinessClassName.EndsWith("Criteria", true, CultureInfo.InvariantCulture))
                    return BusinessClassName.Substring(0, BusinessClassName.Length - 8);

                return BusinessClassName;
            }
        }

        [Category("3. Business Project")]
        [Description("Uses private member backing variables for properties.")]
        [DefaultValue(false)]
        public bool UseMemberVariables { get; set; }

        [Category("3. Business Project")]
        [Description("Changes how the Business Objects are deleted, defaults to immediate deletion.")]
        [DefaultValue(false)]
        public bool UseDeferredDeletion { get; set; }

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
        [DefaultValue(false)]
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

        #endregion

        #region Public Virtual Methods

        public virtual void OnTableChanged()
        {
            Entity = new Entity( SourceTable );

            if (string.IsNullOrEmpty(BusinessClassName))
                BusinessClassName = Entity.ClassName;

            if (string.IsNullOrEmpty(BusinessProjectName))
                BusinessProjectName = string.Format("{0}.Business", SourceTable.Namespace());

            if (string.IsNullOrEmpty(Location))
                Location = ".\\";

            if (string.IsNullOrEmpty(ProcedurePrefix))
                ProcedurePrefix = "CSLA_";
        }

        protected virtual string GetTableOwner()
        {
            return GetTableOwner(true);
        }

        protected virtual string GetTableOwner(bool includeDot)
        {
            if (SourceTable.Owner.Length > 0)
                return includeDot
                           ? string.Format("[{0}].", SourceTable.Owner)
                           : string.Format("[{0}]", SourceTable.Owner);

            return string.Empty;
        }

        #endregion

        #region Public Method(s)

        public override void RegisterReferences()
        {
            RegisterReference(Path.Combine(CodeTemplateInfo.DirectoryName, @"..\..\Common\Csla\Csla.dll"));
        }

        #endregion

        #region Procedure Naming

        public virtual string GetInsertStoredProcedureName()
        {
            return String.Format("{0}[{1}{2}_Insert]", GetTableOwner(), ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetUpdateStoredProcedureName()
        {
            return String.Format("{0}[{1}{2}_Update]", GetTableOwner(), ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetDeleteStoredProcedureName()
        {
            return String.Format("{0}[{1}{2}_Delete]", GetTableOwner(), ProcedurePrefix, Entity.ClassName);
        }

        public virtual string GetSelectStoredProcedureName()
        {
            return String.Format("{0}[{1}{2}_Select]", GetTableOwner(), ProcedurePrefix, Entity.ClassName);
        }

        #endregion
    }
}

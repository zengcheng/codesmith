#pragma warning disable 1591
#pragma warning disable 0414        
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using Tracker.Data;

namespace Tracker.Data.Entities
{
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class Audit : EntityBase
    {
        #region Static Constructor
        
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        static Audit()
        {
            AddSharedRules();
        }
        
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public Audit()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected override void Initialize()
        {
            OnCreated();
        }
        
        #endregion
        
        #region Column Mapped Properties
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.Int32 _identification;
        
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.Int32 Id
        {
            get { return _identification; }
            set
            {
                OnIdChanging(value, _identification);
                SendPropertyChanging("Id");
                _identification = value;
                SendPropertyChanged("Id");
                OnIdChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.DateTime _date;
        
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.DateTime Date
        {
            get { return _date; }
            set
            {
                OnDateChanging(value, _date);
                SendPropertyChanging("Date");
                _date = value;
                SendPropertyChanged("Date");
                OnDateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _content;
        
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Content
        {
            get { return _content; }
            set
            {
                OnContentChanging(value, _content);
                SendPropertyChanging("Content");
                _content = value;
                SendPropertyChanged("Content");
                OnContentChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _username;
        
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Username
        {
            get { return _username; }
            set
            {
                OnUsernameChanging(value, _username);
                SendPropertyChanging("Username");
                _username = value;
                SendPropertyChanged("Username");
                OnUsernameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.DateTime _createdDate;
        
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                OnCreatedDateChanging(value, _createdDate);
                SendPropertyChanging("CreatedDate");
                _createdDate = value;
                SendPropertyChanged("CreatedDate");
                OnCreatedDateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _myxml;
        
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Myxml
        {
            get { return _myxml; }
            set
            {
                OnMyxmlChanging(value, _myxml);
                SendPropertyChanging("Myxml");
                _myxml = value;
                SendPropertyChanged("Myxml");
                OnMyxmlChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.Byte[] _rowVersion;
        
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.Byte[] RowVersion
        {
            get { return _rowVersion; }
            set
            {
                OnRowVersionChanging(value, _rowVersion);
                SendPropertyChanging("RowVersion");
                _rowVersion = value;
                SendPropertyChanged("RowVersion");
                OnRowVersionChanged(value);
            }
        }
        
        #endregion
        
        #region Associations Mappings
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private Task _task;
        
        [System.Runtime.Serialization.DataMember(Order = 8, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual Task Task
        {
            get { return _task; }
            set
            {
                OnTaskChanging(value, _task);
                SendPropertyChanging("Task");
                _task = value;
                SendPropertyChanged("Task");
                OnTaskChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private User _user;
        
        [System.Runtime.Serialization.DataMember(Order = 9, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual User User
        {
            get { return _user; }
            set
            {
                OnUserChanging(value, _user);
                SendPropertyChanging("User");
                _user = value;
                SendPropertyChanged("User");
                OnUserChanged(value);
            }
        }
        
        #endregion
        
        #region Extensibility Method
        
        static partial void AddSharedRules();
        
        partial void OnCreated();
        
        partial void OnIdChanging(System.Int32 newValue, System.Int32 oldValue);
        
        partial void OnIdChanged(System.Int32 value);
        
        partial void OnDateChanging(System.DateTime newValue, System.DateTime oldValue);
        
        partial void OnDateChanged(System.DateTime value);
        
        partial void OnContentChanging(System.String newValue, System.String oldValue);
        
        partial void OnContentChanged(System.String value);
        
        partial void OnUsernameChanging(System.String newValue, System.String oldValue);
        
        partial void OnUsernameChanged(System.String value);
        
        partial void OnCreatedDateChanging(System.DateTime newValue, System.DateTime oldValue);
        
        partial void OnCreatedDateChanged(System.DateTime value);
        
        partial void OnMyxmlChanging(System.String newValue, System.String oldValue);
        
        partial void OnMyxmlChanged(System.String value);
        
        partial void OnRowVersionChanging(System.Byte[] newValue, System.Byte[] oldValue);
        
        partial void OnRowVersionChanged(System.Byte[] value);
        
        
        partial void OnTaskChanging(Task newValue, Task oldValue);
        
        partial void OnTaskChanged(Task value);
        
        partial void OnUserChanging(User newValue, User oldValue);
        
        partial void OnUserChanged(User value);
        
        #endregion
        
        #region Clone
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual Audit Clone()
        {
            return (Audit)((ICloneable)this).Clone();
        }
        
        #endregion
        
        #region Serialization
        
        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Audit FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Audit));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Audit;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Audit FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Audit));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Audit;
            }
        }
        
        #endregion
    }
}

#pragma warning restore 1591
#pragma warning restore 0414


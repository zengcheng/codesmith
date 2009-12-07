﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The class representing the dbo.Task table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Task")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    [System.Data.Services.Common.DataServiceKey("Id")]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class Task
        : LinqEntityBase, ICloneable, Tracker.Core.Data.Interfaces.ITask  
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Task"/> class.
        /// </summary>
        static Task()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Task"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public Task()
        {
            Initialize();
        }

        private void Initialize()
        {
            _taskExtended = default(System.Data.Linq.EntityRef<TaskExtended>);
            _assignedUser = default(System.Data.Linq.EntityRef<User>);
            _createdUser = default(System.Data.Linq.EntityRef<User>);
            _auditList = new System.Data.Linq.EntitySet<Audit>(OnAuditListAdd, OnAuditListRemove);
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        private int _id = default(int);

        /// <summary>
        /// Gets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    OnIdChanging(value);
                    SendPropertyChanging("Id");
                    _id = value;
                    SendPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }

        private int _createdId;

        /// <summary>
        /// Gets or sets the CreatedId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedId", Storage = "_createdId", DbType = "int NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public int CreatedId
        {
            get { return _createdId; }
            set
            {
                if (_createdId != value)
                {
                    if (_createdUser.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnCreatedIdChanging(value);
                    SendPropertyChanging("CreatedId");
                    _createdId = value;
                    SendPropertyChanged("CreatedId");
                    OnCreatedIdChanged();
                }
            }
        }

        private string _summary;

        /// <summary>
        /// Gets or sets the Summary column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Summary", Storage = "_summary", DbType = "nvarchar(255) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public string Summary
        {
            get { return _summary; }
            set
            {
                if (_summary != value)
                {
                    OnSummaryChanging(value);
                    SendPropertyChanging("Summary");
                    _summary = value;
                    SendPropertyChanged("Summary");
                    OnSummaryChanged();
                }
            }
        }

        private string _details;

        /// <summary>
        /// Gets or sets the Details column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Details", Storage = "_details", DbType = "nvarchar(2000)", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(2000)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        public string Details
        {
            get { return _details; }
            set
            {
                if (_details != value)
                {
                    OnDetailsChanging(value);
                    SendPropertyChanging("Details");
                    _details = value;
                    SendPropertyChanged("Details");
                    OnDetailsChanged();
                }
            }
        }

        private Nullable<System.DateTime> _startDate;

        /// <summary>
        /// Gets or sets the StartDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "StartDate", Storage = "_startDate", DbType = "datetime", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        public Nullable<System.DateTime> StartDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    OnStartDateChanging(value);
                    SendPropertyChanging("StartDate");
                    _startDate = value;
                    SendPropertyChanged("StartDate");
                    OnStartDateChanged();
                }
            }
        }

        private Nullable<System.DateTime> _dueDate;

        /// <summary>
        /// Gets or sets the DueDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "DueDate", Storage = "_dueDate", DbType = "datetime", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        public Nullable<System.DateTime> DueDate
        {
            get { return _dueDate; }
            set
            {
                if (_dueDate != value)
                {
                    OnDueDateChanging(value);
                    SendPropertyChanging("DueDate");
                    _dueDate = value;
                    SendPropertyChanged("DueDate");
                    OnDueDateChanged();
                }
            }
        }

        private Nullable<System.DateTime> _completeDate;

        /// <summary>
        /// Gets or sets the CompleteDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CompleteDate", Storage = "_completeDate", DbType = "datetime", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        public Nullable<System.DateTime> CompleteDate
        {
            get { return _completeDate; }
            set
            {
                if (_completeDate != value)
                {
                    OnCompleteDateChanging(value);
                    SendPropertyChanging("CompleteDate");
                    _completeDate = value;
                    SendPropertyChanged("CompleteDate");
                    OnCompleteDateChanged();
                }
            }
        }

        private Nullable<int> _assignedId;

        /// <summary>
        /// Gets or sets the AssignedId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "AssignedId", Storage = "_assignedId", DbType = "int", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        public Nullable<int> AssignedId
        {
            get { return _assignedId; }
            set
            {
                if (_assignedId != value)
                {
                    if (_assignedUser.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnAssignedIdChanging(value);
                    SendPropertyChanging("AssignedId");
                    _assignedId = value;
                    SendPropertyChanged("AssignedId");
                    OnAssignedIdChanged();
                }
            }
        }

        private System.DateTime _createdDate;

        /// <summary>
        /// Gets or sets the CreatedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedDate", Storage = "_createdDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 9)]
        public System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                if (_createdDate != value)
                {
                    OnCreatedDateChanging(value);
                    SendPropertyChanging("CreatedDate");
                    _createdDate = value;
                    SendPropertyChanged("CreatedDate");
                    OnCreatedDateChanged();
                }
            }
        }

        private System.DateTime _modifiedDate;

        /// <summary>
        /// Gets or sets the ModifiedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ModifiedDate", Storage = "_modifiedDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 10)]
        public System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set
            {
                if (_modifiedDate != value)
                {
                    OnModifiedDateChanging(value);
                    SendPropertyChanging("ModifiedDate");
                    _modifiedDate = value;
                    SendPropertyChanged("ModifiedDate");
                    OnModifiedDateChanged();
                }
            }
        }

        private System.Data.Linq.Binary _rowVersion = default(System.Data.Linq.Binary);

        /// <summary>
        /// Gets the RowVersion column value.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Data.Linq.Mapping.Column(Name = "RowVersion", Storage = "_rowVersion", DbType = "timestamp NOT NULL", IsDbGenerated = true, IsVersion = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 11)]
        public System.Data.Linq.Binary RowVersion
        {
            get { return _rowVersion; }
            set
            {
                if (_rowVersion != value)
                {
                    OnRowVersionChanging(value);
                    SendPropertyChanging("RowVersion");
                    _rowVersion = value;
                    SendPropertyChanged("RowVersion");
                    OnRowVersionChanged();
                }
            }
        }

        private string _lastModifiedBy;

        /// <summary>
        /// Gets or sets the LastModifiedBy column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LastModifiedBy", Storage = "_lastModifiedBy", DbType = "nvarchar(50)", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        [System.Runtime.Serialization.DataMember(Order = 12)]
        public string LastModifiedBy
        {
            get { return _lastModifiedBy; }
            set
            {
                if (_lastModifiedBy != value)
                {
                    OnLastModifiedByChanging(value);
                    SendPropertyChanging("LastModifiedBy");
                    _lastModifiedBy = value;
                    SendPropertyChanged("LastModifiedBy");
                    OnLastModifiedByChanged();
                }
            }
        }

        private Status _statusId;

        /// <summary>
        /// Gets or sets the StatusId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "StatusId", Storage = "_statusId", DbType = "int NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 13)]
        [System.ComponentModel.DataAnnotations.UIHint("Enumeration")]
        public Status Status
        {
            get { return _statusId; }
            set
            {
                if (_statusId != value)
                {
                    OnStatusChanging(value);
                    SendPropertyChanging("Status");
                    _statusId = value;
                    SendPropertyChanged("Status");
                    OnStatusChanged();
                }
            }
        }

        private Nullable<Priority> _priorityId;

        /// <summary>
        /// Gets or sets the PriorityId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "PriorityId", Storage = "_priorityId", DbType = "int", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 14)]
        [System.ComponentModel.DataAnnotations.UIHint("Enumeration")]
        public Nullable<Priority> Priority
        {
            get { return _priorityId; }
            set
            {
                if (_priorityId != value)
                {
                    OnPriorityChanging(value);
                    SendPropertyChanging("Priority");
                    _priorityId = value;
                    SendPropertyChanged("Priority");
                    OnPriorityChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        private System.Data.Linq.EntityRef<TaskExtended> _taskExtended;

        /// <summary>
        /// Gets or sets the <see cref="TaskExtended"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Task_TaskExtended", Storage = "_taskExtended", ThisKey = "Id", OtherKey = "TaskId", IsUnique = true)]
        [System.Runtime.Serialization.DataMember(Order = 15, EmitDefaultValue = false)]
        public TaskExtended TaskExtended
        {
            get { return (serializing && !_taskExtended.HasLoadedOrAssignedValue) ? null : _taskExtended.Entity; }
            set
            {
                TaskExtended previousValue = _taskExtended.Entity;
                if (previousValue != value || _taskExtended.HasLoadedOrAssignedValue == false)
                {
                    OnTaskExtendedChanging(value);
                    SendPropertyChanging("TaskExtended");
                    if (previousValue != null)
                    {
                        _taskExtended.Entity = null;
                        previousValue.Task = null;
                    }
                    _taskExtended.Entity = value;
                    if (value != null)
                    {
                        value.Task = this;
                    }
                    SendPropertyChanged("TaskExtended");
                    OnTaskExtendedChanged();
                }
            }
        }
        

        private System.Data.Linq.EntityRef<User> _assignedUser;

        /// <summary>
        /// Gets or sets the <see cref="User"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "User_Task", Storage = "_assignedUser", ThisKey = "AssignedId", OtherKey = "Id", IsUnique = true, IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 16, EmitDefaultValue = false)]
        public User AssignedUser
        {
            get { return (serializing && !_assignedUser.HasLoadedOrAssignedValue) ? null : _assignedUser.Entity; }
            set
            {
                User previousValue = _assignedUser.Entity;
                if (previousValue != value || _assignedUser.HasLoadedOrAssignedValue == false)
                {
                    OnAssignedUserChanging(value);
                    SendPropertyChanging("AssignedUser");
                    if (previousValue != null)
                    {
                        _assignedUser.Entity = null;
                        previousValue.AssignedTaskList.Remove(this);
                    }
                    _assignedUser.Entity = value;
                    if (value != null)
                    {
                        value.AssignedTaskList.Add(this);
                        _assignedId = value.Id;
                    }
                    else
                    {
                        _assignedId = default(Nullable<int>);
                    }
                    SendPropertyChanged("AssignedUser");
                    OnAssignedUserChanged();
                }
            }
        }
        

        private System.Data.Linq.EntityRef<User> _createdUser;

        /// <summary>
        /// Gets or sets the <see cref="User"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "User_Task1", Storage = "_createdUser", ThisKey = "CreatedId", OtherKey = "Id", IsUnique = true, IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 17, EmitDefaultValue = false)]
        public User CreatedUser
        {
            get { return (serializing && !_createdUser.HasLoadedOrAssignedValue) ? null : _createdUser.Entity; }
            set
            {
                User previousValue = _createdUser.Entity;
                if (previousValue != value || _createdUser.HasLoadedOrAssignedValue == false)
                {
                    OnCreatedUserChanging(value);
                    SendPropertyChanging("CreatedUser");
                    if (previousValue != null)
                    {
                        _createdUser.Entity = null;
                        previousValue.CreatedTaskList.Remove(this);
                    }
                    _createdUser.Entity = value;
                    if (value != null)
                    {
                        value.CreatedTaskList.Add(this);
                        _createdId = value.Id;
                    }
                    else
                    {
                        _createdId = default(int);
                    }
                    SendPropertyChanged("CreatedUser");
                    OnCreatedUserChanged();
                }
            }
        }
        

        private System.Data.Linq.EntitySet<Audit> _auditList;

        /// <summary>
        /// Gets or sets the <see cref="Audit"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Task_Audit", Storage = "_auditList", ThisKey = "Id", OtherKey = "TaskId")]
        [System.Runtime.Serialization.DataMember(Order=18, EmitDefaultValue=false)]
        public System.Data.Linq.EntitySet<Audit> AuditList
        {
            get { return (serializing && !_auditList.HasLoadedOrAssignedValues) ? null : _auditList; }
            set { _auditList.Assign(value); }
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnAuditListAdd(Audit entity)
        {
            SendPropertyChanging(null);
            entity.Task = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnAuditListRemove(Audit entity)
        {
            SendPropertyChanging(null);
            entity.Task = null;
            SendPropertyChanged(null);
        }
        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        partial void OnCreated();
        /// <summary>Called when <see cref="Id"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnIdChanging(int value);
        /// <summary>Called after <see cref="Id"/> has Changed.</summary>
        partial void OnIdChanged();
        /// <summary>Called when <see cref="CreatedId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCreatedIdChanging(int value);
        /// <summary>Called after <see cref="CreatedId"/> has Changed.</summary>
        partial void OnCreatedIdChanged();
        /// <summary>Called when <see cref="Summary"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnSummaryChanging(string value);
        /// <summary>Called after <see cref="Summary"/> has Changed.</summary>
        partial void OnSummaryChanged();
        /// <summary>Called when <see cref="Details"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnDetailsChanging(string value);
        /// <summary>Called after <see cref="Details"/> has Changed.</summary>
        partial void OnDetailsChanged();
        /// <summary>Called when <see cref="StartDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnStartDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after <see cref="StartDate"/> has Changed.</summary>
        partial void OnStartDateChanged();
        /// <summary>Called when <see cref="DueDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnDueDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after <see cref="DueDate"/> has Changed.</summary>
        partial void OnDueDateChanged();
        /// <summary>Called when <see cref="CompleteDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCompleteDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after <see cref="CompleteDate"/> has Changed.</summary>
        partial void OnCompleteDateChanged();
        /// <summary>Called when <see cref="AssignedId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnAssignedIdChanging(Nullable<int> value);
        /// <summary>Called after <see cref="AssignedId"/> has Changed.</summary>
        partial void OnAssignedIdChanged();
        /// <summary>Called when <see cref="CreatedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCreatedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="CreatedDate"/> has Changed.</summary>
        partial void OnCreatedDateChanged();
        /// <summary>Called when <see cref="ModifiedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnModifiedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="ModifiedDate"/> has Changed.</summary>
        partial void OnModifiedDateChanged();
        /// <summary>Called when <see cref="RowVersion"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnRowVersionChanging(System.Data.Linq.Binary value);
        /// <summary>Called after <see cref="RowVersion"/> has Changed.</summary>
        partial void OnRowVersionChanged();
        /// <summary>Called when <see cref="LastModifiedBy"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLastModifiedByChanging(string value);
        /// <summary>Called after <see cref="LastModifiedBy"/> has Changed.</summary>
        partial void OnLastModifiedByChanged();
        /// <summary>Called when <see cref="Status"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnStatusChanging(Status value);
        /// <summary>Called after <see cref="Status"/> has Changed.</summary>
        partial void OnStatusChanged();
        /// <summary>Called when <see cref="Priority"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnPriorityChanging(Nullable<Priority> value);
        /// <summary>Called after <see cref="Priority"/> has Changed.</summary>
        partial void OnPriorityChanged();
        /// <summary>Called when <see cref="TaskExtended"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnTaskExtendedChanging(TaskExtended value);
        /// <summary>Called after <see cref="TaskExtended"/> has Changed.</summary>
        partial void OnTaskExtendedChanged();
        /// <summary>Called when <see cref="AssignedUser"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnAssignedUserChanging(User value);
        /// <summary>Called after <see cref="AssignedUser"/> has Changed.</summary>
        partial void OnAssignedUserChanged();
        /// <summary>Called when <see cref="CreatedUser"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCreatedUserChanging(User value);
        /// <summary>Called after <see cref="CreatedUser"/> has Changed.</summary>
        partial void OnCreatedUserChanged();

        #endregion

        #region Serialization
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Task"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Task"/> instance.</param>
        /// <returns>An instance of <see cref="Task"/> that is deserialized from the XML string.</returns>
        public static Task FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Task));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Task;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Task"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Task"/> instance.</param>
        /// <returns>An instance of <see cref="Task"/> that is deserialized from the byte array.</returns>
        public static Task FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Task));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Task;
            }
        }
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        public Task Clone()
        {
            return (Task)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
            _taskExtended = Detach(_taskExtended);
            _assignedUser = Detach(_assignedUser);
            _createdUser = Detach(_createdUser);
            _auditList = Detach(_auditList, OnAuditListAdd, OnAuditListRemove);
        }
        #endregion
    }
}


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

namespace Tester.Data
{
    /// <summary>
    /// Class representing data for the Tester database.
    /// </summary>
    
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    public partial class GetUserFixedResult2
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="GetUserFixedResult2"/> class.
        /// </summary>
        static GetUserFixedResult2()
        {
            CodeSmith.Data.Rules.RuleManager.AddShared<GetUserFixedResult2>();
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserFixedResult2"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public GetUserFixedResult2()
        {
            OnCreated();
            Initialize();
        }

        private void Initialize()
        {
        }
        #endregion

        #region Column Mapped Properties

        private int _id;

        /// <summary>
        /// Gets or sets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    OnIdChanging(value);
                    _id = value;
                    OnIdChanged();
                }
            }
        }

        private Nullable<int> _userId;

        /// <summary>
        /// Gets or sets the UserId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "UserId", Storage = "_userId", DbType = "int")]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public Nullable<int> UserId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    OnUserIdChanging(value);
                    _userId = value;
                    OnUserIdChanged();
                }
            }
        }

        private bool _allowNotification;

        /// <summary>
        /// Gets or sets the AllowNotification column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "AllowNotification", Storage = "_allowNotification", DbType = "bit NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public bool AllowNotification
        {
            get { return _allowNotification; }
            set
            {
                if (_allowNotification != value)
                {
                    OnAllowNotificationChanging(value);
                    _allowNotification = value;
                    OnAllowNotificationChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties
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
        /// <summary>Called when <see cref="UserId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUserIdChanging(Nullable<int> value);
        /// <summary>Called after <see cref="UserId"/> has Changed.</summary>
        partial void OnUserIdChanged();
        /// <summary>Called when <see cref="AllowNotification"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnAllowNotificationChanging(bool value);
        /// <summary>Called after <see cref="AllowNotification"/> has Changed.</summary>
        partial void OnAllowNotificationChanged();

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
        #endregion
    }
}

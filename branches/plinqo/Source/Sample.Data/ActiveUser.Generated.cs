
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Sample.Data
{
    /// <summary>
    /// The class representing the dbo.ActiveUser table.
    /// </summary>
    [Table(Name="dbo.ActiveUser")]
    [DataContract]
    public partial class ActiveUser
        : LinqEntityBase
    {
        
        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveUser"/> class.
        /// </summary>
        [DebuggerNonUserCodeAttribute()]
        public ActiveUser()
        {
            OnCreated();
        }
        #endregion
        
        #region Column Mapped Properties
        
        private int _userID;

        /// <summary>
        /// Gets or sets the UserID column value.
        /// </summary>
        [Column(Name="UserID", Storage="_userID", DbType="int NOT NULL", CanBeNull=false)]
        [DataMember]
        public int UserID
        {
            get { return _userID; }
            set
            {
                if (_userID != value)
                {
                    OnUserIDChanging(value);
                    OnPropertyChanging("UserID");
                    _userID = value;
                    OnPropertyChanged("UserID");
                    OnUserIDChanged();
                }
            }
        }
        
        private string _userName;

        /// <summary>
        /// Gets or sets the UserName column value.
        /// </summary>
        [Column(Name="UserName", Storage="_userName", DbType="varchar(20) NOT NULL", CanBeNull=false)]
        [DataMember]
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    OnUserNameChanging(value);
                    OnPropertyChanging("UserName");
                    _userName = value;
                    OnPropertyChanged("UserName");
                    OnUserNameChanged();
                }
            }
        }
        
        private string _password;

        /// <summary>
        /// Gets or sets the Password column value.
        /// </summary>
        [Column(Name="Password", Storage="_password", DbType="varchar(20) NOT NULL", CanBeNull=false)]
        [DataMember]
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    OnPasswordChanging(value);
                    OnPropertyChanging("Password");
                    _password = value;
                    OnPropertyChanged("Password");
                    OnPasswordChanged();
                }
            }
        }
        
        private string _email;

        /// <summary>
        /// Gets or sets the Email column value.
        /// </summary>
        [Column(Name="Email", Storage="_email", DbType="varchar(150)")]
        [DataMember]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    OnEmailChanging(value);
                    OnPropertyChanging("Email");
                    _email = value;
                    OnPropertyChanged("Email");
                    OnEmailChanged();
                }
            }
        }
        
        private string _firstName;

        /// <summary>
        /// Gets or sets the FirstName column value.
        /// </summary>
        [Column(Name="FirstName", Storage="_firstName", DbType="varchar(100)")]
        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    OnFirstNameChanging(value);
                    OnPropertyChanging("FirstName");
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                    OnFirstNameChanged();
                }
            }
        }
        
        private string _lastName;

        /// <summary>
        /// Gets or sets the LastName column value.
        /// </summary>
        [Column(Name="LastName", Storage="_lastName", DbType="varchar(100)")]
        [DataMember]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    OnLastNameChanging(value);
                    OnPropertyChanging("LastName");
                    _lastName = value;
                    OnPropertyChanged("LastName");
                    OnLastNameChanged();
                }
            }
        }
        #endregion
        
        #region Association Mapped Properties
        #endregion
        
        #region Extensibility Method Definitions
        /// <summary>Called when this instance is loaded.</summary>
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        partial void OnValidate(ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        partial void OnCreated();
        /// <summary>Called when UserID is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUserIDChanging(int value);
        /// <summary>Called after UserID has Changed.</summary>
        partial void OnUserIDChanged();
        /// <summary>Called when UserName is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUserNameChanging(string value);
        /// <summary>Called after UserName has Changed.</summary>
        partial void OnUserNameChanged();
        /// <summary>Called when Password is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnPasswordChanging(string value);
        /// <summary>Called after Password has Changed.</summary>
        partial void OnPasswordChanged();
        /// <summary>Called when Email is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnEmailChanging(string value);
        /// <summary>Called after Email has Changed.</summary>
        partial void OnEmailChanged();
        /// <summary>Called when FirstName is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnFirstNameChanging(string value);
        /// <summary>Called after FirstName has Changed.</summary>
        partial void OnFirstNameChanged();
        /// <summary>Called when LastName is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLastNameChanging(string value);
        /// <summary>Called after LastName has Changed.</summary>
        partial void OnLastNameChanged();
        #endregion
        
    }
}

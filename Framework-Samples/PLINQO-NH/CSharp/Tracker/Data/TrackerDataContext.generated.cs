#pragma warning disable 1591
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using CodeSmith.Data.Linq;
using CodeSmith.Data.NHibernate;
using Configuration = NHibernate.Cfg.Configuration;
using Environment = NHibernate.Cfg.Environment;
using Tracker.Data.Entities;

namespace Tracker.Data
{
    public partial class TrackerDataContext : NHibernateDataContext
    {
        #region Session Implementation

        private static object _sessionFactoryLock = new object();

        private static ISessionFactory _sessionFactory = null;

        private ISessionFactory SessionFactory
        {
            get
            {
                lock (_sessionFactoryLock)
                    if (_sessionFactory == null)
                        _sessionFactory = CreateSessionFactory("Tracker",
                            "Tracker",
                            "NHibernate.Dialect.MsSql2008Dialect",
                            "NHibernate.Driver.SqlClientDriver");

                return _sessionFactory;
            }
        }

        protected override ISession CreateSession()
        {
            return SessionFactory.OpenSession();
        }
        
        protected override IStatelessSession CreateStatelessSession()
        {
            return SessionFactory.OpenStatelessSession();
        }
        
        #endregion
        
        #region Tables
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private ITable<Tracker.Data.Entities.Audit> _audit;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public ITable<Tracker.Data.Entities.Audit> Audit
        {
            get
            {
                if (_audit == null)
                    _audit = new Table<Tracker.Data.Entities.Audit>(this);
                return _audit;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private ITable<Tracker.Data.Entities.Guid> _guid;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public ITable<Tracker.Data.Entities.Guid> Guid
        {
            get
            {
                if (_guid == null)
                    _guid = new Table<Tracker.Data.Entities.Guid>(this);
                return _guid;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private ITable<Tracker.Data.Entities.Priority> _priority;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public ITable<Tracker.Data.Entities.Priority> Priority
        {
            get
            {
                if (_priority == null)
                    _priority = new Table<Tracker.Data.Entities.Priority>(this);
                return _priority;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private ITable<Tracker.Data.Entities.Role> _role;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public ITable<Tracker.Data.Entities.Role> Role
        {
            get
            {
                if (_role == null)
                    _role = new Table<Tracker.Data.Entities.Role>(this);
                return _role;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private ITable<Tracker.Data.Entities.Status> _status;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public ITable<Tracker.Data.Entities.Status> Status
        {
            get
            {
                if (_status == null)
                    _status = new Table<Tracker.Data.Entities.Status>(this);
                return _status;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private ITable<Tracker.Data.Entities.Task> _task;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public ITable<Tracker.Data.Entities.Task> Task
        {
            get
            {
                if (_task == null)
                    _task = new Table<Tracker.Data.Entities.Task>(this);
                return _task;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private ITable<Tracker.Data.Entities.TaskExtended> _taskExtended;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public ITable<Tracker.Data.Entities.TaskExtended> TaskExtended
        {
            get
            {
                if (_taskExtended == null)
                    _taskExtended = new Table<Tracker.Data.Entities.TaskExtended>(this);
                return _taskExtended;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private ITable<Tracker.Data.Entities.User> _user;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public ITable<Tracker.Data.Entities.User> User
        {
            get
            {
                if (_user == null)
                    _user = new Table<Tracker.Data.Entities.User>(this);
                return _user;
            }
        }
        
        #endregion
        
        #region Views
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private IView<Tracker.Data.Entities.TaskDetail> _taskDetail;
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public IView<Tracker.Data.Entities.TaskDetail> TaskDetail
        {
            get
            {
                if (_taskDetail == null)
                    _taskDetail = new View<Tracker.Data.Entities.TaskDetail>(this);
                return _taskDetail;
            }
        }
        
        #endregion
        
        #region Functions
        
        public IList<User> GetUsersWithRolez()
        {
            IQuery query = Advanced.DefaultSession.GetNamedQuery("GetUsersWithRolez");
            
            return query.List<User>();
        }
        
        public IList<RolesForUserResult> RolesForUser(System.Int32 userId)
        {
            IQuery query = Advanced.DefaultSession.GetNamedQuery("RolesForUser");
            
            query.SetParameter("UserId", userId);
            
            query.SetResultTransformer(
                new NHibernate.Transform.AliasToBeanConstructorResultTransformer(
                typeof (RolesForUserResult).GetConstructors()[0]));
                
            return query.List<RolesForUserResult>();
        }
        
        #endregion
    }
}


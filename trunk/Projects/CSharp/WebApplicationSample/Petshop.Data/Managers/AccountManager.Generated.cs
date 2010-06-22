﻿
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
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace Petshop.Data
{
    /// <summary>
    /// The manager class for Account.
    /// </summary>
    public partial class AccountManager 
        : CodeSmith.Data.EntityManagerBase<PetshopDataManager, Petshop.Data.Account>
    {
        /// <summary>
        /// Initializes the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="manager">The current manager.</param>
        public AccountManager(PetshopDataManager manager) : base(manager)
        {
            OnCreated();
        }

        /// <summary>
        /// Gets the current context.
        /// </summary>
        protected Petshop.Data.PetshopDataContext Context
        {
            get { return Manager.Context; }
        }
        
        /// <summary>
        /// Gets the entity for this manager.
        /// </summary>
        protected System.Data.Linq.Table<Petshop.Data.Account> Entity
        {
            get { return Manager.Context.Account; }
        }
        
        
        /// <summary>
        /// Creates the key for this entity.
        /// </summary>
        public static CodeSmith.Data.IEntityKey<int> CreateKey(int accountID)
        {
            return new CodeSmith.Data.EntityKey<int>(accountID);
        }
        
        /// <summary>
        /// Gets an entity by the primary key.
        /// </summary>
        /// <param name="key">The key for the entity.</param>
        /// <returns>
        /// An instance of the entity or null if not found.
        /// </returns>
        /// <remarks>
        /// This method is expecting key to be of type IEntityKey&lt;int&gt;.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when key is not of type IEntityKey&lt;int&gt;.</exception>
        public override Petshop.Data.Account GetByKey(CodeSmith.Data.IEntityKey key)
        {
            if (key is CodeSmith.Data.IEntityKey<int>)
            {
                var entityKey = (CodeSmith.Data.IEntityKey<int>)key;
                return GetByKey(entityKey.Key);
            }
            else
            {
                throw new ArgumentException("Invalid key, expected key to be of type IEntityKey<int>");
            }
        }
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public Petshop.Data.Account GetByKey(int accountID)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByKey.Invoke(Context, accountID);
            else
                return Entity.FirstOrDefault(a => a.AccountID == accountID);
        }
        
        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <returns>The number of rows deleted from the database.</returns>
        public int Delete(int accountID)
        {
            return Entity.Delete(a => a.AccountID == accountID);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        public IQueryable<Petshop.Data.Account> GetByUniqueID(int uniqueID)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByUniqueID.Invoke(Context, uniqueID);
            else
                return Entity.Where(a => a.UniqueID == uniqueID);
        }

        #region Extensibility Method Definitions
        /// <summary>Called when the class is created.</summary>
        partial void OnCreated();
        #endregion
        
        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Petshop.Data.PetshopDataContext, int, Petshop.Data.Account> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Petshop.Data.PetshopDataContext db, int accountID) => 
                        db.Account.FirstOrDefault(a => a.AccountID == accountID));

            internal static readonly Func<Petshop.Data.PetshopDataContext, int, IQueryable<Petshop.Data.Account>> GetByUniqueID = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Petshop.Data.PetshopDataContext db, int uniqueID) => 
                        db.Account.Where(a => a.UniqueID == uniqueID));

        }
        #endregion
    }
}

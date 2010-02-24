﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Product.cs'.
//
//     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    public partial class Product
    {
        #region Root Data Access

        [RunLocal]
        protected override void DataPortal_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;

            LoadProperty(_categoryIdProperty, "BN");
            ValidationRules.CheckRules();

            OnCreated();
        }

        private void DataPortal_Fetch(ProductCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("SELECT [ProductId], [CategoryId], [Name], [Descn], [Image] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'Product' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            const string commandText = "INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [Name], [Descn], [Image]) VALUES (@p_ProductId, @p_CategoryId, @p_Name, @p_Descn, @p_Image)";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
					command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
					command.Parameters.AddWithValue("@p_Name", this.Name);
					command.Parameters.AddWithValue("@p_Descn", this.Description);
					command.Parameters.AddWithValue("@p_Image", this.Image);

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    LoadProperty(_originalProductIdProperty, this.ProductId);
                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnInserted();

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            if(OriginalProductId != ProductId)
            {
                // Insert new child.
                Product item = new Product {ProductId = ProductId, CategoryId = CategoryId, Name = Name, Description = Description, Image = Image};
                item = item.Save();

                // Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
                foreach(Item itemToUpdate in Items)
                {
				itemToUpdate.ProductId = ProductId;
                }

                // Create a new connection.
                using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    FieldManager.UpdateChildren(this, connection);
                }

                // Delete the old.
                DataPortal_Delete(new ProductCriteria {ProductId = OriginalProductId});

                // Mark the original as the new one.
                OriginalProductId = ProductId;

                OnUpdated();

                return;
            }

            const string commandText = "UPDATE [dbo].[Product]  SET [ProductId] = @p_ProductId, [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image WHERE [ProductId] = @p_OriginalProductId";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_OriginalProductId", this.OriginalProductId);
					command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
					command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
					command.Parameters.AddWithValue("@p_Name", this.Name);
					command.Parameters.AddWithValue("@p_Descn", this.Description);
					command.Parameters.AddWithValue("@p_Image", this.Image);

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    LoadProperty(_originalProductIdProperty, this.ProductId);
                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnUpdated();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_DeleteSelf()
        {
            bool cancel = false;
            OnSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new ProductCriteria (ProductId));
        
            OnSelfDeleted();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(ProductCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        #endregion

        #region Child Data Access

        protected override void Child_Create()
        {
            bool cancel = false;
            OnChildCreating(ref cancel);
            if (cancel) return;

            LoadProperty(_categoryIdProperty, "BN");
            ValidationRules.CheckRules();

            OnChildCreated();
        }

        private void Child_Fetch(ProductCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("SELECT [ProductId], [CategoryId], [Name], [Descn], [Image] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(string.Format("The record was not found in 'Product' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnChildFetched();

            MarkAsChild();
        }

        private void Child_Insert(Category category, SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [Name], [Descn], [Image]) VALUES (@p_ProductId, @p_CategoryId, @p_Name, @p_Descn, @p_Image)";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
					command.Parameters.AddWithValue("@p_CategoryId", category.CategoryId);
					command.Parameters.AddWithValue("@p_Name", this.Name);
					command.Parameters.AddWithValue("@p_Descn", this.Description);
					command.Parameters.AddWithValue("@p_Image", this.Image);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                LoadProperty(_originalProductIdProperty, this.ProductId);
            }

            OnChildInserted();
        }

        private void Child_Update(Category category, SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Product]  SET [ProductId] = @p_ProductId, [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image WHERE [ProductId] = @p_OriginalProductId";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_OriginalProductId", this.OriginalProductId);
					command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
					command.Parameters.AddWithValue("@p_CategoryId", category.CategoryId);
					command.Parameters.AddWithValue("@p_Name", this.Name);
					command.Parameters.AddWithValue("@p_Descn", this.Description);
					command.Parameters.AddWithValue("@p_Image", this.Image);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                LoadProperty(_originalProductIdProperty, this.ProductId);
            }

            OnChildUpdated();
        }

        private void Child_DeleteSelf()
        {
            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new ProductCriteria (ProductId));
        
            OnChildSelfDeleted();
        }

        #endregion

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_productIdProperty, reader["ProductId"]);
                LoadProperty(_originalProductIdProperty, reader["ProductId"]);
                LoadProperty(_categoryIdProperty, reader["CategoryId"]);
                LoadProperty(_nameProperty, reader["Name"]);
                LoadProperty(_descriptionProperty, reader["Descn"]);
                LoadProperty(_imageProperty, reader["Image"]);
            }

            OnMapped();

            MarkOld();
        }

        #region Data access partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ProductCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(ProductCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region Child data access partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(ProductCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnChildInserting(ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(ref bool cancel);
        partial void OnChildSelfDeleted();

        #endregion
    }
}
﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Order.cs'.
//
//     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#if !SILVERLIGHT
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    public partial class Order
    {
        #region Root Data Access

        [RunLocal]
        protected override void DataPortal_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;

            BusinessRules.CheckRules();

            OnCreated();
        }

        private void DataPortal_Fetch(OrderCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("SELECT [OrderId], [UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale] FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
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
                            throw new Exception(String.Format("The record was not found in 'Orders' using the following criteria: {0}.", criteria));
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

            const string commandText = "INSERT INTO [dbo].[Orders] ([UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale]) VALUES (@p_UserId, @p_OrderDate, @p_ShipAddr1, @p_ShipAddr2, @p_ShipCity, @p_ShipState, @p_ShipZip, @p_ShipCountry, @p_BillAddr1, @p_BillAddr2, @p_BillCity, @p_BillState, @p_BillZip, @p_BillCountry, @p_Courier, @p_TotalPrice, @p_BillToFirstName, @p_BillToLastName, @p_ShipToFirstName, @p_ShipToLastName, @p_AuthorizationNumber, @p_Locale); SELECT [OrderId] FROM [dbo].[Orders] WHERE OrderId = SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_UserId", this.UserId);
					command.Parameters.AddWithValue("@p_OrderDate", this.OrderDate);
					command.Parameters.AddWithValue("@p_ShipAddr1", this.ShipAddr1);
					command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(this.ShipAddr2));
					command.Parameters.AddWithValue("@p_ShipCity", this.ShipCity);
					command.Parameters.AddWithValue("@p_ShipState", this.ShipState);
					command.Parameters.AddWithValue("@p_ShipZip", this.ShipZip);
					command.Parameters.AddWithValue("@p_ShipCountry", this.ShipCountry);
					command.Parameters.AddWithValue("@p_BillAddr1", this.BillAddr1);
					command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(this.BillAddr2));
					command.Parameters.AddWithValue("@p_BillCity", this.BillCity);
					command.Parameters.AddWithValue("@p_BillState", this.BillState);
					command.Parameters.AddWithValue("@p_BillZip", this.BillZip);
					command.Parameters.AddWithValue("@p_BillCountry", this.BillCountry);
					command.Parameters.AddWithValue("@p_Courier", this.Courier);
					command.Parameters.AddWithValue("@p_TotalPrice", this.TotalPrice);
					command.Parameters.AddWithValue("@p_BillToFirstName", this.BillToFirstName);
					command.Parameters.AddWithValue("@p_BillToLastName", this.BillToLastName);
					command.Parameters.AddWithValue("@p_ShipToFirstName", this.ShipToFirstName);
					command.Parameters.AddWithValue("@p_ShipToLastName", this.ShipToLastName);
					command.Parameters.AddWithValue("@p_AuthorizationNumber", this.AuthorizationNumber);
					command.Parameters.AddWithValue("@p_Locale", this.Locale);

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            using (BypassPropertyChecks)
                            {
                                LoadProperty(_orderIdProperty, reader.GetInt32("OrderId"));
                            }
                        }
                    }

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

            const string commandText = "UPDATE [dbo].[Orders]  SET [UserId] = @p_UserId, [OrderDate] = @p_OrderDate, [ShipAddr1] = @p_ShipAddr1, [ShipAddr2] = @p_ShipAddr2, [ShipCity] = @p_ShipCity, [ShipState] = @p_ShipState, [ShipZip] = @p_ShipZip, [ShipCountry] = @p_ShipCountry, [BillAddr1] = @p_BillAddr1, [BillAddr2] = @p_BillAddr2, [BillCity] = @p_BillCity, [BillState] = @p_BillState, [BillZip] = @p_BillZip, [BillCountry] = @p_BillCountry, [Courier] = @p_Courier, [TotalPrice] = @p_TotalPrice, [BillToFirstName] = @p_BillToFirstName, [BillToLastName] = @p_BillToLastName, [ShipToFirstName] = @p_ShipToFirstName, [ShipToLastName] = @p_ShipToLastName, [AuthorizationNumber] = @p_AuthorizationNumber, [Locale] = @p_Locale WHERE [OrderId] = @p_OrderId";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_OrderId", this.OrderId);
					command.Parameters.AddWithValue("@p_UserId", this.UserId);
					command.Parameters.AddWithValue("@p_OrderDate", this.OrderDate);
					command.Parameters.AddWithValue("@p_ShipAddr1", this.ShipAddr1);
					command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(this.ShipAddr2));
					command.Parameters.AddWithValue("@p_ShipCity", this.ShipCity);
					command.Parameters.AddWithValue("@p_ShipState", this.ShipState);
					command.Parameters.AddWithValue("@p_ShipZip", this.ShipZip);
					command.Parameters.AddWithValue("@p_ShipCountry", this.ShipCountry);
					command.Parameters.AddWithValue("@p_BillAddr1", this.BillAddr1);
					command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(this.BillAddr2));
					command.Parameters.AddWithValue("@p_BillCity", this.BillCity);
					command.Parameters.AddWithValue("@p_BillState", this.BillState);
					command.Parameters.AddWithValue("@p_BillZip", this.BillZip);
					command.Parameters.AddWithValue("@p_BillCountry", this.BillCountry);
					command.Parameters.AddWithValue("@p_Courier", this.Courier);
					command.Parameters.AddWithValue("@p_TotalPrice", this.TotalPrice);
					command.Parameters.AddWithValue("@p_BillToFirstName", this.BillToFirstName);
					command.Parameters.AddWithValue("@p_BillToLastName", this.BillToLastName);
					command.Parameters.AddWithValue("@p_ShipToFirstName", this.ShipToFirstName);
					command.Parameters.AddWithValue("@p_ShipToLastName", this.ShipToLastName);
					command.Parameters.AddWithValue("@p_AuthorizationNumber", this.AuthorizationNumber);
					command.Parameters.AddWithValue("@p_Locale", this.Locale);

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        //RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        if(reader.RecordsAffected == 0)
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                        if(reader.Read())
                        {
                            using (BypassPropertyChecks)
                            {
                            }
                        }
                    }

                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnUpdated();
        }

        protected override void DataPortal_DeleteSelf()
        {
            bool cancel = false;
            OnSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new OrderCriteria (OrderId));
        
            OnSelfDeleted();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(OrderCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
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

        //[Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(OrderCriteria criteria, SqlConnection connection)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
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

            BusinessRules.CheckRules();

            OnChildCreated();
        }

        private void Child_Fetch(OrderCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("SELECT [OrderId], [UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale] FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
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
                            throw new Exception(string.Format("The record was not found in 'Orders' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnChildFetched();

            MarkAsChild();
        }

        #region Child_Insert

        private void Child_Insert(SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Orders] ([UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale]) VALUES (@p_UserId, @p_OrderDate, @p_ShipAddr1, @p_ShipAddr2, @p_ShipCity, @p_ShipState, @p_ShipZip, @p_ShipCountry, @p_BillAddr1, @p_BillAddr2, @p_BillCity, @p_BillState, @p_BillZip, @p_BillCountry, @p_Courier, @p_TotalPrice, @p_BillToFirstName, @p_BillToLastName, @p_ShipToFirstName, @p_ShipToLastName, @p_AuthorizationNumber, @p_Locale); SELECT [OrderId] FROM [dbo].[Orders] WHERE OrderId = SCOPE_IDENTITY()";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_UserId", this.UserId);
					command.Parameters.AddWithValue("@p_OrderDate", this.OrderDate);
					command.Parameters.AddWithValue("@p_ShipAddr1", this.ShipAddr1);
					command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(this.ShipAddr2));
					command.Parameters.AddWithValue("@p_ShipCity", this.ShipCity);
					command.Parameters.AddWithValue("@p_ShipState", this.ShipState);
					command.Parameters.AddWithValue("@p_ShipZip", this.ShipZip);
					command.Parameters.AddWithValue("@p_ShipCountry", this.ShipCountry);
					command.Parameters.AddWithValue("@p_BillAddr1", this.BillAddr1);
					command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(this.BillAddr2));
					command.Parameters.AddWithValue("@p_BillCity", this.BillCity);
					command.Parameters.AddWithValue("@p_BillState", this.BillState);
					command.Parameters.AddWithValue("@p_BillZip", this.BillZip);
					command.Parameters.AddWithValue("@p_BillCountry", this.BillCountry);
					command.Parameters.AddWithValue("@p_Courier", this.Courier);
					command.Parameters.AddWithValue("@p_TotalPrice", this.TotalPrice);
					command.Parameters.AddWithValue("@p_BillToFirstName", this.BillToFirstName);
					command.Parameters.AddWithValue("@p_BillToLastName", this.BillToLastName);
					command.Parameters.AddWithValue("@p_ShipToFirstName", this.ShipToFirstName);
					command.Parameters.AddWithValue("@p_ShipToLastName", this.ShipToLastName);
					command.Parameters.AddWithValue("@p_AuthorizationNumber", this.AuthorizationNumber);
					command.Parameters.AddWithValue("@p_Locale", this.Locale);

                using(var reader = new SafeDataReader(command.ExecuteReader()))
                {
                    if(reader.Read())
                    {

                        // Update identity primary key value.
                        LoadProperty(_orderIdProperty, reader.GetInt32("OrderId"));
                    }
                }
            }

            FieldManager.UpdateChildren(this, connection);
            OnChildInserted();
        }

        #endregion

        #region Child_Update

        private void Child_Update(SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Orders]  SET [UserId] = @p_UserId, [OrderDate] = @p_OrderDate, [ShipAddr1] = @p_ShipAddr1, [ShipAddr2] = @p_ShipAddr2, [ShipCity] = @p_ShipCity, [ShipState] = @p_ShipState, [ShipZip] = @p_ShipZip, [ShipCountry] = @p_ShipCountry, [BillAddr1] = @p_BillAddr1, [BillAddr2] = @p_BillAddr2, [BillCity] = @p_BillCity, [BillState] = @p_BillState, [BillZip] = @p_BillZip, [BillCountry] = @p_BillCountry, [Courier] = @p_Courier, [TotalPrice] = @p_TotalPrice, [BillToFirstName] = @p_BillToFirstName, [BillToLastName] = @p_BillToLastName, [ShipToFirstName] = @p_ShipToFirstName, [ShipToLastName] = @p_ShipToLastName, [AuthorizationNumber] = @p_AuthorizationNumber, [Locale] = @p_Locale WHERE [OrderId] = @p_OrderId";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_OrderId", this.OrderId);
					command.Parameters.AddWithValue("@p_UserId", this.UserId);
					command.Parameters.AddWithValue("@p_OrderDate", this.OrderDate);
					command.Parameters.AddWithValue("@p_ShipAddr1", this.ShipAddr1);
					command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(this.ShipAddr2));
					command.Parameters.AddWithValue("@p_ShipCity", this.ShipCity);
					command.Parameters.AddWithValue("@p_ShipState", this.ShipState);
					command.Parameters.AddWithValue("@p_ShipZip", this.ShipZip);
					command.Parameters.AddWithValue("@p_ShipCountry", this.ShipCountry);
					command.Parameters.AddWithValue("@p_BillAddr1", this.BillAddr1);
					command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(this.BillAddr2));
					command.Parameters.AddWithValue("@p_BillCity", this.BillCity);
					command.Parameters.AddWithValue("@p_BillState", this.BillState);
					command.Parameters.AddWithValue("@p_BillZip", this.BillZip);
					command.Parameters.AddWithValue("@p_BillCountry", this.BillCountry);
					command.Parameters.AddWithValue("@p_Courier", this.Courier);
					command.Parameters.AddWithValue("@p_TotalPrice", this.TotalPrice);
					command.Parameters.AddWithValue("@p_BillToFirstName", this.BillToFirstName);
					command.Parameters.AddWithValue("@p_BillToLastName", this.BillToLastName);
					command.Parameters.AddWithValue("@p_ShipToFirstName", this.ShipToFirstName);
					command.Parameters.AddWithValue("@p_ShipToLastName", this.ShipToLastName);
					command.Parameters.AddWithValue("@p_AuthorizationNumber", this.AuthorizationNumber);
					command.Parameters.AddWithValue("@p_Locale", this.Locale);

                using(var reader = new SafeDataReader(command.ExecuteReader()))
                {
                    if(reader.Read())
                    {
                    }
                }
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
        #endregion

        private void Child_DeleteSelf()
        {
            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new OrderCriteria (OrderId));
        
            OnChildSelfDeleted();
        }

        private void Child_DeleteSelf(params object[] args)
        {
            SqlConnection connection = args.OfType<SqlConnection>().FirstOrDefault();
            if(connection == null)
                throw new ArgumentNullException("args", "Must contain a SqlConnection parameter.");

            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;

            DataPortal_Delete(new OrderCriteria (OrderId), connection);

            OnChildSelfDeleted();
        }

        #endregion

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_orderIdProperty, reader["OrderId"]);
                LoadProperty(_userIdProperty, reader["UserId"]);
                LoadProperty(_orderDateProperty, reader["OrderDate"]);
                LoadProperty(_shipAddr1Property, reader["ShipAddr1"]);
                LoadProperty(_shipAddr2Property, reader["ShipAddr2"]);
                LoadProperty(_shipCityProperty, reader["ShipCity"]);
                LoadProperty(_shipStateProperty, reader["ShipState"]);
                LoadProperty(_shipZipProperty, reader["ShipZip"]);
                LoadProperty(_shipCountryProperty, reader["ShipCountry"]);
                LoadProperty(_billAddr1Property, reader["BillAddr1"]);
                LoadProperty(_billAddr2Property, reader["BillAddr2"]);
                LoadProperty(_billCityProperty, reader["BillCity"]);
                LoadProperty(_billStateProperty, reader["BillState"]);
                LoadProperty(_billZipProperty, reader["BillZip"]);
                LoadProperty(_billCountryProperty, reader["BillCountry"]);
                LoadProperty(_courierProperty, reader["Courier"]);
                LoadProperty(_totalPriceProperty, reader["TotalPrice"]);
                LoadProperty(_billToFirstNameProperty, reader["BillToFirstName"]);
                LoadProperty(_billToLastNameProperty, reader["BillToLastName"]);
                LoadProperty(_shipToFirstNameProperty, reader["ShipToFirstName"]);
                LoadProperty(_shipToLastNameProperty, reader["ShipToLastName"]);
                LoadProperty(_authorizationNumberProperty, reader["AuthorizationNumber"]);
                LoadProperty(_localeProperty, reader["Locale"]);
            }

            OnMapped();

            MarkOld();
        }
    }
}
#endif

﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItem.cs'.
//
//     Template: ObjectFactoryList.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Server;
using Csla.Data;

using PetShop.Tests.ObjF.StoredProcedures;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures.DAL
{
    public partial class LineItemListFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new LineItemList with default values.
        /// </summary>
        /// <returns>new LineItemList.</returns>
        [RunLocal]
        public LineItemList Create()
        {
            var item = (LineItemList)Activator.CreateInstance(typeof(LineItemList), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            CheckRules(item);
            MarkNew(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch LineItemList.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public LineItemList Fetch(LineItemCriteria criteria)
        {
            LineItemList item = (LineItemList)Activator.CreateInstance(typeof(LineItemList), true);

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return item;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_LineItem_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                item.Add(new LineItemFactory().Map(reader));
                            } while(reader.Read());
                        }
                        else
                            throw new Exception(string.Format("The record was not found in 'LineItem' using the following criteria: {0}.", criteria));
                    }
                }
            }

            MarkOld(item);
            OnFetched();
            return item;
        }

        #endregion

        #region Data access partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(LineItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(ref bool cancel);
        partial void OnMapped();

        #endregion
    }
}
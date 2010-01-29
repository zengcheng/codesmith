//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CategoryList.cs'.
//
//     Template: EditableRootList.DataAccess.StoredProcedures.cst
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

namespace PetShop.Tests.Collections.EditableRoot
{
    public partial class CategoryList
    {
        private void DataPortal_Fetch(CategoryCriteria criteria)
        {
            RaiseListChangedEvents = false;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Category_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(new Category(reader));
                            } while(reader.Read());
                        }
                        else
                            throw new Exception(string.Format("The record was not found in 'Category' using the following criteria: {0}.", criteria));
                    }
                }
            }

            RaiseListChangedEvents = true;
        }
    }
}
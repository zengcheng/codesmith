﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'SupplierList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.StoredProcedures
{
    [Serializable]
    public partial class SupplierList : BusinessListBase< SupplierList, Supplier >
    {
        #region Constructor(s)

        private SupplierList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 
        
        internal static SupplierList NewList()
        {
            return DataPortal.CreateChild< SupplierList >();
        }     

        internal static SupplierList GetBySuppId(System.Int32 suppId)
        {
			var criteria = new SupplierCriteria{SuppId = suppId};
			
            
            return DataPortal.FetchChild< SupplierList >(criteria);
        }

        internal static SupplierList GetAll()
        {
            return DataPortal.FetchChild< SupplierList >(new SupplierCriteria());
        }

		#endregion

        #region Method Overrides
        
        protected override object AddNewCore()
        {
            Supplier item = PetShop.Tests.StoredProcedures.Supplier.NewSupplier();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Tests.StoredProcedures.Supplier.NewSupplier();


                Add(item);
            }

            return item;
        }
        
        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(SupplierCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Supplier item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(SupplierCriteria criteria)
        {
            return PetShop.Tests.StoredProcedures.Supplier.Exists(criteria);
        }

        #endregion

    }
}
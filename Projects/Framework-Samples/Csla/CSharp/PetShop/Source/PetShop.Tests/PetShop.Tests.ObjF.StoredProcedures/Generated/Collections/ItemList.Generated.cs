﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1872, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ItemList.cs'.
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

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.ItemListFactoryName)]
    public partial class ItemList : BusinessListBase< ItemList, Item >
    {
        #region Constructor(s)

        private ItemList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 
        
        internal static ItemList NewList()
        {
            return DataPortal.CreateChild< ItemList >();
        }     

        internal static ItemList GetByItemId(System.String itemId)
        {
            var criteria = new ItemCriteria{ItemId = itemId};
            
            
            return DataPortal.FetchChild< ItemList >(criteria);
        }

        internal static ItemList GetByProductIdItemIdListPriceName(System.String productId, System.String itemId, System.Decimal? listPrice, System.String name)
        {
            var criteria = new ItemCriteria{ProductId = productId, ItemId = itemId, Name = name};
            if(listPrice.HasValue) criteria.ListPrice = listPrice.Value;
            
            return DataPortal.FetchChild< ItemList >(criteria);
        }

        internal static ItemList GetByProductId(System.String productId)
        {
            var criteria = new ItemCriteria{ProductId = productId};
            
            
            return DataPortal.FetchChild< ItemList >(criteria);
        }

        internal static ItemList GetBySupplier(System.Int32? supplier)
        {
            var criteria = new ItemCriteria{};
            if(supplier.HasValue) criteria.Supplier = supplier.Value;
            
            return DataPortal.FetchChild< ItemList >(criteria);
        }

        internal static ItemList GetAll()
        {
            return DataPortal.FetchChild< ItemList >(new ItemCriteria());
        }

        #endregion


        #region Method Overrides
        
        protected override object AddNewCore()
        {
            Item item = PetShop.Tests.ObjF.StoredProcedures.Item.NewItem();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Tests.ObjF.StoredProcedures.Item.NewItem();

                // Pass the parent value down to the child.
                //Product product = this.Parent as Product;
                //if(product != null)
                //    item.ProductId = product.ProductId;

                // Pass the parent value down to the child.
                //Supplier supplier = this.Parent as Supplier;
                //if(supplier != null)
                //    item.Supplier = supplier.SuppId;


                Add(item);
            }

            return item;
        }
        
        #endregion

        #region Property overrides

        /// <summary>
        /// Returns true if any children are dirty
        /// </summary>
        public new bool IsDirty
        {
            get
            {
                foreach(Item item in this.Items)
                {
                    if(item.IsDirty) return true;
                }
                
                return false;
            }
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Item item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(ItemCriteria criteria)
        {
            return PetShop.Tests.ObjF.StoredProcedures.Item.Exists(criteria);
        }

        #endregion

    }
}
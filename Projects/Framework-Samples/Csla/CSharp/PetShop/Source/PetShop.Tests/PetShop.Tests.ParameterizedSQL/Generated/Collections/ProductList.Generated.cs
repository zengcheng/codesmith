﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ProductList.cs'.
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

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class ProductList : BusinessListBase< ProductList, Product >
    {
        #region Constructor(s)

        private ProductList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 
        
        internal static ProductList NewList()
        {
            return DataPortal.CreateChild< ProductList >();
        }     

        internal static ProductList GetByProductId(System.String productId)
        {
			var criteria = new ProductCriteria{ProductId = productId};
			
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        internal static ProductList GetByName(System.String name)
        {
			var criteria = new ProductCriteria{Name = name};
			
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        internal static ProductList GetByCategoryId(System.String categoryId)
        {
			var criteria = new ProductCriteria{CategoryId = categoryId};
			
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        internal static ProductList GetByCategoryIdName(System.String categoryId, System.String name)
        {
			var criteria = new ProductCriteria{CategoryId = categoryId, Name = name};
			
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        internal static ProductList GetByCategoryIdProductIdName(System.String categoryId, System.String productId, System.String name)
        {
			var criteria = new ProductCriteria{CategoryId = categoryId, ProductId = productId, Name = name};
			
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        internal static ProductList GetAll()
        {
            return DataPortal.FetchChild< ProductList >(new ProductCriteria());
        }

		#endregion

        #region Method Overrides
        
        protected override object AddNewCore()
        {
            Product item = PetShop.Tests.ParameterizedSQL.Product.NewProduct();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Tests.ParameterizedSQL.Product.NewProduct();

                // Pass the parent value down to the child.
                Category category = this.Parent as Category;
                if(category != null)
                    item.CategoryId = category.CategoryId;


                Add(item);
            }

            return item;
        }
        
        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ProductCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Product item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(ProductCriteria criteria)
        {
            return PetShop.Tests.ParameterizedSQL.Product.Exists(criteria);
        }

        #endregion

    }
}
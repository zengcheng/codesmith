﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1866, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Item.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Rules;
using Csla.Data;
using System.Data.SqlClient;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class Item : BusinessBase< Item >
    {
        #region Contructor(s)

        private Item()
        { /* Require use of factory methods */ }

        internal Item(System.String itemId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_itemIdProperty, itemId);
            }
        }

        internal Item(SafeDataReader reader)
        {
            Map(reader);
        }
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_itemIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_itemIdProperty, 10));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_productIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_productIdProperty, 10));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_statusProperty, 2));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_nameProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_imageProperty, 80));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.String > _itemIdProperty = RegisterProperty< System.String >(p => p.ItemId, string.Empty);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.String ItemId
        {
            get { return GetProperty(_itemIdProperty); }
            set{ SetProperty(_itemIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _originalItemIdProperty = RegisterProperty< System.String >(p => p.OriginalItemId, string.Empty);
        /// <summary>
        /// Holds the original value for ItemId. This is used for non identity primary keys.
        /// </summary>
        internal System.String OriginalItemId
        {
            get { return GetProperty(_originalItemIdProperty); }
            set{ SetProperty(_originalItemIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _productIdProperty = RegisterProperty< System.String >(p => p.ProductId, string.Empty);
        public System.String ProductId
        {
            get { return GetProperty(_productIdProperty); }
            set{ SetProperty(_productIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Decimal? > _listPriceProperty = RegisterProperty< System.Decimal? >(p => p.ListPrice, string.Empty, (System.Decimal?)null);
        public System.Decimal? ListPrice
        {
            get { return GetProperty(_listPriceProperty); }
            set{ SetProperty(_listPriceProperty, value); }
        }
        private static readonly PropertyInfo< System.Decimal? > _unitCostProperty = RegisterProperty< System.Decimal? >(p => p.UnitCost, string.Empty, (System.Decimal?)null);
        public System.Decimal? UnitCost
        {
            get { return GetProperty(_unitCostProperty); }
            set{ SetProperty(_unitCostProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32? > _supplierProperty = RegisterProperty< System.Int32? >(p => p.Supplier, string.Empty, (System.Int32?)null);
        public System.Int32? Supplier
        {
            get { return GetProperty(_supplierProperty); }
            set{ SetProperty(_supplierProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _statusProperty = RegisterProperty< System.String >(p => p.Status, string.Empty, (System.String)null);
        public System.String Status
        {
            get { return GetProperty(_statusProperty); }
            set{ SetProperty(_statusProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name, string.Empty, (System.String)null);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _imageProperty = RegisterProperty< System.String >(p => p.Image, string.Empty, (System.String)null);
        public System.String Image
        {
            get { return GetProperty(_imageProperty); }
            set{ SetProperty(_imageProperty, value); }
        }

        //AssociatedManyToOne
        private static readonly PropertyInfo< Product > _productMemberProperty = RegisterProperty< Product >(p => p.ProductMember, Csla.RelationshipTypes.Child);
        public Product ProductMember
        {
            get
            {
                if(!FieldManager.FieldExists(_productMemberProperty))
                {
                    var criteria = new PetShop.Tests.ParameterizedSQL.ProductCriteria {ProductId = ProductId};
					
                    if(PetShop.Tests.ParameterizedSQL.Product.Exists(criteria))
                        LoadProperty(_productMemberProperty, PetShop.Tests.ParameterizedSQL.Product.GetByProductId(ProductId));
                }

                return GetProperty(_productMemberProperty); 
            }
        }

        //AssociatedManyToOne
        private static readonly PropertyInfo< Supplier > _supplierMemberProperty = RegisterProperty< Supplier >(p => p.SupplierMember, Csla.RelationshipTypes.Child);
        public Supplier SupplierMember
        {
            get
            {
                if(!Supplier.HasValue) 
                    return null;

                if(!FieldManager.FieldExists(_supplierMemberProperty))
                {
                    var criteria = new PetShop.Tests.ParameterizedSQL.SupplierCriteria {};
					if(Supplier.HasValue) criteria.SuppId = Supplier.Value;
                    if(PetShop.Tests.ParameterizedSQL.Supplier.Exists(criteria))
                        LoadProperty(_supplierMemberProperty, PetShop.Tests.ParameterizedSQL.Supplier.GetBySuppId(Supplier.Value));
                }

                return GetProperty(_supplierMemberProperty); 
            }
        }
        #endregion

        #region Synchronous Root Factory Methods 
        
        public static Item NewItem()
        {
            return DataPortal.Create< Item >();
        }

        public static Item GetByItemId(System.String itemId)
        {
			var criteria = new ItemCriteria {ItemId = itemId};
			
			
            return DataPortal.Fetch< Item >(criteria);
        }

        public static Item GetByProductIdItemIdListPriceName(System.String productId, System.String itemId, System.Decimal? listPrice, System.String name)
        {
			var criteria = new ItemCriteria {ProductId = productId, ItemId = itemId, Name = name};
			if(listPrice.HasValue) criteria.ListPrice = listPrice.Value;
			
            return DataPortal.Fetch< Item >(criteria);
        }

        public static Item GetByProductId(System.String productId)
        {
			var criteria = new ItemCriteria {ProductId = productId};
			
			
            return DataPortal.Fetch< Item >(criteria);
        }

        public static Item GetBySupplier(System.Int32? supplier)
        {
			var criteria = new ItemCriteria {};
			if(supplier.HasValue) criteria.Supplier = supplier.Value;
			
            return DataPortal.Fetch< Item >(criteria);
        }

        public static void DeleteItem(System.String itemId)
        {
                DataPortal.Delete< Item >(new ItemCriteria (itemId));
        }
        
        #endregion

        #region Synchronous Child Factory Methods 
        
        internal static Item NewItemChild()
        {
            return DataPortal.CreateChild< Item >();
        }
        internal static Item GetByItemIdChild(System.String itemId)
        {
			var criteria = new ItemCriteria {ItemId = itemId};
			

            return DataPortal.FetchChild< Item >(criteria);
        }
        internal static Item GetByProductIdItemIdListPriceNameChild(System.String productId, System.String itemId, System.Decimal? listPrice, System.String name)
        {
			var criteria = new ItemCriteria {ProductId = productId, ItemId = itemId, Name = name};
			if(listPrice.HasValue) criteria.ListPrice = listPrice.Value;

            return DataPortal.FetchChild< Item >(criteria);
        }
        internal static Item GetByProductIdChild(System.String productId)
        {
			var criteria = new ItemCriteria {ProductId = productId};
			

            return DataPortal.FetchChild< Item >(criteria);
        }
        internal static Item GetBySupplierChild(System.Int32? supplier)
        {
			var criteria = new ItemCriteria {};
			if(supplier.HasValue) criteria.Supplier = supplier.Value;

            return DataPortal.FetchChild< Item >(criteria);
        }

        #endregion
        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(ItemCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region ChildPortal partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(ItemCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(ref bool cancel);
        partial void OnChildSelfDeleted();
        #endregion

        #region Exists Command

        public static bool Exists(ItemCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}
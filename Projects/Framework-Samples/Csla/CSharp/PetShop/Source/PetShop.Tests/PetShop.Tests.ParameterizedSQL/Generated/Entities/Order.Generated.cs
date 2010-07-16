﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Order.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Validation;
using Csla.Data;
using System.Data.SqlClient;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class Order : BusinessBase< Order >
    {
        #region Contructor(s)

        private Order()
        { /* Require use of factory methods */ }

        internal Order(System.Int32 orderId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_orderIdProperty, orderId);
            }
        }

        internal Order(SafeDataReader reader)
        {
            Map(reader);
        }
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            ValidationRules.AddRule(CommonRules.StringRequired, _userIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_userIdProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipAddr1Property);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipAddr1Property, 80));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipAddr2Property, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipCityProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipCityProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipStateProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipStateProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipZipProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipZipProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipCountryProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipCountryProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _billAddr1Property);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billAddr1Property, 80));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billAddr2Property, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billCityProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billCityProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billStateProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billStateProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billZipProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billZipProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _billCountryProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billCountryProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _courierProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_courierProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billToFirstNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billToFirstNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billToLastNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billToLastNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipToFirstNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipToFirstNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipToLastNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipToLastNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _localeProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_localeProperty, 20));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.Int32 > _orderIdProperty = RegisterProperty< System.Int32 >(p => p.OrderId, string.Empty);
		[System.ComponentModel.DataObjectField(true, true)]
        public System.Int32 OrderId
        {
            get { return GetProperty(_orderIdProperty); }
            internal set{ SetProperty(_orderIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _userIdProperty = RegisterProperty< System.String >(p => p.UserId, string.Empty);
        public System.String UserId
        {
            get { return GetProperty(_userIdProperty); }
            set{ SetProperty(_userIdProperty, value); }
        }
        private static readonly PropertyInfo< System.DateTime > _orderDateProperty = RegisterProperty< System.DateTime >(p => p.OrderDate, string.Empty);
        public System.DateTime OrderDate
        {
            get { return GetProperty(_orderDateProperty); }
            set{ SetProperty(_orderDateProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _shipAddr1Property = RegisterProperty< System.String >(p => p.ShipAddr1, string.Empty);
        public System.String ShipAddr1
        {
            get { return GetProperty(_shipAddr1Property); }
            set{ SetProperty(_shipAddr1Property, value); }
        }
        private static readonly PropertyInfo< System.String > _shipAddr2Property = RegisterProperty< System.String >(p => p.ShipAddr2, string.Empty, (System.String)null);
        public System.String ShipAddr2
        {
            get { return GetProperty(_shipAddr2Property); }
            set{ SetProperty(_shipAddr2Property, value); }
        }
        private static readonly PropertyInfo< System.String > _shipCityProperty = RegisterProperty< System.String >(p => p.ShipCity, string.Empty);
        public System.String ShipCity
        {
            get { return GetProperty(_shipCityProperty); }
            set{ SetProperty(_shipCityProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _shipStateProperty = RegisterProperty< System.String >(p => p.ShipState, string.Empty);
        public System.String ShipState
        {
            get { return GetProperty(_shipStateProperty); }
            set{ SetProperty(_shipStateProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _shipZipProperty = RegisterProperty< System.String >(p => p.ShipZip, string.Empty);
        public System.String ShipZip
        {
            get { return GetProperty(_shipZipProperty); }
            set{ SetProperty(_shipZipProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _shipCountryProperty = RegisterProperty< System.String >(p => p.ShipCountry, string.Empty);
        public System.String ShipCountry
        {
            get { return GetProperty(_shipCountryProperty); }
            set{ SetProperty(_shipCountryProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _billAddr1Property = RegisterProperty< System.String >(p => p.BillAddr1, string.Empty);
        public System.String BillAddr1
        {
            get { return GetProperty(_billAddr1Property); }
            set{ SetProperty(_billAddr1Property, value); }
        }
        private static readonly PropertyInfo< System.String > _billAddr2Property = RegisterProperty< System.String >(p => p.BillAddr2, string.Empty, (System.String)null);
        public System.String BillAddr2
        {
            get { return GetProperty(_billAddr2Property); }
            set{ SetProperty(_billAddr2Property, value); }
        }
        private static readonly PropertyInfo< System.String > _billCityProperty = RegisterProperty< System.String >(p => p.BillCity, string.Empty);
        public System.String BillCity
        {
            get { return GetProperty(_billCityProperty); }
            set{ SetProperty(_billCityProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _billStateProperty = RegisterProperty< System.String >(p => p.BillState, string.Empty);
        public System.String BillState
        {
            get { return GetProperty(_billStateProperty); }
            set{ SetProperty(_billStateProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _billZipProperty = RegisterProperty< System.String >(p => p.BillZip, string.Empty);
        public System.String BillZip
        {
            get { return GetProperty(_billZipProperty); }
            set{ SetProperty(_billZipProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _billCountryProperty = RegisterProperty< System.String >(p => p.BillCountry, string.Empty);
        public System.String BillCountry
        {
            get { return GetProperty(_billCountryProperty); }
            set{ SetProperty(_billCountryProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _courierProperty = RegisterProperty< System.String >(p => p.Courier, string.Empty);
        public System.String Courier
        {
            get { return GetProperty(_courierProperty); }
            set{ SetProperty(_courierProperty, value); }
        }
        private static readonly PropertyInfo< System.Decimal > _totalPriceProperty = RegisterProperty< System.Decimal >(p => p.TotalPrice, string.Empty);
        public System.Decimal TotalPrice
        {
            get { return GetProperty(_totalPriceProperty); }
            set{ SetProperty(_totalPriceProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _billToFirstNameProperty = RegisterProperty< System.String >(p => p.BillToFirstName, string.Empty);
        public System.String BillToFirstName
        {
            get { return GetProperty(_billToFirstNameProperty); }
            set{ SetProperty(_billToFirstNameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _billToLastNameProperty = RegisterProperty< System.String >(p => p.BillToLastName, string.Empty);
        public System.String BillToLastName
        {
            get { return GetProperty(_billToLastNameProperty); }
            set{ SetProperty(_billToLastNameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _shipToFirstNameProperty = RegisterProperty< System.String >(p => p.ShipToFirstName, string.Empty);
        public System.String ShipToFirstName
        {
            get { return GetProperty(_shipToFirstNameProperty); }
            set{ SetProperty(_shipToFirstNameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _shipToLastNameProperty = RegisterProperty< System.String >(p => p.ShipToLastName, string.Empty);
        public System.String ShipToLastName
        {
            get { return GetProperty(_shipToLastNameProperty); }
            set{ SetProperty(_shipToLastNameProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _authorizationNumberProperty = RegisterProperty< System.Int32 >(p => p.AuthorizationNumber, string.Empty);
        public System.Int32 AuthorizationNumber
        {
            get { return GetProperty(_authorizationNumberProperty); }
            set{ SetProperty(_authorizationNumberProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _localeProperty = RegisterProperty< System.String >(p => p.Locale, string.Empty);
        public System.String Locale
        {
            get { return GetProperty(_localeProperty); }
            set{ SetProperty(_localeProperty, value); }
        }

        //AssociatedOneToMany
        private static readonly PropertyInfo< LineItemList > _lineItemsProperty = RegisterProperty<LineItemList>(p => p.LineItems, Csla.RelationshipTypes.Child);
        public LineItemList LineItems
        {
            get
            {
                if(!FieldManager.FieldExists(_lineItemsProperty))
                {
					var criteria = new PetShop.Tests.ParameterizedSQL.LineItemCriteria {OrderId = OrderId};
					

                    if(IsNew || !PetShop.Tests.ParameterizedSQL.LineItemList.Exists(criteria))
                        LoadProperty(_lineItemsProperty, PetShop.Tests.ParameterizedSQL.LineItemList.NewList());
                    else
                        LoadProperty(_lineItemsProperty, PetShop.Tests.ParameterizedSQL.LineItemList.GetByOrderId(OrderId));
                }

                return GetProperty(_lineItemsProperty);
            }
        }

        //AssociatedOneToMany
        private static readonly PropertyInfo< OrderStatusList > _orderStatusesProperty = RegisterProperty<OrderStatusList>(p => p.OrderStatuses, Csla.RelationshipTypes.Child);
        public OrderStatusList OrderStatuses
        {
            get
            {
                if(!FieldManager.FieldExists(_orderStatusesProperty))
                {
					var criteria = new PetShop.Tests.ParameterizedSQL.OrderStatusCriteria {OrderId = OrderId};
					

                    if(IsNew || !PetShop.Tests.ParameterizedSQL.OrderStatusList.Exists(criteria))
                        LoadProperty(_orderStatusesProperty, PetShop.Tests.ParameterizedSQL.OrderStatusList.NewList());
                    else
                        LoadProperty(_orderStatusesProperty, PetShop.Tests.ParameterizedSQL.OrderStatusList.GetByOrderId(OrderId));
                }

                return GetProperty(_orderStatusesProperty);
            }
        }
        #endregion

        #region Synchronous Root Factory Methods 
        
        public static Order NewOrder()
        {
            return DataPortal.Create< Order >();
        }

        public static Order GetByOrderId(System.Int32 orderId)
        {
			var criteria = new OrderCriteria {OrderId = orderId};
			
			
            return DataPortal.Fetch< Order >(criteria);
        }

        public static void DeleteOrder(System.Int32 orderId)
        {
                DataPortal.Delete(new OrderCriteria (orderId));
        }
        
        #endregion

        #region Synchronous Child Factory Methods 
        
        internal static Order NewOrderChild()
        {
            return DataPortal.CreateChild< Order >();
        }
        internal static Order GetByOrderIdChild(System.Int32 orderId)
        {
			var criteria = new OrderCriteria {OrderId = orderId};
			

            return DataPortal.FetchChild< Order >(criteria);
        }

        #endregion


        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(OrderCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(OrderCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region ChildPortal partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(OrderCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(ref bool cancel);
        partial void OnChildSelfDeleted();
        #endregion

        #region Exists Command

        public static bool Exists(OrderCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}
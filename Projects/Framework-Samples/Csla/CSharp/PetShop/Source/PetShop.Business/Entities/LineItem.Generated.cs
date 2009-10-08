//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItem.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;

using Csla;
using Csla.Data;
using Csla.Validation;

#endregion

namespace PetShop.Business
{
	[Serializable]
	public partial class LineItem : BusinessBase< LineItem >
	{
        #region Contructor(s)

		private LineItem()
		{ /* Require use of factory methods */ }
        
        internal LineItem(SafeDataReader reader)
        {
            Fetch(reader);
        }
        
		#endregion
        
		#region Validation Rules
		
		protected override void AddBusinessRules()
		{
            if(AddBusinessValidationRules())
                return;
            
			ValidationRules.AddRule(CommonRules.StringRequired, _itemIdProperty);
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10));
		}
		
		#endregion
		
		#region Business Methods


		private static readonly PropertyInfo< int > _orderIdProperty = RegisterProperty< int >(p => p.OrderId);
		[System.ComponentModel.DataObjectField(true, false)]
		public int OrderId
		{
			get { return GetProperty(_orderIdProperty); }				
            set
            { 
                SetProperty(_orderIdProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< int > _lineNumProperty = RegisterProperty< int >(p => p.LineNum);
		[System.ComponentModel.DataObjectField(true, false)]
		public int LineNum
		{
			get { return GetProperty(_lineNumProperty); }				
            set
            { 
                SetProperty(_lineNumProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< string > _itemIdProperty = RegisterProperty< string >(p => p.ItemId);
		public string ItemId
		{
			get { return GetProperty(_itemIdProperty); }				
            set
            { 
                SetProperty(_itemIdProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< int > _quantityProperty = RegisterProperty< int >(p => p.Quantity);
		public int Quantity
		{
			get { return GetProperty(_quantityProperty); }				
            set
            { 
                SetProperty(_quantityProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< decimal > _unitPriceProperty = RegisterProperty< decimal >(p => p.UnitPrice);
		public decimal UnitPrice
		{
			get { return GetProperty(_unitPriceProperty); }				
            set
            { 
                SetProperty(_unitPriceProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< Order > _orderProperty = RegisterProperty< Order >(p => p.Order, Csla.RelationshipTypes.LazyLoad);
		public Order Order
		{
			get
            {
                if(!FieldManager.FieldExists(_orderProperty))
                    SetProperty(_orderProperty, Order.GetOrder(OrderId));

                   return GetProperty(_orderProperty); 
            }
		}

// NOTE: Many-To-Many support coming soon.
		#endregion
				
		#region Root Factory Methods 
		
		public static LineItem NewLineItem()
		{
			return DataPortal.Create< LineItem >();
		}
		
		public static LineItem GetLineItem(int orderId, int lineNum)
		{
			return DataPortal.Fetch< LineItem >(
                new LineItemCriteria(orderId, lineNum));
		}

        public static LineItem GetLineItem(int orderId)
		{
            return DataPortal.Fetch< LineItem >(
                new LineItemCriteria { OrderId = orderId });
        }

        public static void DeleteLineItem(int orderId, int lineNum)
		{
                DataPortal.Delete(new LineItemCriteria(orderId, lineNum));
		}
		
		#endregion
		
		#region Child Factory Methods 
		
		internal static LineItem NewLineItemChild()
		{
			return DataPortal.CreateChild< LineItem >();
		}
		
		public static LineItem GetLineItemChild(int orderId, int lineNum)
		{
            return DataPortal.FetchChild< LineItem >(
				new LineItemCriteria(orderId, lineNum));
		}

        public static LineItem GetLineItemChild(int orderId)
		{
            return DataPortal.FetchChild< LineItem >(
                new LineItemCriteria { OrderId = orderId });
        }

		#endregion
		
		#region Protected Overriden Method(s)
		
		// NOTE: This is needed for Composite Keys. 
		private readonly Guid _guidID = Guid.NewGuid();
		protected override object GetIdValue()
        {
            return _guidID;
        }
		
		#endregion
	}
}
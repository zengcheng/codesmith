//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Product.cs'.
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
	public partial class Product : BusinessBase< Product >
	{
        #region Contructor(s)

		private Product()
		{ /* Require use of factory methods */ }
        
        internal Product(SafeDataReader reader)
        {
            Fetch(reader);
        }
        
		#endregion
        
		#region Validation Rules
		
		protected override void AddBusinessRules()
		{
            if(AddBusinessValidationRules())
                return;
            
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_nameProperty, 80));
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_descnProperty, 255));
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_imageProperty, 80));
			ValidationRules.AddRule(CommonRules.StringRequired, _categoryIdProperty);
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_categoryIdProperty, 10));
			ValidationRules.AddRule(CommonRules.StringRequired, _productIdProperty);
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_productIdProperty, 10));
		}
		
		#endregion
		
		#region Business Methods


		private static readonly PropertyInfo< string > _productIdProperty = RegisterProperty< string >(p => p.ProductId);
		[System.ComponentModel.DataObjectField(true, false)]
		public string ProductId
		{
			get { return GetProperty(_productIdProperty); }				
            set
            { 
                SetProperty(_productIdProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< string > _nameProperty = RegisterProperty< string >(p => p.Name);
		public string Name
		{
			get { return GetProperty(_nameProperty); }				
            set
            { 
                SetProperty(_nameProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< string > _descnProperty = RegisterProperty< string >(p => p.Descn);
		public string Descn
		{
			get { return GetProperty(_descnProperty); }				
            set
            { 
                SetProperty(_descnProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< string > _imageProperty = RegisterProperty< string >(p => p.Image);
		public string Image
		{
			get { return GetProperty(_imageProperty); }				
            set
            { 
                SetProperty(_imageProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< string > _categoryIdProperty = RegisterProperty< string >(p => p.CategoryId);
		public string CategoryId
		{
			get { return GetProperty(_categoryIdProperty); }				
            set
            { 
                SetProperty(_categoryIdProperty, value); 
            }
		}
		
		private static readonly PropertyInfo< Category > _categoryProperty = RegisterProperty< Category >(p => p.Category, Csla.RelationshipTypes.LazyLoad);
		public Category Category
		{
			get
            {
                if(!FieldManager.FieldExists(_categoryProperty))
                    SetProperty(_categoryProperty, Category.GetCategory(CategoryId));

                   return GetProperty(_categoryProperty); 
            }
		}

// NOTE: Many-To-Many support coming soon.
		private static readonly PropertyInfo< ItemList > _itemsProperty = RegisterProperty<ItemList>(p => p.Items, Csla.RelationshipTypes.LazyLoad);
		public ItemList Items
		{
			get
            {
                if(!FieldManager.FieldExists(_itemsProperty))
                    SetProperty(_itemsProperty, ItemList.GetByProductId(ProductId));

                return GetProperty(_itemsProperty); 
            }
		}

		#endregion
				
		#region Root Factory Methods 
		
		public static Product NewProduct()
		{
			return DataPortal.Create< Product >();
		}
		
		public static Product GetProduct(string productId)
		{
			return DataPortal.Fetch< Product >(
                new ProductCriteria(productId));
		}

        public static void DeleteProduct(string productId)
		{
                DataPortal.Delete(new ProductCriteria(productId));
		}
		
		#endregion
		
		#region Child Factory Methods 
		
		internal static Product NewProductChild()
		{
			return DataPortal.CreateChild< Product >();
		}
		
		public static Product GetProductChild(string productId)
		{
            return DataPortal.FetchChild< Product >(
				new ProductCriteria(productId));
		}

		#endregion
		
	}
}
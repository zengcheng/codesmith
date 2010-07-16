//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Cart.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using Csla;

#endregion

namespace PetShop.Business
{
	[Serializable]
	public partial class CartCriteria : CriteriaBase
	{
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public CartCriteria() : base(typeof(Cart)){}

        public CartCriteria(int cartId) : base(typeof(Cart))
        {
            CartId = cartId;
        }

        
        #endregion
        
		#region Public Properties
        
        #region Read-Write
		
        public int UniqueID
		{
            get { return GetValue< int >("UniqueID"); }				
			set { _bag["UniqueID"] = value; }
		}
		
        public bool IsShoppingCart
		{
            get { return GetValue< bool >("IsShoppingCart"); }				
			set { _bag["IsShoppingCart"] = value; }
		}
		
        public int CartId
		{
            get { return GetValue< int >("CartId"); }				
			set { _bag["CartId"] = value; }
		}

        #endregion
        
        #region Read-Only
        
        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
	    {
	        get
	        {
	            return _bag;
	        }
	    }
        
        #endregion

        #endregion
        
        #region Private Methods
        
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
	}
}
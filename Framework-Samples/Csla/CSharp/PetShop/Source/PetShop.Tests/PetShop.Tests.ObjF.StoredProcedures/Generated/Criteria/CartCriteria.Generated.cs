﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Cart.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


using System.Data.SqlClient;

using Csla;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    public partial class CartCriteria : CriteriaBase, IGeneratedCriteria
    {
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public CartCriteria() : base(typeof(PetShop.Tests.ObjF.StoredProcedures.Cart)){}

        public CartCriteria(System.Int32 cartId) : base(typeof(PetShop.Tests.ObjF.StoredProcedures.Cart))
        {
            CartId = cartId;
        }
        
        #endregion
        
        #region Public Properties
        
        #region Read-Write

        public System.Int32 CartId
        {
            get { return GetValue< System.Int32 >("CartId"); }
            set { _bag["CartId"] = value; }
        }

        public System.Int32 UniqueID
        {
            get { return GetValue< System.Int32 >("UniqueID"); }
            set { _bag["UniqueID"] = value; }
        }

        public System.String ItemId
        {
            get { return GetValue< System.String >("ItemId"); }
            set { _bag["ItemId"] = value; }
        }

        public System.String Name
        {
            get { return GetValue< System.String >("Name"); }
            set { _bag["Name"] = value; }
        }

        public System.String Type
        {
            get { return GetValue< System.String >("Type"); }
            set { _bag["Type"] = value; }
        }

        public System.Decimal Price
        {
            get { return GetValue< System.Decimal >("Price"); }
            set { _bag["Price"] = value; }
        }

        public System.String CategoryId
        {
            get { return GetValue< System.String >("CategoryId"); }
            set { _bag["CategoryId"] = value; }
        }

        public System.String ProductId
        {
            get { return GetValue< System.String >("ProductId"); }
            set { _bag["ProductId"] = value; }
        }

        public System.Boolean IsShoppingCart
        {
            get { return GetValue< System.Boolean >("IsShoppingCart"); }
            set { _bag["IsShoppingCart"] = value; }
        }

        public System.Int32 Quantity
        {
            get { return GetValue< System.Int32 >("Quantity"); }
            set { _bag["Quantity"] = value; }
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

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].Cart";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public override string ToString()
        {
            var result = string.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !string.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += string.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

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
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
    }
}
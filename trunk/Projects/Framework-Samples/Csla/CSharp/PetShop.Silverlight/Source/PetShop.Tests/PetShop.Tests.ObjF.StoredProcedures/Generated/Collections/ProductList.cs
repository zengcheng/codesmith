﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//       Changes to this template will not be lost.
//
//     Template: DynamicRootList.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using Csla;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    public partial class ProductList
    {
        #region Authorization Rules

        protected void AddAuthorizationRules()
        {
            //Csla.Rules.BusinessRules.AddRule(typeof(ProductList), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, "SomeRole"));
            //Csla.Rules.BusinessRules.AddRule(typeof(ProductList), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, "SomeRole"));
            //Csla.Rules.BusinessRules.AddRule(typeof(ProductList), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, "SomeRole", "SomeAdminRole"));
        }
        #endregion

    }
}
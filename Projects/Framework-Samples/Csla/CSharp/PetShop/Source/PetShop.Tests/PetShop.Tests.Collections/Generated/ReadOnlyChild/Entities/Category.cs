//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//       Changes to this template will not be lost.
//
//     Template: ReadOnlyChild.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Security;
using Csla.Validation;

#endregion

namespace PetShop.Tests.Collections.ReadOnlyChild
{
    public partial class Category
    {
        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            //// More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

            //string[] canWrite = { "AdminUser", "RegularUser" };
            //string[] canRead = { "AdminUser", "RegularUser", "ReadOnlyUser" };
            //string[] admin = { "AdminUser" };

            // AuthorizationRules.AllowCreate(typeof(Category), admin);
            // AuthorizationRules.AllowDelete(typeof(Category), admin);
            // AuthorizationRules.AllowEdit(typeof(Category), canWrite);
            // AuthorizationRules.AllowGet(typeof(Category), canRead);

            //// CategoryId
            // AuthorizationRules.AllowRead(_categoryIdProperty, canRead);

            //// Name
            // AuthorizationRules.AllowRead(_nameProperty, canRead);

            //// Descn
            // AuthorizationRules.AllowRead(_descnProperty, canRead);

// NOTE: Many-To-Many support coming soon.
        }

        #endregion
    }
}
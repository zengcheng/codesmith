//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.6.x CodeSmith Templates.
//	   Changes to this template will not be lost.
//
//     Template: EditableChild.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;
using Csla;

#endregion

namespace PetShop.Business
{
	public partial class LineItem
	{
		#region Validation Rules
		
		/// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
		protected bool AddBusinessValidationRules()
		{
			// TODO: add validation rules
			//ValidationRules.AddRule(RuleMethod, "");

		    return false;
		}
		
		#endregion
		
		#region Authorization Rules
		
		protected override void AddAuthorizationRules()
		{
			// TODO: add authorization rules
			//AuthorizationRules.AllowWrite(NameProperty, "Role");
		}
		
		private static void AddObjectAuthorizationRules()
		{
			// TODO: add authorization rules
			//AuthorizationRules.AllowEdit(typeof(LineItem), "Role");
		}
		
		#endregion
	}
}
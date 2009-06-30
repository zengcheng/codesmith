
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.6.x CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ItemList.cs'.
//
//     Template: EditableChildList.DataAccess.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;

using Csla;
using Csla.Data;

using PetShop.Data;
#endregion

namespace PetShop.Business
{
	public partial class ItemList
	{
		#region Data Access
		
        [RunLocal]
        protected override void DataPortal_Create()
        {
        }

		private void Child_Fetch(ItemCriteria criteria)
		{
			RaiseListChangedEvents = false;
			
			using(SafeDataReader reader = DataAccessLayer.Instance.ItemFetch(criteria.StateBag)) 
			{
                while(reader.Read())
				{	
                    this.Add(new PetShop.Business.Item(reader));
				}
			}
			
			RaiseListChangedEvents = true;
		}
		
		#endregion
	}
}
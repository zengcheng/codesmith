
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb.
'
'     Template: EditableChild.DataAccess.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

Imports PetShop.Data

Public Partial Class Cart
		
	#Region "Data Access"
	
	<RunLocal()> _
    Protected Overrides Sub Child_Create()
		' TODO: load default values
		' omit this override if you have no defaults to set
		'MyBase.Child_Create()
    End Sub
	
	Private Sub Child_Fetch(ByVal criteria As Object)
		Dim theCriteria As CartCriteria = DirectCast(criteria, CartCriteria)
        If Not theCriteria Is Nothing Then
			Using reader As SafeDataReader = DataAccessLayer.Instance.CartFetch(theCriteria.StateBag)
				If reader.Read() Then
					Fetch(reader)
				End If
			End Using
		End If
	End Sub
	
	Private Sub Child_Insert()
	    Using reader As SafeDataReader = DataAccessLayer.Instance.CartInsert(ReadProperty(_itemIdProperty), ReadProperty(_nameProperty), ReadProperty(_typeProperty), ReadProperty(_priceProperty), ReadProperty(_categoryIdProperty), ReadProperty(_productIdProperty), ReadProperty(_isShoppingCartProperty), ReadProperty(_quantityProperty), ReadProperty(_uniqueIDProperty))
			If reader.Read() Then

				LoadProperty(_cartIdProperty, reader.GetInt32("CartId"))
			End If
		End Using
	End Sub
	
	Private Sub Child_Update()
        Using reader As SafeDataReader = DataAccessLayer.Instance.CartUpdate(ReadProperty(_cartIdProperty), ReadProperty(_itemIdProperty), ReadProperty(_nameProperty), ReadProperty(_typeProperty), ReadProperty(_priceProperty), ReadProperty(_categoryIdProperty), ReadProperty(_productIdProperty), ReadProperty(_isShoppingCartProperty), ReadProperty(_quantityProperty), ReadProperty(_uniqueIDProperty))
        End Using
	End Sub
	
	Private Sub Child_DeleteSelf()
        DataPortal_Delete(new CartCriteria(CartId))
    End Sub
	
    <Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_Delete(ByVal criteria As Object)
		Dim theCriteria As CartCriteria = DirectCast(criteria, CartCriteria)
        If Not theCriteria Is Nothing Then
			Using reader As SafeDataReader = DataAccessLayer.Instance.CartDelete(theCriteria.StateBag)
			End Using
		End If
    End Sub
    
	Private Sub Fetch(ByVal reader As SafeDataReader)
		LoadProperty(_cartIdProperty, reader.GetInt32("CartId"))
		LoadProperty(_itemIdProperty, reader.GetString("ItemId"))
		LoadProperty(_nameProperty, reader.GetString("Name"))
		LoadProperty(_typeProperty, reader.GetString("Type"))
		LoadProperty(_priceProperty, reader.GetDecimal("Price"))
		LoadProperty(_categoryIdProperty, reader.GetString("CategoryId"))
		LoadProperty(_productIdProperty, reader.GetString("ProductId"))
		LoadProperty(_isShoppingCartProperty, reader.GetBoolean("IsShoppingCart"))
		LoadProperty(_quantityProperty, reader.GetInt32("Quantity"))

		LoadProperty(_uniqueIDProperty, reader.GetInt32("UniqueID"))
        MarkAsChild()
        MarkOld()
    End Sub
	
    #End Region
    
End Class
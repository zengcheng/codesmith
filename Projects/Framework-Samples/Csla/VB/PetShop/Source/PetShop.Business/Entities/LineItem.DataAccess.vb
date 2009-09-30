'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItem.vb.
'
'     Template: SwitchableObject.DataAccess.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

Imports PetShop.Data

Public Partial Class LineItem
	
    #Region "Root Data Access"
	
	<RunLocal()> _
	Protected Overrides Sub DataPortal_Create()
		'MyBase.DataPortal_Create()

		ValidationRules.CheckRules()
	End Sub
	
    <Transactional(TransactionalTypes.TransactionScope)> _
	Private Shadows Sub DataPortal_Fetch(ByVal criteria As LineItemCriteria)
	    Using reader As SafeDataReader = DataAccessLayer.Instance.LineItemFetch(criteria.StateBag)
            If reader.Read() Then
	            Fetch(reader)
            End If
        End Using
    End Sub
	
	<Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_Insert()
		Using reader As SafeDataReader = DataAccessLayer.Instance.LineItemInsert(ReadProperty(_orderIdProperty), ReadProperty(_lineNumProperty), ReadProperty(_itemIdProperty), ReadProperty(_quantityProperty), ReadProperty(_unitPriceProperty))
			If reader.Read() Then

			End If
		End Using
        
        FieldManager.UpdateChildren(Me)
	End Sub
	
	<Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_Update()
        Using reader As SafeDataReader = DataAccessLayer.Instance.LineItemUpdate(ReadProperty(_orderIdProperty), ReadProperty(_lineNumProperty), ReadProperty(_itemIdProperty), ReadProperty(_quantityProperty), ReadProperty(_unitPriceProperty))
        End Using
        
        FieldManager.UpdateChildren(Me)
	End Sub
	
	<Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_DeleteSelf()
        DataPortal_Delete(new LineItemCriteria(OrderId, LineNum))
    End Sub
	
	<Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_Delete(ByVal criteria As Object)
		Dim theCriteria As LineItemCriteria = DirectCast(criteria, LineItemCriteria)
        If Not theCriteria Is Nothing Then
			Using reader As SafeDataReader = DataAccessLayer.Instance.LineItemDelete(theCriteria.StateBag)
			End Using
		End If
    End Sub


	#End Region
	
	#Region "Child Data Access"

	<RunLocal()> _
    Protected Overrides Sub Child_Create()
		' TODO: load default values
		' omit this override if you have no defaults to set
		'MyBase.Child_Create()
    End Sub
	
	Private Sub Child_Fetch(ByVal reader As SafeDataReader)
		Fetch(reader)
        
        MarkAsChild()
	End Sub
	
	Private Sub Child_Insert()
	    Using reader As SafeDataReader = DataAccessLayer.Instance.LineItemInsert(ReadProperty(_orderIdProperty), ReadProperty(_lineNumProperty), ReadProperty(_itemIdProperty), ReadProperty(_quantityProperty), ReadProperty(_unitPriceProperty))
			If reader.Read() Then

			End If
		End Using
	End Sub
	
	Private Sub Child_Update()
        Using reader As SafeDataReader = DataAccessLayer.Instance.LineItemUpdate(ReadProperty(_orderIdProperty), ReadProperty(_lineNumProperty), ReadProperty(_itemIdProperty), ReadProperty(_quantityProperty), ReadProperty(_unitPriceProperty))
        End Using
	End Sub
	
	Private Sub Child_DeleteSelf()
        DataPortal_Delete(new LineItemCriteria(OrderId, LineNum))
    End Sub

	#End Region

    Private Sub Fetch(ByVal reader As SafeDataReader)
		LoadProperty(_orderIdProperty, reader.GetInt32("OrderId"))
		LoadProperty(_lineNumProperty, reader.GetInt32("LineNum"))
		LoadProperty(_itemIdProperty, reader.GetString("ItemId"))
		LoadProperty(_quantityProperty, reader.GetInt32("Quantity"))
		LoadProperty(_unitPriceProperty, reader.GetDecimal("UnitPrice"))

		LoadProperty(_orderIdProperty, reader.GetInt32("OrderId"))

        MarkOld()
    End Sub
    
End Class
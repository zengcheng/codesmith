'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Item.vb.
'
'     Template: SwitchableObject.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Public Partial Class Item

    #Region "Root Data Access"

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()
        LoadProperty(_productIdProperty, "BN")
        ValidationRules.CheckRules()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Private Shadows Sub DataPortal_Fetch(ByVal criteria As ItemCriteria)
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Select]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Insert()
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Insert]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_ItemId", ItemId)
				command.Parameters.AddWithValue("@p_ProductId", ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", ListPrice)
				command.Parameters.AddWithValue("@p_UnitCost", UnitCost)
				command.Parameters.AddWithValue("@p_Supplier", Supplier)
				command.Parameters.AddWithValue("@p_Status", Status)
				command.Parameters.AddWithValue("@p_Name", Name)
				command.Parameters.AddWithValue("@p_Image", Image)

                command.ExecuteNonQuery()
            End Using
        End Using

        FieldManager.UpdateChildren(Me)
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Update()
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Update]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_ItemId", ItemId)
				command.Parameters.AddWithValue("@p_ProductId", ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", ListPrice)
				command.Parameters.AddWithValue("@p_UnitCost", UnitCost)
				command.Parameters.AddWithValue("@p_Supplier", Supplier)
				command.Parameters.AddWithValue("@p_Status", Status)
				command.Parameters.AddWithValue("@p_Name", Name)
				command.Parameters.AddWithValue("@p_Image", Image)

                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
        End Using

        FieldManager.UpdateChildren(Me)
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_DeleteSelf()
        DataPortal_Delete(New ItemCriteria(ItemId))
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Shadows Sub DataPortal_Delete(ByVal criteria As ItemCriteria)
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Delete]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
        End Using
    End Sub

    #End Region

    #Region "Child Data Access"

    <RunLocal()> _
    Protected Overrides Sub Child_Create()
        ' TODO: load default values
        ' omit this override if you have no defaults to set
        'MyBase.Child_Create()
    End Sub
    
    Private Sub Child_Fetch(ByVal criteria As ItemCriteria)
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Select]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using
        MarkAsChild()
    End Sub

    Private Sub Child_Insert(ByVal product As Product, ByVal supplier As Supplier)
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Insert]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_ItemId", ItemId)
				command.Parameters.AddWithValue("@p_ProductId", product.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", ListPrice)
				command.Parameters.AddWithValue("@p_UnitCost", UnitCost)
				command.Parameters.AddWithValue("@p_Supplier", supplier.SuppId)
				command.Parameters.AddWithValue("@p_Status", Status)
				command.Parameters.AddWithValue("@p_Name", Name)
				command.Parameters.AddWithValue("@p_Image", Image)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Child_Update(ByVal product As Product, ByVal supplier As Supplier)
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Update]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_ItemId", ItemId)
				command.Parameters.AddWithValue("@p_ProductId", product.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", ListPrice)
				command.Parameters.AddWithValue("@p_UnitCost", UnitCost)
				command.Parameters.AddWithValue("@p_Supplier", supplier.SuppId)
				command.Parameters.AddWithValue("@p_Status", Status)
				command.Parameters.AddWithValue("@p_Name", Name)
				command.Parameters.AddWithValue("@p_Image", Image)

                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
        End Using
    End Sub

    Private Sub Child_DeleteSelf()
        DataPortal_Delete(New ItemCriteria(ItemId))
    End Sub

    #End Region

    Private Sub Map(ByVal reader As SafeDataReader)
        Using(BypassPropertyChecks)
            LoadProperty(_itemIdProperty, reader.GetString("ItemId"))
            LoadProperty(_productIdProperty, reader.GetString("ProductId"))
            LoadProperty(_listPriceProperty, reader.GetDecimal("ListPrice"))
            LoadProperty(_unitCostProperty, reader.GetDecimal("UnitCost"))
            LoadProperty(_supplierProperty, reader.GetInt32("Supplier"))
            LoadProperty(_statusProperty, reader.GetString("Status"))
            LoadProperty(_nameProperty, reader.GetString("Name"))
            LoadProperty(_imageProperty, reader.GetString("Image"))
        End Using

        MarkOld()
    End Sub
End Class
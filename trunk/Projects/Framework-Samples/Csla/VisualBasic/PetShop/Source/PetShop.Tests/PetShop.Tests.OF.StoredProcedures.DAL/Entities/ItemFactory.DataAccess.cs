'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this template will not be lost.
'
'     Template: ObjectFactory.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
#Region "Using declarations"

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Server

Imports PetShop.Tests.OF.StoredProcedures

#End Region

Public Partial Class ItemFactory
    Inherits ObjectFactory

    #Region "Create"

    ''' <summary>
    ''' Creates New Item with default values.
    ''' </summary>
    ''' <Returns>New Item.</Returns>
    <RunLocal()> _
    Public Function Create() As Item
        Dim item As Item = Activator.CreateInstance(GetType(Item), True)

        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return item
        End If

        Using BypassPropertyChecks(item)
            ' Default values.

        ProductId = "BN"

            CheckRules(item)
            MarkNew(item)
        End Using

        OnCreated()

        Return item
    End Function

    ''' <summary>
    ''' Creates New Item with default values.
    ''' </summary>
    ''' <Returns>New Item.</Returns>
    <RunLocal()> _
    Private Function Create(ByVal criteria As ItemCriteria) As  Item
        Dim item As Item = Activator.CreateInstance(GetType(Item), True)

        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return item
        End If

        Dim resource As Item = Fetch(criteria)

        Using BypassPropertyChecks(item)
            item.ListPrice = resource.ListPrice
            item.UnitCost = resource.UnitCost
            item.Status = resource.Status
            item.Name = resource.Name
            item.Image = resource.Image
        End Using

        CheckRules(item)
        MarkNew(item)

        OnCreated()

        Return item
    End Function

    #End Region

    #Region "Fetch

    ''' <summary>
    ''' Fetch Item.
    ''' </summary>
    ''' <param name="criteria">The criteria.</param>
    ''' <Returns></Returns>
    Public Function Fetch(ByVal criteria As ItemCriteria) As Item
        Dim cancel As Boolean = False
        OnFetching(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim item As Item

        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Select]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        item = Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        MarkOld(item)

        OnFetched()

        Return item
    End Function

    #End Region

    #Region "Insert"

    Private Sub DoInsert(ByVal item As Item, ByVal stopProccessingChildren As Boolean)
        ' Don't update If the item isn't dirty.
        If Not (item.IsDirty) Then
            Return
        End If

        Dim cancel As Boolean = False
        OnInserting(cancel)
        If (cancel) Then
            Return
        End If


        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Item_Insert]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_ItemId", item.ItemId)
				command.Parameters.AddWithValue("@p_ProductId", item.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", item.ListPrice)
				command.Parameters.AddWithValue("@p_UnitCost", item.UnitCost)
				command.Parameters.AddWithValue("@p_Supplier", item.Supplier)
				command.Parameters.AddWithValue("@p_Status", item.Status)
				command.Parameters.AddWithValue("@p_Name", item.Name)
				command.Parameters.AddWithValue("@p_Image", item.Image)

                command.ExecuteNonQuery()
            End Using
        End Using

        MarkOld(item)
        CheckRules(item)
        
        If Not (stopProccessingChildren) Then
            ' Update Child Items.
            ProductUpdate(item)
            SupplierUpdate(item)
        End If

        OnInserted()
    End Sub

    #End Region

    #Region "Update"

    <Transactional(TransactionalTypes.TransactionScope)> _
    Public Function Update(ByVal item As Item, ByVal stopProccessingChildren as Boolean) As Item
        Return Update(item, false)
    End Function

    Public Function Update(ByVal item As Item) As Item
        If(item.IsDeleted) Then
            DoDelete(item)
            MarkNew(item)
        Else If(item.IsNew) Then
            DoInsert(item, stopProccessingChildren)
        Else
           DoUpdate(item, stopProccessingChildren)
        End If

        Return item
    End Function

    Private Sub DoUpdate(ByVal item As Item, ByVal stopProccessingChildren As Boolean)
        Dim cancel As Boolean = False
        OnUpdating(cancel)
        If (cancel) Then
            Return
        End If

        ' Don't update If the item isn't dirty.
        If (item.IsDirty) Then
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Item_Update]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_ItemId", item.ItemId)
				command.Parameters.AddWithValue("@p_ProductId", item.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", item.ListPrice)
				command.Parameters.AddWithValue("@p_UnitCost", item.UnitCost)
				command.Parameters.AddWithValue("@p_Supplier", item.Supplier)
				command.Parameters.AddWithValue("@p_Status", item.Status)
				command.Parameters.AddWithValue("@p_Name", item.Name)
				command.Parameters.AddWithValue("@p_Image", item.Image)

                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using
        End If

        MarkOld(item)
        CheckRules(item)

        If Not (stopProccessingChildren) Then
            ' Update Child Items.
            ProductUpdate(item)
            SupplierUpdate(item)
        End If

        OnUpdated()
    End Sub

    #End Region

    #Region "Delete"

    <Transactional(TransactionalTypes.TransactionScope)> _
    Public Function Delete(ByVal criteria As ItemCriteria)
        ' Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
        DoDelete(criteria)
    End Function

    Protected Sub DoDelete(ByVal item As Item)
        ' If we're not dirty then don't update the database.
        If Not (item.IsDirty) Then
            Return
        End If

        ' If we're New then don't call delete.
        If (item.IsNew) Then
            Return
        End If

        Dim criteria As New ItemCriteria()
criteria.ItemId = itemId
        DoDelete(criteria)

        MarkNew(item)
    End Sub

    Private Sub DoDelete(ByVal criteria As ItemCriteria)
        Dim cancel As Boolean = False
        OnDeleting(criteria, cancel)
        If (cancel) Then
            Return
        End If

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

        OnDeleted()
    End Sub

    #End Region

    #Region "Helper Methods"

    Public Function Map(ByVal reader As SafeDataReader) As Item
        Dim item As Item = Activator.CreateInstance(GetType(Item), True)
        Using BypassPropertyChecks(item)
            item.ItemId = reader.GetString("ItemId")
            item.ProductId = reader.GetString("ProductId")
            item.ListPrice = reader.GetDecimal("ListPrice")
            item.UnitCost = reader.GetDecimal("UnitCost")
            item.Supplier = reader.GetInt32("Supplier")
            item.Status = reader.GetString("Status")
            item.Name = reader.GetString("Name")
            item.Image = reader.GetString("Image")
        End Using

        Return item
    End Function

    'AssociatedManyToOne
    Private Friend Sub ProductUpdate(ByRef item As Item)
		item.ProductMember.ProductId = item.ProductId

        New ProductFactory().Update(item.ProductMember, True)
    End Sub
    'AssociatedManyToOne
    Private Friend Sub SupplierUpdate(ByRef item As Item)
		item.SupplierMember.SuppId = item.Supplier.Value

        New SupplierFactory().Update(item.SupplierMember, True)
    End Sub

    #End Region

    #Region "Data access partial methods"

    Partial Private Sub OnCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnFetching(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnFetched()
    End Sub
    Partial Private Sub OnInserting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnInserted()
    End Sub
    Partial Private Sub OnUpdating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnUpdated()
    End Sub
    Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnSelfDeleted()
    End Sub
    Partial Private Sub OnDeleting(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnDeleted()
    End Sub

    #End Region
End Class
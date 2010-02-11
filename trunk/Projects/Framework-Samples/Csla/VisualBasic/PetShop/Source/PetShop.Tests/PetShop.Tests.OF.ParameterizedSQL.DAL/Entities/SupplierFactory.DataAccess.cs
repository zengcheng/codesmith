'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this template will not be lost.
'
'     Template: ObjectFactory.DataAccess.ParameterizedSQL.cst
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

Imports PetShop.Tests.OF.ParameterizedSQL

#End Region

Public Partial Class SupplierFactory
    Inherits ObjectFactory

    #Region "Create"

    ''' <summary>
    ''' Creates New Supplier with default values.
    ''' </summary>
    ''' <Returns>New Supplier.</Returns>
    <RunLocal()> _
    Public Function Create() As Supplier
        Dim item As Supplier = Activator.CreateInstance(GetType(Supplier), True)

        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return item
        End If

        Using BypassPropertyChecks(item)
            ' Default values.


            CheckRules(item)
            MarkNew(item)
        End Using

        OnCreated()

        Return item
    End Function

    ''' <summary>
    ''' Creates New Supplier with default values.
    ''' </summary>
    ''' <Returns>New Supplier.</Returns>
    <RunLocal()> _
    Private Function Create(ByVal criteria As SupplierCriteria) As  Supplier
        Dim item As Supplier = Activator.CreateInstance(GetType(Supplier), True)

        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return item
        End If

        Dim resource As Supplier = Fetch(criteria)

        Using BypassPropertyChecks(item)
            item.Name = resource.Name
            item.Status = resource.Status
            item.Addr1 = resource.Addr1
            item.Addr2 = resource.Addr2
            item.City = resource.City
            item.State = resource.State
            item.Zip = resource.Zip
            item.Phone = resource.Phone
        End Using

        CheckRules(item)
        MarkNew(item)

        OnCreated()

        Return item
    End Function

    #End Region

    #Region "Fetch

    ''' <summary>
    ''' Fetch Supplier.
    ''' </summary>
    ''' <param name="criteria">The criteria.</param>
    ''' <Returns></Returns>
    Public Function Fetch(ByVal criteria As SupplierCriteria) As Supplier
        Dim cancel As Boolean = False
        OnFetching(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim item As Supplier

        Dim commandText As String = String.Format("SELECT [SuppId], [Name], [Status], [Addr1], [Addr2], [City], [State], [Zip], [Phone] FROM [dbo].[Supplier] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        item = Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Supplier' using the following criteria: {0}.", criteria))
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

    Private Sub DoInsert(ByVal item As Supplier, ByVal stopProccessingChildren As Boolean)
        ' Don't update If the item isn't dirty.
        If Not (item.IsDirty) Then
            Return
        End If

        Dim cancel As Boolean = False
        OnInserting(cancel)
        If (cancel) Then
            Return
        End If

        Const commandText As String = "INSERT INTO [dbo].[Supplier] ([SuppId], [Name], [Status], [Addr1], [Addr2], [City], [State], [Zip], [Phone]) VALUES (@p_SuppId, @p_Name, @p_Status, @p_Addr1, @p_Addr2, @p_City, @p_State, @p_Zip, @p_Phone)"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_SuppId", item.SuppId)
				command.Parameters.AddWithValue("@p_Name", item.Name)
				command.Parameters.AddWithValue("@p_Status", item.Status)
				command.Parameters.AddWithValue("@p_Addr1", item.Addr1)
				command.Parameters.AddWithValue("@p_Addr2", item.Addr2)
				command.Parameters.AddWithValue("@p_City", item.City)
				command.Parameters.AddWithValue("@p_State", item.State)
				command.Parameters.AddWithValue("@p_Zip", item.Zip)
				command.Parameters.AddWithValue("@p_Phone", item.Phone)

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then

                    End If
                End Using
            End Using
        End Using

        MarkOld(item)
        CheckRules(item)
        
        If Not (stopProccessingChildren) Then
            ' Update Child Items.
            ItemUpdate(item)
        End If

        OnInserted()
    End Sub

    #End Region

    #Region "Update"

    <Transactional(TransactionalTypes.TransactionScope)> _
    Public Function Update(ByVal item As Supplier, ByVal stopProccessingChildren as Boolean) As Supplier
        Return Update(item, false)
    End Function

    Public Function Update(ByVal item As Supplier) As Supplier
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

    Private Sub DoUpdate(ByVal item As Supplier, ByVal stopProccessingChildren As Boolean)
        Dim cancel As Boolean = False
        OnUpdating(cancel)
        If (cancel) Then
            Return
        End If

        ' Don't update If the item isn't dirty.
        If (item.IsDirty) Then
            Const commandText As String = "UPDATE [dbo].[Supplier]  SET [SuppId] = @p_SuppId, [Name] = @p_Name, [Status] = @p_Status, [Addr1] = @p_Addr1, [Addr2] = @p_Addr2, [City] = @p_City, [State] = @p_State, [Zip] = @p_Zip, [Phone] = @p_Phone WHERE [SuppId] = @p_SuppId"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_SuppId", item.SuppId)
				command.Parameters.AddWithValue("@p_Name", item.Name)
				command.Parameters.AddWithValue("@p_Status", item.Status)
				command.Parameters.AddWithValue("@p_Addr1", item.Addr1)
				command.Parameters.AddWithValue("@p_Addr2", item.Addr2)
				command.Parameters.AddWithValue("@p_City", item.City)
				command.Parameters.AddWithValue("@p_State", item.State)
				command.Parameters.AddWithValue("@p_Zip", item.Zip)
				command.Parameters.AddWithValue("@p_Phone", item.Phone)

                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        If reader.RecordsAffected = 0 Then
                            Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                        End If
                    End Using
                End Using
            End Using
        End If

        MarkOld(item)
        CheckRules(item)

        If Not (stopProccessingChildren) Then
            ' Update Child Items.
            ItemUpdate(item)
        End If

        OnUpdated()
    End Sub

    #End Region

    #Region "Delete"

    <Transactional(TransactionalTypes.TransactionScope)> _
    Public Function Delete(ByVal criteria As SupplierCriteria)
        ' Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
        DoDelete(criteria)
    End Function

    Protected Sub DoDelete(ByVal item As Supplier)
        ' If we're not dirty then don't update the database.
        If Not (item.IsDirty) Then
            Return
        End If

        ' If we're New then don't call delete.
        If (item.IsNew) Then
            Return
        End If

        Dim criteria As New SupplierCriteria()
criteria.SuppId = suppId
        DoDelete(criteria)

        MarkNew(item)
    End Sub

    Private Sub DoDelete(ByVal criteria As SupplierCriteria)
        Dim cancel As Boolean = False
        OnDeleting(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("DELETE FROM [dbo].[Supplier] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
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

    Public Function Map(ByVal reader As SafeDataReader) As Supplier
        Dim item As Supplier = Activator.CreateInstance(GetType(Supplier), True)
        Using BypassPropertyChecks(item)
            item.SuppId = reader.GetInt32("SuppId")
            item.Name = reader.GetString("Name")
            item.Status = reader.GetString("Status")
            item.Addr1 = reader.GetString("Addr1")
            item.Addr2 = reader.GetString("Addr2")
            item.City = reader.GetString("City")
            item.State = reader.GetString("State")
            item.Zip = reader.GetString("Zip")
            item.Phone = reader.GetString("Phone")

            item.Items = New ItemList.NewList()
        End Using

        Return item
    End Function

    'AssociatedOneToMany
    Private Friend Sub ItemUpdate(ByRef item As Supplier)
        For Each itemToUpdate As Item In item.Items
		itemToUpdate.Supplier = item.SuppId

            New ItemFactory().Update(itemToUpdate, True)
        Next
    End Sub

    #End Region

    #Region "Data access partial methods"

    Partial Private Sub OnCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnFetching(ByVal criteria As SupplierCriteria, ByRef cancel As Boolean)
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
    Partial Private Sub OnDeleting(ByVal criteria As SupplierCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnDeleted()
    End Sub

    #End Region
End Class
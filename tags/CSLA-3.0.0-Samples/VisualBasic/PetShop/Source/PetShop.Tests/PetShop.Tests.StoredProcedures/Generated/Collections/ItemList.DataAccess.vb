﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'ItemList.vb.
'
'     Template: EditableChildList.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Imports Csla
Imports Csla.Data
Imports Csla.Validation

Namespace PetShop.Tests.StoredProcedures
    Public Partial Class ItemList
    
        Protected Overrides Sub Child_Create()
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            OnCreated()
        End Sub
    
        Private Shadows Sub Child_Fetch(ByVal criteria As ItemCriteria)
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            RaiseListChangedEvents = False
    
            ' Fetch Child objects.
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Item_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    command.Parameters.AddWithValue("@p_ListPriceHasValue", criteria.ListPriceHasValue)
					command.Parameters.AddWithValue("@p_UnitCostHasValue", criteria.UnitCostHasValue)
					command.Parameters.AddWithValue("@p_SupplierHasValue", criteria.SupplierHasValue)
					command.Parameters.AddWithValue("@p_StatusHasValue", criteria.StatusHasValue)
					command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue)
					command.Parameters.AddWithValue("@p_ImageHasValue", criteria.ImageHasValue)
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Do
                                Me.Add(New PetShop.Tests.StoredProcedures.Item(reader))
                            Loop While reader.Read()
                        End If
                    End Using
                End Using
            End Using
    
            RaiseListChangedEvents = True
    
            OnFetched()
        End Sub
    
        ''' <summary>
        ''' Updates the child object.
        ''' </summary>
        ''' <param name="parameters">The parameters collection may contain more parameters than needed based on the context it was called. We need to filter this list.</param>
        Protected Overrides Sub Child_Update(ParamArray parameters As Object())
        Dim cancel As Boolean = False
        OnUpdating(cancel)
        If cancel Then
            Return
        End If
    
        ' We require that one of the parameters be a connection so we can do the CRUD operations.
        Dim connection As SqlConnection = parameters.OfType(Of SqlConnection)().FirstOrDefault()
        If connection Is Nothing Then
            Throw New ArgumentNullException("parameters", "Must contain a SqlConnection parameter.")
        End If
    
        RaiseListChangedEvents = False
    
        For Each item As Item In DeletedList
            DataPortal.UpdateChild(item, connection)
        Next
    
        DeletedList.Clear()
        
        ' Trim down the list to what is actually contained in the child class.
        Dim list As New System.Collections.Generic.Dictionary(Of String, Object)
        Dim key As String
        For Each o As Object In parameters
            If Not o Is Nothing Then
                key = o.GetType().ToString()
                If Not list.ContainsKey(key) Then
                    list.Add(key, o)
                End If
            End If
        Next
    
        For Each item As Item In Items
            DataPortal.UpdateChild(item, list.Values.ToArray())
        Next
    
        RaiseListChangedEvents = True
    
        OnUpdated()
        End Sub
    End Class
End Namespace
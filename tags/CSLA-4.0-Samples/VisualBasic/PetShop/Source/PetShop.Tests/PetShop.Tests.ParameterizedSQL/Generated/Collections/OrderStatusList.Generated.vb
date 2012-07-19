﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatusList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Linq

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.ParameterizedSQL
    <Serializable()> _
    Public Partial Class OrderStatusList 
        Inherits BusinessListBase(Of OrderStatusList, OrderStatus)
    
#Region "Contructor(s)"


        public Sub New()
            AllowNew = true
        End Sub

#End Region

#Region "Method Overrides"

        Protected Overrides Function AddNewCore() As OrderStatus
            Dim item As OrderStatus = PetShop.Tests.ParameterizedSQL.OrderStatus.NewOrderStatus()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null In the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.ParameterizedSQL.OrderStatus.NewOrderStatus()
                End If
            ' Pass the parent value down to the child.
                Dim order As Order = CType(Me.Parent, Order)
                If Not(order Is Nothing)
                    item.OrderId = order.OrderId
                End If
                Add(item)
            End If

            Return item
        End Function

#End Region

#Region "Synchronous Factory Methods"

        ''' <summary>
        ''' Creates a new object of type <see cref="OrderStatusList"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="OrderStatusList"/>.</returns>
        Public Shared Function NewList() As OrderStatusList
            Return DataPortal.Create(Of OrderStatusList)()
        End Function
    
        ''' <summary>
        ''' Returns a <see cref="OrderStatusList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <param name="lineNum">No additional detail available.</param>
        ''' <returns>A <see cref="OrderStatusList"/> object of the specified criteria.</returns>
        Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatusList 
            Dim criteria As New OrderStatusCriteria()
                        criteria.OrderId = orderId
            criteria.LineNum = lineNum
    
            Return DataPortal.Fetch(Of OrderStatusList)(criteria)
        End Function
    
        ''' <summary>
        ''' Returns a <see cref="OrderStatusList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <returns>A <see cref="OrderStatusList"/> object of the specified criteria.</returns>
        Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As OrderStatusList 
            Dim criteria As New OrderStatusCriteria()
                        criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of OrderStatusList)(criteria)
        End Function

        Public Shared Function GetByCriteria(ByVal criteria As OrderStatusCriteria) As OrderStatusList
            Return DataPortal.Fetch(Of OrderStatusList)(criteria)
        End Function

        Public Shared Function GetAll() As OrderStatusList
            Return DataPortal.Fetch(Of OrderStatusList)(New OrderStatusCriteria())
        End Function

#End Region

#Region "Asynchronous Factory Methods"
            
        Public Shared Sub NewListAsync(ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatusList)))
            Dim dp As New DataPortal(Of OrderStatusList)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByOrderIdLineNumAsync(ByVal orderId As System.Int32, ByVal lineNum As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatusList)))
            Dim dp As New DataPortal(Of OrderStatusList)()
            AddHandler dp.FetchCompleted, handler
    
            Dim criteria As New OrderStatusCriteria()
            criteria.OrderId = orderId
            criteria.LineNum = lineNum
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetByOrderIdAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatusList)))
            Dim dp As New DataPortal(Of OrderStatusList)()
            AddHandler dp.FetchCompleted, handler
    
            Dim criteria As New OrderStatusCriteria()
            criteria.OrderId = orderId
    
            dp.BeginFetch(criteria)
        End Sub

        Public Shared Sub GetByCriteriaAsync(ByVal criteria As OrderStatusCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatusList)))
            Dim dp As New DataPortal(Of OrderStatusList)()
            AddHandler dp.FetchCompleted, handler

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Public Shared Sub GetAllAsync(ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatusList)))
            Dim dp As New DataPortal(Of OrderStatusList)()
            AddHandler dp.FetchCompleted, handler
            dp.BeginFetch(New OrderStatusCriteria())
        End Sub

#End Region

#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' CodeSmith generated stub method that is called when creating the child <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="OrderStatus"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when fetching the child <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderStatusCriteria"/> object containing the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="OrderStatus"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="OrderStatus"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByRef item As OrderStatus, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the OrderStatus in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is a <see cref="OrderStatusList"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As OrderStatusCriteria) As Boolean
            Return PetShop.Tests.ParameterizedSQL.OrderStatus.Exists(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the OrderStatus in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As OrderStatusCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.ParameterizedSQL.OrderStatus.ExistsAsync(criteria, handler)
        End Sub

#End Region
 
#region "Enhancements"

        Public Function GetOrderStatus(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatus
            Return Me.FirstOrDefault(Function(i As OrderStatus) i.OrderId = orderId AndAlso i.LineNum = lineNum)
        End Function
        
        Public Overloads Function Contains(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As Boolean
            Return Me.Where(Function(i As OrderStatus) i.OrderId = orderId AndAlso i.LineNum = lineNum).Count() > 0
        End Function

        Public Overloads Function ContainsDeleted(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As Boolean
            Return DeletedList.Where(Function(i As OrderStatus) i.OrderId = orderId AndAlso i.LineNum = lineNum).Count() > 0
        End Function

        Public Overloads Sub Remove(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
            Dim item As OrderStatus = Me.FirstOrDefault(Function(i As OrderStatus) i.OrderId = orderId AndAlso i.LineNum = lineNum)
            If item IsNot Nothing Then
                Remove(item)
            End If
        End Sub
        
#End Region
    End Class
End Namespace
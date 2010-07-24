﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatus.vb.
'
'     Template: EditableChild.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Rules
Imports Csla.Data
Imports System.Data.SqlClient

Namespace PetShop.Tests.StoredProcedures
    <Serializable()> _
    Public Partial Class OrderStatus
        Inherits BusinessBase(Of OrderStatus)
    
#Region "Contructor(s)"
    
        Private Sub New()
            ' require use of factory method.
            MarkAsChild()
        End Sub
    
        Friend Sub New(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
            Using(BypassPropertyChecks)
                _orderId = orderId
                _lineNum = lineNum
            End Using
    
            MarkAsChild()
        End Sub
    
        Friend Sub New(Byval reader As SafeDataReader)
            Map(reader)
    
            MarkAsChild()
        End Sub
#End Region    
    
#Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
    
            If AddBusinessValidationRules() Then Exit Sub
    
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_statusProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_statusProperty, 2))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.OrderId, String.Empty)
        Private _orderId As System.Int32 = _orderIdProperty.DefaultValue
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property OrderId() As System.Int32
            Get 
                Return GetProperty(_orderIdProperty, _orderId) 
            End Get
            Set (value As System.Int32)
                SetProperty(_orderIdProperty, _orderId, value)
            End Set
        End Property

        Private Shared ReadOnly _originalOrderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.OriginalOrderId, String.Empty)
        Private _originalOrderId As System.Int32 = _originalOrderIdProperty.DefaultValue
        ''' <summary>
        ''' Holds the original value for OrderId. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalOrderId() As System.Int32
            Get 
                Return GetProperty(_originalOrderIdProperty, _originalOrderId) 
            End Get
            Set (value As System.Int32)
                SetProperty(_originalOrderIdProperty, _originalOrderId, value)
            End Set
        End Property

        Private Shared ReadOnly _lineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.LineNum, String.Empty)
        Private _lineNum As System.Int32 = _lineNumProperty.DefaultValue
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property LineNum() As System.Int32
            Get 
                Return GetProperty(_lineNumProperty, _lineNum) 
            End Get
            Set (value As System.Int32)
                SetProperty(_lineNumProperty, _lineNum, value)
            End Set
        End Property

        Private Shared ReadOnly _originalLineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.OriginalLineNum, String.Empty)
        Private _originalLineNum As System.Int32 = _originalLineNumProperty.DefaultValue
        ''' <summary>
        ''' Holds the original value for LineNum. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalLineNum() As System.Int32
            Get 
                Return GetProperty(_originalLineNumProperty, _originalLineNum) 
            End Get
            Set (value As System.Int32)
                SetProperty(_originalLineNumProperty, _originalLineNum, value)
            End Set
        End Property

        Private Shared ReadOnly _timestampProperty As PropertyInfo(Of System.DateTime) = RegisterProperty(Of System.DateTime)(Function(p As OrderStatus) p.Timestamp, String.Empty)
        Private _timestamp As System.DateTime = _timestampProperty.DefaultValue
        
        Public Property Timestamp() As System.DateTime
            Get 
                Return GetProperty(_timestampProperty, _timestamp) 
            End Get
            Set (value As System.DateTime)
                SetProperty(_timestampProperty, _timestamp, value)
            End Set
        End Property

        Private Shared ReadOnly _statusProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As OrderStatus) p.Status, String.Empty)
        Private _status As System.String = _statusProperty.DefaultValue
        
        Public Property Status() As System.String
            Get 
                Return GetProperty(_statusProperty, _status) 
            End Get
            Set (value As System.String)
                SetProperty(_statusProperty, _status, value)
            End Set
        End Property

        'AssociatedManyToOne
        Private Shared ReadOnly _orderMemberProperty As PropertyInfo(Of Order) = RegisterProperty(Of Order)(Function(p As OrderStatus) p.OrderMember, Csla.RelationshipTypes.Child)
        Public ReadOnly Property OrderMember() As Order
            Get
                If(False) Then
                    Return Nothing
                End If
    
                If Not(FieldManager.FieldExists(_orderMemberProperty))
                    Dim criteria As New PetShop.Tests.StoredProcedures.OrderCriteria()
                    criteria.OrderId = OrderId

                    If (PetShop.Tests.StoredProcedures.Order.Exists(criteria)) Then
                        LoadProperty(_orderMemberProperty, PetShop.Tests.StoredProcedures.Order.GetByOrderId(OrderId))
                    End If
                End If
                
                Return GetProperty(_orderMemberProperty) 
            End Get
        End Property 

#End Region
    
#Region "Synchronous Factory Methods"

        Friend Shared Function NewOrderStatus() As OrderStatus 
            Return DataPortal.Create(Of OrderStatus)()
        End Function
    
        Friend Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatus
            Dim criteria As New OrderStatusCriteria()
            criteria.OrderId = orderId
			criteria.LineNum = lineNum
    
            Return DataPortal.FetchChild(Of OrderStatus)(criteria)
        End Function
    
        Friend Shared Function GetByOrderId(ByVal orderId As System.Int32) As OrderStatus
            Dim criteria As New OrderStatusCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.FetchChild(Of OrderStatus)(criteria)
        End Function
    
#End Region
    
#Region "ChildPortal partial methods"
    
        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildCreated()
        End Sub
        Partial Private Sub OnChildFetching(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildInserted()
        End Sub
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildUpdated()
        End Sub
        Partial Private Sub OnChildSelfDeleting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildSelfDeleted()
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As OrderStatusCriteria, ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As OrderStatusCriteria ) As Boolean
            Return PetShop.Tests.StoredProcedures.ExistsCommand.Execute(criteria)
        End Function

#End Region

#Region "Protected Overriden Method(s)"
        
        ' NOTE: This is needed for Composite Keys. 
        Private ReadOnly _guidID As Guid = Guid.NewGuid()
        Protected Overrides Function GetIdValue() As Object
            Return _guidID
        End Function
        
#End Region
    End Class
End Namespace

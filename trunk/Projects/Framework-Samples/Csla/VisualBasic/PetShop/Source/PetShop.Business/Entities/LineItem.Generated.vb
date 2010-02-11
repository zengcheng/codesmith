'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItem.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data
Imports Csla.Validation

<Serializable()> _
Public Partial Class LineItem 
    Inherits BusinessBase(Of LineItem)

    #Region "Contructor(s)"

    Private Sub New()
        ' require use of factory method 
    End Sub

    Private Sub New(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
        Using(BypassPropertyChecks)
           LoadProperty(_orderIdProperty, orderId)
           LoadProperty(_lineNumProperty, lineNum)
        End Using
    End Sub

    Friend Sub New(Byval reader As SafeDataReader)
        Map(reader)
    End Sub

    #End Region
    #Region "Validation Rules"

    Protected Overrides Sub AddBusinessRules()

        If AddBusinessValidationRules() Then Exit Sub

        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _itemIdProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10))
    End Sub

    #End Region

    #Region "Properties"

    
    Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OrderId)
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property OrderId() As System.Int32
        Get 
            Return GetProperty(_orderIdProperty)
        End Get
        Set (ByVal value As System.Int32)
            SetProperty(_orderIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _lineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.LineNum)
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property LineNum() As System.Int32
        Get 
            Return GetProperty(_lineNumProperty)
        End Get
        Set (ByVal value As System.Int32)
            SetProperty(_lineNumProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As LineItem) p.ItemId)
    Public Property ItemId() As System.String
        Get 
            Return GetProperty(_itemIdProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_itemIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _quantityProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.Quantity)
    Public Property Quantity() As System.Int32
        Get 
            Return GetProperty(_quantityProperty)
        End Get
        Set (ByVal value As System.Int32)
            SetProperty(_quantityProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _unitPriceProperty As PropertyInfo(Of System.Decimal) = RegisterProperty(Of System.Decimal)(Function(p As LineItem) p.UnitPrice)
    Public Property UnitPrice() As System.Decimal
        Get 
            Return GetProperty(_unitPriceProperty)
        End Get
        Set (ByVal value As System.Decimal)
            SetProperty(_unitPriceProperty, value)
        End Set
    End Property
    
    'ManyToOne
    Private Shared ReadOnly _orderMemberProperty As PropertyInfo(Of Order) = RegisterProperty(Of Order)(Function(p As LineItem) p.OrderMember, Csla.RelationshipTypes.Child)
    Public ReadOnly Property OrderMember() As Order
        Get
            If Not(FieldManager.FieldExists(_orderMemberProperty))
                Dim criteria As New PetShop.Business.OrderCriteria()
                criteria.OrderId = OrderId
                
                If (Me.IsNew Or Not PetShop.Business.Order.Exists(criteria)) Then
                    LoadProperty(_orderMemberProperty, PetShop.Business.Order.NewOrder())
                Else
                    LoadProperty(_orderMemberProperty, PetShop.Business.Order.GetByOrderId(OrderId))
                End If
            End If
            
            Return GetProperty(_orderMemberProperty) 
        End Get
    End Property
    
    #End Region

    #Region "Root Factory Methods"

    Public Shared Function NewLineItem() As LineItem 
        Return DataPortal.Create(Of LineItem)()
    End Function

    Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItem 
        Dim criteria As New LineItemCriteria ()
        criteria.OrderId = orderId
		criteria.LineNum = lineNum

        Return DataPortal.Fetch(Of LineItem)(criteria)
    End Function

    Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As LineItem 
        Dim criteria As New LineItemCriteria ()
        criteria.OrderId = orderId

        Return DataPortal.Fetch(Of LineItem)(criteria)
    End Function

    Public Shared Sub DeleteLineItem(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
        DataPortal.Delete(New LineItemCriteria (orderId, lineNum))
    End Sub

    #End Region

    #Region "Child Factory Methods"

    Friend Shared Function NewLineItemChild() As LineItem
        Return DataPortal.CreateChild(Of LineItem)()
    End Function

    Friend Shared Function GetByOrderIdLineNumChild(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItem 
        Dim criteria As New LineItemCriteria ()
        criteria.OrderId = orderId
        criteria.LineNum = lineNum

        Return DataPortal.FetchChild(Of LineItem)(criteria)
    End Function

    Friend Shared Function GetByOrderIdChild(ByVal orderId As System.Int32) As LineItem 
        Dim criteria As New LineItemCriteria ()
        criteria.OrderId = orderId

        Return DataPortal.FetchChild(Of LineItem)(criteria)
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As LineItemCriteria ) As Boolean
        Return ExistsCommand.Execute(criteria)
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
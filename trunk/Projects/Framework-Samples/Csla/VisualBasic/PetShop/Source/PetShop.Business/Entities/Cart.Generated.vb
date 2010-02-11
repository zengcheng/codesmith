'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb.
'
'     Template: EditableChild.Generated.cst
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
Public Partial Class Cart 
    Inherits BusinessBase(Of Cart)

    #Region "Contructor(s)"

    Private Sub New()
        ' require use of factory method
        MarkAsChild()
    End Sub

    Private Sub New(ByVal cartId As System.Int32)
        Using(BypassPropertyChecks)
           LoadProperty(_cartIdProperty, cartId)
        End Using

        MarkAsChild()
    End Sub

    Friend Sub New(Byval reader As SafeDataReader)
        Map(reader)

        MarkAsChild()
    End Sub

    #End Region
    #Region "Validation Rules"

    Protected Overrides Sub AddBusinessRules()

        If AddBusinessValidationRules() Then Exit Sub

        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _itemIdProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10))
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _nameProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_nameProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _typeProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_typeProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _categoryIdProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_categoryIdProperty, 10))
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _productIdProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_productIdProperty, 10))
    End Sub

    #End Region

    #Region "Properties"

    
    Private Shared ReadOnly _cartIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Cart) p.CartId)
		<System.ComponentModel.DataObjectField(true, true)> _
    Public Property CartId() As System.Int32
        Get 
            Return GetProperty(_cartIdProperty)
        End Get
        Friend Set (ByVal value As System.Int32)
            SetProperty(_cartIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _uniqueIDProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Cart) p.UniqueID)
    Public Property UniqueID() As System.Int32
        Get 
            Return GetProperty(_uniqueIDProperty)
        End Get
        Set (ByVal value As System.Int32)
            SetProperty(_uniqueIDProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.ItemId)
    Public Property ItemId() As System.String
        Get 
            Return GetProperty(_itemIdProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_itemIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.Name)
    Public Property Name() As System.String
        Get 
            Return GetProperty(_nameProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_nameProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _typeProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.Type)
    Public Property Type() As System.String
        Get 
            Return GetProperty(_typeProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_typeProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _priceProperty As PropertyInfo(Of System.Decimal) = RegisterProperty(Of System.Decimal)(Function(p As Cart) p.Price)
    Public Property Price() As System.Decimal
        Get 
            Return GetProperty(_priceProperty)
        End Get
        Set (ByVal value As System.Decimal)
            SetProperty(_priceProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _categoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.CategoryId)
    Public Property CategoryId() As System.String
        Get 
            Return GetProperty(_categoryIdProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_categoryIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _productIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.ProductId)
    Public Property ProductId() As System.String
        Get 
            Return GetProperty(_productIdProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_productIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _isShoppingCartProperty As PropertyInfo(Of System.Boolean) = RegisterProperty(Of System.Boolean)(Function(p As Cart) p.IsShoppingCart)
    Public Property IsShoppingCart() As System.Boolean
        Get 
            Return GetProperty(_isShoppingCartProperty)
        End Get
        Set (ByVal value As System.Boolean)
            SetProperty(_isShoppingCartProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _quantityProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Cart) p.Quantity)
    Public Property Quantity() As System.Int32
        Get 
            Return GetProperty(_quantityProperty)
        End Get
        Set (ByVal value As System.Int32)
            SetProperty(_quantityProperty, value)
        End Set
    End Property
    
    'ManyToOne
    Private Shared ReadOnly _profileMemberProperty As PropertyInfo(Of Profile) = RegisterProperty(Of Profile)(Function(p As Cart) p.ProfileMember, Csla.RelationshipTypes.Child)
    Public ReadOnly Property ProfileMember() As Profile
        Get
            If Not(FieldManager.FieldExists(_profileMemberProperty))
                Dim criteria As New PetShop.Business.ProfileCriteria()
                criteria.UniqueID = UniqueID
                
                If (Me.IsNew Or Not PetShop.Business.Profile.Exists(criteria)) Then
                    LoadProperty(_profileMemberProperty, PetShop.Business.Profile.NewProfile())
                Else
                    LoadProperty(_profileMemberProperty, PetShop.Business.Profile.GetByUniqueID(UniqueID))
                End If
            End If
            
            Return GetProperty(_profileMemberProperty) 
        End Get
    End Property
    
    #End Region

    #Region "Factory Methods"

    Friend Shared Function NewCart() As Cart 
        Return DataPortal.Create(Of Cart)()
    End Function

    Friend Shared Function GetByCartId(ByVal cartId As System.Int32) As Cart 
        Dim criteria As New CartCriteria ()
		criteria.CartId = cartId

        Return DataPortal.FetchChild(Of Cart)(criteria)
    End Function

    Friend Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As Cart 
        Dim criteria As New CartCriteria ()
		criteria.UniqueID = uniqueID

        Return DataPortal.FetchChild(Of Cart)(criteria)
    End Function

    Friend Shared Function GetByIsShoppingCart(ByVal isShoppingCart As System.Boolean) As Cart 
        Dim criteria As New CartCriteria ()
		criteria.IsShoppingCart = isShoppingCart

        Return DataPortal.FetchChild(Of Cart)(criteria)
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As CartCriteria ) As Boolean
        Return ExistsCommand.Execute(criteria)
    End Function

    #End Region


End Class

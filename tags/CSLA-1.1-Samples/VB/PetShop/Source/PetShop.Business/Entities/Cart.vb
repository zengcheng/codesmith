'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'	   Changes to this template will not be lost.
'
'     Template: EditableChild.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Validation

Public Partial Class Cart

	#Region "Validation Rules"
	
	''' <summary>
    ''' All custom rules need to be placed in this method.
    ''' </summary>
    ''' <Returns>Return true to override the generated rules If false generated rules will be run.</Returns>
	Protected Function AddBusinessValidationRules() As Boolean
	
		' TODO: add validation rules
		'ValidationRules.AddRule(RuleMethod, "")

	    Return False
	
	End Function
	
	#End Region
	
	#Region "Authorization Rules"
	
	Protected Overrides Sub AddAuthorizationRules()
		'Dim canWrite As String() = { "AdminUser", "RegularUser" }
        'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
        'Dim admin As String() = { "AdminUser" }

        'AuthorizationRules.AllowCreate(GetType(Cart), admin)
        'AuthorizationRules.AllowDelete(GetType(Cart), admin)
        'AuthorizationRules.AllowEdit(GetType(Cart), canWrite)
        'AuthorizationRules.AllowGet(GetType(Cart), canRead)

        'CartId
        'AuthorizationRules.AllowRead(_cartIdProperty, canRead)
        
        'ItemId
        'AuthorizationRules.AllowWrite(_itemIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_itemIdProperty, canRead)
        
        'Name
        'AuthorizationRules.AllowWrite(_nameProperty, canWrite)
        'AuthorizationRules.AllowRead(_nameProperty, canRead)
        
        'Type
        'AuthorizationRules.AllowWrite(_typeProperty, canWrite)
        'AuthorizationRules.AllowRead(_typeProperty, canRead)
        
        'Price
        'AuthorizationRules.AllowWrite(_priceProperty, canWrite)
        'AuthorizationRules.AllowRead(_priceProperty, canRead)
        
        'CategoryId
        'AuthorizationRules.AllowWrite(_categoryIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_categoryIdProperty, canRead)
        
        'ProductId
        'AuthorizationRules.AllowWrite(_productIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_productIdProperty, canRead)
        
        'IsShoppingCart
        'AuthorizationRules.AllowWrite(_isShoppingCartProperty, canWrite)
        'AuthorizationRules.AllowRead(_isShoppingCartProperty, canRead)
        
        'Quantity
        'AuthorizationRules.AllowWrite(_quantityProperty, canWrite)
        'AuthorizationRules.AllowRead(_quantityProperty, canRead)
        
        'UniqueID
        'AuthorizationRules.AllowWrite(_uniqueIDProperty, canWrite)
        'AuthorizationRules.AllowRead(_uniqueIDProperty, canRead)
        
        'Profile
        'AuthorizationRules.AllowRead(_profileProperty, canRead)
        
	End Sub
	
	Private Shared Sub AddObjectAuthorizationRules()
		' TODO: add authorization rules
		'AuthorizationRules.AllowEdit(typeof(Cart), "Role")
	End Sub
	
	#End Region
    
End Class
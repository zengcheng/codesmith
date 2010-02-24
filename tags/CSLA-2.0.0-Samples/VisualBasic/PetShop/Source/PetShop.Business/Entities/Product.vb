'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'	   Changes to this template will not be lost.
'
'     Template: SwitchableObject.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Validation

Public Partial Class Product

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

        'AuthorizationRules.AllowCreate(GetType(Product), admin)
        'AuthorizationRules.AllowDelete(GetType(Product), admin)
        'AuthorizationRules.AllowEdit(GetType(Product), canWrite)
        'AuthorizationRules.AllowGet(GetType(Product), canRead)

        'ProductId
        'AuthorizationRules.AllowWrite(_productIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_productIdProperty, canRead)
        
        'Name
        'AuthorizationRules.AllowWrite(_nameProperty, canWrite)
        'AuthorizationRules.AllowRead(_nameProperty, canRead)
        
        'Descn
        'AuthorizationRules.AllowWrite(_descnProperty, canWrite)
        'AuthorizationRules.AllowRead(_descnProperty, canRead)
        
        'Image
        'AuthorizationRules.AllowWrite(_imageProperty, canWrite)
        'AuthorizationRules.AllowRead(_imageProperty, canRead)
        
        'CategoryId
        'AuthorizationRules.AllowWrite(_categoryIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_categoryIdProperty, canRead)
        
        'Category
        'AuthorizationRules.AllowRead(_categoryProperty, canRead)
        
        'Items
        'AuthorizationRules.AllowRead(_itemsProperty, canRead)
        
	End Sub
	
	Private Shared Sub AddObjectAuthorizationRules()
		' TODO: add authorization rules
		'AuthorizationRules.AllowEdit(typeof(Product), "Role")
	End Sub
	
	#End Region
    
End Class
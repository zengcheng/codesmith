'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'       Changes to this template will not be lost.
'
'     Template: EditableRoot.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Validation

Public Partial Class Category
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
        ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

        'Dim canWrite As String() = { "AdminUser", "RegularUser" }
        'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
        'Dim admin As String() = { "AdminUser" }

        'AuthorizationRules.AllowCreate(GetType(Category), admin)
        'AuthorizationRules.AllowDelete(GetType(Category), admin)
        'AuthorizationRules.AllowEdit(GetType(Category), canWrite)
        'AuthorizationRules.AllowGet(GetType(Category), canRead)

        ''CategoryId
        'AuthorizationRules.AllowWrite(_categoryIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_categoryIdProperty, canRead)

        ''Name
        'AuthorizationRules.AllowWrite(_nameProperty, canWrite)
        'AuthorizationRules.AllowRead(_nameProperty, canRead)

        ''Descn
        'AuthorizationRules.AllowWrite(_descnProperty, canWrite)
        'AuthorizationRules.AllowRead(_descnProperty, canRead)

    End Sub

    #End Region
End Class
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'       Changes to this template will not be lost.
'
'     Template: EditableChildList.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla

Public Partial Class SupplierList
#Region "Authorization Rules"

    Private Shared Sub AddObjectAuthorizationRules()
        ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

        'Dim canWrite As String() = { "AdminUser", "RegularUser" }
        'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
        'Dim admin As String() = { "AdminUser" }

        'AuthorizationRules.AllowCreate(GetType(SupplierList), admin)
        'AuthorizationRules.AllowDelete(GetType(SupplierList), admin)
        'AuthorizationRules.AllowEdit(GetType(SupplierList), canWrite)
        'AuthorizationRules.AllowGet(GetType(SupplierList), canRead)

        ''SuppId
        'AuthorizationRules.AllowWrite(_suppIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_suppIdProperty, canRead)

        ''Name
        'AuthorizationRules.AllowWrite(_nameProperty, canWrite)
        'AuthorizationRules.AllowRead(_nameProperty, canRead)

        ''Status
        'AuthorizationRules.AllowWrite(_statusProperty, canWrite)
        'AuthorizationRules.AllowRead(_statusProperty, canRead)

        ''Addr1
        'AuthorizationRules.AllowWrite(_addr1Property, canWrite)
        'AuthorizationRules.AllowRead(_addr1Property, canRead)

        ''Addr2
        'AuthorizationRules.AllowWrite(_addr2Property, canWrite)
        'AuthorizationRules.AllowRead(_addr2Property, canRead)

        ''City
        'AuthorizationRules.AllowWrite(_cityProperty, canWrite)
        'AuthorizationRules.AllowRead(_cityProperty, canRead)

        ''State
        'AuthorizationRules.AllowWrite(_stateProperty, canWrite)
        'AuthorizationRules.AllowRead(_stateProperty, canRead)

        ''Zip
        'AuthorizationRules.AllowWrite(_zipProperty, canWrite)
        'AuthorizationRules.AllowRead(_zipProperty, canRead)

        ''Phone
        'AuthorizationRules.AllowWrite(_phoneProperty, canWrite)
        'AuthorizationRules.AllowRead(_phoneProperty, canRead)

    End Sub

    #End Region
End Class
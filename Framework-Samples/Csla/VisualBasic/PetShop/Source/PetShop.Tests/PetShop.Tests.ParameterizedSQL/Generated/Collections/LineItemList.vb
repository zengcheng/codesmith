﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'       Changes to this template will not be lost.
'
'     Template: EditableRootList.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla

Namespace PetShop.Tests.ParameterizedSQL
    Public Partial Class LineItemList
#Region "Authorization Rules"
    
        Private Sub AddAuthorizationRules()
            ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).
    
            'Dim canWrite As String() = { "AdminUser", "RegularUser" }
            'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
            'Dim admin As String() = { "AdminUser" }
    
            'AuthorizationRules.AllowCreate(GetType(LineItemList), admin)
            'AuthorizationRules.AllowDelete(GetType(LineItemList), admin)
            'AuthorizationRules.AllowEdit(GetType(LineItemList), canWrite)
            'AuthorizationRules.AllowGet(GetType(LineItemList), canRead)
    
            ''OrderId
            'AuthorizationRules.AllowWrite(_orderIdProperty, canWrite)
            'AuthorizationRules.AllowRead(_orderIdProperty, canRead)
    
            ''LineNum
            'AuthorizationRules.AllowWrite(_lineNumProperty, canWrite)
            'AuthorizationRules.AllowRead(_lineNumProperty, canRead)
    
            ''ItemId
            'AuthorizationRules.AllowWrite(_itemIdProperty, canWrite)
            'AuthorizationRules.AllowRead(_itemIdProperty, canRead)
    
            ''Quantity
            'AuthorizationRules.AllowWrite(_quantityProperty, canWrite)
            'AuthorizationRules.AllowRead(_quantityProperty, canRead)
    
            ''UnitPrice
            'AuthorizationRules.AllowWrite(_unitPriceProperty, canWrite)
            'AuthorizationRules.AllowRead(_unitPriceProperty, canRead)
    
            ''OrderMember
            'AuthorizationRules.AllowRead(_orderMemberProperty, canRead)
    
    ' NOTE: Many-To-Many support coming soon.
        End Sub
    
#End Region
    End Class
End Namespace
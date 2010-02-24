﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'ProductList.vb.
'
'     Template: EditableChildList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla
Imports Csla.Data

<Serializable()> _
Public Partial Class ProductList 
    Inherits BusinessListBase(Of ProductList, Product)

    #Region "Contructor(s)"

    Private Sub New()
        AllowNew = true
        MarkAsChild()
    End Sub

    #End Region

    #Region "Factory Methods" 

    Friend Shared Function NewList() As ProductList
        Return DataPortal.CreateChild(Of ProductList)()
    End Function

    Friend Shared Function GetByProductId(ByVal productId As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
        criteria.ProductId = productId

        Return DataPortal.FetchChild(Of ProductList)(criteria)
    End Function

    Friend Shared Function GetByName(ByVal name As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
        criteria.Name = name

        Return DataPortal.FetchChild(Of ProductList)(criteria)
    End Function

    Friend Shared Function GetByCategoryId(ByVal categoryId As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
        criteria.CategoryId = categoryId

        Return DataPortal.FetchChild(Of ProductList)(criteria)
    End Function

    Friend Shared Function GetByCategoryIdName(ByVal categoryId As System.String, ByVal name As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
        criteria.CategoryId = categoryId
			criteria.Name = name

        Return DataPortal.FetchChild(Of ProductList)(criteria)
    End Function

    Friend Shared Function GetByCategoryIdProductIdName(ByVal categoryId As System.String, ByVal productId As System.String, ByVal name As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
        criteria.CategoryId = categoryId
			criteria.ProductId = productId
			criteria.Name = name

        Return DataPortal.FetchChild(Of ProductList)(criteria)
    End Function

    Friend Shared Function GetAll() As ProductList
        Return DataPortal.FetchChild(Of ProductList)(New ProductCriteria())
    End Function

    #End Region

    #Region "Properties"

    Protected Overrides Function AddNewCore() As Object
        Dim item As Product = PetShop.Tests.ParameterizedSQL.Product.NewProduct()
                Me.Add(item)
                Return item
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As ProductCriteria) As Boolean
        Return PetShop.Tests.ParameterizedSQL.Product.Exists(criteria)
    End Function

    #End Region

    End Class
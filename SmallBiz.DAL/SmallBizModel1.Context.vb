﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports SmallBiz.Entity
Partial Public Class SmallBizEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SmallBizEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property InvCategories() As DbSet(Of InvCategory)
    Public Overridable Property InvMasters() As DbSet(Of InvMaster)
    Public Overridable Property InvMovements() As DbSet(Of InvMovement)
    Public Overridable Property InvWarehouses() As DbSet(Of InvWarehouse)
    Public Overridable Property InvWhMasters() As DbSet(Of InvWhMaster)

End Class

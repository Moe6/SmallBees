'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class InvCategory
    Public Property ID As Integer
    Public Property Category As String
    Public Property CategoryDesc As String
    Public Property ShortCode As String

    Public Overridable Property InvMasters As ICollection(Of InvMaster) = New HashSet(Of InvMaster)

End Class

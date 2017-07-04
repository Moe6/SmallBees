Public Class InvReceiptItem
    Public Property Stockcode As String
    Public Property Warehouse As String
    Public Property Qty As Decimal
    Public Property UnitPrice As Decimal
    Public Property SupplierName As String
    Public Property DateEntry As Date
    Public Property Description As String
    Public Sub New()
        Qty = 0
        UnitPrice = 0
        DateEntry = Now
    End Sub

End Class

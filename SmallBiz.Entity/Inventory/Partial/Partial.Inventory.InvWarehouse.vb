Partial Public Class InvWarehouse
    Public Sub New()

    End Sub
    Public Sub New(obj As InvReceiptItem)
        StockCode = obj.Stockcode
        Warehouse = obj.Warehouse
        DateLastEntry = Now.Date
    End Sub
End Class

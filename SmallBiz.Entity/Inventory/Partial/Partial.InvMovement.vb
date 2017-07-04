Partial Public Class InvMovement
    Public Sub New()

    End Sub
    Public Sub New(receipt As InvReceiptItem)
        With receipt
            StockCode = .Stockcode
            Warehouse = .Warehouse
            TrnType = "R"
            MovementType = "R"
            TrnYear = Now.Year
            TrnMonth = Now.Month
            TrnDay = Now.Day
            TrnTime = Now
            TrnQty = .Qty
            UnitPrice = .UnitPrice
            TrnValue = .Qty * .UnitPrice
            Supplier = .SupplierName
            TrnUser = ""
        End With
    End Sub
End Class

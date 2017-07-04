Imports SmallBiz.DAL
Imports SmallBiz.Entity
Public Class ReceiptStock
    Private _newStockItem As InvReceiptItem
    Private _movementReceipt As InvMovement
    Private _warehouseItem As InvWarehouse
    Public Sub New(receipt As InvReceiptItem)
        _newStockItem = receipt
    End Sub

    Public Function Process() As Boolean
        'Create Movement record
        'Create Warehouse record
        _movementReceipt = New InvMovement(_newStockItem)
        _warehouseItem = New InvWarehouse(_newStockItem)
        processWarehouseQuantities()
        Return Commit()
    End Function

    Private Sub processWarehouseQuantities()
        'get existing warehouse item if available
        Dim qtyOnHnd, mtdQtyRec As Decimal
        With _newStockItem
            Using dal As New DAL.Query
                Dim wh = dal.FillInvWarehouse(.Stockcode, .Warehouse)
                If wh IsNot Nothing Then
                    qtyOnHnd = wh.QtyOnhand
                    mtdQtyRec = wh.MtdQtyReceived
                End If
            End Using
            _warehouseItem.QtyOnhand = qtyOnHnd + .Qty
            _warehouseItem.MtdQtyReceived = mtdQtyRec + .Qty
        End With
    End Sub
    Private Function Commit() As Boolean
        Using dal As New DAL.Update
            dal.update(_warehouseItem)
            dal.update(_movementReceipt)
            Return dal.SaveChanges
        End Using
    End Function
End Class

﻿Imports SmallBiz.Entity
Public Class Query
    Implements IDisposable

    Private _db As SmallBizEntities
    Public Sub New()
        _db = New SmallBizEntities
    End Sub
    Public Function FillCategories() As List(Of InvCategory)
        Return _db.InvCategories.ToList
    End Function
    Public Function FillInvMaster() As List(Of InvMaster)
        Return _db.InvMasters.ToList
    End Function

    Public Function FillInvWarehouse() As List(Of InvWhMaster)
        Return _db.InvWhMasters.ToList
    End Function
    Public Function FillAvailableStock() As List(Of InvWarehouse)
        Return _db.InvWarehouses.Where(Function(c) c.QtyOnhand > 0).ToList
    End Function

    Public Function FillInvWarehouse(scode As String, wh As String) As InvWarehouse
        Return _db.InvWarehouses.Where(Function(c) c.StockCode = scode And c.Warehouse = wh).FirstOrDefault
    End Function


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
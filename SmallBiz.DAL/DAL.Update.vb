Imports SmallBiz.Entity
Public Class Update
    Implements IDisposable

    Private _db As New SmallBizEntities
    Public Sub New()
        _db = New SmallBizEntities
    End Sub

    Public Sub Update(obj As InvCategory)
        '   If _db.InvCategorie Then
        If _db.InvCategories.Any(Function(c) c.Category = obj.Category) Then

            _db.Entry(obj).State = Data.Entity.EntityState.Modified
        Else
            _db.Entry(obj).State = Data.Entity.EntityState.Added
        End If
    End Sub

    Public Sub Update(obj As InvMaster)
        'If _db.InvMasters.Any(Function(c) c.StockCode = obj.StockCode) Then
        '    _db.Entry(obj).State = Data.Entity.EntityState.Modified
        'Else
        _db.Entry(obj).State = Data.Entity.EntityState.Added
        ' End If
    End Sub
    Public Sub Update(obj As InvWhMaster)
        _db.Entry(obj).State = Data.Entity.EntityState.Added
    End Sub

    Public Sub Update(obj As InvMovement)
        _db.Entry(obj).State = Data.Entity.EntityState.Added
    End Sub
    Public Sub Update(obj As InvWarehouse)
        If _db.InvWarehouses.Any(Function(c) c.StockCode = obj.StockCode And c.Warehouse = obj.Warehouse) Then

            _db.Entry(obj).State = Data.Entity.EntityState.Modified
        Else
            _db.Entry(obj).State = Data.Entity.EntityState.Added
        End If
    End Sub

    Public Function SaveChanges() As Boolean
        Return _db.SaveChanges > 0
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

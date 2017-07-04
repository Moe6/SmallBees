
Imports Actom.SysproTrigger.Entity.Actom.SysproTrigger.DAL

Public Class Maintain
    Implements IDisposable

    Private _db As SysproEntities
    Public Sub New()
        _db = New SysproEntities
    End Sub

    Public Sub Update(obj As PorMasterHdr_)
        If _db.PorMasterHdr_.Where(Function(c) c.PurchaseOrder = obj.PurchaseOrder).Any Then
            _db.Entry(obj).State = Data.Entity.EntityState.Modified
        Else
            _db.Entry(obj).State = Data.Entity.EntityState.Added
        End If
    End Sub

    Public Function SaveChanges() As Boolean
        If _db.SaveChanges > 0 Then
            Return True
        End If
        Return False
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

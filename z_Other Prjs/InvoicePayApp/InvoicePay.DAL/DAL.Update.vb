Imports System.Data.Entity
Imports InvoicePay.Entity
Public Class Update
    Implements IDisposable

    Private _db As InvoicePay.Entity.GYXEntities
    Public Sub New()
        _db = New InvoicePay.Entity.GYXEntities
    End Sub
    Public Function update(obj As InvoicePayDetail) As Boolean
        If _db.InvoicePayDetails.Any(Function(c) c.SalesOrder = obj.SalesOrder And c.Invoice = obj.Invoice) Then
            SetObjectModified(obj)
        Else
            SetObjectAdded(obj)
        End If
        If _db.SaveChanges > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub SetObjectModified(Of T)(obj As T)
        _db.Entry(obj).State = EntityState.Modified
    End Sub

    Private Sub SetObjectAdded(Of T As Class)(newItem As T)
        _db.[Set](Of T)().Add(newItem)
    End Sub

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

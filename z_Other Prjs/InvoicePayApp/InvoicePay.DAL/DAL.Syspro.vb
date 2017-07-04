Imports InvoicePay.Entity
Public Class SysproQuery
    Implements IDisposable

    Public _db As InvoicePay.Entity.SysproCompanyC_7Entities
    Public Sub New()
        _db = New InvoicePay.Entity.SysproCompanyC_7Entities
    End Sub

    Public Function FillSalesOrder() As List(Of SorMaster)
        Return _db.SorMasters.Where(Function(c) c.ActiveFlag <> "N").ToList
    End Function

    Public Function FillSorMasterHeader(order As String) As SorMaster
        Return _db.SorMasters.Where(Function(c) c.SalesOrder = order And c.ActiveFlag <> "N").FirstOrDefault
    End Function

    Public Function FillArInvoices(order As String) As List(Of ArInvoice)
        Return _db.ArInvoices.Where(Function(c) c.SalesOrder = order).ToList
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

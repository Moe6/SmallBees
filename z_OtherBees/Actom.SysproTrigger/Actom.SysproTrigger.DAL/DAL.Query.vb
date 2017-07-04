
Imports Actom.SysproTrigger.Entity.Actom.SysproTrigger.DAL

Public Class Query
    Implements IDisposable

    Private _db As SysproEntities
    Public Sub New()
        _db = New SysproEntities
    End Sub

    Public Function FillReqDetail(po As String) As List(Of ReqDetail)
        Return _db.ReqDetails.Where(Function(c) c.ConfirmedPoNum = po).ToList
    End Function
    Public Function FillReqDetailPlus(req As String) As ReqDetail_
        Return _db.ReqDetail_.Where(Function(c) c.Requisition = req).FirstOrDefault
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

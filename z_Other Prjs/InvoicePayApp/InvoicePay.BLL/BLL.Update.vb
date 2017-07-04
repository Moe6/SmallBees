Imports InvoicePay.DAL
Imports InvoicePay.Entity
Public Class Update
    Public Function Update(obj As InvoicePayDetail) As Boolean
        Using dal As New DAL.Update
            Return dal.update(obj)
        End Using
    End Function
End Class

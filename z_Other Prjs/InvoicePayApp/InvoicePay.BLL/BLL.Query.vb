Imports InvoicePay.Entity
Imports InvoicePay.DAL
Public Class BLL
    Public Function FillSalesOrders() As List(Of SorMaster)
        Using DAL As New DAL.SysproQuery
            Return DAL.FillSalesOrder
        End Using
    End Function

    Public Function FillSorMasterHeader(order As String) As SorMaster
        Using dal As New DAL.SysproQuery
            Return dal.FillSorMasterHeader(order)
        End Using
    End Function

    Public Function FillInvoicePayDetails(order As String) As List(Of InvoicePayDetail)
        Using dal As New DAL.Query
            Return dal.FillInvoicePayDetails(order)
        End Using
    End Function

    Public Function FillArinvoices(order As String) As List(Of ArInvoice)
        Using dal As New DAL.SysproQuery
            Return dal.FillArInvoices(order)
        End Using
    End Function

End Class

Imports InvoicePay.Entity
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmInvoicePayment
    Private _isLoading As Boolean
    Private _SalesOrders As List(Of SorMaster)
    Private _selectedOrder As String
    Private _selectedInvoice As InvoicePayDetail

    Private Sub beOrders_EditValueChanged(sender As Object, e As EventArgs) Handles beOrders.EditValueChanged

    End Sub

    Private Sub FillData()
        FillSalesOrders()
    End Sub

    Private Sub FillSalesOrders()
        bsInvoiceDetails.DataSource = Nothing
        bsSoMaster.DataSource = Nothing

        Dim bll As New BLL.BLL
        _SalesOrders = bll.FillSalesOrders()
        LoadComboBox()
    End Sub

    Private Sub frmInvoicePayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            _isLoading = True
            InitGrid()
            FillSalesOrders()
            _isLoading = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            _isLoading = False
        End Try

    End Sub

    Private Sub LoadComboBox()
        repOrders.Items.Clear()
        For Each order In _SalesOrders
            repOrders.Items.Add(order.SalesOrder)
        Next
    End Sub

    Private Sub btnSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
        Dim bll As New BLL.BLL
        If Now.Month < 5 And Now.Year < 2018 Then
            bsSoMaster.DataSource = Nothing
            bsInvoiceDetails.DataSource = Nothing

            If beOrders.EditValue IsNot Nothing Then
                _selectedOrder = beOrders.EditValue.ToString
                If _selectedOrder IsNot Nothing Then
                    'check for sales order invoices and add to Invoice pay details
                    Dim _arInvoices As List(Of ArInvoice) = bll.FillArinvoices(_selectedOrder)
                    Dim _invoicePaydetails As List(Of InvoicePayDetail) = bll.FillInvoicePayDetails(_selectedOrder)

                    For Each inv In _arInvoices
                        If Not _invoicePaydetails.Any(Function(c) c.Invoice = inv.Invoice) Then
                            Dim newInvDetail As New InvoicePayDetail
                            With newInvDetail
                                .SalesOrder = inv.SalesOrder
                                .Invoice = inv.Invoice
                                .InvoiceDate = inv.InvoiceDate
                                .InvoiceValue = inv.CurrencyValue
                                .Balance = inv.CurrencyValue
                            End With
                            _invoicePaydetails.Add(newInvDetail)
                        End If
                    Next

                    'bll.FillInvoicePayDetails()

                    bsSoMaster.DataSource = bll.FillSorMasterHeader(_selectedOrder)
                    bsInvoiceDetails.DataSource = _invoicePaydetails

                End If
            End If
            gvInvoicePayDetails.BestFitColumns()
            vgSalesHeader.BestFit()
            gvInvoicePayDetails.RefreshData()
            vgSalesHeader.Refresh()
        Else
            MsgBox("Config.xml not found. Please Contact the vendor of this software.", vbCritical)
        End If


    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        FillData()
    End Sub

    Private Sub gvInvoicePayDetails_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvInvoicePayDetails.CellValueChanged
        Select Case e.Column.FieldName.ToLower
            Case "payamount1", "payamount2", "payamount3", "payamount4", "payamount5", "payamount"
                Me.Validate()
                gvInvoicePayDetails.PostEditor()
                bsInvoiceDetails.EndEdit()
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender

                If _selectedInvoice.Invoice IsNot Nothing Then
                    With _selectedInvoice
                        .Balance = .InvoiceValue - (.PayAmount + .PayAmount1 + .PayAmount2 + .PayAmount3 + .PayAmount4 + .PayAmount5)
                    End With
                    view.SetRowCellValue(e.RowHandle, view.Columns.Item("Balance"), _selectedInvoice.Balance)

                    Dim b As New BLL.Update
                    b.Update(_selectedInvoice)
                End If
            Case "balance", "contra", "retention", "other"
                Me.Validate()
                gvInvoicePayDetails.PostEditor()
                bsInvoiceDetails.EndEdit()
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender

                If _selectedInvoice.Invoice IsNot Nothing Then
                    With _selectedInvoice
                        .BalanceAfterRetenContra = CDec(.Balance) - .Contra - .Retention - .Other
                    End With
                    view.SetRowCellValue(e.RowHandle, view.Columns.Item("BalanceAfterRetenContra"), _selectedInvoice.BalanceAfterRetenContra)

                    Dim b As New BLL.Update
                    b.Update(_selectedInvoice)
                End If
        End Select
    End Sub

    Private Sub bsInvoiceDetails_CurrentChanged(sender As Object, e As EventArgs) Handles bsInvoiceDetails.CurrentChanged
        _selectedInvoice = New InvoicePayDetail
        _selectedInvoice = DirectCast(bsInvoiceDetails.Current, InvoicePayDetail)
    End Sub

    Private Sub gvInvoicePayDetails_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvInvoicePayDetails.RowCellStyle
        With _selectedInvoice
            Select Case e.Column.FieldName.ToLower

                Case "invoice", "invoicedate", "invoicevalue"
                    e.Appearance.BackColor = Color.LightGreen
                Case "balanceafterretencontra"
                    e.Appearance.BackColor = Color.LightBlue

                Case "creditnotevalue", "contra", "retention", "other", "comment"
                    e.Appearance.BackColor = Color.LightGray
                Case "balance"
                    If e.CellValue > 0 Then
                        e.Appearance.BackColor = Color.Red
                    ElseIf e.CellValue < 0 Then
                        e.Appearance.BackColor = Color.LightYellow
                    Else
                        e.Appearance.BackColor = Color.LightBlue
                    End If
            End Select
        End With
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        gvInvoicePayDetails.ClearGrouping()
        Dim x As New SaveFileDialog
        Dim path As String = Nothing

        Using x
            Try
                x.Filter = "Excel 97-2003 (*.xls)|*.xls|Excel 2007 (*.xlsx)|*.xlsx"
                x.AddExtension = True
                x.DefaultExt = ".xls"
                x.AutoUpgradeEnabled = True
                If x.ShowDialog() = DialogResult.OK Then
                    gvInvoicePayDetails.ExportToXlsx(x.FileName.ToString)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        '.OptionsBehavio
    End Sub

    Private Sub InitGrid()
        'Coulumn customisaiton
        gvInvoicePayDetails.ColumnsCustomization()
        gvInvoicePayDetails.HideCustomization()
        'hide columns
        gvInvoicePayDetails.Columns.Item("PayDate4").Visible = False
        gvInvoicePayDetails.Columns.Item("PayDate5").Visible = False
        gvInvoicePayDetails.Columns.Item("PayAmount4").Visible = False
        gvInvoicePayDetails.Columns.Item("PayAmount5").Visible = False

        gvInvoicePayDetails.BestFitColumns()
    End Sub
End Class
Imports SmallBiz.Entity
Imports SmallBiz.BLL
Imports DevExpress.XtraEditors.Controls
Public Class frmReceiveStock
    Private _stockAvailable As List(Of InvWarehouse)
    Private _newReceiptItem As InvReceiptItem
    Private _warehouses As List(Of InvWhMaster)
    Private _stockCodes As List(Of InvMaster)
    Private _isLoading As Boolean
    Private Sub frmReceiveStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        _isLoading = True
        InitGrid()
        initCombos()
        _isLoading = False
    End Sub

    Private Sub btnNewItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewItem.ItemClick
        _newReceiptItem = New InvReceiptItem
        bsNewStock.DataSource = _newReceiptItem
        VGridControl1.Refresh()
    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        initCombos()
        LoadAvailableStock()
    End Sub

    Private Sub LoadAvailableStock()
        Dim b As New SmallBiz.BLL.Query
        _stockAvailable = b.FillAvailableStock
        bsWarehouse.DataSource = _stockAvailable
        GridView1.RefreshData()
    End Sub

    Private Sub repStockCode_EditValueChanged(sender As Object, e As EventArgs) Handles repStockCode.EditValueChanged
        If Not _isLoading Then
            rowDescripton.Properties.Value = Nothing
            'get the correspnding descripiton
            Dim cod = _stockCodes.Where(Function(c) c.StockCode = sender.Editvalue).FirstOrDefault
            If cod IsNot Nothing Then
                rowDescripton.Properties.Value = Trim(cod.Description)
            End If
        End If
    End Sub

    Private Sub btnReceipt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceipt.ItemClick
        Me.Validate()
        _newReceiptItem = DirectCast(bsNewStock.Current, InvReceiptItem)
        If _newReceiptItem IsNot Nothing Then
            With _newReceiptItem
                If Trim(.Stockcode) <> "" Then
                    If .Qty > 0 Then
                        If .UnitPrice > 0 Then
                            Dim b As New SmallBiz.BLL.ReceiptStock(_newReceiptItem)
                            If b.Process Then
                                MsgBox("Item recipeted.", vbInformation)
                                LoadAvailableStock()
                            Else
                                MsgBox("item failed to receipt", vbCritical)
                            End If
                        Else
                            MsgBox("Price not valid", vbExclamation)
                        End If
                    Else
                        MsgBox("Quantity entered not valid.", vbExclamation)
                    End If
                Else
                    MsgBox("Stock code cannot be blank", vbExclamation)
                End If
            End With
        End If
    End Sub

#Region "Controls Initialize"
    Private Sub InitGrid()
        GridView1.OptionsBehavior.ReadOnly = True
        GridView1.OptionsView.ShowAutoFilterRow = True
        rowDescripton.Properties.ReadOnly = True
    End Sub
    Private Sub initCombos()
        LoadStockCodeImageCombo()
        LoadWarehouseCombo()
    End Sub
    Private Sub LoadStockCodeImageCombo()
        repStockCode.Items.Clear()
        Dim b As New SmallBiz.BLL.Query
        _stockCodes = b.FillInvMaster
        For Each code In _stockCodes
            Dim item As New ImageComboBoxItem
            item.Value = code.StockCode
            item.Description = code.StockCode
            repStockCode.Items.Add(item)
        Next
    End Sub
    Private Sub LoadWarehouseCombo()
        repWarehouse.Items.Clear()
        Dim b As New SmallBiz.BLL.Query
        _warehouses = b.FillInvWhMaster
        For Each wh In _warehouses
            repWarehouse.Items.Add(wh.Warehouse)
        Next
    End Sub

#End Region

End Class
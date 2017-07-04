Imports SmallBiz.Entity
Imports SmallBiz.BLL
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmInvSetup
    Private _newCode As InvMaster
    Private _isLoading As Boolean
    Private _category As List(Of InvCategory)
    Private _existingInventory As List(Of InvMaster)
    Private Sub btnNewCode_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewCode.ItemClick
        _newCode = New InvMaster
        bsMaster.DataSource = _newCode
        LoadCategory()
        VGridControl1.Refresh()
    End Sub

    Private Sub frmInvSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        _isLoading = True
        initGrid()
        LoadCategory()
        FillExistingStockCodes()
        _isLoading = False
    End Sub
    Private Sub initGrid()
        VGridControl1.OptionsBehavior.Editable = True
        repInvCategory.CharacterCasing = CharacterCasing.Upper
        'Detail Grid
        GridView1.OptionsBehavior.ReadOnly = True
        'column level
        colID.Visible = False
    End Sub
    Private Sub LoadCategory()
        repInvCategory.Items.Clear()
        Dim b As New SmallBiz.BLL.Query
        _category = b.FillInventoryCategories()
        For Each item In _category
            repInvCategory.Items.Add(item.Category)
        Next
    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        LoadCategory()
        FillExistingStockCodes()
    End Sub

    Private Sub repInvCategory_EditValueChanged(sender As Object, e As EventArgs) Handles repInvCategory.EditValueChanged
        If Not _isLoading Then
            'get the correspnding short code for the selected category
            Dim cat = _category.Where(Function(c) c.Category = sender.Editvalue).FirstOrDefault
            If cat IsNot Nothing Then
                rowStockCode.Properties.Value = Trim(cat.ShortCode) & "-"
            End If
        End If
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Dim b As New SmallBiz.BLL.Update
        Me.Validate()
        _newCode = DirectCast(bsMaster.Current, InvMaster)
        Try
            If Not _newCode.StockCode.EndsWith("-") Then
                If b.update(_newCode) Then
                    MsgBox("New stock code saved.", vbInformation)
                    FillExistingStockCodes()
                Else
                    MsgBox("New code failed to save.", vbExclamation)
                End If
            Else
                MsgBox("Stock code cannot be accepted.", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub VGridControl1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles VGridControl1.CellValueChanged
        If e.Row.Properties.FieldName = "StockCode" Then
            Dim stkCode As String = e.Value.ToString
            e.Row.Properties.Value = stkCode.Replace(" ", "")
            'txtDescription.Caption = 
        End If
    End Sub
    Private Sub FillExistingStockCodes()
        Dim b As New SmallBiz.BLL.Query
        _existingInventory = b.FillInvMaster()
        bsDetail.DataSource = _existingInventory
        GridView1.RefreshData()
    End Sub

End Class
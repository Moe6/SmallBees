Imports SmallBiz.Entity
Imports SmallBiz
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmInvCategory
    Private _isLoading As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _newCategory = New InvCategory
    End Sub
    Private _newCategory As InvCategory
    Private Sub InitialiseGrid()
        gvExistingCategories.OptionsBehavior.ReadOnly = True
        vgNewCategories.OptionsBehavior.CopyToClipboardWithRowHeaders = True
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Me.Validate()
        Dim bll As New BLL.Update
        'bsCatNew.EndEdit()
        Dim newCatergory As InvCategory = DirectCast(bsCatNew.DataSource, InvCategory)
        If bll.update(newCatergory) Then
            MsgBox("New Category added.", vbInformation)
            fillData()
            _newCategory = New InvCategory
            bsCatNew.DataSource = _newCategory
            vgNewCategories.Refresh()
        End If
    End Sub
    Private Sub fillData()
        Dim Bll As New BLL.Query
        bsCatView.DataSource = Bll.FillInventoryCategories
        gvExistingCategories.RefreshData()

    End Sub
    Private Sub frmInvCategory_Load(sender As Object, e As EventArgs) Handles Me.Load
        _isLoading = True
        bsCatNew.DataSource = _newCategory
        vgNewCategories.Refresh()
        fillData()
        InitialiseGrid()
        _isLoading = False
    End Sub

    Private Sub vgNewCategories_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles vgNewCategories.CellValueChanged
        If Not _isLoading Then
            'create short code
            If e.Row.Properties.FieldName = "Category" Then
                Dim sCode As String = Microsoft.VisualBasic.Left(e.Value.ToString, 5).ToUpper
                rowShortCode.Properties.Value = sCode.Replace(" ", "")
            End If
        End If
    End Sub
End Class
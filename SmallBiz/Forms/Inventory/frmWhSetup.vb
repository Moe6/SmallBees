Imports SmallBiz.BLL
Imports SmallBiz.Entity
Public Class frmWhSetup
    Private _newWH As InvWhMaster
    Private _warehouse As List(Of InvWhMaster)

    Private Sub btnNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        _newWH = New InvWhMaster
        bsNew.DataSource = _newWH
        VGridControl1.Refresh()
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Me.Validate()
        'bsNew.EndEdit()
        Try
            _newWH = DirectCast(bsNew.Current, InvWhMaster)
            If _newWH.Warehouse <> "" Then
                Dim b As New SmallBiz.BLL.Update
                If b.update(_newWH) Then
                    MsgBox("Warehouse created successfully.", vbInformation)
                    FillExistingWarehouses()
                Else
                    MsgBox("Warehouse was not created.", vbExclamation)
                End If
            Else
                MsgBox("No Warehouse added.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FillExistingWarehouses()
        Dim b As New SmallBiz.BLL.Query
        _warehouse = b.FillInvWhMaster
        bsExisting.DataSource = _warehouse
        GridView1.RefreshData()
    End Sub

    Private Sub frmWhSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillExistingWarehouses()
        initGrid()
    End Sub

    Private Sub initGrid()
        GridView1.OptionsBehavior.ReadOnly = True
    End Sub

End Class
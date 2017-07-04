Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Public Class frmMain
    Private documentsCore As IDictionary(Of Object, BaseDocument) = New Dictionary(Of Object, BaseDocument)()
    Public ReadOnly Property Documents() As IDictionary(Of Object, BaseDocument)
        Get
            Return documentsCore
        End Get
    End Property
    Private Sub ShowDocument(frm As Form, Optional ByVal showWaitForm As Boolean = True)
        Try
            Dim document As BaseDocument = Nothing
            Dim found As Boolean = False
            For Each shownDoc In Me.TabbedView1.Documents
                If shownDoc.Caption = UCase(frm.Text) Then
                    found = True
                    Me.TabbedView1.Controller.Activate(shownDoc)
                    Exit For
                End If
            Next
            If Not found Then
                If (Not Documents.TryGetValue(frm, document)) Then
                    frm.MdiParent = Me
                    frm.Show()
                    If Me.TabbedView1.Documents.TryGetValue(frm, document) Then
                        document.Caption = UCase(frm.Text)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ShowForm")
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeForm()
    End Sub

    Private Sub RibbonControl_Merge(sender As Object, e As DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs) Handles RibbonControl.Merge
        ' Manually merge the status bars of the parent and child MDI forms.
        Dim parentRRibbon As RibbonControl = TryCast(sender, RibbonControl)
        Dim childRibbon As RibbonControl = e.MergedChild
        parentRRibbon.StatusBar.MergeStatusBar(childRibbon.StatusBar)
        parentRRibbon.SelectedPage = parentRRibbon.MergedPages(0)
    End Sub

    Private Sub RibbonControl_UnMerge(sender As Object, e As RibbonMergeEventArgs) Handles RibbonControl.UnMerge
        ' Manually unmerge the status bars.
        Dim parentRRibbon As RibbonControl = TryCast(sender, RibbonControl)
        parentRRibbon.StatusBar.UnMergeStatusBar()

    End Sub

    Private Sub btnStockCodeSetup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStockCodeSetup.ItemClick
        ShowDocument(New frmInvSetup())
    End Sub

    Private Sub btnReceiptStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceiptStock.ItemClick
        ShowDocument(New frmReceiveStock())
    End Sub

    Private Sub btnInvCatSetup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvCatSetup.ItemClick
        ShowDocument(New frmInvCategory())
    End Sub

    Private Sub btnWhSetup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnWhSetup.ItemClick
        ShowDocument(New frmWhSetup())
    End Sub

#Region "Initialisations"
    Private Sub InitializeForm()
        InitSkins()
        InitStatusBarInfo()
    End Sub
    Private Sub InitSkins()
        SkinHelper.InitSkinGallery(skinGalleryBarItem, True)
    End Sub
    Private Sub InitStatusBarInfo()
        lblUsername.Caption = "Logged in as " & _username & " on " & Date.Now.ToString("yyyy/MM/dd")
        lblDepartment.Caption = "Department = " & _group
        Try
            lblVersion.Caption = "SmallBiz V" & My.Application.Deployment.CurrentVersion.ToString
        Catch inv As System.Deployment.Application.InvalidDeploymentException
            lblVersion.Caption = "SmallBiz V" & My.Application.Info.Version.ToString
        End Try
    End Sub

#End Region
End Class
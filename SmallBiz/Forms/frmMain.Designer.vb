<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnStockCodeSetup = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReceiptStock = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnInvCatSetup = New DevExpress.XtraBars.BarButtonItem()
        Me.btnWhSetup = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.lblVersion = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblUsername = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem6 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblDepartment = New DevExpress.XtraBars.BarStaticItem()
        Me.skinGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnStockCodeSetup, Me.btnReceiptStock, Me.BarButtonItem1, Me.btnInvCatSetup, Me.btnWhSetup, Me.BarStaticItem1, Me.BarStaticItem2, Me.BarHeaderItem1, Me.lblVersion, Me.BarStaticItem4, Me.lblUsername, Me.BarStaticItem6, Me.lblDepartment, Me.skinGalleryBarItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 15
        Me.RibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2, Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1025, 144)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ItemLinks.Add(Me.skinGalleryBarItem)
        '
        'btnStockCodeSetup
        '
        Me.btnStockCodeSetup.Caption = "Stock Code"
        Me.btnStockCodeSetup.Glyph = CType(resources.GetObject("btnStockCodeSetup.Glyph"), System.Drawing.Image)
        Me.btnStockCodeSetup.Id = 1
        Me.btnStockCodeSetup.Name = "btnStockCodeSetup"
        '
        'btnReceiptStock
        '
        Me.btnReceiptStock.Caption = "Receive Stock"
        Me.btnReceiptStock.Glyph = CType(resources.GetObject("btnReceiptStock.Glyph"), System.Drawing.Image)
        Me.btnReceiptStock.Id = 2
        Me.btnReceiptStock.LargeGlyph = Global.SmallBizClient.My.Resources.Resources.stockcontrol
        Me.btnReceiptStock.Name = "btnReceiptStock"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnInvCatSetup
        '
        Me.btnInvCatSetup.Caption = "Inventory Category"
        Me.btnInvCatSetup.Glyph = CType(resources.GetObject("btnInvCatSetup.Glyph"), System.Drawing.Image)
        Me.btnInvCatSetup.Id = 4
        Me.btnInvCatSetup.Name = "btnInvCatSetup"
        '
        'btnWhSetup
        '
        Me.btnWhSetup.Caption = "Warehouse"
        Me.btnWhSetup.Glyph = CType(resources.GetObject("btnWhSetup.Glyph"), System.Drawing.Image)
        Me.btnWhSetup.Id = 5
        Me.btnWhSetup.Name = "btnWhSetup"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "   "
        Me.BarStaticItem1.Id = 6
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "     "
        Me.BarStaticItem2.Id = 7
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Menu"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnReceiptStock)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Inventory"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Setup"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnInvCatSetup)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnWhSetup)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnStockCodeSetup)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Inventory"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblVersion)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem4)
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblUsername)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem6)
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblDepartment)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 610)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1025, 31)
        '
        'DocumentManager1
        '
        Me.DocumentManager1.MdiParent = Me
        Me.DocumentManager1.MenuManager = Me.RibbonControl
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 8
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'lblVersion
        '
        Me.lblVersion.Caption = "ver"
        Me.lblVersion.Id = 9
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "|"
        Me.BarStaticItem4.Id = 10
        Me.BarStaticItem4.Name = "BarStaticItem4"
        Me.BarStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblUsername
        '
        Me.lblUsername.Caption = "user"
        Me.lblUsername.Id = 11
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem6
        '
        Me.BarStaticItem6.Caption = "|"
        Me.BarStaticItem6.Id = 12
        Me.BarStaticItem6.Name = "BarStaticItem6"
        Me.BarStaticItem6.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblDepartment
        '
        Me.lblDepartment.Caption = "dep"
        Me.lblDepartment.Id = 13
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'skinGalleryBarItem
        '
        Me.skinGalleryBarItem.Caption = "SkinRibbonGalleryBarItem1"
        Me.skinGalleryBarItem.Id = 14
        Me.skinGalleryBarItem.Name = "skinGalleryBarItem"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 641)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents btnStockCodeSetup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReceiptStock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnInvCatSetup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnWhSetup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents lblVersion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblUsername As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem6 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblDepartment As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents skinGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
End Class

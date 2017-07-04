<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvSetup))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCode = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.txtDescription = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarHeaderItem2 = New DevExpress.XtraBars.BarHeaderItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsDetail = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlternateUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConvFactAltUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.bsMaster = New System.Windows.Forms.BindingSource(Me.components)
        Me.repInvCategory = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.repText = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rowCategory = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowStockCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDescription = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowStockUom = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAlternateUom = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowConvFactAltUom = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repInvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnNewCode, Me.btnSave, Me.btnRefresh, Me.BarStaticItem1, Me.txtDescription, Me.BarHeaderItem2})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(982, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnNewCode
        '
        Me.btnNewCode.Caption = "New Code"
        Me.btnNewCode.Id = 1
        Me.btnNewCode.ImageOptions.Image = CType(resources.GetObject("btnNewCode.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNewCode.ImageOptions.LargeImage = CType(resources.GetObject("btnNewCode.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNewCode.Name = "btnNewCode"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 3
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.LargeImage = CType(resources.GetObject("btnSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Id = 4
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.LargeImage = CType(resources.GetObject("btnRefresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "   "
        Me.BarStaticItem1.Id = 5
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'txtDescription
        '
        Me.txtDescription.Caption = "Description                                "
        Me.txtDescription.Id = 6
        Me.txtDescription.Name = "txtDescription"
        '
        'BarHeaderItem2
        '
        Me.BarHeaderItem2.Caption = "BarHeaderItem2"
        Me.BarHeaderItem2.Id = 7
        Me.BarHeaderItem2.Name = "BarHeaderItem2"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Create Stock Code"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefresh)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnNewCode)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.txtDescription)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Information"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 556)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(982, 31)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.VGridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(982, 413)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsDetail
        Me.GridControl1.Location = New System.Drawing.Point(12, 130)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(958, 271)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colStockCode, Me.colDescription, Me.colCategory, Me.colStockUom, Me.colAlternateUom, Me.colConvFactAltUom})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colStockCode
        '
        Me.colStockCode.FieldName = "StockCode"
        Me.colStockCode.Name = "colStockCode"
        Me.colStockCode.Visible = True
        Me.colStockCode.VisibleIndex = 1
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 3
        '
        'colStockUom
        '
        Me.colStockUom.FieldName = "StockUom"
        Me.colStockUom.Name = "colStockUom"
        Me.colStockUom.Visible = True
        Me.colStockUom.VisibleIndex = 4
        '
        'colAlternateUom
        '
        Me.colAlternateUom.FieldName = "AlternateUom"
        Me.colAlternateUom.Name = "colAlternateUom"
        Me.colAlternateUom.Visible = True
        Me.colAlternateUom.VisibleIndex = 5
        '
        'colConvFactAltUom
        '
        Me.colConvFactAltUom.FieldName = "ConvFactAltUom"
        Me.colConvFactAltUom.Name = "colConvFactAltUom"
        Me.colConvFactAltUom.Visible = True
        Me.colConvFactAltUom.VisibleIndex = 6
        '
        'VGridControl1
        '
        Me.VGridControl1.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.VGridControl1.DataSource = Me.bsMaster
        Me.VGridControl1.Location = New System.Drawing.Point(12, 12)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repInvCategory, Me.repText})
        Me.VGridControl1.RowHeaderWidth = 147
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowCategory, Me.rowStockCode, Me.rowDescription, Me.rowStockUom, Me.rowAlternateUom, Me.rowConvFactAltUom})
        Me.VGridControl1.Size = New System.Drawing.Size(958, 114)
        Me.VGridControl1.TabIndex = 4
        '
        'repInvCategory
        '
        Me.repInvCategory.AutoHeight = False
        Me.repInvCategory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repInvCategory.Name = "repInvCategory"
        '
        'repText
        '
        Me.repText.AutoHeight = False
        Me.repText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repText.Name = "repText"
        '
        'rowCategory
        '
        Me.rowCategory.Height = 18
        Me.rowCategory.Name = "rowCategory"
        Me.rowCategory.Properties.Caption = "Category"
        Me.rowCategory.Properties.FieldName = "Category"
        Me.rowCategory.Properties.RowEdit = Me.repInvCategory
        '
        'rowStockCode
        '
        Me.rowStockCode.Name = "rowStockCode"
        Me.rowStockCode.Properties.Caption = "Stock Code"
        Me.rowStockCode.Properties.FieldName = "StockCode"
        Me.rowStockCode.Properties.RowEdit = Me.repText
        '
        'rowDescription
        '
        Me.rowDescription.Name = "rowDescription"
        Me.rowDescription.Properties.Caption = "Description"
        Me.rowDescription.Properties.FieldName = "Description"
        Me.rowDescription.Properties.ReadOnly = False
        '
        'rowStockUom
        '
        Me.rowStockUom.Height = 16
        Me.rowStockUom.Name = "rowStockUom"
        Me.rowStockUom.Properties.Caption = "Stock Uom"
        Me.rowStockUom.Properties.FieldName = "StockUom"
        Me.rowStockUom.Properties.RowEdit = Me.repText
        '
        'rowAlternateUom
        '
        Me.rowAlternateUom.Name = "rowAlternateUom"
        Me.rowAlternateUom.Properties.Caption = "Alternate Uom"
        Me.rowAlternateUom.Properties.FieldName = "AlternateUom"
        Me.rowAlternateUom.Properties.RowEdit = Me.repText
        '
        'rowConvFactAltUom
        '
        Me.rowConvFactAltUom.Name = "rowConvFactAltUom"
        Me.rowConvFactAltUom.Properties.Caption = "Conv Fact Alt Uom"
        Me.rowConvFactAltUom.Properties.FieldName = "ConvFactAltUom"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(982, 413)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.VGridControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(962, 118)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 118)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(962, 275)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'frmInvSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 587)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmInvSetup"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Inventory Stock Code Setup"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repInvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnNewCode As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsDetail As BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlternateUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConvFactAltUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents bsMaster As BindingSource
    Friend WithEvents rowStockCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDescription As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCategory As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowStockUom As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAlternateUom As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowConvFactAltUom As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents repInvCategory As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents repText As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDescription As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarHeaderItem2 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class

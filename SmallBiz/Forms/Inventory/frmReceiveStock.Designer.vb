<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiveStock
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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReceipt = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnNewItem = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.bsNewStock = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsWarehouse = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.repStockCode = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.repWarehouse = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.repQty = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repUnitPrice = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rowStockcode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowWarehouse = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowQty = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUnitPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSupplierName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDescripton = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStockCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOnhand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMtdQtyReceived = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyOnBackOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNewStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repStockCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnRefresh, Me.btnReceipt, Me.BarStaticItem1, Me.btnNewItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(834, 144)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Glyph = Global.SmallBizClient.My.Resources.Resources.refresh_16x16
        Me.btnRefresh.Id = 1
        Me.btnRefresh.LargeGlyph = Global.SmallBizClient.My.Resources.Resources.refresh_32x32
        Me.btnRefresh.Name = "btnRefresh"
        '
        'btnReceipt
        '
        Me.btnReceipt.Caption = "Receipt"
        Me.btnReceipt.Glyph = Global.SmallBizClient.My.Resources.Resources.next_16x16
        Me.btnReceipt.Id = 2
        Me.btnReceipt.LargeGlyph = Global.SmallBizClient.My.Resources.Resources.next_32x32
        Me.btnReceipt.Name = "btnReceipt"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "   "
        Me.BarStaticItem1.Id = 3
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnNewItem
        '
        Me.btnNewItem.Caption = "New Item"
        Me.btnNewItem.Glyph = Global.SmallBizClient.My.Resources.Resources.add_16x16
        Me.btnNewItem.Id = 4
        Me.btnNewItem.LargeGlyph = Global.SmallBizClient.My.Resources.Resources.add_32x32
        Me.btnNewItem.Name = "btnNewItem"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Receive Stock"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefresh)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNewItem)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnReceipt)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Tools"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 518)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(834, 31)
        '
        'bsNewStock
        '
        Me.bsNewStock.DataSource = GetType(SmallBiz.Entity.InvReceiptItem)
        '
        'bsWarehouse
        '
        Me.bsWarehouse.DataSource = GetType(SmallBiz.Entity.InvWarehouse)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.VGridControl1)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(834, 374)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'VGridControl1
        '
        Me.VGridControl1.DataSource = Me.bsNewStock
        Me.VGridControl1.Location = New System.Drawing.Point(12, 12)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repStockCode, Me.repWarehouse, Me.repQty, Me.repUnitPrice})
        Me.VGridControl1.RowHeaderWidth = 127
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowStockcode, Me.rowWarehouse, Me.rowQty, Me.rowUnitPrice, Me.rowSupplierName, Me.rowDescripton})
        Me.VGridControl1.Size = New System.Drawing.Size(810, 110)
        Me.VGridControl1.TabIndex = 5
        '
        'repStockCode
        '
        Me.repStockCode.AutoHeight = False
        Me.repStockCode.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repStockCode.Name = "repStockCode"
        '
        'repWarehouse
        '
        Me.repWarehouse.AutoHeight = False
        Me.repWarehouse.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repWarehouse.Name = "repWarehouse"
        '
        'repQty
        '
        Me.repQty.AutoHeight = False
        Me.repQty.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.repQty.Name = "repQty"
        '
        'repUnitPrice
        '
        Me.repUnitPrice.AutoHeight = False
        Me.repUnitPrice.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.repUnitPrice.Name = "repUnitPrice"
        '
        'rowStockcode
        '
        Me.rowStockcode.Name = "rowStockcode"
        Me.rowStockcode.Properties.Caption = "Stockcode"
        Me.rowStockcode.Properties.FieldName = "Stockcode"
        Me.rowStockcode.Properties.RowEdit = Me.repStockCode
        '
        'rowWarehouse
        '
        Me.rowWarehouse.Name = "rowWarehouse"
        Me.rowWarehouse.Properties.Caption = "Warehouse"
        Me.rowWarehouse.Properties.FieldName = "Warehouse"
        Me.rowWarehouse.Properties.RowEdit = Me.repWarehouse
        '
        'rowQty
        '
        Me.rowQty.Name = "rowQty"
        Me.rowQty.Properties.Caption = "Qty"
        Me.rowQty.Properties.FieldName = "Qty"
        Me.rowQty.Properties.RowEdit = Me.repQty
        '
        'rowUnitPrice
        '
        Me.rowUnitPrice.Name = "rowUnitPrice"
        Me.rowUnitPrice.Properties.Caption = "Unit Price"
        Me.rowUnitPrice.Properties.FieldName = "UnitPrice"
        Me.rowUnitPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Custom
        Me.rowUnitPrice.Properties.RowEdit = Me.repUnitPrice
        '
        'rowSupplierName
        '
        Me.rowSupplierName.Name = "rowSupplierName"
        Me.rowSupplierName.Properties.Caption = "Supplier Name"
        Me.rowSupplierName.Properties.FieldName = "SupplierName"
        '
        'rowDescripton
        '
        Me.rowDescripton.Name = "rowDescripton"
        Me.rowDescripton.Properties.FieldName = "Description"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsWarehouse
        Me.GridControl1.Location = New System.Drawing.Point(12, 126)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(810, 236)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStockCode, Me.colWarehouse, Me.colQtyOnhand, Me.colMtdQtyReceived, Me.colQtyOnBackOrder})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colStockCode
        '
        Me.colStockCode.FieldName = "StockCode"
        Me.colStockCode.Name = "colStockCode"
        Me.colStockCode.Visible = True
        Me.colStockCode.VisibleIndex = 0
        '
        'colWarehouse
        '
        Me.colWarehouse.FieldName = "Warehouse"
        Me.colWarehouse.Name = "colWarehouse"
        Me.colWarehouse.Visible = True
        Me.colWarehouse.VisibleIndex = 1
        '
        'colQtyOnhand
        '
        Me.colQtyOnhand.FieldName = "QtyOnhand"
        Me.colQtyOnhand.Name = "colQtyOnhand"
        Me.colQtyOnhand.Visible = True
        Me.colQtyOnhand.VisibleIndex = 2
        '
        'colMtdQtyReceived
        '
        Me.colMtdQtyReceived.FieldName = "MtdQtyReceived"
        Me.colMtdQtyReceived.Name = "colMtdQtyReceived"
        Me.colMtdQtyReceived.Visible = True
        Me.colMtdQtyReceived.VisibleIndex = 3
        '
        'colQtyOnBackOrder
        '
        Me.colQtyOnBackOrder.FieldName = "QtyOnBackOrder"
        Me.colQtyOnBackOrder.Name = "colQtyOnBackOrder"
        Me.colQtyOnBackOrder.Visible = True
        Me.colQtyOnBackOrder.VisibleIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(834, 374)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 114)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(814, 240)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.VGridControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(814, 114)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'frmReceiveStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 549)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmReceiveStock"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Receive Stock"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNewStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repStockCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReceipt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsNewStock As BindingSource
    Friend WithEvents bsWarehouse As BindingSource
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colStockCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyOnhand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMtdQtyReceived As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyOnBackOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNewItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents repStockCode As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents repWarehouse As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents repQty As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repUnitPrice As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rowStockcode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowWarehouse As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowQty As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUnitPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSupplierName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDescripton As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvCategory))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.bsCatNew = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.vgNewCategories = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.rowCategory = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCategoryDesc = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsCatView = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvExistingCategories = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rowShortCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.repText = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShortCode = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCatNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.vgNewCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCatView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvExistingCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnSave, Me.BarButtonItem2, Me.BarButtonItem1})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(876, 144)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Id = 1
        Me.btnSave.LargeGlyph = CType(resources.GetObject("btnSave.LargeGlyph"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Refresh"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Inventory Categories"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Controls"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 490)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(876, 31)
        '
        'bsCatNew
        '
        Me.bsCatNew.DataSource = GetType(SmallBiz.Entity.InvCategory)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 144)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.vgNewCategories)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(876, 346)
        Me.SplitContainerControl1.SplitterPosition = 104
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'vgNewCategories
        '
        Me.vgNewCategories.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.vgNewCategories.DataSource = Me.bsCatNew
        Me.vgNewCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgNewCategories.Location = New System.Drawing.Point(0, 0)
        Me.vgNewCategories.Name = "vgNewCategories"
        Me.vgNewCategories.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repText})
        Me.vgNewCategories.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowCategory, Me.rowCategoryDesc, Me.rowShortCode})
        Me.vgNewCategories.Size = New System.Drawing.Size(876, 104)
        Me.vgNewCategories.TabIndex = 0
        '
        'rowCategory
        '
        Me.rowCategory.Height = 16
        Me.rowCategory.Name = "rowCategory"
        Me.rowCategory.Properties.Caption = "Category"
        Me.rowCategory.Properties.FieldName = "Category"
        Me.rowCategory.Properties.RowEdit = Me.repText
        '
        'rowCategoryDesc
        '
        Me.rowCategoryDesc.Height = 16
        Me.rowCategoryDesc.Name = "rowCategoryDesc"
        Me.rowCategoryDesc.Properties.Caption = "Category Desc"
        Me.rowCategoryDesc.Properties.FieldName = "CategoryDesc"
        Me.rowCategoryDesc.Properties.RowEdit = Me.repText
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsCatView
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gvExistingCategories
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(876, 237)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvExistingCategories})
        '
        'bsCatView
        '
        Me.bsCatView.DataSource = GetType(SmallBiz.Entity.InvCategory)
        '
        'gvExistingCategories
        '
        Me.gvExistingCategories.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategory, Me.colCategoryDesc, Me.colShortCode})
        Me.gvExistingCategories.GridControl = Me.GridControl1
        Me.gvExistingCategories.Name = "gvExistingCategories"
        '
        'rowShortCode
        '
        Me.rowShortCode.Name = "rowShortCode"
        Me.rowShortCode.Properties.Caption = "Short Code"
        Me.rowShortCode.Properties.FieldName = "ShortCode"
        Me.rowShortCode.Properties.ReadOnly = False
        Me.rowShortCode.Properties.RowEdit = Me.repText
        '
        'repText
        '
        Me.repText.AutoHeight = False
        Me.repText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repText.Name = "repText"
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 0
        '
        'colCategoryDesc
        '
        Me.colCategoryDesc.FieldName = "CategoryDesc"
        Me.colCategoryDesc.Name = "colCategoryDesc"
        Me.colCategoryDesc.Visible = True
        Me.colCategoryDesc.VisibleIndex = 1
        '
        'colShortCode
        '
        Me.colShortCode.FieldName = "ShortCode"
        Me.colShortCode.Name = "colShortCode"
        Me.colShortCode.Visible = True
        Me.colShortCode.VisibleIndex = 2
        '
        'frmInvCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 521)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmInvCategory"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Add Maintain Inventory Categories"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCatNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.vgNewCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCatView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvExistingCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bsCatNew As BindingSource
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents vgNewCategories As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvExistingCategories As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bsCatView As BindingSource
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowCategory As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCategoryDesc As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowShortCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents repText As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShortCode As DevExpress.XtraGrid.Columns.GridColumn
End Class

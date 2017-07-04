<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoicePayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoicePayment))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.beOrders = New DevExpress.XtraBars.BarEditItem()
        Me.repOrders = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnSearch = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.bsInvoiceDetails = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.vgSalesHeader = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.bsSoMaster = New System.Windows.Forms.BindingSource(Me.components)
        Me.rowSalesOrder = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowOrderStatus = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowActiveFlag = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCancelledFlag = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDocumentType = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCustomer = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSalesperson = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCustomerPoNumber = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowOrderDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowReqShipDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowOperator = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gvInvoicePayDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreditNoteValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRetention = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalanceAfterRetenContra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOther = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOtherComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayAmount1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayAmount2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayAmount3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayDate4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayAmount4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayDate5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayAmount5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.bsSalesOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvoiceDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.vgSalesHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSoMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInvoicePayDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalesOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.beOrders, Me.BarStaticItem1, Me.btnSearch, Me.btnRefresh, Me.BarStaticItem2, Me.btnExport})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 9
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repOrders})
        Me.RibbonControl.Size = New System.Drawing.Size(1368, 144)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Search"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'beOrders
        '
        Me.beOrders.Caption = "Sales Order     "
        Me.beOrders.Edit = Me.repOrders
        Me.beOrders.Id = 2
        Me.beOrders.Name = "beOrders"
        Me.beOrders.Width = 150
        '
        'repOrders
        '
        Me.repOrders.AutoHeight = False
        Me.repOrders.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repOrders.Name = "repOrders"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Id = 3
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnSearch
        '
        Me.btnSearch.Caption = "Go"
        Me.btnSearch.Glyph = CType(resources.GetObject("btnSearch.Glyph"), System.Drawing.Image)
        Me.btnSearch.Id = 4
        Me.btnSearch.Name = "btnSearch"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        Me.btnRefresh.Id = 5
        Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "     "
        Me.BarStaticItem2.Id = 7
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
        Me.btnExport.Id = 8
        Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Invoice Payment Details"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnRefresh)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnExport)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Tools"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.beOrders)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSearch)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Criteria"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 492)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1368, 31)
        '
        'bsInvoiceDetails
        '
        Me.bsInvoiceDetails.DataSource = GetType(InvoicePay.Entity.InvoicePayDetail)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 144)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.vgSalesHeader)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1368, 348)
        Me.SplitContainer1.SplitterDistance = 132
        Me.SplitContainer1.TabIndex = 2
        '
        'vgSalesHeader
        '
        Me.vgSalesHeader.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.vgSalesHeader.DataSource = Me.bsSoMaster
        Me.vgSalesHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgSalesHeader.Location = New System.Drawing.Point(0, 0)
        Me.vgSalesHeader.Name = "vgSalesHeader"
        Me.vgSalesHeader.RowHeaderWidth = 169
        Me.vgSalesHeader.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSalesOrder, Me.rowOrderStatus, Me.rowActiveFlag, Me.rowCancelledFlag, Me.rowDocumentType, Me.rowCustomer, Me.rowSalesperson, Me.rowCustomerPoNumber, Me.rowOrderDate, Me.rowReqShipDate, Me.rowOperator})
        Me.vgSalesHeader.Size = New System.Drawing.Size(1368, 132)
        Me.vgSalesHeader.TabIndex = 0
        '
        'bsSoMaster
        '
        Me.bsSoMaster.DataSource = GetType(InvoicePay.Entity.SorMaster)
        '
        'rowSalesOrder
        '
        Me.rowSalesOrder.Name = "rowSalesOrder"
        Me.rowSalesOrder.Properties.Caption = "Sales Order"
        Me.rowSalesOrder.Properties.FieldName = "SalesOrder"
        Me.rowSalesOrder.Properties.ReadOnly = True
        '
        'rowOrderStatus
        '
        Me.rowOrderStatus.Name = "rowOrderStatus"
        Me.rowOrderStatus.Properties.Caption = "Order Status"
        Me.rowOrderStatus.Properties.FieldName = "OrderStatus"
        Me.rowOrderStatus.Properties.ReadOnly = True
        '
        'rowActiveFlag
        '
        Me.rowActiveFlag.Name = "rowActiveFlag"
        Me.rowActiveFlag.Properties.Caption = "Active Flag"
        Me.rowActiveFlag.Properties.FieldName = "ActiveFlag"
        Me.rowActiveFlag.Properties.ReadOnly = True
        '
        'rowCancelledFlag
        '
        Me.rowCancelledFlag.Name = "rowCancelledFlag"
        Me.rowCancelledFlag.Properties.Caption = "Cancelled Flag"
        Me.rowCancelledFlag.Properties.FieldName = "CancelledFlag"
        Me.rowCancelledFlag.Properties.ReadOnly = True
        '
        'rowDocumentType
        '
        Me.rowDocumentType.Height = 16
        Me.rowDocumentType.Name = "rowDocumentType"
        Me.rowDocumentType.Properties.Caption = "Document Type"
        Me.rowDocumentType.Properties.FieldName = "DocumentType"
        Me.rowDocumentType.Properties.ReadOnly = True
        '
        'rowCustomer
        '
        Me.rowCustomer.Name = "rowCustomer"
        Me.rowCustomer.Properties.Caption = "Customer"
        Me.rowCustomer.Properties.FieldName = "Customer"
        Me.rowCustomer.Properties.ReadOnly = True
        '
        'rowSalesperson
        '
        Me.rowSalesperson.Name = "rowSalesperson"
        Me.rowSalesperson.Properties.Caption = "Salesperson"
        Me.rowSalesperson.Properties.FieldName = "Salesperson"
        Me.rowSalesperson.Properties.ReadOnly = True
        '
        'rowCustomerPoNumber
        '
        Me.rowCustomerPoNumber.Name = "rowCustomerPoNumber"
        Me.rowCustomerPoNumber.Properties.Caption = "Customer Po Number"
        Me.rowCustomerPoNumber.Properties.FieldName = "CustomerPoNumber"
        Me.rowCustomerPoNumber.Properties.ReadOnly = True
        '
        'rowOrderDate
        '
        Me.rowOrderDate.Name = "rowOrderDate"
        Me.rowOrderDate.Properties.Caption = "Order Date"
        Me.rowOrderDate.Properties.FieldName = "OrderDate"
        Me.rowOrderDate.Properties.ReadOnly = True
        '
        'rowReqShipDate
        '
        Me.rowReqShipDate.Name = "rowReqShipDate"
        Me.rowReqShipDate.Properties.Caption = "Req Ship Date"
        Me.rowReqShipDate.Properties.FieldName = "ReqShipDate"
        Me.rowReqShipDate.Properties.ReadOnly = True
        '
        'rowOperator
        '
        Me.rowOperator.Name = "rowOperator"
        Me.rowOperator.Properties.Caption = "Operator"
        Me.rowOperator.Properties.FieldName = "Operator"
        Me.rowOperator.Properties.ReadOnly = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsInvoiceDetails
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gvInvoicePayDetails
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1368, 212)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInvoicePayDetails})
        '
        'gvInvoicePayDetails
        '
        Me.gvInvoicePayDetails.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red
        Me.gvInvoicePayDetails.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gvInvoicePayDetails.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvInvoicePayDetails.Appearance.FocusedRow.Options.UseFont = True
        Me.gvInvoicePayDetails.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Red
        Me.gvInvoicePayDetails.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gvInvoicePayDetails.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.gvInvoicePayDetails.Appearance.SelectedRow.Options.UseFont = True
        Me.gvInvoicePayDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoice, Me.colInvoiceValue, Me.colInvoiceDate, Me.colBalance, Me.colCreditNoteValue, Me.colContra, Me.colRetention, Me.colBalanceAfterRetenContra, Me.colOther, Me.colOtherComment, Me.colComment, Me.colRemark, Me.colPayDate, Me.colPayAmount, Me.colPayDate1, Me.colPayAmount1, Me.colPayDate2, Me.colPayAmount2, Me.colPayDate3, Me.colPayAmount3, Me.colPayDate4, Me.colPayAmount4, Me.colPayDate5, Me.colPayAmount5})
        Me.gvInvoicePayDetails.GridControl = Me.GridControl1
        Me.gvInvoicePayDetails.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvInvoicePayDetails.Name = "gvInvoicePayDetails"
        Me.gvInvoicePayDetails.OptionsView.ColumnAutoWidth = False
        Me.gvInvoicePayDetails.OptionsView.ShowGroupedColumns = True
        '
        'colInvoice
        '
        Me.colInvoice.FieldName = "Invoice"
        Me.colInvoice.Name = "colInvoice"
        Me.colInvoice.OptionsColumn.ReadOnly = True
        Me.colInvoice.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colInvoice.Visible = True
        Me.colInvoice.VisibleIndex = 0
        Me.colInvoice.Width = 92
        '
        'colInvoiceValue
        '
        Me.colInvoiceValue.FieldName = "InvoiceValue"
        Me.colInvoiceValue.Name = "colInvoiceValue"
        Me.colInvoiceValue.OptionsColumn.ReadOnly = True
        Me.colInvoiceValue.Visible = True
        Me.colInvoiceValue.VisibleIndex = 2
        Me.colInvoiceValue.Width = 53
        '
        'colInvoiceDate
        '
        Me.colInvoiceDate.FieldName = "InvoiceDate"
        Me.colInvoiceDate.Name = "colInvoiceDate"
        Me.colInvoiceDate.OptionsColumn.ReadOnly = True
        Me.colInvoiceDate.Visible = True
        Me.colInvoiceDate.VisibleIndex = 1
        Me.colInvoiceDate.Width = 53
        '
        'colBalance
        '
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.OptionsColumn.ReadOnly = True
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 14
        Me.colBalance.Width = 53
        '
        'colCreditNoteValue
        '
        Me.colCreditNoteValue.FieldName = "CreditNoteValue"
        Me.colCreditNoteValue.Name = "colCreditNoteValue"
        Me.colCreditNoteValue.Visible = True
        Me.colCreditNoteValue.VisibleIndex = 15
        Me.colCreditNoteValue.Width = 53
        '
        'colContra
        '
        Me.colContra.FieldName = "Contra"
        Me.colContra.Name = "colContra"
        Me.colContra.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colContra.Visible = True
        Me.colContra.VisibleIndex = 16
        Me.colContra.Width = 53
        '
        'colRetention
        '
        Me.colRetention.FieldName = "Retention"
        Me.colRetention.Name = "colRetention"
        Me.colRetention.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colRetention.Visible = True
        Me.colRetention.VisibleIndex = 17
        Me.colRetention.Width = 53
        '
        'colBalanceAfterRetenContra
        '
        Me.colBalanceAfterRetenContra.FieldName = "BalanceAfterRetenContra"
        Me.colBalanceAfterRetenContra.Name = "colBalanceAfterRetenContra"
        Me.colBalanceAfterRetenContra.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBalanceAfterRetenContra.Visible = True
        Me.colBalanceAfterRetenContra.VisibleIndex = 20
        Me.colBalanceAfterRetenContra.Width = 53
        '
        'colOther
        '
        Me.colOther.FieldName = "Other"
        Me.colOther.Name = "colOther"
        Me.colOther.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOther.Visible = True
        Me.colOther.VisibleIndex = 18
        Me.colOther.Width = 53
        '
        'colOtherComment
        '
        Me.colOtherComment.FieldName = "OtherComment"
        Me.colOtherComment.Name = "colOtherComment"
        Me.colOtherComment.Visible = True
        Me.colOtherComment.VisibleIndex = 19
        Me.colOtherComment.Width = 53
        '
        'colComment
        '
        Me.colComment.FieldName = "Comment"
        Me.colComment.Name = "colComment"
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 21
        Me.colComment.Width = 53
        '
        'colRemark
        '
        Me.colRemark.FieldName = "Remark"
        Me.colRemark.Name = "colRemark"
        Me.colRemark.Visible = True
        Me.colRemark.VisibleIndex = 22
        Me.colRemark.Width = 53
        '
        'colPayDate
        '
        Me.colPayDate.FieldName = "PayDate"
        Me.colPayDate.Name = "colPayDate"
        Me.colPayDate.Visible = True
        Me.colPayDate.VisibleIndex = 3
        Me.colPayDate.Width = 79
        '
        'colPayAmount
        '
        Me.colPayAmount.Caption = "Payment"
        Me.colPayAmount.FieldName = "PayAmount"
        Me.colPayAmount.Name = "colPayAmount"
        Me.colPayAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPayAmount.Visible = True
        Me.colPayAmount.VisibleIndex = 4
        Me.colPayAmount.Width = 50
        '
        'colPayDate1
        '
        Me.colPayDate1.FieldName = "PayDate1"
        Me.colPayDate1.Name = "colPayDate1"
        Me.colPayDate1.Visible = True
        Me.colPayDate1.VisibleIndex = 5
        Me.colPayDate1.Width = 50
        '
        'colPayAmount1
        '
        Me.colPayAmount1.Caption = "Payment 1"
        Me.colPayAmount1.FieldName = "PayAmount1"
        Me.colPayAmount1.Name = "colPayAmount1"
        Me.colPayAmount1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPayAmount1.Visible = True
        Me.colPayAmount1.VisibleIndex = 6
        Me.colPayAmount1.Width = 50
        '
        'colPayDate2
        '
        Me.colPayDate2.FieldName = "PayDate2"
        Me.colPayDate2.Name = "colPayDate2"
        Me.colPayDate2.Visible = True
        Me.colPayDate2.VisibleIndex = 7
        Me.colPayDate2.Width = 50
        '
        'colPayAmount2
        '
        Me.colPayAmount2.Caption = "Payment 2"
        Me.colPayAmount2.FieldName = "PayAmount2"
        Me.colPayAmount2.Name = "colPayAmount2"
        Me.colPayAmount2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPayAmount2.Visible = True
        Me.colPayAmount2.VisibleIndex = 8
        Me.colPayAmount2.Width = 50
        '
        'colPayDate3
        '
        Me.colPayDate3.FieldName = "PayDate3"
        Me.colPayDate3.Name = "colPayDate3"
        Me.colPayDate3.Visible = True
        Me.colPayDate3.VisibleIndex = 9
        Me.colPayDate3.Width = 50
        '
        'colPayAmount3
        '
        Me.colPayAmount3.Caption = "Payment 3"
        Me.colPayAmount3.FieldName = "PayAmount3"
        Me.colPayAmount3.Name = "colPayAmount3"
        Me.colPayAmount3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPayAmount3.Visible = True
        Me.colPayAmount3.VisibleIndex = 10
        Me.colPayAmount3.Width = 50
        '
        'colPayDate4
        '
        Me.colPayDate4.FieldName = "PayDate4"
        Me.colPayDate4.Name = "colPayDate4"
        Me.colPayDate4.Visible = True
        Me.colPayDate4.VisibleIndex = 11
        Me.colPayDate4.Width = 50
        '
        'colPayAmount4
        '
        Me.colPayAmount4.Caption = "Payment 4"
        Me.colPayAmount4.FieldName = "PayAmount4"
        Me.colPayAmount4.Name = "colPayAmount4"
        Me.colPayAmount4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPayAmount4.Visible = True
        Me.colPayAmount4.VisibleIndex = 12
        Me.colPayAmount4.Width = 50
        '
        'colPayDate5
        '
        Me.colPayDate5.FieldName = "PayDate5"
        Me.colPayDate5.Name = "colPayDate5"
        Me.colPayDate5.Visible = True
        Me.colPayDate5.VisibleIndex = 13
        Me.colPayDate5.Width = 50
        '
        'colPayAmount5
        '
        Me.colPayAmount5.Caption = "Payment 5"
        Me.colPayAmount5.FieldName = "PayAmount5"
        Me.colPayAmount5.Name = "colPayAmount5"
        Me.colPayAmount5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPayAmount5.Width = 67
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'frmInvoicePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 523)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmInvoicePayment"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Invoice Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvoiceDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.vgSalesHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSoMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInvoicePayDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalesOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bsInvoiceDetails As BindingSource
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInvoicePayDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents beOrders As DevExpress.XtraBars.BarEditItem
    Friend WithEvents repOrders As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents colInvoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreditNoteValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRetention As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalanceAfterRetenContra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOther As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOtherComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayAmount1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayAmount2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayAmount3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayDate4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayAmount4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayDate5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayAmount5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsSoMaster As BindingSource
    Friend WithEvents bsSalesOrders As BindingSource
    Friend WithEvents vgSalesHeader As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents btnSearch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowSalesOrder As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOrderStatus As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowActiveFlag As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCancelledFlag As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDocumentType As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCustomer As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSalesperson As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCustomerPoNumber As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOrderDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowReqShipDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOperator As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class

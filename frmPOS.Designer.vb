<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOS
    Inherits System.Windows.Forms.Form
    ''''Uncomment the line above to bring the form to original windows forms
    '''''''then copy the enclose with comments asterisk code
    '******************************************************************************************
    'Inherits PDSAFormBase
    Public Sub New()
        MyBase.New()
        DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Tahoma", 8.5)
        ' Track User Flag must be set here or it won't be set in time
        ' MyBase.UserTrack = False

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' This is done for apparent speed
        Dim ctlSelected As Control
        ctlSelected = PDSAForms.GetActiveMDIChildControl(Me)

        'Add any initialization after the InitializeComponent() call

        'MyBase.CheckSecurityOnControls = True
    End Sub
    ''******************************************************************************************
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)

        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.PosGrid = New System.Windows.Forms.DataGridView()
        Me.ProdID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyordrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyordrduom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtydlvrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uomdlvrd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.netamnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLUOMID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adddiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.tbSQL = New DevExpress.XtraEditors.TextEdit()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DGRetrieve = New System.Windows.Forms.DataGridView()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.stckid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.barcode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.items = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbPriceMode = New System.Windows.Forms.ComboBox()
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ceRefno = New DevExpress.XtraEditors.CalcEdit()
        Me.txtTendered = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtStckid = New System.Windows.Forms.TextBox()
        Me.txtbcodes = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.btnSearchItems = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomers = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPriceMode = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaves = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCreditPay = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSuspend = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRetrievePO = New DevExpress.XtraEditors.SimpleButton()
        Me.btnType = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLookuprice = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReprint = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDiscount = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemoveRate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnnew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBcode = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefund = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCounts = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgEmps = New System.Windows.Forms.DataGridView()
        Me.wtid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waiter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceWtid = New DevExpress.XtraEditors.CalcEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ceQtyy = New DevExpress.XtraEditors.CalcEdit()
        Me.dgitems = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSetQty = New DevExpress.XtraEditors.SimpleButton()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.txtSalesman = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtInstruction = New System.Windows.Forms.TextBox()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InputCustomerNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesForTodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveryReceivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPlNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PlDate = New DevExpress.XtraEditors.TextEdit()
        Me.btnSaveInvoice = New DevExpress.XtraEditors.SimpleButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalItems = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnPlusDisc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNewItem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.lePicklistNumbers = New DevExpress.XtraEditors.LookUpEdit()
        Me.cePrice = New DevExpress.XtraEditors.CalcEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ceRate = New DevExpress.XtraEditors.CalcEdit()
        Me.ceUOMid = New DevExpress.XtraEditors.CalcEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLotNo = New DevExpress.XtraEditors.TextEdit()
        Me.deInvDate = New DevExpress.XtraEditors.DateEdit()
        CType(Me.PosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceRefno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEmps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceWtid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceQtyy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.txtPlNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lePicklistNumbers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceUOMid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLotNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deInvDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deInvDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.Color.AliceBlue
        Me.txtSum.Enabled = False
        Me.txtSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSum.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtSum.Location = New System.Drawing.Point(1053, 669)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtSum, False)
        Me.txtSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSum.Size = New System.Drawing.Size(104, 29)
        Me.txtSum.TabIndex = 19
        Me.txtSum.TabStop = False
        '
        'txtitem
        '
        Me.txtitem.Enabled = False
        Me.txtitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitem.Location = New System.Drawing.Point(389, 761)
        Me.txtitem.Name = "txtitem"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtitem, False)
        Me.txtitem.Size = New System.Drawing.Size(464, 29)
        Me.txtitem.TabIndex = 1
        Me.txtitem.Visible = False
        '
        'PosGrid
        '
        Me.PosGrid.AllowUserToAddRows = False
        Me.PosGrid.AllowUserToDeleteRows = False
        Me.PosGrid.AllowUserToOrderColumns = True
        Me.PosGrid.AllowUserToResizeColumns = False
        Me.PosGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PosGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.PosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PosGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdID, Me.productcode, Me.Item, Me.qtyordrd, Me.qtyordrduom, Me.qtydlvrd, Me.uomdlvrd, Me.Price, Me.Rate, Me.Amount, Me.netamnt, Me.LotNo, Me.ExpiryDate, Me.categoryid, Me.PLUOMID, Me.adddiscount})
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PosGrid.DefaultCellStyle = DataGridViewCellStyle21
        Me.PosGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.PosGrid.Enabled = False
        Me.PosGrid.Location = New System.Drawing.Point(12, 151)
        Me.PosGrid.MultiSelect = False
        Me.PosGrid.Name = "PosGrid"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PosGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PosGrid.RowsDefaultCellStyle = DataGridViewCellStyle23
        Me.PosGrid.RowTemplate.Height = 30
        Me.PosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PosGrid.Size = New System.Drawing.Size(1145, 512)
        Me.PosGrid.TabIndex = 12
        '
        'ProdID
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdID.DefaultCellStyle = DataGridViewCellStyle10
        Me.ProdID.HeaderText = "ProdID"
        Me.ProdID.Name = "ProdID"
        Me.ProdID.ReadOnly = True
        Me.ProdID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProdID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ProdID.Visible = False
        '
        'productcode
        '
        Me.productcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productcode.DefaultCellStyle = DataGridViewCellStyle11
        Me.productcode.HeaderText = "Product Code"
        Me.productcode.MaxInputLength = 22
        Me.productcode.Name = "productcode"
        Me.productcode.ReadOnly = True
        Me.productcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.productcode.Visible = False
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Item.DefaultCellStyle = DataGridViewCellStyle12
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'qtyordrd
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.qtyordrd.DefaultCellStyle = DataGridViewCellStyle13
        Me.qtyordrd.HeaderText = "Qty Ordered"
        Me.qtyordrd.Name = "qtyordrd"
        Me.qtyordrd.ReadOnly = True
        Me.qtyordrd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.qtyordrd.Width = 120
        '
        'qtyordrduom
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.qtyordrduom.DefaultCellStyle = DataGridViewCellStyle14
        Me.qtyordrduom.HeaderText = "UOM"
        Me.qtyordrduom.Name = "qtyordrduom"
        Me.qtyordrduom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.qtyordrduom.Width = 70
        '
        'qtydlvrd
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.qtydlvrd.DefaultCellStyle = DataGridViewCellStyle15
        Me.qtydlvrd.HeaderText = "Qty Dlvrd"
        Me.qtydlvrd.Name = "qtydlvrd"
        Me.qtydlvrd.ReadOnly = True
        Me.qtydlvrd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'uomdlvrd
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.uomdlvrd.DefaultCellStyle = DataGridViewCellStyle16
        Me.uomdlvrd.HeaderText = "UOM"
        Me.uomdlvrd.Name = "uomdlvrd"
        Me.uomdlvrd.ReadOnly = True
        Me.uomdlvrd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.uomdlvrd.Width = 70
        '
        'Price
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0"
        Me.Price.DefaultCellStyle = DataGridViewCellStyle17
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Price.Width = 120
        '
        'Rate
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle18
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Rate.Width = 60
        '
        'Amount
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle19
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'netamnt
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.netamnt.DefaultCellStyle = DataGridViewCellStyle20
        Me.netamnt.HeaderText = "Net Amount"
        Me.netamnt.Name = "netamnt"
        Me.netamnt.ReadOnly = True
        Me.netamnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.netamnt.Width = 150
        '
        'LotNo
        '
        Me.LotNo.HeaderText = "Lot No"
        Me.LotNo.Name = "LotNo"
        Me.LotNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ExpiryDate
        '
        Me.ExpiryDate.HeaderText = "Expiry Date"
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'categoryid
        '
        Me.categoryid.HeaderText = "categoryid"
        Me.categoryid.Name = "categoryid"
        Me.categoryid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.categoryid.Visible = False
        Me.categoryid.Width = 5
        '
        'PLUOMID
        '
        Me.PLUOMID.HeaderText = "PLUOMID"
        Me.PLUOMID.Name = "PLUOMID"
        Me.PLUOMID.Visible = False
        '
        'adddiscount
        '
        Me.adddiscount.HeaderText = "adddiscount"
        Me.adddiscount.Name = "adddiscount"
        Me.adddiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.adddiscount.Visible = False
        Me.adddiscount.Width = 5
        '
        'txtBarcode
        '
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(140, 764)
        Me.txtBarcode.Name = "txtBarcode"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtBarcode, False)
        Me.txtBarcode.Size = New System.Drawing.Size(189, 26)
        Me.txtBarcode.TabIndex = 0
        Me.txtBarcode.Visible = False
        '
        'tbSQL
        '
        Me.tbSQL.Location = New System.Drawing.Point(696, 793)
        Me.tbSQL.Name = "tbSQL"
        Me.tbSQL.Size = New System.Drawing.Size(27, 20)
        Me.tbSQL.TabIndex = 22
        Me.tbSQL.TabStop = False
        Me.tbSQL.Visible = False
        '
        'DGRetrieve
        '
        Me.DGRetrieve.AllowUserToAddRows = False
        Me.DGRetrieve.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRetrieve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGRetrieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGRetrieve.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGRetrieve.Location = New System.Drawing.Point(294, 165)
        Me.DGRetrieve.Name = "DGRetrieve"
        Me.DGRetrieve.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRetrieve.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGRetrieve.Size = New System.Drawing.Size(233, 343)
        Me.DGRetrieve.TabIndex = 30
        Me.DGRetrieve.Visible = False
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.EditValue = ""
        Me.GridLookUpEdit2.Enabled = False
        Me.GridLookUpEdit2.EnterMoveNextControl = True
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(23, 780)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLookUpEdit2.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2.Properties.AppearanceFocused.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.PopupFormSize = New System.Drawing.Size(860, 600)
        Me.GridLookUpEdit2.Properties.PopupView = Me.GridLookUpEdit2View
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(77, 32)
        Me.GridLookUpEdit2.TabIndex = 1
        Me.GridLookUpEdit2.ToolTip = "Press CTRL + I to move focus to Item Search"
        Me.GridLookUpEdit2.Visible = False
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridLookUpEdit2View.Appearance.FilterPanel.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.FocusedCell.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.FocusedRow.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.GridLookUpEdit2View.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.Row.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.SelectedRow.Options.UseFont = True
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.stckid, Me.barcode1, Me.items, Me.GridColumn4, Me.GridColumn5, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsBehavior.AllowPartialRedrawOnScrolling = False
        Me.GridLookUpEdit2View.OptionsFind.AlwaysVisible = True
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'stckid
        '
        Me.stckid.Caption = "StockID"
        Me.stckid.FieldName = "stckid"
        Me.stckid.Name = "stckid"
        Me.stckid.Width = 96
        '
        'barcode1
        '
        Me.barcode1.AppearanceHeader.Options.UseTextOptions = True
        Me.barcode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.barcode1.Caption = "Barcode"
        Me.barcode1.FieldName = "barcode"
        Me.barcode1.Name = "barcode1"
        Me.barcode1.Width = 197
        '
        'items
        '
        Me.items.AppearanceHeader.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.items.AppearanceHeader.Options.UseFont = True
        Me.items.Caption = "Item Description"
        Me.items.FieldName = "itemdesc"
        Me.items.Name = "items"
        Me.items.Visible = True
        Me.items.VisibleIndex = 0
        Me.items.Width = 526
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Selling Price"
        Me.GridColumn4.DisplayFormat.FormatString = "N2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "retail"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 170
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Wholesale"
        Me.GridColumn5.DisplayFormat.FormatString = "N2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "retail2"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 185
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GridColumn8"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 33
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 33
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "GridColumn10"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 33
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "GridColumn11"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 33
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "GridColumn12"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Width = 33
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "GridColumn13"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Width = 57
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "GridColumn7"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        '
        'cmbPriceMode
        '
        Me.cmbPriceMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPriceMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbPriceMode.FormattingEnabled = True
        Me.cmbPriceMode.Items.AddRange(New Object() {"Retail", "Wholesale", "Refund"})
        Me.cmbPriceMode.Location = New System.Drawing.Point(719, 754)
        Me.cmbPriceMode.Name = "cmbPriceMode"
        Me.cmbPriceMode.Size = New System.Drawing.Size(281, 37)
        Me.cmbPriceMode.TabIndex = 43
        Me.cmbPriceMode.Text = "Retail"
        Me.cmbPriceMode.Visible = False
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentType.ForeColor = System.Drawing.Color.Green
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Items.AddRange(New Object() {"CASH", "CREDIT", "CHEQUE"})
        Me.cmbPaymentType.Location = New System.Drawing.Point(60, 781)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(60, 37)
        Me.cmbPaymentType.TabIndex = 44
        Me.cmbPaymentType.Text = "CREDIT"
        Me.cmbPaymentType.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(496, 791)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "A m o u n t   T e n d e r e d"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(793, 788)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CHANGE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'ceRefno
        '
        Me.ceRefno.Enabled = False
        Me.ceRefno.Location = New System.Drawing.Point(834, 798)
        Me.ceRefno.Name = "ceRefno"
        Me.ceRefno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceRefno.Properties.Appearance.Options.UseFont = True
        Me.ceRefno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceRefno.Size = New System.Drawing.Size(144, 26)
        Me.ceRefno.TabIndex = 49
        Me.ceRefno.Visible = False
        '
        'txtTendered
        '
        Me.txtTendered.BackColor = System.Drawing.Color.White
        Me.txtTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTendered.ForeColor = System.Drawing.Color.Blue
        Me.txtTendered.Location = New System.Drawing.Point(527, 764)
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.ReadOnly = True
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtTendered, False)
        Me.txtTendered.Size = New System.Drawing.Size(70, 49)
        Me.txtTendered.TabIndex = 54
        Me.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTendered.Visible = False
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.White
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Red
        Me.lblChange.Location = New System.Drawing.Point(1105, 770)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.ReadOnly = True
        Me.NetResize1.SetResizeTextBoxMultiline(Me.lblChange, False)
        Me.lblChange.Size = New System.Drawing.Size(38, 49)
        Me.lblChange.TabIndex = 55
        Me.lblChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lblChange.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Customer"
        '
        'txtcustid
        '
        Me.txtcustid.Enabled = False
        Me.txtcustid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtcustid.Location = New System.Drawing.Point(480, -42)
        Me.txtcustid.Name = "txtcustid"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtcustid, False)
        Me.txtcustid.Size = New System.Drawing.Size(27, 26)
        Me.txtcustid.TabIndex = 58
        Me.txtcustid.Text = "1"
        Me.txtcustid.Visible = False
        '
        'txtlastname
        '
        Me.txtlastname.Enabled = False
        Me.txtlastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtlastname.Location = New System.Drawing.Point(417, 9)
        Me.txtlastname.Name = "txtlastname"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtlastname, False)
        Me.txtlastname.Size = New System.Drawing.Size(255, 26)
        Me.txtlastname.TabIndex = 58
        Me.txtlastname.Text = "Name"
        '
        'txtfirstname
        '
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtfirstname.Location = New System.Drawing.Point(729, -42)
        Me.txtfirstname.Name = "txtfirstname"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtfirstname, False)
        Me.txtfirstname.Size = New System.Drawing.Size(37, 26)
        Me.txtfirstname.TabIndex = 58
        Me.txtfirstname.Visible = False
        '
        'txtStckid
        '
        Me.txtStckid.Enabled = False
        Me.txtStckid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStckid.Location = New System.Drawing.Point(798, 790)
        Me.txtStckid.Name = "txtStckid"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtStckid, False)
        Me.txtStckid.Size = New System.Drawing.Size(55, 20)
        Me.txtStckid.TabIndex = 59
        Me.txtStckid.Visible = False
        '
        'txtbcodes
        '
        Me.txtbcodes.Enabled = False
        Me.txtbcodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbcodes.Location = New System.Drawing.Point(633, 765)
        Me.txtbcodes.MaxLength = 22
        Me.txtbcodes.Name = "txtbcodes"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtbcodes, False)
        Me.txtbcodes.Size = New System.Drawing.Size(94, 29)
        Me.txtbcodes.TabIndex = 61
        Me.txtbcodes.Visible = False
        '
        'txtqty
        '
        Me.txtqty.Enabled = False
        Me.txtqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(566, 765)
        Me.txtqty.MaxLength = 22
        Me.txtqty.Name = "txtqty"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtqty, False)
        Me.txtqty.Size = New System.Drawing.Size(45, 29)
        Me.txtqty.TabIndex = 61
        Me.txtqty.Visible = False
        '
        'btnSearchItems
        '
        Me.btnSearchItems.ImageOptions.Image = CType(resources.GetObject("btnSearchItems.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearchItems.Location = New System.Drawing.Point(859, 761)
        Me.btnSearchItems.Name = "btnSearchItems"
        Me.btnSearchItems.Size = New System.Drawing.Size(97, 30)
        Me.btnSearchItems.TabIndex = 64
        Me.btnSearchItems.Text = "Find &Item"
        Me.btnSearchItems.Visible = False
        '
        'btnCustomers
        '
        Me.btnCustomers.ImageOptions.Image = CType(resources.GetObject("btnCustomers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCustomers.Location = New System.Drawing.Point(106, 767)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(136, 41)
        Me.btnCustomers.TabIndex = 65
        Me.btnCustomers.Text = "Find &Customer"
        Me.btnCustomers.Visible = False
        '
        'btnPriceMode
        '
        Me.btnPriceMode.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPriceMode.Appearance.Options.UseFont = True
        Me.btnPriceMode.Location = New System.Drawing.Point(683, 781)
        Me.btnPriceMode.Name = "btnPriceMode"
        Me.btnPriceMode.Size = New System.Drawing.Size(282, 30)
        Me.btnPriceMode.TabIndex = 66
        Me.btnPriceMode.Text = "S e &l l    T y p e"
        Me.btnPriceMode.Visible = False
        '
        'btnSaves
        '
        Me.btnSaves.ImageOptions.Image = CType(resources.GetObject("btnSaves.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaves.Location = New System.Drawing.Point(585, 759)
        Me.btnSaves.Name = "btnSaves"
        Me.btnSaves.Size = New System.Drawing.Size(138, 38)
        Me.btnSaves.TabIndex = 67
        Me.btnSaves.Text = "Take Payment(F12)"
        Me.btnSaves.Visible = False
        '
        'btnCreditPay
        '
        Me.btnCreditPay.ImageOptions.Image = CType(resources.GetObject("btnCreditPay.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCreditPay.Location = New System.Drawing.Point(661, 772)
        Me.btnCreditPay.Name = "btnCreditPay"
        Me.btnCreditPay.Size = New System.Drawing.Size(131, 38)
        Me.btnCreditPay.TabIndex = 68
        Me.btnCreditPay.Text = "Pa&y Credit(F3)"
        Me.btnCreditPay.Visible = False
        '
        'btnSuspend
        '
        Me.btnSuspend.ImageOptions.Image = CType(resources.GetObject("btnSuspend.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSuspend.Location = New System.Drawing.Point(346, 764)
        Me.btnSuspend.Name = "btnSuspend"
        Me.btnSuspend.Size = New System.Drawing.Size(138, 38)
        Me.btnSuspend.TabIndex = 69
        Me.btnSuspend.Text = "Suspend(F5)"
        Me.btnSuspend.Visible = False
        '
        'btnRetrievePO
        '
        Me.btnRetrievePO.ImageOptions.Image = CType(resources.GetObject("btnRetrievePO.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRetrievePO.Location = New System.Drawing.Point(12, 669)
        Me.btnRetrievePO.Name = "btnRetrievePO"
        Me.btnRetrievePO.Size = New System.Drawing.Size(112, 41)
        Me.btnRetrievePO.TabIndex = 0
        Me.btnRetrievePO.Text = "&Retrieve PO"
        '
        'btnType
        '
        Me.btnType.ImageOptions.Image = CType(resources.GetObject("btnType.ImageOptions.Image"), System.Drawing.Image)
        Me.btnType.Location = New System.Drawing.Point(257, 772)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(137, 41)
        Me.btnType.TabIndex = 72
        Me.btnType.Text = "&Type of Payment"
        Me.btnType.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(718, 805)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl1.TabIndex = 73
        Me.LabelControl1.Text = "Reference No."
        Me.LabelControl1.ToolTip = "Press F4 to Reprint Sales or Credit"
        Me.LabelControl1.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(400, 764)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(137, 41)
        Me.btnRemove.TabIndex = 74
        Me.btnRemove.Text = "&Remove Item"
        Me.btnRemove.Visible = False
        '
        'btnLookuprice
        '
        Me.btnLookuprice.ImageOptions.Image = CType(resources.GetObject("btnLookuprice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLookuprice.Location = New System.Drawing.Point(434, 773)
        Me.btnLookuprice.Name = "btnLookuprice"
        Me.btnLookuprice.Size = New System.Drawing.Size(129, 41)
        Me.btnLookuprice.TabIndex = 75
        Me.btnLookuprice.Text = "Price Lookup(F2)"
        Me.btnLookuprice.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(240, 670)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 41)
        Me.btnCancel.TabIndex = 76
        Me.btnCancel.Text = "&Cancel"
        '
        'btnReprint
        '
        Me.btnReprint.ImageOptions.Image = CType(resources.GetObject("btnReprint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReprint.Location = New System.Drawing.Point(635, 767)
        Me.btnReprint.Name = "btnReprint"
        Me.btnReprint.Size = New System.Drawing.Size(131, 41)
        Me.btnReprint.TabIndex = 77
        Me.btnReprint.Text = "Re-Print(F4)"
        Me.btnReprint.Visible = False
        '
        'Button1
        '
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(23, 764)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 41)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Set &Quantity"
        Me.Button1.Visible = False
        '
        'btnDiscount
        '
        Me.btnDiscount.ImageOptions.Image = CType(resources.GetObject("btnDiscount.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDiscount.Location = New System.Drawing.Point(971, 773)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(105, 41)
        Me.btnDiscount.TabIndex = 83
        Me.btnDiscount.Text = "&Discount"
        Me.btnDiscount.Visible = False
        '
        'btnRemoveRate
        '
        Me.btnRemoveRate.Enabled = False
        Me.btnRemoveRate.ImageOptions.Image = CType(resources.GetObject("btnRemoveRate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemoveRate.Location = New System.Drawing.Point(333, 670)
        Me.btnRemoveRate.Name = "btnRemoveRate"
        Me.btnRemoveRate.Size = New System.Drawing.Size(115, 41)
        Me.btnRemoveRate.TabIndex = 84
        Me.btnRemoveRate.Text = "Clear Discount"
        '
        'btnnew
        '
        Me.btnnew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Appearance.Options.UseFont = True
        Me.btnnew.ImageOptions.Image = CType(resources.GetObject("btnnew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnnew.Location = New System.Drawing.Point(296, 784)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(159, 35)
        Me.btnnew.TabIndex = 85
        Me.btnnew.Text = "&N e w   T r a n s a c t i o n"
        Me.btnnew.Visible = False
        '
        'btnBcode
        '
        Me.btnBcode.ImageOptions.Image = CType(resources.GetObject("btnBcode.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBcode.Location = New System.Drawing.Point(1065, 773)
        Me.btnBcode.Name = "btnBcode"
        Me.btnBcode.Size = New System.Drawing.Size(39, 29)
        Me.btnBcode.TabIndex = 86
        Me.btnBcode.Text = "&Barcode"
        Me.btnBcode.Visible = False
        '
        'btnRefund
        '
        Me.btnRefund.ImageOptions.Image = CType(resources.GetObject("btnRefund.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefund.Location = New System.Drawing.Point(1082, 773)
        Me.btnRefund.Name = "btnRefund"
        Me.btnRefund.Size = New System.Drawing.Size(105, 41)
        Me.btnRefund.TabIndex = 83
        Me.btnRefund.Text = "Refund"
        Me.btnRefund.Visible = False
        '
        'txtCounts
        '
        Me.txtCounts.Enabled = False
        Me.txtCounts.Location = New System.Drawing.Point(775, 666)
        Me.txtCounts.Name = "txtCounts"
        Me.txtCounts.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCounts.Properties.Appearance.Options.UseFont = True
        Me.txtCounts.Size = New System.Drawing.Size(45, 32)
        ToolTipTitleItem2.Text = "ITEMS SOLD"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "TOTAL COUNT OF ITEMS SOLD"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txtCounts.SuperTip = SuperToolTip2
        Me.txtCounts.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(916, 806)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "ITEM COUNT"
        Me.Label1.Visible = False
        '
        'dgEmps
        '
        Me.dgEmps.AllowUserToAddRows = False
        Me.dgEmps.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.wtid, Me.waiter})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEmps.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgEmps.Location = New System.Drawing.Point(294, 151)
        Me.dgEmps.Name = "dgEmps"
        Me.dgEmps.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmps.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgEmps.Size = New System.Drawing.Size(450, 395)
        Me.dgEmps.TabIndex = 90
        Me.dgEmps.Visible = False
        '
        'wtid
        '
        Me.wtid.HeaderText = "wtid"
        Me.wtid.Name = "wtid"
        Me.wtid.ReadOnly = True
        Me.wtid.Visible = False
        '
        'waiter
        '
        Me.waiter.HeaderText = "Employee Name"
        Me.waiter.Name = "waiter"
        Me.waiter.ReadOnly = True
        Me.waiter.Width = 400
        '
        'ceWtid
        '
        Me.ceWtid.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ceWtid.Location = New System.Drawing.Point(1006, 794)
        Me.ceWtid.Name = "ceWtid"
        Me.ceWtid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceWtid.Size = New System.Drawing.Size(51, 20)
        Me.ceWtid.TabIndex = 91
        Me.ceWtid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(835, 776)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "QTY"
        Me.Label5.Visible = False
        '
        'ceQtyy
        '
        Me.ceQtyy.Enabled = False
        Me.ceQtyy.EnterMoveNextControl = True
        Me.ceQtyy.Location = New System.Drawing.Point(85, 82)
        Me.ceQtyy.Name = "ceQtyy"
        Me.ceQtyy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceQtyy.Properties.Appearance.Options.UseFont = True
        Me.ceQtyy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceQtyy.Size = New System.Drawing.Size(97, 26)
        Me.ceQtyy.TabIndex = 222
        '
        'dgitems
        '
        Me.dgitems.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgitems.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgitems.Location = New System.Drawing.Point(761, 185)
        Me.dgitems.Name = "dgitems"
        Me.dgitems.ReadOnly = True
        Me.dgitems.Size = New System.Drawing.Size(265, 267)
        Me.dgitems.TabIndex = 92
        Me.dgitems.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(829, 674)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 24)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Total Items"
        '
        'btnSetQty
        '
        Me.btnSetQty.Location = New System.Drawing.Point(558, 757)
        Me.btnSetQty.Name = "btnSetQty"
        Me.btnSetQty.Size = New System.Drawing.Size(114, 23)
        Me.btnSetQty.TabIndex = 94
        Me.btnSetQty.TabStop = False
        Me.btnSetQty.Text = "&Quanity Change"
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'txtSalesman
        '
        Me.txtSalesman.Enabled = False
        Me.txtSalesman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtSalesman.Location = New System.Drawing.Point(761, 9)
        Me.txtSalesman.Name = "txtSalesman"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtSalesman, False)
        Me.txtSalesman.Size = New System.Drawing.Size(204, 26)
        Me.txtSalesman.TabIndex = 96
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtAddress.Location = New System.Drawing.Point(86, 45)
        Me.txtAddress.Name = "txtAddress"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtAddress, False)
        Me.txtAddress.Size = New System.Drawing.Size(879, 26)
        Me.txtAddress.TabIndex = 58
        '
        'txtInstruction
        '
        Me.txtInstruction.Enabled = False
        Me.txtInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtInstruction.Location = New System.Drawing.Point(157, 119)
        Me.txtInstruction.Name = "txtInstruction"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtInstruction, False)
        Me.txtInstruction.Size = New System.Drawing.Size(1000, 26)
        Me.txtInstruction.TabIndex = 58
        '
        'txtTerms
        '
        Me.txtTerms.Enabled = False
        Me.txtTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtTerms.Location = New System.Drawing.Point(1051, 41)
        Me.txtTerms.Name = "txtTerms"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtTerms, False)
        Me.txtTerms.Size = New System.Drawing.Size(106, 26)
        Me.txtTerms.TabIndex = 96
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputCustomerNameToolStripMenuItem, Me.SalesForTodayToolStripMenuItem, Me.NewItemToolStripMenuItem, Me.EditItemToolStripMenuItem, Me.TransferStockToolStripMenuItem, Me.ReceiveStockToolStripMenuItem, Me.DeliveryReceivingToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(232, 186)
        '
        'InputCustomerNameToolStripMenuItem
        '
        Me.InputCustomerNameToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputCustomerNameToolStripMenuItem.Name = "InputCustomerNameToolStripMenuItem"
        Me.InputCustomerNameToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.InputCustomerNameToolStripMenuItem.Text = "Input &Customer Name"
        '
        'SalesForTodayToolStripMenuItem
        '
        Me.SalesForTodayToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SalesForTodayToolStripMenuItem.Name = "SalesForTodayToolStripMenuItem"
        Me.SalesForTodayToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.SalesForTodayToolStripMenuItem.Text = "&Sales for Today"
        '
        'NewItemToolStripMenuItem
        '
        Me.NewItemToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NewItemToolStripMenuItem.Name = "NewItemToolStripMenuItem"
        Me.NewItemToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.NewItemToolStripMenuItem.Text = "&New Item"
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.EditItemToolStripMenuItem.Text = "&Edit Item"
        '
        'TransferStockToolStripMenuItem
        '
        Me.TransferStockToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TransferStockToolStripMenuItem.Name = "TransferStockToolStripMenuItem"
        Me.TransferStockToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.TransferStockToolStripMenuItem.Text = "&Transfer Stock"
        '
        'ReceiveStockToolStripMenuItem
        '
        Me.ReceiveStockToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ReceiveStockToolStripMenuItem.Name = "ReceiveStockToolStripMenuItem"
        Me.ReceiveStockToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ReceiveStockToolStripMenuItem.Text = "&Receive Stock"
        '
        'DeliveryReceivingToolStripMenuItem
        '
        Me.DeliveryReceivingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DeliveryReceivingToolStripMenuItem.Name = "DeliveryReceivingToolStripMenuItem"
        Me.DeliveryReceivingToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.DeliveryReceivingToolStripMenuItem.Text = "Delivery Receiving"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "PL No."
        '
        'txtPlNo
        '
        Me.txtPlNo.Enabled = False
        Me.txtPlNo.Location = New System.Drawing.Point(85, 9)
        Me.txtPlNo.Name = "txtPlNo"
        Me.txtPlNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlNo.Properties.Appearance.Options.UseFont = True
        Me.txtPlNo.Size = New System.Drawing.Size(100, 26)
        Me.txtPlNo.TabIndex = 95
        Me.txtPlNo.ToolTip = "Input the Picklist number and  press enter to load the order."
        Me.txtPlNo.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(675, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 20)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Salesman"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(996, 674)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 24)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(980, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 20)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "PL Date"
        '
        'PlDate
        '
        Me.PlDate.Enabled = False
        Me.PlDate.Location = New System.Drawing.Point(1051, 9)
        Me.PlDate.Name = "PlDate"
        Me.PlDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlDate.Properties.Appearance.Options.UseFont = True
        Me.PlDate.Size = New System.Drawing.Size(106, 26)
        Me.PlDate.TabIndex = 97
        '
        'btnSaveInvoice
        '
        Me.btnSaveInvoice.Enabled = False
        Me.btnSaveInvoice.ImageOptions.Image = CType(resources.GetObject("btnSaveInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaveInvoice.Location = New System.Drawing.Point(130, 669)
        Me.btnSaveInvoice.Name = "btnSaveInvoice"
        Me.btnSaveInvoice.Size = New System.Drawing.Size(104, 41)
        Me.btnSaveInvoice.TabIndex = 98
        Me.btnSaveInvoice.Text = "&Save Invoice"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(669, 674)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 24)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Item Count"
        '
        'txtTotalItems
        '
        Me.txtTotalItems.Enabled = False
        Me.txtTotalItems.Location = New System.Drawing.Point(935, 666)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItems.Properties.Appearance.Options.UseFont = True
        Me.txtTotalItems.Size = New System.Drawing.Size(55, 32)
        ToolTipTitleItem1.Text = "ITEMS SOLD"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "TOTAL COUNT OF ITEMS SOLD"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txtTotalItems.SuperTip = SuperToolTip1
        Me.txtTotalItems.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Delviery Instruction"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Address:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(980, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 20)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Terms"
        '
        'btnPlusDisc
        '
        Me.btnPlusDisc.Enabled = False
        Me.btnPlusDisc.ImageOptions.Image = CType(resources.GetObject("btnPlusDisc.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPlusDisc.Location = New System.Drawing.Point(454, 669)
        Me.btnPlusDisc.Name = "btnPlusDisc"
        Me.btnPlusDisc.Size = New System.Drawing.Size(98, 41)
        Me.btnPlusDisc.TabIndex = 84
        Me.btnPlusDisc.Text = "+ Discount"
        '
        'btnNewItem
        '
        Me.btnNewItem.Enabled = False
        Me.btnNewItem.ImageOptions.Image = CType(resources.GetObject("btnNewItem.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNewItem.Location = New System.Drawing.Point(679, 79)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(106, 34)
        Me.btnNewItem.TabIndex = 225
        Me.btnNewItem.Text = "&New Item"
        '
        'btnPrint
        '
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(558, 669)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(105, 42)
        Me.btnPrint.TabIndex = 100
        Me.btnPrint.Text = "&Print"
        '
        'lePicklistNumbers
        '
        Me.lePicklistNumbers.Enabled = False
        Me.lePicklistNumbers.Location = New System.Drawing.Point(86, 9)
        Me.lePicklistNumbers.Name = "lePicklistNumbers"
        Me.lePicklistNumbers.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lePicklistNumbers.Properties.Appearance.Options.UseFont = True
        Me.lePicklistNumbers.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lePicklistNumbers.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lePicklistNumbers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lePicklistNumbers.Properties.PopupFormMinSize = New System.Drawing.Size(1000, 400)
        Me.lePicklistNumbers.Properties.PopupWidth = 1000
        Me.lePicklistNumbers.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.lePicklistNumbers.Size = New System.Drawing.Size(237, 26)
        Me.lePicklistNumbers.TabIndex = 101
        '
        'cePrice
        '
        Me.cePrice.Location = New System.Drawing.Point(842, 83)
        Me.cePrice.Name = "cePrice"
        Me.cePrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cePrice.Size = New System.Drawing.Size(100, 20)
        Me.cePrice.TabIndex = 102
        Me.cePrice.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 20)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Qty:"
        '
        'ceRate
        '
        Me.ceRate.Location = New System.Drawing.Point(842, 83)
        Me.ceRate.Name = "ceRate"
        Me.ceRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceRate.Size = New System.Drawing.Size(100, 20)
        Me.ceRate.TabIndex = 223
        Me.ceRate.Visible = False
        '
        'ceUOMid
        '
        Me.ceUOMid.Location = New System.Drawing.Point(842, 82)
        Me.ceUOMid.Name = "ceUOMid"
        Me.ceUOMid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceUOMid.Size = New System.Drawing.Size(100, 20)
        Me.ceUOMid.TabIndex = 224
        Me.ceUOMid.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(197, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 20)
        Me.Label16.TabIndex = 225
        Me.Label16.Text = "Lot No.:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(399, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 20)
        Me.Label17.TabIndex = 225
        Me.Label17.Text = "Expiration Date:"
        '
        'txtLotNo
        '
        Me.txtLotNo.Enabled = False
        Me.txtLotNo.EnterMoveNextControl = True
        Me.txtLotNo.Location = New System.Drawing.Point(267, 82)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNo.Properties.Appearance.Options.UseFont = True
        Me.txtLotNo.Size = New System.Drawing.Size(100, 26)
        Me.txtLotNo.TabIndex = 223
        '
        'deInvDate
        '
        Me.deInvDate.EditValue = Nothing
        Me.deInvDate.Enabled = False
        Me.deInvDate.EnterMoveNextControl = True
        Me.deInvDate.Location = New System.Drawing.Point(536, 81)
        Me.deInvDate.Name = "deInvDate"
        Me.deInvDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deInvDate.Properties.Appearance.Options.UseFont = True
        Me.deInvDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deInvDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deInvDate.Size = New System.Drawing.Size(127, 26)
        Me.deInvDate.TabIndex = 224
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1169, 716)
        Me.Controls.Add(Me.deInvDate)
        Me.Controls.Add(Me.txtLotNo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ceUOMid)
        Me.Controls.Add(Me.ceRate)
        Me.Controls.Add(Me.cePrice)
        Me.Controls.Add(Me.lePicklistNumbers)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnNewItem)
        Me.Controls.Add(Me.btnSaveInvoice)
        Me.Controls.Add(Me.PlDate)
        Me.Controls.Add(Me.txtTerms)
        Me.Controls.Add(Me.txtSalesman)
        Me.Controls.Add(Me.txtPlNo)
        Me.Controls.Add(Me.dgitems)
        Me.Controls.Add(Me.DGRetrieve)
        Me.Controls.Add(Me.btnSetQty)
        Me.Controls.Add(Me.ceWtid)
        Me.Controls.Add(Me.dgEmps)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBcode)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnPlusDisc)
        Me.Controls.Add(Me.btnRemoveRate)
        Me.Controls.Add(Me.btnRefund)
        Me.Controls.Add(Me.btnDiscount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReprint)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLookuprice)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnType)
        Me.Controls.Add(Me.btnRetrievePO)
        Me.Controls.Add(Me.btnSuspend)
        Me.Controls.Add(Me.btnCreditPay)
        Me.Controls.Add(Me.btnSaves)
        Me.Controls.Add(Me.btnPriceMode)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnSearchItems)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtbcodes)
        Me.Controls.Add(Me.txtStckid)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtInstruction)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtcustid)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtTendered)
        Me.Controls.Add(Me.ceRefno)
        Me.Controls.Add(Me.cmbPaymentType)
        Me.Controls.Add(Me.cmbPriceMode)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.tbSQL)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ceQtyy)
        Me.Controls.Add(Me.PosGrid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalItems)
        Me.Controls.Add(Me.txtCounts)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceRefno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEmps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceWtid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceQtyy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.txtPlNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lePicklistNumbers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceUOMid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLotNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deInvDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deInvDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents txtitem As System.Windows.Forms.TextBox
    Friend WithEvents PosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents tbSQL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents DGRetrieve As System.Windows.Forms.DataGridView
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colstckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colretail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents stckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barcode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents items As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbPriceMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ceRefno As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtTendered As System.Windows.Forms.TextBox
    Friend WithEvents lblChange As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtStckid As System.Windows.Forms.TextBox
    Friend WithEvents txtbcodes As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchItems As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPriceMode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaves As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreditPay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSuspend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRetrievePO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLookuprice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveRate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnnew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBcode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefund As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCounts As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgEmps As System.Windows.Forms.DataGridView
    Friend WithEvents wtid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waiter As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents ceWtid As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ceQtyy As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents dgitems As System.Windows.Forms.DataGridView
    Public WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSetQty As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InputCustomerNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesForTodayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeliveryReceivingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtPlNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSalesman As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PlDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSaveInvoice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalItems As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInstruction As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTerms As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnPlusDisc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lePicklistNumbers As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cePrice As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label15 As Label
    Friend WithEvents ceRate As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceUOMid As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents deInvDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtLotNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ProdID As DataGridViewTextBoxColumn
    Friend WithEvents productcode As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents qtyordrd As DataGridViewTextBoxColumn
    Friend WithEvents qtyordrduom As DataGridViewTextBoxColumn
    Friend WithEvents qtydlvrd As DataGridViewTextBoxColumn
    Friend WithEvents uomdlvrd As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents netamnt As DataGridViewTextBoxColumn
    Friend WithEvents LotNo As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDate As DataGridViewTextBoxColumn
    Friend WithEvents categoryid As DataGridViewTextBoxColumn
    Friend WithEvents PLUOMID As DataGridViewTextBoxColumn
    Friend WithEvents adddiscount As DataGridViewTextBoxColumn
End Class

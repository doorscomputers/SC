<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPO
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPO))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.chkPartial = New DevExpress.XtraEditors.CheckEdit()
        Me.cePonum = New DevExpress.XtraEditors.CalcEdit()
        Me.leCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.leAgent = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInstruction = New System.Windows.Forms.TextBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnItemSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.dedlvrydate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ceQty = New DevExpress.XtraEditors.CalcEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.ceCost = New DevExpress.XtraEditors.CalcEdit()
        Me.btnSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtSupcode = New System.Windows.Forms.TextBox()
        Me.txtStckid = New System.Windows.Forms.TextBox()
        Me.cmbType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DGRetrieve = New System.Windows.Forms.DataGridView()
        Me.txtsum = New System.Windows.Forms.TextBox()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPost = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.drgrid = New System.Windows.Forms.DataGridView()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.btnRetrievePL = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cePrice = New DevExpress.XtraEditors.CalcEdit()
        Me.stckid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Division = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Picked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDate = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uomid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkPartial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cePonum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leAgent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedlvrydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedlvrydate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.cePrice)
        Me.GroupControl1.Controls.Add(Me.chkPartial)
        Me.GroupControl1.Controls.Add(Me.cePonum)
        Me.GroupControl1.Controls.Add(Me.leCustomer)
        Me.GroupControl1.Controls.Add(Me.leAgent)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtInstruction)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.btnItemSearch)
        Me.GroupControl1.Controls.Add(Me.txtItem)
        Me.GroupControl1.Controls.Add(Me.dedlvrydate)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.ceQty)
        Me.GroupControl1.Controls.Add(Me.btnAdd)
        Me.GroupControl1.Controls.Add(Me.ceCost)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(9, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1120, 129)
        Me.GroupControl1.TabIndex = 46
        Me.GroupControl1.Text = "Pick List Header"
        '
        'chkPartial
        '
        Me.chkPartial.Location = New System.Drawing.Point(975, 97)
        Me.chkPartial.Name = "chkPartial"
        Me.chkPartial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPartial.Properties.Appearance.Options.UseFont = True
        Me.chkPartial.Properties.Caption = "Partial"
        Me.chkPartial.Size = New System.Drawing.Size(126, 23)
        Me.chkPartial.TabIndex = 68
        Me.chkPartial.Visible = False
        '
        'cePonum
        '
        Me.cePonum.Location = New System.Drawing.Point(608, 51)
        Me.cePonum.Name = "cePonum"
        Me.cePonum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cePonum.Size = New System.Drawing.Size(100, 20)
        Me.cePonum.TabIndex = 55
        Me.cePonum.Visible = False
        '
        'leCustomer
        '
        Me.leCustomer.EnterMoveNextControl = True
        Me.leCustomer.Location = New System.Drawing.Point(306, 27)
        Me.leCustomer.Name = "leCustomer"
        Me.leCustomer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leCustomer.Properties.Appearance.Options.UseFont = True
        Me.leCustomer.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leCustomer.Properties.AppearanceDropDown.Options.UseFont = True
        Me.leCustomer.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leCustomer.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.leCustomer.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leCustomer.Properties.AppearanceFocused.Options.UseFont = True
        Me.leCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.leCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustID", "CustID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lastname", "Customer Name")})
        Me.leCustomer.Properties.DropDownRows = 15
        Me.leCustomer.Properties.NullText = ""
        Me.leCustomer.Size = New System.Drawing.Size(357, 26)
        Me.leCustomer.TabIndex = 2
        Me.leCustomer.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters"
        '
        'leAgent
        '
        Me.leAgent.EnterMoveNextControl = True
        Me.leAgent.Location = New System.Drawing.Point(746, 27)
        Me.leAgent.Name = "leAgent"
        Me.leAgent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leAgent.Properties.Appearance.Options.UseFont = True
        Me.leAgent.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leAgent.Properties.AppearanceDropDown.Options.UseFont = True
        Me.leAgent.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leAgent.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.leAgent.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leAgent.Properties.AppearanceFocused.Options.UseFont = True
        Me.leAgent.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.leAgent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leAgent.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("agentid", "agentid", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AgentName", "Agent Name")})
        Me.leAgent.Properties.DropDownRows = 15
        Me.leAgent.Properties.NullText = ""
        Me.leAgent.Size = New System.Drawing.Size(355, 26)
        Me.leAgent.TabIndex = 3
        Me.leAgent.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "PL Date"
        '
        'txtInstruction
        '
        Me.txtInstruction.Enabled = False
        Me.txtInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtInstruction.Location = New System.Drawing.Point(83, 93)
        Me.txtInstruction.Name = "txtInstruction"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtInstruction, False)
        Me.txtInstruction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInstruction.Size = New System.Drawing.Size(875, 29)
        Me.txtInstruction.TabIndex = 43
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(44, 68)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Item"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(808, 68)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Price"
        Me.LabelControl9.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(608, 68)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(88, 19)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Qty Ordered"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(673, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Salesman"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(232, 34)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Customer"
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemSearch.Appearance.Options.UseFont = True
        Me.btnItemSearch.Location = New System.Drawing.Point(566, 62)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(27, 25)
        Me.btnItemSearch.TabIndex = 4
        Me.btnItemSearch.Text = "&I..."
        Me.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtItem.Location = New System.Drawing.Point(83, 61)
        Me.txtItem.Name = "txtItem"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtItem, False)
        Me.txtItem.Size = New System.Drawing.Size(477, 26)
        Me.txtItem.TabIndex = 12
        Me.txtItem.TabStop = False
        '
        'dedlvrydate
        '
        Me.dedlvrydate.EditValue = Nothing
        Me.dedlvrydate.EnterMoveNextControl = True
        Me.dedlvrydate.Location = New System.Drawing.Point(83, 30)
        Me.dedlvrydate.Name = "dedlvrydate"
        Me.dedlvrydate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.dedlvrydate.Properties.Appearance.Options.UseFont = True
        Me.dedlvrydate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Size = New System.Drawing.Size(145, 26)
        Me.dedlvrydate.TabIndex = 1
        Me.dedlvrydate.ToolTip = "Date the Goods were delivered"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(5, 103)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "Instruction"
        '
        'ceQty
        '
        Me.ceQty.EnterMoveNextControl = True
        Me.ceQty.Location = New System.Drawing.Point(705, 61)
        Me.ceQty.Name = "ceQty"
        Me.ceQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceQty.Properties.Appearance.Options.UseFont = True
        Me.ceQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceQty.Size = New System.Drawing.Size(86, 26)
        Me.ceQty.TabIndex = 5
        Me.ceQty.ToolTip = "Qty Delivered by the supplier"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(975, 59)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 36)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add to List"
        Me.btnAdd.ToolTip = "Add the item to the list"
        '
        'ceCost
        '
        Me.ceCost.EnterMoveNextControl = True
        Me.ceCost.Location = New System.Drawing.Point(848, 61)
        Me.ceCost.Name = "ceCost"
        Me.ceCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceCost.Properties.Appearance.Options.UseFont = True
        Me.ceCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceCost.Properties.Mask.BeepOnError = True
        Me.ceCost.Properties.Mask.EditMask = "n2"
        Me.ceCost.Size = New System.Drawing.Size(110, 26)
        Me.ceCost.TabIndex = 67
        Me.ceCost.TabStop = False
        Me.ceCost.ToolTip = "Cost of the item delivered"
        Me.ceCost.Visible = False
        '
        'btnSupplier
        '
        Me.btnSupplier.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnSupplier.Appearance.Options.UseFont = True
        Me.btnSupplier.ImageOptions.Image = CType(resources.GetObject("btnSupplier.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSupplier.Location = New System.Drawing.Point(612, 766)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(137, 26)
        Me.btnSupplier.TabIndex = 34
        Me.btnSupplier.Text = "&Add Customer"
        Me.btnSupplier.ToolTip = "Add the item to the list"
        Me.btnSupplier.Visible = False
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(761, 772)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(39, 20)
        Me.ComboBoxEdit1.TabIndex = 33
        Me.ComboBoxEdit1.Visible = False
        '
        'txtSupcode
        '
        Me.txtSupcode.Location = New System.Drawing.Point(926, 765)
        Me.txtSupcode.Name = "txtSupcode"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtSupcode, False)
        Me.txtSupcode.Size = New System.Drawing.Size(41, 21)
        Me.txtSupcode.TabIndex = 14
        Me.txtSupcode.Visible = False
        '
        'txtStckid
        '
        Me.txtStckid.Location = New System.Drawing.Point(857, 765)
        Me.txtStckid.Name = "txtStckid"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtStckid, False)
        Me.txtStckid.Size = New System.Drawing.Size(28, 21)
        Me.txtStckid.TabIndex = 14
        Me.txtStckid.Visible = False
        '
        'cmbType
        '
        Me.cmbType.EnterMoveNextControl = True
        Me.cmbType.Location = New System.Drawing.Point(1000, 711)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.cmbType.Properties.Appearance.Options.UseFont = True
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Properties.Items.AddRange(New Object() {"COD", "I.S.", "Consignment"})
        Me.cmbType.Size = New System.Drawing.Size(106, 26)
        Me.cmbType.TabIndex = 32
        Me.cmbType.ToolTip = "COD,IS or Consignment"
        Me.cmbType.Visible = False
        '
        'DGRetrieve
        '
        Me.DGRetrieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRetrieve.Location = New System.Drawing.Point(92, 133)
        Me.DGRetrieve.Name = "DGRetrieve"
        Me.DGRetrieve.ReadOnly = True
        Me.DGRetrieve.Size = New System.Drawing.Size(875, 423)
        Me.DGRetrieve.TabIndex = 45
        Me.DGRetrieve.Visible = False
        '
        'txtsum
        '
        Me.txtsum.Enabled = False
        Me.txtsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtsum.Location = New System.Drawing.Point(962, 666)
        Me.txtsum.Name = "txtsum"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtsum, False)
        Me.txtsum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsum.Size = New System.Drawing.Size(168, 29)
        Me.txtsum.TabIndex = 43
        Me.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtsum.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ImageOptions.Image = CType(resources.GetObject("btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(12, 665)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 32)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.ToolTip = "Click this to enter a new delivery."
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(120, 665)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 32)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save"
        Me.btnSave.ToolTip = "Save the List for later modification"
        '
        'btnPost
        '
        Me.btnPost.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnPost.Appearance.Options.UseFont = True
        Me.btnPost.Enabled = False
        Me.btnPost.ImageOptions.Image = CType(resources.GetObject("btnPost.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPost.Location = New System.Drawing.Point(1004, 756)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(102, 32)
        Me.btnPost.TabIndex = 41
        Me.btnPost.Text = "&Post"
        Me.btnPost.ToolTip = "Click this button to update the inventory and the Balance per supplier"
        Me.btnPost.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(905, 672)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl12.TabIndex = 34
        Me.LabelControl12.Text = "TOTAL"
        Me.LabelControl12.Visible = False
        '
        'drgrid
        '
        Me.drgrid.AllowUserToAddRows = False
        Me.drgrid.AllowUserToDeleteRows = False
        Me.drgrid.AllowUserToResizeRows = False
        Me.drgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stckid, Me.Division, Me.Item, Me.UOM, Me.Picked, Me.LotNo, Me.Ordered, Me.ExpiryDate, Me.Price, Me.rate, Me.uomid, Me.categoryid, Me.ItemCode})
        Me.drgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.drgrid.Location = New System.Drawing.Point(9, 139)
        Me.drgrid.MultiSelect = False
        Me.drgrid.Name = "drgrid"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drgrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.drgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgrid.Size = New System.Drawing.Size(1120, 521)
        Me.drgrid.TabIndex = 37
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Enabled = False
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(135, 756)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(102, 32)
        Me.btnPrint.TabIndex = 54
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.ToolTip = "Click this button to update the inventory and the Balance per supplier"
        Me.btnPrint.Visible = False
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'btnRetrievePL
        '
        Me.btnRetrievePL.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnRetrievePL.Appearance.Options.UseFont = True
        Me.btnRetrievePL.ImageOptions.Image = CType(resources.GetObject("btnRetrievePL.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRetrievePL.Location = New System.Drawing.Point(228, 665)
        Me.btnRetrievePL.Name = "btnRetrievePL"
        Me.btnRetrievePL.Size = New System.Drawing.Size(102, 32)
        Me.btnRetrievePL.TabIndex = 40
        Me.btnRetrievePL.Text = "&Retrieve"
        Me.btnRetrievePL.ToolTip = "Save the List for later modification"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Enabled = False
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(336, 665)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 32)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.ToolTip = "Save the List for later modification"
        '
        'cePrice
        '
        Me.cePrice.Location = New System.Drawing.Point(732, 42)
        Me.cePrice.Name = "cePrice"
        Me.cePrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cePrice.Size = New System.Drawing.Size(100, 20)
        Me.cePrice.TabIndex = 69
        Me.cePrice.Visible = False
        '
        'stckid
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stckid.DefaultCellStyle = DataGridViewCellStyle1
        Me.stckid.HeaderText = "StockID"
        Me.stckid.Name = "stckid"
        Me.stckid.ReadOnly = True
        Me.stckid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.stckid.Visible = False
        Me.stckid.Width = 5
        '
        'Division
        '
        Me.Division.HeaderText = "Division"
        Me.Division.Name = "Division"
        Me.Division.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Division.Width = 160
        '
        'Item
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.DefaultCellStyle = DataGridViewCellStyle2
        Me.Item.HeaderText = "Item Description"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Item.Width = 285
        '
        'UOM
        '
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UOM.Width = 80
        '
        'Picked
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Picked.DefaultCellStyle = DataGridViewCellStyle3
        Me.Picked.HeaderText = "Picked"
        Me.Picked.Name = "Picked"
        Me.Picked.ReadOnly = True
        Me.Picked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LotNo
        '
        Me.LotNo.HeaderText = "Lot No"
        Me.LotNo.Name = "LotNo"
        Me.LotNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.LotNo.Width = 145
        '
        'Ordered
        '
        Me.Ordered.HeaderText = "Ordered"
        Me.Ordered.Name = "Ordered"
        Me.Ordered.ReadOnly = True
        Me.Ordered.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ordered.Width = 90
        '
        'ExpiryDate
        '
        '
        '
        '
        Me.ExpiryDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.ExpiryDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExpiryDate.HeaderText = "Expiry Date"
        Me.ExpiryDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.ExpiryDate.MinDate = New Date(2019, 2, 28, 0, 0, 0, 0)
        '
        '
        '
        '
        '
        '
        Me.ExpiryDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExpiryDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.ExpiryDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExpiryDate.MonthCalendar.DisplayMonth = New Date(2019, 2, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.ExpiryDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ExpiryDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExpiryDate.Width = 130
        '
        'Price
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Price.DefaultCellStyle = DataGridViewCellStyle4
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Price.Visible = False
        Me.Price.Width = 200
        '
        'rate
        '
        Me.rate.HeaderText = "Rate"
        Me.rate.Name = "rate"
        Me.rate.ReadOnly = True
        Me.rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.rate.Visible = False
        '
        'uomid
        '
        Me.uomid.HeaderText = "uomid"
        Me.uomid.Name = "uomid"
        Me.uomid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.uomid.Visible = False
        '
        'categoryid
        '
        Me.categoryid.HeaderText = "categoryid"
        Me.categoryid.Name = "categoryid"
        Me.categoryid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.categoryid.Visible = False
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "Item Code"
        Me.ItemCode.Name = "ItemCode"
        '
        'frmPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 701)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.DGRetrieve)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRetrievePL)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSupcode)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.txtStckid)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.drgrid)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Syleenor Corporation Pick List Entry Form"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.chkPartial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cePonum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leAgent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedlvrydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedlvrydate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupcode As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStckid As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnItemSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents dedlvrydate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ceQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ceCost As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents DGRetrieve As System.Windows.Forms.DataGridView
    Friend WithEvents txtsum As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents drgrid As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSupplier As DevExpress.XtraEditors.SimpleButton
    Public WithEvents leAgent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Public WithEvents leCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents txtInstruction As TextBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRetrievePL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cePonum As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkPartial As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cePrice As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents stckid As DataGridViewTextBoxColumn
    Friend WithEvents Division As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents UOM As DataGridViewTextBoxColumn
    Friend WithEvents Picked As DataGridViewTextBoxColumn
    Friend WithEvents LotNo As DataGridViewTextBoxColumn
    Friend WithEvents Ordered As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDate As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents rate As DataGridViewTextBoxColumn
    Friend WithEvents uomid As DataGridViewTextBoxColumn
    Friend WithEvents categoryid As DataGridViewTextBoxColumn
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
End Class

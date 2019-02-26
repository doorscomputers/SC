Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UImgrPicklistStoks
Imports DevExpress.XtraReports.UI

Public Class frmPO
    Dim mgrpohdrtmp As pohdrtmpManager
    Dim mgrpodettmp As podettmpManager
    Dim mgrPlheader As PLHdrManager
    Dim mgrPldetail As PLdetailManager
    'Dim mgrdrheader As pohdrtmpManager
    Dim mgrseven As stocksManager
    Dim mgrPicklistStoks As vwStockPicklistManager
    Dim Totss As Decimal = 0
    Private mOrderId As Integer = 0
    Private mdrId As Integer = 0
    Private WithEvents TranDr As PDSATransaction
    Dim userid As Integer = 0
    Dim aprubuserid As Integer = 0
    Dim prepuserid As Integer = 0
    Dim noteduserid As Integer = 0
    Dim vSupcode As Integer = 0
    Dim username As String = String.Empty
    Dim vRetrivId As Integer = 0
    Dim poRetrivStatus As Integer = 0
    Dim vCellVal As Integer = 0
    Public Shared nStckid As Integer = 0
    Dim mOrderId2 As Integer = 0
    Dim mgrRetrieve As vwPicklistManager
    Dim col5 As vwPicklistCollection
    Dim RetrivNew As Integer = 0
    Dim varPicklistNo As Integer = 0

    Private Sub frmPO_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'AddHandler ComboBoxEdit1.SelectedIndexChanged, AddressOf comboBoxEdit1_SelectedIndexChanged
        ' Add available skin names to the combo box.
        For Each cnt As SkinContainer In SkinManager.Default.Skins
            ComboBoxEdit1.Properties.Items.Add(cnt.SkinName)
        Next cnt
        Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
        Dim skinName As String = comboBox.Text
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName
    End Sub

    Private Sub frmPO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnNew.Enabled = False Then
            Dim vRows As Integer = drgrid.Rows.Count
            If vRows > 0 Then
                MessageBox.Show("Pick List still Exist. Please Save or Click New before closing the Pick List Entry Form.")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Softgroup.NetResize.License.LicenseName = "Doorscomputers"
        Softgroup.NetResize.License.LicenseUser = "rr3800@gmail.com"
        Softgroup.NetResize.License.LicenseKey = "JTAQCRATYLGO0YBIQMGFXANEA"
        Me.NetResize1.MinimumSize = New System.Drawing.Size(100, 100)

        Me.Cursor = Cursors.WaitCursor
        dedlvrydate.EditValue = Date.Today
        drgrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'drgrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'Dim btn As New DataGridViewButtonColumn()
        'drgrid.Columns.Add(btn)
        'btn.HeaderText = "Remove"
        'btn.Text = "Remove"
        'btn.Name = "Remove"
        'btn.UseColumnTextForButtonValue = True
        'LoadSupplier()
        LoadCust()
        LoadAgent()
        btnNew.Focus()
        'load_items()
        Me.Cursor = Cursors.Default
    End Sub

    Sub load_supplier()
        Dim mgrsup As suppliersManager
        Dim cols As suppliersCollection
        Try
            mgrsup = New suppliersManager()
            mgrsup.DataObject.SelectFilter = suppliersData.SelectFilters.ListBox
            mgrsup.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier

            mgrsup.DataObject.Load()
            cols = mgrsup.BuildCollection()
            'GridLookUpEdit1.Properties.PopupFormWidth = 720
            'GridLookUpEdit1.Properties.DisplayMember = "supplier"
            'GridLookUpEdit1.Properties.ValueMember = "supcode"
            'GridLookUpEdit1.Properties.DataSource = cols

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Private Sub LoadCust()
        Dim mgrs As membersManager = New membersManager()
        mgrs.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
        Dim cols As membersCollection
        cols = mgrs.BuildCollection()
        leCustomer.Properties.DisplayMember = "lastname"
        leCustomer.Properties.ValueMember = "CustID"
        leCustomer.Properties.DataSource = cols
    End Sub


    Sub LoadCustomer()

        'Dim cols As membersCollection
        'Try
        '    Dim mgrsup As membersManager = New membersManager()
        '    ' mgrsup.DataObject.SelectFilter = membersData.SelectFilters.CustList
        '    mgrsup.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
        '    'mgrsup.DataObject.Load()
        '    cols = mgrsup.BuildCollection()
        '    leSupplier.Properties.DisplayMember = "lastname" '+ "," + "firstname"
        '    leSupplier.Properties.ValueMember = "custid"
        '    leSupplier.Properties.DataSource = cols

        'Catch ex As PDSAValidationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try

    End Sub

    Sub LoadAgent()
        Dim mgragent As AgentManager
        Dim colsagent As AgentCollection
        Try
            mgragent = New AgentManager()
            mgragent.DataObject.SelectFilter = AgentData.SelectFilters.ListBox
            mgragent.DataObject.OrderByFilter = AgentData.OrderByFilters.AgentName

            mgragent.DataObject.Load()
            colsagent = mgragent.BuildCollection()
            leAgent.Properties.DisplayMember = "AgentName"
            leAgent.Properties.ValueMember = "agentid"
            leAgent.Properties.DataSource = colsagent

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If ceQty.Value <= 0 Then
            MessageBox.Show("Qty Ordered cannot be equal or less than zero")
            Exit Sub
        Else
            Call SendItemtoGrid()
            btnItemSearch.Focus()
        End If
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Enablectrl()
        leCustomer.Text = ""
        leAgent.Text = ""
        leCustomer.EditValue = 0
        leAgent.EditValue = 0
        cePonum.Value = 0
        RetrivNew = 1
        drgrid.Rows.Clear()
        dedlvrydate.EditValue = Date.Today
        ceQty.Value = 0
        ceCost.Value = 0
        txtStckid.Text = String.Empty
        txtSupcode.Text = String.Empty
        poRetrivStatus = 0
        dedlvrydate.Focus()
    End Sub

    Sub SendItemtoGrid()

        Dim I As Integer = 0
        Dim ItemLoc As Integer = -1
        Dim nProdIDD As Integer = 0
        Dim Amount3 As Decimal = 0
        Dim PricePcBox As Decimal = 0
        Dim vqtypicked As Decimal = 0 ' qty ordered
        Dim vqtyavlbl As Decimal = 0 ' qty available
        Dim vqtytodlver As Decimal = 0 ' qty to be delviered
        vqtypicked = ceQty.Value
        vqtyavlbl = CDec(mgrPicklistStoks.DataObject.Entity.available)

        If vqtypicked > vqtyavlbl Then
            vqtytodlver = vqtyavlbl
        Else
            vqtytodlver = ceQty.Value
        End If


        If ceQty.Value >= 1 Then
            Amount3 = 0
            PricePcBox = mgrPicklistStoks.DataObject.Entity.retail
            Amount3 = CDec(ceQty.Value * PricePcBox)

            'MessageBox.Show(CStr(Amount3))
        Else
            Amount3 = 0
            Dim vMod2 As Integer = CInt(ceQty.Value * 10)
            PricePcBox = CDec(mgrPicklistStoks.DataObject.Entity.retail / mgrPicklistStoks.DataObject.Entity.packaging)
            Amount3 = CDec(vMod2 * PricePcBox)
            'MessageBox.Show(CStr(Amount3))
        End If

        Try
            'nProdIDD = CInt(txtStckid.Text)
            'For I = 0 To drgrid.Rows.Count - 1
            '    If nProdIDD = CInt(drgrid.Rows(I).Cells(0).Value) Then
            '        ' item found
            '        ItemLoc = I
            '        Exit For
            '    End If
            'Next

            '' if item is not found, add it


            'If ItemLoc = -1 Then
            ''drgrid.Rows.Add(mgrseven.DataObject.Entity.stckid, mgrseven.DataObject.Entity.itemdesc, ceQty.Value, mgrseven.DataObject.Entity.cost, Amount3)
            drgrid.Rows.Add(mgrPicklistStoks.DataObject.Entity.stckid, mgrPicklistStoks.DataObject.Entity.catgory, mgrPicklistStoks.DataObject.Entity.itemdesc, mgrPicklistStoks.DataObject.Entity.sayz, vqtytodlver, "", ceQty.Value, "", PricePcBox, mgrPicklistStoks.DataObject.Entity.incentive, mgrPicklistStoks.DataObject.Entity.sizeid, mgrPicklistStoks.DataObject.Entity.categoryid, mgrPicklistStoks.DataObject.Entity.barcode)
            'Else

            ''    ' if item is already there increase its count
            ''    Dim ItemCount As Integer = CInt(drgrid.Rows(ItemLoc).Cells(2).Value)
            ''    ItemCount += CInt(ceQty.Value)
            ''    Dim NewPrice As Decimal = mgrseven.DataObject.Entity.cost * ItemCount
            ''    drgrid.Rows(ItemLoc).Cells(2).Value = ItemCount
            ''    drgrid.Rows(ItemLoc).Cells(4).Value = NewPrice

            'End If
            'Dim Totsss As Decimal = 0

            'For I = 0 To drgrid.Rows.Count - 1
            'Totsss += CDec(drgrid.Rows(I).Cells(4).Value)
            'Next
            'Select the last row.
            Me.drgrid.Rows(Me.drgrid.RowCount - 1).Selected = True
            'Scroll to the last row.
            Me.drgrid.FirstDisplayedScrollingRowIndex = Me.drgrid.RowCount - 1
            'MessageBox.Show(CStr(vqtytodlver))
            'txtsum.Text = FormatNumber(CStr(Totsss))
            ceQty.Value = 1
            txtItem.Text = String.Empty
            ceCost.Value = 0
            txtStckid.Text = String.Empty

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    'Private Sub btnSupSearch_Click(sender As Object, e As EventArgs) Handles btnSupSearch.Click
    '    Dim frmSupsearch As New frmSupplierSearch
    '    frmSupsearch.ShowDialog()
    '    Try
    '        txtSupplier.Text = String.Empty
    '        txtSupplier.Text = frmSupsearch.vSupplier.ToString()
    '        txtSupcode.Text = frmSupsearch.vSupCode.ToString()
    '        If txtSupcode.Text = String.Empty Then
    '            MessageBox.Show("Please Select a supplier!")
    '            Exit Sub
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString())
    '    End Try

    'End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim frmitemserch As New frmItemSearch
        frmitemserch.ShowDialog()
        txtItem.Text = String.Empty
        txtStckid.Text = String.Empty
        txtItem.Text = frmitemserch.vItem.ToString
        txtStckid.Text = frmitemserch.vStckid.ToString
        cePrice.Value = frmitemserch.vPrice
        If txtStckid.Text = String.Empty Then
            Exit Sub
        Else
            ItemsearchExecute()
        End If

    End Sub

    Private Sub ItemsearchExecute()
        'Dim col1 As stocksCollection
        'Dim nStckid As Integer = 0
        'Try
        '    mgrseven = New stocksManager()
        '    mgrseven.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
        '    ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
        '    mgrseven.DataObject.Entity.stckid = CInt(txtStckid.Text)

        '    col1 = mgrseven.BuildCollection()

        '    If mgrseven.DataObject.RowsAffected > 0 Then

        '        nStckid = mgrseven.DataObject.Entity.stckid
        '        ceCost.Value = mgrseven.DataObject.Entity.cost

        '        ceQty.Focus()
        '        'SendItemtoGrid()

        '    End If

        'Catch ex As PDSAValidationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try

        Dim col111 As vwStockPicklistCollection

        Try
            nStckid = 0
            mgrPicklistStoks = New vwStockPicklistManager()
            mgrPicklistStoks.DataObject.WhereFilter = vwStockPicklistData.WhereFilters.stockid
            ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
            mgrPicklistStoks.DataObject.Entity.stckid = CInt(txtStckid.Text)
            mgrPicklistStoks.DataObject.Load()
            col111 = mgrPicklistStoks.BuildCollection()

            If mgrPicklistStoks.DataObject.RowsAffected > 0 Then

                nStckid = mgrPicklistStoks.DataObject.Entity.stckid
                Dim stritem As String = mgrPicklistStoks.DataObject.Entity.itemdesc
                Dim strcategory As String = mgrPicklistStoks.DataObject.Entity.catgory

                ' ceCost.Value = mgrPicklistStoks.DataObject.Entity.cost
                ceQty.Focus()
                'SendItemtoGrid()

            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub
    Private Sub ceQty_LostFocus(sender As Object, e As EventArgs) Handles ceQty.LostFocus
        If ceQty.Value < 0 Then
            MessageBox.Show("Qty Delivered cannot be equal or less than zero")

        End If
    End Sub
    Private Sub drgrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles drgrid.CellClick

        If e.ColumnIndex = -1 Then
            Dim ansint As Integer = 7
            ansint = MsgBox("Are you sure you want Delete the selected Row?", MsgBoxStyle.YesNo, "Delete Row Confirmation")
            If ansint = 6 Then
                Dim ii As Integer = 0
                Try
                    Totss = 0
                    drgrid.Rows.Remove(drgrid.SelectedRows(0))
                    For ii = 0 To drgrid.Rows.Count - 1
                        Totss += CDec(drgrid.Rows(ii).Cells(4).Value)
                    Next
                    txtsum.Text = FormatNumber(CStr(Totss))
                Catch ex As PDSAValidationException
                    MessageBox.Show(ex.Message)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        End If
    End Sub
    Private Sub Tran_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranDr.AfterSubmit
        'If e.ClassName = "pohdrtmpData" Then
        '    mOrderId = DirectCast(e.DataClassTable.EntityObject, pohdrtmp).poidtmp
        'End If
        'If e.ClassName = "pos_hdrtmpData" Then
        '    mOrderId = DirectCast(e.DataClassTable.EntityObject, pos_hdrtmp).postmphdrid
        'End If
        If e.ClassName = "PLHdrData" Then
            mOrderId = DirectCast(e.DataClassTable.EntityObject, PLHdr).plid
        End If


    End Sub

    Private Sub Tran_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranDr.BeforeSubmit
        'If e.ClassName = "pos_dettmpData" Then
        '    DirectCast(e.DataClassTable.EntityObject, pos_dettmp).postmphdrid = mOrderId
        'End If
        ' Put local order id into line item objects prior to submitting INSERT statement
        If e.ClassName = "PLdetailData" Then
            DirectCast(e.DataClassTable.EntityObject, PLdetail).plid = mOrderId
        End If
    End Sub

    Private Sub DGRetrieve_KeyDown(sender As Object, e As KeyEventArgs) Handles DGRetrieve.KeyDown
        Dim ii As Integer
        If e.KeyCode = Keys.Enter Then
            'If DGRetrieve.Rows.Count <= 0 Then
            '    Exit Sub
            'End If

            Dim row As Integer = DGRetrieve.CurrentCellAddress.Y
            Dim column As Integer = DGRetrieve.CurrentCellAddress.X
            Dim col4 As vwPicklistCollection 'vwDlvrySuspendedCollection

            If column > 1 Then
                MessageBox.Show("Please select the Picklist on the first column or select the second column to Cancel Retrieval of Suspended Picklist")
                Exit Sub
            End If

            If column = 0 Then ' this is the main code to be executed

                vCellVal = CInt(DGRetrieve.CurrentCell.Value)

                Dim mgrRetrivDr As vwPicklistManager

                Try
                    mgrRetrivDr = New vwPicklistManager
                    mgrRetrivDr.DataObject.WhereFilter = vwPicklistData.WhereFilters.plid
                    mgrRetrivDr.Entity.plid = vCellVal

                    col4 = mgrRetrivDr.BuildCollection()
                    If mgrRetrivDr.DataObject.RowsAffected > 0 Then
                        ' vRetrivId = CInt(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("poidtmp"))
                        varPicklistNo = CInt(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("ponum"))
                        leCustomer.EditValue = CInt(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("custid"))
                        leCustomer.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("lastname"))
                        leAgent.EditValue = CInt(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("agentid"))
                        leAgent.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("AgentName"))
                        txtInstruction.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("instruction"))
                        cePonum.Value = CInt(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("ponum"))
                        For ii = 0 To mgrRetrivDr.DataObject.GetDataTable.Rows.Count - 1
                            drgrid.Rows.Add(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("stckid"), CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("catgory")), CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("item_desc")), CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("sayz")), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("qtydlvrd"), "", mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("orderqty"), "", mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("price"), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("rate"), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("uomid"), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("categoryid"), CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("barcode")))
                        Next

                        Dim Tots22 As Decimal = 0
                        Dim iii As Integer
                        For iii = 0 To drgrid.Rows.Count - 1
                            Tots22 += CDec(drgrid.Rows(iii).Cells(4).Value)
                        Next

                        txtsum.Text = FormatNumber(CStr(Tots22))
                        DGRetrieve.Visible = False
                        RetrivNew = 2 ' Meaning Na click retrieve
                        'FindApprovedBy()
                        'FindPrepBy()
                        'FindNotedBy()
                        'FindSupplier()
                        '''delete the records for the hdrtmp it will cascade delete the data on hdr_detiltmp
                        ''mgrdrTmp = New pohdrtmpManager  'dlvryhdrtmpManager()
                        ''mgrdrTmp.DataObject.DeleteByPK(vCellVal)
                        Dim strsqlDelPoTmp As String = String.Empty
                        strsqlDelPoTmp = "DELETE FROM PLHdr WHERE plid=" & vCellVal
                        ExecuteSQLQuery(strsqlDelPoTmp)
                    End If



                Catch ex As PDSA.Validation.PDSAValidationException
                    MessageBox.Show(ex.Message)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            End If
            'leSupplier.Focus()
            btnItemSearch.Focus()

            If column = 1 Then
                DGRetrieve.Visible = False
            End If
            btnItemSearch.Focus()
        End If
    End Sub
    Private Sub FindSupplier()
        'Try
        '    Dim mgremp As New suppliersManager()
        '    Dim cols As New suppliersCollection
        '    mgremp.DataObject.WhereFilter = suppliersData.WhereFilters.PrimaryKey
        '    mgremp.Entity.supcode = CInt(txtSupcode.Text)
        '    cols = mgremp.BuildCollection()
        '    If mgremp.DataObject.RowsAffected > 0 Then
        '        MessageBox.Show(CStr(mgremp.DataObject.Entity.supplier))
        '        ' leSupplier.EditValue = mgremp.DataObject.Entity.supcode
        '        'leSupplier.Text = mgremp.DataObject.Entity.supplier

        '        MessageBox.Show(CStr(mgremp.DataObject.Entity.supcode))
        '        leSupplier.EditValue = CInt(mgremp.DataObject.Entity.supcode)
        '        'leSupplier.Text = CStr(mgremp.DataObject.Entity.supplier)
        '    End If
        '    leSupplier.Focus()
        '    leSupplier.Text = CStr(mgremp.DataObject.Entity.supplier)
        'Catch ex As PDSAApplicationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try

    End Sub
    Private Sub drgrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles drgrid.CellEndEdit
        'Dim roww As Integer = DGRetrieve.CurrentCellAddress.Y
        'Dim varrowindex As Integer = 0
        'Dim vqty As Integer = 0
        'Dim vamnt As Decimal = 0
        'varrowindex = drgrid.SelectedCells(0).RowIndex
        'vqty = CInt(drgrid.Rows(varrowindex).Cells(2).Value)
        'vamnt = CDec(drgrid.Rows(varrowindex).Cells(4).Value)

        ''Dim rowww As Integer = CInt(DGRetrieve.CurrentRow.Selected())
        'drgrid.Rows(varrowindex).Cells(4).Value = vqty * vamnt
        'Dim I As Integer = 0
        'Totss = 0
        'For I = 0 To drgrid.Rows.Count - 1
        '    Totss += CDec(drgrid.Rows(I).Cells(4).Value)
        'Next
        'txtsum.Text = FormatNumber(Totss, 2)
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        ''If poRetrivStatus = 0 Then
        'If leApprovedby.Text = String.Empty Or leApprovedby.Text = "0" Or lePreparedby.Text = String.Empty Or lePreparedby.Text = "0" Then '  Or leNotedby.Text = String.Empty Or leNotedby.Text = "0"
        '        MessageBox.Show("Approved by, Prepared by must not be Blank.", "Approval Process", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Exit Sub
        '    End If

        '    Dim ansint As Integer = 0
        '    ansint = 7
        '    ansint = MsgBox("Please make sure All information entered are correct(Supplier,Items Ordered,Date Ordered etc.) before clicking Yes to Save!", MsgBoxStyle.YesNo)
        '    If ansint = 7 Then
        '        Exit Sub
        '    End If

        '    If drgrid.Rows.Count <= 0 Then
        '        MessageBox.Show("Item list is empty!")
        '        btnItemSearch.Focus()
        '        Exit Sub
        '    End If
        '    If leSupplier.Text = String.Empty Then
        '        MessageBox.Show("Please select a supplier before saving.")
        '        leSupplier.Focus()
        '        Exit Sub
        '    End If

        '    '+The code to Execute the Sequence operation
        '    Dim spGetPONo As spGetPONoManager
        '    Dim transpGetPONo As PDSATransaction = New PDSATransaction()
        '    spGetPONo = New spGetPONoManager()
        '    transpGetPONo.Add(spGetPONo.DataObject)
        '    transpGetPONo.Execute()


        '    Dim grdCount As Integer = 0
        '    Dim iii As Integer = 0
        '    TranDr = New PDSATransaction()
        '    mgrpohdrtmp = New pohdrtmpManager  'dlvry_hdrManager()
        '    mgrpohdrtmp.DataObject.TransactionType = PDSATransactionType.Insert
        '    Try

        '        mgrpohdrtmp.Entity.podate = CDate(dedlvrydate.Text)
        '        mgrpohdrtmp.Entity.dtInsertdt = Date.Now
        '        mgrpohdrtmp.Entity.dtLastUpdatedt = Date.Now
        '        mgrpohdrtmp.Entity.dlivered = False
        '        mgrpohdrtmp.Entity.drpsted = False
        '        mgrpohdrtmp.Entity.poamnt = CDec(txtsum.Text) 'vGrandTotal
        '        mgrpohdrtmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
        '        mgrpohdrtmp.Entity.supcode = CInt(leSupplier.EditValue) 'CInt(txtSupcode.Text)

        '    mgrpohdrtmp.Entity.status = 1
        '        mgrpohdrtmp.Entity.ponumber = Convert.ToInt32(spGetPONo.DataObject.Entity.PONo)
        '        TranDr.Add(mgrpohdrtmp.DataObject)


        '        grdCount = drgrid.Rows.Count
        '        For iii = 0 To grdCount - 1
        '            mgrpodettmp = New podettmpManager()
        '            mgrpodettmp.DataObject.TransactionType = PDSATransactionType.Insert
        '            mgrpodettmp.Entity.poidtmp = mOrderId 'mdrId
        '            mgrpodettmp.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
        '            mgrpodettmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
        '            If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
        '                mgrpodettmp.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
        '            Else
        '                mgrpodettmp.Entity.qty = 0
        '            End If
        '            mgrpodettmp.Entity.cost = CDec(drgrid.Rows(iii).Cells(3).Value)
        '            mgrpodettmp.Entity.podetamnt = CDec(drgrid.Rows(iii).Cells(4).Value)
        '            TranDr.Add(mgrpodettmp.DataObject)
        '        Next
        '        TranDr.Execute()

        '        'Dim TranDrSp As New PDSATransaction()
        '        'Dim mgrspDrTrans As New spDlvryProcManager()

        '        'mgrspDrTrans.Entity.drdrid = mdrId
        '        'mgrspDrTrans.Entity.supcode = CInt(Trim(txtSupcode.Text))
        '        'TranDrSp.Add(mgrspDrTrans.DataObject)
        '        'TranDrSp.Execute()
        '        MessageBox.Show("Purchase Order Transaction Successfully Saved.")
        '    'btnPost.Enabled = False
        '    Call Disablectrl()
        '    drgrid.Rows.Clear()

        '    Dim porep As New xrPO()
        '        'posrep.DataSource = sqlDT
        '        porep.PoId.Value = mOrderId
        '        porep.RequestParameters = False
        '        porep.PrintingSystem.ShowMarginsWarning = False
        '        porep.Print()

        '    Catch ex As PDSAValidationException
        '        MessageBox.Show(ex.Message)
        '        Exit Sub
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString())
        '        Exit Sub
        '    End Try
        ''Else
        ''    '+The code to Execute the Sequence operation
        ''    Dim spGetPONo2 As spGetPONoManager
        ''    Dim transpGetPONo2 As PDSATransaction = New PDSATransaction()
        ''    spGetPONo2 = New spGetPONoManager()
        ''    transpGetPONo2.Add(spGetPONo2.DataObject)
        ''    transpGetPONo2.Execute()

        ''    ' locate poid pk update status and po number


        ''    Dim porep As New xrPO()
        ''    'posrep.DataSource = sqlDT
        ''    porep.PoId.Value = 'this is th pk of po
        ''    porep.RequestParameters = False
        ''    porep.PrintingSystem.ShowMarginsWarning = False
        ''    porep.Print()
        ''    poRetrivStatus = 0


        ''End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If leCustomer.Text = String.Empty Or leAgent.Text = "" Then
            MessageBox.Show("Customer Name and Agent Name must not be blank")
            Exit Sub
        End If
        Dim ansint As Integer = 0
        ansint = 7
        ansint = MsgBox("Please make sure you selected the correct customer and entered the correct items before clicking yes!", MsgBoxStyle.YesNo)
        If ansint = 7 Then
            Exit Sub
        End If
        'Check Before Saving
        If drgrid.Rows.Count <= 0 Then
            MessageBox.Show("Item list is empty!")
            Exit Sub
        End If
        'If txtSupcode.Text = String.Empty Then
        'MessageBox.Show("Please select a supplier before saving.")
        'Exit Sub
        'End If
        poRetrivStatus = 0
        If RetrivNew = 1 Then
            Call SavePo()
            RetrivNew = 1
        Else
            Call SaveRetrievedPO()
            RetrivNew = 1
        End If
    End Sub
    Sub SavePo()
        Dim grdCount As Integer = 0
        Dim iii As Integer = 0

        mgrPlheader = New PLHdrManager()
        Try

            TranDr = New PDSATransaction()
            '+The code to Execute the Sequence operation
            Dim spGetPLNo As spGetpicklistnoManager
            Dim transpGetPLNo As PDSATransaction = New PDSATransaction()
            spGetPLNo = New spGetpicklistnoManager()
            transpGetPLNo.Add(spGetPLNo.DataObject)
            transpGetPLNo.Execute()
            'MessageBox.Show(spGetReceiptNo.DataObject.Entity.ReceiptNo.ToString)
            mOrderId2 = 0
            mOrderId2 = Convert.ToInt32(spGetPLNo.DataObject.Entity.picklistno)

            mgrPlheader.DataObject.TransactionType = PDSATransactionType.Insert

            mgrPlheader.Entity.invoicedate = DateTime.Now 'CDate(dedlvrydate.Text)
            mgrPlheader.Entity.custid = CInt(leCustomer.EditValue)
            mgrPlheader.Entity.agentid = CInt(leAgent.EditValue)
            mgrPlheader.Entity.ponum = mOrderId2
            mgrPlheader.Entity.approvaldate = Date.Now
            mgrPlheader.Entity.dtInsertdt = Date.Now
            mgrPlheader.Entity.terms = 0
            mgrPlheader.Entity.preparedby = PDSAAppConfig.CurrentLoginID
            mgrPlheader.Entity.dtLastUpdatedt = Date.Now
            mgrPlheader.Entity.dlivered = False
            mgrPlheader.Entity.drpsted = False
            mgrPlheader.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrPlheader.Entity.instruction = Trim(txtInstruction.Text)
            TranDr.Add(mgrPlheader.DataObject)

            grdCount = drgrid.Rows.Count
            For iii = 0 To grdCount - 1
                mgrPldetail = New PLdetailManager()
                mgrPldetail.DataObject.TransactionType = PDSATransactionType.Insert
                mgrPldetail.Entity.plid = mOrderId 'mdrId
                mgrPldetail.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
                mgrPldetail.Entity.categoryid = Convert.ToInt32(drgrid.Rows(iii).Cells(11).Value)
                mgrPldetail.Entity.uomid = Convert.ToInt32(drgrid.Rows(iii).Cells(10).Value)
                mgrPldetail.Entity.orderqty = Convert.ToDecimal(drgrid.Rows(iii).Cells(6).Value)
                mgrPldetail.Entity.qtydlvrd = Convert.ToDecimal(drgrid.Rows(iii).Cells(4).Value)
                mgrPldetail.Entity.price = Convert.ToDecimal(drgrid.Rows(iii).Cells(8).Value)
                mgrPldetail.Entity.rate = Convert.ToInt32(drgrid.Rows(iii).Cells(9).Value)
                mgrPldetail.Entity.lotno = CStr(drgrid.Rows(iii).Cells(5).Value)
                If CStr((drgrid.Rows(iii).Cells(7).Value)) = "" Then
                    mgrPldetail.Entity.expdate = CDate("12/31/2099")
                Else
                    mgrPldetail.Entity.expdate = CDate((drgrid.Rows(iii).Cells(7).Value))
                End If
                mgrPldetail.Entity.amount = 0
                mgrPldetail.Entity.totamnt = 0

                'If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
                '    mgrPldetail.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
                'Else
                '    mgrPldetail.Entity.qty = 0
                'End If

                TranDr.Add(mgrPldetail.DataObject)
            Next
            TranDr.Execute()
            Dim ansint7 As Integer = 7
            ansint7 = MsgBox("Pick List Successfuly Saved. Do you want to preview the Picklist?", MsgBoxStyle.YesNo, "Preview Confirmation")
            If ansint7 = 6 Then
                Dim PLrep As New xrPicklistPrint
                PLrep.Parameter1.Value = mOrderId2
                PLrep.RequestParameters = False
                PLrep.PrintingSystem.ShowMarginsWarning = False
                PLrep.ShowPreview()
            End If
            'btnSave.Enabled = False
            Call Disablectrl()
            drgrid.Rows.Clear()

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub
    Sub SaveRetrievedPO()
        Dim grdCount As Integer = 0
        Dim iii As Integer = 0

        mgrPlheader = New PLHdrManager()
        Try

            TranDr = New PDSATransaction()

            mOrderId2 = 0
            mOrderId2 = CInt(cePonum.Value)

            mgrPlheader.DataObject.TransactionType = PDSATransactionType.Insert

            mgrPlheader.Entity.invoicedate = DateTime.Now 'CDate(dedlvrydate.Text)
            mgrPlheader.Entity.custid = CInt(leCustomer.EditValue)
            mgrPlheader.Entity.agentid = CInt(leAgent.EditValue)
            mgrPlheader.Entity.ponum = mOrderId2
            mgrPlheader.Entity.approvaldate = Date.Now
            mgrPlheader.Entity.dtInsertdt = Date.Now
            mgrPlheader.Entity.terms = 0
            mgrPlheader.Entity.preparedby = PDSAAppConfig.CurrentLoginID
            mgrPlheader.Entity.dtLastUpdatedt = Date.Now
            mgrPlheader.Entity.dlivered = False
            mgrPlheader.Entity.drpsted = False
            mgrPlheader.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrPlheader.Entity.instruction = Trim(txtInstruction.Text)
            TranDr.Add(mgrPlheader.DataObject)

            grdCount = drgrid.Rows.Count
            For iii = 0 To grdCount - 1
                mgrPldetail = New PLdetailManager()
                mgrPldetail.DataObject.TransactionType = PDSATransactionType.Insert
                mgrPldetail.Entity.plid = mOrderId 'mdrId
                mgrPldetail.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
                mgrPldetail.Entity.categoryid = Convert.ToInt32(drgrid.Rows(iii).Cells(11).Value)
                mgrPldetail.Entity.uomid = Convert.ToInt32(drgrid.Rows(iii).Cells(10).Value)
                mgrPldetail.Entity.orderqty = Convert.ToDecimal(drgrid.Rows(iii).Cells(6).Value)
                mgrPldetail.Entity.qtydlvrd = Convert.ToDecimal(drgrid.Rows(iii).Cells(4).Value)
                mgrPldetail.Entity.price = Convert.ToDecimal(drgrid.Rows(iii).Cells(8).Value)
                mgrPldetail.Entity.rate = Convert.ToInt32(drgrid.Rows(iii).Cells(9).Value)
                mgrPldetail.Entity.lotno = CStr(drgrid.Rows(iii).Cells(5).Value)
                If CStr((drgrid.Rows(iii).Cells(7).Value)) = "" Then
                    mgrPldetail.Entity.expdate = CDate("12/31/2099")
                Else
                    mgrPldetail.Entity.expdate = CDate((drgrid.Rows(iii).Cells(7).Value))
                End If
                mgrPldetail.Entity.amount = 0
                mgrPldetail.Entity.totamnt = 0

                'If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
                '    mgrPldetail.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
                'Else
                '    mgrPldetail.Entity.qty = 0
                'End If

                TranDr.Add(mgrPldetail.DataObject)
            Next
            TranDr.Execute()
            Dim ansint7 As Integer = 7
            ansint7 = MsgBox("Pick List Successfuly Saved. Do you want to preview the Picklist?", MsgBoxStyle.YesNo, "Preview Confirmation")
            If ansint7 = 6 Then
                Dim PLrep As New xrPicklistPrint
                PLrep.Parameter1.Value = mOrderId2
                PLrep.RequestParameters = False
                PLrep.PrintingSystem.ShowMarginsWarning = False
                PLrep.ShowPreview()

            End If
            Call Disablectrl()
            drgrid.Rows.Clear()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Sub SaveRetrivdPO()
        Dim grdCount As Integer = 0
        Dim iii As Integer = 0
        TranDr = New PDSATransaction()

        Try
            mgrpohdrtmp = New pohdrtmpManager()
            '   mgrpohdrtmp.DataObject.WhereFilter = pohdrtmpData.WhereFilters.PrimaryKey
            'mgrpohdrtmp.Entity.poidtmp = vRetrivId
            mgrpohdrtmp.DataObject.LoadByPK(vRetrivId)
            If mgrpohdrtmp.DataObject.RowsAffected > 0 Then
                mgrpohdrtmp.Entity.podate = CDate(dedlvrydate.Text)
                mgrpohdrtmp.Entity.dtInsertdt = Date.Now
                mgrpohdrtmp.Entity.dtLastUpdatedt = Date.Now
                mgrpohdrtmp.Entity.dlivered = False
                mgrpohdrtmp.Entity.drpsted = False
                mgrpohdrtmp.Entity.poamnt = CDec(txtsum.Text) 'vGrandTotal
                mgrpohdrtmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                mgrpohdrtmp.Entity.supcode = CInt(leCustomer.EditValue) 'CInt(txtSupcode.Text)
                mgrpohdrtmp.DataObject.TransactionType = PDSATransactionType.Update
                TranDr.Add(mgrpohdrtmp.DataObject)

                grdCount = drgrid.Rows.Count
                For iii = 0 To grdCount - 1
                    mgrpodettmp = New podettmpManager()
                    mgrpodettmp.DataObject.LoadByPK(Convert.ToInt32(drgrid.Rows(iii).Cells(5).Value))
                    If mgrpodettmp.DataObject.RowsAffected = 1 Then

                        mgrpodettmp.Entity.poidtmp = vRetrivId 'Convert.ToInt32(drgrid.Rows(iii).Cells(10).Value)
                        mgrpodettmp.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
                        mgrpodettmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                        If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
                            mgrpodettmp.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
                        Else
                            mgrpodettmp.Entity.qty = 0
                        End If
                        mgrpodettmp.Entity.cost = CDec(drgrid.Rows(iii).Cells(3).Value)
                        mgrpodettmp.Entity.podetamnt = CDec(drgrid.Rows(iii).Cells(4).Value)
                        mgrpodettmp.DataObject.TransactionType = PDSATransactionType.Update
                        TranDr.Add(mgrpodettmp.DataObject)
                    End If
                Next
                TranDr.Execute()
                MessageBox.Show("PO successfuly saved.")
                'btnSave.Enabled = False
                Call Disablectrl()
            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub
    Private Sub Disablectrl()
        GroupControl1.Enabled = False
        dedlvrydate.Enabled = False
        btnItemSearch.Enabled = False
        ceQty.Enabled = False
        ceCost.Enabled = False
        btnAdd.Enabled = False
        drgrid.Enabled = False
        btnPost.Enabled = False
        txtInstruction.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
        btnRetrievePL.Enabled = True
        btnCancel.Enabled = False
    End Sub

    Private Sub Enablectrl()
        GroupControl1.Enabled = True
        dedlvrydate.Enabled = True
        btnItemSearch.Enabled = True
        txtInstruction.Enabled = True
        ceQty.Enabled = True
        ceCost.Enabled = True
        btnAdd.Enabled = True
        drgrid.Enabled = True
        btnPost.Enabled = True
        btnSave.Enabled = True
        txtInstruction.Enabled = True
        btnNew.Enabled = False
        btnRetrievePL.Enabled = False
        btnCancel.Enabled = True
        leCustomer.Enabled = True
        leAgent.Enabled = True
        ceQty.Enabled = True


    End Sub

    Sub RetrievePoItems()
        'Dim ii As Integer = 0
        'Dim iCntr As Integer = 0
        'Dim mgrRetrieve As vwPoItemsManager
        'Dim col3 As vwPoItemsCollection
        'drgrid.Rows.Clear()
        'Me.DGRetrieve.DefaultCellStyle.Font = New Font("Tahoma", 12)

        'Try
        '    mgrRetrieve = New vwPoItemsManager()
        '    mgrRetrieve.DataObject.SelectFilter = vwPoItemsData.SelectFilters.All
        '    mgrRetrieve.DataObject.WhereFilter = vwPoItemsData.WhereFilters.Suplayr
        '    mgrRetrieve.Entity.supplier = leSupplier.Text


        '    'tbSQL.Text = mgrRetrieve.DataObject.SQL
        '    col3 = mgrRetrieve.BuildCollection()
        '    If mgrRetrieve.DataObject.RowsAffected > 0 Then
        '        DGRetrieve.Visible = True
        '        DGRetrieve.Focus()
        '        DGRetrieve.DataSource = mgrRetrieve.DataObject.GetDataTable() 'col3
        '        Me.DGRetrieve.AutoResizeColumns()
        '        Me.DGRetrieve.Columns(3).Visible = False
        '        Me.DGRetrieve.Columns(2).Visible = False
        '        Me.DGRetrieve.Columns("cost").DefaultCellStyle.Format = "c"
        '        Me.DGRetrieve.Columns("cost").DefaultCellStyle.Alignment = _
        '            DataGridViewContentAlignment.MiddleRight


        '        '+Code that Came from the DGRetrieve Keydown as a basis to put the items on the PO Items list
        '        For ii = 0 To mgrRetrieve.DataObject.GetDataTable.Rows.Count - 1
        '            '+Original Code 
        '            'drgrid.Rows.Add(mgrRetrieve.DataObject.GetDataTable.Rows(ii)("stckid"), CStr(mgrRetrieve.DataObject.GetDataTable.Rows(ii)("item_desc")), CStr(mgrRetrieve.DataObject.GetDataTable.Rows(ii)("qty")), mgrRetrieve.DataObject.GetDataTable.Rows(ii)("cost"), mgrRetrieve.DataObject.GetDataTable.Rows(ii)("podetamnt"))
        '            '+End of Orig Code
        '            drgrid.Rows.Add(mgrRetrieve.DataObject.GetDataTable.Rows(ii)("stckid"), CStr(mgrRetrieve.DataObject.GetDataTable.Rows(ii)("item_desc")), CStr(mgrRetrieve.DataObject.GetDataTable.Rows(ii)("minimum")), mgrRetrieve.DataObject.GetDataTable.Rows(ii)("cost"), CDec(mgrRetrieve.DataObject.GetDataTable.Rows(ii)("minimum")) * CDec(mgrRetrieve.DataObject.GetDataTable.Rows(ii)("cost")))
        '            ''txtSupcode.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supcode"))
        '            ''txtSupplier.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supplier"))
        '            'dedlvrydate.EditValue = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("podate"))
        '        Next
        '        Dim Tots22 As Decimal = 0

        '        For iCntr = 0 To drgrid.Rows.Count - 1
        '            Tots22 += CDec(drgrid.Rows(iCntr).Cells(4).Value)
        '        Next
        '        txtsum.Text = FormatNumber(CStr(Tots22))
        '        DGRetrieve.Visible = False

        '        '+End of Code


        '    Else
        '        MessageBox.Show("No items  t o   D i s p l a y based on the currently selected Supplier")
        '        DGRetrieve.Visible = False
        '        'btnSearchItems.Focus()
        '        'txtBarcode.Focus()
        '        'txtitem.focus()
        '        txtItem.Text = String.Empty

        '    End If
        '    'PosGrid.Rows.Add(mgr.DataObject.Entity.s, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.item, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail,                 qtyy, mgr.DataObject.Entity.retail)

        '    txtSupcode.Text = CStr(leSupplier.EditValue)

        'Catch ex As PDSAValidationException
        '    MessageBox.Show(ex.Message)

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub

    Private Sub drgrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles drgrid.CellValueChanged
        'If drgrid.Rows.Count > 0 Then
        '    Try

        '        Dim number As Decimal
        '        Dim result As Boolean = Decimal.TryParse(CStr(drgrid.SelectedRows.Item(0).Cells(2).Value), number)
        '        Dim result2 As Boolean = Decimal.TryParse(CStr(drgrid.SelectedRows.Item(0).Cells(3).Value), number)

        '        If result And result2 Then
        '            'Console.WriteLine("Converted '{0}' to {1}.", CStr(drgrid.SelectedRows.Item(0).Cells(5).Value), number)
        '            drgrid.SelectedRows.Item(0).Cells(4).Value = CDec(CStr(drgrid.SelectedRows.Item(0).Cells(2).Value)) * CDec(CStr(drgrid.SelectedRows.Item(0).Cells(3).Value))
        '            'If (dgvr.Cells(7).Value < dgvr.Cells(10).Value) Then
        '            'dgvr.DefaultCellStyle.ForeColor = Color.Red
        '            'End If
        '            If CInt(drgrid.SelectedRows.Item(0).Cells(2).Value) <= 0 Then
        '                drgrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Red
        '            Else
        '                drgrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Black
        '            End If

        '            If CDec(drgrid.SelectedRows.Item(0).Cells(3).Value) <= 0 Then
        '                drgrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Red
        '            Else
        '                drgrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Black
        '            End If

        '            Dim Recompute As Decimal = 0
        '            Dim aii As Integer = 0
        '            For aii = 0 To drgrid.Rows.Count - 1
        '                Recompute += CDec(drgrid.Rows(aii).Cells(4).Value)
        '            Next
        '            'CalcEdit1.Value = Totss
        '            'txtCounts.Text = CStr(drgrid.Rows.Count)
        '            txtsum.Text = FormatNumber(Recompute, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Recompute))
        '            'CheckSumifNegative()
        '            vpTotalSales = Recompute

        '        Else
        '            If CStr(drgrid.SelectedRows.Item(0).Cells(3).Value) Is Nothing Then drgrid.SelectedRows.Item(0).Cells(2).Value = 0
        '            MessageBox.Show("W A R N I N G !!!!!! Cost or Qty Must be Greater than Zero", CStr(drgrid.SelectedRows.Item(0).Cells(3).Value))
        '            drgrid.SelectedRows.Item(0).Cells(2).Value = 0

        '            Dim Recomputes As Decimal = 0
        '            Dim aiii As Integer = 0
        '            For aiii = 0 To drgrid.Rows.Count - 1
        '                Recomputes += CDec(drgrid.Rows(aiii).Cells(4).Value)
        '            Next
        '            'txtCounts.Text = CStr(drgrid.Rows.Count)
        '            txtsum.Text = FormatNumber(Recomputes, 2, , TriState.True, TriState.True) ' FormatNumber(CStr(Recomputes))
        '            'CheckSumifNegative()
        '            vpTotalSales = Recomputes

        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString())
        '    End Try
        'End If
    End Sub

    Private Sub txtPassPrep_KeyPress(sender As Object, e As KeyPressEventArgs)
        'If e.KeyChar = Chr(13) Then
        '    Validate_UserPassPrep()
        'End If
    End Sub


    Private Sub Validate_UserPassPrep()
        'userid = 0
        'prepuserid = 0
        'username = String.Empty
        'Try
        '    Dim mgremp As New waitersManager()
        '    Dim cols As New waitersCollection
        '    mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
        '    mgremp.Entity.pword = Trim(txtPassPrep.Text)
        '    cols = mgremp.BuildCollection()
        '    If mgremp.DataObject.RowsAffected > 0 Then
        '        userid = mgremp.DataObject.Entity.wtid
        '        username = mgremp.DataObject.Entity.waiter
        '        prepuserid = userid
        '        lePreparedby.Text = username
        '    Else
        '        MessageBox.Show("Not a valid password, try again.")

        '    End If
        'Catch ex As PDSAApplicationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub
    Private Sub txtPassApproved_KeyPress(sender As Object, e As KeyPressEventArgs)
        'If e.KeyChar = Chr(13) Then
        '    Validate_UserPassApprove()
        'End If
    End Sub
    Private Sub Validate_UserPassApprove()
        'userid = 0
        'aprubuserid = 0
        'username = String.Empty
        'Try
        '    Dim mgremp As New waitersManager()
        '    Dim cols As New waitersCollection
        '    mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
        '    mgremp.Entity.pword = Trim(txtPassApproved.Text)
        '    cols = mgremp.BuildCollection()
        '    If mgremp.DataObject.RowsAffected > 0 Then
        '        userid = mgremp.DataObject.Entity.wtid
        '        username = mgremp.DataObject.Entity.waiter
        '        aprubuserid = userid
        '        leApprovedby.Text = username
        '    Else
        '        MessageBox.Show("Not a valid password, try again.")
        '    End If
        'Catch ex As PDSAApplicationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub
    'Private Sub txtPassNoted_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then
    '        Validate_UserPassNoted()
    '    End If
    'End Sub

    Private Sub Validate_UserPassNoted()
        'userid = 0
        'noteduserid = 0
        'username = String.Empty
        'Try
        '    Dim mgremp As New waitersManager()
        '    Dim cols As New waitersCollection
        '    mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
        '    mgremp.Entity.pword = Trim(txtPassNoted.Text)
        '    cols = mgremp.BuildCollection()
        '    If mgremp.DataObject.RowsAffected > 0 Then
        '        userid = mgremp.DataObject.Entity.wtid
        '        username = mgremp.DataObject.Entity.waiter
        '        noteduserid = userid
        '        leNotedby.Text = username
        '    Else
        '        MessageBox.Show("Not a valid password, try again.")

        '    End If
        'Catch ex As PDSAApplicationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub


    Private Sub FindPrepBy()
        ''userid = 0
        ''prepuserid = 0
        ''username = String.Empty
        'Try
        '    Dim mgremp As New waitersManager()
        '    Dim cols As New waitersCollection
        '    mgremp.DataObject.WhereFilter = waitersData.WhereFilters.wpkey
        '    mgremp.Entity.wtid = prepuserid
        '    cols = mgremp.BuildCollection()
        '    If mgremp.DataObject.RowsAffected > 0 Then
        '        'userid = mgremp.DataObject.Entity.wtid
        '        'username = mgremp.DataObject.Entity.waiter
        '        'prepuserid = userid
        '        lePreparedby.Text = mgremp.DataObject.Entity.waiter

        '    End If
        'Catch ex As PDSAApplicationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub

    Private Sub FindApprovedBy()
        ''userid = 0
        ''prepuserid = 0
        ''username = String.Empty
        'Try
        '    Dim mgremp As New waitersManager()
        '    Dim cols As New waitersCollection
        '    mgremp.DataObject.WhereFilter = waitersData.WhereFilters.wpkey
        '    mgremp.Entity.wtid = aprubuserid
        '    cols = mgremp.BuildCollection()
        '    If mgremp.DataObject.RowsAffected > 0 Then
        '        'userid = mgremp.DataObject.Entity.wtid
        '        'username = mgremp.DataObject.Entity.waiter
        '        'prepuserid = userid
        '        leApprovedby.Text = mgremp.DataObject.Entity.waiter

        '    End If
        'Catch ex As PDSAApplicationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub


    Private Sub FindNotedBy()
        'Try
        '    Dim mgremp As New waitersManager()
        '    Dim cols As New waitersCollection
        '    mgremp.DataObject.WhereFilter = waitersData.WhereFilters.wpkey
        '    mgremp.Entity.wtid = noteduserid
        '    cols = mgremp.BuildCollection()
        '    If mgremp.DataObject.RowsAffected > 0 Then
        '        'userid = mgremp.DataObject.Entity.wtid
        '        'username = mgremp.DataObject.Entity.waiter
        '        'prepuserid = userid
        '        leNotedby.Text = mgremp.DataObject.Entity.waiter

        '    End If
        'Catch ex As PDSAApplicationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub
    Private Sub FindSupplier2()
        'Try
        '    Dim mgremp As New suppliersManager()
        '    Dim cols As New suppliersCollection
        '    mgremp.DataObject.WhereFilter = suppliersData.WhereFilters.PrimaryKey
        '    mgremp.Entity.supcode = vSupcode
        '    cols = mgremp.BuildCollection()
        '    If mgremp.DataObject.RowsAffected > 0 Then
        '        leSupplier.Text = mgremp.DataObject.Entity.supplier
        '    End If
        'Catch ex As PDSAApplicationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Dim frm As frmSuppliers
        frm = New frmSuppliers
        frm.ShowDialog()
        frm = Nothing
    End Sub


    Private Sub drgrid_DoubleClick(sender As Object, e As EventArgs) Handles drgrid.DoubleClick
        'Dim ansint As Integer = 7
        'ansint = MsgBox("Are you sure you want Remove All the Items?", MsgBoxStyle.YesNo, "Remove All Rows Confirmation")
        'If ansint = 6 Then
        '    drgrid.Rows.Clear()
        'End If
    End Sub

    Private Sub btnRetrievePL_Click(sender As Object, e As EventArgs) Handles btnRetrievePL.Click
        RetrivNew = 2
        leCustomer.EditValue = 0
        leAgent.EditValue = 0
        leCustomer.Enabled = False
        leAgent.Enabled = False
        ceQty.Enabled = False
        MessageBox.Show("Retrieving the Pick list items will delete it from the Database. Don't forget to save it again.")
        Dim mgrvwPicklistRetriv As vwPicklistRetrivManager
        Dim col6 As vwPicklistRetrivCollection
        If drgrid.Rows.Count > 0 Then
            MessageBox.Show("There is a Pending Picklist Entry. Pelase save or delete it first!")
            Exit Sub
        End If

        ' RetrivNew = 2 ' Retrived Flag
        Try
            mgrvwPicklistRetriv = New vwPicklistRetrivManager()
            'mgrvwPicklistRetriv.DataObject.WhereFilter = vwPicklistData.WhereFilters.posted
            col6 = mgrvwPicklistRetriv.BuildCollection()
            mgrvwPicklistRetriv.DataObject.Load()
            If mgrvwPicklistRetriv.DataObject.RowsAffected > 0 Then

                DGRetrieve.Visible = True
                DGRetrieve.DataSource = col6
                Me.DGRetrieve.Columns(0).Width = 5
                Me.DGRetrieve.Columns(1).Width = 130
                Me.DGRetrieve.Columns(4).Width = 250
                Me.DGRetrieve.Columns(5).Width = 190
                Me.DGRetrieve.Columns(2).HeaderText = "Pick List Number"
                Me.DGRetrieve.Columns(3).HeaderText = "Customer Code"
                Me.DGRetrieve.Columns(4).HeaderText = "Customer"
                Me.DGRetrieve.Columns(6).Visible = False
                Me.DGRetrieve.Columns(7).Visible = False
                Me.DGRetrieve.Columns(8).Visible = False
                Me.DGRetrieve.Columns(9).Visible = False
                DGRetrieve.Focus()
                Call Enablectrl()
                RetrivNew = 2

            Else
                MessageBox.Show("N o   P e n d i n g   P i c k l i s t    t o   D i s p l a y")
                DGRetrieve.Visible = False
                RetrivNew = 1
            End If
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


        'Dim PLNum As Integer = 0
        'PLNum = CInt(InputBox("Enter Picklist Number", "Pick List Number to Retrieve", CType(PLNum, String)))
        'If PLNum > 0 Then
        '    Dim ii As Integer

        '    Dim mgrvwPList As vwPicklistManager
        '    Dim col1 As vwPicklistCollection
        '    Try
        '        mgrvwPList = New vwPicklistManager()
        '        mgrvwPList.DataObject.WhereFilter = vwPicklistData.WhereFilters.ponum
        '        mgrvwPList.Entity.ponum = PLNum
        '        'MessageBox.Show("Total Record Count is " & _
        '        'mgr.DataObject.RowCount().ToString())
        '        'tbSQL.Text = mgr.DataObject.SQL

        '        col1 = mgrvwPList.BuildCollection()
        '        If mgrvwPList.DataObject.RowsAffected > 0 Then

        '            nProdID = mgrvwPList.DataObject.Entity.stckid
        '            txtbcodes.Text = CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("barcode"))
        '            txtlastname.Text = CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("lastname"))
        '            vCustid = CInt(mgrvwPList.DataObject.GetDataTable.Rows(ii)("custid"))
        '            vAgentid = CInt(mgrvwPList.DataObject.GetDataTable.Rows(ii)("agentid"))
        '            txtSalesman.Text = CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("AgentName"))
        '            vPicklistNo = CInt(mgrvwPList.DataObject.GetDataTable.Rows(ii)("ponum"))
        '            PlDate.Text = CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("invoicedate"))
        '            txtcustid.Text = CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("custid"))
        '            txtTerms.Text = CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("middlename"))
        '            txtAddress.Text = CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("address1"))
        '            txtInstruction.Text = CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("instruction"))

        '            For ii = 0 To mgrvwPList.DataObject.GetDataTable.Rows.Count - 1
        '                Dim vrate As Integer = CInt(mgrvwPList.DataObject.GetDataTable.Rows(ii)("rate"))
        '                Dim vQtydlvrd As Decimal = CDec(mgrvwPList.DataObject.GetDataTable.Rows(ii)("qtydlvrd"))
        '                Dim vPrice As Decimal = CDec(mgrvwPList.DataObject.GetDataTable.Rows(ii)("price"))
        '                Dim vDiscount As Decimal = 0
        '                Dim vAmount As Decimal = 0
        '                Dim vNetAmount As Decimal = 0
        '                If vrate > 0 Then
        '                    vDiscount = CDec(vPrice * (vrate / 100))
        '                    vAmount = vDiscount * vQtydlvrd
        '                    vNetAmount = (vPrice * vQtydlvrd) - vAmount
        '                Else
        '                    vNetAmount = (vPrice * vQtydlvrd)
        '                End If
        '                'add the records to the Grid
        '                PosGrid.Rows.Add(mgrvwPList.DataObject.GetDataTable.Rows(ii)("stckid"), CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("barcode")), CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("item_desc")), CStr(mgrvwPList.DataObject.GetDataTable.Rows(ii)("qtydlvrd")), mgrvwPList.DataObject.GetDataTable.Rows(ii)("sayz"), mgrvwPList.DataObject.GetDataTable.Rows(ii)("qtydlvrd"), mgrvwPList.DataObject.GetDataTable.Rows(ii)("sayz"), mgrvwPList.DataObject.GetDataTable.Rows(ii)("price"), mgrvwPList.DataObject.GetDataTable.Rows(ii)("rate"), vAmount, FormatNumber(vNetAmount, 2, , TriState.True, TriState.True), mgrvwPList.DataObject.GetDataTable.Rows(ii)("lotno"), mgrvwPList.DataObject.GetDataTable.Rows(ii)("expdate"), mgrvwPList.DataObject.GetDataTable.Rows(ii)("categoryid"), mgrvwPList.DataObject.GetDataTable.Rows(ii)("uomid"))

        '                If vQtydlvrd <= 0 Then
        '                    PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Red
        '                Else
        '                    PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Black
        '                End If


        '            Next
        '            Dim Tots22 As Decimal = 0
        '            Dim iii As Integer
        '            For iii = 0 To PosGrid.Rows.Count - 1
        '                Tots22 += CDec(PosGrid.Rows(iii).Cells(10).Value)
        '            Next

        '            txtsum.Text = FormatNumber(CStr(Tots22))
        '            txtCounts.Text = CStr(PosGrid.Rows.Count)

        '            Dim TotalItemsBought As Integer = 0
        '            Dim i3 As Integer = 0
        '            For i3 = 0 To PosGrid.Rows.Count - 1
        '                TotalItemsBought += CInt(PosGrid.Rows(i3).Cells(5).Value)
        '            Next
        '            txtTotalItems.Text = CStr(TotalItemsBought)

        '            txtPlNo.Enabled = False
        '            btnSaveInvoice.Enabled = True
        '            btnCancel.Enabled = True
        '            btnRemoveRate.Enabled = True
        '            btnRetrievePO.Enabled = False
        '            btnPlusDisc.Enabled = True
        '            txtInstruction.Enabled = True
        '        Else
        '            'MessageBox.Show("B A R C O D E  N O T  F O U N D")
        '            Dim frmnotfawn As New frmNotFound
        '            frmnotfawn.ShowDialog()

        '        End If
        '    Catch ex As PDSAValidationException
        '        MessageBox.Show(ex.Message)
        '    End Try

        '    'Dim straqlUpdateCustName As String = String.Empty
        '    'straqlUpdateCustName = "UPDATE members SET lastname='" & vStrCustName & "'" & " WHERE CustId=1"
        '    'ExecuteSQLQuery(straqlUpdateCustName)
        '    'straqlUpdateCustName = String.Empty
        '    'straqlUpdateCustName = "UPDATE members SET firstname=' ' WHERE CustId=1"
        '    'ExecuteSQLQuery(straqlUpdateCustName)
        'End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ansint As Integer = 7
        ansint = MsgBox("Are you sure you want Cancel the Picklist", MsgBoxStyle.YesNo, "Cancel Picklist Confirmation")
        If ansint = 6 Then
            btnNew.Enabled = True
            btnRetrievePL.Enabled = True
            btnCancel.Enabled = False
            btnSave.Enabled = False
            drgrid.Rows.Clear()
            leCustomer.EditValue = 0
            leAgent.EditValue = 0
            leCustomer.Text = ""
            leAgent.Text = ""
            cePonum.Value = 0
            dedlvrydate.Text = CStr(Date.Now)
            RetrivNew = 1
            'DGRetrieve.Rows.Clear()
            DGRetrieve.Visible = False
            Call Disablectrl()
        End If
    End Sub
End Class




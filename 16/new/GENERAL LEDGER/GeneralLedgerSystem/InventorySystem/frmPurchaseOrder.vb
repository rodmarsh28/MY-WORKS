Public Class frmPurchaseOrder
    Public rows As Integer
    Public totalAmount As Double
    Dim itemDesc As String
    Dim serial As String
    Dim unit As String
    Dim uprice As Double
    Dim quantity As String
    Dim amount As Double
    Dim lessVat As Double
    Dim taxexcempted As String
    Public mode As String
    Dim debitTo As String
    Sub clear()
        txtMaterialDesc.Text = ""
        txtSerial.Text = ""
        txtUnit.Text = ""
        txtUnitPrice.Text = ""
        txtQuantity.Text = ""

    End Sub
    Sub autoCompleteSUPPNAME()
        Try
            Dim col As New AutoCompleteStringCollection

            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT Distinct SUPPLIERNAME from tblPODESC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtSuppName.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtSuppName.AutoCompleteCustomSource = col
                txtSuppName.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteRECOMMENDEDBY()
        Try
            Dim col As New AutoCompleteStringCollection

            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT Distinct RECOMMENDEDBY from tblPODESC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtRecommendedBy.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtRecommendedBy.AutoCompleteCustomSource = col
                txtRecommendedBy.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteAPPROVEDBY()
        Try
            Dim col As New AutoCompleteStringCollection

            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT Distinct APPROVEDBY from tblPODESC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtApprovedBy.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtAddress.AutoCompleteCustomSource = col
                txtApprovedBy.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Sub autoCompleteACCOUNT()
    '    Try
    '        Dim col As New AutoCompleteStringCollection

    '        If conn.State = ConnectionState.Open Then
    '            OleDBC.Dispose()
    '            conn.Close()
    '        End If
    '        If conn.State <> ConnectionState.Open Then
    '            ConnectDatabase()
    '        End If
    '        With OleDBC
    '            .Connection = conn
    '            .CommandText = "SELECT Distinct ACCOUNTDEBIT from tblPOITEM "
    '        End With
    '        OleDBDR = OleDBC.ExecuteReader
    '        If OleDBDR.HasRows Then
    '            While OleDBDR.Read
    '                col.Add(OleDBDR.Item(0))
    '            End While
    '            txtDebitTo.AutoCompleteSource = AutoCompleteSource.CustomSource
    '            txtDebitTo.AutoCompleteCustomSource = col
    '            txtDebitTo.AutoCompleteMode = AutoCompleteMode.Suggest
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Sub autoCompleteUNIT()
        Try
            Dim col As New AutoCompleteStringCollection

            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT Distinct UNIT from tblPOITEM "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtUnit.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtUnit.AutoCompleteCustomSource = col
                txtUnit.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub selectPONo()
        Dim StrID As String
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblPODESC order by PONO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 6, Len(OleDBDR(0)))
                txtPONo.Text = "PO-" & Format(Val(StrID) + 1, "00000")
            Else
                txtPONo.Text = "PO-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub addtoDGW()
        dgw.ClearSelection()
        dgw.Rows.Add()
        dgw.Item(0, rows).Value = txtMaterialDesc.Text
        dgw.Item(1, rows).Value = txtSerial.Text
        dgw.Item(2, rows).Value = txtUnit.Text
        dgw.Item(3, rows).Value = txtUnitPrice.Text * 1
        dgw.Item(5, rows).Value = txtQuantity.Text
        If chkboxLessVat.Checked = True Then
            dgw.Item(4, rows).Value = txtUnitPrice.Text * 1 / 1.12
            totalAmount = totalAmount + txtUnitPrice.Text * txtQuantity.Text / 1.12
            dgw.Item(6, rows).Value = txtUnitPrice.Text * txtQuantity.Text / 1.12
        Else

            dgw.Item(4, rows).Value = 0
            totalAmount = totalAmount + txtUnitPrice.Text * txtQuantity.Text
            dgw.Item(6, rows).Value = txtUnitPrice.Text * txtQuantity.Text
        End If

        rows = dgw.RowCount
        clear()
    End Sub
    Sub edit()
        If MsgBox("ARE YOU SURE YOU WANT TO SAVE THIS PURCHASE ORDER ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Try
                If conn.State = ConnectionState.Open Then
                    OleDBC.Dispose()
                    conn.Close()
                End If
                If conn.State <> ConnectionState.Open Then
                    ConnectDatabase()
                End If
                With OleDBC
                    .Connection = conn
                    .CommandText = "DELETE FROM tblPODESC where PONO='" & txtPONo.Text & "'; " & _
                                    "DELETE FROM tblPOITEM where PONO='" & txtPONo.Text & "'"
                    .ExecuteNonQuery()
                End With
                If conn.State = ConnectionState.Open Then
                    OleDBC.Dispose()
                    conn.Close()
                End If
                If conn.State <> ConnectionState.Open Then
                    ConnectDatabase()
                End If
                With OleDBC
                    .Connection = conn
                    .CommandText = "INSERT INTO tblPODESC VALUES('" & txtPONo.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtPRSRef.Text & _
                        "','" & txtSuppName.Text & _
                        "','" & txtAddress.Text & _
                        "','" & txtContactPerson.Text & _
                        "','" & txtContactNo.Text & _
                        "','" & txtPayTerm.Text & _
                        "','" & totalAmount & _
                        "','" & txtRemakrs.Text & _
                        "','" & txtPreparedBy.Text & _
                        "','" & txtRecommendedBy.Text & _
                        "','" & txtApprovedBy.Text & "','WAITING FOR CASH/CHECK ISSUANCE'" & _
                        ",'" & taxexcempted & "')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
                printPO()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("PURCHASE ORDER SAVED !", MsgBoxStyle.Information, "DONE")
                Me.Close()
            End Try
     
        End If
    End Sub
    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO CREATE AND SAVE PURCHASE ORDER SLIP ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Try
                If conn.State = ConnectionState.Open Then
                    OleDBC.Dispose()
                    conn.Close()
                End If
                If conn.State <> ConnectionState.Open Then
                    ConnectDatabase()
                End If
                With OleDBC
                    .Connection = conn
                    .CommandText = "INSERT INTO tblPODESC VALUES('" & txtPONo.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtPRSRef.Text & _
                        "','" & txtSuppName.Text & _
                        "','" & txtAddress.Text & _
                        "','" & txtContactPerson.Text & _
                        "','" & txtContactNo.Text & _
                        "','" & txtPayTerm.Text & _
                        "','" & totalAmount & _
                        "','" & txtRemakrs.Text & _
                        "','" & txtPreparedBy.Text & _
                        "','" & txtRecommendedBy.Text & _
                        "','" & txtApprovedBy.Text & "','WAITING FOR CASH/CHECK ISSUANCE'" & _
                        ",'" & taxexcempted & "')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
                printPO()
                UpdatePRSStatus()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("THE PURCHASE ORDER HAS BEEN CREATED!", MsgBoxStyle.Information, "SUCCESS")
                If MsgBox("Do You want to Create P.O. Again in this Request ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                    selectPONo()
                    txtSuppName.Text = ""
                    txtAddress.Text = ""
                    txtContactPerson.Text = ""
                    txtContactNo.Text = ""
                    txtRemakrs.Text = ""
                    chkboxLessVat.Checked = False
                    dgw.Rows.Clear()
                    totalAmount = 0
                    lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ " & totalAmount.ToString("n2")
                    rows = 0
                Else
                    Me.Close()
                    frmViewPendingPurchase.showPRS()
                End If
            End Try
        End If
    End Sub
    Sub dgwItemProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw.RowCount
        While col < row1
            itemDesc = dgw.Item(0, col).Value
            serial = dgw.Item(1, col).Value
            unit = dgw.Item(2, col).Value
            uprice = dgw.Item(3, col).Value
            lessVat = dgw.Item(4, col).Value
            quantity = dgw.Item(5, col).Value
            amount = dgw.Item(6, col).Value


            saveItem()

            col = col + 1
        End While

    End Sub
    Sub saveItem()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "INSERT INTO tblPOITEM VALUES('" & txtPONo.Text & _
                    "','" & itemDesc & _
                    "','" & serial & _
                    "','" & unit & _
                    "','" & uprice & _
                    "','" & quantity & _
                    "','" & amount & _
                    "','" & lessVat & "')"

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub UpdatePRSStatus()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "update tblPRSDESC SET REQSTATUS= 'APPROVED FOR PO' where PRSNO ='" & txtPRSRef.Text & "'"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printPO()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT dbo.tblPODESC.PONO,dbo.tblPODESC.[DATE],dbo.tblPODESC.PRSREF,dbo.tblPODESC.SUPPLIERNAME,dbo.tblPODESC.ADDRESS," & _
                    "dbo.tblPODESC.CONTACTPERSON,dbo.tblPODESC.CONTACTNO,dbo.tblPODESC.PAYMENTTERM,dbo.tblPODESC.TOTALAMOUNT,dbo.tblPODESC.REMARKS," & _
                    "dbo.tblPODESC.PREPAREDBY,dbo.tblPODESC.RECOMMENDEDBY,dbo.tblPODESC.APPROVEDBY,dbo.tblPODESC.POSTATUS,dbo.tblPOITEM.ITEMDESC," & _
                    "dbo.tblPOITEM.SERIAL,dbo.tblPOITEM.UNIT,dbo.tblPOITEM.UPRICE,dbo.tblPOITEM.LESSVAT,dbo.tblPOITEM.QTY,dbo.tblPOITEM.AMOUNT FROM dbo.tblPODESC " & _
                    "INNER JOIN dbo.tblPOITEM ON dbo.tblPODESC.PONO = dbo.tblPOITEM.PONO WHERE dbo.tblPODESC.PONO = '" & txtPONo.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("PONO")
                .Columns.Add("DATE")
                .Columns.Add("PRSREF")
                .Columns.Add("SUPPLIERNAME")
                .Columns.Add("ADDRESS")
                .Columns.Add("CONTACTPERSON")
                .Columns.Add("CONTACTNO")
                .Columns.Add("PAYMENTTERM")
                .Columns.Add("TOTALAMOUNT")
                .Columns.Add("REMARKS")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("RECOMMENDEDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("POSTATUS")
                .Columns.Add("ITEMDESC")
                .Columns.Add("SERIAL")
                .Columns.Add("UNIT")
                .Columns.Add("UPRICE")
                .Columns.Add("LESSVAT")
                .Columns.Add("QUANTITY")
                .Columns.Add("AMOUNT")
            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), Convert.ToDecimal(OleDBDR.Item(8)).ToString("c"), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), OleDBDR.Item(14),
                                  OleDBDR.Item(15), OleDBDR.Item(16), Convert.ToDecimal(OleDBDR.Item(17)).ToString("c"), Convert.ToDecimal(OleDBDR.Item(18)).ToString("c"), OleDBDR.Item(19),
                                  Convert.ToDecimal(OleDBDR.Item(20)).ToString("c"))
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New purchaseOrderSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmFindMaterials.showAllMaterialsforPO()
        'autoCompleteACCOUNT()
        autoCompleteAPPROVEDBY()
        autoCompleteRECOMMENDEDBY()
        autoCompleteUNIT()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmFindMaterials.mode = "po"
        frmFindMaterials.dgw.Columns(4).HeaderCell.Value = "UNIT PRICE"
        frmFindMaterials.dgw.Columns(4).DefaultCellStyle.Format = "c"
        frmFindMaterials.ShowDialog()
        lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ " & totalAmount.ToString("n2")
        dgw.ClearSelection()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtMaterialDesc.Text = "" Or txtSerial.Text = "" Or txtUnit.Text = "" Or txtUnitPrice.Text = "" Or txtQuantity.Text = "" Then
        Else
            addtoDGW()
            lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ " & totalAmount.ToString("n2")
        End If
        dgw.ClearSelection()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If mode = "EDIT" Then
            If chkboxLessVat.Checked = True Then
                taxexcempted = "YES"
            Else
                taxexcempted = "NO"
            End If
            edit()

        Else
            If chkboxLessVat.Checked = True Then
                taxexcempted = "YES"
            Else
                taxexcempted = "NO"
            End If
            save()
        End If
    End Sub

    Private Sub DELETEITEMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEITEMToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            totalAmount = totalAmount - dgw.CurrentRow.Cells(6).Value
            dgw.Rows.Remove(row)
            rows = rows - 1
            lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ " & totalAmount.ToString("n2")
        Next
    End Sub

    Private Sub txtUnitPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        InputAccount.mode = "PO"
        InputAccount.ShowDialog()

    End Sub

    Private Sub txtDebitTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub
End Class
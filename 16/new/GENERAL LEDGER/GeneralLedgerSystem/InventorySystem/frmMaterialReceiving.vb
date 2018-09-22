Public Class frmMaterialReceiving
    Public totalAmount As Double
    Dim invtyCode As String
    Dim itemDesc As String
    Dim serial As String
    Dim itemCategories As String
    Dim unit As String
    Dim unitPrice As Double
    Dim quantity As Integer
    Dim amount As Double
    Public rows As Integer
    Dim IC As String
    Dim LessVat As String
    Dim originalPrice As Double
    Dim LessVatAmount As Double
    Private Sub frmMaterialReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        selectMRSNo()
        selectInvtyCode()
        frmFindMaterials.showAllMaterialsforReceiving()
        autoCompleteRECEIVEDBY()
        autoCompleteUNIT()
    End Sub
    Sub clear()
        txtItemDesc.Text = ""
        txtSerial.Text = ""
        txtInvtyCode.Text = ""

        txtUnit.Text = ""
        txtUnitPrice.Text = ""
        txtQuantity.Text = ""
    End Sub
   
    Sub autoCompleteRECEIVEDBY()
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
                .CommandText = "SELECT Distinct RECEIVEDBY from tblMRSDESC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtReceived.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtReceived.AutoCompleteCustomSource = col
                txtReceived.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
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
                .CommandText = "SELECT Distinct UNIT from tblMRSITEM "
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
    Sub selectMRSNo()
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
                .CommandText = "SELECT * from tblMRSDESC order by MRSNO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtMRSNo.Text = "MRS-" & Format(Val(StrID) + 1, "00000")

            Else
                txtMRSNo.Text = "MRS-00001"

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub selectInvtyCode()
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
                .CommandText = "SELECT * from tblINVENTORY order by INVTYCODE DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                IC = "ITM-" & Format(Val(StrID) + 1, "00000")
                txtInvtyCode.Text = IC
            Else
                IC = "ITM-00001"
                txtInvtyCode.Text = IC
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub genIC()
        Dim ICID As String
        ICID = Mid(IC, 7, Len(IC))
        IC = "ITM-" & Format(Val(ICID) + 1, "00000")
        txtInvtyCode.Text = IC

    End Sub
    Sub minIC()
        Dim ICID As String
        ICID = Mid(IC, 7, Len(IC))
        IC = "ITM-" & Format(Val(ICID) - 1, "00000")
        txtInvtyCode.Text = IC
    End Sub
    Sub addtoDGW()
        dgw.ClearSelection()
        dgw.Rows.Add()
        dgw.Item(0, rows).Value = txtInvtyCode.Text
        dgw.Item(1, rows).Value = txtItemDesc.Text
        dgw.Item(2, rows).Value = txtSerial.Text

        dgw.Item(3, rows).Value = txtUnit.Text
        
        dgw.Item(6, rows).Value = txtQuantity.Text
        If chkboxLessVat.Checked = True Then
            dgw.Item(4, rows).Value = txtUnitPrice.Text * 1.12
            dgw.Item(5, rows).Value = txtUnitPrice.Text * txtQuantity.Text
            dgw.Item(7, rows).Value = txtUnitPrice.Text * txtQuantity.Text
            totalAmount = totalAmount + txtUnitPrice.Text * txtQuantity.Text
        Else
            dgw.Item(4, rows).Value = txtUnitPrice.Text * 1
            dgw.Item(5, rows).Value = txtUnitPrice.Text * txtQuantity.Text / 1.12
            dgw.Item(7, rows).Value = txtUnitPrice.Text * txtQuantity.Text
            totalAmount = totalAmount + txtUnitPrice.Text * txtQuantity.Text
        End If
        rows = dgw.RowCount
        clear()
        genIC()
    End Sub
    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO ADD ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "INSERT INTO tblMRSDESC VALUES('" & txtMRSNo.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtPORef.Text & _
                        "','" & txtDR.Text & _
                        "','" & txtSuppName.Text & _
                        "','" & txtAddress.Text & _
                        "','" & txtRemarks.Text & _
                        "','" & totalAmount & _
                        "','" & txtReceived.Text & _
                        "','" & txtDelivered.Text & "','" & LessVat & "')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
                updatePOStatus()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("THE ITEM YOU RECEIVED IS NOW IN !", MsgBoxStyle.Information, "SUCCESS")
                If MsgBox("YOU WANT TO PRINT MATERIAL RECEIVING SLIP ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                    printMRS()
                Else
                    Me.Close()
                End If

                frmViewPendingPurchase.showPOnotReceived()
                Me.Close()
            End Try
        End If
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
                .CommandText = "INSERT INTO tblMRSITEM VALUES('" & txtMRSNo.Text & _
                    "','" & invtyCode & _
                    "','" & itemDesc & _
                    "','" & serial & _
                    "','" & unit & _
                    "','" & unitPrice & _
                    "','" & quantity & _
                    "','" & amount & "')"

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub dgwItemProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw.RowCount
        While col < row1
            INVTYCODE = dgw.Item(0, col).Value
            ITEMDESC = dgw.Item(1, col).Value
            SERIAL = dgw.Item(2, col).Value
            unit = dgw.Item(3, col).Value
            If chkboxLessVat.Checked = True Then
                unitPrice = dgw.Item(5, col).Value
            Else
                unitPrice = dgw.Item(4, col).Value
            End If
            originalPrice = dgw.Item(4, col).Value
            LessVatAmount = dgw.Item(5, col).Value
            quantity = dgw.Item(6, col).Value
            amount = dgw.Item(7, col).Value
            saveItem()
            InventoryStocksUpdate()
            col = col + 1

        End While
    End Sub
    Sub InventoryStocksUpdate()
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
                .CommandText = "SELECT * from tblINVENTORY where INVTYCODE = '" & invtyCode & "'"
        End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                updateStocks()
            Else
                AddItems()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub AddItems()
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
                .CommandText = "INSERT INTO tblINVENTORY VALUES('" & invtyCode & _
                    "','" & itemDesc & _
                    "','" & serial & _
                    "','" & unit & _
                    "','" & originalPrice & _
                    "','" & LessVatAmount & _
                    "','" & quantity & "')"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printMRS()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            Dim c As Integer
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT dbo.tblMRSDESC.MRSNO,dbo.tblMRSDESC.[DATE],dbo.tblMRSDESC.POREFNO,dbo.tblMRSDESC.DR,dbo.tblMRSDESC.SUPPLIERNAME," & _
                    "dbo.tblMRSDESC.ADDRESS,dbo.tblMRSDESC.REMARKS,dbo.tblMRSDESC.RECEIVEDBY,dbo.tblMRSDESC.DELIVEREDBY,dbo.tblMRSITEM.MATERIALDESC," & _
                    "dbo.tblMRSITEM.SERIAL,dbo.tblMRSITEM.UNIT,dbo.tblMRSITEM.QUANTITY FROM dbo.tblMRSITEM INNER JOIN dbo.tblMRSDESC ON dbo.tblMRSDESC.MRSNO = dbo.tblMRSITEM.MRSNO " & _
                    "WHERE dbo.tblMRSDESC.MRSNO = '" & txtMRSNo.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("MRSNO")
                .Columns.Add("DATE")
                .Columns.Add("POREFNO")
                .Columns.Add("DR")
                .Columns.Add("SUPPLIERNAME")
                .Columns.Add("ADDRESS")
                .Columns.Add("REMARKS")
                .Columns.Add("RECEIVEDBY")
                .Columns.Add("DELIVEREDBY")
                .Columns.Add("MATERIALDESC")
                .Columns.Add("SERIAL")
                .Columns.Add("UNIT")
                .Columns.Add("QUANTITY")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12))
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New materialReceivingSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub updateStocks()
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
                .CommandText = "update tblINVENTORY SET STOCKSONHAND=STOCKSONHAND +" & quantity & " where INVTYCODE = '" & invtyCode & "'"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub updatePOStatus()
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
                .CommandText = "update tblPODESC SET POSTATUS = 'RECEIVED' where PONO = '" & txtPORef.Text & "'"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtItemDesc.Text = "" Or txtSerial.Text = "" Or txtInvtyCode.Text = "" Or txtUnit.Text = "" Or txtUnitPrice.Text = "" Or txtQuantity.Text = "" Then
        Else
            addtoDGW()
            lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ " & totalAmount.ToString("n2")
        End If
        dgw.ClearSelection()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmFindMaterials.mode = "mrs"
        frmFindMaterials.dgw.Columns(4).HeaderCell.Value = "UNIT PRICE"
        frmFindMaterials.dgw.Columns(4).DefaultCellStyle.Format = "c"
        frmFindMaterials.ShowDialog()
        lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ " & totalAmount.ToString("n2")
        dgw.ClearSelection()
    End Sub
    Sub haveDatabase()

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
                .CommandText = "SELECT * from tblINVENTORY where INVTYCODE = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
            Else
                minIC()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub


    Private Sub DELELTEITEMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELELTEITEMToolStripMenuItem.Click

        For Each row As DataGridViewRow In dgw.SelectedRows
            totalAmount = totalAmount - dgw.CurrentRow.Cells(7).Value
            haveDatabase()
            dgw.Rows.Remove(row)
            rows = rows - 1
            lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ " & totalAmount.ToString("n2")
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If chkboxLessVat.Checked = True Then
            LessVat = "YES"
        Else
            LessVat = "NO"
        End If
        save()
        frmInventorySystem.showInventory()
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUnitPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged

    End Sub
End Class
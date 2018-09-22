Public Class frmAddReqOfDept
    Dim c As Integer = 0
    Dim MaterialDesc As String
    Dim ITMNo As String
    Dim debit As String
    Dim unit As String
    Dim quantity As String
    Dim ITEMID2 As String
    Dim nocount As Integer = 0
    Public accno As String
    'Sub autoCompleteAccounts()
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
    '            .CommandText = "SELECT Distinct ACCOUNTDEBIT from tblMWSITEM "
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
    Sub autoCompleteTO()
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
                .CommandText = "SELECT Distinct sTo from tblMWSDESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtTo.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtTo.AutoCompleteCustomSource = col
                txtTo.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteSection()
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
                .CommandText = "SELECT Distinct SECTION from tblMWSDESC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtSection.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtSection.AutoCompleteCustomSource = col
                txtSection.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteDepartment()
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
                .CommandText = "SELECT Distinct DEPARTMENT from tblMWSDESC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtDeprt.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtDeprt.AutoCompleteCustomSource = col
                txtDeprt.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompletePREPAREDBY()
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
                .CommandText = "SELECT Distinct PREPAREDBY from tblMWSDESC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtPREPAREDBY.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtPREPAREDBY.AutoCompleteCustomSource = col
                txtPREPAREDBY.AutoCompleteMode = AutoCompleteMode.Suggest
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
                .CommandText = "SELECT Distinct APPROVEDBY from tblMWSDESC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtAPPROVEDBY.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtAPPROVEDBY.AutoCompleteCustomSource = col
                txtAPPROVEDBY.AutoCompleteMode = AutoCompleteMode.Suggest
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
                .CommandText = "SELECT Distinct UNIT from tblMWSITEM "
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
    Sub clear()
        txtMaterialDesc.Text = ""
        txtDebitTo.Text = ""
        txtUnit.Text = ""
        txtQuantity.Text = ""
    End Sub
    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO ADD ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Try
                frmLoadingBar.Show()
                If conn.State = ConnectionState.Open Then
                    OleDBC.Dispose()
                    conn.Close()
                End If
                If conn.State <> ConnectionState.Open Then
                    ConnectDatabase()
                End If
                With OleDBC
                    .Connection = conn
                    .CommandText = "INSERT INTO tblMWSDESC VALUES('" & LBLMWSNO.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtTo.Text & _
                        "','" & txtSection.Text & _
                        "','" & txtDeprt.Text & _
                        "','" & txtJustification.Text & _
                        "','" & txtPREPAREDBY.Text & _
                        "','" & txtAPPROVEDBY.Text & "','NO')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("YOUR REQUEST HAS BEEN POSTED !", MsgBoxStyle.Information, "SUCCESS")
                If MsgBox("YOU WANT TO PRINT MATERIAL WIDTHRAWAL SLIP ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                    printMWS()
                Else
                    Me.Close()
                End If
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
                .CommandText = "INSERT INTO tblMWSITEM VALUES('" & LBLMWSNO.Text & _
                    "','" & MaterialDesc & _
                    "','" & debit & _
                    "','" & unit & _
                    "','" & quantity & "')"
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
            MaterialDesc = dgw.Item(1, col).Value
            debit = dgw.Item(5, col).Value
            unit = dgw.Item(3, col).Value
            quantity = dgw.Item(4, col).Value
            saveItem()
            col = col + 1
            
        End While
    End Sub
    Sub generateMWSNo()
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
                .CommandText = "SELECT * from tblMWSDESC order by MWSDESCNO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                LBLMWSNO.Text = "MWS-" & Format(Val(StrID) + 1, "00000")
            Else
                LBLMWSNO.Text = "MWS-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    'Sub generateMWSITEMNo()
    '    Dim strID2 As String
    '    Try
    '        If conn.State = ConnectionState.Open Then
    '            OleDBC.Dispose()
    '            conn.Close()
    '        End If
    '        If conn.State <> ConnectionState.Open Then
    '            ConnectDatabase()
    '        End If
    '        With OleDBC
    '            .Connection = conn
    '            .CommandText = "SELECT * from tblMWSITEM order by MWSITEMID DESC"
    '        End With
    '        OleDBDR = OleDBC.ExecuteReader
    '        If OleDBDR.Read Then
    '            strID2 = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
    '            dgw.Item(0, c).Value = "ITM-" & Format(Val(strID2) + nocount + 1, "00000")

    '        Else
    '            Dim def As String
    '            def = "ITM-00001"
    '            strID2 = Mid(def, 7, Len(def))
    '            dgw.Item(0, c).Value = "ITM-" & Format(Val(def) + nocount + 1, "00000")
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally

    '    End Try
    'End Sub

    Private Sub frmAddReqOfDept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generateMWSNo()
        autoCompleteTO()
        autoCompleteSection()
        autoCompleteDepartment()
        autoCompletePREPAREDBY()
        autoCompleteAPPROVEDBY()
        autoCompleteUNIT()
    End Sub
    Sub addToDGW()
        dgw.ClearSelection()
        dgw.Rows.Add()
        dgw.Item(1, c).Value = txtMaterialDesc.Text
        dgw.Item(2, c).Value = txtDebitTo.Text
        dgw.Item(3, c).Value = txtUnit.Text
        dgw.Item(4, c).Value = txtQuantity.Text
        dgw.Item(5, c).Value = accno
        c = c + 1
        nocount = nocount + 1
        clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtMaterialDesc.Text = "" Or txtDebitTo.Text = "" Or txtUnit.Text = "" Or txtQuantity.Text = "" Then
        Else
            addToDGW()
        End If
        dgw.ClearSelection()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        save()
    End Sub
    Sub printMWS()

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
                .CommandText = "SELECT dbo.tblMWSDESC.MWSDESCNO,dbo.tblMWSDESC.[DATE],dbo.tblMWSDESC.[sTO],dbo.tblMWSDESC.[SECTION]," & _
                    "dbo.tblMWSDESC.DEPARTMENT,dbo.tblMWSDESC.JUSTIFICATION,dbo.tblMWSDESC.PREPAREDBY,dbo.tblMWSDESC.APPROVEDBY,dbo.tblMWSITEM.MATERIALDESC,dbo.tblCOA.ACCOUNTNAME,dbo.tblMWSITEM.UNIT," & _
                    "dbo.tblMWSITEM.QTY FROM dbo.tblMWSDESC INNER JOIN dbo.tblMWSITEM ON dbo.tblMWSDESC.MWSDESCNO = dbo.tblMWSITEM.MWSDESCNO INNER JOIN dbo.tblCOA ON dbo.tblMWSITEM.ACCNO = dbo.tblCOA.ACCNO " & _
                    "where dbo.tblMWSDESC.MWSDESCNO = '" & LBLMWSNO.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("MWSDESCNO")
                .Columns.Add("DATE")
                .Columns.Add("TO")
                .Columns.Add("SECTION")
                .Columns.Add("DEPARTMENT")
                .Columns.Add("JUSTIFICATION")
                .Columns.Add("MATERIALDESC")
                .Columns.Add("DEBITTO")
                .Columns.Add("UNIT")
                .Columns.Add("QTY")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("APPROVEDBY")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(8),
                                 OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(6), OleDBDR.Item(7))
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New materialWithdrawalSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoadingBar.Close()
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DELETEITEMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEITEMToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            dgw.Rows.Remove(row)
            c = c - 1
        Next
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        InputAccount.mode = "MWS"
        InputAccount.ShowDialog()
    End Sub
End Class
Public Class frmRequestForCash
    Sub CLEAR()
        txtTo.Text = "PCF CUSTODIAN"
        txtSection.Text = ""
        txtDepartment.Text = ""
        txtPayee.Text = ""
        txtPurpose.Text = ""
        txtIDNo.Text = ""
        txtAmount.Text = ""
        txtRequestedBy.Text = ""
        txtApprovedBy.Text = ""
    End Sub
    Sub autoCompleteTo()
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
                .CommandText = "SELECT Distinct xTO from tblRFC "
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
    Sub autoCompleteSECTION()
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
                .CommandText = "SELECT Distinct SECTION from tblRFC "
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
    Sub autoCompleteDEPARTMENT()
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
                .CommandText = "SELECT Distinct DEPARTMENT from tblRFC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtDepartment.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtDepartment.AutoCompleteCustomSource = col
                txtDepartment.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompletePAYEE()
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
                .CommandText = "SELECT Distinct PAYEE from tblRFC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtPayee.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtPayee.AutoCompleteCustomSource = col
                txtPayee.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteIDNO()
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
                .CommandText = "SELECT Distinct IDNO from tblRFC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtIDNo.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtIDNo.AutoCompleteCustomSource = col
                txtIDNo.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteApprovedBy()
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
                .CommandText = "SELECT Distinct APPROVEDBY from tblRFC "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtApprovedBy.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtApprovedBy.AutoCompleteCustomSource = col
                txtApprovedBy.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub generateRFCNo()
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
                .CommandText = "SELECT * from tblRFC order by RFCNO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtRFCNO.Text = "RFC-" & Format(Val(StrID) + 1, "00000")
            Else
                txtRFCNO.Text = "RFC-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub

    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO SAVE REQUST FOR CASH ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "INSERT INTO tblRFC VALUES('" & txtRFCNO.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtTo.Text & _
                        "','" & txtSection.Text & _
                        "','" & txtDepartment.Text & _
                        "','" & txtPayee.Text & _
                        "','" & txtPurpose.Text & _
                        "','" & txtIDNo.Text & _
                        "','" & txtAmount.Text & _
                        "','" & txtRequestedBy.Text & _
                        "','" & txtApprovedBy.Text & "','WAITING FOR APPROVED')"
                    .ExecuteNonQuery()
                End With
                printRFC()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("THE REQUEST FOR CASH HAS BEEN CREATED!", MsgBoxStyle.Information, "SUCCESS")
                CLEAR()
                Me.Close()
            End Try
        End If
    End Sub
    Sub printRFC()

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
                .CommandText = "SELECT dbo.tblRFC.RFCNO,dbo.tblRFC.[DATE],dbo.tblRFC.xTO,dbo.tblRFC.[SECTION],dbo.tblRFC.DEPARTMENT," & _
                                "dbo.tblRFC.PAYEE,dbo.tblRFC.PURPOSE,dbo.tblRFC.IDNO,dbo.tblRFC.AMOUNT,dbo.tblRFC.REQUESTEDBY,dbo.tblRFC.APPROVEDBY FROM dbo.tblRFC " & _
                                "WHERE dbo.tblRFC.RFCNO = '" & txtRFCNO.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("RFCNO")
                .Columns.Add("DATE")
                .Columns.Add("xTO")
                .Columns.Add("SECTION")
                .Columns.Add("DEPARTMENT")
                .Columns.Add("PAYEE")
                .Columns.Add("PURPOSE")
                .Columns.Add("IDNO")
                .Columns.Add("AMOUNT")
                .Columns.Add("REQUESTEDBY")
                .Columns.Add("APPROVEDBY")

            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), Convert.ToDecimal(OleDBDR.Item(8)).ToString("c"), OleDBDR.Item(9), OleDBDR.Item(10))
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New requestForCash
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoadingBar.Close()
            reportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRequestForCash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generateRFCNo()
        autoCompleteTo()
        autoCompletePAYEE()
        autoCompleteDEPARTMENT()
        autoCompleteIDNO()
        autoCompleteSECTION()
        autoCompleteApprovedBy()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub txtDepartment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepartment.TextChanged

    End Sub
End Class
Public Class frmMaterialsIssuance
    Public rows As Integer = 0
    Dim INVTYCODE As String
    Dim ITEMDESC As String
    Dim SERIAL As String
    Dim DEBIT As String
    Dim UNIT As String
    Dim QTY As String
    Dim ACQUISITIONUNITCOST As Double
    Dim ACQUISITIONCOST As Double
    Dim REMAININGSTOCKS As Integer
    Public totalAcquisitionCost As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mode = "mis"
        frmFindMaterials.dgw.Columns(4).HeaderCell.Value = "STOCKS ON HAND"
        frmFindMaterials.dgw.Columns(4).DefaultCellStyle.Format = ""
        frmFindMaterials.ShowDialog()
        dgw.ClearSelection()
    End Sub

    Private Sub frmMaterialsIssuance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generateMISNo()
        frmFindMaterials.showAllMaterials()
    End Sub
 
    Sub generateMISNo()
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
                .CommandText = "SELECT * from tblMISDESC order by MISNO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtMisNo.Text = "MIS-" & Format(Val(StrID) + 1, "00000")
            Else
                txtMisNo.Text = "MIS-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
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
                    .CommandText = "INSERT INTO tblMISDESC VALUES('" & txtMisNo.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtMWSRefNo.Text & _
                        "','" & txtSection.Text & _
                        "','" & txtDepartment.Text & _
                        "','" & txtReferrence.Text & _
                        "','" & txtIssuedBy.Text & _
                        "','" & txtApprovedBy.Text & _
                        "','" & txtRequestor.Text & "','NO')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
                requestUpdateStatus()
                printMIS()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("THE REQUEST HAS BEEN ISSUED!", MsgBoxStyle.Information, "SUCCESS")
                frmViewIssuedReq.Refresh()
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
                .CommandText = "INSERT INTO tblMISITEM VALUES('" & INVTYCODE & _
                    "','" & txtMisNo.Text & _
                    "','" & ITEMDESC & _
                    "','" & SERIAL & _
                    "','" & UNIT & _
                    "','" & QTY  & "')"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub stocksUpdate()
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
                .CommandText = "update tblINVENTORY SET STOCKSONHAND=STOCKSONHAND -" & QTY & " where INVTYCODE = '" & INVTYCODE & "'"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub requestUpdateStatus()
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
                .CommandText = "update tblMWSDESC SET ISISSUED= 'YES' where MWSDESCNO ='" & txtMWSRefNo.Text & "'"
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
            UNIT = dgw.Item(3, col).Value
            QTY = dgw.Item(4, col).Value
            saveItem()
            stocksUpdate()
            col = col + 1

        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        save()
        frmInventorySystem.showInventory()
        frmViewIssuedReq.showPendingRequest()
    End Sub
    Sub printMIS()

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
                .CommandText = "SELECT dbo.tblMISDESC.MISNO,dbo.tblMISDESC.[DATE],dbo.tblMISDESC.MWSREF,dbo.tblMISDESC.[SECTION],dbo.tblMISDESC.DEPARTMENT," & _
                    "dbo.tblMISDESC.REMARKS,dbo.tblMISDESC.ISSUEDBY,dbo.tblMISDESC.APPROVEDBY,dbo.tblMISDESC.RECEIVEDBY,dbo.tblMISITEM.INVTYCODE,dbo.tblMISITEM.MATERIALDESC,dbo.tblMISITEM.TYPE," & _
                    "dbo.tblMISITEM.TYPE,dbo.tblMISITEM.UNIT,dbo.tblMISITEM.QTY FROM dbo.tblMISITEM INNER JOIN dbo.tblMISDESC ON dbo.tblMISITEM.MISNO = dbo.tblMISDESC.MISNO " & _
                    "WHERE dbo.tblMISDESC.MISNO = '" & txtMisNo.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("MISNO")
                .Columns.Add("DATE")
                .Columns.Add("MWSREF")
                .Columns.Add("SECTION")
                .Columns.Add("DEPARTMENT")
                .Columns.Add("REMARKS")
                .Columns.Add("ISSUEDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("RECEIVEDBY")
                .Columns.Add("INVTYCODE")
                .Columns.Add("MATERIALDESC")
                .Columns.Add("SERIAL")
                .Columns.Add("DEBITTO")
                .Columns.Add("UNIT")
                .Columns.Add("QTY")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), OleDBDR.Item(14))
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New materialIssuanceSlip
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
            rows = rows - 1
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            dgw.Rows.Remove(row)
            rows = rows - 1
        Next
    End Sub
End Class
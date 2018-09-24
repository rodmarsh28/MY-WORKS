Public Class frmTransactionReportForMember
    Dim total As Double = 0.0
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        frmNameList.ShowDialog()
    End Sub
    Sub showItemAcquire()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "SELECT dbo.tblMISDESC.[DATE],dbo.tblMISITEM.MATERIALDESC,dbo.tblMISITEM.TYPE,dbo.tblMISITEM.ACCNO,dbo.tblMISITEM.UNIT" & _
                        ",dbo.tblMISITEM.QTY,dbo.tblMISITEM.ACQUISITIONUNITCOST,dbo.tblMISDESC.ISRECEIVED FROM dbo.tblMISDESC INNER JOIN dbo.tblMISITEM ON " & _
                        "dbo.tblMISDESC.MISNO = dbo.tblMISITEM.MISNO where RECEIVEDBY = '" & txtName.Text & "'" & _
                        " and ISRECEIVED != 'RETURNED' order by date desc"
                End With
            Else
                With OleDBC
                    .Connection = conn
                    .CommandText = "SELECT dbo.tblMISDESC.[DATE],dbo.tblMISITEM.MATERIALDESC,dbo.tblMISITEM.TYPE,dbo.tblMISITEM.ACCNO,dbo.tblMISITEM.UNIT" & _
                        ",dbo.tblMISITEM.QTY,dbo.tblMISITEM.ACQUISITIONUNITCOST,dbo.tblMISDESC.ISRECEIVED FROM dbo.tblMISDESC INNER JOIN dbo.tblMISITEM ON " & _
                        "dbo.tblMISDESC.MISNO = dbo.tblMISITEM.MISNO where RECEIVEDBY = '" & txtName.Text & "'" & _
                        " and ISRECEIVED = 'YES' order by date desc"
                End With
            End If
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            total = 0.0
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(0), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    dgw.Item(4, c).Value = OleDBDR.Item(4)
                    dgw.Item(5, c).Value = OleDBDR.Item(5)
                    dgw.Item(6, c).Value = OleDBDR.Item(6)
                    dgw.Item(7, c).Value = OleDBDR.Item(7)
                    total = total + OleDBDR.Item(6)
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lblTotalAmount.Text = CDbl(total).ToString("#,##0.00")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub SearchItemAcquire()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "SELECT dbo.tblMISDESC.[DATE],dbo.tblMISITEM.MATERIALDESC,dbo.tblMISITEM.TYPE,dbo.tblMISITEM.UNIT" & _
                        ",dbo.tblMISITEM.QTY,dbo.tblMISITEM.ACQUISITIONUNITCOST,dbo.tblMISDESC.ISRECEIVED FROM dbo.tblMISDESC INNER JOIN dbo.tblMISITEM ON " & _
                        "dbo.tblMISDESC.MISNO = dbo.tblMISITEM.MISNO where DATE between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & _
                        "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & "' and RECEIVEDBY = '" & txtName.Text & "' and ISRECEIVED != 'RETURNED' order by date desc"
                End With
            Else
                With OleDBC
                    .Connection = conn
                    .CommandText = "SELECT dbo.tblMISDESC.[DATE],dbo.tblMISITEM.MATERIALDESC,dbo.tblMISITEM.TYPE,dbo.tblMISITEM.ACCOUNTDEBIT,dbo.tblMISITEM.UNIT" & _
                        ",dbo.tblMISITEM.QTY,dbo.tblMISITEM.ACQUISITIONUNITCOST,dbo.tblMISDESC.ISRECEIVED FROM dbo.tblMISDESC INNER JOIN dbo.tblMISITEM ON " & _
                        "dbo.tblMISDESC.MISNO = dbo.tblMISITEM.MISNO where DATE between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & _
                        "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & "' and RECEIVEDBY = '" & txtName.Text & "' and ISRECEIVED = 'YES' order by date desc"
                End With
            End If
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            total = 0.0
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(0), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    dgw.Item(4, c).Value = OleDBDR.Item(4)
                    dgw.Item(5, c).Value = OleDBDR.Item(5)
                    dgw.Item(6, c).Value = OleDBDR.Item(6)
                    dgw.Item(7, c).Value = OleDBDR.Item(7)
                    total = total + OleDBDR.Item(6)
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lblTotalAmount.Text = CDbl(total).ToString("#,##0.00")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If Format(dtpFrom.Value, "dd/MM/yyyy") = Format(Now, "dd/MM/yyyy") And Format(dtpTo.Value, "dd/MM/yyyy") = Format(Now, "dd/MM/yyyy") Then
            showItemAcquire()
        Else
            SearchItemAcquire()
        End If

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        showItemAcquire()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dtpFrom.Value = Now
        dtpTo.Value = Now
        showItemAcquire()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SearchItemAcquire()
    End Sub

    Private Sub dgw_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgw.SelectionChanged
        dgw.ClearSelection()
    End Sub
End Class
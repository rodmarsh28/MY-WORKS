Public Class frmExpensesHistory
    Sub viewExpensesHistory()
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
                .CommandText = "SELECT dbo.tblSummaryExpenses.[date],dbo.tblVehicle.plateNo,dbo.tblVehicle.vehicleModel," & _
                    "dbo.tblSummaryExpenses.expenseType,dbo.tblSummaryExpenses.qty,dbo.tblSummaryExpenses.unit," & _
                    "dbo.tblSummaryExpenses.unitPrice,dbo.tblSummaryExpenses.totalPrice,dbo.tblSummaryExpenses.prevOdometer," & _
                    "dbo.tblSummaryExpenses.currentOdometer,dbo.tblSummaryExpenses.kml FROM dbo.tblSummaryExpenses INNER JOIN " & _
                    "dbo.tblVehicle ON dbo.tblSummaryExpenses.vID = dbo.tblVehicle.vID order by date desc"

            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(0), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    dgw.Item(4, c).Value = OleDBDR.Item(4) & " " & OleDBDR.Item(5)
                    dgw.Item(5, c).Value = Format(OleDBDR.Item(6), "###,###.00")
                    dgw.Item(6, c).Value = Format(OleDBDR.Item(7), "###,###.00")
                    dgw.Item(7, c).Value = OleDBDR.Item(8)
                    dgw.Item(8, c).Value = OleDBDR.Item(9)
                    dgw.Item(9, c).Value = OleDBDR.Item(10)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmExpensesHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewExpensesHistory()
    End Sub
End Class
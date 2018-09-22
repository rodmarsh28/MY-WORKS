﻿Public Class frmFindMaterials
    Public mode As String
    Public debitTo As String

    Sub showAllMaterials()
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
                .CommandText = "select * from tblINVENTORY"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    dgw.Item(4, c).Value = OleDBDR.Item(6)
                    dgw.Item(5, c).Value = OleDBDR.Item(4)
                    dgw.Item(6, c).Value = OleDBDR.Item(5)
                    

                    c = c + 1
                End While
            End If
            dgw.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub showAllMaterialsforPO()
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
                .CommandText = "select * from tblINVENTORY"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    dgw.Item(4, c).Value = OleDBDR.Item(4)
                    dgw.Item(5, c).Value = OleDBDR.Item(4)
                    dgw.Item(6, c).Value = OleDBDR.Item(5)


                    c = c + 1
                End While
            End If
            dgw.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub showAllMaterialsforReceiving()
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
                .CommandText = "select * from tblINVENTORY"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    dgw.Item(4, c).Value = OleDBDR.Item(4)
                    dgw.Item(5, c).Value = OleDBDR.Item(6)
                    dgw.Item(6, c).Value = OleDBDR.Item(5)


                    c = c + 1
                End While
            End If
            dgw.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmFindMaterials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InputAccount.mode = "FM"
    End Sub

    Private Sub dgw_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellDoubleClick
        If mode = "prs" Then
            purchaseRequesitionFunction()
        ElseIf mode = "mis" Then
            materialIssuanceFunction()
        ElseIf mode = "po" Then
            purchaseOrderFunction()
        ElseIf mode = "mrs" Then
            materialsReceivingFunction()
        End If

    End Sub
    Sub materialsReceivingFunction()
        Dim qty As String = InputBox("Quantity you Received ?", "Please Enter Quantity")
        If qty = " " Or qty = "" Then
            MessageBox.Show("You must enter a Quantity to Continue")
            Exit Sub
        ElseIf Not IsNumeric(qty) Then
            MessageBox.Show("You must enter a Number to Continue")
            Exit Sub
        End If
        frmMaterialReceiving.dgw.Rows.Add()
        frmMaterialReceiving.dgw.Item(0, frmMaterialReceiving.rows).Value = dgw.CurrentRow.Cells(0).Value
        frmMaterialReceiving.dgw.Item(1, frmMaterialReceiving.rows).Value = dgw.CurrentRow.Cells(1).Value
        frmMaterialReceiving.dgw.Item(2, frmMaterialReceiving.rows).Value = dgw.CurrentRow.Cells(2).Value
        frmMaterialReceiving.dgw.Item(3, frmMaterialReceiving.rows).Value = dgw.CurrentRow.Cells(3).Value
        frmMaterialReceiving.dgw.Item(6, frmMaterialReceiving.rows).Value = qty
        frmMaterialReceiving.dgw.Item(5, frmMaterialReceiving.rows).Value = dgw.CurrentRow.Cells(6).Value
        frmMaterialReceiving.dgw.Item(4, frmMaterialReceiving.rows).Value = dgw.CurrentRow.Cells(4).Value
        If frmMaterialReceiving.chkboxLessVat.Checked = True Then
            frmMaterialReceiving.dgw.Item(7, frmMaterialReceiving.rows).Value = dgw.CurrentRow.Cells(6).Value * qty
            frmMaterialReceiving.totalAmount = frmMaterialReceiving.totalAmount + dgw.CurrentRow.Cells(6).Value * qty
        Else
            frmMaterialReceiving.dgw.Item(7, frmMaterialReceiving.rows).Value = dgw.CurrentRow.Cells(4).Value * qty
            frmMaterialReceiving.totalAmount = frmMaterialReceiving.totalAmount + dgw.CurrentRow.Cells(4).Value * qty
        End If
        frmMaterialReceiving.rows = frmMaterialReceiving.dgw.RowCount
        Me.Close()



    End Sub
    Sub purchaseOrderFunction()
        InputAccount.ShowDialog()
        Dim qty As String = InputBox("How Many you Want to Purchase ?", "Please Enter Quantity")
        If qty = " " Or qty = "" Then
            MessageBox.Show("You must enter a Quantity to Continue")
            Exit Sub
        ElseIf Not IsNumeric(qty) Then
            MessageBox.Show("You must enter a Number to Continue")
            Exit Sub
        End If
        frmPurchaseOrder.dgw.Rows.Add()
        frmPurchaseOrder.dgw.Item(0, frmPurchaseOrder.rows).Value = dgw.CurrentRow.Cells(1).Value
        frmPurchaseOrder.dgw.Item(1, frmPurchaseOrder.rows).Value = dgw.CurrentRow.Cells(2).Value
        frmPurchaseOrder.dgw.Item(2, frmPurchaseOrder.rows).Value = debitTo
        frmPurchaseOrder.dgw.Item(3, frmPurchaseOrder.rows).Value = dgw.CurrentRow.Cells(3).Value
        frmPurchaseOrder.dgw.Item(4, frmPurchaseOrder.rows).Value = dgw.CurrentRow.Cells(5).Value
        If frmPurchaseOrder.chkboxLessVat.Checked = True Then
            frmPurchaseOrder.dgw.Item(5, frmPurchaseOrder.rows).Value = dgw.CurrentRow.Cells(6).Value
            frmPurchaseOrder.dgw.Item(7, frmPurchaseOrder.rows).Value = dgw.CurrentRow.Cells(6).Value * qty
            frmPurchaseOrder.totalAmount = frmPurchaseOrder.totalAmount + dgw.CurrentRow.Cells(6).Value * qty
        Else
            frmPurchaseOrder.dgw.Item(5, frmPurchaseOrder.rows).Value = 0
            frmPurchaseOrder.dgw.Item(7, frmPurchaseOrder.rows).Value = dgw.CurrentRow.Cells(5).Value * qty
            frmPurchaseOrder.totalAmount = frmPurchaseOrder.totalAmount + dgw.CurrentRow.Cells(5).Value * qty
        End If
        frmPurchaseOrder.dgw.Item(6, frmPurchaseOrder.rows).Value = qty

        frmPurchaseOrder.rows = frmPurchaseOrder.dgw.RowCount
        Me.Close()
    End Sub
    Sub purchaseRequesitionFunction()
       
        Dim qty As String = InputBox("How Many you Want to Request ?", "Please Enter Quantity")
        If qty = " " Or qty = "" Then
            MessageBox.Show("You must enter a Quantity to Continue")
            Exit Sub
        ElseIf Not IsNumeric(qty) Then
            MessageBox.Show("You must enter a Number to Continue")
            Exit Sub
        End If
        frmPurchaseRequestSlip.dgw.Rows.Add()
        frmPurchaseRequestSlip.dgw.Item(0, frmPurchaseRequestSlip.rows).Value = dgw.CurrentRow.Cells(0).Value
        frmPurchaseRequestSlip.dgw.Item(1, frmPurchaseRequestSlip.rows).Value = dgw.CurrentRow.Cells(1).Value
        frmPurchaseRequestSlip.dgw.Item(2, frmPurchaseRequestSlip.rows).Value = dgw.CurrentRow.Cells(2).Value
        frmPurchaseRequestSlip.dgw.Item(3, frmPurchaseRequestSlip.rows).Value = dgw.CurrentRow.Cells(3).Value
        frmPurchaseRequestSlip.dgw.Item(4, frmPurchaseRequestSlip.rows).Value = qty
        frmPurchaseRequestSlip.dgw.Item(5, frmPurchaseRequestSlip.rows).Value = dgw.CurrentRow.Cells(4).Value
        frmPurchaseRequestSlip.rows = frmPurchaseRequestSlip.dgw.RowCount
        Me.Close()


    End Sub
    Sub materialIssuanceFunction()
        'Dim deb As String = InputBox("DEBIT TO")
        'If deb = " " Or deb = "" Then
        '    MessageBox.Show("You must enter a type to Continue")
        '    Exit Sub
        'End If
        InputAccount.ShowDialog()
        Dim qty As String = InputBox("How Many you Want to Issue ?", "Please Enter Quantity")
        If qty = " " Or qty = "" Then
            MessageBox.Show("You must enter a Quantity to Continue")
            Exit Sub
        ElseIf Not IsNumeric(qty) Then
            MessageBox.Show("You must enter a Number to Continue")
            Exit Sub
        Else
            If dgw.CurrentRow.Cells(4).Value < qty Then
                MsgBox("We dont Have that much Stocks, Please Input quantity that we have only", MsgBoxStyle.Exclamation, "Out of Stock")
            Else
                frmMaterialsIssuance.dgw.Rows.Add()
                frmMaterialsIssuance.dgw.Item(0, frmMaterialsIssuance.rows).Value = dgw.CurrentRow.Cells(0).Value
                frmMaterialsIssuance.dgw.Item(1, frmMaterialsIssuance.rows).Value = dgw.CurrentRow.Cells(1).Value
                frmMaterialsIssuance.dgw.Item(2, frmMaterialsIssuance.rows).Value = dgw.CurrentRow.Cells(2).Value
                frmMaterialsIssuance.dgw.Item(3, frmMaterialsIssuance.rows).Value = debitTo
                frmMaterialsIssuance.dgw.Item(4, frmMaterialsIssuance.rows).Value = dgw.CurrentRow.Cells(3).Value
                frmMaterialsIssuance.dgw.Item(5, frmMaterialsIssuance.rows).Value = qty
                frmMaterialsIssuance.dgw.Item(6, frmMaterialsIssuance.rows).Value = dgw.CurrentRow.Cells(5).Value
                frmMaterialsIssuance.dgw.Item(7, frmMaterialsIssuance.rows).Value = dgw.CurrentRow.Cells(5).Value * qty
                dgw.CurrentRow.Cells(5).Value = dgw.CurrentRow.Cells(5).Value - qty
                frmMaterialsIssuance.rows = frmMaterialsIssuance.dgw.RowCount
                frmMaterialsIssuance.totalAcquisitionCost = frmMaterialsIssuance.totalAcquisitionCost + dgw.CurrentRow.Cells(6).Value * qty
                Me.Close()
            End If
        End If

    End Sub



    Private Sub cmbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClose.Click
        Me.Close()
    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub
End Class
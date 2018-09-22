<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accEntry
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgwAcc = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwType = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDebit = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.chkDebit = New System.Windows.Forms.CheckBox()
        Me.chkCredit = New System.Windows.Forms.CheckBox()
        CType(Me.dgwAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PLEASE SELECT ACCOUNT"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgwAcc
        '
        Me.dgwAcc.AllowUserToAddRows = False
        Me.dgwAcc.AllowUserToDeleteRows = False
        Me.dgwAcc.AllowUserToResizeRows = False
        Me.dgwAcc.BackgroundColor = System.Drawing.Color.White
        Me.dgwAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAcc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgwAcc.Location = New System.Drawing.Point(309, 63)
        Me.dgwAcc.Name = "dgwAcc"
        Me.dgwAcc.ReadOnly = True
        Me.dgwAcc.RowHeadersVisible = False
        Me.dgwAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwAcc.Size = New System.Drawing.Size(368, 107)
        Me.dgwAcc.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ACCOUNT DESCRIPTION"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 260
        '
        'dgwType
        '
        Me.dgwType.AllowUserToAddRows = False
        Me.dgwType.AllowUserToDeleteRows = False
        Me.dgwType.AllowUserToResizeRows = False
        Me.dgwType.BackgroundColor = System.Drawing.Color.White
        Me.dgwType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgwType.Location = New System.Drawing.Point(17, 63)
        Me.dgwType.Name = "dgwType"
        Me.dgwType.ReadOnly = True
        Me.dgwType.RowHeadersVisible = False
        Me.dgwType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwType.Size = New System.Drawing.Size(286, 107)
        Me.dgwType.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ACCOUNT TYPE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 180
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(421, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 36)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDebit
        '
        Me.txtDebit.Location = New System.Drawing.Point(697, 84)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(122, 20)
        Me.txtDebit.TabIndex = 11
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(697, 129)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(122, 20)
        Me.txtCredit.TabIndex = 12
        '
        'chkDebit
        '
        Me.chkDebit.AutoSize = True
        Me.chkDebit.Location = New System.Drawing.Point(697, 66)
        Me.chkDebit.Name = "chkDebit"
        Me.chkDebit.Size = New System.Drawing.Size(58, 17)
        Me.chkDebit.TabIndex = 13
        Me.chkDebit.Text = "DEBIT"
        Me.chkDebit.UseVisualStyleBackColor = True
        '
        'chkCredit
        '
        Me.chkCredit.AutoSize = True
        Me.chkCredit.Location = New System.Drawing.Point(697, 111)
        Me.chkCredit.Name = "chkCredit"
        Me.chkCredit.Size = New System.Drawing.Size(66, 17)
        Me.chkCredit.TabIndex = 14
        Me.chkCredit.Text = "CREDIT"
        Me.chkCredit.UseVisualStyleBackColor = True
        '
        'accEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 275)
        Me.Controls.Add(Me.chkCredit)
        Me.Controls.Add(Me.chkDebit)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgwAcc)
        Me.Controls.Add(Me.dgwType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "accEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "accEntry"
        CType(Me.dgwAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgwAcc As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgwType As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDebit As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents chkDebit As System.Windows.Forms.CheckBox
    Friend WithEvents chkCredit As System.Windows.Forms.CheckBox
End Class

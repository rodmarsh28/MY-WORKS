<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageAccounts
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
        Me.dgwType = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwAcc = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgwType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwType
        '
        Me.dgwType.AllowUserToAddRows = False
        Me.dgwType.AllowUserToDeleteRows = False
        Me.dgwType.AllowUserToResizeRows = False
        Me.dgwType.BackgroundColor = System.Drawing.Color.White
        Me.dgwType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgwType.Location = New System.Drawing.Point(18, 76)
        Me.dgwType.Name = "dgwType"
        Me.dgwType.ReadOnly = True
        Me.dgwType.RowHeadersVisible = False
        Me.dgwType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwType.Size = New System.Drawing.Size(286, 183)
        Me.dgwType.TabIndex = 0
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
        'dgwAcc
        '
        Me.dgwAcc.AllowUserToAddRows = False
        Me.dgwAcc.AllowUserToDeleteRows = False
        Me.dgwAcc.AllowUserToResizeRows = False
        Me.dgwAcc.BackgroundColor = System.Drawing.Color.White
        Me.dgwAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAcc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgwAcc.Location = New System.Drawing.Point(350, 76)
        Me.dgwAcc.Name = "dgwAcc"
        Me.dgwAcc.ReadOnly = True
        Me.dgwAcc.RowHeadersVisible = False
        Me.dgwAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwAcc.Size = New System.Drawing.Size(368, 183)
        Me.dgwAcc.TabIndex = 1
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmManageAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 288)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgwAcc)
        Me.Controls.Add(Me.dgwType)
        Me.Name = "frmManageAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmManageAccounts"
        CType(Me.dgwType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwAcc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgwType As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgwAcc As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

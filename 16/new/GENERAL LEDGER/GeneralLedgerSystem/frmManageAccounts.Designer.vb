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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgwType = New System.Windows.Forms.DataGridView()
        Me.dgwAcc = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.textSearch = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgwCategories = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgwType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwType
        '
        Me.dgwType.AllowUserToAddRows = False
        Me.dgwType.AllowUserToDeleteRows = False
        Me.dgwType.AllowUserToResizeRows = False
        Me.dgwType.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwType.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgwType.EnableHeadersVisualStyles = False
        Me.dgwType.Location = New System.Drawing.Point(18, 76)
        Me.dgwType.Name = "dgwType"
        Me.dgwType.ReadOnly = True
        Me.dgwType.RowHeadersVisible = False
        Me.dgwType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwType.Size = New System.Drawing.Size(275, 183)
        Me.dgwType.TabIndex = 0
        '
        'dgwAcc
        '
        Me.dgwAcc.AllowUserToAddRows = False
        Me.dgwAcc.AllowUserToDeleteRows = False
        Me.dgwAcc.AllowUserToResizeRows = False
        Me.dgwAcc.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwAcc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgwAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAcc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgwAcc.EnableHeadersVisualStyles = False
        Me.dgwAcc.Location = New System.Drawing.Point(679, 76)
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
        Me.Button2.Location = New System.Drawing.Point(679, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'textSearch
        '
        Me.textSearch.Location = New System.Drawing.Point(807, 47)
        Me.textSearch.Name = "textSearch"
        Me.textSearch.Size = New System.Drawing.Size(240, 20)
        Me.textSearch.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(297, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 27)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "ADD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgwCategories
        '
        Me.dgwCategories.AllowUserToAddRows = False
        Me.dgwCategories.AllowUserToDeleteRows = False
        Me.dgwCategories.AllowUserToResizeRows = False
        Me.dgwCategories.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwCategories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgwCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgwCategories.EnableHeadersVisualStyles = False
        Me.dgwCategories.Location = New System.Drawing.Point(297, 76)
        Me.dgwCategories.Name = "dgwCategories"
        Me.dgwCategories.ReadOnly = True
        Me.dgwCategories.RowHeadersVisible = False
        Me.dgwCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwCategories.Size = New System.Drawing.Size(345, 183)
        Me.dgwCategories.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "ACCOUNT TYPE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 220
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CODE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ACCOUNT CATEGORIES"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 290
        '
        'frmManageAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 288)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgwCategories)
        Me.Controls.Add(Me.textSearch)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgwAcc)
        Me.Controls.Add(Me.dgwType)
        Me.Name = "frmManageAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmManageAccounts"
        CType(Me.dgwType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgwType As System.Windows.Forms.DataGridView
    Friend WithEvents dgwAcc As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents textSearch As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgwCategories As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

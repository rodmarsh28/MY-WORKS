<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventorySystem
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblItemcount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATERIALWITHDRAWALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GENERATEPURCHASEREQUESTSLIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDITEMMANUALLYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWPENDINGREQUESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENDINGREQUESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONHISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLMWSREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLMISREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLPRSREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLPOREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLMWSREPORTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgw)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1093, 475)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.BackgroundColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.dgw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.LightGray
        Me.dgw.Location = New System.Drawing.Point(3, 20)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgw.RowHeadersVisible = False
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(1087, 452)
        Me.dgw.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblItemcount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 603)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1105, 30)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(195, 25)
        Me.ToolStripStatusLabel1.Text = "Total of Item Count/'s :"
        '
        'lblItemcount
        '
        Me.lblItemcount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemcount.ForeColor = System.Drawing.Color.White
        Me.lblItemcount.Name = "lblItemcount"
        Me.lblItemcount.Size = New System.Drawing.Size(22, 25)
        Me.lblItemcount.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.TRANSACTIONSToolStripMenuItem, Me.VIEWPENDINGREQUESTToolStripMenuItem, Me.REPORTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1105, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MATERIALWITHDRAWALToolStripMenuItem, Me.GENERATEPURCHASEREQUESTSLIPToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'MATERIALWITHDRAWALToolStripMenuItem
        '
        Me.MATERIALWITHDRAWALToolStripMenuItem.Name = "MATERIALWITHDRAWALToolStripMenuItem"
        Me.MATERIALWITHDRAWALToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.MATERIALWITHDRAWALToolStripMenuItem.Text = "ADD REQUEST OF DEPARTMENT"
        '
        'GENERATEPURCHASEREQUESTSLIPToolStripMenuItem
        '
        Me.GENERATEPURCHASEREQUESTSLIPToolStripMenuItem.Name = "GENERATEPURCHASEREQUESTSLIPToolStripMenuItem"
        Me.GENERATEPURCHASEREQUESTSLIPToolStripMenuItem.Size = New System.Drawing.Size(316, 24)
        Me.GENERATEPURCHASEREQUESTSLIPToolStripMenuItem.Text = "CREATE PURCHASE REQUEST SLIP"
        '
        'TRANSACTIONSToolStripMenuItem
        '
        Me.TRANSACTIONSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDITEMMANUALLYToolStripMenuItem})
        Me.TRANSACTIONSToolStripMenuItem.Name = "TRANSACTIONSToolStripMenuItem"
        Me.TRANSACTIONSToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.TRANSACTIONSToolStripMenuItem.Text = "STOCKS TRANSACTION'S"
        '
        'ADDITEMMANUALLYToolStripMenuItem
        '
        Me.ADDITEMMANUALLYToolStripMenuItem.Name = "ADDITEMMANUALLYToolStripMenuItem"
        Me.ADDITEMMANUALLYToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ADDITEMMANUALLYToolStripMenuItem.Text = "ADD ITEM MANUALLY"
        '
        'VIEWPENDINGREQUESTToolStripMenuItem
        '
        Me.VIEWPENDINGREQUESTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENDINGREQUESTToolStripMenuItem, Me.TRANSACTIONHISTORYToolStripMenuItem})
        Me.VIEWPENDINGREQUESTToolStripMenuItem.Name = "VIEWPENDINGREQUESTToolStripMenuItem"
        Me.VIEWPENDINGREQUESTToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.VIEWPENDINGREQUESTToolStripMenuItem.Text = "VIEW"
        '
        'PENDINGREQUESTToolStripMenuItem
        '
        Me.PENDINGREQUESTToolStripMenuItem.Name = "PENDINGREQUESTToolStripMenuItem"
        Me.PENDINGREQUESTToolStripMenuItem.Size = New System.Drawing.Size(328, 24)
        Me.PENDINGREQUESTToolStripMenuItem.Text = "MWS / MIS TRANSACTION VIEWER"
        '
        'TRANSACTIONHISTORYToolStripMenuItem
        '
        Me.TRANSACTIONHISTORYToolStripMenuItem.Name = "TRANSACTIONHISTORYToolStripMenuItem"
        Me.TRANSACTIONHISTORYToolStripMenuItem.Size = New System.Drawing.Size(328, 24)
        Me.TRANSACTIONHISTORYToolStripMenuItem.Text = "PRS / PO TRANSACTION VIEWER"
        '
        'REPORTToolStripMenuItem
        '
        Me.REPORTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALLMWSREPORTToolStripMenuItem, Me.ALLMISREPORTToolStripMenuItem, Me.ALLPRSREPORTToolStripMenuItem, Me.ALLPOREPORTToolStripMenuItem, Me.ALLMWSREPORTToolStripMenuItem1, Me.PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem})
        Me.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem"
        Me.REPORTToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.REPORTToolStripMenuItem.Text = "REPORT"
        '
        'ALLMWSREPORTToolStripMenuItem
        '
        Me.ALLMWSREPORTToolStripMenuItem.Name = "ALLMWSREPORTToolStripMenuItem"
        Me.ALLMWSREPORTToolStripMenuItem.Size = New System.Drawing.Size(346, 24)
        Me.ALLMWSREPORTToolStripMenuItem.Text = "ALL MWS REPORT"
        '
        'ALLMISREPORTToolStripMenuItem
        '
        Me.ALLMISREPORTToolStripMenuItem.Name = "ALLMISREPORTToolStripMenuItem"
        Me.ALLMISREPORTToolStripMenuItem.Size = New System.Drawing.Size(346, 24)
        Me.ALLMISREPORTToolStripMenuItem.Text = "ALL MIS REPORT"
        '
        'ALLPRSREPORTToolStripMenuItem
        '
        Me.ALLPRSREPORTToolStripMenuItem.Name = "ALLPRSREPORTToolStripMenuItem"
        Me.ALLPRSREPORTToolStripMenuItem.Size = New System.Drawing.Size(346, 24)
        Me.ALLPRSREPORTToolStripMenuItem.Text = "ALL PRS REPORT"
        '
        'ALLPOREPORTToolStripMenuItem
        '
        Me.ALLPOREPORTToolStripMenuItem.Name = "ALLPOREPORTToolStripMenuItem"
        Me.ALLPOREPORTToolStripMenuItem.Size = New System.Drawing.Size(346, 24)
        Me.ALLPOREPORTToolStripMenuItem.Text = "ALL PO REPORT"
        '
        'ALLMWSREPORTToolStripMenuItem1
        '
        Me.ALLMWSREPORTToolStripMenuItem1.Name = "ALLMWSREPORTToolStripMenuItem1"
        Me.ALLMWSREPORTToolStripMenuItem1.Size = New System.Drawing.Size(346, 24)
        Me.ALLMWSREPORTToolStripMenuItem1.Text = "ALL MRS REPORT"
        '
        'PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem
        '
        Me.PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem.Name = "PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem"
        Me.PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem.Size = New System.Drawing.Size(357, 24)
        Me.PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem.Text = "ITEM / MATERIAL PURCHASED REPORT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 100)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory System"
        '
        'Column1
        '
        Me.Column1.HeaderText = "INVENTORY CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "ITEM DESCRIPTION"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 350
        '
        'Column5
        '
        Me.Column5.HeaderText = "SERIAL/BRAND/MODEL/TYPE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "UNIT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 170
        '
        'Column4
        '
        Me.Column4.HeaderText = "STOCKS ONHAND"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 130
        '
        'frmInventorySystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1105, 633)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmInventorySystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory System"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATERIALWITHDRAWALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GENERATEPURCHASEREQUESTSLIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSACTIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWPENDINGREQUESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENDINGREQUESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSACTIONHISTORYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDITEMMANUALLYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblItemcount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents REPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLMWSREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLMISREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLPRSREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLPOREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLMWSREPORTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

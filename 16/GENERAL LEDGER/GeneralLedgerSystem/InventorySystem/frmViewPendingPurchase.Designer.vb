<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewPendingPurchase
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbShowby = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREATEPOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CANCELPURCHASEREQUESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VIEWToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CASHCHECKISSUEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITPOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VIEWPOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECEIVEANDADDMRSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbShowby
        '
        Me.cmbShowby.BackColor = System.Drawing.Color.White
        Me.cmbShowby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShowby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbShowby.FormattingEnabled = True
        Me.cmbShowby.Items.AddRange(New Object() {"", "PENDING PURCHASE REQUEST", "WAITING FOR CASH/CHECK ISSUANCE", "WAITING FOR RECEIVING ITEMS / MATERIALS"})
        Me.cmbShowby.Location = New System.Drawing.Point(14, 102)
        Me.cmbShowby.Name = "cmbShowby"
        Me.cmbShowby.Size = New System.Drawing.Size(258, 21)
        Me.cmbShowby.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(356, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "SEARCH"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(413, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 56
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dgw)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 269)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column5, Me.Column2, Me.Column3, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.LightGray
        Me.dgw.Location = New System.Drawing.Point(3, 16)
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersVisible = False
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(561, 250)
        Me.dgw.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "DATE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "PRS NO."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "PREPARED BY"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "STATUS"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "SUPPLIER NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "ADDRESS"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWToolStripMenuItem, Me.CREATEPOToolStripMenuItem, Me.CANCELPURCHASEREQUESTToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(234, 70)
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.VIEWToolStripMenuItem.Text = "VIEW PRS"
        '
        'CREATEPOToolStripMenuItem
        '
        Me.CREATEPOToolStripMenuItem.Name = "CREATEPOToolStripMenuItem"
        Me.CREATEPOToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.CREATEPOToolStripMenuItem.Text = "CREATE P.O."
        '
        'CANCELPURCHASEREQUESTToolStripMenuItem
        '
        Me.CANCELPURCHASEREQUESTToolStripMenuItem.Name = "CANCELPURCHASEREQUESTToolStripMenuItem"
        Me.CANCELPURCHASEREQUESTToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.CANCELPURCHASEREQUESTToolStripMenuItem.Text = "CANCEL PURCHASE REQUEST"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWToolStripMenuItem1, Me.CASHCHECKISSUEDToolStripMenuItem, Me.EDITPOToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(195, 70)
        '
        'VIEWToolStripMenuItem1
        '
        Me.VIEWToolStripMenuItem1.Name = "VIEWToolStripMenuItem1"
        Me.VIEWToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.VIEWToolStripMenuItem1.Text = "VIEW P.O."
        '
        'CASHCHECKISSUEDToolStripMenuItem
        '
        Me.CASHCHECKISSUEDToolStripMenuItem.Name = "CASHCHECKISSUEDToolStripMenuItem"
        Me.CASHCHECKISSUEDToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CASHCHECKISSUEDToolStripMenuItem.Text = "CASH / CHECK ISSUED"
        '
        'EDITPOToolStripMenuItem
        '
        Me.EDITPOToolStripMenuItem.Name = "EDITPOToolStripMenuItem"
        Me.EDITPOToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.EDITPOToolStripMenuItem.Text = "EDIT P.O."
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWPOToolStripMenuItem, Me.RECEIVEANDADDMRSToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(200, 48)
        '
        'VIEWPOToolStripMenuItem
        '
        Me.VIEWPOToolStripMenuItem.Name = "VIEWPOToolStripMenuItem"
        Me.VIEWPOToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.VIEWPOToolStripMenuItem.Text = "VIEW P.O."
        '
        'RECEIVEANDADDMRSToolStripMenuItem
        '
        Me.RECEIVEANDADDMRSToolStripMenuItem.Name = "RECEIVEANDADDMRSToolStripMenuItem"
        Me.RECEIVEANDADDMRSToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RECEIVEANDADDMRSToolStripMenuItem.Text = "RECEIVE AND ADD MRS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmbShowby)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 422)
        Me.Panel1.TabIndex = 64
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(570, 140)
        Me.Panel2.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(130, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 22)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "PURCHASE ORDER  PENDING VIEWER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(175, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 22)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "PURCHASE REQUEST AND"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 410)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(587, 22)
        Me.StatusStrip1.TabIndex = 65
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(135, 17)
        Me.ToolStripStatusLabel1.Text = "TOTAL ITEM COUNT/'S :"
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(14, 17)
        Me.lblCount.Text = "0"
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(61, 4)
        '
        'frmViewPendingPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(587, 432)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewPendingPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbShowby As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CREATEPOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VIEWToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VIEWPOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RECEIVEANDADDMRSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CASHCHECKISSUEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip4 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CANCELPURCHASEREQUESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITPOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

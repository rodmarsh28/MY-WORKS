<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWMASTERLISTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOngoingDesciplinaryActionPunishedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOngoingLeavEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllPayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPremiumsSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.lblDate, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.lblTime, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel7, Me.lblUsername})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 404)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1055, 24)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(41, 19)
        Me.ToolStripStatusLabel3.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(83, 19)
        Me.lblDate.Text = "00/00/0000"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 19)
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(41, 19)
        Me.ToolStripStatusLabel6.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(44, 19)
        Me.lblTime.Text = "00:00"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 19)
        Me.ToolStripStatusLabel1.Text = "           "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(40, 19)
        Me.ToolStripStatusLabel7.Text = "User:"
        '
        'lblUsername
        '
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(68, 19)
        Me.lblUsername.Text = "Unknown"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.ConfigurationToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1055, 27)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeesToolStripMenuItem, Me.BackupDatabaseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddEmployeesToolStripMenuItem
        '
        Me.AddEmployeesToolStripMenuItem.Name = "AddEmployeesToolStripMenuItem"
        Me.AddEmployeesToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.AddEmployeesToolStripMenuItem.Text = "Add Employees"
        '
        'BackupDatabaseToolStripMenuItem
        '
        Me.BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        Me.BackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.BackupDatabaseToolStripMenuItem.Text = "Backup Database"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWMASTERLISTToolStripMenuItem, Me.ViewOngoingDesciplinaryActionPunishedToolStripMenuItem, Me.ViewOngoingLeavEmployeesToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(50, 23)
        Me.TransactionToolStripMenuItem.Text = "View"
        '
        'VIEWMASTERLISTToolStripMenuItem
        '
        Me.VIEWMASTERLISTToolStripMenuItem.Name = "VIEWMASTERLISTToolStripMenuItem"
        Me.VIEWMASTERLISTToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.VIEWMASTERLISTToolStripMenuItem.Text = "Masterlist"
        '
        'ViewOngoingDesciplinaryActionPunishedToolStripMenuItem
        '
        Me.ViewOngoingDesciplinaryActionPunishedToolStripMenuItem.Name = "ViewOngoingDesciplinaryActionPunishedToolStripMenuItem"
        Me.ViewOngoingDesciplinaryActionPunishedToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.ViewOngoingDesciplinaryActionPunishedToolStripMenuItem.Text = "Ongoing Desciplinary Action"
        '
        'ViewOngoingLeavEmployeesToolStripMenuItem
        '
        Me.ViewOngoingLeavEmployeesToolStripMenuItem.Name = "ViewOngoingLeavEmployeesToolStripMenuItem"
        Me.ViewOngoingLeavEmployeesToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.ViewOngoingLeavEmployeesToolStripMenuItem.Text = "Ongoing Leave Employees"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPayrollToolStripMenuItem, Me.ViewAllPayrollToolStripMenuItem, Me.PrintPremiumsSummaryToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'AddPayrollToolStripMenuItem
        '
        Me.AddPayrollToolStripMenuItem.Name = "AddPayrollToolStripMenuItem"
        Me.AddPayrollToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.AddPayrollToolStripMenuItem.Text = "Add Payroll"
        '
        'ViewAllPayrollToolStripMenuItem
        '
        Me.ViewAllPayrollToolStripMenuItem.Name = "ViewAllPayrollToolStripMenuItem"
        Me.ViewAllPayrollToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.ViewAllPayrollToolStripMenuItem.Text = "All Payroll History"
        '
        'PrintPremiumsSummaryToolStripMenuItem
        '
        Me.PrintPremiumsSummaryToolStripMenuItem.Name = "PrintPremiumsSummaryToolStripMenuItem"
        Me.PrintPremiumsSummaryToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.PrintPremiumsSummaryToolStripMenuItem.Text = "Print Premiums Summary"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(105, 23)
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 428)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DFC PACKING SOLUTIONS EMPLOYEES MASTER LIST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWMASTERLISTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOngoingDesciplinaryActionPunishedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOngoingLeavEmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllPayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PrintPremiumsSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

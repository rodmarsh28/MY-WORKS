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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewExpensesHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PreviewExpensePerCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewExpensePerUnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1089, 27)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddVehicleToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddVehicleToolStripMenuItem
        '
        Me.AddVehicleToolStripMenuItem.Name = "AddVehicleToolStripMenuItem"
        Me.AddVehicleToolStripMenuItem.Size = New System.Drawing.Size(149, 24)
        Me.AddVehicleToolStripMenuItem.Text = "Add Vehicle"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewVehicleToolStripMenuItem, Me.ViewExpensesHistoryToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(90, 23)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'ViewVehicleToolStripMenuItem
        '
        Me.ViewVehicleToolStripMenuItem.Name = "ViewVehicleToolStripMenuItem"
        Me.ViewVehicleToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.ViewVehicleToolStripMenuItem.Text = "View Vehicle Masterlist"
        '
        'ViewExpensesHistoryToolStripMenuItem
        '
        Me.ViewExpensesHistoryToolStripMenuItem.Name = "ViewExpensesHistoryToolStripMenuItem"
        Me.ViewExpensesHistoryToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.ViewExpensesHistoryToolStripMenuItem.Text = "View Expenses History"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreviewExpensePerCategoryToolStripMenuItem, Me.PreviewExpensePerUnitToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 561)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1089, 24)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(47, 19)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'PreviewExpensePerCategoryToolStripMenuItem
        '
        Me.PreviewExpensePerCategoryToolStripMenuItem.Name = "PreviewExpensePerCategoryToolStripMenuItem"
        Me.PreviewExpensePerCategoryToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.PreviewExpensePerCategoryToolStripMenuItem.Text = "Preview Expense per Category"
        '
        'PreviewExpensePerUnitToolStripMenuItem
        '
        Me.PreviewExpensePerUnitToolStripMenuItem.Name = "PreviewExpensePerUnitToolStripMenuItem"
        Me.PreviewExpensePerUnitToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.PreviewExpensePerUnitToolStripMenuItem.Text = "Preview Expense per Unit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 585)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddVehicleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewVehicleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewExpensesHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewExpensePerCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewExpensePerUnitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

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
        Me.tileAccountingSystem = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'tileAccountingSystem
        '
        Me.tileAccountingSystem.ActiveControl = Nothing
        Me.tileAccountingSystem.Location = New System.Drawing.Point(241, 128)
        Me.tileAccountingSystem.Name = "tileAccountingSystem"
        Me.tileAccountingSystem.Size = New System.Drawing.Size(358, 204)
        Me.tileAccountingSystem.Style = MetroFramework.MetroColorStyle.Blue
        Me.tileAccountingSystem.TabIndex = 0
        Me.tileAccountingSystem.Text = "Accounting System"
        Me.tileAccountingSystem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.tileAccountingSystem.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(605, 128)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(341, 204)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroTile2.TabIndex = 1
        Me.MetroTile2.Text = "Inventory System"
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile2.UseSelectable = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(952, 128)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(282, 204)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTile1.TabIndex = 2
        Me.MetroTile1.Text = "Payroll System"
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(373, 91)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(101, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "System Lists"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 640)
        Me.Panel1.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.tileAccountingSystem)
        Me.Name = "frmMain"
        Me.Text = "General Ledger Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tileAccountingSystem As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class

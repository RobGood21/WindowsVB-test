<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Wisselmotor
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpeningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnderhoudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductgroepenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MerkenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.OnderhoudToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpeningToolStripMenuItem, Me.ProductenToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripMenuItem1.Text = "Forms"
        '
        'OpeningToolStripMenuItem
        '
        Me.OpeningToolStripMenuItem.Name = "OpeningToolStripMenuItem"
        Me.OpeningToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.OpeningToolStripMenuItem.Text = "Opening"
        '
        'ProductenToolStripMenuItem
        '
        Me.ProductenToolStripMenuItem.Name = "ProductenToolStripMenuItem"
        Me.ProductenToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ProductenToolStripMenuItem.Text = "Producten"
        '
        'OnderhoudToolStripMenuItem
        '
        Me.OnderhoudToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductgroepenToolStripMenuItem, Me.MerkenToolStripMenuItem})
        Me.OnderhoudToolStripMenuItem.Name = "OnderhoudToolStripMenuItem"
        Me.OnderhoudToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.OnderhoudToolStripMenuItem.Text = "Onderhoud"
        '
        'ProductgroepenToolStripMenuItem
        '
        Me.ProductgroepenToolStripMenuItem.Name = "ProductgroepenToolStripMenuItem"
        Me.ProductgroepenToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ProductgroepenToolStripMenuItem.Text = "Productgroepen"
        '
        'MerkenToolStripMenuItem
        '
        Me.MerkenToolStripMenuItem.Name = "MerkenToolStripMenuItem"
        Me.MerkenToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MerkenToolStripMenuItem.Text = "Merken"
        '
        'F_Wisselmotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "F_Wisselmotor"
        Me.Text = "Wisselmotor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpeningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnderhoudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductgroepenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MerkenToolStripMenuItem As ToolStripMenuItem
End Class

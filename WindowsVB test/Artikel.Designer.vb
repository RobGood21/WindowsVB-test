<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Artikel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Artikel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LijstP = New System.Windows.Forms.ListBox()
        Me.KnopTest1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LijstP
        '
        Me.LijstP.FormattingEnabled = True
        resources.ApplyResources(Me.LijstP, "LijstP")
        Me.LijstP.Name = "LijstP"
        '
        'KnopTest1
        '
        resources.ApplyResources(Me.KnopTest1, "KnopTest1")
        Me.KnopTest1.Name = "KnopTest1"
        Me.KnopTest1.UseVisualStyleBackColor = True
        '
        'Artikel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KnopTest1)
        Me.Controls.Add(Me.LijstP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Artikel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LijstP As ListBox
    Friend WithEvents KnopTest1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Opening
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Knop_afsluiten = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Knop_afsluiten
        '
        Me.Knop_afsluiten.Location = New System.Drawing.Point(542, 403)
        Me.Knop_afsluiten.Name = "Knop_afsluiten"
        Me.Knop_afsluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_afsluiten.TabIndex = 0
        Me.Knop_afsluiten.Text = "Afsluiten"
        Me.Knop_afsluiten.UseVisualStyleBackColor = True
        '
        'F_Opening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 457)
        Me.Controls.Add(Me.Knop_afsluiten)
        Me.Name = "F_Opening"
        Me.Text = "Opening Wisselmotor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Knop_afsluiten As Button
End Class

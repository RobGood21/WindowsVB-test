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
        Me.Pic_Opening = New System.Windows.Forms.PictureBox()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        CType(Me.Pic_Opening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic_Opening
        '
        Me.Pic_Opening.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Wisselmotor_program_opening
        Me.Pic_Opening.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Opening.Location = New System.Drawing.Point(12, 12)
        Me.Pic_Opening.Name = "Pic_Opening"
        Me.Pic_Opening.Size = New System.Drawing.Size(736, 235)
        Me.Pic_Opening.TabIndex = 0
        Me.Pic_Opening.TabStop = False
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(12, 253)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Sluiten.TabIndex = 1
        Me.Knop_Sluiten.Text = "Afsluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'F_Opening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 669)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Controls.Add(Me.Pic_Opening)
        Me.Name = "F_Opening"
        Me.Text = "Opening Wisselmotor"
        CType(Me.Pic_Opening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pic_Opening As PictureBox
    Friend WithEvents Knop_Sluiten As Button
End Class

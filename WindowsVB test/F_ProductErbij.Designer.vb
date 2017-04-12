<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ProductErbij
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
        Me.GB_TypeOntvangst = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Hoeontvangen = New System.Windows.Forms.ComboBox()
        Me.GB_Crediteur = New System.Windows.Forms.GroupBox()
        Me.CB_Leverancier = New System.Windows.Forms.ComboBox()
        Me.LBL_Leverancier = New System.Windows.Forms.Label()
        Me.Knop_DetailsLeverancier = New System.Windows.Forms.Button()
        Me.Knop_ShopDetails = New System.Windows.Forms.Button()
        Me.LBL_Shop = New System.Windows.Forms.Label()
        Me.CB_Shop = New System.Windows.Forms.ComboBox()
        Me.GB_TypeOntvangst.SuspendLayout()
        Me.GB_Crediteur.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_TypeOntvangst
        '
        Me.GB_TypeOntvangst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_TypeOntvangst.Controls.Add(Me.Label1)
        Me.GB_TypeOntvangst.Controls.Add(Me.CB_Hoeontvangen)
        Me.GB_TypeOntvangst.Location = New System.Drawing.Point(12, 12)
        Me.GB_TypeOntvangst.Name = "GB_TypeOntvangst"
        Me.GB_TypeOntvangst.Size = New System.Drawing.Size(933, 100)
        Me.GB_TypeOntvangst.TabIndex = 0
        Me.GB_TypeOntvangst.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hoe ontvangen:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'CB_Hoeontvangen
        '
        Me.CB_Hoeontvangen.FormattingEnabled = True
        Me.CB_Hoeontvangen.Items.AddRange(New Object() {"Correctie voorraad", "Aankoop contant", "Aankoop op factuur"})
        Me.CB_Hoeontvangen.Location = New System.Drawing.Point(97, 19)
        Me.CB_Hoeontvangen.Name = "CB_Hoeontvangen"
        Me.CB_Hoeontvangen.Size = New System.Drawing.Size(184, 21)
        Me.CB_Hoeontvangen.TabIndex = 0
        '
        'GB_Crediteur
        '
        Me.GB_Crediteur.Controls.Add(Me.Knop_ShopDetails)
        Me.GB_Crediteur.Controls.Add(Me.LBL_Shop)
        Me.GB_Crediteur.Controls.Add(Me.CB_Shop)
        Me.GB_Crediteur.Controls.Add(Me.Knop_DetailsLeverancier)
        Me.GB_Crediteur.Controls.Add(Me.LBL_Leverancier)
        Me.GB_Crediteur.Controls.Add(Me.CB_Leverancier)
        Me.GB_Crediteur.Location = New System.Drawing.Point(22, 150)
        Me.GB_Crediteur.Name = "GB_Crediteur"
        Me.GB_Crediteur.Size = New System.Drawing.Size(456, 223)
        Me.GB_Crediteur.TabIndex = 1
        Me.GB_Crediteur.TabStop = False
        Me.GB_Crediteur.Text = "Factuur gegevens"
        '
        'CB_Leverancier
        '
        Me.CB_Leverancier.FormattingEnabled = True
        Me.CB_Leverancier.Location = New System.Drawing.Point(87, 28)
        Me.CB_Leverancier.Name = "CB_Leverancier"
        Me.CB_Leverancier.Size = New System.Drawing.Size(224, 21)
        Me.CB_Leverancier.TabIndex = 0
        '
        'LBL_Leverancier
        '
        Me.LBL_Leverancier.AutoSize = True
        Me.LBL_Leverancier.Location = New System.Drawing.Point(15, 31)
        Me.LBL_Leverancier.Name = "LBL_Leverancier"
        Me.LBL_Leverancier.Size = New System.Drawing.Size(66, 13)
        Me.LBL_Leverancier.TabIndex = 2
        Me.LBL_Leverancier.Text = "Leverancier:"
        Me.LBL_Leverancier.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Knop_DetailsLeverancier
        '
        Me.Knop_DetailsLeverancier.Location = New System.Drawing.Point(328, 28)
        Me.Knop_DetailsLeverancier.Name = "Knop_DetailsLeverancier"
        Me.Knop_DetailsLeverancier.Size = New System.Drawing.Size(75, 23)
        Me.Knop_DetailsLeverancier.TabIndex = 3
        Me.Knop_DetailsLeverancier.Text = "Details"
        Me.Knop_DetailsLeverancier.UseVisualStyleBackColor = True
        '
        'Knop_ShopDetails
        '
        Me.Knop_ShopDetails.Location = New System.Drawing.Point(328, 53)
        Me.Knop_ShopDetails.Name = "Knop_ShopDetails"
        Me.Knop_ShopDetails.Size = New System.Drawing.Size(75, 23)
        Me.Knop_ShopDetails.TabIndex = 6
        Me.Knop_ShopDetails.Text = "Details"
        Me.Knop_ShopDetails.UseVisualStyleBackColor = True
        '
        'LBL_Shop
        '
        Me.LBL_Shop.AutoSize = True
        Me.LBL_Shop.Location = New System.Drawing.Point(15, 56)
        Me.LBL_Shop.Name = "LBL_Shop"
        Me.LBL_Shop.Size = New System.Drawing.Size(35, 13)
        Me.LBL_Shop.TabIndex = 5
        Me.LBL_Shop.Text = "Shop:"
        Me.LBL_Shop.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'CB_Shop
        '
        Me.CB_Shop.FormattingEnabled = True
        Me.CB_Shop.Location = New System.Drawing.Point(87, 53)
        Me.CB_Shop.Name = "CB_Shop"
        Me.CB_Shop.Size = New System.Drawing.Size(224, 21)
        Me.CB_Shop.TabIndex = 4
        '
        'F_ProductErbij
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 589)
        Me.Controls.Add(Me.GB_Crediteur)
        Me.Controls.Add(Me.GB_TypeOntvangst)
        Me.Name = "F_ProductErbij"
        Me.Text = "Producten ontvangen "
        Me.GB_TypeOntvangst.ResumeLayout(False)
        Me.GB_TypeOntvangst.PerformLayout()
        Me.GB_Crediteur.ResumeLayout(False)
        Me.GB_Crediteur.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_TypeOntvangst As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Hoeontvangen As ComboBox
    Friend WithEvents GB_Crediteur As GroupBox
    Friend WithEvents Knop_ShopDetails As Button
    Friend WithEvents LBL_Shop As Label
    Friend WithEvents CB_Shop As ComboBox
    Friend WithEvents Knop_DetailsLeverancier As Button
    Friend WithEvents LBL_Leverancier As Label
    Friend WithEvents CB_Leverancier As ComboBox
End Class

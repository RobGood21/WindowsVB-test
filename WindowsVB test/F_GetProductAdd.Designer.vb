<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_GetProductAdd
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
        Me.components = New System.ComponentModel.Container()
        Dim PD_VoorraadLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.TXT_ProductLijst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Knop_Zoek = New System.Windows.Forms.Button()
        Me.PD_VoorraadTextBox = New System.Windows.Forms.TextBox()
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.TXT_PDnaam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Product_Inkoop = New System.Windows.Forms.TextBox()
        Me.TXT_aantal = New System.Windows.Forms.TextBox()
        Me.GetProductAddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXT_GetProductAdd = New System.Windows.Forms.TextBox()
        Me.Knop_Details = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_ProductID = New System.Windows.Forms.TextBox()
        Me.GB_Prijs = New System.Windows.Forms.GroupBox()
        Me.Knop_Reset = New System.Windows.Forms.Button()
        Me.CB_valuta = New System.Windows.Forms.ComboBox()
        Me.ValutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_Koers = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_TotaalBetaaldVAL = New System.Windows.Forms.TextBox()
        Me.TXT_TotaalBetaaldEur = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_Prijs = New System.Windows.Forms.TextBox()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.GetProductAddTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductAddTableAdapter()
        Me.DT_productTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.DT_productTableAdapter()
        Me.ValutaTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ValutaTableAdapter()
        Me.TXT_IDONTV = New System.Windows.Forms.TextBox()
        Me.Knop_Verwijder = New System.Windows.Forms.Button()
        PD_VoorraadLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Prijs.SuspendLayout()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PD_VoorraadLabel
        '
        PD_VoorraadLabel.AutoSize = True
        PD_VoorraadLabel.Location = New System.Drawing.Point(20, 102)
        PD_VoorraadLabel.Name = "PD_VoorraadLabel"
        PD_VoorraadLabel.Size = New System.Drawing.Size(53, 13)
        PD_VoorraadLabel.TabIndex = 15
        PD_VoorraadLabel.Text = "Voorraad:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(181, 98)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(61, 13)
        Label10.TabIndex = 16
        Label10.Text = "Inkoopprijs:"
        '
        'TXT_ProductLijst
        '
        Me.TXT_ProductLijst.Location = New System.Drawing.Point(81, 19)
        Me.TXT_ProductLijst.Name = "TXT_ProductLijst"
        Me.TXT_ProductLijst.Size = New System.Drawing.Size(247, 20)
        Me.TXT_ProductLijst.TabIndex = 0
        Me.TXT_ProductLijst.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Productlijst:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Me.Knop_Zoek)
        Me.GroupBox1.Controls.Add(PD_VoorraadLabel)
        Me.GroupBox1.Controls.Add(Me.PD_VoorraadTextBox)
        Me.GroupBox1.Controls.Add(Me.TXT_PDnaam)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_Product_Inkoop)
        Me.GroupBox1.Controls.Add(Me.TXT_aantal)
        Me.GroupBox1.Controls.Add(Me.Knop_Details)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_ProductID)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 151)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aan de productlijst toe te voegen producten"
        '
        'Knop_Zoek
        '
        Me.Knop_Zoek.Location = New System.Drawing.Point(144, 25)
        Me.Knop_Zoek.Name = "Knop_Zoek"
        Me.Knop_Zoek.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Zoek.TabIndex = 1
        Me.Knop_Zoek.Text = "Zoek"
        Me.Knop_Zoek.UseVisualStyleBackColor = True
        '
        'PD_VoorraadTextBox
        '
        Me.PD_VoorraadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PD_VoorraadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.PD_VoorraadTextBox.Location = New System.Drawing.Point(77, 98)
        Me.PD_VoorraadTextBox.Name = "PD_VoorraadTextBox"
        Me.PD_VoorraadTextBox.ReadOnly = True
        Me.PD_VoorraadTextBox.Size = New System.Drawing.Size(63, 20)
        Me.PD_VoorraadTextBox.TabIndex = 16
        Me.PD_VoorraadTextBox.TabStop = False
        '
        'DT_productBindingSource
        '
        Me.DT_productBindingSource.DataMember = "DT_product"
        Me.DT_productBindingSource.DataSource = Me.DS_Product
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXT_PDnaam
        '
        Me.TXT_PDnaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PDnaam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Beschrijving(2)", True))
        Me.TXT_PDnaam.Location = New System.Drawing.Point(77, 55)
        Me.TXT_PDnaam.Multiline = True
        Me.TXT_PDnaam.Name = "TXT_PDnaam"
        Me.TXT_PDnaam.ReadOnly = True
        Me.TXT_PDnaam.Size = New System.Drawing.Size(219, 37)
        Me.TXT_PDnaam.TabIndex = 12
        Me.TXT_PDnaam.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Aantal:"
        '
        'TXT_Product_Inkoop
        '
        Me.TXT_Product_Inkoop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_Product_Inkoop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Buy_Cost", True))
        Me.TXT_Product_Inkoop.Location = New System.Drawing.Point(245, 95)
        Me.TXT_Product_Inkoop.Name = "TXT_Product_Inkoop"
        Me.TXT_Product_Inkoop.ReadOnly = True
        Me.TXT_Product_Inkoop.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Product_Inkoop.TabIndex = 13
        Me.TXT_Product_Inkoop.TabStop = False
        Me.TXT_Product_Inkoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_aantal
        '
        Me.TXT_aantal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "GP_Lijst", True))
        Me.TXT_aantal.Location = New System.Drawing.Point(77, 120)
        Me.TXT_aantal.Name = "TXT_aantal"
        Me.TXT_aantal.Size = New System.Drawing.Size(63, 20)
        Me.TXT_aantal.TabIndex = 1
        '
        'GetProductAddBindingSource
        '
        Me.GetProductAddBindingSource.DataMember = "GetProductAdd"
        Me.GetProductAddBindingSource.DataSource = Me.DS_Product
        '
        'TXT_GetProductAdd
        '
        Me.TXT_GetProductAdd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "ID_GetProductAdd", True))
        Me.TXT_GetProductAdd.Enabled = False
        Me.TXT_GetProductAdd.Location = New System.Drawing.Point(258, 88)
        Me.TXT_GetProductAdd.Name = "TXT_GetProductAdd"
        Me.TXT_GetProductAdd.ReadOnly = True
        Me.TXT_GetProductAdd.Size = New System.Drawing.Size(38, 20)
        Me.TXT_GetProductAdd.TabIndex = 11
        Me.TXT_GetProductAdd.TabStop = False
        '
        'Knop_Details
        '
        Me.Knop_Details.Location = New System.Drawing.Point(221, 25)
        Me.Knop_Details.Name = "Knop_Details"
        Me.Knop_Details.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Details.TabIndex = 6
        Me.Knop_Details.TabStop = False
        Me.Knop_Details.Text = "Details"
        Me.Knop_Details.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product:"
        '
        'TXT_ProductID
        '
        Me.TXT_ProductID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "ID_Product", True))
        Me.TXT_ProductID.Location = New System.Drawing.Point(77, 26)
        Me.TXT_ProductID.Name = "TXT_ProductID"
        Me.TXT_ProductID.ReadOnly = True
        Me.TXT_ProductID.Size = New System.Drawing.Size(63, 20)
        Me.TXT_ProductID.TabIndex = 2
        Me.TXT_ProductID.TabStop = False
        '
        'GB_Prijs
        '
        Me.GB_Prijs.Controls.Add(Me.Knop_Reset)
        Me.GB_Prijs.Controls.Add(Me.TXT_IDONTV)
        Me.GB_Prijs.Controls.Add(Me.CB_valuta)
        Me.GB_Prijs.Controls.Add(Me.Label9)
        Me.GB_Prijs.Controls.Add(Me.TXT_Koers)
        Me.GB_Prijs.Controls.Add(Me.Label2)
        Me.GB_Prijs.Controls.Add(Me.TXT_TotaalBetaaldVAL)
        Me.GB_Prijs.Controls.Add(Me.TXT_TotaalBetaaldEur)
        Me.GB_Prijs.Controls.Add(Me.TXT_GetProductAdd)
        Me.GB_Prijs.Controls.Add(Me.Label5)
        Me.GB_Prijs.Controls.Add(Me.Label7)
        Me.GB_Prijs.Controls.Add(Me.Label6)
        Me.GB_Prijs.Controls.Add(Me.TXT_Prijs)
        Me.GB_Prijs.Location = New System.Drawing.Point(19, 225)
        Me.GB_Prijs.Name = "GB_Prijs"
        Me.GB_Prijs.Size = New System.Drawing.Size(309, 116)
        Me.GB_Prijs.TabIndex = 3
        Me.GB_Prijs.TabStop = False
        Me.GB_Prijs.Text = "Bereken stuks inkoopprijs"
        '
        'Knop_Reset
        '
        Me.Knop_Reset.Location = New System.Drawing.Point(231, 49)
        Me.Knop_Reset.Name = "Knop_Reset"
        Me.Knop_Reset.Size = New System.Drawing.Size(65, 23)
        Me.Knop_Reset.TabIndex = 26
        Me.Knop_Reset.TabStop = False
        Me.Knop_Reset.Text = "Reset "
        Me.Knop_Reset.UseVisualStyleBackColor = True
        '
        'CB_valuta
        '
        Me.CB_valuta.DataSource = Me.ValutaBindingSource
        Me.CB_valuta.DisplayMember = "VT_Short"
        Me.CB_valuta.FormattingEnabled = True
        Me.CB_valuta.Location = New System.Drawing.Point(77, 22)
        Me.CB_valuta.Name = "CB_valuta"
        Me.CB_valuta.Size = New System.Drawing.Size(66, 21)
        Me.CB_valuta.TabIndex = 25
        Me.CB_valuta.TabStop = False
        Me.CB_valuta.ValueMember = "ID_valuta"
        '
        'ValutaBindingSource
        '
        Me.ValutaBindingSource.DataMember = "Valuta"
        Me.ValutaBindingSource.DataSource = Me.DS_Product
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(191, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Koers:"
        '
        'TXT_Koers
        '
        Me.TXT_Koers.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ValutaBindingSource, "VT_Koers", True))
        Me.TXT_Koers.Location = New System.Drawing.Point(231, 22)
        Me.TXT_Koers.Name = "TXT_Koers"
        Me.TXT_Koers.ReadOnly = True
        Me.TXT_Koers.Size = New System.Drawing.Size(65, 20)
        Me.TXT_Koers.TabIndex = 23
        Me.TXT_Koers.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "In Euro:"
        '
        'TXT_TotaalBetaaldVAL
        '
        Me.TXT_TotaalBetaaldVAL.Location = New System.Drawing.Point(77, 45)
        Me.TXT_TotaalBetaaldVAL.Name = "TXT_TotaalBetaaldVAL"
        Me.TXT_TotaalBetaaldVAL.Size = New System.Drawing.Size(40, 20)
        Me.TXT_TotaalBetaaldVAL.TabIndex = 2
        Me.TXT_TotaalBetaaldVAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_TotaalBetaaldEur
        '
        Me.TXT_TotaalBetaaldEur.Location = New System.Drawing.Point(77, 67)
        Me.TXT_TotaalBetaaldEur.Name = "TXT_TotaalBetaaldEur"
        Me.TXT_TotaalBetaaldEur.ReadOnly = True
        Me.TXT_TotaalBetaaldEur.Size = New System.Drawing.Size(40, 20)
        Me.TXT_TotaalBetaaldEur.TabIndex = 21
        Me.TXT_TotaalBetaaldEur.TabStop = False
        Me.TXT_TotaalBetaaldEur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Betaald:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Per stuk:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Valuta:"
        '
        'TXT_Prijs
        '
        Me.TXT_Prijs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "GP_BuyPriceEUR", True))
        Me.TXT_Prijs.Location = New System.Drawing.Point(77, 88)
        Me.TXT_Prijs.Name = "TXT_Prijs"
        Me.TXT_Prijs.ReadOnly = True
        Me.TXT_Prijs.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Prijs.TabIndex = 3
        Me.TXT_Prijs.TabStop = False
        Me.TXT_Prijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(217, 347)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(111, 23)
        Me.Knop_Opslaan.TabIndex = 3
        Me.Knop_Opslaan.Text = "&Opslaan en sluiten "
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(137, 347)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(74, 23)
        Me.Knop_Annuleren.TabIndex = 12
        Me.Knop_Annuleren.TabStop = False
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DT_productTableAdapter = Nothing
        Me.TableAdapterManager.GetOntvangstTableAdapter = Nothing
        Me.TableAdapterManager.GetProductAddTableAdapter = Nothing
        Me.TableAdapterManager.GPA_AantalTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.LocatieHolderTableAdapter = Nothing
        Me.TableAdapterManager.LocatieTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'GetProductAddTableAdapter
        '
        Me.GetProductAddTableAdapter.ClearBeforeFill = True
        '
        'DT_productTableAdapter
        '
        Me.DT_productTableAdapter.ClearBeforeFill = True
        '
        'ValutaTableAdapter
        '
        Me.ValutaTableAdapter.ClearBeforeFill = True
        '
        'TXT_IDONTV
        '
        Me.TXT_IDONTV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "ID_GetOntvangst", True))
        Me.TXT_IDONTV.Location = New System.Drawing.Point(212, 88)
        Me.TXT_IDONTV.Name = "TXT_IDONTV"
        Me.TXT_IDONTV.ReadOnly = True
        Me.TXT_IDONTV.Size = New System.Drawing.Size(40, 20)
        Me.TXT_IDONTV.TabIndex = 14
        Me.TXT_IDONTV.TabStop = False
        '
        'Knop_Verwijder
        '
        Me.Knop_Verwijder.Location = New System.Drawing.Point(19, 349)
        Me.Knop_Verwijder.Name = "Knop_Verwijder"
        Me.Knop_Verwijder.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Verwijder.TabIndex = 15
        Me.Knop_Verwijder.TabStop = False
        Me.Knop_Verwijder.Text = "Verwijder"
        Me.Knop_Verwijder.UseVisualStyleBackColor = True
        '
        'F_GetProductAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 385)
        Me.Controls.Add(Me.Knop_Verwijder)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.GB_Prijs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_ProductLijst)
        Me.Name = "F_GetProductAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Producten toevoegen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Prijs.ResumeLayout(False)
        Me.GB_Prijs.PerformLayout()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_ProductLijst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_ProductID As TextBox
    Friend WithEvents Knop_Details As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_aantal As TextBox
    Friend WithEvents GB_Prijs As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_Prijs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_TotaalBetaaldVAL As TextBox
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents GetProductAddBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents TXT_GetProductAdd As TextBox
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents GetProductAddTableAdapter As DS_ProductTableAdapters.GetProductAddTableAdapter
    Friend WithEvents DT_productBindingSource As BindingSource
    Friend WithEvents DT_productTableAdapter As DS_ProductTableAdapters.DT_productTableAdapter
    Friend WithEvents TXT_Product_Inkoop As TextBox
    Friend WithEvents TXT_PDnaam As TextBox
    Friend WithEvents PD_VoorraadTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_TotaalBetaaldEur As TextBox
    Friend WithEvents Knop_Zoek As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_Koers As TextBox
    Friend WithEvents CB_valuta As ComboBox
    Friend WithEvents ValutaBindingSource As BindingSource
    Friend WithEvents ValutaTableAdapter As DS_ProductTableAdapters.ValutaTableAdapter
    Friend WithEvents TXT_IDONTV As TextBox
    Friend WithEvents Knop_Verwijder As Button
    Friend WithEvents Knop_Reset As Button
End Class

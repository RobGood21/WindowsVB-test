<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Shop
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
        Dim SH_NaamLabel As System.Windows.Forms.Label
        Dim SH_AdresLabel As System.Windows.Forms.Label
        Dim SH_AdresXtraLabel As System.Windows.Forms.Label
        Dim SH_PostcodeLabel As System.Windows.Forms.Label
        Dim SH_PLaatsLabel As System.Windows.Forms.Label
        Dim SH_ContactLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim SH_EmailLabel As System.Windows.Forms.Label
        Dim SH_PhoneLabel As System.Windows.Forms.Label
        Dim SH_WebsiteLabel As System.Windows.Forms.Label
        Dim SH_RelationCodeLabel As System.Windows.Forms.Label
        Me.GB_Shop = New System.Windows.Forms.GroupBox()
        Me.TXT_Website = New System.Windows.Forms.TextBox()
        Me.ShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Supplier = New WindowsVB_test.DS_Supplier()
        Me.SH_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.SH_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CB_Land = New System.Windows.Forms.ComboBox()
        Me.LandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SH_ContactTextBox = New System.Windows.Forms.TextBox()
        Me.SH_PLaatsTextBox = New System.Windows.Forms.TextBox()
        Me.SH_PostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.SH_AdresXtraTextBox = New System.Windows.Forms.TextBox()
        Me.SH_AdresTextBox = New System.Windows.Forms.TextBox()
        Me.SH_NaamTextBox = New System.Windows.Forms.TextBox()
        Me.Knop_opslaan = New System.Windows.Forms.Button()
        Me.Knop_Link = New System.Windows.Forms.Button()
        Me.TXT_IDSHOP = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager()
        Me.LandTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.LandTableAdapter()
        Me.ShopTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.ShopTableAdapter()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.SupplierTableAdapter()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SH_RelationCodeTextBox = New System.Windows.Forms.TextBox()
        Me.TXT_SupplierNaam = New System.Windows.Forms.TextBox()
        Me.TXT_IDSupplier = New System.Windows.Forms.TextBox()
        Me.txt_IDSupplier_Shop = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TKnop_Sluit = New System.Windows.Forms.ToolStripButton()
        Me.Tknop_Nieuw = New System.Windows.Forms.ToolStripButton()
        Me.Tknop_Annuleren = New System.Windows.Forms.ToolStripButton()
        Me.Tknop_Opslaan = New System.Windows.Forms.ToolStripButton()
        Me.Tknop_Delete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        SH_NaamLabel = New System.Windows.Forms.Label()
        SH_AdresLabel = New System.Windows.Forms.Label()
        SH_AdresXtraLabel = New System.Windows.Forms.Label()
        SH_PostcodeLabel = New System.Windows.Forms.Label()
        SH_PLaatsLabel = New System.Windows.Forms.Label()
        SH_ContactLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        SH_EmailLabel = New System.Windows.Forms.Label()
        SH_PhoneLabel = New System.Windows.Forms.Label()
        SH_WebsiteLabel = New System.Windows.Forms.Label()
        SH_RelationCodeLabel = New System.Windows.Forms.Label()
        Me.GB_Shop.SuspendLayout()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SH_NaamLabel
        '
        SH_NaamLabel.AutoSize = True
        SH_NaamLabel.Location = New System.Drawing.Point(14, 20)
        SH_NaamLabel.Name = "SH_NaamLabel"
        SH_NaamLabel.Size = New System.Drawing.Size(38, 13)
        SH_NaamLabel.TabIndex = 0
        SH_NaamLabel.Text = "Naam:"
        '
        'SH_AdresLabel
        '
        SH_AdresLabel.AutoSize = True
        SH_AdresLabel.Location = New System.Drawing.Point(14, 42)
        SH_AdresLabel.Name = "SH_AdresLabel"
        SH_AdresLabel.Size = New System.Drawing.Size(37, 13)
        SH_AdresLabel.TabIndex = 2
        SH_AdresLabel.Text = "Adres:"
        '
        'SH_AdresXtraLabel
        '
        SH_AdresXtraLabel.AutoSize = True
        SH_AdresXtraLabel.Location = New System.Drawing.Point(14, 64)
        SH_AdresXtraLabel.Name = "SH_AdresXtraLabel"
        SH_AdresXtraLabel.Size = New System.Drawing.Size(59, 13)
        SH_AdresXtraLabel.TabIndex = 4
        SH_AdresXtraLabel.Text = "Adres Xtra:"
        '
        'SH_PostcodeLabel
        '
        SH_PostcodeLabel.AutoSize = True
        SH_PostcodeLabel.Location = New System.Drawing.Point(14, 85)
        SH_PostcodeLabel.Name = "SH_PostcodeLabel"
        SH_PostcodeLabel.Size = New System.Drawing.Size(55, 13)
        SH_PostcodeLabel.TabIndex = 6
        SH_PostcodeLabel.Text = "Postcode:"
        '
        'SH_PLaatsLabel
        '
        SH_PLaatsLabel.AutoSize = True
        SH_PLaatsLabel.Location = New System.Drawing.Point(14, 107)
        SH_PLaatsLabel.Name = "SH_PLaatsLabel"
        SH_PLaatsLabel.Size = New System.Drawing.Size(27, 13)
        SH_PLaatsLabel.TabIndex = 8
        SH_PLaatsLabel.Text = "City:"
        '
        'SH_ContactLabel
        '
        SH_ContactLabel.AutoSize = True
        SH_ContactLabel.Location = New System.Drawing.Point(14, 152)
        SH_ContactLabel.Name = "SH_ContactLabel"
        SH_ContactLabel.Size = New System.Drawing.Size(47, 13)
        SH_ContactLabel.TabIndex = 10
        SH_ContactLabel.Text = "Contact:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(14, 129)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 13
        Label1.Text = "Land:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(28, 31)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 13)
        Label2.TabIndex = 60
        Label2.Text = "Supplier, groep:"
        '
        'SH_EmailLabel
        '
        SH_EmailLabel.AutoSize = True
        SH_EmailLabel.Location = New System.Drawing.Point(14, 174)
        SH_EmailLabel.Name = "SH_EmailLabel"
        SH_EmailLabel.Size = New System.Drawing.Size(35, 13)
        SH_EmailLabel.TabIndex = 14
        SH_EmailLabel.Text = "Email:"
        '
        'SH_PhoneLabel
        '
        SH_PhoneLabel.AutoSize = True
        SH_PhoneLabel.Location = New System.Drawing.Point(14, 196)
        SH_PhoneLabel.Name = "SH_PhoneLabel"
        SH_PhoneLabel.Size = New System.Drawing.Size(52, 13)
        SH_PhoneLabel.TabIndex = 16
        SH_PhoneLabel.Text = "Telefoon:"
        '
        'SH_WebsiteLabel
        '
        SH_WebsiteLabel.AutoSize = True
        SH_WebsiteLabel.Location = New System.Drawing.Point(14, 226)
        SH_WebsiteLabel.Name = "SH_WebsiteLabel"
        SH_WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        SH_WebsiteLabel.TabIndex = 18
        SH_WebsiteLabel.Text = "Website:"
        '
        'SH_RelationCodeLabel
        '
        SH_RelationCodeLabel.AutoSize = True
        SH_RelationCodeLabel.Location = New System.Drawing.Point(28, 53)
        SH_RelationCodeLabel.Name = "SH_RelationCodeLabel"
        SH_RelationCodeLabel.Size = New System.Drawing.Size(68, 13)
        SH_RelationCodeLabel.TabIndex = 60
        SH_RelationCodeLabel.Text = "RelatieCode:"
        '
        'GB_Shop
        '
        Me.GB_Shop.Controls.Add(SH_WebsiteLabel)
        Me.GB_Shop.Controls.Add(Me.TXT_Website)
        Me.GB_Shop.Controls.Add(SH_PhoneLabel)
        Me.GB_Shop.Controls.Add(Me.SH_PhoneTextBox)
        Me.GB_Shop.Controls.Add(SH_EmailLabel)
        Me.GB_Shop.Controls.Add(Me.SH_EmailTextBox)
        Me.GB_Shop.Controls.Add(Label1)
        Me.GB_Shop.Controls.Add(Me.Knop_Link)
        Me.GB_Shop.Controls.Add(Me.CB_Land)
        Me.GB_Shop.Controls.Add(SH_ContactLabel)
        Me.GB_Shop.Controls.Add(Me.SH_ContactTextBox)
        Me.GB_Shop.Controls.Add(SH_PLaatsLabel)
        Me.GB_Shop.Controls.Add(Me.SH_PLaatsTextBox)
        Me.GB_Shop.Controls.Add(SH_PostcodeLabel)
        Me.GB_Shop.Controls.Add(Me.SH_PostcodeTextBox)
        Me.GB_Shop.Controls.Add(SH_AdresXtraLabel)
        Me.GB_Shop.Controls.Add(Me.SH_AdresXtraTextBox)
        Me.GB_Shop.Controls.Add(SH_AdresLabel)
        Me.GB_Shop.Controls.Add(Me.SH_AdresTextBox)
        Me.GB_Shop.Controls.Add(SH_NaamLabel)
        Me.GB_Shop.Controls.Add(Me.SH_NaamTextBox)
        Me.GB_Shop.Location = New System.Drawing.Point(36, 81)
        Me.GB_Shop.Name = "GB_Shop"
        Me.GB_Shop.Size = New System.Drawing.Size(361, 255)
        Me.GB_Shop.TabIndex = 0
        Me.GB_Shop.TabStop = False
        '
        'TXT_Website
        '
        Me.TXT_Website.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Website", True))
        Me.TXT_Website.Location = New System.Drawing.Point(73, 223)
        Me.TXT_Website.Name = "TXT_Website"
        Me.TXT_Website.Size = New System.Drawing.Size(239, 20)
        Me.TXT_Website.TabIndex = 12
        '
        'ShopBindingSource
        '
        Me.ShopBindingSource.DataMember = "Shop"
        Me.ShopBindingSource.DataSource = Me.DS_Supplier
        '
        'DS_Supplier
        '
        Me.DS_Supplier.DataSetName = "DS_Supplier"
        Me.DS_Supplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SH_PhoneTextBox
        '
        Me.SH_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Phone", True))
        Me.SH_PhoneTextBox.Location = New System.Drawing.Point(73, 193)
        Me.SH_PhoneTextBox.Name = "SH_PhoneTextBox"
        Me.SH_PhoneTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_PhoneTextBox.TabIndex = 11
        '
        'SH_EmailTextBox
        '
        Me.SH_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Email", True))
        Me.SH_EmailTextBox.Location = New System.Drawing.Point(73, 171)
        Me.SH_EmailTextBox.Name = "SH_EmailTextBox"
        Me.SH_EmailTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_EmailTextBox.TabIndex = 10
        '
        'CB_Land
        '
        Me.CB_Land.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ShopBindingSource, "ID_Land", True))
        Me.CB_Land.DataSource = Me.LandBindingSource
        Me.CB_Land.DisplayMember = "LD_Naam"
        Me.CB_Land.FormattingEnabled = True
        Me.CB_Land.Location = New System.Drawing.Point(73, 126)
        Me.CB_Land.Name = "CB_Land"
        Me.CB_Land.Size = New System.Drawing.Size(274, 21)
        Me.CB_Land.TabIndex = 8
        Me.CB_Land.ValueMember = "ID_Land"
        '
        'LandBindingSource
        '
        Me.LandBindingSource.DataMember = "Land"
        Me.LandBindingSource.DataSource = Me.DS_Supplier
        '
        'SH_ContactTextBox
        '
        Me.SH_ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Contact", True))
        Me.SH_ContactTextBox.Location = New System.Drawing.Point(73, 149)
        Me.SH_ContactTextBox.Name = "SH_ContactTextBox"
        Me.SH_ContactTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_ContactTextBox.TabIndex = 9
        '
        'SH_PLaatsTextBox
        '
        Me.SH_PLaatsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_PLaats", True))
        Me.SH_PLaatsTextBox.Location = New System.Drawing.Point(73, 104)
        Me.SH_PLaatsTextBox.Name = "SH_PLaatsTextBox"
        Me.SH_PLaatsTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_PLaatsTextBox.TabIndex = 7
        '
        'SH_PostcodeTextBox
        '
        Me.SH_PostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Postcode", True))
        Me.SH_PostcodeTextBox.Location = New System.Drawing.Point(73, 82)
        Me.SH_PostcodeTextBox.Name = "SH_PostcodeTextBox"
        Me.SH_PostcodeTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_PostcodeTextBox.TabIndex = 6
        '
        'SH_AdresXtraTextBox
        '
        Me.SH_AdresXtraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_AdresXtra", True))
        Me.SH_AdresXtraTextBox.Location = New System.Drawing.Point(73, 60)
        Me.SH_AdresXtraTextBox.Name = "SH_AdresXtraTextBox"
        Me.SH_AdresXtraTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_AdresXtraTextBox.TabIndex = 5
        '
        'SH_AdresTextBox
        '
        Me.SH_AdresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Adres", True))
        Me.SH_AdresTextBox.Location = New System.Drawing.Point(73, 38)
        Me.SH_AdresTextBox.Name = "SH_AdresTextBox"
        Me.SH_AdresTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_AdresTextBox.TabIndex = 3
        '
        'SH_NaamTextBox
        '
        Me.SH_NaamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Naam", True))
        Me.SH_NaamTextBox.Location = New System.Drawing.Point(73, 17)
        Me.SH_NaamTextBox.Name = "SH_NaamTextBox"
        Me.SH_NaamTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_NaamTextBox.TabIndex = 1
        '
        'Knop_opslaan
        '
        Me.Knop_opslaan.Location = New System.Drawing.Point(246, 342)
        Me.Knop_opslaan.Name = "Knop_opslaan"
        Me.Knop_opslaan.Size = New System.Drawing.Size(150, 23)
        Me.Knop_opslaan.TabIndex = 13
        Me.Knop_opslaan.Text = "&Opslaan en sluiten"
        Me.Knop_opslaan.UseVisualStyleBackColor = True
        '
        'Knop_Link
        '
        Me.Knop_Link.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Insert_hyperlink_icon
        Me.Knop_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Link.Location = New System.Drawing.Point(317, 217)
        Me.Knop_Link.Name = "Knop_Link"
        Me.Knop_Link.Size = New System.Drawing.Size(30, 30)
        Me.Knop_Link.TabIndex = 57
        Me.Knop_Link.TabStop = False
        Me.Knop_Link.UseVisualStyleBackColor = True
        '
        'TXT_IDSHOP
        '
        Me.TXT_IDSHOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "ID_Shop", True))
        Me.TXT_IDSHOP.Enabled = False
        Me.TXT_IDSHOP.Location = New System.Drawing.Point(78, 342)
        Me.TXT_IDSHOP.Name = "TXT_IDSHOP"
        Me.TXT_IDSHOP.ReadOnly = True
        Me.TXT_IDSHOP.Size = New System.Drawing.Size(37, 20)
        Me.TXT_IDSHOP.TabIndex = 54
        Me.TXT_IDSHOP.TabStop = False
        Me.TXT_IDSHOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BetaalWijzenTableAdapter = Nothing
        Me.TableAdapterManager.LandTableAdapter = Me.LandTableAdapter
        Me.TableAdapterManager.ShopTableAdapter = Me.ShopTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'LandTableAdapter
        '
        Me.LandTableAdapter.ClearBeforeFill = True
        '
        'ShopTableAdapter
        '
        Me.ShopTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Supplier
        '
        'SH_RelationCodeTextBox
        '
        Me.SH_RelationCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_RelationCode", True))
        Me.SH_RelationCodeTextBox.Location = New System.Drawing.Point(109, 50)
        Me.SH_RelationCodeTextBox.Name = "SH_RelationCodeTextBox"
        Me.SH_RelationCodeTextBox.Size = New System.Drawing.Size(274, 20)
        Me.SH_RelationCodeTextBox.TabIndex = 0
        '
        'TXT_SupplierNaam
        '
        Me.TXT_SupplierNaam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_SupplierNaam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Naam", True))
        Me.TXT_SupplierNaam.Location = New System.Drawing.Point(109, 32)
        Me.TXT_SupplierNaam.Name = "TXT_SupplierNaam"
        Me.TXT_SupplierNaam.ReadOnly = True
        Me.TXT_SupplierNaam.Size = New System.Drawing.Size(239, 13)
        Me.TXT_SupplierNaam.TabIndex = 62
        Me.TXT_SupplierNaam.TabStop = False
        '
        'TXT_IDSupplier
        '
        Me.TXT_IDSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_IDSupplier.Enabled = False
        Me.TXT_IDSupplier.Location = New System.Drawing.Point(354, 32)
        Me.TXT_IDSupplier.Name = "TXT_IDSupplier"
        Me.TXT_IDSupplier.Size = New System.Drawing.Size(30, 13)
        Me.TXT_IDSupplier.TabIndex = 63
        Me.TXT_IDSupplier.TabStop = False
        Me.TXT_IDSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_IDSupplier_Shop
        '
        Me.txt_IDSupplier_Shop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "ID_Supplier", True))
        Me.txt_IDSupplier_Shop.Enabled = False
        Me.txt_IDSupplier_Shop.Location = New System.Drawing.Point(36, 342)
        Me.txt_IDSupplier_Shop.Name = "txt_IDSupplier_Shop"
        Me.txt_IDSupplier_Shop.ReadOnly = True
        Me.txt_IDSupplier_Shop.Size = New System.Drawing.Size(37, 20)
        Me.txt_IDSupplier_Shop.TabIndex = 64
        Me.txt_IDSupplier_Shop.TabStop = False
        Me.txt_IDSupplier_Shop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TKnop_Sluit, Me.ToolStripSeparator1, Me.Tknop_Nieuw, Me.ToolStripSeparator2, Me.Tknop_Annuleren, Me.ToolStripSeparator3, Me.Tknop_Opslaan, Me.ToolStripSeparator4, Me.Tknop_Delete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(432, 25)
        Me.ToolStrip1.TabIndex = 65
        Me.ToolStrip1.Text = "TS_Shop"
        '
        'TKnop_Sluit
        '
        Me.TKnop_Sluit.Image = Global.WindowsVB_test.My.Resources.Resources.close_icon
        Me.TKnop_Sluit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TKnop_Sluit.Name = "TKnop_Sluit"
        Me.TKnop_Sluit.Size = New System.Drawing.Size(63, 22)
        Me.TKnop_Sluit.Text = "Sluiten"
        '
        'Tknop_Nieuw
        '
        Me.Tknop_Nieuw.Image = Global.WindowsVB_test.My.Resources.Resources.Button_Add_icon
        Me.Tknop_Nieuw.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_Nieuw.Name = "Tknop_Nieuw"
        Me.Tknop_Nieuw.Size = New System.Drawing.Size(61, 22)
        Me.Tknop_Nieuw.Text = "Nieuw"
        '
        'Tknop_Annuleren
        '
        Me.Tknop_Annuleren.Image = Global.WindowsVB_test.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.Tknop_Annuleren.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_Annuleren.Name = "Tknop_Annuleren"
        Me.Tknop_Annuleren.Size = New System.Drawing.Size(82, 22)
        Me.Tknop_Annuleren.Text = "Annuleren"
        '
        'Tknop_Opslaan
        '
        Me.Tknop_Opslaan.Image = Global.WindowsVB_test.My.Resources.Resources.Save_as_icon
        Me.Tknop_Opslaan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_Opslaan.Name = "Tknop_Opslaan"
        Me.Tknop_Opslaan.Size = New System.Drawing.Size(70, 22)
        Me.Tknop_Opslaan.Text = "Opslaan"
        '
        'Tknop_Delete
        '
        Me.Tknop_Delete.Image = Global.WindowsVB_test.My.Resources.Resources.Windows_Close_Program_icon
        Me.Tknop_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_Delete.Name = "Tknop_Delete"
        Me.Tknop_Delete.Size = New System.Drawing.Size(63, 22)
        Me.Tknop_Delete.Text = "Delete "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'F_Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 391)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_IDSupplier_Shop)
        Me.Controls.Add(Me.TXT_IDSupplier)
        Me.Controls.Add(Me.TXT_SupplierNaam)
        Me.Controls.Add(SH_RelationCodeLabel)
        Me.Controls.Add(Me.SH_RelationCodeTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TXT_IDSHOP)
        Me.Controls.Add(Me.Knop_opslaan)
        Me.Controls.Add(Me.GB_Shop)
        Me.Name = "F_Shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Shop of filiaal"
        Me.GB_Shop.ResumeLayout(False)
        Me.GB_Shop.PerformLayout()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Shop As GroupBox
    Friend WithEvents Knop_opslaan As Button
    Friend WithEvents Knop_Link As Button
    Friend WithEvents TXT_IDSHOP As TextBox
    Friend WithEvents DS_Supplier As DS_Supplier
    Friend WithEvents ShopBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_SupplierTableAdapters.TableAdapterManager
    Friend WithEvents SH_NaamTextBox As TextBox
    Friend WithEvents SH_ContactTextBox As TextBox
    Friend WithEvents SH_PLaatsTextBox As TextBox
    Friend WithEvents SH_PostcodeTextBox As TextBox
    Friend WithEvents SH_AdresXtraTextBox As TextBox
    Friend WithEvents SH_AdresTextBox As TextBox
    Friend WithEvents CB_Land As ComboBox
    Friend WithEvents LandTableAdapter As DS_SupplierTableAdapters.LandTableAdapter
    Friend WithEvents LandBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DS_SupplierTableAdapters.SupplierTableAdapter
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SH_EmailTextBox As TextBox
    Friend WithEvents TXT_Website As TextBox
    Friend WithEvents SH_PhoneTextBox As TextBox
    Friend WithEvents ShopTableAdapter As DS_SupplierTableAdapters.ShopTableAdapter
    Friend WithEvents SH_RelationCodeTextBox As TextBox
    Friend WithEvents TXT_SupplierNaam As TextBox
    Friend WithEvents TXT_IDSupplier As TextBox
    Friend WithEvents txt_IDSupplier_Shop As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TKnop_Sluit As ToolStripButton
    Friend WithEvents Tknop_Nieuw As ToolStripButton
    Friend WithEvents Tknop_Annuleren As ToolStripButton
    Friend WithEvents Tknop_Opslaan As ToolStripButton
    Friend WithEvents Tknop_Delete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class

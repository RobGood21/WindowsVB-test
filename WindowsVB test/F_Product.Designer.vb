<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Product
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
        Dim PD_NaamLabel As System.Windows.Forms.Label
        Dim PD_BehuizingLabel As System.Windows.Forms.Label
        Dim PD_FunctieLabel As System.Windows.Forms.Label
        Dim PD_WaardeLabel As System.Windows.Forms.Label
        Dim ID_MerkLabel As System.Windows.Forms.Label
        Dim PD_Sale_PrijsLabel As System.Windows.Forms.Label
        Dim PD_Buy_CostLabel As System.Windows.Forms.Label
        Dim PD_MinimumVoorraadLabel As System.Windows.Forms.Label
        Dim PD_VoorraadLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ID_GroepLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_PN = New System.Windows.Forms.Label()
        Me.TXT_Productnummer = New System.Windows.Forms.TextBox()
        Me.Knop_ZoekProduct = New System.Windows.Forms.Button()
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.GroepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_productTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.DT_productTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.GroepTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GroepTableAdapter()
        Me.MerkTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.MerkTableAdapter()
        Me.GBOX_Velden = New System.Windows.Forms.GroupBox()
        Me.CB_Groep = New System.Windows.Forms.ComboBox()
        Me.GB_Merk = New System.Windows.Forms.ComboBox()
        Me.TXT_Naam = New System.Windows.Forms.TextBox()
        Me.TXT_functie = New System.Windows.Forms.TextBox()
        Me.TXT_behuizing = New System.Windows.Forms.TextBox()
        Me.TXT_waarde = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXT_Locatie = New System.Windows.Forms.TextBox()
        Me.LocatieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXT_Beschrijving2 = New System.Windows.Forms.TextBox()
        Me.Knop_Locatie = New System.Windows.Forms.Button()
        Me.CB_Locatie = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_LaatsteInkoop_Waarde = New System.Windows.Forms.TextBox()
        Me.TXT_Laatste_inkoop_Datum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Minimal = New System.Windows.Forms.TextBox()
        Me.TXT_Voorraad = New System.Windows.Forms.TextBox()
        Me.TXT_Verkoopprijs = New System.Windows.Forms.TextBox()
        Me.TXT_Inkoopwaarde = New System.Windows.Forms.TextBox()
        Me.TAB_Product = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_Beschrijving1 = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.LocatieTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.LocatieTableAdapter()
        Me.TXT_IDP = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Opslaan = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnulerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NieuwProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductWissenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        PD_NaamLabel = New System.Windows.Forms.Label()
        PD_BehuizingLabel = New System.Windows.Forms.Label()
        PD_FunctieLabel = New System.Windows.Forms.Label()
        PD_WaardeLabel = New System.Windows.Forms.Label()
        ID_MerkLabel = New System.Windows.Forms.Label()
        PD_Sale_PrijsLabel = New System.Windows.Forms.Label()
        PD_Buy_CostLabel = New System.Windows.Forms.Label()
        PD_MinimumVoorraadLabel = New System.Windows.Forms.Label()
        PD_VoorraadLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ID_GroepLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBOX_Velden.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LocatieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_Product.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PD_NaamLabel
        '
        PD_NaamLabel.AutoSize = True
        PD_NaamLabel.Location = New System.Drawing.Point(28, 39)
        PD_NaamLabel.Name = "PD_NaamLabel"
        PD_NaamLabel.Size = New System.Drawing.Size(68, 13)
        PD_NaamLabel.TabIndex = 18
        PD_NaamLabel.Text = "Naam, code:"
        '
        'PD_BehuizingLabel
        '
        PD_BehuizingLabel.AutoSize = True
        PD_BehuizingLabel.Location = New System.Drawing.Point(40, 110)
        PD_BehuizingLabel.Name = "PD_BehuizingLabel"
        PD_BehuizingLabel.Size = New System.Drawing.Size(56, 13)
        PD_BehuizingLabel.TabIndex = 24
        PD_BehuizingLabel.Text = "Behuizing:"
        '
        'PD_FunctieLabel
        '
        PD_FunctieLabel.AutoSize = True
        PD_FunctieLabel.Location = New System.Drawing.Point(51, 62)
        PD_FunctieLabel.Name = "PD_FunctieLabel"
        PD_FunctieLabel.Size = New System.Drawing.Size(45, 13)
        PD_FunctieLabel.TabIndex = 20
        PD_FunctieLabel.Text = "Functie:"
        '
        'PD_WaardeLabel
        '
        PD_WaardeLabel.AutoSize = True
        PD_WaardeLabel.Location = New System.Drawing.Point(43, 86)
        PD_WaardeLabel.Name = "PD_WaardeLabel"
        PD_WaardeLabel.Size = New System.Drawing.Size(53, 13)
        PD_WaardeLabel.TabIndex = 22
        PD_WaardeLabel.Text = "Waardes:"
        '
        'ID_MerkLabel
        '
        ID_MerkLabel.AutoSize = True
        ID_MerkLabel.Location = New System.Drawing.Point(62, 134)
        ID_MerkLabel.Name = "ID_MerkLabel"
        ID_MerkLabel.Size = New System.Drawing.Size(34, 13)
        ID_MerkLabel.TabIndex = 26
        ID_MerkLabel.Text = "Merk:"
        '
        'PD_Sale_PrijsLabel
        '
        PD_Sale_PrijsLabel.AutoSize = True
        PD_Sale_PrijsLabel.Location = New System.Drawing.Point(25, 21)
        PD_Sale_PrijsLabel.Name = "PD_Sale_PrijsLabel"
        PD_Sale_PrijsLabel.Size = New System.Drawing.Size(68, 13)
        PD_Sale_PrijsLabel.TabIndex = 22
        PD_Sale_PrijsLabel.Text = "Verkoopprijs:"
        '
        'PD_Buy_CostLabel
        '
        PD_Buy_CostLabel.AutoSize = True
        PD_Buy_CostLabel.Location = New System.Drawing.Point(170, 21)
        PD_Buy_CostLabel.Name = "PD_Buy_CostLabel"
        PD_Buy_CostLabel.Size = New System.Drawing.Size(78, 13)
        PD_Buy_CostLabel.TabIndex = 24
        PD_Buy_CostLabel.Text = "Inkoopwaarde:"
        PD_Buy_CostLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PD_MinimumVoorraadLabel
        '
        PD_MinimumVoorraadLabel.AutoSize = True
        PD_MinimumVoorraadLabel.Location = New System.Drawing.Point(142, 89)
        PD_MinimumVoorraadLabel.Name = "PD_MinimumVoorraadLabel"
        PD_MinimumVoorraadLabel.Size = New System.Drawing.Size(51, 13)
        PD_MinimumVoorraadLabel.TabIndex = 30
        PD_MinimumVoorraadLabel.Text = "Minimaal:"
        '
        'PD_VoorraadLabel
        '
        PD_VoorraadLabel.AutoSize = True
        PD_VoorraadLabel.Location = New System.Drawing.Point(43, 89)
        PD_VoorraadLabel.Name = "PD_VoorraadLabel"
        PD_VoorraadLabel.Size = New System.Drawing.Size(56, 13)
        PD_VoorraadLabel.TabIndex = 28
        PD_VoorraadLabel.Text = "Voorraad: "
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(51, 113)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 13)
        Label1.TabIndex = 38
        Label1.Text = "Lokatie:"
        '
        'ID_GroepLabel
        '
        ID_GroepLabel.AutoSize = True
        ID_GroepLabel.Location = New System.Drawing.Point(22, 15)
        ID_GroepLabel.Name = "ID_GroepLabel"
        ID_GroepLabel.Size = New System.Drawing.Size(74, 13)
        ID_GroepLabel.TabIndex = 29
        ID_GroepLabel.Text = "Productgroep:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(23, 139)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(70, 13)
        Label2.TabIndex = 41
        Label2.Text = "Omschrijving:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_PN)
        Me.GroupBox1.Controls.Add(Me.TXT_Productnummer)
        Me.GroupBox1.Controls.Add(Me.Knop_ZoekProduct)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 58)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product"
        '
        'LBL_PN
        '
        Me.LBL_PN.AutoSize = True
        Me.LBL_PN.Location = New System.Drawing.Point(12, 27)
        Me.LBL_PN.Name = "LBL_PN"
        Me.LBL_PN.Size = New System.Drawing.Size(84, 13)
        Me.LBL_PN.TabIndex = 20
        Me.LBL_PN.Text = "Productnummer:"
        '
        'TXT_Productnummer
        '
        Me.TXT_Productnummer.Location = New System.Drawing.Point(102, 24)
        Me.TXT_Productnummer.Name = "TXT_Productnummer"
        Me.TXT_Productnummer.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Productnummer.TabIndex = 0
        '
        'Knop_ZoekProduct
        '
        Me.Knop_ZoekProduct.Location = New System.Drawing.Point(211, 22)
        Me.Knop_ZoekProduct.Name = "Knop_ZoekProduct"
        Me.Knop_ZoekProduct.Size = New System.Drawing.Size(75, 23)
        Me.Knop_ZoekProduct.TabIndex = 18
        Me.Knop_ZoekProduct.TabStop = False
        Me.Knop_ZoekProduct.Text = "Zoek.."
        Me.Knop_ZoekProduct.UseVisualStyleBackColor = True
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
        'GroepBindingSource
        '
        Me.GroepBindingSource.DataMember = "Groep"
        Me.GroepBindingSource.DataSource = Me.DS_Product
        '
        'MerkBindingSource
        '
        Me.MerkBindingSource.DataMember = "Merk"
        Me.MerkBindingSource.DataSource = Me.DSProductBindingSource
        '
        'DSProductBindingSource
        '
        Me.DSProductBindingSource.DataSource = Me.DS_Product
        Me.DSProductBindingSource.Position = 0
        '
        'DT_productTableAdapter
        '
        Me.DT_productTableAdapter.ClearBeforeFill = True
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
        'GroepTableAdapter
        '
        Me.GroepTableAdapter.ClearBeforeFill = True
        '
        'MerkTableAdapter
        '
        Me.MerkTableAdapter.ClearBeforeFill = True
        '
        'GBOX_Velden
        '
        Me.GBOX_Velden.Controls.Add(Me.CB_Groep)
        Me.GBOX_Velden.Controls.Add(ID_GroepLabel)
        Me.GBOX_Velden.Controls.Add(Me.GB_Merk)
        Me.GBOX_Velden.Controls.Add(ID_MerkLabel)
        Me.GBOX_Velden.Controls.Add(Me.TXT_Naam)
        Me.GBOX_Velden.Controls.Add(PD_NaamLabel)
        Me.GBOX_Velden.Controls.Add(PD_BehuizingLabel)
        Me.GBOX_Velden.Controls.Add(Me.TXT_functie)
        Me.GBOX_Velden.Controls.Add(Me.TXT_behuizing)
        Me.GBOX_Velden.Controls.Add(PD_FunctieLabel)
        Me.GBOX_Velden.Controls.Add(PD_WaardeLabel)
        Me.GBOX_Velden.Controls.Add(Me.TXT_waarde)
        Me.GBOX_Velden.Location = New System.Drawing.Point(12, 96)
        Me.GBOX_Velden.Name = "GBOX_Velden"
        Me.GBOX_Velden.Size = New System.Drawing.Size(315, 164)
        Me.GBOX_Velden.TabIndex = 0
        Me.GBOX_Velden.TabStop = False
        '
        'CB_Groep
        '
        Me.CB_Groep.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_productBindingSource, "ID_Groep", True))
        Me.CB_Groep.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "GP_Naam", True))
        Me.CB_Groep.DataSource = Me.GroepBindingSource
        Me.CB_Groep.DisplayMember = "GP_Naam"
        Me.CB_Groep.FormattingEnabled = True
        Me.CB_Groep.Location = New System.Drawing.Point(102, 9)
        Me.CB_Groep.Name = "CB_Groep"
        Me.CB_Groep.Size = New System.Drawing.Size(184, 21)
        Me.CB_Groep.TabIndex = 0
        Me.CB_Groep.ValueMember = "ID_Groep"
        '
        'GB_Merk
        '
        Me.GB_Merk.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_productBindingSource, "ID_Merk", True))
        Me.GB_Merk.DataSource = Me.MerkBindingSource
        Me.GB_Merk.DisplayMember = "MK_MerkNaam"
        Me.GB_Merk.FormattingEnabled = True
        Me.GB_Merk.Location = New System.Drawing.Point(102, 131)
        Me.GB_Merk.Name = "GB_Merk"
        Me.GB_Merk.Size = New System.Drawing.Size(184, 21)
        Me.GB_Merk.TabIndex = 4
        Me.GB_Merk.ValueMember = "ID_Merk"
        '
        'TXT_Naam
        '
        Me.TXT_Naam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Naam", True))
        Me.TXT_Naam.Location = New System.Drawing.Point(102, 36)
        Me.TXT_Naam.Name = "TXT_Naam"
        Me.TXT_Naam.Size = New System.Drawing.Size(184, 20)
        Me.TXT_Naam.TabIndex = 1
        '
        'TXT_functie
        '
        Me.TXT_functie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Functie", True))
        Me.TXT_functie.Location = New System.Drawing.Point(102, 59)
        Me.TXT_functie.Name = "TXT_functie"
        Me.TXT_functie.Size = New System.Drawing.Size(184, 20)
        Me.TXT_functie.TabIndex = 1
        '
        'TXT_behuizing
        '
        Me.TXT_behuizing.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Behuizing", True))
        Me.TXT_behuizing.Location = New System.Drawing.Point(102, 107)
        Me.TXT_behuizing.Name = "TXT_behuizing"
        Me.TXT_behuizing.Size = New System.Drawing.Size(185, 20)
        Me.TXT_behuizing.TabIndex = 3
        '
        'TXT_waarde
        '
        Me.TXT_waarde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Waarde", True))
        Me.TXT_waarde.Location = New System.Drawing.Point(102, 83)
        Me.TXT_waarde.Name = "TXT_waarde"
        Me.TXT_waarde.Size = New System.Drawing.Size(184, 20)
        Me.TXT_waarde.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXT_Locatie)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.TXT_Beschrijving2)
        Me.GroupBox3.Controls.Add(Me.Knop_Locatie)
        Me.GroupBox3.Controls.Add(Me.CB_Locatie)
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TXT_LaatsteInkoop_Waarde)
        Me.GroupBox3.Controls.Add(Me.TXT_Laatste_inkoop_Datum)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(PD_MinimumVoorraadLabel)
        Me.GroupBox3.Controls.Add(Me.TXT_Minimal)
        Me.GroupBox3.Controls.Add(PD_VoorraadLabel)
        Me.GroupBox3.Controls.Add(Me.TXT_Voorraad)
        Me.GroupBox3.Controls.Add(PD_Sale_PrijsLabel)
        Me.GroupBox3.Controls.Add(Me.TXT_Verkoopprijs)
        Me.GroupBox3.Controls.Add(Me.TXT_Inkoopwaarde)
        Me.GroupBox3.Controls.Add(PD_Buy_CostLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(333, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 211)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prijzen"
        '
        'TXT_Locatie
        '
        Me.TXT_Locatie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieBindingSource, "LK_Code", True))
        Me.TXT_Locatie.Location = New System.Drawing.Point(102, 110)
        Me.TXT_Locatie.Name = "TXT_Locatie"
        Me.TXT_Locatie.Size = New System.Drawing.Size(131, 20)
        Me.TXT_Locatie.TabIndex = 42
        '
        'LocatieBindingSource
        '
        Me.LocatieBindingSource.DataMember = "Locatie"
        Me.LocatieBindingSource.DataSource = Me.DS_Product
        '
        'TXT_Beschrijving2
        '
        Me.TXT_Beschrijving2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Beschrijving(2)", True))
        Me.TXT_Beschrijving2.Location = New System.Drawing.Point(102, 136)
        Me.TXT_Beschrijving2.Multiline = True
        Me.TXT_Beschrijving2.Name = "TXT_Beschrijving2"
        Me.TXT_Beschrijving2.Size = New System.Drawing.Size(249, 51)
        Me.TXT_Beschrijving2.TabIndex = 35
        Me.TXT_Beschrijving2.TabStop = False
        '
        'Knop_Locatie
        '
        Me.Knop_Locatie.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.location_icon
        Me.Knop_Locatie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Locatie.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Knop_Locatie.Location = New System.Drawing.Point(235, 105)
        Me.Knop_Locatie.Name = "Knop_Locatie"
        Me.Knop_Locatie.Size = New System.Drawing.Size(31, 30)
        Me.Knop_Locatie.TabIndex = 40
        Me.Knop_Locatie.UseVisualStyleBackColor = True
        '
        'CB_Locatie
        '
        Me.CB_Locatie.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_productBindingSource, "ID_Locatie", True))
        Me.CB_Locatie.DataSource = Me.LocatieBindingSource
        Me.CB_Locatie.DisplayMember = "LK_Code"
        Me.CB_Locatie.Enabled = False
        Me.CB_Locatie.Location = New System.Drawing.Point(239, 109)
        Me.CB_Locatie.MaxDropDownItems = 2
        Me.CB_Locatie.Name = "CB_Locatie"
        Me.CB_Locatie.Size = New System.Drawing.Size(22, 21)
        Me.CB_Locatie.TabIndex = 39
        Me.CB_Locatie.ValueMember = "ID_Locatie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Betaald:"
        '
        'TXT_LaatsteInkoop_Waarde
        '
        Me.TXT_LaatsteInkoop_Waarde.Location = New System.Drawing.Point(102, 64)
        Me.TXT_LaatsteInkoop_Waarde.Name = "TXT_LaatsteInkoop_Waarde"
        Me.TXT_LaatsteInkoop_Waarde.ReadOnly = True
        Me.TXT_LaatsteInkoop_Waarde.Size = New System.Drawing.Size(69, 20)
        Me.TXT_LaatsteInkoop_Waarde.TabIndex = 36
        Me.TXT_LaatsteInkoop_Waarde.TabStop = False
        '
        'TXT_Laatste_inkoop_Datum
        '
        Me.TXT_Laatste_inkoop_Datum.Location = New System.Drawing.Point(102, 42)
        Me.TXT_Laatste_inkoop_Datum.Name = "TXT_Laatste_inkoop_Datum"
        Me.TXT_Laatste_inkoop_Datum.ReadOnly = True
        Me.TXT_Laatste_inkoop_Datum.Size = New System.Drawing.Size(206, 20)
        Me.TXT_Laatste_inkoop_Datum.TabIndex = 35
        Me.TXT_Laatste_inkoop_Datum.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Laatste inkoop:"
        '
        'TXT_Minimal
        '
        Me.TXT_Minimal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_MinimumVoorraad", True))
        Me.TXT_Minimal.Location = New System.Drawing.Point(199, 86)
        Me.TXT_Minimal.Name = "TXT_Minimal"
        Me.TXT_Minimal.Size = New System.Drawing.Size(34, 20)
        Me.TXT_Minimal.TabIndex = 31
        '
        'TXT_Voorraad
        '
        Me.TXT_Voorraad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.TXT_Voorraad.Location = New System.Drawing.Point(102, 86)
        Me.TXT_Voorraad.Name = "TXT_Voorraad"
        Me.TXT_Voorraad.Size = New System.Drawing.Size(34, 20)
        Me.TXT_Voorraad.TabIndex = 29
        '
        'TXT_Verkoopprijs
        '
        Me.TXT_Verkoopprijs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Sale_Prijs", True))
        Me.TXT_Verkoopprijs.Location = New System.Drawing.Point(102, 18)
        Me.TXT_Verkoopprijs.Name = "TXT_Verkoopprijs"
        Me.TXT_Verkoopprijs.Size = New System.Drawing.Size(54, 20)
        Me.TXT_Verkoopprijs.TabIndex = 23
        '
        'TXT_Inkoopwaarde
        '
        Me.TXT_Inkoopwaarde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Buy_Cost", True))
        Me.TXT_Inkoopwaarde.Location = New System.Drawing.Point(254, 18)
        Me.TXT_Inkoopwaarde.Name = "TXT_Inkoopwaarde"
        Me.TXT_Inkoopwaarde.Size = New System.Drawing.Size(54, 20)
        Me.TXT_Inkoopwaarde.TabIndex = 25
        '
        'TAB_Product
        '
        Me.TAB_Product.Controls.Add(Me.TabPage3)
        Me.TAB_Product.Controls.Add(Me.TabPage5)
        Me.TAB_Product.Controls.Add(Me.TabPage6)
        Me.TAB_Product.Controls.Add(Me.TabPage2)
        Me.TAB_Product.Controls.Add(Me.TabPage1)
        Me.TAB_Product.Location = New System.Drawing.Point(12, 282)
        Me.TAB_Product.Name = "TAB_Product"
        Me.TAB_Product.SelectedIndex = 0
        Me.TAB_Product.Size = New System.Drawing.Size(689, 309)
        Me.TAB_Product.TabIndex = 38
        Me.TAB_Product.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_Beschrijving1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(681, 283)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Beschrijving product"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_Beschrijving1
        '
        Me.txt_Beschrijving1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Beschrijving1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Beschrijving(1)", True))
        Me.txt_Beschrijving1.Location = New System.Drawing.Point(-4, -27)
        Me.txt_Beschrijving1.Multiline = True
        Me.txt_Beschrijving1.Name = "txt_Beschrijving1"
        Me.txt_Beschrijving1.Size = New System.Drawing.Size(689, 314)
        Me.txt_Beschrijving1.TabIndex = 37
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(707, 283)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Afbeeldingen"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(707, 283)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Hyperlinks "
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(707, 283)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gebruikt voor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(707, 283)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ontvangen "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Enabled = False
        Me.Knop_Opslaan.Location = New System.Drawing.Point(595, 253)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(106, 23)
        Me.Knop_Opslaan.TabIndex = 41
        Me.Knop_Opslaan.Text = "&Opslaan en Sluiten"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'LocatieTableAdapter
        '
        Me.LocatieTableAdapter.ClearBeforeFill = True
        '
        'TXT_IDP
        '
        Me.TXT_IDP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "ID_Product", True))
        Me.TXT_IDP.Enabled = False
        Me.TXT_IDP.Location = New System.Drawing.Point(667, 15)
        Me.TXT_IDP.Name = "TXT_IDP"
        Me.TXT_IDP.ReadOnly = True
        Me.TXT_IDP.Size = New System.Drawing.Size(34, 20)
        Me.TXT_IDP.TabIndex = 41
        Me.TXT_IDP.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(435, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SluitenToolStripMenuItem, Me.NieuwProductToolStripMenuItem, Me.TSM_Opslaan, Me.AnnulerenToolStripMenuItem, Me.ProductWissenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SluitenToolStripMenuItem
        '
        Me.SluitenToolStripMenuItem.Image = Global.WindowsVB_test.My.Resources.Resources.close_icon
        Me.SluitenToolStripMenuItem.Name = "SluitenToolStripMenuItem"
        Me.SluitenToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SluitenToolStripMenuItem.Text = "Sluiten"
        '
        'TSM_Opslaan
        '
        Me.TSM_Opslaan.Image = Global.WindowsVB_test.My.Resources.Resources.Save_as_icon
        Me.TSM_Opslaan.Name = "TSM_Opslaan"
        Me.TSM_Opslaan.Size = New System.Drawing.Size(78, 20)
        Me.TSM_Opslaan.Text = "Opslaan"
        '
        'AnnulerenToolStripMenuItem
        '
        Me.AnnulerenToolStripMenuItem.Image = Global.WindowsVB_test.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.AnnulerenToolStripMenuItem.Name = "AnnulerenToolStripMenuItem"
        Me.AnnulerenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.AnnulerenToolStripMenuItem.Text = "Annuleren"
        '
        'NieuwProductToolStripMenuItem
        '
        Me.NieuwProductToolStripMenuItem.Image = Global.WindowsVB_test.My.Resources.Resources.Button_Add_icon
        Me.NieuwProductToolStripMenuItem.Name = "NieuwProductToolStripMenuItem"
        Me.NieuwProductToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.NieuwProductToolStripMenuItem.Text = "Nieuw product"
        '
        'ProductWissenToolStripMenuItem
        '
        Me.ProductWissenToolStripMenuItem.Image = Global.WindowsVB_test.My.Resources.Resources.Windows_Close_Program_icon
        Me.ProductWissenToolStripMenuItem.Name = "ProductWissenToolStripMenuItem"
        Me.ProductWissenToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ProductWissenToolStripMenuItem.Text = "Product wissen"
        '
        'F_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 624)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_IDP)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.TAB_Product)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GBOX_Velden)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "F_Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBOX_Velden.ResumeLayout(False)
        Me.GBOX_Velden.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.LocatieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_Product.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents DT_productBindingSource As BindingSource
    Friend WithEvents DT_productTableAdapter As DS_ProductTableAdapters.DT_productTableAdapter
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents GroepBindingSource As BindingSource
    Friend WithEvents GroepTableAdapter As DS_ProductTableAdapters.GroepTableAdapter
    Friend WithEvents DSProductBindingSource As BindingSource
    Friend WithEvents MerkBindingSource As BindingSource
    Friend WithEvents MerkTableAdapter As DS_ProductTableAdapters.MerkTableAdapter
    Friend WithEvents Knop_ZoekProduct As Button
    Friend WithEvents LBL_PN As Label
    Friend WithEvents TXT_Productnummer As TextBox
    Friend WithEvents GBOX_Velden As GroupBox
    Friend WithEvents TXT_Naam As TextBox
    Friend WithEvents TXT_functie As TextBox
    Friend WithEvents TXT_behuizing As TextBox
    Friend WithEvents TXT_waarde As TextBox
    Friend WithEvents GB_Merk As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXT_Verkoopprijs As TextBox
    Friend WithEvents TXT_Inkoopwaarde As TextBox
    Friend WithEvents TXT_Laatste_inkoop_Datum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Minimal As TextBox
    Friend WithEvents TXT_Voorraad As TextBox
    Friend WithEvents TXT_LaatsteInkoop_Waarde As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TAB_Product As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txt_Beschrijving1 As TextBox
    Friend WithEvents TXT_Beschrijving2 As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents CB_Groep As ComboBox
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents CB_Locatie As ComboBox
    Friend WithEvents LocatieBindingSource As BindingSource
    Friend WithEvents LocatieTableAdapter As DS_ProductTableAdapters.LocatieTableAdapter
    Friend WithEvents Knop_Locatie As Button
    Friend WithEvents TXT_IDP As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TXT_Locatie As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSM_Opslaan As ToolStripMenuItem
    Friend WithEvents AnnulerenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SluitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NieuwProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductWissenToolStripMenuItem As ToolStripMenuItem
End Class

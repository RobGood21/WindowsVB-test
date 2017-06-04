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
        Dim PD_WaardeLabel As System.Windows.Forms.Label
        Dim PD_FunctieLabel As System.Windows.Forms.Label
        Dim PD_BehuizingLabel As System.Windows.Forms.Label
        Dim PD_NaamLabel As System.Windows.Forms.Label
        Dim ID_GroepLabel As System.Windows.Forms.Label
        Dim PD_Buy_CostLabel As System.Windows.Forms.Label
        Dim PD_Sale_PrijsLabel As System.Windows.Forms.Label
        Dim PD_VoorraadLabel As System.Windows.Forms.Label
        Dim PD_MinimumVoorraadLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.MerkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_productTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.DT_productTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.PicturesTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.PicturesTableAdapter()
        Me.ProductInfoTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ProductInfoTableAdapter()
        Me.MerkTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.MerkTableAdapter()
        Me.GroepPDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocatieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductMutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocatieTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.LocatieTableAdapter()
        Me.GroepPDTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GroepPDTableAdapter()
        Me.ProductMutTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ProductMutTableAdapter()
        Me.TKnop_Sluiten = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tknop_Nieuw = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tknop_Opslaan = New System.Windows.Forms.ToolStripButton()
        Me.Tknop_annuleren = New System.Windows.Forms.ToolStripButton()
        Me.Tknop_Kopieer = New System.Windows.Forms.ToolStripButton()
        Me.Tknop_Delete = New System.Windows.Forms.ToolStripButton()
        Me.TS_product = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Knop_ZoekProduct = New System.Windows.Forms.Button()
        Me.TXT_Productnummer = New System.Windows.Forms.TextBox()
        Me.LBL_PN = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_waarde = New System.Windows.Forms.TextBox()
        Me.TXT_behuizing = New System.Windows.Forms.TextBox()
        Me.TXT_functie = New System.Windows.Forms.TextBox()
        Me.TXT_Naam = New System.Windows.Forms.TextBox()
        Me.GB_Merk = New System.Windows.Forms.ComboBox()
        Me.CB_Groep = New System.Windows.Forms.ComboBox()
        Me.Knop_Merk = New System.Windows.Forms.Button()
        Me.GBOX_Velden = New System.Windows.Forms.GroupBox()
        Me.TXT_Inkoopwaarde = New System.Windows.Forms.TextBox()
        Me.TXT_Verkoopprijs = New System.Windows.Forms.TextBox()
        Me.TXT_Voorraad = New System.Windows.Forms.TextBox()
        Me.TXT_Minimal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_BTW = New System.Windows.Forms.TextBox()
        Me.CB_Locatie = New System.Windows.Forms.ComboBox()
        Me.Knop_Locatie = New System.Windows.Forms.Button()
        Me.TXT_Beschrijving2 = New System.Windows.Forms.TextBox()
        Me.TXT_Locatie = New System.Windows.Forms.TextBox()
        Me.LBL_BTWperc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_prijsexBTW = New System.Windows.Forms.TextBox()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GB_Mutaties = New System.Windows.Forms.GroupBox()
        Me.Optie_mutatie_Verbuik = New System.Windows.Forms.RadioButton()
        Me.OPtie_Mutatie_Besteld = New System.Windows.Forms.RadioButton()
        Me.Optie_Mutatie_Ontvang = New System.Windows.Forms.RadioButton()
        Me.Optie_Mutatie_alles = New System.Windows.Forms.RadioButton()
        Me.DG_Mutaties = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_Naam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GP_Lijst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tpage_Product_beschrijving = New System.Windows.Forms.TabPage()
        Me.RTXT_Beschrijving = New System.Windows.Forms.RichTextBox()
        Me.TB_Product = New System.Windows.Forms.TabControl()
        Me.Tpage_Pics = New System.Windows.Forms.TabPage()
        Me.TXT_Pics_Idproduct = New System.Windows.Forms.TextBox()
        Me.PicturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GB_PicsDetail = New System.Windows.Forms.GroupBox()
        Me.Knop_Pics_Nieuw = New System.Windows.Forms.Button()
        Me.Knop_Pics_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_Pics_Opslaan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_Pics_Url = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_Pics_Tekst = New System.Windows.Forms.TextBox()
        Me.TXT_Pics_Naam = New System.Windows.Forms.TextBox()
        Me.LB_Pics = New System.Windows.Forms.ListBox()
        Me.Pic_Pic = New System.Windows.Forms.PictureBox()
        Me.TXT_Pics_ID = New System.Windows.Forms.TextBox()
        Me.Tpage_Links = New System.Windows.Forms.TabPage()
        Me.TXT_Links_IDproduct = New System.Windows.Forms.TextBox()
        Me.ProductInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXT_Links_ID = New System.Windows.Forms.TextBox()
        Me.Knop_Links_Toon = New System.Windows.Forms.Button()
        Me.GB_Links = New System.Windows.Forms.GroupBox()
        Me.Knop_Links_Nieuw = New System.Windows.Forms.Button()
        Me.Knop_Links_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_links_opslaan = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_Links_URL = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_links_tekst = New System.Windows.Forms.TextBox()
        Me.txt_Links_Naam = New System.Windows.Forms.TextBox()
        Me.LB_Links = New System.Windows.Forms.ListBox()
        Me.TXT_IDP = New System.Windows.Forms.TextBox()
        PD_WaardeLabel = New System.Windows.Forms.Label()
        PD_FunctieLabel = New System.Windows.Forms.Label()
        PD_BehuizingLabel = New System.Windows.Forms.Label()
        PD_NaamLabel = New System.Windows.Forms.Label()
        ID_GroepLabel = New System.Windows.Forms.Label()
        PD_Buy_CostLabel = New System.Windows.Forms.Label()
        PD_Sale_PrijsLabel = New System.Windows.Forms.Label()
        PD_VoorraadLabel = New System.Windows.Forms.Label()
        PD_MinimumVoorraadLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroepPDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocatieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductMutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TS_product.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBOX_Velden.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GB_Mutaties.SuspendLayout()
        CType(Me.DG_Mutaties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Product_beschrijving.SuspendLayout()
        Me.TB_Product.SuspendLayout()
        Me.Tpage_Pics.SuspendLayout()
        CType(Me.PicturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_PicsDetail.SuspendLayout()
        CType(Me.Pic_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Links.SuspendLayout()
        CType(Me.ProductInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Links.SuspendLayout()
        Me.SuspendLayout()
        '
        'PD_WaardeLabel
        '
        PD_WaardeLabel.AutoSize = True
        PD_WaardeLabel.Location = New System.Drawing.Point(27, 84)
        PD_WaardeLabel.Name = "PD_WaardeLabel"
        PD_WaardeLabel.Size = New System.Drawing.Size(53, 13)
        PD_WaardeLabel.TabIndex = 22
        PD_WaardeLabel.Text = "Waardes:"
        '
        'PD_FunctieLabel
        '
        PD_FunctieLabel.AutoSize = True
        PD_FunctieLabel.Location = New System.Drawing.Point(27, 60)
        PD_FunctieLabel.Name = "PD_FunctieLabel"
        PD_FunctieLabel.Size = New System.Drawing.Size(45, 13)
        PD_FunctieLabel.TabIndex = 20
        PD_FunctieLabel.Text = "Functie:"
        '
        'PD_BehuizingLabel
        '
        PD_BehuizingLabel.AutoSize = True
        PD_BehuizingLabel.Location = New System.Drawing.Point(27, 108)
        PD_BehuizingLabel.Name = "PD_BehuizingLabel"
        PD_BehuizingLabel.Size = New System.Drawing.Size(56, 13)
        PD_BehuizingLabel.TabIndex = 24
        PD_BehuizingLabel.Text = "Behuizing:"
        '
        'PD_NaamLabel
        '
        PD_NaamLabel.AutoSize = True
        PD_NaamLabel.Location = New System.Drawing.Point(27, 37)
        PD_NaamLabel.Name = "PD_NaamLabel"
        PD_NaamLabel.Size = New System.Drawing.Size(68, 13)
        PD_NaamLabel.TabIndex = 18
        PD_NaamLabel.Text = "Naam, code:"
        '
        'ID_GroepLabel
        '
        ID_GroepLabel.AutoSize = True
        ID_GroepLabel.Location = New System.Drawing.Point(27, 13)
        ID_GroepLabel.Name = "ID_GroepLabel"
        ID_GroepLabel.Size = New System.Drawing.Size(74, 13)
        ID_GroepLabel.TabIndex = 29
        ID_GroepLabel.Text = "Productgroep:"
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
        'PD_Sale_PrijsLabel
        '
        PD_Sale_PrijsLabel.AutoSize = True
        PD_Sale_PrijsLabel.Location = New System.Drawing.Point(32, 21)
        PD_Sale_PrijsLabel.Name = "PD_Sale_PrijsLabel"
        PD_Sale_PrijsLabel.Size = New System.Drawing.Size(68, 13)
        PD_Sale_PrijsLabel.TabIndex = 22
        PD_Sale_PrijsLabel.Text = "Verkoopprijs:"
        '
        'PD_VoorraadLabel
        '
        PD_VoorraadLabel.AutoSize = True
        PD_VoorraadLabel.Location = New System.Drawing.Point(32, 89)
        PD_VoorraadLabel.Name = "PD_VoorraadLabel"
        PD_VoorraadLabel.Size = New System.Drawing.Size(56, 13)
        PD_VoorraadLabel.TabIndex = 28
        PD_VoorraadLabel.Text = "Voorraad: "
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
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(32, 113)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 13)
        Label1.TabIndex = 38
        Label1.Text = "Lokatie:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(32, 139)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(70, 13)
        Label2.TabIndex = 41
        Label2.Text = "Omschrijving:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(180, 42)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(71, 13)
        Label3.TabIndex = 45
        Label3.Text = "Prijs ex.BTW:"
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
        Me.TableAdapterManager.DT_productTableAdapter = Me.DT_productTableAdapter
        Me.TableAdapterManager.GetOntvangstTableAdapter = Nothing
        Me.TableAdapterManager.GetProductAddTableAdapter = Nothing
        Me.TableAdapterManager.GPA_AantalTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.LocatieHolderTableAdapter = Nothing
        Me.TableAdapterManager.LocatieTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.PicturesTableAdapter = Me.PicturesTableAdapter
        Me.TableAdapterManager.ProductInfoTableAdapter = Me.ProductInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'PicturesTableAdapter
        '
        Me.PicturesTableAdapter.ClearBeforeFill = True
        '
        'ProductInfoTableAdapter
        '
        Me.ProductInfoTableAdapter.ClearBeforeFill = True
        '
        'MerkTableAdapter
        '
        Me.MerkTableAdapter.ClearBeforeFill = True
        '
        'GroepPDBindingSource
        '
        Me.GroepPDBindingSource.DataMember = "GroepPD"
        Me.GroepPDBindingSource.DataSource = Me.DS_Product
        '
        'LocatieBindingSource
        '
        Me.LocatieBindingSource.DataMember = "Locatie"
        Me.LocatieBindingSource.DataSource = Me.DS_Product
        '
        'ProductMutBindingSource
        '
        Me.ProductMutBindingSource.DataMember = "ProductMut"
        Me.ProductMutBindingSource.DataSource = Me.DS_Product
        '
        'LocatieTableAdapter
        '
        Me.LocatieTableAdapter.ClearBeforeFill = True
        '
        'GroepPDTableAdapter
        '
        Me.GroepPDTableAdapter.ClearBeforeFill = True
        '
        'ProductMutTableAdapter
        '
        Me.ProductMutTableAdapter.ClearBeforeFill = True
        '
        'TKnop_Sluiten
        '
        Me.TKnop_Sluiten.Image = Global.WindowsVB_test.My.Resources.Resources.close_icon
        Me.TKnop_Sluiten.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TKnop_Sluiten.Name = "TKnop_Sluiten"
        Me.TKnop_Sluiten.Size = New System.Drawing.Size(63, 22)
        Me.TKnop_Sluiten.Text = "Sluiten"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tknop_Nieuw
        '
        Me.Tknop_Nieuw.Image = Global.WindowsVB_test.My.Resources.Resources.Button_Add_icon
        Me.Tknop_Nieuw.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_Nieuw.Name = "Tknop_Nieuw"
        Me.Tknop_Nieuw.Size = New System.Drawing.Size(106, 22)
        Me.Tknop_Nieuw.Text = "Nieuw Product"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tknop_Opslaan
        '
        Me.Tknop_Opslaan.Image = Global.WindowsVB_test.My.Resources.Resources.Save_as_icon
        Me.Tknop_Opslaan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_Opslaan.Name = "Tknop_Opslaan"
        Me.Tknop_Opslaan.Size = New System.Drawing.Size(70, 22)
        Me.Tknop_Opslaan.Text = "Opslaan"
        '
        'Tknop_annuleren
        '
        Me.Tknop_annuleren.Image = Global.WindowsVB_test.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.Tknop_annuleren.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_annuleren.Name = "Tknop_annuleren"
        Me.Tknop_annuleren.Size = New System.Drawing.Size(82, 22)
        Me.Tknop_annuleren.Text = "Annuleren"
        '
        'Tknop_Kopieer
        '
        Me.Tknop_Kopieer.Image = Global.WindowsVB_test.My.Resources.Resources.copy_icon
        Me.Tknop_Kopieer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_Kopieer.Name = "Tknop_Kopieer"
        Me.Tknop_Kopieer.Size = New System.Drawing.Size(112, 22)
        Me.Tknop_Kopieer.Text = "Kopieer Product"
        '
        'Tknop_Delete
        '
        Me.Tknop_Delete.Image = Global.WindowsVB_test.My.Resources.Resources.Windows_Close_Program_icon
        Me.Tknop_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tknop_Delete.Name = "Tknop_Delete"
        Me.Tknop_Delete.Size = New System.Drawing.Size(105, 22)
        Me.Tknop_Delete.Text = "Delete Product"
        '
        'TS_product
        '
        Me.TS_product.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TKnop_Sluiten, Me.ToolStripSeparator1, Me.Tknop_Nieuw, Me.ToolStripSeparator2, Me.Tknop_Opslaan, Me.ToolStripSeparator3, Me.Tknop_annuleren, Me.ToolStripSeparator4, Me.Tknop_Kopieer, Me.ToolStripSeparator5, Me.Tknop_Delete, Me.ToolStripSeparator6})
        Me.TS_product.Location = New System.Drawing.Point(0, 0)
        Me.TS_product.Name = "TS_product"
        Me.TS_product.Size = New System.Drawing.Size(714, 25)
        Me.TS_product.TabIndex = 204
        Me.TS_product.Text = "ToolStrip1"
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
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
        'TXT_Productnummer
        '
        Me.TXT_Productnummer.Location = New System.Drawing.Point(102, 24)
        Me.TXT_Productnummer.Name = "TXT_Productnummer"
        Me.TXT_Productnummer.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Productnummer.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_PN)
        Me.GroupBox1.Controls.Add(Me.TXT_Productnummer)
        Me.GroupBox1.Controls.Add(Me.Knop_ZoekProduct)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 58)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product"
        '
        'TXT_waarde
        '
        Me.TXT_waarde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Waarde", True))
        Me.TXT_waarde.Location = New System.Drawing.Point(102, 83)
        Me.TXT_waarde.Name = "TXT_waarde"
        Me.TXT_waarde.Size = New System.Drawing.Size(184, 20)
        Me.TXT_waarde.TabIndex = 2
        '
        'TXT_behuizing
        '
        Me.TXT_behuizing.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Behuizing", True))
        Me.TXT_behuizing.Location = New System.Drawing.Point(102, 107)
        Me.TXT_behuizing.Name = "TXT_behuizing"
        Me.TXT_behuizing.Size = New System.Drawing.Size(185, 20)
        Me.TXT_behuizing.TabIndex = 3
        '
        'TXT_functie
        '
        Me.TXT_functie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Functie", True))
        Me.TXT_functie.Location = New System.Drawing.Point(102, 59)
        Me.TXT_functie.Name = "TXT_functie"
        Me.TXT_functie.Size = New System.Drawing.Size(184, 20)
        Me.TXT_functie.TabIndex = 1
        '
        'TXT_Naam
        '
        Me.TXT_Naam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Naam", True))
        Me.TXT_Naam.Location = New System.Drawing.Point(102, 36)
        Me.TXT_Naam.Name = "TXT_Naam"
        Me.TXT_Naam.Size = New System.Drawing.Size(184, 20)
        Me.TXT_Naam.TabIndex = 1
        '
        'GB_Merk
        '
        Me.GB_Merk.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_productBindingSource, "ID_Merk", True))
        Me.GB_Merk.DataSource = Me.MerkBindingSource
        Me.GB_Merk.DisplayMember = "MK_MerkNaam"
        Me.GB_Merk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GB_Merk.FormattingEnabled = True
        Me.GB_Merk.Location = New System.Drawing.Point(102, 131)
        Me.GB_Merk.Name = "GB_Merk"
        Me.GB_Merk.Size = New System.Drawing.Size(184, 21)
        Me.GB_Merk.TabIndex = 4
        Me.GB_Merk.ValueMember = "ID_Merk"
        '
        'CB_Groep
        '
        Me.CB_Groep.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_productBindingSource, "ID_Groep", True))
        Me.CB_Groep.DataSource = Me.GroepPDBindingSource
        Me.CB_Groep.DisplayMember = "GP_Naam"
        Me.CB_Groep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Groep.FormattingEnabled = True
        Me.CB_Groep.Location = New System.Drawing.Point(102, 9)
        Me.CB_Groep.Name = "CB_Groep"
        Me.CB_Groep.Size = New System.Drawing.Size(184, 21)
        Me.CB_Groep.TabIndex = 0
        Me.CB_Groep.ValueMember = "ID_Groep"
        '
        'Knop_Merk
        '
        Me.Knop_Merk.Location = New System.Drawing.Point(30, 129)
        Me.Knop_Merk.Name = "Knop_Merk"
        Me.Knop_Merk.Size = New System.Drawing.Size(63, 23)
        Me.Knop_Merk.TabIndex = 47
        Me.Knop_Merk.TabStop = False
        Me.Knop_Merk.Text = "Merk:"
        Me.Knop_Merk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Knop_Merk.UseVisualStyleBackColor = True
        '
        'GBOX_Velden
        '
        Me.GBOX_Velden.Controls.Add(Me.Knop_Merk)
        Me.GBOX_Velden.Controls.Add(Me.CB_Groep)
        Me.GBOX_Velden.Controls.Add(ID_GroepLabel)
        Me.GBOX_Velden.Controls.Add(Me.GB_Merk)
        Me.GBOX_Velden.Controls.Add(Me.TXT_Naam)
        Me.GBOX_Velden.Controls.Add(PD_NaamLabel)
        Me.GBOX_Velden.Controls.Add(PD_BehuizingLabel)
        Me.GBOX_Velden.Controls.Add(Me.TXT_functie)
        Me.GBOX_Velden.Controls.Add(Me.TXT_behuizing)
        Me.GBOX_Velden.Controls.Add(PD_FunctieLabel)
        Me.GBOX_Velden.Controls.Add(PD_WaardeLabel)
        Me.GBOX_Velden.Controls.Add(Me.TXT_waarde)
        Me.GBOX_Velden.Location = New System.Drawing.Point(12, 92)
        Me.GBOX_Velden.Name = "GBOX_Velden"
        Me.GBOX_Velden.Size = New System.Drawing.Size(315, 164)
        Me.GBOX_Velden.TabIndex = 201
        Me.GBOX_Velden.TabStop = False
        '
        'TXT_Inkoopwaarde
        '
        Me.TXT_Inkoopwaarde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Buy_Cost", True))
        Me.TXT_Inkoopwaarde.Location = New System.Drawing.Point(254, 17)
        Me.TXT_Inkoopwaarde.Name = "TXT_Inkoopwaarde"
        Me.TXT_Inkoopwaarde.Size = New System.Drawing.Size(54, 20)
        Me.TXT_Inkoopwaarde.TabIndex = 6
        '
        'TXT_Verkoopprijs
        '
        Me.TXT_Verkoopprijs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Sale_Prijs", True))
        Me.TXT_Verkoopprijs.Location = New System.Drawing.Point(102, 17)
        Me.TXT_Verkoopprijs.Name = "TXT_Verkoopprijs"
        Me.TXT_Verkoopprijs.Size = New System.Drawing.Size(54, 20)
        Me.TXT_Verkoopprijs.TabIndex = 5
        '
        'TXT_Voorraad
        '
        Me.TXT_Voorraad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.TXT_Voorraad.Location = New System.Drawing.Point(102, 86)
        Me.TXT_Voorraad.Name = "TXT_Voorraad"
        Me.TXT_Voorraad.Size = New System.Drawing.Size(34, 20)
        Me.TXT_Voorraad.TabIndex = 29
        '
        'TXT_Minimal
        '
        Me.TXT_Minimal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_MinimumVoorraad", True))
        Me.TXT_Minimal.Location = New System.Drawing.Point(199, 86)
        Me.TXT_Minimal.Name = "TXT_Minimal"
        Me.TXT_Minimal.Size = New System.Drawing.Size(34, 20)
        Me.TXT_Minimal.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "BTW"
        '
        'TXT_BTW
        '
        Me.TXT_BTW.Location = New System.Drawing.Point(102, 38)
        Me.TXT_BTW.Name = "TXT_BTW"
        Me.TXT_BTW.ReadOnly = True
        Me.TXT_BTW.Size = New System.Drawing.Size(54, 20)
        Me.TXT_BTW.TabIndex = 35
        Me.TXT_BTW.TabStop = False
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
        'TXT_Locatie
        '
        Me.TXT_Locatie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieBindingSource, "LK_Code", True))
        Me.TXT_Locatie.Location = New System.Drawing.Point(102, 110)
        Me.TXT_Locatie.Name = "TXT_Locatie"
        Me.TXT_Locatie.Size = New System.Drawing.Size(131, 20)
        Me.TXT_Locatie.TabIndex = 42
        Me.TXT_Locatie.TabStop = False
        '
        'LBL_BTWperc
        '
        Me.LBL_BTWperc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepPDBindingSource, "BTW_Perc", True))
        Me.LBL_BTWperc.Location = New System.Drawing.Point(64, 42)
        Me.LBL_BTWperc.Name = "LBL_BTWperc"
        Me.LBL_BTWperc.Size = New System.Drawing.Size(20, 13)
        Me.LBL_BTWperc.TabIndex = 43
        Me.LBL_BTWperc.Text = "00"
        Me.LBL_BTWperc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "% :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXT_prijsexBTW
        '
        Me.TXT_prijsexBTW.Location = New System.Drawing.Point(254, 38)
        Me.TXT_prijsexBTW.Name = "TXT_prijsexBTW"
        Me.TXT_prijsexBTW.ReadOnly = True
        Me.TXT_prijsexBTW.Size = New System.Drawing.Size(54, 20)
        Me.TXT_prijsexBTW.TabIndex = 46
        Me.TXT_prijsexBTW.TabStop = False
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(245, 196)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(106, 23)
        Me.Knop_Opslaan.TabIndex = 41
        Me.Knop_Opslaan.Text = "&Opslaan en Sluiten"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Knop_Opslaan)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.TXT_prijsexBTW)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.LBL_BTWperc)
        Me.GroupBox3.Controls.Add(Me.TXT_Locatie)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.TXT_Beschrijving2)
        Me.GroupBox3.Controls.Add(Me.Knop_Locatie)
        Me.GroupBox3.Controls.Add(Me.CB_Locatie)
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.TXT_BTW)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(PD_MinimumVoorraadLabel)
        Me.GroupBox3.Controls.Add(Me.TXT_Minimal)
        Me.GroupBox3.Controls.Add(PD_VoorraadLabel)
        Me.GroupBox3.Controls.Add(Me.TXT_Voorraad)
        Me.GroupBox3.Controls.Add(PD_Sale_PrijsLabel)
        Me.GroupBox3.Controls.Add(Me.TXT_Verkoopprijs)
        Me.GroupBox3.Controls.Add(Me.TXT_Inkoopwaarde)
        Me.GroupBox3.Controls.Add(PD_Buy_CostLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(333, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 228)
        Me.GroupBox3.TabIndex = 202
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prijzen"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GB_Mutaties)
        Me.TabPage2.Controls.Add(Me.DG_Mutaties)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(681, 283)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mutaties voorraad"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GB_Mutaties
        '
        Me.GB_Mutaties.Controls.Add(Me.Optie_mutatie_Verbuik)
        Me.GB_Mutaties.Controls.Add(Me.OPtie_Mutatie_Besteld)
        Me.GB_Mutaties.Controls.Add(Me.Optie_Mutatie_Ontvang)
        Me.GB_Mutaties.Controls.Add(Me.Optie_Mutatie_alles)
        Me.GB_Mutaties.Location = New System.Drawing.Point(3, 3)
        Me.GB_Mutaties.Name = "GB_Mutaties"
        Me.GB_Mutaties.Size = New System.Drawing.Size(660, 46)
        Me.GB_Mutaties.TabIndex = 1
        Me.GB_Mutaties.TabStop = False
        '
        'Optie_mutatie_Verbuik
        '
        Me.Optie_mutatie_Verbuik.Appearance = System.Windows.Forms.Appearance.Button
        Me.Optie_mutatie_Verbuik.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Optie_mutatie_Verbuik.Location = New System.Drawing.Point(363, 15)
        Me.Optie_mutatie_Verbuik.Name = "Optie_mutatie_Verbuik"
        Me.Optie_mutatie_Verbuik.Size = New System.Drawing.Size(120, 23)
        Me.Optie_mutatie_Verbuik.TabIndex = 304
        Me.Optie_mutatie_Verbuik.Tag = "4"
        Me.Optie_mutatie_Verbuik.Text = "Verbruik, verkoop"
        Me.Optie_mutatie_Verbuik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Optie_mutatie_Verbuik.UseVisualStyleBackColor = True
        '
        'OPtie_Mutatie_Besteld
        '
        Me.OPtie_Mutatie_Besteld.Appearance = System.Windows.Forms.Appearance.Button
        Me.OPtie_Mutatie_Besteld.Checked = True
        Me.OPtie_Mutatie_Besteld.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.OPtie_Mutatie_Besteld.Location = New System.Drawing.Point(125, 15)
        Me.OPtie_Mutatie_Besteld.Name = "OPtie_Mutatie_Besteld"
        Me.OPtie_Mutatie_Besteld.Size = New System.Drawing.Size(120, 23)
        Me.OPtie_Mutatie_Besteld.TabIndex = 301
        Me.OPtie_Mutatie_Besteld.TabStop = True
        Me.OPtie_Mutatie_Besteld.Tag = "2"
        Me.OPtie_Mutatie_Besteld.Text = "In Bestelling"
        Me.OPtie_Mutatie_Besteld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OPtie_Mutatie_Besteld.UseVisualStyleBackColor = True
        '
        'Optie_Mutatie_Ontvang
        '
        Me.Optie_Mutatie_Ontvang.Appearance = System.Windows.Forms.Appearance.Button
        Me.Optie_Mutatie_Ontvang.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Optie_Mutatie_Ontvang.Location = New System.Drawing.Point(244, 15)
        Me.Optie_Mutatie_Ontvang.Name = "Optie_Mutatie_Ontvang"
        Me.Optie_Mutatie_Ontvang.Size = New System.Drawing.Size(120, 23)
        Me.Optie_Mutatie_Ontvang.TabIndex = 303
        Me.Optie_Mutatie_Ontvang.Tag = "3"
        Me.Optie_Mutatie_Ontvang.Text = "Ontvangen"
        Me.Optie_Mutatie_Ontvang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Optie_Mutatie_Ontvang.UseVisualStyleBackColor = True
        '
        'Optie_Mutatie_alles
        '
        Me.Optie_Mutatie_alles.Appearance = System.Windows.Forms.Appearance.Button
        Me.Optie_Mutatie_alles.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Optie_Mutatie_alles.Location = New System.Drawing.Point(6, 15)
        Me.Optie_Mutatie_alles.Name = "Optie_Mutatie_alles"
        Me.Optie_Mutatie_alles.Size = New System.Drawing.Size(120, 23)
        Me.Optie_Mutatie_alles.TabIndex = 300
        Me.Optie_Mutatie_alles.Tag = "1"
        Me.Optie_Mutatie_alles.Text = "Alles tonen"
        Me.Optie_Mutatie_alles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Optie_Mutatie_alles.UseVisualStyleBackColor = True
        '
        'DG_Mutaties
        '
        Me.DG_Mutaties.AllowUserToAddRows = False
        Me.DG_Mutaties.AllowUserToDeleteRows = False
        Me.DG_Mutaties.AutoGenerateColumns = False
        Me.DG_Mutaties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Mutaties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.GV_Naam, Me.DataGridViewTextBoxColumn4, Me.GP_Lijst, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DG_Mutaties.DataSource = Me.ProductMutBindingSource
        Me.DG_Mutaties.Location = New System.Drawing.Point(6, 55)
        Me.DG_Mutaties.MultiSelect = False
        Me.DG_Mutaties.Name = "DG_Mutaties"
        Me.DG_Mutaties.ReadOnly = True
        Me.DG_Mutaties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Mutaties.Size = New System.Drawing.Size(669, 206)
        Me.DG_Mutaties.TabIndex = 0
        Me.DG_Mutaties.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Product"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_GetOntvangst"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_GetOntvangst"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GV_Status"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GV_Status"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'GV_Naam
        '
        Me.GV_Naam.DataPropertyName = "GV_Naam"
        Me.GV_Naam.HeaderText = "LijstNaam"
        Me.GV_Naam.Name = "GV_Naam"
        Me.GV_Naam.ReadOnly = True
        Me.GV_Naam.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "GV_Datum"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'GP_Lijst
        '
        Me.GP_Lijst.DataPropertyName = "GP_Lijst"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GP_Lijst.DefaultCellStyle = DataGridViewCellStyle9
        Me.GP_Lijst.HeaderText = "Aantal"
        Me.GP_Lijst.Name = "GP_Lijst"
        Me.GP_Lijst.ReadOnly = True
        Me.GP_Lijst.Width = 65
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "GP__Ontvangen"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ontvangen"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "GP_Besteld"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn6.HeaderText = "Backorder"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 65
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "GP_BuyPriceEUR"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn7.HeaderText = "Inkoop"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SP_Naam"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SH_Naam"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Shop"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'Tpage_Product_beschrijving
        '
        Me.Tpage_Product_beschrijving.Controls.Add(Me.RTXT_Beschrijving)
        Me.Tpage_Product_beschrijving.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Product_beschrijving.Name = "Tpage_Product_beschrijving"
        Me.Tpage_Product_beschrijving.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Product_beschrijving.Size = New System.Drawing.Size(681, 283)
        Me.Tpage_Product_beschrijving.TabIndex = 2
        Me.Tpage_Product_beschrijving.Text = "Beschrijving product"
        Me.Tpage_Product_beschrijving.UseVisualStyleBackColor = True
        '
        'RTXT_Beschrijving
        '
        Me.RTXT_Beschrijving.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Beschrijving(1)", True))
        Me.RTXT_Beschrijving.Location = New System.Drawing.Point(11, 6)
        Me.RTXT_Beschrijving.Name = "RTXT_Beschrijving"
        Me.RTXT_Beschrijving.Size = New System.Drawing.Size(664, 271)
        Me.RTXT_Beschrijving.TabIndex = 0
        Me.RTXT_Beschrijving.Text = ""
        '
        'TB_Product
        '
        Me.TB_Product.Controls.Add(Me.Tpage_Product_beschrijving)
        Me.TB_Product.Controls.Add(Me.TabPage2)
        Me.TB_Product.Controls.Add(Me.Tpage_Pics)
        Me.TB_Product.Controls.Add(Me.Tpage_Links)
        Me.TB_Product.Location = New System.Drawing.Point(12, 262)
        Me.TB_Product.Name = "TB_Product"
        Me.TB_Product.SelectedIndex = 0
        Me.TB_Product.Size = New System.Drawing.Size(689, 309)
        Me.TB_Product.TabIndex = 203
        '
        'Tpage_Pics
        '
        Me.Tpage_Pics.Controls.Add(Me.TXT_Pics_Idproduct)
        Me.Tpage_Pics.Controls.Add(Me.Label9)
        Me.Tpage_Pics.Controls.Add(Me.GB_PicsDetail)
        Me.Tpage_Pics.Controls.Add(Me.LB_Pics)
        Me.Tpage_Pics.Controls.Add(Me.Pic_Pic)
        Me.Tpage_Pics.Controls.Add(Me.TXT_Pics_ID)
        Me.Tpage_Pics.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Pics.Name = "Tpage_Pics"
        Me.Tpage_Pics.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Pics.Size = New System.Drawing.Size(681, 283)
        Me.Tpage_Pics.TabIndex = 3
        Me.Tpage_Pics.Text = "Afbeeldingen"
        Me.Tpage_Pics.UseVisualStyleBackColor = True
        '
        'TXT_Pics_Idproduct
        '
        Me.TXT_Pics_Idproduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PicturesBindingSource, "ID_Product", True))
        Me.TXT_Pics_Idproduct.Location = New System.Drawing.Point(636, 32)
        Me.TXT_Pics_Idproduct.Name = "TXT_Pics_Idproduct"
        Me.TXT_Pics_Idproduct.ReadOnly = True
        Me.TXT_Pics_Idproduct.Size = New System.Drawing.Size(39, 20)
        Me.TXT_Pics_Idproduct.TabIndex = 47
        Me.TXT_Pics_Idproduct.TabStop = False
        Me.TXT_Pics_Idproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PicturesBindingSource
        '
        Me.PicturesBindingSource.DataMember = "Pictures"
        Me.PicturesBindingSource.DataSource = Me.DS_Product
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Afbeelding:"
        '
        'GB_PicsDetail
        '
        Me.GB_PicsDetail.Controls.Add(Me.Knop_Pics_Nieuw)
        Me.GB_PicsDetail.Controls.Add(Me.Knop_Pics_Annuleren)
        Me.GB_PicsDetail.Controls.Add(Me.Knop_Pics_Opslaan)
        Me.GB_PicsDetail.Controls.Add(Me.Label8)
        Me.GB_PicsDetail.Controls.Add(Me.TXT_Pics_Url)
        Me.GB_PicsDetail.Controls.Add(Me.Label7)
        Me.GB_PicsDetail.Controls.Add(Me.Label6)
        Me.GB_PicsDetail.Controls.Add(Me.TXT_Pics_Tekst)
        Me.GB_PicsDetail.Controls.Add(Me.TXT_Pics_Naam)
        Me.GB_PicsDetail.Location = New System.Drawing.Point(11, 107)
        Me.GB_PicsDetail.Name = "GB_PicsDetail"
        Me.GB_PicsDetail.Size = New System.Drawing.Size(272, 170)
        Me.GB_PicsDetail.TabIndex = 2
        Me.GB_PicsDetail.TabStop = False
        '
        'Knop_Pics_Nieuw
        '
        Me.Knop_Pics_Nieuw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Knop_Pics_Nieuw.Location = New System.Drawing.Point(11, 139)
        Me.Knop_Pics_Nieuw.Name = "Knop_Pics_Nieuw"
        Me.Knop_Pics_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Pics_Nieuw.TabIndex = 9
        Me.Knop_Pics_Nieuw.TabStop = False
        Me.Knop_Pics_Nieuw.Text = "Nieuw"
        Me.Knop_Pics_Nieuw.UseVisualStyleBackColor = True
        '
        'Knop_Pics_Annuleren
        '
        Me.Knop_Pics_Annuleren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Knop_Pics_Annuleren.Location = New System.Drawing.Point(88, 139)
        Me.Knop_Pics_Annuleren.Name = "Knop_Pics_Annuleren"
        Me.Knop_Pics_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Pics_Annuleren.TabIndex = 8
        Me.Knop_Pics_Annuleren.TabStop = False
        Me.Knop_Pics_Annuleren.Text = "Annuleren"
        Me.Knop_Pics_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_Pics_Opslaan
        '
        Me.Knop_Pics_Opslaan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Knop_Pics_Opslaan.Location = New System.Drawing.Point(174, 139)
        Me.Knop_Pics_Opslaan.Name = "Knop_Pics_Opslaan"
        Me.Knop_Pics_Opslaan.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Pics_Opslaan.TabIndex = 7
        Me.Knop_Pics_Opslaan.TabStop = False
        Me.Knop_Pics_Opslaan.Text = "Opslaan"
        Me.Knop_Pics_Opslaan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "URL:"
        '
        'TXT_Pics_Url
        '
        Me.TXT_Pics_Url.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PicturesBindingSource, "Pic_URL", True))
        Me.TXT_Pics_Url.Location = New System.Drawing.Point(50, 89)
        Me.TXT_Pics_Url.Multiline = True
        Me.TXT_Pics_Url.Name = "TXT_Pics_Url"
        Me.TXT_Pics_Url.Size = New System.Drawing.Size(200, 34)
        Me.TXT_Pics_Url.TabIndex = 223
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tekst:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Naam:"
        '
        'TXT_Pics_Tekst
        '
        Me.TXT_Pics_Tekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PicturesBindingSource, "Pic_Tekst", True))
        Me.TXT_Pics_Tekst.Location = New System.Drawing.Point(50, 37)
        Me.TXT_Pics_Tekst.Multiline = True
        Me.TXT_Pics_Tekst.Name = "TXT_Pics_Tekst"
        Me.TXT_Pics_Tekst.Size = New System.Drawing.Size(200, 51)
        Me.TXT_Pics_Tekst.TabIndex = 222
        '
        'TXT_Pics_Naam
        '
        Me.TXT_Pics_Naam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PicturesBindingSource, "Pic_Naam", True))
        Me.TXT_Pics_Naam.Location = New System.Drawing.Point(50, 16)
        Me.TXT_Pics_Naam.Name = "TXT_Pics_Naam"
        Me.TXT_Pics_Naam.Size = New System.Drawing.Size(200, 20)
        Me.TXT_Pics_Naam.TabIndex = 221
        '
        'LB_Pics
        '
        Me.LB_Pics.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PicturesBindingSource, "ID_Picture", True))
        Me.LB_Pics.DataSource = Me.PicturesBindingSource
        Me.LB_Pics.DisplayMember = "Pic_Naam"
        Me.LB_Pics.FormattingEnabled = True
        Me.LB_Pics.Location = New System.Drawing.Point(61, 6)
        Me.LB_Pics.Name = "LB_Pics"
        Me.LB_Pics.Size = New System.Drawing.Size(200, 95)
        Me.LB_Pics.TabIndex = 220
        Me.LB_Pics.ValueMember = "ID_Picture"
        '
        'Pic_Pic
        '
        Me.Pic_Pic.ImageLocation = ""
        Me.Pic_Pic.Location = New System.Drawing.Point(316, 6)
        Me.Pic_Pic.Name = "Pic_Pic"
        Me.Pic_Pic.Size = New System.Drawing.Size(306, 271)
        Me.Pic_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Pic.TabIndex = 0
        Me.Pic_Pic.TabStop = False
        '
        'TXT_Pics_ID
        '
        Me.TXT_Pics_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PicturesBindingSource, "ID_Picture", True))
        Me.TXT_Pics_ID.Location = New System.Drawing.Point(636, 6)
        Me.TXT_Pics_ID.Name = "TXT_Pics_ID"
        Me.TXT_Pics_ID.ReadOnly = True
        Me.TXT_Pics_ID.Size = New System.Drawing.Size(39, 20)
        Me.TXT_Pics_ID.TabIndex = 0
        Me.TXT_Pics_ID.TabStop = False
        Me.TXT_Pics_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tpage_Links
        '
        Me.Tpage_Links.Controls.Add(Me.TXT_Links_IDproduct)
        Me.Tpage_Links.Controls.Add(Me.TXT_Links_ID)
        Me.Tpage_Links.Controls.Add(Me.Knop_Links_Toon)
        Me.Tpage_Links.Controls.Add(Me.GB_Links)
        Me.Tpage_Links.Controls.Add(Me.LB_Links)
        Me.Tpage_Links.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Links.Name = "Tpage_Links"
        Me.Tpage_Links.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Links.Size = New System.Drawing.Size(681, 283)
        Me.Tpage_Links.TabIndex = 4
        Me.Tpage_Links.Text = "Info op internet"
        Me.Tpage_Links.UseVisualStyleBackColor = True
        '
        'TXT_Links_IDproduct
        '
        Me.TXT_Links_IDproduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductInfoBindingSource, "ID_Product", True))
        Me.TXT_Links_IDproduct.Location = New System.Drawing.Point(629, 13)
        Me.TXT_Links_IDproduct.Name = "TXT_Links_IDproduct"
        Me.TXT_Links_IDproduct.ReadOnly = True
        Me.TXT_Links_IDproduct.Size = New System.Drawing.Size(39, 20)
        Me.TXT_Links_IDproduct.TabIndex = 49
        Me.TXT_Links_IDproduct.TabStop = False
        Me.TXT_Links_IDproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductInfoBindingSource
        '
        Me.ProductInfoBindingSource.DataMember = "ProductInfo"
        Me.ProductInfoBindingSource.DataSource = Me.DS_Product
        '
        'TXT_Links_ID
        '
        Me.TXT_Links_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductInfoBindingSource, "id_productinfo", True))
        Me.TXT_Links_ID.Location = New System.Drawing.Point(584, 13)
        Me.TXT_Links_ID.Name = "TXT_Links_ID"
        Me.TXT_Links_ID.ReadOnly = True
        Me.TXT_Links_ID.Size = New System.Drawing.Size(39, 20)
        Me.TXT_Links_ID.TabIndex = 48
        Me.TXT_Links_ID.TabStop = False
        Me.TXT_Links_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Knop_Links_Toon
        '
        Me.Knop_Links_Toon.Location = New System.Drawing.Point(370, 45)
        Me.Knop_Links_Toon.Name = "Knop_Links_Toon"
        Me.Knop_Links_Toon.Size = New System.Drawing.Size(298, 40)
        Me.Knop_Links_Toon.TabIndex = 2
        Me.Knop_Links_Toon.Text = "Open Link in Webbrowser"
        Me.Knop_Links_Toon.UseVisualStyleBackColor = True
        '
        'GB_Links
        '
        Me.GB_Links.Controls.Add(Me.Knop_Links_Nieuw)
        Me.GB_Links.Controls.Add(Me.Knop_Links_Annuleren)
        Me.GB_Links.Controls.Add(Me.Knop_links_opslaan)
        Me.GB_Links.Controls.Add(Me.Label10)
        Me.GB_Links.Controls.Add(Me.TXT_Links_URL)
        Me.GB_Links.Controls.Add(Me.Label11)
        Me.GB_Links.Controls.Add(Me.Label12)
        Me.GB_Links.Controls.Add(Me.TXT_links_tekst)
        Me.GB_Links.Controls.Add(Me.txt_Links_Naam)
        Me.GB_Links.Location = New System.Drawing.Point(317, 96)
        Me.GB_Links.Name = "GB_Links"
        Me.GB_Links.Size = New System.Drawing.Size(351, 177)
        Me.GB_Links.TabIndex = 1
        Me.GB_Links.TabStop = False
        '
        'Knop_Links_Nieuw
        '
        Me.Knop_Links_Nieuw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Knop_Links_Nieuw.Location = New System.Drawing.Point(54, 138)
        Me.Knop_Links_Nieuw.Name = "Knop_Links_Nieuw"
        Me.Knop_Links_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Links_Nieuw.TabIndex = 229
        Me.Knop_Links_Nieuw.TabStop = False
        Me.Knop_Links_Nieuw.Text = "Nieuw"
        Me.Knop_Links_Nieuw.UseVisualStyleBackColor = True
        '
        'Knop_Links_Annuleren
        '
        Me.Knop_Links_Annuleren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Knop_Links_Annuleren.Location = New System.Drawing.Point(131, 138)
        Me.Knop_Links_Annuleren.Name = "Knop_Links_Annuleren"
        Me.Knop_Links_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Links_Annuleren.TabIndex = 228
        Me.Knop_Links_Annuleren.TabStop = False
        Me.Knop_Links_Annuleren.Text = "Annuleren"
        Me.Knop_Links_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_links_opslaan
        '
        Me.Knop_links_opslaan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Knop_links_opslaan.Location = New System.Drawing.Point(270, 138)
        Me.Knop_links_opslaan.Name = "Knop_links_opslaan"
        Me.Knop_links_opslaan.Size = New System.Drawing.Size(75, 23)
        Me.Knop_links_opslaan.TabIndex = 227
        Me.Knop_links_opslaan.TabStop = False
        Me.Knop_links_opslaan.Text = "Opslaan"
        Me.Knop_links_opslaan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 226
        Me.Label10.Text = "URL:"
        '
        'TXT_Links_URL
        '
        Me.TXT_Links_URL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductInfoBindingSource, "PI_URL", True))
        Me.TXT_Links_URL.Location = New System.Drawing.Point(53, 88)
        Me.TXT_Links_URL.Multiline = True
        Me.TXT_Links_URL.Name = "TXT_Links_URL"
        Me.TXT_Links_URL.Size = New System.Drawing.Size(292, 34)
        Me.TXT_Links_URL.TabIndex = 232
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 225
        Me.Label11.Text = "Tekst:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 224
        Me.Label12.Text = "Naam:"
        '
        'TXT_links_tekst
        '
        Me.TXT_links_tekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductInfoBindingSource, "PI_Tekst", True))
        Me.TXT_links_tekst.Location = New System.Drawing.Point(53, 36)
        Me.TXT_links_tekst.Multiline = True
        Me.TXT_links_tekst.Name = "TXT_links_tekst"
        Me.TXT_links_tekst.Size = New System.Drawing.Size(292, 51)
        Me.TXT_links_tekst.TabIndex = 231
        '
        'txt_Links_Naam
        '
        Me.txt_Links_Naam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductInfoBindingSource, "PI_Naam", True))
        Me.txt_Links_Naam.Location = New System.Drawing.Point(53, 15)
        Me.txt_Links_Naam.Name = "txt_Links_Naam"
        Me.txt_Links_Naam.Size = New System.Drawing.Size(292, 20)
        Me.txt_Links_Naam.TabIndex = 230
        '
        'LB_Links
        '
        Me.LB_Links.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductInfoBindingSource, "id_productinfo", True))
        Me.LB_Links.DataSource = Me.ProductInfoBindingSource
        Me.LB_Links.DisplayMember = "PI_Naam"
        Me.LB_Links.FormattingEnabled = True
        Me.LB_Links.Location = New System.Drawing.Point(14, 9)
        Me.LB_Links.Name = "LB_Links"
        Me.LB_Links.Size = New System.Drawing.Size(297, 264)
        Me.LB_Links.TabIndex = 0
        Me.LB_Links.ValueMember = "id_productinfo"
        '
        'TXT_IDP
        '
        Me.TXT_IDP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "ID_Product", True))
        Me.TXT_IDP.Enabled = False
        Me.TXT_IDP.Location = New System.Drawing.Point(661, 39)
        Me.TXT_IDP.Name = "TXT_IDP"
        Me.TXT_IDP.ReadOnly = True
        Me.TXT_IDP.Size = New System.Drawing.Size(34, 20)
        Me.TXT_IDP.TabIndex = 41
        Me.TXT_IDP.TabStop = False
        '
        'F_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 624)
        Me.Controls.Add(Me.TS_product)
        Me.Controls.Add(Me.TXT_IDP)
        Me.Controls.Add(Me.TB_Product)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GBOX_Velden)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product"
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroepPDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocatieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductMutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TS_product.ResumeLayout(False)
        Me.TS_product.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBOX_Velden.ResumeLayout(False)
        Me.GBOX_Velden.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GB_Mutaties.ResumeLayout(False)
        CType(Me.DG_Mutaties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Product_beschrijving.ResumeLayout(False)
        Me.TB_Product.ResumeLayout(False)
        Me.Tpage_Pics.ResumeLayout(False)
        Me.Tpage_Pics.PerformLayout()
        CType(Me.PicturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_PicsDetail.ResumeLayout(False)
        Me.GB_PicsDetail.PerformLayout()
        CType(Me.Pic_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Links.ResumeLayout(False)
        Me.Tpage_Links.PerformLayout()
        CType(Me.ProductInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Links.ResumeLayout(False)
        Me.GB_Links.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents DT_productBindingSource As BindingSource
    Friend WithEvents DT_productTableAdapter As DS_ProductTableAdapters.DT_productTableAdapter
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents DSProductBindingSource As BindingSource
    Friend WithEvents MerkBindingSource As BindingSource
    Friend WithEvents MerkTableAdapter As DS_ProductTableAdapters.MerkTableAdapter
    Friend WithEvents LocatieBindingSource As BindingSource
    Friend WithEvents LocatieTableAdapter As DS_ProductTableAdapters.LocatieTableAdapter
    Friend WithEvents GroepPDBindingSource As BindingSource
    Friend WithEvents GroepPDTableAdapter As DS_ProductTableAdapters.GroepPDTableAdapter
    Friend WithEvents ProductMutBindingSource As BindingSource
    Friend WithEvents ProductMutTableAdapter As DS_ProductTableAdapters.ProductMutTableAdapter
    Friend WithEvents TKnop_Sluiten As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Tknop_Nieuw As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Tknop_Opslaan As ToolStripButton
    Friend WithEvents Tknop_annuleren As ToolStripButton
    Friend WithEvents Tknop_Kopieer As ToolStripButton
    Friend WithEvents Tknop_Delete As ToolStripButton
    Friend WithEvents TS_product As ToolStrip
    Friend WithEvents Knop_ZoekProduct As Button
    Friend WithEvents TXT_Productnummer As TextBox
    Friend WithEvents LBL_PN As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_waarde As TextBox
    Friend WithEvents TXT_behuizing As TextBox
    Friend WithEvents TXT_functie As TextBox
    Friend WithEvents TXT_Naam As TextBox
    Friend WithEvents GB_Merk As ComboBox
    Friend WithEvents CB_Groep As ComboBox
    Friend WithEvents Knop_Merk As Button
    Friend WithEvents GBOX_Velden As GroupBox
    Friend WithEvents TXT_Inkoopwaarde As TextBox
    Friend WithEvents TXT_Verkoopprijs As TextBox
    Friend WithEvents TXT_Voorraad As TextBox
    Friend WithEvents TXT_Minimal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_BTW As TextBox
    Friend WithEvents CB_Locatie As ComboBox
    Friend WithEvents Knop_Locatie As Button
    Friend WithEvents TXT_Beschrijving2 As TextBox
    Friend WithEvents TXT_Locatie As TextBox
    Friend WithEvents LBL_BTWperc As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_prijsexBTW As TextBox
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GB_Mutaties As GroupBox
    Friend WithEvents Optie_mutatie_Verbuik As RadioButton
    Friend WithEvents OPtie_Mutatie_Besteld As RadioButton
    Friend WithEvents Optie_Mutatie_Ontvang As RadioButton
    Friend WithEvents Optie_Mutatie_alles As RadioButton
    Friend WithEvents DG_Mutaties As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GV_Naam As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents GP_Lijst As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Tpage_Product_beschrijving As TabPage
    Friend WithEvents RTXT_Beschrijving As RichTextBox
    Friend WithEvents TB_Product As TabControl
    Friend WithEvents TXT_IDP As TextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Tpage_Pics As TabPage
    Friend WithEvents Pic_Pic As PictureBox
    Friend WithEvents GB_PicsDetail As GroupBox
    Friend WithEvents LB_Pics As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_Pics_Url As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_Pics_Tekst As TextBox
    Friend WithEvents TXT_Pics_Naam As TextBox
    Friend WithEvents TXT_Pics_ID As TextBox
    Friend WithEvents Knop_Pics_Opslaan As Button
    Friend WithEvents Knop_Pics_Nieuw As Button
    Friend WithEvents Knop_Pics_Annuleren As Button
    Friend WithEvents TXT_Pics_Idproduct As TextBox
    Friend WithEvents PicturesBindingSource As BindingSource
    Friend WithEvents PicturesTableAdapter As DS_ProductTableAdapters.PicturesTableAdapter
    Friend WithEvents Tpage_Links As TabPage
    Friend WithEvents LB_Links As ListBox
    Friend WithEvents Knop_Links_Toon As Button
    Friend WithEvents GB_Links As GroupBox
    Friend WithEvents Knop_Links_Nieuw As Button
    Friend WithEvents Knop_Links_Annuleren As Button
    Friend WithEvents Knop_links_opslaan As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_Links_URL As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_links_tekst As TextBox
    Friend WithEvents txt_Links_Naam As TextBox
    Friend WithEvents ProductInfoBindingSource As BindingSource
    Friend WithEvents ProductInfoTableAdapter As DS_ProductTableAdapters.ProductInfoTableAdapter
    Friend WithEvents TXT_Links_IDproduct As TextBox
    Friend WithEvents TXT_Links_ID As TextBox
End Class

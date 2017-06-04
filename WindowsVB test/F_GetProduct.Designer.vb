<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_GetProduct
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
        Dim GV_DatumLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Knop_Supplier = New System.Windows.Forms.Button()
        Me.Knop_DetailsShop = New System.Windows.Forms.Button()
        Me.CB_Shop = New System.Windows.Forms.ComboBox()
        Me.GetOntvangstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.ShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_Supplier = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GPAOntvangenLijstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GPA_AantalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knop_Kosten = New System.Windows.Forms.Button()
        Me.Knop_BoekOntvangst = New System.Windows.Forms.Button()
        Me.GB_Get = New System.Windows.Forms.GroupBox()
        Me.txt_Status = New System.Windows.Forms.TextBox()
        Me.DA_Datum = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NaamGet = New System.Windows.Forms.TextBox()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Ontvangen = New System.Windows.Forms.ComboBox()
        Me.TXT_getontvangstid = New System.Windows.Forms.TextBox()
        Me.GetOntvangstTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetOntvangstTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.SupplierTableAdapter()
        Me.ShopTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ShopTableAdapter()
        Me.DT_productTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.DT_productTableAdapter()
        Me.GetProductAddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetProductAddTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductAddTableAdapter()
        Me.TXT_AdmInkoop = New System.Windows.Forms.TextBox()
        Me.TXT_Lijstwaarde = New System.Windows.Forms.TextBox()
        Me.TXT_Boekwaarde = New System.Windows.Forms.TextBox()
        Me.PD_Voorraad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPBuyPriceEURDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LK_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GP_Lijst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GP_Besteld = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GP__Ontvangen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGetProductAddDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGetOntvangstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPA_AantalTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GPA_AantalTableAdapter()
        Me.GPA_OntvangenLijstTableAdaptor_ = New WindowsVB_test.DS_ProductTableAdapters.GPA_OntvangenLijstTableAdaptor_()
        Me.GetProductListTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductListTableAdapter()
        Me.TB_Doel = New System.Windows.Forms.TabControl()
        Me.TPage_Doel_Ontvang = New System.Windows.Forms.TabPage()
        Me.Tpage_Doel_Bestel = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Knop_Bestelling = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_Kenmerk = New System.Windows.Forms.TextBox()
        Me.Tpage_Doel_Project = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXT_Project_Voorraad = New System.Windows.Forms.TextBox()
        Me.Knop_Project_bereken = New System.Windows.Forms.Button()
        Me.Knop_project_maak = New System.Windows.Forms.Button()
        Me.Knop_Project_Build = New System.Windows.Forms.Button()
        Me.TXT_Project_AantalMaak = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXT_Project_Max = New System.Windows.Forms.TextBox()
        Me.Knop_Project_Product = New System.Windows.Forms.Button()
        Me.TXT_Project_ProductID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT_Project_Prijs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_Project_SomVerkoop = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_Project_SomInkoop = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_Project_AantalParts = New System.Windows.Forms.TextBox()
        Me.Tpage_Doel_Sale = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXT_Push_Kas = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TXT_Push_Bank = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LBL_Push_Btw = New System.Windows.Forms.Label()
        Me.BTWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TXT_Push_Verkoop = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_Push_BTW = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TXT_Push_Omzet = New System.Windows.Forms.TextBox()
        Me.TXT_Push_Inkoop = New System.Windows.Forms.TextBox()
        Me.Knop_Push_Bereken = New System.Windows.Forms.Button()
        Me.Knop_Push_Maak = New System.Windows.Forms.Button()
        Me.CB_Push_soort = New System.Windows.Forms.ComboBox()
        Me.TXT_Voorraad = New System.Windows.Forms.TextBox()
        Me.TXT_LijstAantal = New System.Windows.Forms.TextBox()
        Me.TXT_ontvangen = New System.Windows.Forms.TextBox()
        Me.TXT_besteld = New System.Windows.Forms.TextBox()
        Me.TXT_Prijs = New System.Windows.Forms.TextBox()
        Me.Tpage_Product_Journaal = New System.Windows.Forms.TabPage()
        Me.DG_Journaal = New System.Windows.Forms.DataGridView()
        Me.IDGetontvangstDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDJournaalPostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JPDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_naam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGrootboekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JPDebetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JPCreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JNLijstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Administratie = New WindowsVB_test.DS_Administratie()
        Me.AdmJournaalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tpage_Product_Besteld = New System.Windows.Forms.TabPage()
        Me.Knop_Bestel_Ontvangst = New System.Windows.Forms.Button()
        Me.CH_AlleBestel = New System.Windows.Forms.CheckBox()
        Me.DG_Besteld = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_GetProductAdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPA_BesteldBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tpage_Product_Ontvang = New System.Windows.Forms.TabPage()
        Me.CH_AlleOntvangst = New System.Windows.Forms.CheckBox()
        Me.DG_ontvangen = New System.Windows.Forms.DataGridView()
        Me.Tpage_Product_Lijst = New System.Windows.Forms.TabPage()
        Me.Knop_Toon = New System.Windows.Forms.Button()
        Me.Knop_ProductPLus = New System.Windows.Forms.Button()
        Me.DG_Lijst = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PD_Sale_Prijs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_Products = New System.Windows.Forms.TabControl()
        Me.GB_Hulpvelden = New System.Windows.Forms.GroupBox()
        Me.GPA_BesteldTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GPA_BesteldTableAdapter()
        Me.Optie_Open = New System.Windows.Forms.RadioButton()
        Me.Optie_Ontvangst = New System.Windows.Forms.RadioButton()
        Me.Optie_besteld = New System.Windows.Forms.RadioButton()
        Me.Optie_Verbruik = New System.Windows.Forms.RadioButton()
        Me.Optie_Project = New System.Windows.Forms.RadioButton()
        Me.GB_Sectie = New System.Windows.Forms.GroupBox()
        Me.BTWTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.BTWTableAdapter()
        Me.AdmJournaalTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.AdmJournaalTableAdapter()
        Me.JN_LijstDatatable = New WindowsVB_test.DS_AdministratieTableAdapters.JN_LijstDatatable()
        Me.GVDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GVDatumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPOntvangenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDBeschrijving2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDSalePrijsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGetOntvangstDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGetProductAddDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        GV_DatumLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.GetOntvangstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPAOntvangenLijstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPA_AantalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Get.SuspendLayout()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB_Doel.SuspendLayout()
        Me.TPage_Doel_Ontvang.SuspendLayout()
        Me.Tpage_Doel_Bestel.SuspendLayout()
        Me.Tpage_Doel_Project.SuspendLayout()
        Me.Tpage_Doel_Sale.SuspendLayout()
        CType(Me.BTWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Product_Journaal.SuspendLayout()
        CType(Me.DG_Journaal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JNLijstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmJournaalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Product_Besteld.SuspendLayout()
        CType(Me.DG_Besteld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPA_BesteldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Product_Ontvang.SuspendLayout()
        CType(Me.DG_ontvangen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Product_Lijst.SuspendLayout()
        CType(Me.DG_Lijst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB_Products.SuspendLayout()
        Me.GB_Hulpvelden.SuspendLayout()
        Me.GB_Sectie.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV_DatumLabel
        '
        GV_DatumLabel.AutoSize = True
        GV_DatumLabel.Location = New System.Drawing.Point(10, 45)
        GV_DatumLabel.Name = "GV_DatumLabel"
        GV_DatumLabel.Size = New System.Drawing.Size(41, 13)
        GV_DatumLabel.TabIndex = 5
        GV_DatumLabel.Text = "Datum:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(14, 49)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(70, 13)
        Label4.TabIndex = 14
        Label4.Text = "Boekwaarde:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(14, 72)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(63, 13)
        Label5.TabIndex = 16
        Label5.Text = "Lijstwaarde:"
        '
        'Knop_Supplier
        '
        Me.Knop_Supplier.Location = New System.Drawing.Point(10, 63)
        Me.Knop_Supplier.Name = "Knop_Supplier"
        Me.Knop_Supplier.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Supplier.TabIndex = 102
        Me.Knop_Supplier.TabStop = False
        Me.Knop_Supplier.Text = "&Leverancier:"
        Me.Knop_Supplier.UseVisualStyleBackColor = True
        '
        'Knop_DetailsShop
        '
        Me.Knop_DetailsShop.Location = New System.Drawing.Point(290, 15)
        Me.Knop_DetailsShop.Name = "Knop_DetailsShop"
        Me.Knop_DetailsShop.Size = New System.Drawing.Size(47, 23)
        Me.Knop_DetailsShop.TabIndex = 5
        Me.Knop_DetailsShop.Text = "&Shop:"
        Me.Knop_DetailsShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Knop_DetailsShop.UseVisualStyleBackColor = True
        '
        'CB_Shop
        '
        Me.CB_Shop.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GetOntvangstBindingSource, "ID_Shop", True))
        Me.CB_Shop.DataSource = Me.ShopBindingSource
        Me.CB_Shop.DisplayMember = "SH_Naam"
        Me.CB_Shop.FormattingEnabled = True
        Me.CB_Shop.Location = New System.Drawing.Point(343, 16)
        Me.CB_Shop.Name = "CB_Shop"
        Me.CB_Shop.Size = New System.Drawing.Size(156, 21)
        Me.CB_Shop.TabIndex = 2
        Me.CB_Shop.ValueMember = "ID_Shop"
        '
        'GetOntvangstBindingSource
        '
        Me.GetOntvangstBindingSource.DataMember = "GetOntvangst"
        Me.GetOntvangstBindingSource.DataSource = Me.DS_Product
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShopBindingSource
        '
        Me.ShopBindingSource.DataMember = "Shop"
        Me.ShopBindingSource.DataSource = Me.DS_Product
        '
        'CB_Supplier
        '
        Me.CB_Supplier.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GetOntvangstBindingSource, "ID_Supplier", True))
        Me.CB_Supplier.DataSource = Me.SupplierBindingSource
        Me.CB_Supplier.DisplayMember = "SP_Naam"
        Me.CB_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Supplier.FormattingEnabled = True
        Me.CB_Supplier.Location = New System.Drawing.Point(90, 65)
        Me.CB_Supplier.Name = "CB_Supplier"
        Me.CB_Supplier.Size = New System.Drawing.Size(262, 21)
        Me.CB_Supplier.TabIndex = 3
        Me.CB_Supplier.ValueMember = "ID_Supplier"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Product
        '
        'GetProductListBindingSource
        '
        Me.GetProductListBindingSource.DataMember = "GetProductList"
        Me.GetProductListBindingSource.DataSource = Me.DS_Product
        '
        'GPAOntvangenLijstBindingSource
        '
        Me.GPAOntvangenLijstBindingSource.DataMember = "GPA_OntvangenLijst "
        Me.GPAOntvangenLijstBindingSource.DataSource = Me.DS_Product
        '
        'GPA_AantalBindingSource
        '
        Me.GPA_AantalBindingSource.DataMember = "GPA_Aantal"
        Me.GPA_AantalBindingSource.DataSource = Me.DS_Product
        '
        'DT_productBindingSource
        '
        Me.DT_productBindingSource.DataMember = "DT_product"
        Me.DT_productBindingSource.DataSource = Me.DS_Product
        '
        'Knop_Kosten
        '
        Me.Knop_Kosten.Location = New System.Drawing.Point(19, 15)
        Me.Knop_Kosten.Name = "Knop_Kosten"
        Me.Knop_Kosten.Size = New System.Drawing.Size(116, 23)
        Me.Knop_Kosten.TabIndex = 7
        Me.Knop_Kosten.Text = "&Kosten boeken"
        Me.Knop_Kosten.UseVisualStyleBackColor = True
        '
        'Knop_BoekOntvangst
        '
        Me.Knop_BoekOntvangst.Location = New System.Drawing.Point(150, 15)
        Me.Knop_BoekOntvangst.Name = "Knop_BoekOntvangst"
        Me.Knop_BoekOntvangst.Size = New System.Drawing.Size(116, 23)
        Me.Knop_BoekOntvangst.TabIndex = 12
        Me.Knop_BoekOntvangst.Text = "Boek als ontvangst"
        Me.Knop_BoekOntvangst.UseVisualStyleBackColor = True
        '
        'GB_Get
        '
        Me.GB_Get.Controls.Add(Me.Knop_Supplier)
        Me.GB_Get.Controls.Add(Me.txt_Status)
        Me.GB_Get.Controls.Add(GV_DatumLabel)
        Me.GB_Get.Controls.Add(Me.DA_Datum)
        Me.GB_Get.Controls.Add(Me.TXT_NaamGet)
        Me.GB_Get.Controls.Add(Me.Knop_Nieuw)
        Me.GB_Get.Controls.Add(Me.Label3)
        Me.GB_Get.Controls.Add(Me.CB_Ontvangen)
        Me.GB_Get.Controls.Add(Me.TXT_getontvangstid)
        Me.GB_Get.Controls.Add(Me.CB_Supplier)
        Me.GB_Get.Location = New System.Drawing.Point(12, 4)
        Me.GB_Get.Name = "GB_Get"
        Me.GB_Get.Size = New System.Drawing.Size(366, 118)
        Me.GB_Get.TabIndex = 2
        Me.GB_Get.TabStop = False
        '
        'txt_Status
        '
        Me.txt_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "GV_Status", True))
        Me.txt_Status.Enabled = False
        Me.txt_Status.Location = New System.Drawing.Point(4, 92)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.Size = New System.Drawing.Size(41, 20)
        Me.txt_Status.TabIndex = 101
        Me.txt_Status.TabStop = False
        Me.txt_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DA_Datum
        '
        Me.DA_Datum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GetOntvangstBindingSource, "GV_Datum", True))
        Me.DA_Datum.Location = New System.Drawing.Point(90, 42)
        Me.DA_Datum.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.DA_Datum.Name = "DA_Datum"
        Me.DA_Datum.Size = New System.Drawing.Size(262, 20)
        Me.DA_Datum.TabIndex = 2
        '
        'TXT_NaamGet
        '
        Me.TXT_NaamGet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "GV_Naam", True))
        Me.TXT_NaamGet.Location = New System.Drawing.Point(117, 20)
        Me.TXT_NaamGet.Name = "TXT_NaamGet"
        Me.TXT_NaamGet.Size = New System.Drawing.Size(235, 20)
        Me.TXT_NaamGet.TabIndex = 1
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(282, 89)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(70, 23)
        Me.Knop_Nieuw.TabIndex = 8
        Me.Knop_Nieuw.TabStop = False
        Me.Knop_Nieuw.Text = "&Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Productlijst:"
        '
        'CB_Ontvangen
        '
        Me.CB_Ontvangen.AllowDrop = True
        Me.CB_Ontvangen.DataSource = Me.GetOntvangstBindingSource
        Me.CB_Ontvangen.DisplayMember = "GV_Naam"
        Me.CB_Ontvangen.DropDownWidth = 400
        Me.CB_Ontvangen.FormattingEnabled = True
        Me.CB_Ontvangen.Location = New System.Drawing.Point(90, 20)
        Me.CB_Ontvangen.MaxDropDownItems = 15
        Me.CB_Ontvangen.Name = "CB_Ontvangen"
        Me.CB_Ontvangen.Size = New System.Drawing.Size(21, 21)
        Me.CB_Ontvangen.TabIndex = 103
        Me.CB_Ontvangen.TabStop = False
        Me.CB_Ontvangen.ValueMember = "ID_GetOntvangst"
        '
        'TXT_getontvangstid
        '
        Me.TXT_getontvangstid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "ID_GetOntvangst", True))
        Me.TXT_getontvangstid.Enabled = False
        Me.TXT_getontvangstid.Location = New System.Drawing.Point(51, 92)
        Me.TXT_getontvangstid.Name = "TXT_getontvangstid"
        Me.TXT_getontvangstid.Size = New System.Drawing.Size(40, 20)
        Me.TXT_getontvangstid.TabIndex = 100
        Me.TXT_getontvangstid.TabStop = False
        Me.TXT_getontvangstid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GetOntvangstTableAdapter
        '
        Me.GetOntvangstTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DT_productTableAdapter = Nothing
        Me.TableAdapterManager.GetOntvangstTableAdapter = Me.GetOntvangstTableAdapter
        Me.TableAdapterManager.GetProductAddTableAdapter = Nothing
        Me.TableAdapterManager.GPA_AantalTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.LocatieHolderTableAdapter = Nothing
        Me.TableAdapterManager.LocatieTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.PicturesTableAdapter = Nothing
        Me.TableAdapterManager.ProductInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(19, 221)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(85, 23)
        Me.Knop_Sluiten.TabIndex = 4
        Me.Knop_Sluiten.Text = "&Sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'ShopTableAdapter
        '
        Me.ShopTableAdapter.ClearBeforeFill = True
        '
        'DT_productTableAdapter
        '
        Me.DT_productTableAdapter.ClearBeforeFill = True
        '
        'GetProductAddBindingSource
        '
        Me.GetProductAddBindingSource.DataMember = "GetProductAdd"
        Me.GetProductAddBindingSource.DataSource = Me.DS_Product
        '
        'GetProductAddTableAdapter
        '
        Me.GetProductAddTableAdapter.ClearBeforeFill = True
        '
        'TXT_AdmInkoop
        '
        Me.TXT_AdmInkoop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "ID_AdmInkoopboek", True))
        Me.TXT_AdmInkoop.Enabled = False
        Me.TXT_AdmInkoop.Location = New System.Drawing.Point(216, 45)
        Me.TXT_AdmInkoop.Name = "TXT_AdmInkoop"
        Me.TXT_AdmInkoop.Size = New System.Drawing.Size(45, 20)
        Me.TXT_AdmInkoop.TabIndex = 18
        '
        'TXT_Lijstwaarde
        '
        Me.TXT_Lijstwaarde.Location = New System.Drawing.Point(90, 69)
        Me.TXT_Lijstwaarde.Name = "TXT_Lijstwaarde"
        Me.TXT_Lijstwaarde.Size = New System.Drawing.Size(60, 20)
        Me.TXT_Lijstwaarde.TabIndex = 15
        Me.TXT_Lijstwaarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_Boekwaarde
        '
        Me.TXT_Boekwaarde.Location = New System.Drawing.Point(90, 45)
        Me.TXT_Boekwaarde.Name = "TXT_Boekwaarde"
        Me.TXT_Boekwaarde.Size = New System.Drawing.Size(60, 20)
        Me.TXT_Boekwaarde.TabIndex = 13
        Me.TXT_Boekwaarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PD_Voorraad
        '
        Me.PD_Voorraad.DataPropertyName = "PD_Voorraad"
        Me.PD_Voorraad.HeaderText = "V"
        Me.PD_Voorraad.Name = "PD_Voorraad"
        Me.PD_Voorraad.ReadOnly = True
        Me.PD_Voorraad.Width = 50
        '
        'GPBuyPriceEURDataGridViewTextBoxColumn
        '
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.DataPropertyName = "GP_BuyPriceEUR"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.HeaderText = "Inkoop"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.Name = "GPBuyPriceEURDataGridViewTextBoxColumn"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.ReadOnly = True
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.Width = 50
        '
        'LK_Code
        '
        Me.LK_Code.DataPropertyName = "LK_Code"
        Me.LK_Code.HeaderText = "Locatie"
        Me.LK_Code.Name = "LK_Code"
        Me.LK_Code.ReadOnly = True
        Me.LK_Code.Width = 80
        '
        'product
        '
        Me.product.DataPropertyName = "product"
        Me.product.HeaderText = "Beschrijving"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        Me.product.Width = 200
        '
        'GP_Lijst
        '
        Me.GP_Lijst.DataPropertyName = "GP_Lijst"
        Me.GP_Lijst.HeaderText = "Lijst"
        Me.GP_Lijst.Name = "GP_Lijst"
        Me.GP_Lijst.ReadOnly = True
        Me.GP_Lijst.Width = 50
        '
        'GP_Besteld
        '
        Me.GP_Besteld.DataPropertyName = "GP_Besteld"
        Me.GP_Besteld.HeaderText = "B"
        Me.GP_Besteld.Name = "GP_Besteld"
        Me.GP_Besteld.ReadOnly = True
        Me.GP_Besteld.Width = 20
        '
        'GP__Ontvangen
        '
        Me.GP__Ontvangen.DataPropertyName = "GP__Ontvangen"
        Me.GP__Ontvangen.HeaderText = "O"
        Me.GP__Ontvangen.Name = "GP__Ontvangen"
        Me.GP__Ontvangen.ReadOnly = True
        Me.GP__Ontvangen.Width = 20
        '
        'IDProductDataGridViewTextBoxColumn
        '
        Me.IDProductDataGridViewTextBoxColumn.DataPropertyName = "ID_Product"
        Me.IDProductDataGridViewTextBoxColumn.HeaderText = "ID_Product"
        Me.IDProductDataGridViewTextBoxColumn.Name = "IDProductDataGridViewTextBoxColumn"
        Me.IDProductDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDGetProductAddDataGridViewTextBoxColumn
        '
        Me.IDGetProductAddDataGridViewTextBoxColumn.DataPropertyName = "ID_GetProductAdd"
        Me.IDGetProductAddDataGridViewTextBoxColumn.HeaderText = "ID_GetProductAdd"
        Me.IDGetProductAddDataGridViewTextBoxColumn.Name = "IDGetProductAddDataGridViewTextBoxColumn"
        Me.IDGetProductAddDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDGetOntvangstDataGridViewTextBoxColumn
        '
        Me.IDGetOntvangstDataGridViewTextBoxColumn.DataPropertyName = "ID_GetOntvangst"
        Me.IDGetOntvangstDataGridViewTextBoxColumn.HeaderText = "ID_GetOntvangst"
        Me.IDGetOntvangstDataGridViewTextBoxColumn.Name = "IDGetOntvangstDataGridViewTextBoxColumn"
        Me.IDGetOntvangstDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GPA_AantalTableAdapter
        '
        Me.GPA_AantalTableAdapter.ClearBeforeFill = True
        '
        'GPA_OntvangenLijstTableAdaptor_
        '
        Me.GPA_OntvangenLijstTableAdaptor_.ClearBeforeFill = True
        '
        'GetProductListTableAdapter
        '
        Me.GetProductListTableAdapter.ClearBeforeFill = True
        '
        'TB_Doel
        '
        Me.TB_Doel.Controls.Add(Me.TPage_Doel_Ontvang)
        Me.TB_Doel.Controls.Add(Me.Tpage_Doel_Bestel)
        Me.TB_Doel.Controls.Add(Me.Tpage_Doel_Project)
        Me.TB_Doel.Controls.Add(Me.Tpage_Doel_Sale)
        Me.TB_Doel.ItemSize = New System.Drawing.Size(135, 18)
        Me.TB_Doel.Location = New System.Drawing.Point(12, 128)
        Me.TB_Doel.Name = "TB_Doel"
        Me.TB_Doel.SelectedIndex = 0
        Me.TB_Doel.Size = New System.Drawing.Size(544, 133)
        Me.TB_Doel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TB_Doel.TabIndex = 21
        '
        'TPage_Doel_Ontvang
        '
        Me.TPage_Doel_Ontvang.BackColor = System.Drawing.Color.Azure
        Me.TPage_Doel_Ontvang.Controls.Add(Label5)
        Me.TPage_Doel_Ontvang.Controls.Add(Me.Knop_DetailsShop)
        Me.TPage_Doel_Ontvang.Controls.Add(Me.Knop_Kosten)
        Me.TPage_Doel_Ontvang.Controls.Add(Me.TXT_Lijstwaarde)
        Me.TPage_Doel_Ontvang.Controls.Add(Me.CB_Shop)
        Me.TPage_Doel_Ontvang.Controls.Add(Me.Knop_BoekOntvangst)
        Me.TPage_Doel_Ontvang.Controls.Add(Me.TXT_AdmInkoop)
        Me.TPage_Doel_Ontvang.Controls.Add(Me.TXT_Boekwaarde)
        Me.TPage_Doel_Ontvang.Controls.Add(Label4)
        Me.TPage_Doel_Ontvang.Location = New System.Drawing.Point(4, 22)
        Me.TPage_Doel_Ontvang.Name = "TPage_Doel_Ontvang"
        Me.TPage_Doel_Ontvang.Padding = New System.Windows.Forms.Padding(3)
        Me.TPage_Doel_Ontvang.Size = New System.Drawing.Size(536, 107)
        Me.TPage_Doel_Ontvang.TabIndex = 0
        Me.TPage_Doel_Ontvang.Text = "Ontvangen"
        '
        'Tpage_Doel_Bestel
        '
        Me.Tpage_Doel_Bestel.BackColor = System.Drawing.Color.Linen
        Me.Tpage_Doel_Bestel.Controls.Add(Me.RichTextBox1)
        Me.Tpage_Doel_Bestel.Controls.Add(Me.Knop_Bestelling)
        Me.Tpage_Doel_Bestel.Controls.Add(Me.Label6)
        Me.Tpage_Doel_Bestel.Controls.Add(Me.TXT_Kenmerk)
        Me.Tpage_Doel_Bestel.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Doel_Bestel.Name = "Tpage_Doel_Bestel"
        Me.Tpage_Doel_Bestel.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Doel_Bestel.Size = New System.Drawing.Size(536, 107)
        Me.Tpage_Doel_Bestel.TabIndex = 1
        Me.Tpage_Doel_Bestel.Text = "Bestelling"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(316, 9)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(214, 92)
        Me.RichTextBox1.TabIndex = 22
        Me.RichTextBox1.Text = "Bestellingen, voorlopig alleen handmatig." & Global.Microsoft.VisualBasic.ChrW(10) & "Straks, via bv, zoekproduct naar bestel" &
    "adviezen" & Global.Microsoft.VisualBasic.ChrW(10) & "minimale voorraden en klantbestellingen." & Global.Microsoft.VisualBasic.ChrW(10) & "Verder faxen emails en opmaak " &
    "bestelling formulier. "
        '
        'Knop_Bestelling
        '
        Me.Knop_Bestelling.Location = New System.Drawing.Point(64, 53)
        Me.Knop_Bestelling.Name = "Knop_Bestelling"
        Me.Knop_Bestelling.Size = New System.Drawing.Size(91, 23)
        Me.Knop_Bestelling.TabIndex = 21
        Me.Knop_Bestelling.Text = "Maak bestelling"
        Me.Knop_Bestelling.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Kenmerk:"
        '
        'TXT_Kenmerk
        '
        Me.TXT_Kenmerk.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "GV_Beschrijving", True))
        Me.TXT_Kenmerk.Location = New System.Drawing.Point(64, 9)
        Me.TXT_Kenmerk.Multiline = True
        Me.TXT_Kenmerk.Name = "TXT_Kenmerk"
        Me.TXT_Kenmerk.Size = New System.Drawing.Size(236, 38)
        Me.TXT_Kenmerk.TabIndex = 0
        '
        'Tpage_Doel_Project
        '
        Me.Tpage_Doel_Project.BackColor = System.Drawing.Color.LightYellow
        Me.Tpage_Doel_Project.Controls.Add(Me.Label17)
        Me.Tpage_Doel_Project.Controls.Add(Me.TXT_Project_Voorraad)
        Me.Tpage_Doel_Project.Controls.Add(Me.Knop_Project_bereken)
        Me.Tpage_Doel_Project.Controls.Add(Me.Knop_project_maak)
        Me.Tpage_Doel_Project.Controls.Add(Me.Knop_Project_Build)
        Me.Tpage_Doel_Project.Controls.Add(Me.TXT_Project_AantalMaak)
        Me.Tpage_Doel_Project.Controls.Add(Me.Label16)
        Me.Tpage_Doel_Project.Controls.Add(Me.TXT_Project_Max)
        Me.Tpage_Doel_Project.Controls.Add(Me.Knop_Project_Product)
        Me.Tpage_Doel_Project.Controls.Add(Me.TXT_Project_ProductID)
        Me.Tpage_Doel_Project.Controls.Add(Me.Label15)
        Me.Tpage_Doel_Project.Controls.Add(Me.TXT_Project_Prijs)
        Me.Tpage_Doel_Project.Controls.Add(Me.Label9)
        Me.Tpage_Doel_Project.Controls.Add(Me.TXT_Project_SomVerkoop)
        Me.Tpage_Doel_Project.Controls.Add(Me.Label8)
        Me.Tpage_Doel_Project.Controls.Add(Me.TXT_Project_SomInkoop)
        Me.Tpage_Doel_Project.Controls.Add(Me.Label1)
        Me.Tpage_Doel_Project.Controls.Add(Me.TXT_Project_AantalParts)
        Me.Tpage_Doel_Project.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Doel_Project.Name = "Tpage_Doel_Project"
        Me.Tpage_Doel_Project.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Doel_Project.Size = New System.Drawing.Size(536, 107)
        Me.Tpage_Doel_Project.TabIndex = 2
        Me.Tpage_Doel_Project.Text = "Project"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(279, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Voorraad:"
        '
        'TXT_Project_Voorraad
        '
        Me.TXT_Project_Voorraad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.TXT_Project_Voorraad.Location = New System.Drawing.Point(357, 54)
        Me.TXT_Project_Voorraad.Name = "TXT_Project_Voorraad"
        Me.TXT_Project_Voorraad.ReadOnly = True
        Me.TXT_Project_Voorraad.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Project_Voorraad.TabIndex = 17
        Me.TXT_Project_Voorraad.TabStop = False
        '
        'Knop_Project_bereken
        '
        Me.Knop_Project_bereken.Location = New System.Drawing.Point(279, 9)
        Me.Knop_Project_bereken.Name = "Knop_Project_bereken"
        Me.Knop_Project_bereken.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Project_bereken.TabIndex = 16
        Me.Knop_Project_bereken.TabStop = False
        Me.Knop_Project_bereken.Text = "Bereken"
        Me.Knop_Project_bereken.UseVisualStyleBackColor = True
        '
        'Knop_project_maak
        '
        Me.Knop_project_maak.Enabled = False
        Me.Knop_project_maak.Location = New System.Drawing.Point(6, 31)
        Me.Knop_project_maak.Name = "Knop_project_maak"
        Me.Knop_project_maak.Size = New System.Drawing.Size(120, 23)
        Me.Knop_project_maak.TabIndex = 15
        Me.Knop_project_maak.TabStop = False
        Me.Knop_project_maak.Text = "Maak project"
        Me.Knop_project_maak.UseVisualStyleBackColor = True
        '
        'Knop_Project_Build
        '
        Me.Knop_Project_Build.Location = New System.Drawing.Point(279, 75)
        Me.Knop_Project_Build.Name = "Knop_Project_Build"
        Me.Knop_Project_Build.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Project_Build.TabIndex = 14
        Me.Knop_Project_Build.TabStop = False
        Me.Knop_Project_Build.Text = "Maak:"
        Me.Knop_Project_Build.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Knop_Project_Build.UseVisualStyleBackColor = True
        '
        'TXT_Project_AantalMaak
        '
        Me.TXT_Project_AantalMaak.Location = New System.Drawing.Point(357, 76)
        Me.TXT_Project_AantalMaak.Name = "TXT_Project_AantalMaak"
        Me.TXT_Project_AantalMaak.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Project_AantalMaak.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(279, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Max projects:"
        '
        'TXT_Project_Max
        '
        Me.TXT_Project_Max.Location = New System.Drawing.Point(357, 32)
        Me.TXT_Project_Max.Name = "TXT_Project_Max"
        Me.TXT_Project_Max.ReadOnly = True
        Me.TXT_Project_Max.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Project_Max.TabIndex = 11
        Me.TXT_Project_Max.TabStop = False
        '
        'Knop_Project_Product
        '
        Me.Knop_Project_Product.Location = New System.Drawing.Point(6, 9)
        Me.Knop_Project_Product.Name = "Knop_Project_Product"
        Me.Knop_Project_Product.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Project_Product.TabIndex = 10
        Me.Knop_Project_Product.TabStop = False
        Me.Knop_Project_Product.Text = "Product"
        Me.Knop_Project_Product.UseVisualStyleBackColor = True
        '
        'TXT_Project_ProductID
        '
        Me.TXT_Project_ProductID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "ID_Product", True))
        Me.TXT_Project_ProductID.Location = New System.Drawing.Point(86, 10)
        Me.TXT_Project_ProductID.Name = "TXT_Project_ProductID"
        Me.TXT_Project_ProductID.ReadOnly = True
        Me.TXT_Project_ProductID.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Project_ProductID.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(147, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Prijs Project:"
        '
        'TXT_Project_Prijs
        '
        Me.TXT_Project_Prijs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Sale_Prijs", True))
        Me.TXT_Project_Prijs.Location = New System.Drawing.Point(223, 76)
        Me.TXT_Project_Prijs.Name = "TXT_Project_Prijs"
        Me.TXT_Project_Prijs.ReadOnly = True
        Me.TXT_Project_Prijs.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Project_Prijs.TabIndex = 6
        Me.TXT_Project_Prijs.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(147, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Som verkoop:"
        '
        'TXT_Project_SomVerkoop
        '
        Me.TXT_Project_SomVerkoop.Location = New System.Drawing.Point(223, 54)
        Me.TXT_Project_SomVerkoop.Name = "TXT_Project_SomVerkoop"
        Me.TXT_Project_SomVerkoop.ReadOnly = True
        Me.TXT_Project_SomVerkoop.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Project_SomVerkoop.TabIndex = 4
        Me.TXT_Project_SomVerkoop.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Som inkoop:"
        '
        'TXT_Project_SomInkoop
        '
        Me.TXT_Project_SomInkoop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Buy_Cost", True))
        Me.TXT_Project_SomInkoop.Location = New System.Drawing.Point(223, 32)
        Me.TXT_Project_SomInkoop.Name = "TXT_Project_SomInkoop"
        Me.TXT_Project_SomInkoop.ReadOnly = True
        Me.TXT_Project_SomInkoop.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Project_SomInkoop.TabIndex = 2
        Me.TXT_Project_SomInkoop.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aantal parts:"
        '
        'TXT_Project_AantalParts
        '
        Me.TXT_Project_AantalParts.Location = New System.Drawing.Point(223, 10)
        Me.TXT_Project_AantalParts.Name = "TXT_Project_AantalParts"
        Me.TXT_Project_AantalParts.ReadOnly = True
        Me.TXT_Project_AantalParts.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Project_AantalParts.TabIndex = 0
        Me.TXT_Project_AantalParts.TabStop = False
        '
        'Tpage_Doel_Sale
        '
        Me.Tpage_Doel_Sale.BackColor = System.Drawing.Color.LavenderBlush
        Me.Tpage_Doel_Sale.Controls.Add(Me.Label24)
        Me.Tpage_Doel_Sale.Controls.Add(Me.TXT_Push_Kas)
        Me.Tpage_Doel_Sale.Controls.Add(Me.Label23)
        Me.Tpage_Doel_Sale.Controls.Add(Me.TXT_Push_Bank)
        Me.Tpage_Doel_Sale.Controls.Add(Me.Label22)
        Me.Tpage_Doel_Sale.Controls.Add(Me.Label18)
        Me.Tpage_Doel_Sale.Controls.Add(Me.LBL_Push_Btw)
        Me.Tpage_Doel_Sale.Controls.Add(Me.Label21)
        Me.Tpage_Doel_Sale.Controls.Add(Me.TXT_Push_Verkoop)
        Me.Tpage_Doel_Sale.Controls.Add(Me.Label20)
        Me.Tpage_Doel_Sale.Controls.Add(Me.TXT_Push_BTW)
        Me.Tpage_Doel_Sale.Controls.Add(Me.Label19)
        Me.Tpage_Doel_Sale.Controls.Add(Me.TXT_Push_Omzet)
        Me.Tpage_Doel_Sale.Controls.Add(Me.TXT_Push_Inkoop)
        Me.Tpage_Doel_Sale.Controls.Add(Me.Knop_Push_Bereken)
        Me.Tpage_Doel_Sale.Controls.Add(Me.Knop_Push_Maak)
        Me.Tpage_Doel_Sale.Controls.Add(Me.CB_Push_soort)
        Me.Tpage_Doel_Sale.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Doel_Sale.Name = "Tpage_Doel_Sale"
        Me.Tpage_Doel_Sale.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Doel_Sale.Size = New System.Drawing.Size(536, 107)
        Me.Tpage_Doel_Sale.TabIndex = 3
        Me.Tpage_Doel_Sale.Text = "Verbruik"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(233, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Per kas:"
        '
        'TXT_Push_Kas
        '
        Me.TXT_Push_Kas.Location = New System.Drawing.Point(294, 76)
        Me.TXT_Push_Kas.Name = "TXT_Push_Kas"
        Me.TXT_Push_Kas.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Push_Kas.TabIndex = 1
        Me.TXT_Push_Kas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(233, 58)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 13)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Bank(PIN):"
        '
        'TXT_Push_Bank
        '
        Me.TXT_Push_Bank.Location = New System.Drawing.Point(294, 54)
        Me.TXT_Push_Bank.Name = "TXT_Push_Bank"
        Me.TXT_Push_Bank.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Push_Bank.TabIndex = 0
        Me.TXT_Push_Bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Som inkoop:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Soort verbruik:"
        '
        'LBL_Push_Btw
        '
        Me.LBL_Push_Btw.AutoSize = True
        Me.LBL_Push_Btw.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BTWBindingSource, "BTW_Perc", True))
        Me.LBL_Push_Btw.Location = New System.Drawing.Point(233, 31)
        Me.LBL_Push_Btw.Name = "LBL_Push_Btw"
        Me.LBL_Push_Btw.Size = New System.Drawing.Size(10, 13)
        Me.LBL_Push_Btw.TabIndex = 13
        Me.LBL_Push_Btw.Text = "-"
        '
        'BTWBindingSource
        '
        Me.BTWBindingSource.DataMember = "BTW"
        Me.BTWBindingSource.DataSource = Me.DS_Product
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Som verkoop:"
        '
        'TXT_Push_Verkoop
        '
        Me.TXT_Push_Verkoop.Location = New System.Drawing.Point(90, 76)
        Me.TXT_Push_Verkoop.Name = "TXT_Push_Verkoop"
        Me.TXT_Push_Verkoop.ReadOnly = True
        Me.TXT_Push_Verkoop.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Push_Verkoop.TabIndex = 10
        Me.TXT_Push_Verkoop.TabStop = False
        Me.TXT_Push_Verkoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(245, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = " % BTW:"
        '
        'TXT_Push_BTW
        '
        Me.TXT_Push_BTW.Location = New System.Drawing.Point(294, 27)
        Me.TXT_Push_BTW.Name = "TXT_Push_BTW"
        Me.TXT_Push_BTW.ReadOnly = True
        Me.TXT_Push_BTW.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Push_BTW.TabIndex = 8
        Me.TXT_Push_BTW.TabStop = False
        Me.TXT_Push_BTW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(233, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Omzet:"
        '
        'TXT_Push_Omzet
        '
        Me.TXT_Push_Omzet.Location = New System.Drawing.Point(294, 6)
        Me.TXT_Push_Omzet.Name = "TXT_Push_Omzet"
        Me.TXT_Push_Omzet.ReadOnly = True
        Me.TXT_Push_Omzet.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Push_Omzet.TabIndex = 6
        Me.TXT_Push_Omzet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_Push_Inkoop
        '
        Me.TXT_Push_Inkoop.Location = New System.Drawing.Point(90, 55)
        Me.TXT_Push_Inkoop.Name = "TXT_Push_Inkoop"
        Me.TXT_Push_Inkoop.ReadOnly = True
        Me.TXT_Push_Inkoop.Size = New System.Drawing.Size(50, 20)
        Me.TXT_Push_Inkoop.TabIndex = 4
        Me.TXT_Push_Inkoop.TabStop = False
        Me.TXT_Push_Inkoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Knop_Push_Bereken
        '
        Me.Knop_Push_Bereken.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Calculator_icon
        Me.Knop_Push_Bereken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Push_Bereken.Location = New System.Drawing.Point(170, 56)
        Me.Knop_Push_Bereken.Name = "Knop_Push_Bereken"
        Me.Knop_Push_Bereken.Size = New System.Drawing.Size(40, 40)
        Me.Knop_Push_Bereken.TabIndex = 3
        Me.Knop_Push_Bereken.UseVisualStyleBackColor = True
        '
        'Knop_Push_Maak
        '
        Me.Knop_Push_Maak.Location = New System.Drawing.Point(368, 75)
        Me.Knop_Push_Maak.Name = "Knop_Push_Maak"
        Me.Knop_Push_Maak.Size = New System.Drawing.Size(120, 23)
        Me.Knop_Push_Maak.TabIndex = 2
        Me.Knop_Push_Maak.Text = "Boek Verbruik"
        Me.Knop_Push_Maak.UseVisualStyleBackColor = True
        '
        'CB_Push_soort
        '
        Me.CB_Push_soort.FormattingEnabled = True
        Me.CB_Push_soort.Items.AddRange(New Object() {"Omzet, verkoop", "Naar Inventaris", "Verlies, afboeken "})
        Me.CB_Push_soort.Location = New System.Drawing.Point(90, 8)
        Me.CB_Push_soort.Name = "CB_Push_soort"
        Me.CB_Push_soort.Size = New System.Drawing.Size(120, 21)
        Me.CB_Push_soort.TabIndex = 0
        '
        'TXT_Voorraad
        '
        Me.TXT_Voorraad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.TXT_Voorraad.Enabled = False
        Me.TXT_Voorraad.Location = New System.Drawing.Point(14, 12)
        Me.TXT_Voorraad.Name = "TXT_Voorraad"
        Me.TXT_Voorraad.Size = New System.Drawing.Size(20, 20)
        Me.TXT_Voorraad.TabIndex = 16
        Me.TXT_Voorraad.TabStop = False
        '
        'TXT_LijstAantal
        '
        Me.TXT_LijstAantal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_Lijst", True))
        Me.TXT_LijstAantal.Enabled = False
        Me.TXT_LijstAantal.Location = New System.Drawing.Point(94, 12)
        Me.TXT_LijstAantal.Name = "TXT_LijstAantal"
        Me.TXT_LijstAantal.Size = New System.Drawing.Size(20, 20)
        Me.TXT_LijstAantal.TabIndex = 17
        Me.TXT_LijstAantal.TabStop = False
        '
        'TXT_ontvangen
        '
        Me.TXT_ontvangen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP__Ontvangen", True))
        Me.TXT_ontvangen.Enabled = False
        Me.TXT_ontvangen.Location = New System.Drawing.Point(74, 12)
        Me.TXT_ontvangen.Name = "TXT_ontvangen"
        Me.TXT_ontvangen.Size = New System.Drawing.Size(20, 20)
        Me.TXT_ontvangen.TabIndex = 20
        Me.TXT_ontvangen.TabStop = False
        '
        'TXT_besteld
        '
        Me.TXT_besteld.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_Besteld", True))
        Me.TXT_besteld.Enabled = False
        Me.TXT_besteld.Location = New System.Drawing.Point(54, 12)
        Me.TXT_besteld.Name = "TXT_besteld"
        Me.TXT_besteld.Size = New System.Drawing.Size(20, 20)
        Me.TXT_besteld.TabIndex = 22
        Me.TXT_besteld.TabStop = False
        '
        'TXT_Prijs
        '
        Me.TXT_Prijs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_BuyPriceEUR", True))
        Me.TXT_Prijs.Enabled = False
        Me.TXT_Prijs.Location = New System.Drawing.Point(34, 12)
        Me.TXT_Prijs.Name = "TXT_Prijs"
        Me.TXT_Prijs.Size = New System.Drawing.Size(20, 20)
        Me.TXT_Prijs.TabIndex = 24
        Me.TXT_Prijs.TabStop = False
        '
        'Tpage_Product_Journaal
        '
        Me.Tpage_Product_Journaal.Controls.Add(Me.DG_Journaal)
        Me.Tpage_Product_Journaal.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Product_Journaal.Name = "Tpage_Product_Journaal"
        Me.Tpage_Product_Journaal.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Product_Journaal.Size = New System.Drawing.Size(675, 342)
        Me.Tpage_Product_Journaal.TabIndex = 5
        Me.Tpage_Product_Journaal.Text = "Journaalboeking"
        Me.Tpage_Product_Journaal.UseVisualStyleBackColor = True
        '
        'DG_Journaal
        '
        Me.DG_Journaal.AllowUserToAddRows = False
        Me.DG_Journaal.AllowUserToDeleteRows = False
        Me.DG_Journaal.AutoGenerateColumns = False
        Me.DG_Journaal.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DG_Journaal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Journaal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDGetontvangstDataGridViewTextBoxColumn1, Me.IDJournaalPostDataGridViewTextBoxColumn, Me.JPDatumDataGridViewTextBoxColumn, Me.GB_naam, Me.IDGrootboekDataGridViewTextBoxColumn, Me.JPDebetDataGridViewTextBoxColumn, Me.JPCreditDataGridViewTextBoxColumn})
        Me.DG_Journaal.DataSource = Me.JNLijstBindingSource
        Me.DG_Journaal.Location = New System.Drawing.Point(10, 35)
        Me.DG_Journaal.Name = "DG_Journaal"
        Me.DG_Journaal.ReadOnly = True
        Me.DG_Journaal.Size = New System.Drawing.Size(499, 301)
        Me.DG_Journaal.TabIndex = 0
        '
        'IDGetontvangstDataGridViewTextBoxColumn1
        '
        Me.IDGetontvangstDataGridViewTextBoxColumn1.DataPropertyName = "ID_Getontvangst"
        Me.IDGetontvangstDataGridViewTextBoxColumn1.HeaderText = "ID_Getontvangst"
        Me.IDGetontvangstDataGridViewTextBoxColumn1.Name = "IDGetontvangstDataGridViewTextBoxColumn1"
        Me.IDGetontvangstDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDGetontvangstDataGridViewTextBoxColumn1.Visible = False
        '
        'IDJournaalPostDataGridViewTextBoxColumn
        '
        Me.IDJournaalPostDataGridViewTextBoxColumn.DataPropertyName = "ID_JournaalPost"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IDJournaalPostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle22
        Me.IDJournaalPostDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDJournaalPostDataGridViewTextBoxColumn.Name = "IDJournaalPostDataGridViewTextBoxColumn"
        Me.IDJournaalPostDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDJournaalPostDataGridViewTextBoxColumn.Width = 50
        '
        'JPDatumDataGridViewTextBoxColumn
        '
        Me.JPDatumDataGridViewTextBoxColumn.DataPropertyName = "JP_Datum"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.JPDatumDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle23
        Me.JPDatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.JPDatumDataGridViewTextBoxColumn.Name = "JPDatumDataGridViewTextBoxColumn"
        Me.JPDatumDataGridViewTextBoxColumn.ReadOnly = True
        Me.JPDatumDataGridViewTextBoxColumn.Width = 80
        '
        'GB_naam
        '
        Me.GB_naam.DataPropertyName = "GB_naam"
        Me.GB_naam.HeaderText = "Grootboek"
        Me.GB_naam.Name = "GB_naam"
        Me.GB_naam.ReadOnly = True
        Me.GB_naam.Width = 150
        '
        'IDGrootboekDataGridViewTextBoxColumn
        '
        Me.IDGrootboekDataGridViewTextBoxColumn.DataPropertyName = "ID_Grootboek"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IDGrootboekDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle24
        Me.IDGrootboekDataGridViewTextBoxColumn.HeaderText = "Rekening"
        Me.IDGrootboekDataGridViewTextBoxColumn.Name = "IDGrootboekDataGridViewTextBoxColumn"
        Me.IDGrootboekDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDGrootboekDataGridViewTextBoxColumn.Width = 70
        '
        'JPDebetDataGridViewTextBoxColumn
        '
        Me.JPDebetDataGridViewTextBoxColumn.DataPropertyName = "JP_Debet"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.JPDebetDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle25
        Me.JPDebetDataGridViewTextBoxColumn.HeaderText = "Debet"
        Me.JPDebetDataGridViewTextBoxColumn.Name = "JPDebetDataGridViewTextBoxColumn"
        Me.JPDebetDataGridViewTextBoxColumn.ReadOnly = True
        Me.JPDebetDataGridViewTextBoxColumn.Width = 50
        '
        'JPCreditDataGridViewTextBoxColumn
        '
        Me.JPCreditDataGridViewTextBoxColumn.DataPropertyName = "JP_Credit"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.JPCreditDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.JPCreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.JPCreditDataGridViewTextBoxColumn.Name = "JPCreditDataGridViewTextBoxColumn"
        Me.JPCreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.JPCreditDataGridViewTextBoxColumn.Width = 50
        '
        'JNLijstBindingSource
        '
        Me.JNLijstBindingSource.DataMember = "JN_Lijst"
        Me.JNLijstBindingSource.DataSource = Me.DS_Administratie
        '
        'DS_Administratie
        '
        Me.DS_Administratie.DataSetName = "DS_Administratie"
        Me.DS_Administratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdmJournaalBindingSource
        '
        Me.AdmJournaalBindingSource.DataMember = "AdmJournaal"
        Me.AdmJournaalBindingSource.DataSource = Me.DS_Administratie
        '
        'Tpage_Product_Besteld
        '
        Me.Tpage_Product_Besteld.AutoScroll = True
        Me.Tpage_Product_Besteld.Controls.Add(Me.Knop_Bestel_Ontvangst)
        Me.Tpage_Product_Besteld.Controls.Add(Me.CH_AlleBestel)
        Me.Tpage_Product_Besteld.Controls.Add(Me.DG_Besteld)
        Me.Tpage_Product_Besteld.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Product_Besteld.Name = "Tpage_Product_Besteld"
        Me.Tpage_Product_Besteld.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Product_Besteld.Size = New System.Drawing.Size(675, 342)
        Me.Tpage_Product_Besteld.TabIndex = 3
        Me.Tpage_Product_Besteld.Text = "Bestelde producten"
        Me.Tpage_Product_Besteld.UseVisualStyleBackColor = True
        '
        'Knop_Bestel_Ontvangst
        '
        Me.Knop_Bestel_Ontvangst.Location = New System.Drawing.Point(338, 8)
        Me.Knop_Bestel_Ontvangst.Name = "Knop_Bestel_Ontvangst"
        Me.Knop_Bestel_Ontvangst.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Bestel_Ontvangst.TabIndex = 5
        Me.Knop_Bestel_Ontvangst.Text = "Ontvangen"
        Me.Knop_Bestel_Ontvangst.UseVisualStyleBackColor = True
        '
        'CH_AlleBestel
        '
        Me.CH_AlleBestel.AutoSize = True
        Me.CH_AlleBestel.Location = New System.Drawing.Point(13, 12)
        Me.CH_AlleBestel.Name = "CH_AlleBestel"
        Me.CH_AlleBestel.Size = New System.Drawing.Size(102, 17)
        Me.CH_AlleBestel.TabIndex = 4
        Me.CH_AlleBestel.Text = "Alle bestellingen"
        Me.CH_AlleBestel.UseVisualStyleBackColor = True
        '
        'DG_Besteld
        '
        Me.DG_Besteld.AllowUserToAddRows = False
        Me.DG_Besteld.AllowUserToDeleteRows = False
        Me.DG_Besteld.AutoGenerateColumns = False
        Me.DG_Besteld.BackgroundColor = System.Drawing.Color.Linen
        Me.DG_Besteld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Besteld.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.ID_GetProductAdd})
        Me.DG_Besteld.DataSource = Me.GPA_BesteldBindingSource
        Me.DG_Besteld.Location = New System.Drawing.Point(10, 35)
        Me.DG_Besteld.Name = "DG_Besteld"
        Me.DG_Besteld.ReadOnly = True
        Me.DG_Besteld.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Besteld.Size = New System.Drawing.Size(653, 304)
        Me.DG_Besteld.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ID_Supplier"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn12.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 50
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "GV_Datum"
        Me.DataGridViewTextBoxColumn13.HeaderText = "BestelDatum"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "GV_Status"
        Me.DataGridViewTextBoxColumn14.HeaderText = "GV_Status"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 30
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "GP_Besteld"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewTextBoxColumn15.HeaderText = "Aantal"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 50
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ID_Product"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn16.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 50
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PD_Beschrijving(2)"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Beschrijving"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 300
        '
        'ID_GetProductAdd
        '
        Me.ID_GetProductAdd.DataPropertyName = "ID_GetProductAdd"
        Me.ID_GetProductAdd.HeaderText = "ID_GetProductAdd"
        Me.ID_GetProductAdd.Name = "ID_GetProductAdd"
        Me.ID_GetProductAdd.ReadOnly = True
        Me.ID_GetProductAdd.Visible = False
        '
        'GPA_BesteldBindingSource
        '
        Me.GPA_BesteldBindingSource.DataMember = "GPA_Besteld"
        Me.GPA_BesteldBindingSource.DataSource = Me.DS_Product
        '
        'Tpage_Product_Ontvang
        '
        Me.Tpage_Product_Ontvang.Controls.Add(Me.CH_AlleOntvangst)
        Me.Tpage_Product_Ontvang.Controls.Add(Me.DG_ontvangen)
        Me.Tpage_Product_Ontvang.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Product_Ontvang.Name = "Tpage_Product_Ontvang"
        Me.Tpage_Product_Ontvang.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Product_Ontvang.Size = New System.Drawing.Size(675, 342)
        Me.Tpage_Product_Ontvang.TabIndex = 2
        Me.Tpage_Product_Ontvang.Text = "Products ontvangen"
        Me.Tpage_Product_Ontvang.UseVisualStyleBackColor = True
        '
        'CH_AlleOntvangst
        '
        Me.CH_AlleOntvangst.AutoSize = True
        Me.CH_AlleOntvangst.Location = New System.Drawing.Point(13, 12)
        Me.CH_AlleOntvangst.Name = "CH_AlleOntvangst"
        Me.CH_AlleOntvangst.Size = New System.Drawing.Size(105, 17)
        Me.CH_AlleOntvangst.TabIndex = 3
        Me.CH_AlleOntvangst.Text = "Alle ontvangsten"
        Me.CH_AlleOntvangst.UseVisualStyleBackColor = True
        '
        'DG_ontvangen
        '
        Me.DG_ontvangen.AllowUserToAddRows = False
        Me.DG_ontvangen.AllowUserToDeleteRows = False
        Me.DG_ontvangen.AutoGenerateColumns = False
        Me.DG_ontvangen.BackgroundColor = System.Drawing.Color.Azure
        Me.DG_ontvangen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ontvangen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GVDatumDataGridViewTextBoxColumn1, Me.GPOntvangenDataGridViewTextBoxColumn, Me.IDProductDataGridViewTextBoxColumn1, Me.PDBeschrijving2DataGridViewTextBoxColumn, Me.GPBuyPriceEURDataGridViewTextBoxColumn1, Me.PDSalePrijsDataGridViewTextBoxColumn, Me.IDGetOntvangstDataGridViewTextBoxColumn2, Me.IDSupplierDataGridViewTextBoxColumn, Me.IDGetProductAddDataGridViewTextBoxColumn1})
        Me.DG_ontvangen.DataSource = Me.GPAOntvangenLijstBindingSource
        Me.DG_ontvangen.Location = New System.Drawing.Point(10, 35)
        Me.DG_ontvangen.Name = "DG_ontvangen"
        Me.DG_ontvangen.ReadOnly = True
        Me.DG_ontvangen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_ontvangen.Size = New System.Drawing.Size(659, 301)
        Me.DG_ontvangen.TabIndex = 2
        '
        'Tpage_Product_Lijst
        '
        Me.Tpage_Product_Lijst.Controls.Add(Me.Knop_Toon)
        Me.Tpage_Product_Lijst.Controls.Add(Me.Knop_ProductPLus)
        Me.Tpage_Product_Lijst.Controls.Add(Me.DG_Lijst)
        Me.Tpage_Product_Lijst.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Product_Lijst.Name = "Tpage_Product_Lijst"
        Me.Tpage_Product_Lijst.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Product_Lijst.Size = New System.Drawing.Size(675, 342)
        Me.Tpage_Product_Lijst.TabIndex = 1
        Me.Tpage_Product_Lijst.Text = "Productlijst"
        Me.Tpage_Product_Lijst.UseVisualStyleBackColor = True
        '
        'Knop_Toon
        '
        Me.Knop_Toon.Location = New System.Drawing.Point(89, 6)
        Me.Knop_Toon.Name = "Knop_Toon"
        Me.Knop_Toon.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Toon.TabIndex = 2
        Me.Knop_Toon.Text = "Toon"
        Me.Knop_Toon.UseVisualStyleBackColor = True
        '
        'Knop_ProductPLus
        '
        Me.Knop_ProductPLus.Location = New System.Drawing.Point(8, 6)
        Me.Knop_ProductPLus.Name = "Knop_ProductPLus"
        Me.Knop_ProductPLus.Size = New System.Drawing.Size(75, 23)
        Me.Knop_ProductPLus.TabIndex = 1
        Me.Knop_ProductPLus.Text = "Product +"
        Me.Knop_ProductPLus.UseVisualStyleBackColor = True
        '
        'DG_Lijst
        '
        Me.DG_Lijst.AllowUserToAddRows = False
        Me.DG_Lijst.AllowUserToDeleteRows = False
        Me.DG_Lijst.AutoGenerateColumns = False
        Me.DG_Lijst.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DG_Lijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Lijst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.PD_Sale_Prijs, Me.DataGridViewTextBoxColumn10})
        Me.DG_Lijst.DataSource = Me.GetProductListBindingSource
        Me.DG_Lijst.Location = New System.Drawing.Point(10, 35)
        Me.DG_Lijst.MultiSelect = False
        Me.DG_Lijst.Name = "DG_Lijst"
        Me.DG_Lijst.ReadOnly = True
        Me.DG_Lijst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Lijst.Size = New System.Drawing.Size(649, 299)
        Me.DG_Lijst.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_GetProductAdd"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID_GetProductAdd"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_GetOntvangst"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_GetOntvangst"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID_Product"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn5.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "GP__Ontvangen"
        Me.DataGridViewTextBoxColumn9.HeaderText = "GP__Ontvangen"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "GP_Besteld"
        Me.DataGridViewTextBoxColumn8.HeaderText = "GP_Besteld"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "GP_Lijst"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridViewTextBoxColumn7.HeaderText = "aantal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PD_Beschrijving(2)"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Beschrijving"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PD_Voorraad"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewTextBoxColumn4.HeaderText = "Voorraad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GP_BuyPriceEUR"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewTextBoxColumn3.HeaderText = "Inkoop"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'PD_Sale_Prijs
        '
        Me.PD_Sale_Prijs.DataPropertyName = "PD_Sale_Prijs"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PD_Sale_Prijs.DefaultCellStyle = DataGridViewCellStyle34
        Me.PD_Sale_Prijs.HeaderText = "Verkoop"
        Me.PD_Sale_Prijs.Name = "PD_Sale_Prijs"
        Me.PD_Sale_Prijs.ReadOnly = True
        Me.PD_Sale_Prijs.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "LK_Code"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle35
        Me.DataGridViewTextBoxColumn10.HeaderText = "Locatie"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 90
        '
        'TB_Products
        '
        Me.TB_Products.Controls.Add(Me.Tpage_Product_Lijst)
        Me.TB_Products.Controls.Add(Me.Tpage_Product_Ontvang)
        Me.TB_Products.Controls.Add(Me.Tpage_Product_Besteld)
        Me.TB_Products.Controls.Add(Me.Tpage_Product_Journaal)
        Me.TB_Products.ItemSize = New System.Drawing.Size(170, 18)
        Me.TB_Products.Location = New System.Drawing.Point(16, 263)
        Me.TB_Products.Name = "TB_Products"
        Me.TB_Products.SelectedIndex = 0
        Me.TB_Products.Size = New System.Drawing.Size(683, 368)
        Me.TB_Products.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TB_Products.TabIndex = 17
        '
        'GB_Hulpvelden
        '
        Me.GB_Hulpvelden.Controls.Add(Me.TXT_ontvangen)
        Me.GB_Hulpvelden.Controls.Add(Me.TXT_Voorraad)
        Me.GB_Hulpvelden.Controls.Add(Me.TXT_LijstAantal)
        Me.GB_Hulpvelden.Controls.Add(Me.TXT_Prijs)
        Me.GB_Hulpvelden.Controls.Add(Me.TXT_besteld)
        Me.GB_Hulpvelden.Controls.Add(Me.Knop_Sluiten)
        Me.GB_Hulpvelden.Location = New System.Drawing.Point(562, 4)
        Me.GB_Hulpvelden.Name = "GB_Hulpvelden"
        Me.GB_Hulpvelden.Size = New System.Drawing.Size(133, 257)
        Me.GB_Hulpvelden.TabIndex = 26
        Me.GB_Hulpvelden.TabStop = False
        '
        'GPA_BesteldTableAdapter
        '
        Me.GPA_BesteldTableAdapter.ClearBeforeFill = True
        '
        'Optie_Open
        '
        Me.Optie_Open.Appearance = System.Windows.Forms.Appearance.Button
        Me.Optie_Open.Location = New System.Drawing.Point(10, 20)
        Me.Optie_Open.Name = "Optie_Open"
        Me.Optie_Open.Size = New System.Drawing.Size(70, 23)
        Me.Optie_Open.TabIndex = 21
        Me.Optie_Open.TabStop = True
        Me.Optie_Open.Text = "Open"
        Me.Optie_Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Optie_Open.UseVisualStyleBackColor = True
        '
        'Optie_Ontvangst
        '
        Me.Optie_Ontvangst.Appearance = System.Windows.Forms.Appearance.Button
        Me.Optie_Ontvangst.Location = New System.Drawing.Point(10, 47)
        Me.Optie_Ontvangst.Name = "Optie_Ontvangst"
        Me.Optie_Ontvangst.Size = New System.Drawing.Size(70, 23)
        Me.Optie_Ontvangst.TabIndex = 22
        Me.Optie_Ontvangst.TabStop = True
        Me.Optie_Ontvangst.Text = "Ontvangen"
        Me.Optie_Ontvangst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Optie_Ontvangst.UseVisualStyleBackColor = True
        '
        'Optie_besteld
        '
        Me.Optie_besteld.Appearance = System.Windows.Forms.Appearance.Button
        Me.Optie_besteld.Location = New System.Drawing.Point(86, 47)
        Me.Optie_besteld.Name = "Optie_besteld"
        Me.Optie_besteld.Size = New System.Drawing.Size(70, 23)
        Me.Optie_besteld.TabIndex = 23
        Me.Optie_besteld.TabStop = True
        Me.Optie_besteld.Text = "Besteld"
        Me.Optie_besteld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Optie_besteld.UseVisualStyleBackColor = True
        '
        'Optie_Verbruik
        '
        Me.Optie_Verbruik.Appearance = System.Windows.Forms.Appearance.Button
        Me.Optie_Verbruik.Location = New System.Drawing.Point(10, 76)
        Me.Optie_Verbruik.Name = "Optie_Verbruik"
        Me.Optie_Verbruik.Size = New System.Drawing.Size(70, 23)
        Me.Optie_Verbruik.TabIndex = 24
        Me.Optie_Verbruik.TabStop = True
        Me.Optie_Verbruik.Text = "Verbruikt"
        Me.Optie_Verbruik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Optie_Verbruik.UseVisualStyleBackColor = True
        '
        'Optie_Project
        '
        Me.Optie_Project.Appearance = System.Windows.Forms.Appearance.Button
        Me.Optie_Project.Location = New System.Drawing.Point(86, 76)
        Me.Optie_Project.Name = "Optie_Project"
        Me.Optie_Project.Size = New System.Drawing.Size(70, 23)
        Me.Optie_Project.TabIndex = 25
        Me.Optie_Project.TabStop = True
        Me.Optie_Project.Text = "Project"
        Me.Optie_Project.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Optie_Project.UseVisualStyleBackColor = True
        '
        'GB_Sectie
        '
        Me.GB_Sectie.Controls.Add(Me.Optie_Open)
        Me.GB_Sectie.Controls.Add(Me.Optie_Ontvangst)
        Me.GB_Sectie.Controls.Add(Me.Optie_besteld)
        Me.GB_Sectie.Controls.Add(Me.Optie_Verbruik)
        Me.GB_Sectie.Controls.Add(Me.Optie_Project)
        Me.GB_Sectie.Location = New System.Drawing.Point(384, 4)
        Me.GB_Sectie.Name = "GB_Sectie"
        Me.GB_Sectie.Size = New System.Drawing.Size(172, 118)
        Me.GB_Sectie.TabIndex = 27
        Me.GB_Sectie.TabStop = False
        '
        'BTWTableAdapter
        '
        Me.BTWTableAdapter.ClearBeforeFill = True
        '
        'AdmJournaalTableAdapter
        '
        Me.AdmJournaalTableAdapter.ClearBeforeFill = True
        '
        'JN_LijstDatatable
        '
        Me.JN_LijstDatatable.ClearBeforeFill = True
        '
        'GVDatumDataGridViewTextBoxColumn
        '
        Me.GVDatumDataGridViewTextBoxColumn.DataPropertyName = "GV_Datum"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GVDatumDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle36
        Me.GVDatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.GVDatumDataGridViewTextBoxColumn.Name = "GVDatumDataGridViewTextBoxColumn"
        Me.GVDatumDataGridViewTextBoxColumn.Width = 70
        '
        'IDProductDataGridViewTextBoxColumn2
        '
        Me.IDProductDataGridViewTextBoxColumn2.DataPropertyName = "ID_Product"
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IDProductDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle37
        Me.IDProductDataGridViewTextBoxColumn2.HeaderText = "Product"
        Me.IDProductDataGridViewTextBoxColumn2.Name = "IDProductDataGridViewTextBoxColumn2"
        Me.IDProductDataGridViewTextBoxColumn2.Width = 50
        '
        'GVDatumDataGridViewTextBoxColumn1
        '
        Me.GVDatumDataGridViewTextBoxColumn1.DataPropertyName = "GV_Datum"
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GVDatumDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle38
        Me.GVDatumDataGridViewTextBoxColumn1.HeaderText = "Datum"
        Me.GVDatumDataGridViewTextBoxColumn1.Name = "GVDatumDataGridViewTextBoxColumn1"
        Me.GVDatumDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GVDatumDataGridViewTextBoxColumn1.Width = 70
        '
        'GPOntvangenDataGridViewTextBoxColumn
        '
        Me.GPOntvangenDataGridViewTextBoxColumn.DataPropertyName = "GP__Ontvangen"
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GPOntvangenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle39
        Me.GPOntvangenDataGridViewTextBoxColumn.HeaderText = "Aantal"
        Me.GPOntvangenDataGridViewTextBoxColumn.Name = "GPOntvangenDataGridViewTextBoxColumn"
        Me.GPOntvangenDataGridViewTextBoxColumn.ReadOnly = True
        Me.GPOntvangenDataGridViewTextBoxColumn.Width = 50
        '
        'IDProductDataGridViewTextBoxColumn1
        '
        Me.IDProductDataGridViewTextBoxColumn1.DataPropertyName = "ID_Product"
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IDProductDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle40
        Me.IDProductDataGridViewTextBoxColumn1.HeaderText = "Product"
        Me.IDProductDataGridViewTextBoxColumn1.Name = "IDProductDataGridViewTextBoxColumn1"
        Me.IDProductDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDProductDataGridViewTextBoxColumn1.Width = 60
        '
        'PDBeschrijving2DataGridViewTextBoxColumn
        '
        Me.PDBeschrijving2DataGridViewTextBoxColumn.DataPropertyName = "PD_Beschrijving(2)"
        Me.PDBeschrijving2DataGridViewTextBoxColumn.HeaderText = "Beschrijving"
        Me.PDBeschrijving2DataGridViewTextBoxColumn.Name = "PDBeschrijving2DataGridViewTextBoxColumn"
        Me.PDBeschrijving2DataGridViewTextBoxColumn.ReadOnly = True
        Me.PDBeschrijving2DataGridViewTextBoxColumn.Width = 300
        '
        'GPBuyPriceEURDataGridViewTextBoxColumn1
        '
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.DataPropertyName = "GP_BuyPriceEUR"
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle41
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.HeaderText = "Inkoop"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.Name = "GPBuyPriceEURDataGridViewTextBoxColumn1"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.Width = 50
        '
        'PDSalePrijsDataGridViewTextBoxColumn
        '
        Me.PDSalePrijsDataGridViewTextBoxColumn.DataPropertyName = "PD_Sale_Prijs"
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PDSalePrijsDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle42
        Me.PDSalePrijsDataGridViewTextBoxColumn.HeaderText = "Verkoop"
        Me.PDSalePrijsDataGridViewTextBoxColumn.Name = "PDSalePrijsDataGridViewTextBoxColumn"
        Me.PDSalePrijsDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDSalePrijsDataGridViewTextBoxColumn.Width = 50
        '
        'IDGetOntvangstDataGridViewTextBoxColumn2
        '
        Me.IDGetOntvangstDataGridViewTextBoxColumn2.DataPropertyName = "ID_GetOntvangst"
        Me.IDGetOntvangstDataGridViewTextBoxColumn2.HeaderText = "ID_GetOntvangst"
        Me.IDGetOntvangstDataGridViewTextBoxColumn2.Name = "IDGetOntvangstDataGridViewTextBoxColumn2"
        Me.IDGetOntvangstDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IDGetOntvangstDataGridViewTextBoxColumn2.Visible = False
        '
        'IDSupplierDataGridViewTextBoxColumn
        '
        Me.IDSupplierDataGridViewTextBoxColumn.DataPropertyName = "ID_Supplier"
        Me.IDSupplierDataGridViewTextBoxColumn.HeaderText = "ID_Supplier"
        Me.IDSupplierDataGridViewTextBoxColumn.Name = "IDSupplierDataGridViewTextBoxColumn"
        Me.IDSupplierDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDSupplierDataGridViewTextBoxColumn.Visible = False
        '
        'IDGetProductAddDataGridViewTextBoxColumn1
        '
        Me.IDGetProductAddDataGridViewTextBoxColumn1.DataPropertyName = "ID_GetProductAdd"
        Me.IDGetProductAddDataGridViewTextBoxColumn1.HeaderText = "ID_GetProductAdd"
        Me.IDGetProductAddDataGridViewTextBoxColumn1.Name = "IDGetProductAddDataGridViewTextBoxColumn1"
        Me.IDGetProductAddDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDGetProductAddDataGridViewTextBoxColumn1.Visible = False
        '
        'F_GetProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 642)
        Me.Controls.Add(Me.GB_Sectie)
        Me.Controls.Add(Me.GB_Hulpvelden)
        Me.Controls.Add(Me.TB_Products)
        Me.Controls.Add(Me.TB_Doel)
        Me.Controls.Add(Me.GB_Get)
        Me.Name = "F_GetProduct"
        Me.Text = "Product-Lijsten"
        CType(Me.GetOntvangstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPAOntvangenLijstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPA_AantalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Get.ResumeLayout(False)
        Me.GB_Get.PerformLayout()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB_Doel.ResumeLayout(False)
        Me.TPage_Doel_Ontvang.ResumeLayout(False)
        Me.TPage_Doel_Ontvang.PerformLayout()
        Me.Tpage_Doel_Bestel.ResumeLayout(False)
        Me.Tpage_Doel_Bestel.PerformLayout()
        Me.Tpage_Doel_Project.ResumeLayout(False)
        Me.Tpage_Doel_Project.PerformLayout()
        Me.Tpage_Doel_Sale.ResumeLayout(False)
        Me.Tpage_Doel_Sale.PerformLayout()
        CType(Me.BTWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Product_Journaal.ResumeLayout(False)
        CType(Me.DG_Journaal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JNLijstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmJournaalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Product_Besteld.ResumeLayout(False)
        Me.Tpage_Product_Besteld.PerformLayout()
        CType(Me.DG_Besteld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPA_BesteldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Product_Ontvang.ResumeLayout(False)
        Me.Tpage_Product_Ontvang.PerformLayout()
        CType(Me.DG_ontvangen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Product_Lijst.ResumeLayout(False)
        CType(Me.DG_Lijst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB_Products.ResumeLayout(False)
        Me.GB_Hulpvelden.ResumeLayout(False)
        Me.GB_Hulpvelden.PerformLayout()
        Me.GB_Sectie.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CB_Shop As ComboBox
    Friend WithEvents GB_Get As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_Ontvangen As ComboBox
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents GetOntvangstBindingSource As BindingSource
    Friend WithEvents GetOntvangstTableAdapter As DS_ProductTableAdapters.GetOntvangstTableAdapter
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents TXT_getontvangstid As TextBox
    Friend WithEvents Knop_Sluiten As Button
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DS_ProductTableAdapters.SupplierTableAdapter
    Friend WithEvents CB_Supplier As ComboBox
    Friend WithEvents TXT_NaamGet As TextBox
    Friend WithEvents ShopBindingSource As BindingSource
    Friend WithEvents ShopTableAdapter As DS_ProductTableAdapters.ShopTableAdapter
    Friend WithEvents Knop_DetailsShop As Button
    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents Knop_BoekOntvangst As Button
    Friend WithEvents DT_productBindingSource As BindingSource
    Friend WithEvents DT_productTableAdapter As DS_ProductTableAdapters.DT_productTableAdapter
    Friend WithEvents GetProductAddBindingSource As BindingSource
    Friend WithEvents GetProductAddTableAdapter As DS_ProductTableAdapters.GetProductAddTableAdapter
    Friend WithEvents Knop_Supplier As Button
    Friend WithEvents Knop_Kosten As Button
    Friend WithEvents TXT_AdmInkoop As TextBox
    Friend WithEvents TXT_Boekwaarde As TextBox
    Friend WithEvents TXT_Lijstwaarde As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents txt_Status As TextBox
    Friend WithEvents PD_Voorraad As DataGridViewTextBoxColumn
    Friend WithEvents GPBuyPriceEURDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LK_Code As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents GP_Lijst As DataGridViewTextBoxColumn
    Friend WithEvents GP_Besteld As DataGridViewTextBoxColumn
    Friend WithEvents GP__Ontvangen As DataGridViewTextBoxColumn
    Friend WithEvents IDProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGetProductAddDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGetOntvangstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPA_AantalBindingSource As BindingSource
    Friend WithEvents GPA_AantalTableAdapter As DS_ProductTableAdapters.GPA_AantalTableAdapter
    Friend WithEvents GPAOntvangenLijstBindingSource As BindingSource
    Friend WithEvents GPA_OntvangenLijstTableAdaptor_ As DS_ProductTableAdapters.GPA_OntvangenLijstTableAdaptor_
    Friend WithEvents GetProductListBindingSource As BindingSource
    Friend WithEvents GetProductListTableAdapter As DS_ProductTableAdapters.GetProductListTableAdapter
    Friend WithEvents TB_Doel As TabControl
    Friend WithEvents TPage_Doel_Ontvang As TabPage
    Friend WithEvents Tpage_Doel_Bestel As TabPage
    Friend WithEvents TXT_Voorraad As TextBox
    Friend WithEvents TXT_LijstAantal As TextBox
    Friend WithEvents TXT_ontvangen As TextBox
    Friend WithEvents TXT_besteld As TextBox
    Friend WithEvents TXT_Prijs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_Kenmerk As TextBox
    Friend WithEvents Knop_Bestelling As Button
    Friend WithEvents Tpage_Product_Journaal As TabPage
    Friend WithEvents Tpage_Product_Besteld As TabPage
    Friend WithEvents Tpage_Product_Ontvang As TabPage
    Friend WithEvents DG_ontvangen As DataGridView
    Friend WithEvents Tpage_Product_Lijst As TabPage
    Friend WithEvents Knop_Toon As Button
    Friend WithEvents Knop_ProductPLus As Button
    Friend WithEvents DG_Lijst As DataGridView
    Friend WithEvents TB_Products As TabControl
    Friend WithEvents GB_Hulpvelden As GroupBox
    Friend WithEvents GPA_BesteldBindingSource As BindingSource
    Friend WithEvents GPA_BesteldTableAdapter As DS_ProductTableAdapters.GPA_BesteldTableAdapter
    Friend WithEvents DG_Besteld As DataGridView
    Friend WithEvents Optie_Open As RadioButton
    Friend WithEvents Optie_Verbruik As RadioButton
    Friend WithEvents Optie_besteld As RadioButton
    Friend WithEvents Optie_Ontvangst As RadioButton
    Friend WithEvents Optie_Project As RadioButton
    Friend WithEvents GB_Sectie As GroupBox
    Friend WithEvents CH_AlleBestel As CheckBox
    Friend WithEvents CH_AlleOntvangst As CheckBox
    Friend WithEvents Tpage_Doel_Project As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents TXT_Project_Prijs As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_Project_SomVerkoop As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_Project_SomInkoop As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_Project_AantalParts As TextBox
    Friend WithEvents Knop_Project_Product As Button
    Friend WithEvents TXT_Project_ProductID As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TXT_Project_Max As TextBox
    Friend WithEvents Knop_Project_Build As Button
    Friend WithEvents TXT_Project_AantalMaak As TextBox
    Friend WithEvents Knop_project_maak As Button
    Friend WithEvents Knop_Project_bereken As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TXT_Project_Voorraad As TextBox
    Friend WithEvents Tpage_Doel_Sale As TabPage
    Friend WithEvents CB_Push_soort As ComboBox
    Friend WithEvents Knop_Push_Maak As Button
    Friend WithEvents Knop_Push_Bereken As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents TXT_Push_Verkoop As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TXT_Push_BTW As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TXT_Push_Omzet As TextBox
    Friend WithEvents TXT_Push_Inkoop As TextBox
    Friend WithEvents LBL_Push_Btw As Label
    Friend WithEvents BTWBindingSource As BindingSource
    Friend WithEvents BTWTableAdapter As DS_ProductTableAdapters.BTWTableAdapter
    Friend WithEvents DG_Journaal As DataGridView
    Friend WithEvents AdmJournaalBindingSource As BindingSource
    Friend WithEvents DS_Administratie As DS_Administratie
    Friend WithEvents AdmJournaalTableAdapter As DS_AdministratieTableAdapters.AdmJournaalTableAdapter
    Friend WithEvents Label22 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TXT_Push_Kas As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TXT_Push_Bank As TextBox
    Friend WithEvents JNLijstBindingSource As BindingSource
    Friend WithEvents JN_LijstDatatable As DS_AdministratieTableAdapters.JN_LijstDatatable
    Friend WithEvents IDGetontvangstDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDJournaalPostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JPDatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GB_naam As DataGridViewTextBoxColumn
    Friend WithEvents IDGrootboekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JPDebetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JPCreditDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents ID_GetProductAdd As DataGridViewTextBoxColumn
    Friend WithEvents Knop_Bestel_Ontvangst As Button
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PD_Sale_Prijs As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DA_Datum As DateTimePicker
    Friend WithEvents GVDatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDProductDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GVDatumDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GPOntvangenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDProductDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PDBeschrijving2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPBuyPriceEURDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PDSalePrijsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGetOntvangstDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDSupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGetProductAddDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class

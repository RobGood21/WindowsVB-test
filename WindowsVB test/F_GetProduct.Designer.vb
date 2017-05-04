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
        Me.GB_Supplier = New System.Windows.Forms.GroupBox()
        Me.Knop_Supplier = New System.Windows.Forms.Button()
        Me.Knop_DetailsShop = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_Shop = New System.Windows.Forms.ComboBox()
        Me.GetOntvangstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.ShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Supplier = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GB_Products = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_Prijs = New System.Windows.Forms.TextBox()
        Me.GPA_AantalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTbesteld = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_ontvangen = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_Products = New System.Windows.Forms.TabControl()
        Me.Tpage_Lijst = New System.Windows.Forms.TabPage()
        Me.Knop_Toon = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DG_Lijst = New System.Windows.Forms.DataGridView()
        Me.IDGetProductAddDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGetOntvangstDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPOntvangenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPBesteldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPLijstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LKCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDVoorraadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knop_ProductPlus = New System.Windows.Forms.Button()
        Me.Tpage_Besteld = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tpage_Leveren = New System.Windows.Forms.TabPage()
        Me.DG_ontvangen = New System.Windows.Forms.DataGridView()
        Me.GVDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProDuctDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPOntvangenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPBuyPriceEURDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDSalePrijsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPAOntvangenLijstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tpage_advies = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tpage_TeLeveren = New System.Windows.Forms.TabPage()
        Me.TXT_LijstAantal = New System.Windows.Forms.TextBox()
        Me.TXT_Voorraad = New System.Windows.Forms.TextBox()
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Knop_Kosten = New System.Windows.Forms.Button()
        Me.Knop_BoekOntvangst = New System.Windows.Forms.Button()
        Me.GB_Get = New System.Windows.Forms.GroupBox()
        Me.txt_Status = New System.Windows.Forms.TextBox()
        Me.DA_Datum = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NaamGet = New System.Windows.Forms.TextBox()
        Me.TXT_getontvangstid = New System.Windows.Forms.TextBox()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.CB_Ontvangen = New System.Windows.Forms.ComboBox()
        Me.GetOntvangstTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetOntvangstTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.SupplierTableAdapter()
        Me.TXT_output = New System.Windows.Forms.TextBox()
        Me.ShopTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ShopTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Knop_update = New System.Windows.Forms.Button()
        Me.Knop_OpslaanDB = New System.Windows.Forms.Button()
        Me.DT_productTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.DT_productTableAdapter()
        Me.GetProductAddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetProductAddTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductAddTableAdapter()
        Me.TXT_AdmInkoop = New System.Windows.Forms.TextBox()
        Me.GB_Kosten = New System.Windows.Forms.GroupBox()
        Me.TXT_Lijstwaarde = New System.Windows.Forms.TextBox()
        Me.TXT_Boekwaarde = New System.Windows.Forms.TextBox()
        Me.GetProductListTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductListTableAdapter()
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
        Me.GB_bestelling = New System.Windows.Forms.GroupBox()
        GV_DatumLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.GB_Supplier.SuspendLayout()
        CType(Me.GetOntvangstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Products.SuspendLayout()
        CType(Me.GPA_AantalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB_Products.SuspendLayout()
        Me.Tpage_Lijst.SuspendLayout()
        CType(Me.DG_Lijst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Besteld.SuspendLayout()
        Me.Tpage_Leveren.SuspendLayout()
        CType(Me.DG_ontvangen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPAOntvangenLijstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_advies.SuspendLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Get.SuspendLayout()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Kosten.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV_DatumLabel
        '
        GV_DatumLabel.AutoSize = True
        GV_DatumLabel.Location = New System.Drawing.Point(23, 47)
        GV_DatumLabel.Name = "GV_DatumLabel"
        GV_DatumLabel.Size = New System.Drawing.Size(41, 13)
        GV_DatumLabel.TabIndex = 5
        GV_DatumLabel.Text = "Datum:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(18, 56)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(70, 13)
        Label4.TabIndex = 14
        Label4.Text = "Boekwaarde:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(18, 79)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(63, 13)
        Label5.TabIndex = 16
        Label5.Text = "Lijstwaarde:"
        '
        'GB_Supplier
        '
        Me.GB_Supplier.Controls.Add(Me.Knop_Supplier)
        Me.GB_Supplier.Controls.Add(Me.Knop_DetailsShop)
        Me.GB_Supplier.Controls.Add(Me.Label2)
        Me.GB_Supplier.Controls.Add(Me.CB_Shop)
        Me.GB_Supplier.Controls.Add(Me.Label1)
        Me.GB_Supplier.Controls.Add(Me.CB_Supplier)
        Me.GB_Supplier.Location = New System.Drawing.Point(12, 135)
        Me.GB_Supplier.Name = "GB_Supplier"
        Me.GB_Supplier.Size = New System.Drawing.Size(450, 82)
        Me.GB_Supplier.TabIndex = 0
        Me.GB_Supplier.TabStop = False
        Me.GB_Supplier.Text = "Herkomst:"
        '
        'Knop_Supplier
        '
        Me.Knop_Supplier.Location = New System.Drawing.Point(354, 17)
        Me.Knop_Supplier.Name = "Knop_Supplier"
        Me.Knop_Supplier.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Supplier.TabIndex = 6
        Me.Knop_Supplier.Text = "&Leverancier"
        Me.Knop_Supplier.UseVisualStyleBackColor = True
        '
        'Knop_DetailsShop
        '
        Me.Knop_DetailsShop.Location = New System.Drawing.Point(354, 41)
        Me.Knop_DetailsShop.Name = "Knop_DetailsShop"
        Me.Knop_DetailsShop.Size = New System.Drawing.Size(75, 23)
        Me.Knop_DetailsShop.TabIndex = 5
        Me.Knop_DetailsShop.Text = "&Shop"
        Me.Knop_DetailsShop.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Shop:"
        '
        'CB_Shop
        '
        Me.CB_Shop.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GetOntvangstBindingSource, "ID_Shop", True))
        Me.CB_Shop.DataSource = Me.ShopBindingSource
        Me.CB_Shop.DisplayMember = "SH_Naam"
        Me.CB_Shop.FormattingEnabled = True
        Me.CB_Shop.Location = New System.Drawing.Point(86, 42)
        Me.CB_Shop.Name = "CB_Shop"
        Me.CB_Shop.Size = New System.Drawing.Size(262, 21)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Leverancier:"
        '
        'CB_Supplier
        '
        Me.CB_Supplier.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GetOntvangstBindingSource, "ID_Supplier", True))
        Me.CB_Supplier.DataSource = Me.SupplierBindingSource
        Me.CB_Supplier.DisplayMember = "SP_Naam"
        Me.CB_Supplier.FormattingEnabled = True
        Me.CB_Supplier.Location = New System.Drawing.Point(86, 19)
        Me.CB_Supplier.Name = "CB_Supplier"
        Me.CB_Supplier.Size = New System.Drawing.Size(262, 21)
        Me.CB_Supplier.TabIndex = 0
        Me.CB_Supplier.ValueMember = "ID_Supplier"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Product
        '
        'GB_Products
        '
        Me.GB_Products.Controls.Add(Me.Label14)
        Me.GB_Products.Controls.Add(Me.TXT_Prijs)
        Me.GB_Products.Controls.Add(Me.Label13)
        Me.GB_Products.Controls.Add(Me.TXTbesteld)
        Me.GB_Products.Controls.Add(Me.Label12)
        Me.GB_Products.Controls.Add(Me.TXT_ontvangen)
        Me.GB_Products.Controls.Add(Me.Label11)
        Me.GB_Products.Controls.Add(Me.Label10)
        Me.GB_Products.Controls.Add(Me.TB_Products)
        Me.GB_Products.Controls.Add(Me.TXT_LijstAantal)
        Me.GB_Products.Controls.Add(Me.TXT_Voorraad)
        Me.GB_Products.Location = New System.Drawing.Point(12, 223)
        Me.GB_Products.Name = "GB_Products"
        Me.GB_Products.Size = New System.Drawing.Size(963, 412)
        Me.GB_Products.TabIndex = 1
        Me.GB_Products.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(842, 221)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "prijs (laatste inkoop)"
        '
        'TXT_Prijs
        '
        Me.TXT_Prijs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_BuyPriceEUR", True))
        Me.TXT_Prijs.Location = New System.Drawing.Point(870, 237)
        Me.TXT_Prijs.Name = "TXT_Prijs"
        Me.TXT_Prijs.Size = New System.Drawing.Size(43, 20)
        Me.TXT_Prijs.TabIndex = 24
        '
        'GPA_AantalBindingSource
        '
        Me.GPA_AantalBindingSource.DataMember = "GPA_Aantal"
        Me.GPA_AantalBindingSource.DataSource = Me.DS_Product
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(842, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "besteld"
        '
        'TXTbesteld
        '
        Me.TXTbesteld.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_Besteld", True))
        Me.TXTbesteld.Location = New System.Drawing.Point(870, 194)
        Me.TXTbesteld.Name = "TXTbesteld"
        Me.TXTbesteld.Size = New System.Drawing.Size(43, 20)
        Me.TXTbesteld.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(842, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Ontvangen"
        '
        'TXT_ontvangen
        '
        Me.TXT_ontvangen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP__Ontvangen", True))
        Me.TXT_ontvangen.Location = New System.Drawing.Point(870, 148)
        Me.TXT_ontvangen.Name = "TXT_ontvangen"
        Me.TXT_ontvangen.Size = New System.Drawing.Size(43, 20)
        Me.TXT_ontvangen.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(842, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "lijstaantal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(842, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "voorraad"
        '
        'TB_Products
        '
        Me.TB_Products.Controls.Add(Me.Tpage_Lijst)
        Me.TB_Products.Controls.Add(Me.Tpage_Besteld)
        Me.TB_Products.Controls.Add(Me.Tpage_Leveren)
        Me.TB_Products.Controls.Add(Me.Tpage_advies)
        Me.TB_Products.Controls.Add(Me.Tpage_TeLeveren)
        Me.TB_Products.ItemSize = New System.Drawing.Size(150, 18)
        Me.TB_Products.Location = New System.Drawing.Point(5, 19)
        Me.TB_Products.Name = "TB_Products"
        Me.TB_Products.SelectedIndex = 0
        Me.TB_Products.Size = New System.Drawing.Size(813, 359)
        Me.TB_Products.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TB_Products.TabIndex = 17
        '
        'Tpage_Lijst
        '
        Me.Tpage_Lijst.Controls.Add(Me.Knop_Toon)
        Me.Tpage_Lijst.Controls.Add(Me.Label6)
        Me.Tpage_Lijst.Controls.Add(Me.DG_Lijst)
        Me.Tpage_Lijst.Controls.Add(Me.Knop_ProductPlus)
        Me.Tpage_Lijst.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Lijst.Name = "Tpage_Lijst"
        Me.Tpage_Lijst.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Lijst.Size = New System.Drawing.Size(805, 333)
        Me.Tpage_Lijst.TabIndex = 0
        Me.Tpage_Lijst.Text = "Productlijst"
        Me.Tpage_Lijst.UseVisualStyleBackColor = True
        '
        'Knop_Toon
        '
        Me.Knop_Toon.Location = New System.Drawing.Point(134, 6)
        Me.Knop_Toon.Name = "Knop_Toon"
        Me.Knop_Toon.Size = New System.Drawing.Size(111, 23)
        Me.Knop_Toon.TabIndex = 17
        Me.Knop_Toon.Text = "Toon Product"
        Me.Knop_Toon.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 0
        '
        'DG_Lijst
        '
        Me.DG_Lijst.AllowUserToAddRows = False
        Me.DG_Lijst.AutoGenerateColumns = False
        Me.DG_Lijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Lijst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDGetProductAddDataGridViewTextBoxColumn1, Me.IDProductDataGridViewTextBoxColumn1, Me.IDGetOntvangstDataGridViewTextBoxColumn1, Me.GPOntvangenDataGridViewTextBoxColumn, Me.GPBesteldDataGridViewTextBoxColumn, Me.GPLijstDataGridViewTextBoxColumn, Me.ProductDataGridViewTextBoxColumn, Me.LKCodeDataGridViewTextBoxColumn, Me.GPBuyPriceEURDataGridViewTextBoxColumn1, Me.PDVoorraadDataGridViewTextBoxColumn})
        Me.DG_Lijst.DataSource = Me.GetProductListBindingSource
        Me.DG_Lijst.Location = New System.Drawing.Point(0, 35)
        Me.DG_Lijst.Name = "DG_Lijst"
        Me.DG_Lijst.ReadOnly = True
        Me.DG_Lijst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Lijst.Size = New System.Drawing.Size(766, 217)
        Me.DG_Lijst.TabIndex = 16
        '
        'IDGetProductAddDataGridViewTextBoxColumn1
        '
        Me.IDGetProductAddDataGridViewTextBoxColumn1.DataPropertyName = "ID_GetProductAdd"
        Me.IDGetProductAddDataGridViewTextBoxColumn1.HeaderText = "ID_GetProductAdd"
        Me.IDGetProductAddDataGridViewTextBoxColumn1.Name = "IDGetProductAddDataGridViewTextBoxColumn1"
        Me.IDGetProductAddDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDGetProductAddDataGridViewTextBoxColumn1.Visible = False
        '
        'IDProductDataGridViewTextBoxColumn1
        '
        Me.IDProductDataGridViewTextBoxColumn1.DataPropertyName = "ID_Product"
        Me.IDProductDataGridViewTextBoxColumn1.HeaderText = "ID_Product"
        Me.IDProductDataGridViewTextBoxColumn1.Name = "IDProductDataGridViewTextBoxColumn1"
        Me.IDProductDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDProductDataGridViewTextBoxColumn1.Visible = False
        '
        'IDGetOntvangstDataGridViewTextBoxColumn1
        '
        Me.IDGetOntvangstDataGridViewTextBoxColumn1.DataPropertyName = "ID_GetOntvangst"
        Me.IDGetOntvangstDataGridViewTextBoxColumn1.HeaderText = "ID_GetOntvangst"
        Me.IDGetOntvangstDataGridViewTextBoxColumn1.Name = "IDGetOntvangstDataGridViewTextBoxColumn1"
        Me.IDGetOntvangstDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDGetOntvangstDataGridViewTextBoxColumn1.Visible = False
        '
        'GPOntvangenDataGridViewTextBoxColumn
        '
        Me.GPOntvangenDataGridViewTextBoxColumn.DataPropertyName = "GP__Ontvangen"
        Me.GPOntvangenDataGridViewTextBoxColumn.HeaderText = "GP__Ontvangen"
        Me.GPOntvangenDataGridViewTextBoxColumn.Name = "GPOntvangenDataGridViewTextBoxColumn"
        Me.GPOntvangenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GPBesteldDataGridViewTextBoxColumn
        '
        Me.GPBesteldDataGridViewTextBoxColumn.DataPropertyName = "GP_Besteld"
        Me.GPBesteldDataGridViewTextBoxColumn.HeaderText = "GP_Besteld"
        Me.GPBesteldDataGridViewTextBoxColumn.Name = "GPBesteldDataGridViewTextBoxColumn"
        Me.GPBesteldDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GPLijstDataGridViewTextBoxColumn
        '
        Me.GPLijstDataGridViewTextBoxColumn.DataPropertyName = "GP_Lijst"
        Me.GPLijstDataGridViewTextBoxColumn.HeaderText = "GP_Lijst"
        Me.GPLijstDataGridViewTextBoxColumn.Name = "GPLijstDataGridViewTextBoxColumn"
        Me.GPLijstDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductDataGridViewTextBoxColumn
        '
        Me.ProductDataGridViewTextBoxColumn.DataPropertyName = "product"
        Me.ProductDataGridViewTextBoxColumn.HeaderText = "product"
        Me.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn"
        Me.ProductDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LKCodeDataGridViewTextBoxColumn
        '
        Me.LKCodeDataGridViewTextBoxColumn.DataPropertyName = "LK_Code"
        Me.LKCodeDataGridViewTextBoxColumn.HeaderText = "LK_Code"
        Me.LKCodeDataGridViewTextBoxColumn.Name = "LKCodeDataGridViewTextBoxColumn"
        Me.LKCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GPBuyPriceEURDataGridViewTextBoxColumn1
        '
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.DataPropertyName = "GP_BuyPriceEUR"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.HeaderText = "GP_BuyPriceEUR"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.Name = "GPBuyPriceEURDataGridViewTextBoxColumn1"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PDVoorraadDataGridViewTextBoxColumn
        '
        Me.PDVoorraadDataGridViewTextBoxColumn.DataPropertyName = "PD_Voorraad"
        Me.PDVoorraadDataGridViewTextBoxColumn.HeaderText = "PD_Voorraad"
        Me.PDVoorraadDataGridViewTextBoxColumn.Name = "PDVoorraadDataGridViewTextBoxColumn"
        Me.PDVoorraadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GetProductListBindingSource
        '
        Me.GetProductListBindingSource.DataMember = "GetProductList"
        Me.GetProductListBindingSource.DataSource = Me.DS_Product
        '
        'Knop_ProductPlus
        '
        Me.Knop_ProductPlus.Location = New System.Drawing.Point(3, 6)
        Me.Knop_ProductPlus.Name = "Knop_ProductPlus"
        Me.Knop_ProductPlus.Size = New System.Drawing.Size(111, 23)
        Me.Knop_ProductPlus.TabIndex = 9
        Me.Knop_ProductPlus.Text = "Product toevoegen"
        Me.Knop_ProductPlus.UseVisualStyleBackColor = True
        '
        'Tpage_Besteld
        '
        Me.Tpage_Besteld.Controls.Add(Me.Label7)
        Me.Tpage_Besteld.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Besteld.Name = "Tpage_Besteld"
        Me.Tpage_Besteld.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Besteld.Size = New System.Drawing.Size(805, 333)
        Me.Tpage_Besteld.TabIndex = 1
        Me.Tpage_Besteld.Text = "Products in bestelling"
        Me.Tpage_Besteld.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(413, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Alle bestellingen die bij de gekozen leverancier, en optioneel, shop in bestellin" &
    "g staan. "
        '
        'Tpage_Leveren
        '
        Me.Tpage_Leveren.Controls.Add(Me.DG_ontvangen)
        Me.Tpage_Leveren.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Leveren.Name = "Tpage_Leveren"
        Me.Tpage_Leveren.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Leveren.Size = New System.Drawing.Size(805, 333)
        Me.Tpage_Leveren.TabIndex = 2
        Me.Tpage_Leveren.Text = "Products ontvangen"
        Me.Tpage_Leveren.UseVisualStyleBackColor = True
        '
        'DG_ontvangen
        '
        Me.DG_ontvangen.AllowUserToAddRows = False
        Me.DG_ontvangen.AllowUserToDeleteRows = False
        Me.DG_ontvangen.AutoGenerateColumns = False
        Me.DG_ontvangen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ontvangen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GVDatumDataGridViewTextBoxColumn, Me.IDProductDataGridViewTextBoxColumn2, Me.ProDuctDataGridViewTextBoxColumn1, Me.GPOntvangenDataGridViewTextBoxColumn1, Me.GPBuyPriceEURDataGridViewTextBoxColumn2, Me.PDSalePrijsDataGridViewTextBoxColumn})
        Me.DG_ontvangen.DataSource = Me.GPAOntvangenLijstBindingSource
        Me.DG_ontvangen.Location = New System.Drawing.Point(8, 6)
        Me.DG_ontvangen.Name = "DG_ontvangen"
        Me.DG_ontvangen.ReadOnly = True
        Me.DG_ontvangen.Size = New System.Drawing.Size(771, 232)
        Me.DG_ontvangen.TabIndex = 2
        '
        'GVDatumDataGridViewTextBoxColumn
        '
        Me.GVDatumDataGridViewTextBoxColumn.DataPropertyName = "GV_Datum"
        Me.GVDatumDataGridViewTextBoxColumn.HeaderText = "GV_Datum"
        Me.GVDatumDataGridViewTextBoxColumn.Name = "GVDatumDataGridViewTextBoxColumn"
        Me.GVDatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDProductDataGridViewTextBoxColumn2
        '
        Me.IDProductDataGridViewTextBoxColumn2.DataPropertyName = "ID_Product"
        Me.IDProductDataGridViewTextBoxColumn2.HeaderText = "ID_Product"
        Me.IDProductDataGridViewTextBoxColumn2.Name = "IDProductDataGridViewTextBoxColumn2"
        Me.IDProductDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ProDuctDataGridViewTextBoxColumn1
        '
        Me.ProDuctDataGridViewTextBoxColumn1.DataPropertyName = "ProDuct"
        Me.ProDuctDataGridViewTextBoxColumn1.HeaderText = "ProDuct"
        Me.ProDuctDataGridViewTextBoxColumn1.Name = "ProDuctDataGridViewTextBoxColumn1"
        Me.ProDuctDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'GPOntvangenDataGridViewTextBoxColumn1
        '
        Me.GPOntvangenDataGridViewTextBoxColumn1.DataPropertyName = "GP__Ontvangen"
        Me.GPOntvangenDataGridViewTextBoxColumn1.HeaderText = "GP__Ontvangen"
        Me.GPOntvangenDataGridViewTextBoxColumn1.Name = "GPOntvangenDataGridViewTextBoxColumn1"
        Me.GPOntvangenDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'GPBuyPriceEURDataGridViewTextBoxColumn2
        '
        Me.GPBuyPriceEURDataGridViewTextBoxColumn2.DataPropertyName = "GP_BuyPriceEUR"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn2.HeaderText = "GP_BuyPriceEUR"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn2.Name = "GPBuyPriceEURDataGridViewTextBoxColumn2"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'PDSalePrijsDataGridViewTextBoxColumn
        '
        Me.PDSalePrijsDataGridViewTextBoxColumn.DataPropertyName = "PD_Sale_Prijs"
        Me.PDSalePrijsDataGridViewTextBoxColumn.HeaderText = "PD_Sale_Prijs"
        Me.PDSalePrijsDataGridViewTextBoxColumn.Name = "PDSalePrijsDataGridViewTextBoxColumn"
        Me.PDSalePrijsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GPAOntvangenLijstBindingSource
        '
        Me.GPAOntvangenLijstBindingSource.DataMember = "GPA_OntvangenLijst "
        Me.GPAOntvangenLijstBindingSource.DataSource = Me.DS_Product
        '
        'Tpage_advies
        '
        Me.Tpage_advies.Controls.Add(Me.Label9)
        Me.Tpage_advies.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_advies.Name = "Tpage_advies"
        Me.Tpage_advies.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_advies.Size = New System.Drawing.Size(805, 333)
        Me.Tpage_advies.TabIndex = 3
        Me.Tpage_advies.Text = "Besteladvies"
        Me.Tpage_advies.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(313, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "producten waar minimale voorraad aanleiding geeft tot bestellen. "
        '
        'Tpage_TeLeveren
        '
        Me.Tpage_TeLeveren.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_TeLeveren.Name = "Tpage_TeLeveren"
        Me.Tpage_TeLeveren.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_TeLeveren.Size = New System.Drawing.Size(805, 333)
        Me.Tpage_TeLeveren.TabIndex = 4
        Me.Tpage_TeLeveren.Text = "Nog Te Leveren"
        Me.Tpage_TeLeveren.UseVisualStyleBackColor = True
        '
        'TXT_LijstAantal
        '
        Me.TXT_LijstAantal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_Lijst", True))
        Me.TXT_LijstAantal.Enabled = False
        Me.TXT_LijstAantal.Location = New System.Drawing.Point(870, 102)
        Me.TXT_LijstAantal.Name = "TXT_LijstAantal"
        Me.TXT_LijstAantal.Size = New System.Drawing.Size(43, 20)
        Me.TXT_LijstAantal.TabIndex = 17
        '
        'TXT_Voorraad
        '
        Me.TXT_Voorraad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.TXT_Voorraad.Location = New System.Drawing.Point(870, 282)
        Me.TXT_Voorraad.Name = "TXT_Voorraad"
        Me.TXT_Voorraad.Size = New System.Drawing.Size(43, 20)
        Me.TXT_Voorraad.TabIndex = 16
        '
        'DT_productBindingSource
        '
        Me.DT_productBindingSource.DataMember = "DT_product"
        Me.DT_productBindingSource.DataSource = Me.DS_Product
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(813, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Boek als bestelling"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Knop_Kosten
        '
        Me.Knop_Kosten.Location = New System.Drawing.Point(18, 24)
        Me.Knop_Kosten.Name = "Knop_Kosten"
        Me.Knop_Kosten.Size = New System.Drawing.Size(116, 23)
        Me.Knop_Kosten.TabIndex = 7
        Me.Knop_Kosten.Text = "&Kosten boeken"
        Me.Knop_Kosten.UseVisualStyleBackColor = True
        '
        'Knop_BoekOntvangst
        '
        Me.Knop_BoekOntvangst.Enabled = False
        Me.Knop_BoekOntvangst.Location = New System.Drawing.Point(149, 24)
        Me.Knop_BoekOntvangst.Name = "Knop_BoekOntvangst"
        Me.Knop_BoekOntvangst.Size = New System.Drawing.Size(116, 23)
        Me.Knop_BoekOntvangst.TabIndex = 12
        Me.Knop_BoekOntvangst.Text = "Boek als ontvangst"
        Me.Knop_BoekOntvangst.UseVisualStyleBackColor = True
        '
        'GB_Get
        '
        Me.GB_Get.Controls.Add(Me.txt_Status)
        Me.GB_Get.Controls.Add(GV_DatumLabel)
        Me.GB_Get.Controls.Add(Me.DA_Datum)
        Me.GB_Get.Controls.Add(Me.TXT_NaamGet)
        Me.GB_Get.Controls.Add(Me.TXT_getontvangstid)
        Me.GB_Get.Controls.Add(Me.Knop_Nieuw)
        Me.GB_Get.Controls.Add(Me.Label3)
        Me.GB_Get.Controls.Add(Me.Knop_Opslaan)
        Me.GB_Get.Controls.Add(Me.CB_Ontvangen)
        Me.GB_Get.Location = New System.Drawing.Point(12, 12)
        Me.GB_Get.Name = "GB_Get"
        Me.GB_Get.Size = New System.Drawing.Size(450, 110)
        Me.GB_Get.TabIndex = 2
        Me.GB_Get.TabStop = False
        '
        'txt_Status
        '
        Me.txt_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "GV_Status", True))
        Me.txt_Status.Enabled = False
        Me.txt_Status.Location = New System.Drawing.Point(379, 8)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.Size = New System.Drawing.Size(19, 20)
        Me.txt_Status.TabIndex = 20
        Me.txt_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DA_Datum
        '
        Me.DA_Datum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GetOntvangstBindingSource, "GV_Datum", True))
        Me.DA_Datum.Location = New System.Drawing.Point(86, 41)
        Me.DA_Datum.Name = "DA_Datum"
        Me.DA_Datum.Size = New System.Drawing.Size(262, 20)
        Me.DA_Datum.TabIndex = 6
        '
        'TXT_NaamGet
        '
        Me.TXT_NaamGet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "GV_Naam", True))
        Me.TXT_NaamGet.Location = New System.Drawing.Point(113, 19)
        Me.TXT_NaamGet.Name = "TXT_NaamGet"
        Me.TXT_NaamGet.Size = New System.Drawing.Size(235, 20)
        Me.TXT_NaamGet.TabIndex = 5
        '
        'TXT_getontvangstid
        '
        Me.TXT_getontvangstid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "ID_GetOntvangst", True))
        Me.TXT_getontvangstid.Enabled = False
        Me.TXT_getontvangstid.Location = New System.Drawing.Point(404, 8)
        Me.TXT_getontvangstid.Name = "TXT_getontvangstid"
        Me.TXT_getontvangstid.Size = New System.Drawing.Size(40, 20)
        Me.TXT_getontvangstid.TabIndex = 4
        Me.TXT_getontvangstid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(365, 41)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(79, 23)
        Me.Knop_Nieuw.TabIndex = 8
        Me.Knop_Nieuw.Text = "&Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Productlijst:"
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(365, 70)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(79, 23)
        Me.Knop_Opslaan.TabIndex = 5
        Me.Knop_Opslaan.Text = "&Opslaan"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'CB_Ontvangen
        '
        Me.CB_Ontvangen.DataSource = Me.GetOntvangstBindingSource
        Me.CB_Ontvangen.DisplayMember = "GV_Naam"
        Me.CB_Ontvangen.DropDownWidth = 160
        Me.CB_Ontvangen.FormattingEnabled = True
        Me.CB_Ontvangen.Location = New System.Drawing.Point(86, 19)
        Me.CB_Ontvangen.Name = "CB_Ontvangen"
        Me.CB_Ontvangen.Size = New System.Drawing.Size(21, 21)
        Me.CB_Ontvangen.TabIndex = 2
        Me.CB_Ontvangen.ValueMember = "ID_GetOntvangst"
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
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(813, 128)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Sluiten.TabIndex = 4
        Me.Knop_Sluiten.Text = "&Sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TXT_output
        '
        Me.TXT_output.Location = New System.Drawing.Point(900, 17)
        Me.TXT_output.Multiline = True
        Me.TXT_output.Name = "TXT_output"
        Me.TXT_output.Size = New System.Drawing.Size(169, 59)
        Me.TXT_output.TabIndex = 7
        '
        'ShopTableAdapter
        '
        Me.ShopTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(819, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "herlaad form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Knop_update
        '
        Me.Knop_update.Location = New System.Drawing.Point(994, 223)
        Me.Knop_update.Name = "Knop_update"
        Me.Knop_update.Size = New System.Drawing.Size(75, 23)
        Me.Knop_update.TabIndex = 13
        Me.Knop_update.Text = "Update lijst naar DB"
        Me.Knop_update.UseVisualStyleBackColor = True
        '
        'Knop_OpslaanDB
        '
        Me.Knop_OpslaanDB.Location = New System.Drawing.Point(994, 252)
        Me.Knop_OpslaanDB.Name = "Knop_OpslaanDB"
        Me.Knop_OpslaanDB.Size = New System.Drawing.Size(75, 23)
        Me.Knop_OpslaanDB.TabIndex = 14
        Me.Knop_OpslaanDB.Text = "Opslaan in DB"
        Me.Knop_OpslaanDB.UseVisualStyleBackColor = True
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
        Me.TXT_AdmInkoop.Location = New System.Drawing.Point(281, 17)
        Me.TXT_AdmInkoop.Name = "TXT_AdmInkoop"
        Me.TXT_AdmInkoop.Size = New System.Drawing.Size(45, 20)
        Me.TXT_AdmInkoop.TabIndex = 18
        '
        'GB_Kosten
        '
        Me.GB_Kosten.Controls.Add(Label5)
        Me.GB_Kosten.Controls.Add(Me.TXT_Lijstwaarde)
        Me.GB_Kosten.Controls.Add(Me.TXT_AdmInkoop)
        Me.GB_Kosten.Controls.Add(Label4)
        Me.GB_Kosten.Controls.Add(Me.TXT_Boekwaarde)
        Me.GB_Kosten.Controls.Add(Me.Knop_Kosten)
        Me.GB_Kosten.Controls.Add(Me.Knop_BoekOntvangst)
        Me.GB_Kosten.Location = New System.Drawing.Point(468, 17)
        Me.GB_Kosten.Name = "GB_Kosten"
        Me.GB_Kosten.Size = New System.Drawing.Size(332, 105)
        Me.GB_Kosten.TabIndex = 19
        Me.GB_Kosten.TabStop = False
        Me.GB_Kosten.Text = "Lijst boeken als onvangst"
        '
        'TXT_Lijstwaarde
        '
        Me.TXT_Lijstwaarde.Location = New System.Drawing.Point(94, 76)
        Me.TXT_Lijstwaarde.Name = "TXT_Lijstwaarde"
        Me.TXT_Lijstwaarde.Size = New System.Drawing.Size(60, 20)
        Me.TXT_Lijstwaarde.TabIndex = 15
        Me.TXT_Lijstwaarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_Boekwaarde
        '
        Me.TXT_Boekwaarde.Location = New System.Drawing.Point(94, 52)
        Me.TXT_Boekwaarde.Name = "TXT_Boekwaarde"
        Me.TXT_Boekwaarde.Size = New System.Drawing.Size(60, 20)
        Me.TXT_Boekwaarde.TabIndex = 13
        Me.TXT_Boekwaarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GetProductListTableAdapter
        '
        Me.GetProductListTableAdapter.ClearBeforeFill = True
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
        'GB_bestelling
        '
        Me.GB_bestelling.Location = New System.Drawing.Point(468, 128)
        Me.GB_bestelling.Name = "GB_bestelling"
        Me.GB_bestelling.Size = New System.Drawing.Size(332, 100)
        Me.GB_bestelling.TabIndex = 20
        Me.GB_bestelling.TabStop = False
        Me.GB_bestelling.Text = "Lijst boeken als bestelling"
        '
        'F_GetProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 601)
        Me.Controls.Add(Me.GB_bestelling)
        Me.Controls.Add(Me.GB_Kosten)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Knop_OpslaanDB)
        Me.Controls.Add(Me.Knop_update)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_output)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Controls.Add(Me.GB_Get)
        Me.Controls.Add(Me.GB_Products)
        Me.Controls.Add(Me.GB_Supplier)
        Me.Name = "F_GetProduct"
        Me.Text = "Poducten ontvangen"
        Me.GB_Supplier.ResumeLayout(False)
        Me.GB_Supplier.PerformLayout()
        CType(Me.GetOntvangstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Products.ResumeLayout(False)
        Me.GB_Products.PerformLayout()
        CType(Me.GPA_AantalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB_Products.ResumeLayout(False)
        Me.Tpage_Lijst.ResumeLayout(False)
        Me.Tpage_Lijst.PerformLayout()
        CType(Me.DG_Lijst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Besteld.ResumeLayout(False)
        Me.Tpage_Besteld.PerformLayout()
        Me.Tpage_Leveren.ResumeLayout(False)
        CType(Me.DG_ontvangen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPAOntvangenLijstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_advies.ResumeLayout(False)
        Me.Tpage_advies.PerformLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Get.ResumeLayout(False)
        Me.GB_Get.PerformLayout()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Kosten.ResumeLayout(False)
        Me.GB_Kosten.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Supplier As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_Shop As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GB_Products As GroupBox
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
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents TXT_NaamGet As TextBox
    Friend WithEvents TXT_output As TextBox
    Friend WithEvents ShopBindingSource As BindingSource
    Friend WithEvents ShopTableAdapter As DS_ProductTableAdapters.ShopTableAdapter
    Friend WithEvents Knop_DetailsShop As Button
    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents Knop_ProductPlus As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Knop_BoekOntvangst As Button
    Friend WithEvents Knop_update As Button
    Friend WithEvents Knop_OpslaanDB As Button
    Friend WithEvents DT_productBindingSource As BindingSource
    Friend WithEvents DT_productTableAdapter As DS_ProductTableAdapters.DT_productTableAdapter
    Friend WithEvents TXT_Voorraad As TextBox
    Friend WithEvents TXT_LijstAantal As TextBox
    Friend WithEvents GetProductAddBindingSource As BindingSource
    Friend WithEvents GetProductAddTableAdapter As DS_ProductTableAdapters.GetProductAddTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents DA_Datum As DateTimePicker
    Friend WithEvents Knop_Supplier As Button
    Friend WithEvents Knop_Kosten As Button
    Friend WithEvents TXT_AdmInkoop As TextBox
    Friend WithEvents GB_Kosten As GroupBox
    Friend WithEvents TXT_Boekwaarde As TextBox
    Friend WithEvents TXT_Lijstwaarde As TextBox
    Friend WithEvents GetProductListBindingSource As BindingSource
    Friend WithEvents GetProductListTableAdapter As DS_ProductTableAdapters.GetProductListTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TB_Products As TabControl
    Friend WithEvents Tpage_Besteld As TabPage
    Friend WithEvents Tpage_Leveren As TabPage
    Friend WithEvents Tpage_advies As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_Status As TextBox
    Friend WithEvents Tpage_Lijst As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents DG_Lijst As DataGridView
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
    Friend WithEvents Tpage_TeLeveren As TabPage
    Friend WithEvents DG_ontvangen As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTbesteld As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_ontvangen As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GPA_AantalBindingSource As BindingSource
    Friend WithEvents GPA_AantalTableAdapter As DS_ProductTableAdapters.GPA_AantalTableAdapter
    Friend WithEvents Label14 As Label
    Friend WithEvents TXT_Prijs As TextBox
    Friend WithEvents IDGetProductAddDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDProductDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDGetOntvangstDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GPOntvangenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPBesteldDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPLijstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LKCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPBuyPriceEURDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PDVoorraadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GVDatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDProductDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ProDuctDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GPOntvangenDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GPBuyPriceEURDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PDSalePrijsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPAOntvangenLijstBindingSource As BindingSource
    Friend WithEvents GPA_OntvangenLijstTableAdaptor_ As DS_ProductTableAdapters.GPA_OntvangenLijstTableAdaptor_
    Friend WithEvents GB_bestelling As GroupBox
    Friend WithEvents Knop_Toon As Button
End Class

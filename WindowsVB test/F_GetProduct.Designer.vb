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
        Me.TB_Products = New System.Windows.Forms.TabControl()
        Me.Tpage_Lijst = New System.Windows.Forms.TabPage()
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
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tpage_Leveren = New System.Windows.Forms.TabPage()
        Me.DG_ontvangen = New System.Windows.Forms.DataGridView()
        Me.GVDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProDuctDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPOntvangenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPBuyPriceEURDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDSalePrijsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPAOntvangenLijstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tpage_TeLeveren = New System.Windows.Forms.TabPage()
        Me.Tpage_advies = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GPA_AantalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ShopTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ShopTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Knop_update = New System.Windows.Forms.Button()
        Me.Knop_OpslaanDB = New System.Windows.Forms.Button()
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
        Me.TPage_Ontvangen = New System.Windows.Forms.TabPage()
        Me.Tpage_Bestelling = New System.Windows.Forms.TabPage()
        Me.Knop_Bestelling = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_Kenmerk = New System.Windows.Forms.TextBox()
        Me.TXT_Voorraad = New System.Windows.Forms.TextBox()
        Me.TXT_LijstAantal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_ontvangen = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTbesteld = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_Prijs = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        GV_DatumLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.GetOntvangstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB_Products.SuspendLayout()
        Me.Tpage_Lijst.SuspendLayout()
        CType(Me.DG_Lijst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Leveren.SuspendLayout()
        CType(Me.DG_ontvangen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPAOntvangenLijstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_advies.SuspendLayout()
        CType(Me.GPA_AantalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Get.SuspendLayout()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB_Doel.SuspendLayout()
        Me.TPage_Ontvangen.SuspendLayout()
        Me.Tpage_Bestelling.SuspendLayout()
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
        Me.Knop_Supplier.Location = New System.Drawing.Point(354, 65)
        Me.Knop_Supplier.Name = "Knop_Supplier"
        Me.Knop_Supplier.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Supplier.TabIndex = 6
        Me.Knop_Supplier.Text = "&Leverancier"
        Me.Knop_Supplier.UseVisualStyleBackColor = True
        '
        'Knop_DetailsShop
        '
        Me.Knop_DetailsShop.Location = New System.Drawing.Point(477, 17)
        Me.Knop_DetailsShop.Name = "Knop_DetailsShop"
        Me.Knop_DetailsShop.Size = New System.Drawing.Size(75, 23)
        Me.Knop_DetailsShop.TabIndex = 5
        Me.Knop_DetailsShop.Text = "&Shop"
        Me.Knop_DetailsShop.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 22)
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
        Me.CB_Shop.Location = New System.Drawing.Point(315, 19)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 70)
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
        Me.CB_Supplier.Location = New System.Drawing.Point(86, 67)
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
        'TB_Products
        '
        Me.TB_Products.Controls.Add(Me.Tpage_Lijst)
        Me.TB_Products.Controls.Add(Me.Tpage_Leveren)
        Me.TB_Products.Controls.Add(Me.Tpage_TeLeveren)
        Me.TB_Products.Controls.Add(Me.Tpage_advies)
        Me.TB_Products.ItemSize = New System.Drawing.Size(150, 18)
        Me.TB_Products.Location = New System.Drawing.Point(12, 264)
        Me.TB_Products.Name = "TB_Products"
        Me.TB_Products.SelectedIndex = 0
        Me.TB_Products.Size = New System.Drawing.Size(813, 260)
        Me.TB_Products.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TB_Products.TabIndex = 17
        '
        'Tpage_Lijst
        '
        Me.Tpage_Lijst.Controls.Add(Me.Knop_Toon)
        Me.Tpage_Lijst.Controls.Add(Me.Knop_ProductPLus)
        Me.Tpage_Lijst.Controls.Add(Me.DG_Lijst)
        Me.Tpage_Lijst.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Lijst.Name = "Tpage_Lijst"
        Me.Tpage_Lijst.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Lijst.Size = New System.Drawing.Size(805, 234)
        Me.Tpage_Lijst.TabIndex = 1
        Me.Tpage_Lijst.Text = "Productlijst"
        Me.Tpage_Lijst.UseVisualStyleBackColor = True
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
        Me.DG_Lijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Lijst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DG_Lijst.DataSource = Me.GetProductListBindingSource
        Me.DG_Lijst.Location = New System.Drawing.Point(0, 45)
        Me.DG_Lijst.MultiSelect = False
        Me.DG_Lijst.Name = "DG_Lijst"
        Me.DG_Lijst.ReadOnly = True
        Me.DG_Lijst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Lijst.Size = New System.Drawing.Size(756, 178)
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
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID_Product"
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
        Me.DataGridViewTextBoxColumn7.HeaderText = "GP_Lijst"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PD_Beschrijving(2)"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PD_Beschrijving(2)"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 300
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "LK_Code"
        Me.DataGridViewTextBoxColumn10.HeaderText = "LK_Code"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GP_BuyPriceEUR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GP_BuyPriceEUR"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PD_Voorraad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PD_Voorraad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'GetProductListBindingSource
        '
        Me.GetProductListBindingSource.DataMember = "GetProductList"
        Me.GetProductListBindingSource.DataSource = Me.DS_Product
        '
        'Tpage_Leveren
        '
        Me.Tpage_Leveren.Controls.Add(Me.DG_ontvangen)
        Me.Tpage_Leveren.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Leveren.Name = "Tpage_Leveren"
        Me.Tpage_Leveren.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Leveren.Size = New System.Drawing.Size(805, 234)
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
        'Tpage_TeLeveren
        '
        Me.Tpage_TeLeveren.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_TeLeveren.Name = "Tpage_TeLeveren"
        Me.Tpage_TeLeveren.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_TeLeveren.Size = New System.Drawing.Size(805, 234)
        Me.Tpage_TeLeveren.TabIndex = 4
        Me.Tpage_TeLeveren.Text = "Nog Te Leveren"
        Me.Tpage_TeLeveren.UseVisualStyleBackColor = True
        '
        'Tpage_advies
        '
        Me.Tpage_advies.Controls.Add(Me.Label9)
        Me.Tpage_advies.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_advies.Name = "Tpage_advies"
        Me.Tpage_advies.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_advies.Size = New System.Drawing.Size(805, 234)
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
        Me.Knop_Kosten.Location = New System.Drawing.Point(14, 17)
        Me.Knop_Kosten.Name = "Knop_Kosten"
        Me.Knop_Kosten.Size = New System.Drawing.Size(116, 23)
        Me.Knop_Kosten.TabIndex = 7
        Me.Knop_Kosten.Text = "&Kosten boeken"
        Me.Knop_Kosten.UseVisualStyleBackColor = True
        '
        'Knop_BoekOntvangst
        '
        Me.Knop_BoekOntvangst.Enabled = False
        Me.Knop_BoekOntvangst.Location = New System.Drawing.Point(145, 17)
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
        Me.GB_Get.Controls.Add(Me.TXT_getontvangstid)
        Me.GB_Get.Controls.Add(Me.Knop_Nieuw)
        Me.GB_Get.Controls.Add(Me.Label3)
        Me.GB_Get.Controls.Add(Me.Knop_Opslaan)
        Me.GB_Get.Controls.Add(Me.Label1)
        Me.GB_Get.Controls.Add(Me.CB_Ontvangen)
        Me.GB_Get.Controls.Add(Me.CB_Supplier)
        Me.GB_Get.Location = New System.Drawing.Point(12, 12)
        Me.GB_Get.Name = "GB_Get"
        Me.GB_Get.Size = New System.Drawing.Size(568, 110)
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
        Me.Knop_Nieuw.Location = New System.Drawing.Point(470, 12)
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
        Me.Knop_Opslaan.Location = New System.Drawing.Point(470, 41)
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
        Me.Knop_Sluiten.Location = New System.Drawing.Point(611, 82)
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
        'ShopTableAdapter
        '
        Me.ShopTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(611, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "herlaad form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Knop_update
        '
        Me.Knop_update.Location = New System.Drawing.Point(611, 18)
        Me.Knop_update.Name = "Knop_update"
        Me.Knop_update.Size = New System.Drawing.Size(75, 23)
        Me.Knop_update.TabIndex = 13
        Me.Knop_update.Text = "Update lijst naar DB"
        Me.Knop_update.UseVisualStyleBackColor = True
        '
        'Knop_OpslaanDB
        '
        Me.Knop_OpslaanDB.Location = New System.Drawing.Point(611, 50)
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
        Me.TB_Doel.Controls.Add(Me.TPage_Ontvangen)
        Me.TB_Doel.Controls.Add(Me.Tpage_Bestelling)
        Me.TB_Doel.ItemSize = New System.Drawing.Size(150, 18)
        Me.TB_Doel.Location = New System.Drawing.Point(12, 128)
        Me.TB_Doel.Name = "TB_Doel"
        Me.TB_Doel.SelectedIndex = 0
        Me.TB_Doel.Size = New System.Drawing.Size(568, 133)
        Me.TB_Doel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TB_Doel.TabIndex = 21
        '
        'TPage_Ontvangen
        '
        Me.TPage_Ontvangen.Controls.Add(Label5)
        Me.TPage_Ontvangen.Controls.Add(Me.Knop_DetailsShop)
        Me.TPage_Ontvangen.Controls.Add(Me.Knop_Kosten)
        Me.TPage_Ontvangen.Controls.Add(Me.Label2)
        Me.TPage_Ontvangen.Controls.Add(Me.TXT_Lijstwaarde)
        Me.TPage_Ontvangen.Controls.Add(Me.CB_Shop)
        Me.TPage_Ontvangen.Controls.Add(Me.Knop_BoekOntvangst)
        Me.TPage_Ontvangen.Controls.Add(Me.TXT_AdmInkoop)
        Me.TPage_Ontvangen.Controls.Add(Me.TXT_Boekwaarde)
        Me.TPage_Ontvangen.Controls.Add(Label4)
        Me.TPage_Ontvangen.Location = New System.Drawing.Point(4, 22)
        Me.TPage_Ontvangen.Name = "TPage_Ontvangen"
        Me.TPage_Ontvangen.Padding = New System.Windows.Forms.Padding(3)
        Me.TPage_Ontvangen.Size = New System.Drawing.Size(560, 107)
        Me.TPage_Ontvangen.TabIndex = 0
        Me.TPage_Ontvangen.Text = "Ontvangen"
        Me.TPage_Ontvangen.UseVisualStyleBackColor = True
        '
        'Tpage_Bestelling
        '
        Me.Tpage_Bestelling.Controls.Add(Me.Label7)
        Me.Tpage_Bestelling.Controls.Add(Me.Knop_Bestelling)
        Me.Tpage_Bestelling.Controls.Add(Me.Label6)
        Me.Tpage_Bestelling.Controls.Add(Me.TXT_Kenmerk)
        Me.Tpage_Bestelling.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Bestelling.Name = "Tpage_Bestelling"
        Me.Tpage_Bestelling.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Bestelling.Size = New System.Drawing.Size(560, 107)
        Me.Tpage_Bestelling.TabIndex = 1
        Me.Tpage_Bestelling.Text = "Bestelling"
        Me.Tpage_Bestelling.UseVisualStyleBackColor = True
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
        Me.TXT_Kenmerk.Location = New System.Drawing.Point(64, 9)
        Me.TXT_Kenmerk.Multiline = True
        Me.TXT_Kenmerk.Name = "TXT_Kenmerk"
        Me.TXT_Kenmerk.Size = New System.Drawing.Size(236, 38)
        Me.TXT_Kenmerk.TabIndex = 0
        '
        'TXT_Voorraad
        '
        Me.TXT_Voorraad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.TXT_Voorraad.Location = New System.Drawing.Point(741, 257)
        Me.TXT_Voorraad.Name = "TXT_Voorraad"
        Me.TXT_Voorraad.Size = New System.Drawing.Size(43, 20)
        Me.TXT_Voorraad.TabIndex = 16
        '
        'TXT_LijstAantal
        '
        Me.TXT_LijstAantal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_Lijst", True))
        Me.TXT_LijstAantal.Enabled = False
        Me.TXT_LijstAantal.Location = New System.Drawing.Point(741, 77)
        Me.TXT_LijstAantal.Name = "TXT_LijstAantal"
        Me.TXT_LijstAantal.Size = New System.Drawing.Size(43, 20)
        Me.TXT_LijstAantal.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(713, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "voorraad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(713, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "lijstaantal"
        '
        'TXT_ontvangen
        '
        Me.TXT_ontvangen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP__Ontvangen", True))
        Me.TXT_ontvangen.Location = New System.Drawing.Point(741, 123)
        Me.TXT_ontvangen.Name = "TXT_ontvangen"
        Me.TXT_ontvangen.Size = New System.Drawing.Size(43, 20)
        Me.TXT_ontvangen.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(713, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Ontvangen"
        '
        'TXTbesteld
        '
        Me.TXTbesteld.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_Besteld", True))
        Me.TXTbesteld.Location = New System.Drawing.Point(741, 169)
        Me.TXTbesteld.Name = "TXTbesteld"
        Me.TXTbesteld.Size = New System.Drawing.Size(43, 20)
        Me.TXTbesteld.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(713, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "besteld"
        '
        'TXT_Prijs
        '
        Me.TXT_Prijs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPA_AantalBindingSource, "GP_BuyPriceEUR", True))
        Me.TXT_Prijs.Location = New System.Drawing.Point(741, 212)
        Me.TXT_Prijs.Name = "TXT_Prijs"
        Me.TXT_Prijs.Size = New System.Drawing.Size(43, 20)
        Me.TXT_Prijs.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(713, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "prijs (laatste inkoop)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Hier later fancy knoppen maken naar faxen emails enz"
        '
        'F_GetProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 539)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TB_Products)
        Me.Controls.Add(Me.TXT_Prijs)
        Me.Controls.Add(Me.TB_Doel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Knop_OpslaanDB)
        Me.Controls.Add(Me.TXTbesteld)
        Me.Controls.Add(Me.Knop_update)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_ontvangen)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GB_Get)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_LijstAantal)
        Me.Controls.Add(Me.TXT_Voorraad)
        Me.Name = "F_GetProduct"
        Me.Text = "Poducten ontvangen"
        CType(Me.GetOntvangstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB_Products.ResumeLayout(False)
        Me.Tpage_Lijst.ResumeLayout(False)
        CType(Me.DG_Lijst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Leveren.ResumeLayout(False)
        CType(Me.DG_ontvangen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPAOntvangenLijstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_advies.ResumeLayout(False)
        Me.Tpage_advies.PerformLayout()
        CType(Me.GPA_AantalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Get.ResumeLayout(False)
        Me.GB_Get.PerformLayout()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB_Doel.ResumeLayout(False)
        Me.TPage_Ontvangen.ResumeLayout(False)
        Me.TPage_Ontvangen.PerformLayout()
        Me.Tpage_Bestelling.ResumeLayout(False)
        Me.Tpage_Bestelling.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_Shop As ComboBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents ShopBindingSource As BindingSource
    Friend WithEvents ShopTableAdapter As DS_ProductTableAdapters.ShopTableAdapter
    Friend WithEvents Knop_DetailsShop As Button
    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Knop_BoekOntvangst As Button
    Friend WithEvents Knop_update As Button
    Friend WithEvents Knop_OpslaanDB As Button
    Friend WithEvents DT_productBindingSource As BindingSource
    Friend WithEvents DT_productTableAdapter As DS_ProductTableAdapters.DT_productTableAdapter
    Friend WithEvents GetProductAddBindingSource As BindingSource
    Friend WithEvents GetProductAddTableAdapter As DS_ProductTableAdapters.GetProductAddTableAdapter
    Friend WithEvents DA_Datum As DateTimePicker
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
    Friend WithEvents TB_Products As TabControl
    Friend WithEvents Tpage_Lijst As TabPage
    Friend WithEvents Tpage_Leveren As TabPage
    Friend WithEvents DG_ontvangen As DataGridView
    Friend WithEvents GVDatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDProductDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ProDuctDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GPOntvangenDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GPBuyPriceEURDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PDSalePrijsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tpage_advies As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Tpage_TeLeveren As TabPage
    Friend WithEvents GetProductListBindingSource As BindingSource
    Friend WithEvents GetProductListTableAdapter As DS_ProductTableAdapters.GetProductListTableAdapter
    Friend WithEvents DG_Lijst As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Knop_ProductPLus As Button
    Friend WithEvents Knop_Toon As Button
    Friend WithEvents TB_Doel As TabControl
    Friend WithEvents TPage_Ontvangen As TabPage
    Friend WithEvents Tpage_Bestelling As TabPage
    Friend WithEvents TXT_Voorraad As TextBox
    Friend WithEvents TXT_LijstAantal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_ontvangen As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXTbesteld As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_Prijs As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_Kenmerk As TextBox
    Friend WithEvents Knop_Bestelling As Button
    Friend WithEvents Label7 As Label
End Class

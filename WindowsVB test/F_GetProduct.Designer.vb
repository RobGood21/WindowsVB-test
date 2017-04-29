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
        Me.TB_Products = New System.Windows.Forms.TabControl()
        Me.Tpage_Lijst = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DG_Lijst = New System.Windows.Forms.DataGridView()
        Me.GetProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tpage_Besteld = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tpage_Leveren = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tpage_advies = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Knop_ProductPlus = New System.Windows.Forms.Button()
        Me.Knop_Kosten = New System.Windows.Forms.Button()
        Me.Knop_BoekOntvangst = New System.Windows.Forms.Button()
        Me.GB_Get = New System.Windows.Forms.GroupBox()
        Me.txt_Status = New System.Windows.Forms.TextBox()
        Me.DA_Datum = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NaamGet = New System.Windows.Forms.TextBox()
        Me.TXT_getontvangstid = New System.Windows.Forms.TextBox()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Ontvangen = New System.Windows.Forms.ComboBox()
        Me.GetOntvangstTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetOntvangstTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.SupplierTableAdapter()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.TXT_output = New System.Windows.Forms.TextBox()
        Me.ShopTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ShopTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Knop_update = New System.Windows.Forms.Button()
        Me.Knop_OpslaanDB = New System.Windows.Forms.Button()
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_productTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.DT_productTableAdapter()
        Me.TXT_Voorraad = New System.Windows.Forms.TextBox()
        Me.TXT_LijstAantal = New System.Windows.Forms.TextBox()
        Me.GPAAantalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetProductAddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetProductAddTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductAddTableAdapter()
        Me.GPA_AantalTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GPA_AantalTableAdapter()
        Me.TXT_AdmInkoop = New System.Windows.Forms.TextBox()
        Me.GB_Kosten = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GetProductListTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductListTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GP__Ontvangen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GP_Besteld = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GP_Lijst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        GV_DatumLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.GB_Supplier.SuspendLayout()
        CType(Me.GetOntvangstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Products.SuspendLayout()
        Me.TB_Products.SuspendLayout()
        Me.Tpage_Lijst.SuspendLayout()
        CType(Me.DG_Lijst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tpage_Besteld.SuspendLayout()
        Me.Tpage_Leveren.SuspendLayout()
        Me.Tpage_advies.SuspendLayout()
        Me.GB_Get.SuspendLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPAAantalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GB_Products.Controls.Add(Me.TB_Products)
        Me.GB_Products.Location = New System.Drawing.Point(12, 223)
        Me.GB_Products.Name = "GB_Products"
        Me.GB_Products.Size = New System.Drawing.Size(1022, 343)
        Me.GB_Products.TabIndex = 1
        Me.GB_Products.TabStop = False
        '
        'TB_Products
        '
        Me.TB_Products.Controls.Add(Me.Tpage_Lijst)
        Me.TB_Products.Controls.Add(Me.Tpage_Besteld)
        Me.TB_Products.Controls.Add(Me.Tpage_Leveren)
        Me.TB_Products.Controls.Add(Me.Tpage_advies)
        Me.TB_Products.ItemSize = New System.Drawing.Size(120, 18)
        Me.TB_Products.Location = New System.Drawing.Point(6, 19)
        Me.TB_Products.Name = "TB_Products"
        Me.TB_Products.SelectedIndex = 0
        Me.TB_Products.Size = New System.Drawing.Size(927, 283)
        Me.TB_Products.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TB_Products.TabIndex = 17
        '
        'Tpage_Lijst
        '
        Me.Tpage_Lijst.Controls.Add(Me.Label6)
        Me.Tpage_Lijst.Controls.Add(Me.DG_Lijst)
        Me.Tpage_Lijst.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Lijst.Name = "Tpage_Lijst"
        Me.Tpage_Lijst.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Lijst.Size = New System.Drawing.Size(919, 257)
        Me.Tpage_Lijst.TabIndex = 0
        Me.Tpage_Lijst.Text = "Lijst Products"
        Me.Tpage_Lijst.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(573, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Lijst met producten, deze lijst kan worden omgezet in een ontvangst, bijwerken vo" &
    "orraad en ontvangst of een bestelling  "
        '
        'DG_Lijst
        '
        Me.DG_Lijst.AutoGenerateColumns = False
        Me.DG_Lijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Lijst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn10, Me.GP__Ontvangen, Me.GP_Besteld, Me.GP_Lijst, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn4, Me.product})
        Me.DG_Lijst.DataSource = Me.GetProductListBindingSource
        Me.DG_Lijst.Location = New System.Drawing.Point(6, 20)
        Me.DG_Lijst.Name = "DG_Lijst"
        Me.DG_Lijst.Size = New System.Drawing.Size(801, 217)
        Me.DG_Lijst.TabIndex = 16
        '
        'GetProductListBindingSource
        '
        Me.GetProductListBindingSource.DataMember = "GetProductList"
        Me.GetProductListBindingSource.DataSource = Me.DS_Product
        '
        'Tpage_Besteld
        '
        Me.Tpage_Besteld.Controls.Add(Me.Label7)
        Me.Tpage_Besteld.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Besteld.Name = "Tpage_Besteld"
        Me.Tpage_Besteld.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Besteld.Size = New System.Drawing.Size(919, 257)
        Me.Tpage_Besteld.TabIndex = 1
        Me.Tpage_Besteld.Text = "Besteld"
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
        Me.Tpage_Leveren.Controls.Add(Me.Label8)
        Me.Tpage_Leveren.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_Leveren.Name = "Tpage_Leveren"
        Me.Tpage_Leveren.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_Leveren.Size = New System.Drawing.Size(919, 257)
        Me.Tpage_Leveren.TabIndex = 2
        Me.Tpage_Leveren.Text = "Te leveren"
        Me.Tpage_Leveren.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(325, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Bestellingen van klanten, nog te leveren. Ook als een besteladvies "
        '
        'Tpage_advies
        '
        Me.Tpage_advies.Controls.Add(Me.Label9)
        Me.Tpage_advies.Location = New System.Drawing.Point(4, 22)
        Me.Tpage_advies.Name = "Tpage_advies"
        Me.Tpage_advies.Padding = New System.Windows.Forms.Padding(3)
        Me.Tpage_advies.Size = New System.Drawing.Size(919, 257)
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(813, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Boek als bestelling"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Knop_ProductPlus
        '
        Me.Knop_ProductPlus.Location = New System.Drawing.Point(806, 131)
        Me.Knop_ProductPlus.Name = "Knop_ProductPlus"
        Me.Knop_ProductPlus.Size = New System.Drawing.Size(75, 23)
        Me.Knop_ProductPlus.TabIndex = 9
        Me.Knop_ProductPlus.Text = "Product +"
        Me.Knop_ProductPlus.UseVisualStyleBackColor = True
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
        Me.Knop_BoekOntvangst.Location = New System.Drawing.Point(21, 102)
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
        Me.GB_Get.Controls.Add(Me.CB_Ontvangen)
        Me.GB_Get.Location = New System.Drawing.Point(12, 12)
        Me.GB_Get.Name = "GB_Get"
        Me.GB_Get.Size = New System.Drawing.Size(450, 78)
        Me.GB_Get.TabIndex = 2
        Me.GB_Get.TabStop = False
        '
        'txt_Status
        '
        Me.txt_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "GV_Status", True))
        Me.txt_Status.Enabled = False
        Me.txt_Status.Location = New System.Drawing.Point(379, 19)
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
        Me.TXT_getontvangstid.Location = New System.Drawing.Point(404, 19)
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
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(994, 194)
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
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(994, 154)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Opslaan.TabIndex = 5
        Me.Knop_Opslaan.Text = "&Opslaan"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
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
        'DT_productBindingSource
        '
        Me.DT_productBindingSource.DataMember = "DT_product"
        Me.DT_productBindingSource.DataSource = Me.DS_Product
        '
        'DT_productTableAdapter
        '
        Me.DT_productTableAdapter.ClearBeforeFill = True
        '
        'TXT_Voorraad
        '
        Me.TXT_Voorraad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.TXT_Voorraad.Location = New System.Drawing.Point(1026, 82)
        Me.TXT_Voorraad.Name = "TXT_Voorraad"
        Me.TXT_Voorraad.Size = New System.Drawing.Size(43, 20)
        Me.TXT_Voorraad.TabIndex = 16
        '
        'TXT_LijstAantal
        '
        Me.TXT_LijstAantal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAAantalBindingSource, "GP_Aantal", True))
        Me.TXT_LijstAantal.Enabled = False
        Me.TXT_LijstAantal.Location = New System.Drawing.Point(1026, 110)
        Me.TXT_LijstAantal.Name = "TXT_LijstAantal"
        Me.TXT_LijstAantal.Size = New System.Drawing.Size(43, 20)
        Me.TXT_LijstAantal.TabIndex = 17
        '
        'GPAAantalBindingSource
        '
        Me.GPAAantalBindingSource.DataMember = "GPA_Aantal"
        Me.GPAAantalBindingSource.DataSource = Me.DS_Product
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
        'GPA_AantalTableAdapter
        '
        Me.GPA_AantalTableAdapter.ClearBeforeFill = True
        '
        'TXT_AdmInkoop
        '
        Me.TXT_AdmInkoop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "ID_AdmInkoopboek", True))
        Me.TXT_AdmInkoop.Enabled = False
        Me.TXT_AdmInkoop.Location = New System.Drawing.Point(854, 105)
        Me.TXT_AdmInkoop.Name = "TXT_AdmInkoop"
        Me.TXT_AdmInkoop.Size = New System.Drawing.Size(102, 20)
        Me.TXT_AdmInkoop.TabIndex = 18
        '
        'GB_Kosten
        '
        Me.GB_Kosten.Controls.Add(Label5)
        Me.GB_Kosten.Controls.Add(Me.TextBox2)
        Me.GB_Kosten.Controls.Add(Label4)
        Me.GB_Kosten.Controls.Add(Me.TextBox1)
        Me.GB_Kosten.Controls.Add(Me.Knop_Kosten)
        Me.GB_Kosten.Controls.Add(Me.Knop_BoekOntvangst)
        Me.GB_Kosten.Location = New System.Drawing.Point(468, 17)
        Me.GB_Kosten.Name = "GB_Kosten"
        Me.GB_Kosten.Size = New System.Drawing.Size(332, 200)
        Me.GB_Kosten.TabIndex = 19
        Me.GB_Kosten.TabStop = False
        Me.GB_Kosten.Text = "Kosten"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 13
        '
        'GetProductListTableAdapter
        '
        Me.GetProductListTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_GetOntvangst"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_GetOntvangst"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID_GetProductAdd"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID_GetProductAdd"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 5
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ID_Product"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID_Product"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 5
        '
        'GP__Ontvangen
        '
        Me.GP__Ontvangen.DataPropertyName = "GP__Ontvangen"
        Me.GP__Ontvangen.HeaderText = "O"
        Me.GP__Ontvangen.Name = "GP__Ontvangen"
        Me.GP__Ontvangen.Width = 20
        '
        'GP_Besteld
        '
        Me.GP_Besteld.DataPropertyName = "GP_Besteld"
        Me.GP_Besteld.HeaderText = "B"
        Me.GP_Besteld.Name = "GP_Besteld"
        Me.GP_Besteld.Width = 20
        '
        'GP_Lijst
        '
        Me.GP_Lijst.DataPropertyName = "GP_Lijst"
        Me.GP_Lijst.HeaderText = "Lijst"
        Me.GP_Lijst.Name = "GP_Lijst"
        Me.GP_Lijst.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PD_Voorraad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Voorraad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PD_Naam"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Naam"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'product
        '
        Me.product.DataPropertyName = "product"
        Me.product.HeaderText = "Beschrijving"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        Me.product.Width = 200
        '
        'F_GetProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 601)
        Me.Controls.Add(Me.GB_Kosten)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TXT_AdmInkoop)
        Me.Controls.Add(Me.TXT_LijstAantal)
        Me.Controls.Add(Me.Knop_ProductPlus)
        Me.Controls.Add(Me.TXT_Voorraad)
        Me.Controls.Add(Me.Knop_OpslaanDB)
        Me.Controls.Add(Me.Knop_update)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_output)
        Me.Controls.Add(Me.Knop_Opslaan)
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
        Me.TB_Products.ResumeLayout(False)
        Me.Tpage_Lijst.ResumeLayout(False)
        Me.Tpage_Lijst.PerformLayout()
        CType(Me.DG_Lijst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tpage_Besteld.ResumeLayout(False)
        Me.Tpage_Besteld.PerformLayout()
        Me.Tpage_Leveren.ResumeLayout(False)
        Me.Tpage_Leveren.PerformLayout()
        Me.Tpage_advies.ResumeLayout(False)
        Me.Tpage_advies.PerformLayout()
        Me.GB_Get.ResumeLayout(False)
        Me.GB_Get.PerformLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPAAantalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GPAAantalBindingSource As BindingSource
    Friend WithEvents GPA_AantalTableAdapter As DS_ProductTableAdapters.GPA_AantalTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents DA_Datum As DateTimePicker
    Friend WithEvents Knop_Supplier As Button
    Friend WithEvents Knop_Kosten As Button
    Friend WithEvents TXT_AdmInkoop As TextBox
    Friend WithEvents GB_Kosten As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GetProductListBindingSource As BindingSource
    Friend WithEvents GetProductListTableAdapter As DS_ProductTableAdapters.GetProductListTableAdapter
    Friend WithEvents DG_Lijst As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TB_Products As TabControl
    Friend WithEvents Tpage_Lijst As TabPage
    Friend WithEvents Tpage_Besteld As TabPage
    Friend WithEvents Tpage_Leveren As TabPage
    Friend WithEvents Tpage_advies As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_Status As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents GP__Ontvangen As DataGridViewTextBoxColumn
    Friend WithEvents GP_Besteld As DataGridViewTextBoxColumn
    Friend WithEvents GP_Lijst As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
End Class

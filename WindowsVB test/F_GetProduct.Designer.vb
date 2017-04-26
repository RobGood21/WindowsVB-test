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
        Dim GV_BeschrijvingLabel As System.Windows.Forms.Label
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DG_List = New System.Windows.Forms.DataGridView()
        Me.IDGetOntvangstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_GetProductAdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPAantalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Voorraad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Besteld = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDNaamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDFunctieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDWaardeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDBehuizingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPBuyPriceEURDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knop_Actie = New System.Windows.Forms.Button()
        Me.Knop_ProductPlus = New System.Windows.Forms.Button()
        Me.Knop_Kosten = New System.Windows.Forms.Button()
        Me.GB_Get = New System.Windows.Forms.GroupBox()
        Me.TXT_Beschrijving = New System.Windows.Forms.TextBox()
        Me.GV_DatumDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NaamGet = New System.Windows.Forms.TextBox()
        Me.TXT_getontvangstid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Ontvangen = New System.Windows.Forms.ComboBox()
        Me.GetOntvangstTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetOntvangstTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.SupplierTableAdapter()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.TXT_output = New System.Windows.Forms.TextBox()
        Me.ShopTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ShopTableAdapter()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.GetProductListTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductListTableAdapter()
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
        GV_DatumLabel = New System.Windows.Forms.Label()
        GV_BeschrijvingLabel = New System.Windows.Forms.Label()
        Me.GB_Supplier.SuspendLayout()
        CType(Me.GetOntvangstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Products.SuspendLayout()
        CType(Me.DG_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Get.SuspendLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPAAantalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GV_BeschrijvingLabel
        '
        GV_BeschrijvingLabel.AutoSize = True
        GV_BeschrijvingLabel.Location = New System.Drawing.Point(23, 70)
        GV_BeschrijvingLabel.Name = "GV_BeschrijvingLabel"
        GV_BeschrijvingLabel.Size = New System.Drawing.Size(52, 13)
        GV_BeschrijvingLabel.TabIndex = 6
        GV_BeschrijvingLabel.Text = "Kenmerk:"
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
        Me.GB_Supplier.Size = New System.Drawing.Size(547, 82)
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
        Me.GB_Products.Controls.Add(Me.Button2)
        Me.GB_Products.Controls.Add(Me.DG_List)
        Me.GB_Products.Controls.Add(Me.Knop_Actie)
        Me.GB_Products.Controls.Add(Me.Knop_ProductPlus)
        Me.GB_Products.Location = New System.Drawing.Point(12, 223)
        Me.GB_Products.Name = "GB_Products"
        Me.GB_Products.Size = New System.Drawing.Size(788, 212)
        Me.GB_Products.TabIndex = 1
        Me.GB_Products.TabStop = False
        Me.GB_Products.Text = "wat ontvangen?"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Boek lijst als bestelling"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DG_List
        '
        Me.DG_List.AllowUserToAddRows = False
        Me.DG_List.AllowUserToDeleteRows = False
        Me.DG_List.AutoGenerateColumns = False
        Me.DG_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDGetOntvangstDataGridViewTextBoxColumn, Me.ID_GetProductAdd, Me.idP, Me.GPAantalDataGridViewTextBoxColumn, Me.Voorraad, Me.Besteld, Me.PDNaamDataGridViewTextBoxColumn, Me.PDFunctieDataGridViewTextBoxColumn, Me.PDWaardeDataGridViewTextBoxColumn, Me.PDBehuizingDataGridViewTextBoxColumn, Me.GPBuyPriceEURDataGridViewTextBoxColumn})
        Me.DG_List.DataSource = Me.GetProductListBindingSource
        Me.DG_List.Location = New System.Drawing.Point(17, 19)
        Me.DG_List.Name = "DG_List"
        Me.DG_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_List.Size = New System.Drawing.Size(765, 150)
        Me.DG_List.TabIndex = 0
        '
        'IDGetOntvangstDataGridViewTextBoxColumn
        '
        Me.IDGetOntvangstDataGridViewTextBoxColumn.DataPropertyName = "ID_GetOntvangst"
        Me.IDGetOntvangstDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IDGetOntvangstDataGridViewTextBoxColumn.Name = "IDGetOntvangstDataGridViewTextBoxColumn"
        Me.IDGetOntvangstDataGridViewTextBoxColumn.Visible = False
        Me.IDGetOntvangstDataGridViewTextBoxColumn.Width = 20
        '
        'ID_GetProductAdd
        '
        Me.ID_GetProductAdd.DataPropertyName = "ID_GetProductAdd"
        Me.ID_GetProductAdd.HeaderText = "IPA"
        Me.ID_GetProductAdd.Name = "ID_GetProductAdd"
        Me.ID_GetProductAdd.ReadOnly = True
        Me.ID_GetProductAdd.Visible = False
        Me.ID_GetProductAdd.Width = 20
        '
        'idP
        '
        Me.idP.DataPropertyName = "ID_Product"
        Me.idP.HeaderText = "idP"
        Me.idP.Name = "idP"
        Me.idP.ReadOnly = True
        Me.idP.Visible = False
        Me.idP.Width = 20
        '
        'GPAantalDataGridViewTextBoxColumn
        '
        Me.GPAantalDataGridViewTextBoxColumn.DataPropertyName = "GP_Aantal"
        Me.GPAantalDataGridViewTextBoxColumn.HeaderText = "Lijst"
        Me.GPAantalDataGridViewTextBoxColumn.Name = "GPAantalDataGridViewTextBoxColumn"
        Me.GPAantalDataGridViewTextBoxColumn.Width = 30
        '
        'Voorraad
        '
        Me.Voorraad.DataPropertyName = "PD_Voorraad"
        Me.Voorraad.HeaderText = "Stock"
        Me.Voorraad.Name = "Voorraad"
        Me.Voorraad.Width = 30
        '
        'Besteld
        '
        Me.Besteld.DataPropertyName = "PD_Voorraadordered"
        Me.Besteld.HeaderText = "Besteld"
        Me.Besteld.Name = "Besteld"
        Me.Besteld.Width = 30
        '
        'PDNaamDataGridViewTextBoxColumn
        '
        Me.PDNaamDataGridViewTextBoxColumn.DataPropertyName = "PD_Naam"
        Me.PDNaamDataGridViewTextBoxColumn.HeaderText = "Titel"
        Me.PDNaamDataGridViewTextBoxColumn.Name = "PDNaamDataGridViewTextBoxColumn"
        '
        'PDFunctieDataGridViewTextBoxColumn
        '
        Me.PDFunctieDataGridViewTextBoxColumn.DataPropertyName = "PD_Functie"
        Me.PDFunctieDataGridViewTextBoxColumn.HeaderText = "Functie"
        Me.PDFunctieDataGridViewTextBoxColumn.Name = "PDFunctieDataGridViewTextBoxColumn"
        '
        'PDWaardeDataGridViewTextBoxColumn
        '
        Me.PDWaardeDataGridViewTextBoxColumn.DataPropertyName = "PD_Waarde"
        Me.PDWaardeDataGridViewTextBoxColumn.HeaderText = "Waarde"
        Me.PDWaardeDataGridViewTextBoxColumn.Name = "PDWaardeDataGridViewTextBoxColumn"
        '
        'PDBehuizingDataGridViewTextBoxColumn
        '
        Me.PDBehuizingDataGridViewTextBoxColumn.DataPropertyName = "PD_Behuizing"
        Me.PDBehuizingDataGridViewTextBoxColumn.HeaderText = "behuizing"
        Me.PDBehuizingDataGridViewTextBoxColumn.Name = "PDBehuizingDataGridViewTextBoxColumn"
        '
        'GPBuyPriceEURDataGridViewTextBoxColumn
        '
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.DataPropertyName = "GP_BuyPriceEUR"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.HeaderText = "Inkoop"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.Name = "GPBuyPriceEURDataGridViewTextBoxColumn"
        Me.GPBuyPriceEURDataGridViewTextBoxColumn.Width = 30
        '
        'GetProductListBindingSource
        '
        Me.GetProductListBindingSource.DataMember = "GetProductList"
        Me.GetProductListBindingSource.DataSource = Me.DS_Product
        '
        'Knop_Actie
        '
        Me.Knop_Actie.Location = New System.Drawing.Point(98, 175)
        Me.Knop_Actie.Name = "Knop_Actie"
        Me.Knop_Actie.Size = New System.Drawing.Size(139, 23)
        Me.Knop_Actie.TabIndex = 12
        Me.Knop_Actie.Text = "Boek lijst als ontvangst"
        Me.Knop_Actie.UseVisualStyleBackColor = True
        '
        'Knop_ProductPlus
        '
        Me.Knop_ProductPlus.Location = New System.Drawing.Point(707, 175)
        Me.Knop_ProductPlus.Name = "Knop_ProductPlus"
        Me.Knop_ProductPlus.Size = New System.Drawing.Size(75, 23)
        Me.Knop_ProductPlus.TabIndex = 9
        Me.Knop_ProductPlus.Text = "Product +"
        Me.Knop_ProductPlus.UseVisualStyleBackColor = True
        '
        'Knop_Kosten
        '
        Me.Knop_Kosten.Location = New System.Drawing.Point(12, 441)
        Me.Knop_Kosten.Name = "Knop_Kosten"
        Me.Knop_Kosten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Kosten.TabIndex = 7
        Me.Knop_Kosten.Text = "&Kosten"
        Me.Knop_Kosten.UseVisualStyleBackColor = True
        '
        'GB_Get
        '
        Me.GB_Get.Controls.Add(GV_BeschrijvingLabel)
        Me.GB_Get.Controls.Add(Me.TXT_Beschrijving)
        Me.GB_Get.Controls.Add(GV_DatumLabel)
        Me.GB_Get.Controls.Add(Me.GV_DatumDateTimePicker)
        Me.GB_Get.Controls.Add(Me.TXT_NaamGet)
        Me.GB_Get.Controls.Add(Me.TXT_getontvangstid)
        Me.GB_Get.Controls.Add(Me.Label3)
        Me.GB_Get.Controls.Add(Me.CB_Ontvangen)
        Me.GB_Get.Location = New System.Drawing.Point(12, 12)
        Me.GB_Get.Name = "GB_Get"
        Me.GB_Get.Size = New System.Drawing.Size(547, 119)
        Me.GB_Get.TabIndex = 2
        Me.GB_Get.TabStop = False
        Me.GB_Get.Text = "Producten verwerken"
        '
        'TXT_Beschrijving
        '
        Me.TXT_Beschrijving.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOntvangstBindingSource, "GV_Beschrijving", True))
        Me.TXT_Beschrijving.Location = New System.Drawing.Point(86, 67)
        Me.TXT_Beschrijving.Multiline = True
        Me.TXT_Beschrijving.Name = "TXT_Beschrijving"
        Me.TXT_Beschrijving.Size = New System.Drawing.Size(262, 37)
        Me.TXT_Beschrijving.TabIndex = 7
        '
        'GV_DatumDateTimePicker
        '
        Me.GV_DatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GetOntvangstBindingSource, "GV_Datum", True))
        Me.GV_DatumDateTimePicker.Location = New System.Drawing.Point(86, 41)
        Me.GV_DatumDateTimePicker.Name = "GV_DatumDateTimePicker"
        Me.GV_DatumDateTimePicker.Size = New System.Drawing.Size(262, 20)
        Me.GV_DatumDateTimePicker.TabIndex = 6
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
        Me.TXT_getontvangstid.Location = New System.Drawing.Point(487, 15)
        Me.TXT_getontvangstid.Name = "TXT_getontvangstid"
        Me.TXT_getontvangstid.Size = New System.Drawing.Size(40, 20)
        Me.TXT_getontvangstid.TabIndex = 4
        Me.TXT_getontvangstid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Knop_Sluiten.Location = New System.Drawing.Point(664, 108)
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
        Me.Knop_Opslaan.Location = New System.Drawing.Point(664, 79)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Opslaan.TabIndex = 5
        Me.Knop_Opslaan.Text = "&Opslaan"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'TXT_output
        '
        Me.TXT_output.Location = New System.Drawing.Point(570, 141)
        Me.TXT_output.Multiline = True
        Me.TXT_output.Name = "TXT_output"
        Me.TXT_output.Size = New System.Drawing.Size(169, 59)
        Me.TXT_output.TabIndex = 7
        '
        'ShopTableAdapter
        '
        Me.ShopTableAdapter.ClearBeforeFill = True
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(581, 53)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(158, 23)
        Me.Knop_Nieuw.TabIndex = 8
        Me.Knop_Nieuw.Text = "Nieuwe levering, order"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'GetProductListTableAdapter
        '
        Me.GetProductListTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(664, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "herlaad form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Knop_update
        '
        Me.Knop_update.Location = New System.Drawing.Point(719, 493)
        Me.Knop_update.Name = "Knop_update"
        Me.Knop_update.Size = New System.Drawing.Size(75, 23)
        Me.Knop_update.TabIndex = 13
        Me.Knop_update.Text = "Update lijst naar DB"
        Me.Knop_update.UseVisualStyleBackColor = True
        '
        'Knop_OpslaanDB
        '
        Me.Knop_OpslaanDB.Location = New System.Drawing.Point(638, 493)
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
        Me.TXT_Voorraad.Location = New System.Drawing.Point(751, 82)
        Me.TXT_Voorraad.Name = "TXT_Voorraad"
        Me.TXT_Voorraad.Size = New System.Drawing.Size(43, 20)
        Me.TXT_Voorraad.TabIndex = 16
        '
        'TXT_LijstAantal
        '
        Me.TXT_LijstAantal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAAantalBindingSource, "GP_Aantal", True))
        Me.TXT_LijstAantal.Enabled = False
        Me.TXT_LijstAantal.Location = New System.Drawing.Point(751, 110)
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
        Me.TXT_AdmInkoop.Location = New System.Drawing.Point(93, 444)
        Me.TXT_AdmInkoop.Name = "TXT_AdmInkoop"
        Me.TXT_AdmInkoop.Size = New System.Drawing.Size(102, 20)
        Me.TXT_AdmInkoop.TabIndex = 18
        '
        'F_GetProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 601)
        Me.Controls.Add(Me.TXT_AdmInkoop)
        Me.Controls.Add(Me.Knop_Kosten)
        Me.Controls.Add(Me.TXT_LijstAantal)
        Me.Controls.Add(Me.TXT_Voorraad)
        Me.Controls.Add(Me.Knop_OpslaanDB)
        Me.Controls.Add(Me.Knop_update)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Knop_Nieuw)
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
        CType(Me.DG_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Get.ResumeLayout(False)
        Me.GB_Get.PerformLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPAAantalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GetProductListBindingSource As BindingSource
    Friend WithEvents GetProductListTableAdapter As DS_ProductTableAdapters.GetProductListTableAdapter
    Friend WithEvents DG_List As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Knop_Actie As Button
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
    Friend WithEvents IDGetOntvangstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID_GetProductAdd As DataGridViewTextBoxColumn
    Friend WithEvents idP As DataGridViewTextBoxColumn
    Friend WithEvents GPAantalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Voorraad As DataGridViewTextBoxColumn
    Friend WithEvents Besteld As DataGridViewTextBoxColumn
    Friend WithEvents PDNaamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDFunctieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDWaardeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDBehuizingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPBuyPriceEURDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GV_DatumDateTimePicker As DateTimePicker
    Friend WithEvents TXT_Beschrijving As TextBox
    Friend WithEvents Knop_Supplier As Button
    Friend WithEvents Knop_Kosten As Button
    Friend WithEvents TXT_AdmInkoop As TextBox
End Class

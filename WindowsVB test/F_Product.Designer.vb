﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Product
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
        Me.components = New System.ComponentModel.Container()
        Dim ID_GroepLabel As System.Windows.Forms.Label
        Dim PD_NaamLabel As System.Windows.Forms.Label
        Dim PD_BehuizingLabel As System.Windows.Forms.Label
        Dim PD_FunctieLabel As System.Windows.Forms.Label
        Dim PD_WaardeLabel As System.Windows.Forms.Label
        Dim ID_MerkLabel As System.Windows.Forms.Label
        Dim ID_ProductLabel As System.Windows.Forms.Label
        Dim PD_Sale_PrijsLabel As System.Windows.Forms.Label
        Dim PD_Buy_CostLabel As System.Windows.Forms.Label
        Dim PD_MinimumVoorraadLabel As System.Windows.Forms.Label
        Dim PD_VoorraadLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Product))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_PN = New System.Windows.Forms.Label()
        Me.TXT_Productnummer = New System.Windows.Forms.TextBox()
        Me.Knop_ZoekProduct = New System.Windows.Forms.Button()
        Me.Knop_DetailsGroep = New System.Windows.Forms.Button()
        Me.CB_Groep = New System.Windows.Forms.ComboBox()
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.GroepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MerkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knop_OpslaanSluiten = New System.Windows.Forms.Button()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.DT_productTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.DT_productTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.DT_productBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DT_productBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IDProductToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IDProductToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroepTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GroepTableAdapter()
        Me.MerkTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.MerkTableAdapter()
        Me.GBOX_Velden = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GB_Merk = New System.Windows.Forms.ComboBox()
        Me.PD_NaamTextBox = New System.Windows.Forms.TextBox()
        Me.PD_FunctieTextBox = New System.Windows.Forms.TextBox()
        Me.PD_BehuizingTextBox = New System.Windows.Forms.TextBox()
        Me.PD_WaardeTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProductTextBox = New System.Windows.Forms.TextBox()
        Me.ID_GroepTextBox = New System.Windows.Forms.TextBox()
        Me.ID_MerkTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_LaatsteInkoop_Waarde = New System.Windows.Forms.TextBox()
        Me.TXT_Laatste_inkoop_Datum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PD_MinimumVoorraadTextBox = New System.Windows.Forms.TextBox()
        Me.PD_VoorraadTextBox = New System.Windows.Forms.TextBox()
        Me.TXT_Verkoopprijs = New System.Windows.Forms.TextBox()
        Me.TXT_Inkoopwaarde = New System.Windows.Forms.TextBox()
        Me.TAB_Product = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_Beschrijving1 = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TXT_Beschrijving2 = New System.Windows.Forms.TextBox()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        ID_GroepLabel = New System.Windows.Forms.Label()
        PD_NaamLabel = New System.Windows.Forms.Label()
        PD_BehuizingLabel = New System.Windows.Forms.Label()
        PD_FunctieLabel = New System.Windows.Forms.Label()
        PD_WaardeLabel = New System.Windows.Forms.Label()
        ID_MerkLabel = New System.Windows.Forms.Label()
        ID_ProductLabel = New System.Windows.Forms.Label()
        PD_Sale_PrijsLabel = New System.Windows.Forms.Label()
        PD_Buy_CostLabel = New System.Windows.Forms.Label()
        PD_MinimumVoorraadLabel = New System.Windows.Forms.Label()
        PD_VoorraadLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_productBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_productBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        Me.GBOX_Velden.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TAB_Product.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_GroepLabel
        '
        ID_GroepLabel.AutoSize = True
        ID_GroepLabel.Location = New System.Drawing.Point(22, 55)
        ID_GroepLabel.Name = "ID_GroepLabel"
        ID_GroepLabel.Size = New System.Drawing.Size(74, 13)
        ID_GroepLabel.TabIndex = 2
        ID_GroepLabel.Text = "Productgroep:"
        '
        'PD_NaamLabel
        '
        PD_NaamLabel.AutoSize = True
        PD_NaamLabel.Location = New System.Drawing.Point(28, 20)
        PD_NaamLabel.Name = "PD_NaamLabel"
        PD_NaamLabel.Size = New System.Drawing.Size(68, 13)
        PD_NaamLabel.TabIndex = 18
        PD_NaamLabel.Text = "Naam, code:"
        '
        'PD_BehuizingLabel
        '
        PD_BehuizingLabel.AutoSize = True
        PD_BehuizingLabel.Location = New System.Drawing.Point(40, 91)
        PD_BehuizingLabel.Name = "PD_BehuizingLabel"
        PD_BehuizingLabel.Size = New System.Drawing.Size(56, 13)
        PD_BehuizingLabel.TabIndex = 24
        PD_BehuizingLabel.Text = "Behuizing:"
        '
        'PD_FunctieLabel
        '
        PD_FunctieLabel.AutoSize = True
        PD_FunctieLabel.Location = New System.Drawing.Point(51, 43)
        PD_FunctieLabel.Name = "PD_FunctieLabel"
        PD_FunctieLabel.Size = New System.Drawing.Size(45, 13)
        PD_FunctieLabel.TabIndex = 20
        PD_FunctieLabel.Text = "Functie:"
        '
        'PD_WaardeLabel
        '
        PD_WaardeLabel.AutoSize = True
        PD_WaardeLabel.Location = New System.Drawing.Point(43, 67)
        PD_WaardeLabel.Name = "PD_WaardeLabel"
        PD_WaardeLabel.Size = New System.Drawing.Size(53, 13)
        PD_WaardeLabel.TabIndex = 22
        PD_WaardeLabel.Text = "Waardes:"
        '
        'ID_MerkLabel
        '
        ID_MerkLabel.AutoSize = True
        ID_MerkLabel.Location = New System.Drawing.Point(62, 115)
        ID_MerkLabel.Name = "ID_MerkLabel"
        ID_MerkLabel.Size = New System.Drawing.Size(34, 13)
        ID_MerkLabel.TabIndex = 26
        ID_MerkLabel.Text = "Merk:"
        '
        'ID_ProductLabel
        '
        ID_ProductLabel.AutoSize = True
        ID_ProductLabel.Location = New System.Drawing.Point(635, 53)
        ID_ProductLabel.Name = "ID_ProductLabel"
        ID_ProductLabel.Size = New System.Drawing.Size(61, 13)
        ID_ProductLabel.TabIndex = 18
        ID_ProductLabel.Text = "ID Product:"
        '
        'PD_Sale_PrijsLabel
        '
        PD_Sale_PrijsLabel.AutoSize = True
        PD_Sale_PrijsLabel.Location = New System.Drawing.Point(25, 21)
        PD_Sale_PrijsLabel.Name = "PD_Sale_PrijsLabel"
        PD_Sale_PrijsLabel.Size = New System.Drawing.Size(68, 13)
        PD_Sale_PrijsLabel.TabIndex = 22
        PD_Sale_PrijsLabel.Text = "Verkoopprijs:"
        AddHandler PD_Sale_PrijsLabel.MouseHover, AddressOf Me.PD_Sale_PrijsLabel_MouseHover
        '
        'PD_Buy_CostLabel
        '
        PD_Buy_CostLabel.AutoSize = True
        PD_Buy_CostLabel.Location = New System.Drawing.Point(18, 45)
        PD_Buy_CostLabel.Name = "PD_Buy_CostLabel"
        PD_Buy_CostLabel.Size = New System.Drawing.Size(78, 13)
        PD_Buy_CostLabel.TabIndex = 24
        PD_Buy_CostLabel.Text = "Inkoopwaarde:"
        PD_Buy_CostLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PD_MinimumVoorraadLabel
        '
        PD_MinimumVoorraadLabel.AutoSize = True
        PD_MinimumVoorraadLabel.Location = New System.Drawing.Point(142, 123)
        PD_MinimumVoorraadLabel.Name = "PD_MinimumVoorraadLabel"
        PD_MinimumVoorraadLabel.Size = New System.Drawing.Size(51, 13)
        PD_MinimumVoorraadLabel.TabIndex = 30
        PD_MinimumVoorraadLabel.Text = "Minimaal:"
        '
        'PD_VoorraadLabel
        '
        PD_VoorraadLabel.AutoSize = True
        PD_VoorraadLabel.Location = New System.Drawing.Point(43, 123)
        PD_VoorraadLabel.Name = "PD_VoorraadLabel"
        PD_VoorraadLabel.Size = New System.Drawing.Size(56, 13)
        PD_VoorraadLabel.TabIndex = 28
        PD_VoorraadLabel.Text = "Voorraad: "
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(51, 146)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 13)
        Label1.TabIndex = 38
        Label1.Text = "Lokatie:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_PN)
        Me.GroupBox1.Controls.Add(Me.TXT_Productnummer)
        Me.GroupBox1.Controls.Add(Me.Knop_ZoekProduct)
        Me.GroupBox1.Controls.Add(Me.Knop_DetailsGroep)
        Me.GroupBox1.Controls.Add(Me.CB_Groep)
        Me.GroupBox1.Controls.Add(ID_GroepLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 80)
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
        Me.TXT_Productnummer.TabIndex = 1
        Me.TXT_Productnummer.TabStop = False
        '
        'Knop_ZoekProduct
        '
        Me.Knop_ZoekProduct.Location = New System.Drawing.Point(208, 22)
        Me.Knop_ZoekProduct.Name = "Knop_ZoekProduct"
        Me.Knop_ZoekProduct.Size = New System.Drawing.Size(79, 23)
        Me.Knop_ZoekProduct.TabIndex = 18
        Me.Knop_ZoekProduct.TabStop = False
        Me.Knop_ZoekProduct.Text = "Zoek.."
        Me.Knop_ZoekProduct.UseVisualStyleBackColor = True
        '
        'Knop_DetailsGroep
        '
        Me.Knop_DetailsGroep.Location = New System.Drawing.Point(258, 50)
        Me.Knop_DetailsGroep.Name = "Knop_DetailsGroep"
        Me.Knop_DetailsGroep.Size = New System.Drawing.Size(28, 23)
        Me.Knop_DetailsGroep.TabIndex = 16
        Me.Knop_DetailsGroep.TabStop = False
        Me.Knop_DetailsGroep.Text = ">"
        Me.Knop_DetailsGroep.UseVisualStyleBackColor = True
        '
        'CB_Groep
        '
        Me.CB_Groep.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_productBindingSource, "ID_Groep", True))
        Me.CB_Groep.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "GP_Naam", True))
        Me.CB_Groep.DataSource = Me.GroepBindingSource
        Me.CB_Groep.DisplayMember = "GP_Naam"
        Me.CB_Groep.FormattingEnabled = True
        Me.CB_Groep.Location = New System.Drawing.Point(102, 50)
        Me.CB_Groep.Name = "CB_Groep"
        Me.CB_Groep.Size = New System.Drawing.Size(150, 21)
        Me.CB_Groep.TabIndex = 14
        Me.CB_Groep.ValueMember = "ID_Groep"
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
        'Knop_OpslaanSluiten
        '
        Me.Knop_OpslaanSluiten.Location = New System.Drawing.Point(540, 492)
        Me.Knop_OpslaanSluiten.Name = "Knop_OpslaanSluiten"
        Me.Knop_OpslaanSluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_OpslaanSluiten.TabIndex = 1
        Me.Knop_OpslaanSluiten.Text = "Sluiten"
        Me.Knop_OpslaanSluiten.UseVisualStyleBackColor = True
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(632, 213)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Opslaan.TabIndex = 2
        Me.Knop_Opslaan.Text = "Opslaan"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'DT_productTableAdapter
        '
        Me.DT_productTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DT_productTableAdapter = Me.DT_productTableAdapter
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DT_productBindingNavigator
        '
        Me.DT_productBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DT_productBindingNavigator.BindingSource = Me.DT_productBindingSource
        Me.DT_productBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DT_productBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DT_productBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DT_productBindingNavigatorSaveItem})
        Me.DT_productBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DT_productBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_productBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_productBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_productBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_productBindingNavigator.Name = "DT_productBindingNavigator"
        Me.DT_productBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_productBindingNavigator.Size = New System.Drawing.Size(1156, 25)
        Me.DT_productBindingNavigator.TabIndex = 3
        Me.DT_productBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DT_productBindingNavigatorSaveItem
        '
        Me.DT_productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DT_productBindingNavigatorSaveItem.Image = CType(resources.GetObject("DT_productBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DT_productBindingNavigatorSaveItem.Name = "DT_productBindingNavigatorSaveItem"
        Me.DT_productBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DT_productBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDProductToolStripLabel, Me.IDProductToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1156, 25)
        Me.FillToolStrip.TabIndex = 4
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'IDProductToolStripLabel
        '
        Me.IDProductToolStripLabel.Name = "IDProductToolStripLabel"
        Me.IDProductToolStripLabel.Size = New System.Drawing.Size(63, 22)
        Me.IDProductToolStripLabel.Text = "IDProduct:"
        '
        'IDProductToolStripTextBox
        '
        Me.IDProductToolStripTextBox.Name = "IDProductToolStripTextBox"
        Me.IDProductToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
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
        Me.GBOX_Velden.Controls.Add(Me.Button2)
        Me.GBOX_Velden.Controls.Add(Me.GB_Merk)
        Me.GBOX_Velden.Controls.Add(ID_MerkLabel)
        Me.GBOX_Velden.Controls.Add(Me.PD_NaamTextBox)
        Me.GBOX_Velden.Controls.Add(PD_NaamLabel)
        Me.GBOX_Velden.Controls.Add(PD_BehuizingLabel)
        Me.GBOX_Velden.Controls.Add(Me.PD_FunctieTextBox)
        Me.GBOX_Velden.Controls.Add(Me.PD_BehuizingTextBox)
        Me.GBOX_Velden.Controls.Add(PD_FunctieLabel)
        Me.GBOX_Velden.Controls.Add(PD_WaardeLabel)
        Me.GBOX_Velden.Controls.Add(Me.PD_WaardeTextBox)
        Me.GBOX_Velden.Location = New System.Drawing.Point(12, 133)
        Me.GBOX_Velden.Name = "GBOX_Velden"
        Me.GBOX_Velden.Size = New System.Drawing.Size(341, 148)
        Me.GBOX_Velden.TabIndex = 0
        Me.GBOX_Velden.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.TabStop = False
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GB_Merk
        '
        Me.GB_Merk.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_productBindingSource, "ID_Merk", True))
        Me.GB_Merk.DataSource = Me.MerkBindingSource
        Me.GB_Merk.DisplayMember = "MK_MerkNaam"
        Me.GB_Merk.FormattingEnabled = True
        Me.GB_Merk.Location = New System.Drawing.Point(102, 112)
        Me.GB_Merk.Name = "GB_Merk"
        Me.GB_Merk.Size = New System.Drawing.Size(150, 21)
        Me.GB_Merk.TabIndex = 4
        Me.GB_Merk.ValueMember = "ID_Merk"
        '
        'PD_NaamTextBox
        '
        Me.PD_NaamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Naam", True))
        Me.PD_NaamTextBox.Location = New System.Drawing.Point(102, 17)
        Me.PD_NaamTextBox.Name = "PD_NaamTextBox"
        Me.PD_NaamTextBox.Size = New System.Drawing.Size(184, 20)
        Me.PD_NaamTextBox.TabIndex = 0
        '
        'PD_FunctieTextBox
        '
        Me.PD_FunctieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Functie", True))
        Me.PD_FunctieTextBox.Location = New System.Drawing.Point(102, 40)
        Me.PD_FunctieTextBox.Name = "PD_FunctieTextBox"
        Me.PD_FunctieTextBox.Size = New System.Drawing.Size(184, 20)
        Me.PD_FunctieTextBox.TabIndex = 1
        '
        'PD_BehuizingTextBox
        '
        Me.PD_BehuizingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Behuizing", True))
        Me.PD_BehuizingTextBox.Location = New System.Drawing.Point(102, 88)
        Me.PD_BehuizingTextBox.Name = "PD_BehuizingTextBox"
        Me.PD_BehuizingTextBox.Size = New System.Drawing.Size(185, 20)
        Me.PD_BehuizingTextBox.TabIndex = 3
        '
        'PD_WaardeTextBox
        '
        Me.PD_WaardeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Waarde", True))
        Me.PD_WaardeTextBox.Location = New System.Drawing.Point(102, 64)
        Me.PD_WaardeTextBox.Name = "PD_WaardeTextBox"
        Me.PD_WaardeTextBox.Size = New System.Drawing.Size(184, 20)
        Me.PD_WaardeTextBox.TabIndex = 2
        '
        'ID_ProductTextBox
        '
        Me.ID_ProductTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "ID_Product", True))
        Me.ID_ProductTextBox.Location = New System.Drawing.Point(632, 71)
        Me.ID_ProductTextBox.Name = "ID_ProductTextBox"
        Me.ID_ProductTextBox.Size = New System.Drawing.Size(64, 20)
        Me.ID_ProductTextBox.TabIndex = 19
        '
        'ID_GroepTextBox
        '
        Me.ID_GroepTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "ID_Groep", True))
        Me.ID_GroepTextBox.Location = New System.Drawing.Point(632, 129)
        Me.ID_GroepTextBox.Name = "ID_GroepTextBox"
        Me.ID_GroepTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_GroepTextBox.TabIndex = 20
        '
        'ID_MerkTextBox
        '
        Me.ID_MerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "ID_Merk", True))
        Me.ID_MerkTextBox.Location = New System.Drawing.Point(632, 103)
        Me.ID_MerkTextBox.Name = "ID_MerkTextBox"
        Me.ID_MerkTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_MerkTextBox.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TXT_LaatsteInkoop_Waarde)
        Me.GroupBox3.Controls.Add(Me.TXT_Laatste_inkoop_Datum)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(PD_MinimumVoorraadLabel)
        Me.GroupBox3.Controls.Add(Me.PD_MinimumVoorraadTextBox)
        Me.GroupBox3.Controls.Add(PD_VoorraadLabel)
        Me.GroupBox3.Controls.Add(Me.PD_VoorraadTextBox)
        Me.GroupBox3.Controls.Add(PD_Sale_PrijsLabel)
        Me.GroupBox3.Controls.Add(Me.TXT_Verkoopprijs)
        Me.GroupBox3.Controls.Add(Me.TXT_Inkoopwaarde)
        Me.GroupBox3.Controls.Add(PD_Buy_CostLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(359, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 228)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prijzen"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_MinimumVoorraad", True))
        Me.TextBox1.Location = New System.Drawing.Point(102, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Waarde:"
        '
        'TXT_LaatsteInkoop_Waarde
        '
        Me.TXT_LaatsteInkoop_Waarde.Location = New System.Drawing.Point(102, 91)
        Me.TXT_LaatsteInkoop_Waarde.Name = "TXT_LaatsteInkoop_Waarde"
        Me.TXT_LaatsteInkoop_Waarde.Size = New System.Drawing.Size(103, 20)
        Me.TXT_LaatsteInkoop_Waarde.TabIndex = 36
        '
        'TXT_Laatste_inkoop_Datum
        '
        Me.TXT_Laatste_inkoop_Datum.Location = New System.Drawing.Point(102, 68)
        Me.TXT_Laatste_inkoop_Datum.Name = "TXT_Laatste_inkoop_Datum"
        Me.TXT_Laatste_inkoop_Datum.Size = New System.Drawing.Size(103, 20)
        Me.TXT_Laatste_inkoop_Datum.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Laatste inkoop:"
        '
        'PD_MinimumVoorraadTextBox
        '
        Me.PD_MinimumVoorraadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_MinimumVoorraad", True))
        Me.PD_MinimumVoorraadTextBox.Location = New System.Drawing.Point(199, 120)
        Me.PD_MinimumVoorraadTextBox.Name = "PD_MinimumVoorraadTextBox"
        Me.PD_MinimumVoorraadTextBox.Size = New System.Drawing.Size(34, 20)
        Me.PD_MinimumVoorraadTextBox.TabIndex = 31
        '
        'PD_VoorraadTextBox
        '
        Me.PD_VoorraadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.PD_VoorraadTextBox.Location = New System.Drawing.Point(102, 120)
        Me.PD_VoorraadTextBox.Name = "PD_VoorraadTextBox"
        Me.PD_VoorraadTextBox.Size = New System.Drawing.Size(34, 20)
        Me.PD_VoorraadTextBox.TabIndex = 29
        '
        'TXT_Verkoopprijs
        '
        Me.TXT_Verkoopprijs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Sale_Prijs", True))
        Me.TXT_Verkoopprijs.Location = New System.Drawing.Point(102, 18)
        Me.TXT_Verkoopprijs.Name = "TXT_Verkoopprijs"
        Me.TXT_Verkoopprijs.Size = New System.Drawing.Size(69, 20)
        Me.TXT_Verkoopprijs.TabIndex = 23
        '
        'TXT_Inkoopwaarde
        '
        Me.TXT_Inkoopwaarde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Buy_Cost", True))
        Me.TXT_Inkoopwaarde.Location = New System.Drawing.Point(102, 42)
        Me.TXT_Inkoopwaarde.Name = "TXT_Inkoopwaarde"
        Me.TXT_Inkoopwaarde.Size = New System.Drawing.Size(69, 20)
        Me.TXT_Inkoopwaarde.TabIndex = 25
        '
        'TAB_Product
        '
        Me.TAB_Product.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TAB_Product.Controls.Add(Me.TabPage3)
        Me.TAB_Product.Controls.Add(Me.TabPage5)
        Me.TAB_Product.Controls.Add(Me.TabPage6)
        Me.TAB_Product.Controls.Add(Me.TabPage2)
        Me.TAB_Product.Controls.Add(Me.TabPage1)
        Me.TAB_Product.Controls.Add(Me.TabPage4)
        Me.TAB_Product.Location = New System.Drawing.Point(12, 288)
        Me.TAB_Product.Name = "TAB_Product"
        Me.TAB_Product.SelectedIndex = 0
        Me.TAB_Product.Size = New System.Drawing.Size(607, 198)
        Me.TAB_Product.TabIndex = 38
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_Beschrijving1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(599, 172)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Beschrijving product"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_Beschrijving1
        '
        Me.txt_Beschrijving1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Beschrijving(1)", True))
        Me.txt_Beschrijving1.Location = New System.Drawing.Point(3, 6)
        Me.txt_Beschrijving1.Multiline = True
        Me.txt_Beschrijving1.Name = "txt_Beschrijving1"
        Me.txt_Beschrijving1.Size = New System.Drawing.Size(593, 159)
        Me.txt_Beschrijving1.TabIndex = 37
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(599, 172)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Afbeeldingen"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(599, 172)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Hyperlinks "
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(599, 172)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gebruikt voor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(599, 172)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ontvangen "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TXT_Beschrijving2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(599, 172)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Opmerkingen"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TXT_Beschrijving2
        '
        Me.TXT_Beschrijving2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Beschrijving(2)", True))
        Me.TXT_Beschrijving2.Location = New System.Drawing.Point(11, 6)
        Me.TXT_Beschrijving2.Multiline = True
        Me.TXT_Beschrijving2.Name = "TXT_Beschrijving2"
        Me.TXT_Beschrijving2.Size = New System.Drawing.Size(582, 159)
        Me.TXT_Beschrijving2.TabIndex = 35
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(632, 184)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 39
        Me.Knop_Annuleren.Text = "annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(632, 155)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Nieuw.TabIndex = 40
        Me.Knop_Nieuw.Text = "Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'F_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 591)
        Me.Controls.Add(Me.Knop_Nieuw)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.TAB_Product)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ID_ProductTextBox)
        Me.Controls.Add(ID_ProductLabel)
        Me.Controls.Add(Me.ID_GroepTextBox)
        Me.Controls.Add(Me.ID_MerkTextBox)
        Me.Controls.Add(Me.GBOX_Velden)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.DT_productBindingNavigator)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.Knop_OpslaanSluiten)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_Product"
        Me.Text = "Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_productBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_productBindingNavigator.ResumeLayout(False)
        Me.DT_productBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.GBOX_Velden.ResumeLayout(False)
        Me.GBOX_Velden.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TAB_Product.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Knop_OpslaanSluiten As Button
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents DT_productBindingSource As BindingSource
    Friend WithEvents DT_productTableAdapter As DS_ProductTableAdapters.DT_productTableAdapter
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents DT_productBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DT_productBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents IDProductToolStripLabel As ToolStripLabel
    Friend WithEvents IDProductToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents CB_Groep As ComboBox
    Friend WithEvents GroepBindingSource As BindingSource
    Friend WithEvents GroepTableAdapter As DS_ProductTableAdapters.GroepTableAdapter
    Friend WithEvents DSProductBindingSource As BindingSource
    Friend WithEvents MerkBindingSource As BindingSource
    Friend WithEvents MerkTableAdapter As DS_ProductTableAdapters.MerkTableAdapter
    Friend WithEvents Knop_DetailsGroep As Button
    Friend WithEvents Knop_ZoekProduct As Button
    Friend WithEvents LBL_PN As Label
    Friend WithEvents TXT_Productnummer As TextBox
    Friend WithEvents GBOX_Velden As GroupBox
    Friend WithEvents PD_NaamTextBox As TextBox
    Friend WithEvents PD_FunctieTextBox As TextBox
    Friend WithEvents PD_BehuizingTextBox As TextBox
    Friend WithEvents PD_WaardeTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GB_Merk As ComboBox
    Friend WithEvents ID_ProductTextBox As TextBox
    Friend WithEvents ID_GroepTextBox As TextBox
    Friend WithEvents ID_MerkTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXT_Verkoopprijs As TextBox
    Friend WithEvents TXT_Inkoopwaarde As TextBox
    Friend WithEvents TXT_Laatste_inkoop_Datum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PD_MinimumVoorraadTextBox As TextBox
    Friend WithEvents PD_VoorraadTextBox As TextBox
    Friend WithEvents TXT_LaatsteInkoop_Waarde As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TAB_Product As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txt_Beschrijving1 As TextBox
    Friend WithEvents TXT_Beschrijving2 As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Knop_Nieuw As Button
End Class

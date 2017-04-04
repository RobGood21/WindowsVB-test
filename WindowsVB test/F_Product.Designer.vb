<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Product))
        Dim ID_ProductLabel As System.Windows.Forms.Label
        Dim ID_GroepLabel As System.Windows.Forms.Label
        Dim ID_MerkLabel As System.Windows.Forms.Label
        Dim PD_NaamLabel As System.Windows.Forms.Label
        Dim PD_FunctieLabel As System.Windows.Forms.Label
        Dim PD_WaardeLabel As System.Windows.Forms.Label
        Dim PD_BehuizingLabel As System.Windows.Forms.Label
        Dim PD_Sale_PrijsLabel As System.Windows.Forms.Label
        Dim PD_Buy_CostLabel As System.Windows.Forms.Label
        Dim PD_VoorraadLabel As System.Windows.Forms.Label
        Dim PD_MinimumVoorraadLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Knop_OpslaanSluiten = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.DT_productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_productTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.DT_productTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.DT_productBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DT_productBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IDProductToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IDProductToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ID_ProductTextBox = New System.Windows.Forms.TextBox()
        Me.ID_GroepTextBox = New System.Windows.Forms.TextBox()
        Me.ID_MerkTextBox = New System.Windows.Forms.TextBox()
        Me.PD_NaamTextBox = New System.Windows.Forms.TextBox()
        Me.PD_FunctieTextBox = New System.Windows.Forms.TextBox()
        Me.PD_WaardeTextBox = New System.Windows.Forms.TextBox()
        Me.PD_BehuizingTextBox = New System.Windows.Forms.TextBox()
        Me.txt_Beschrijving1 = New System.Windows.Forms.TextBox()
        Me.TXT_Beschrijving2 = New System.Windows.Forms.TextBox()
        Me.PD_Sale_PrijsTextBox = New System.Windows.Forms.TextBox()
        Me.PD_Buy_CostTextBox = New System.Windows.Forms.TextBox()
        Me.PD_VoorraadTextBox = New System.Windows.Forms.TextBox()
        Me.PD_MinimumVoorraadTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        ID_ProductLabel = New System.Windows.Forms.Label()
        ID_GroepLabel = New System.Windows.Forms.Label()
        ID_MerkLabel = New System.Windows.Forms.Label()
        PD_NaamLabel = New System.Windows.Forms.Label()
        PD_FunctieLabel = New System.Windows.Forms.Label()
        PD_WaardeLabel = New System.Windows.Forms.Label()
        PD_BehuizingLabel = New System.Windows.Forms.Label()
        PD_Sale_PrijsLabel = New System.Windows.Forms.Label()
        PD_Buy_CostLabel = New System.Windows.Forms.Label()
        PD_VoorraadLabel = New System.Windows.Forms.Label()
        PD_MinimumVoorraadLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_productBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_productBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(PD_BehuizingLabel)
        Me.GroupBox1.Controls.Add(Me.PD_BehuizingTextBox)
        Me.GroupBox1.Controls.Add(PD_WaardeLabel)
        Me.GroupBox1.Controls.Add(Me.PD_WaardeTextBox)
        Me.GroupBox1.Controls.Add(PD_FunctieLabel)
        Me.GroupBox1.Controls.Add(Me.PD_FunctieTextBox)
        Me.GroupBox1.Controls.Add(PD_NaamLabel)
        Me.GroupBox1.Controls.Add(Me.PD_NaamTextBox)
        Me.GroupBox1.Controls.Add(ID_MerkLabel)
        Me.GroupBox1.Controls.Add(Me.ID_MerkTextBox)
        Me.GroupBox1.Controls.Add(ID_GroepLabel)
        Me.GroupBox1.Controls.Add(Me.ID_GroepTextBox)
        Me.GroupBox1.Controls.Add(ID_ProductLabel)
        Me.GroupBox1.Controls.Add(Me.ID_ProductTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 362)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product"
        '
        'Knop_OpslaanSluiten
        '
        Me.Knop_OpslaanSluiten.Location = New System.Drawing.Point(624, 427)
        Me.Knop_OpslaanSluiten.Name = "Knop_OpslaanSluiten"
        Me.Knop_OpslaanSluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_OpslaanSluiten.TabIndex = 1
        Me.Knop_OpslaanSluiten.Text = "Sluiten"
        Me.Knop_OpslaanSluiten.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DT_productBindingNavigator.Size = New System.Drawing.Size(751, 25)
        Me.DT_productBindingNavigator.TabIndex = 3
        Me.DT_productBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.FillToolStrip.Size = New System.Drawing.Size(751, 25)
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
        'ID_ProductLabel
        '
        ID_ProductLabel.AutoSize = True
        ID_ProductLabel.Location = New System.Drawing.Point(35, 35)
        ID_ProductLabel.Name = "ID_ProductLabel"
        ID_ProductLabel.Size = New System.Drawing.Size(61, 13)
        ID_ProductLabel.TabIndex = 0
        ID_ProductLabel.Text = "ID Product:"
        AddHandler ID_ProductLabel.Click, AddressOf Me.ID_ProductLabel_Click
        '
        'ID_ProductTextBox
        '
        Me.ID_ProductTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "ID_Product", True))
        Me.ID_ProductTextBox.Location = New System.Drawing.Point(102, 32)
        Me.ID_ProductTextBox.Name = "ID_ProductTextBox"
        Me.ID_ProductTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_ProductTextBox.TabIndex = 1
        '
        'ID_GroepLabel
        '
        ID_GroepLabel.AutoSize = True
        ID_GroepLabel.Location = New System.Drawing.Point(43, 61)
        ID_GroepLabel.Name = "ID_GroepLabel"
        ID_GroepLabel.Size = New System.Drawing.Size(53, 13)
        ID_GroepLabel.TabIndex = 2
        ID_GroepLabel.Text = "ID Groep:"
        '
        'ID_GroepTextBox
        '
        Me.ID_GroepTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "ID_Groep", True))
        Me.ID_GroepTextBox.Location = New System.Drawing.Point(102, 58)
        Me.ID_GroepTextBox.Name = "ID_GroepTextBox"
        Me.ID_GroepTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_GroepTextBox.TabIndex = 3
        '
        'ID_MerkLabel
        '
        ID_MerkLabel.AutoSize = True
        ID_MerkLabel.Location = New System.Drawing.Point(48, 87)
        ID_MerkLabel.Name = "ID_MerkLabel"
        ID_MerkLabel.Size = New System.Drawing.Size(48, 13)
        ID_MerkLabel.TabIndex = 4
        ID_MerkLabel.Text = "ID Merk:"
        '
        'ID_MerkTextBox
        '
        Me.ID_MerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "ID_Merk", True))
        Me.ID_MerkTextBox.Location = New System.Drawing.Point(102, 84)
        Me.ID_MerkTextBox.Name = "ID_MerkTextBox"
        Me.ID_MerkTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_MerkTextBox.TabIndex = 5
        '
        'PD_NaamLabel
        '
        PD_NaamLabel.AutoSize = True
        PD_NaamLabel.Location = New System.Drawing.Point(40, 113)
        PD_NaamLabel.Name = "PD_NaamLabel"
        PD_NaamLabel.Size = New System.Drawing.Size(56, 13)
        PD_NaamLabel.TabIndex = 6
        PD_NaamLabel.Text = "PD Naam:"
        '
        'PD_NaamTextBox
        '
        Me.PD_NaamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Naam", True))
        Me.PD_NaamTextBox.Location = New System.Drawing.Point(102, 110)
        Me.PD_NaamTextBox.Name = "PD_NaamTextBox"
        Me.PD_NaamTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PD_NaamTextBox.TabIndex = 7
        '
        'PD_FunctieLabel
        '
        PD_FunctieLabel.AutoSize = True
        PD_FunctieLabel.Location = New System.Drawing.Point(33, 139)
        PD_FunctieLabel.Name = "PD_FunctieLabel"
        PD_FunctieLabel.Size = New System.Drawing.Size(63, 13)
        PD_FunctieLabel.TabIndex = 8
        PD_FunctieLabel.Text = "PD Functie:"
        '
        'PD_FunctieTextBox
        '
        Me.PD_FunctieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Functie", True))
        Me.PD_FunctieTextBox.Location = New System.Drawing.Point(102, 136)
        Me.PD_FunctieTextBox.Name = "PD_FunctieTextBox"
        Me.PD_FunctieTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PD_FunctieTextBox.TabIndex = 9
        '
        'PD_WaardeLabel
        '
        PD_WaardeLabel.AutoSize = True
        PD_WaardeLabel.Location = New System.Drawing.Point(30, 165)
        PD_WaardeLabel.Name = "PD_WaardeLabel"
        PD_WaardeLabel.Size = New System.Drawing.Size(66, 13)
        PD_WaardeLabel.TabIndex = 10
        PD_WaardeLabel.Text = "PD Waarde:"
        '
        'PD_WaardeTextBox
        '
        Me.PD_WaardeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Waarde", True))
        Me.PD_WaardeTextBox.Location = New System.Drawing.Point(102, 162)
        Me.PD_WaardeTextBox.Name = "PD_WaardeTextBox"
        Me.PD_WaardeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PD_WaardeTextBox.TabIndex = 11
        '
        'PD_BehuizingLabel
        '
        PD_BehuizingLabel.AutoSize = True
        PD_BehuizingLabel.Location = New System.Drawing.Point(22, 191)
        PD_BehuizingLabel.Name = "PD_BehuizingLabel"
        PD_BehuizingLabel.Size = New System.Drawing.Size(74, 13)
        PD_BehuizingLabel.TabIndex = 12
        PD_BehuizingLabel.Text = "PD Behuizing:"
        '
        'PD_BehuizingTextBox
        '
        Me.PD_BehuizingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Behuizing", True))
        Me.PD_BehuizingTextBox.Location = New System.Drawing.Point(102, 188)
        Me.PD_BehuizingTextBox.Name = "PD_BehuizingTextBox"
        Me.PD_BehuizingTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PD_BehuizingTextBox.TabIndex = 13
        '
        'txt_Beschrijving1
        '
        Me.txt_Beschrijving1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Beschrijving(1)", True))
        Me.txt_Beschrijving1.Location = New System.Drawing.Point(9, 19)
        Me.txt_Beschrijving1.Multiline = True
        Me.txt_Beschrijving1.Name = "txt_Beschrijving1"
        Me.txt_Beschrijving1.Size = New System.Drawing.Size(297, 68)
        Me.txt_Beschrijving1.TabIndex = 15
        '
        'TXT_Beschrijving2
        '
        Me.TXT_Beschrijving2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Beschrijving(2)", True))
        Me.TXT_Beschrijving2.Location = New System.Drawing.Point(6, 93)
        Me.TXT_Beschrijving2.Multiline = True
        Me.TXT_Beschrijving2.Name = "TXT_Beschrijving2"
        Me.TXT_Beschrijving2.Size = New System.Drawing.Size(300, 66)
        Me.TXT_Beschrijving2.TabIndex = 17
        '
        'PD_Sale_PrijsLabel
        '
        PD_Sale_PrijsLabel.AutoSize = True
        PD_Sale_PrijsLabel.Location = New System.Drawing.Point(58, 26)
        PD_Sale_PrijsLabel.Name = "PD_Sale_PrijsLabel"
        PD_Sale_PrijsLabel.Size = New System.Drawing.Size(71, 13)
        PD_Sale_PrijsLabel.TabIndex = 18
        PD_Sale_PrijsLabel.Text = "PD Sale Prijs:"
        '
        'PD_Sale_PrijsTextBox
        '
        Me.PD_Sale_PrijsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Sale_Prijs", True))
        Me.PD_Sale_PrijsTextBox.Location = New System.Drawing.Point(135, 26)
        Me.PD_Sale_PrijsTextBox.Name = "PD_Sale_PrijsTextBox"
        Me.PD_Sale_PrijsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PD_Sale_PrijsTextBox.TabIndex = 19
        '
        'PD_Buy_CostLabel
        '
        PD_Buy_CostLabel.AutoSize = True
        PD_Buy_CostLabel.Location = New System.Drawing.Point(59, 52)
        PD_Buy_CostLabel.Name = "PD_Buy_CostLabel"
        PD_Buy_CostLabel.Size = New System.Drawing.Size(70, 13)
        PD_Buy_CostLabel.TabIndex = 20
        PD_Buy_CostLabel.Text = "PD Buy Cost:"
        '
        'PD_Buy_CostTextBox
        '
        Me.PD_Buy_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Buy_Cost", True))
        Me.PD_Buy_CostTextBox.Location = New System.Drawing.Point(135, 52)
        Me.PD_Buy_CostTextBox.Name = "PD_Buy_CostTextBox"
        Me.PD_Buy_CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PD_Buy_CostTextBox.TabIndex = 21
        '
        'PD_VoorraadLabel
        '
        PD_VoorraadLabel.AutoSize = True
        PD_VoorraadLabel.Location = New System.Drawing.Point(58, 78)
        PD_VoorraadLabel.Name = "PD_VoorraadLabel"
        PD_VoorraadLabel.Size = New System.Drawing.Size(71, 13)
        PD_VoorraadLabel.TabIndex = 22
        PD_VoorraadLabel.Text = "PD Voorraad:"
        '
        'PD_VoorraadTextBox
        '
        Me.PD_VoorraadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_Voorraad", True))
        Me.PD_VoorraadTextBox.Location = New System.Drawing.Point(135, 78)
        Me.PD_VoorraadTextBox.Name = "PD_VoorraadTextBox"
        Me.PD_VoorraadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PD_VoorraadTextBox.TabIndex = 23
        '
        'PD_MinimumVoorraadLabel
        '
        PD_MinimumVoorraadLabel.AutoSize = True
        PD_MinimumVoorraadLabel.Location = New System.Drawing.Point(14, 104)
        PD_MinimumVoorraadLabel.Name = "PD_MinimumVoorraadLabel"
        PD_MinimumVoorraadLabel.Size = New System.Drawing.Size(115, 13)
        PD_MinimumVoorraadLabel.TabIndex = 24
        PD_MinimumVoorraadLabel.Text = "PD Minimum Voorraad:"
        '
        'PD_MinimumVoorraadTextBox
        '
        Me.PD_MinimumVoorraadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_productBindingSource, "PD_MinimumVoorraad", True))
        Me.PD_MinimumVoorraadTextBox.Location = New System.Drawing.Point(135, 104)
        Me.PD_MinimumVoorraadTextBox.Name = "PD_MinimumVoorraadTextBox"
        Me.PD_MinimumVoorraadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PD_MinimumVoorraadTextBox.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(PD_MinimumVoorraadLabel)
        Me.GroupBox2.Controls.Add(PD_Sale_PrijsLabel)
        Me.GroupBox2.Controls.Add(Me.PD_MinimumVoorraadTextBox)
        Me.GroupBox2.Controls.Add(Me.PD_Sale_PrijsTextBox)
        Me.GroupBox2.Controls.Add(PD_VoorraadLabel)
        Me.GroupBox2.Controls.Add(Me.PD_Buy_CostTextBox)
        Me.GroupBox2.Controls.Add(Me.PD_VoorraadTextBox)
        Me.GroupBox2.Controls.Add(PD_Buy_CostLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(387, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 187)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prijs, voorraad, lokatie"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(135, 131)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(100, 43)
        Me.ListBox1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Lokaties:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXT_Beschrijving2)
        Me.GroupBox3.Controls.Add(Me.txt_Beschrijving1)
        Me.GroupBox3.Location = New System.Drawing.Point(387, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 165)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Beschrijving"
        '
        'F_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 468)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.DT_productBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Knop_OpslaanSluiten)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_Product"
        Me.Text = "F_Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_productBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_productBindingNavigator.ResumeLayout(False)
        Me.DT_productBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Knop_OpslaanSluiten As Button
    Friend WithEvents Button1 As Button
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
    Friend WithEvents ID_ProductTextBox As TextBox
    Friend WithEvents PD_BehuizingTextBox As TextBox
    Friend WithEvents PD_WaardeTextBox As TextBox
    Friend WithEvents PD_FunctieTextBox As TextBox
    Friend WithEvents PD_NaamTextBox As TextBox
    Friend WithEvents ID_MerkTextBox As TextBox
    Friend WithEvents ID_GroepTextBox As TextBox
    Friend WithEvents txt_Beschrijving1 As TextBox
    Friend WithEvents TXT_Beschrijving2 As TextBox
    Friend WithEvents PD_Sale_PrijsTextBox As TextBox
    Friend WithEvents PD_Buy_CostTextBox As TextBox
    Friend WithEvents PD_VoorraadTextBox As TextBox
    Friend WithEvents PD_MinimumVoorraadTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox3 As GroupBox
End Class

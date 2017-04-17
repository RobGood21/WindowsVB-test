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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Shop))
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
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_opslaan = New System.Windows.Forms.Button()
        Me.Knop_Link = New System.Windows.Forms.Button()
        Me.Knop_Delete = New System.Windows.Forms.Button()
        Me.Knop_Save = New System.Windows.Forms.Button()
        Me.ID_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager()
        Me.LandTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.LandTableAdapter()
        Me.ShopTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.ShopTableAdapter()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.SupplierTableAdapter()
        Me.ShopBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ShopBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SH_RelationCodeTextBox = New System.Windows.Forms.TextBox()
        Me.TXT_SupplierNaam = New System.Windows.Forms.TextBox()
        Me.TXT_IDSupplier = New System.Windows.Forms.TextBox()
        Me.txt_IDSupplier_Shop = New System.Windows.Forms.TextBox()
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
        CType(Me.ShopBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShopBindingNavigator.SuspendLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SH_NaamLabel
        '
        SH_NaamLabel.AutoSize = True
        SH_NaamLabel.Location = New System.Drawing.Point(15, 20)
        SH_NaamLabel.Name = "SH_NaamLabel"
        SH_NaamLabel.Size = New System.Drawing.Size(38, 13)
        SH_NaamLabel.TabIndex = 0
        SH_NaamLabel.Text = "Naam:"
        '
        'SH_AdresLabel
        '
        SH_AdresLabel.AutoSize = True
        SH_AdresLabel.Location = New System.Drawing.Point(15, 42)
        SH_AdresLabel.Name = "SH_AdresLabel"
        SH_AdresLabel.Size = New System.Drawing.Size(37, 13)
        SH_AdresLabel.TabIndex = 2
        SH_AdresLabel.Text = "Adres:"
        '
        'SH_AdresXtraLabel
        '
        SH_AdresXtraLabel.AutoSize = True
        SH_AdresXtraLabel.Location = New System.Drawing.Point(15, 64)
        SH_AdresXtraLabel.Name = "SH_AdresXtraLabel"
        SH_AdresXtraLabel.Size = New System.Drawing.Size(59, 13)
        SH_AdresXtraLabel.TabIndex = 4
        SH_AdresXtraLabel.Text = "Adres Xtra:"
        '
        'SH_PostcodeLabel
        '
        SH_PostcodeLabel.AutoSize = True
        SH_PostcodeLabel.Location = New System.Drawing.Point(15, 85)
        SH_PostcodeLabel.Name = "SH_PostcodeLabel"
        SH_PostcodeLabel.Size = New System.Drawing.Size(55, 13)
        SH_PostcodeLabel.TabIndex = 6
        SH_PostcodeLabel.Text = "Postcode:"
        '
        'SH_PLaatsLabel
        '
        SH_PLaatsLabel.AutoSize = True
        SH_PLaatsLabel.Location = New System.Drawing.Point(15, 107)
        SH_PLaatsLabel.Name = "SH_PLaatsLabel"
        SH_PLaatsLabel.Size = New System.Drawing.Size(27, 13)
        SH_PLaatsLabel.TabIndex = 8
        SH_PLaatsLabel.Text = "City:"
        '
        'SH_ContactLabel
        '
        SH_ContactLabel.AutoSize = True
        SH_ContactLabel.Location = New System.Drawing.Point(15, 152)
        SH_ContactLabel.Name = "SH_ContactLabel"
        SH_ContactLabel.Size = New System.Drawing.Size(47, 13)
        SH_ContactLabel.TabIndex = 10
        SH_ContactLabel.Text = "Contact:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(15, 129)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 13
        Label1.Text = "Land:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(21, 85)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 13)
        Label2.TabIndex = 60
        Label2.Text = "Supplier, groep:"
        '
        'SH_EmailLabel
        '
        SH_EmailLabel.AutoSize = True
        SH_EmailLabel.Location = New System.Drawing.Point(15, 174)
        SH_EmailLabel.Name = "SH_EmailLabel"
        SH_EmailLabel.Size = New System.Drawing.Size(35, 13)
        SH_EmailLabel.TabIndex = 14
        SH_EmailLabel.Text = "Email:"
        '
        'SH_PhoneLabel
        '
        SH_PhoneLabel.AutoSize = True
        SH_PhoneLabel.Location = New System.Drawing.Point(15, 196)
        SH_PhoneLabel.Name = "SH_PhoneLabel"
        SH_PhoneLabel.Size = New System.Drawing.Size(52, 13)
        SH_PhoneLabel.TabIndex = 16
        SH_PhoneLabel.Text = "Telefoon:"
        '
        'SH_WebsiteLabel
        '
        SH_WebsiteLabel.AutoSize = True
        SH_WebsiteLabel.Location = New System.Drawing.Point(15, 218)
        SH_WebsiteLabel.Name = "SH_WebsiteLabel"
        SH_WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        SH_WebsiteLabel.TabIndex = 18
        SH_WebsiteLabel.Text = "Website:"
        '
        'SH_RelationCodeLabel
        '
        SH_RelationCodeLabel.AutoSize = True
        SH_RelationCodeLabel.Location = New System.Drawing.Point(21, 108)
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
        Me.GB_Shop.Location = New System.Drawing.Point(29, 136)
        Me.GB_Shop.Name = "GB_Shop"
        Me.GB_Shop.Size = New System.Drawing.Size(361, 255)
        Me.GB_Shop.TabIndex = 0
        Me.GB_Shop.TabStop = False
        '
        'TXT_Website
        '
        Me.TXT_Website.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Website", True))
        Me.TXT_Website.Location = New System.Drawing.Point(73, 215)
        Me.TXT_Website.Name = "TXT_Website"
        Me.TXT_Website.Size = New System.Drawing.Size(275, 20)
        Me.TXT_Website.TabIndex = 19
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
        Me.SH_PhoneTextBox.TabIndex = 17
        '
        'SH_EmailTextBox
        '
        Me.SH_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Email", True))
        Me.SH_EmailTextBox.Location = New System.Drawing.Point(73, 171)
        Me.SH_EmailTextBox.Name = "SH_EmailTextBox"
        Me.SH_EmailTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_EmailTextBox.TabIndex = 15
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
        Me.CB_Land.TabIndex = 12
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
        Me.SH_ContactTextBox.TabIndex = 11
        '
        'SH_PLaatsTextBox
        '
        Me.SH_PLaatsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_PLaats", True))
        Me.SH_PLaatsTextBox.Location = New System.Drawing.Point(73, 104)
        Me.SH_PLaatsTextBox.Name = "SH_PLaatsTextBox"
        Me.SH_PLaatsTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_PLaatsTextBox.TabIndex = 9
        '
        'SH_PostcodeTextBox
        '
        Me.SH_PostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_Postcode", True))
        Me.SH_PostcodeTextBox.Location = New System.Drawing.Point(73, 82)
        Me.SH_PostcodeTextBox.Name = "SH_PostcodeTextBox"
        Me.SH_PostcodeTextBox.Size = New System.Drawing.Size(275, 20)
        Me.SH_PostcodeTextBox.TabIndex = 7
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
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(65, 397)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Nieuw.TabIndex = 53
        Me.Knop_Nieuw.Text = "&Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(146, 397)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 52
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_opslaan
        '
        Me.Knop_opslaan.Location = New System.Drawing.Point(227, 397)
        Me.Knop_opslaan.Name = "Knop_opslaan"
        Me.Knop_opslaan.Size = New System.Drawing.Size(150, 23)
        Me.Knop_opslaan.TabIndex = 51
        Me.Knop_opslaan.Text = "&Opslaan en sluiten"
        Me.Knop_opslaan.UseVisualStyleBackColor = True
        '
        'Knop_Link
        '
        Me.Knop_Link.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Insert_hyperlink_icon
        Me.Knop_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Link.Location = New System.Drawing.Point(293, 46)
        Me.Knop_Link.Name = "Knop_Link"
        Me.Knop_Link.Size = New System.Drawing.Size(30, 30)
        Me.Knop_Link.TabIndex = 57
        Me.Knop_Link.UseVisualStyleBackColor = True
        '
        'Knop_Delete
        '
        Me.Knop_Delete.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Windows_Close_Program_icon
        Me.Knop_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Delete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Knop_Delete.Location = New System.Drawing.Point(327, 46)
        Me.Knop_Delete.Name = "Knop_Delete"
        Me.Knop_Delete.Size = New System.Drawing.Size(30, 30)
        Me.Knop_Delete.TabIndex = 56
        Me.Knop_Delete.UseVisualStyleBackColor = True
        '
        'Knop_Save
        '
        Me.Knop_Save.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Save_as_icon
        Me.Knop_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Knop_Save.Location = New System.Drawing.Point(360, 46)
        Me.Knop_Save.Name = "Knop_Save"
        Me.Knop_Save.Size = New System.Drawing.Size(30, 30)
        Me.Knop_Save.TabIndex = 55
        Me.Knop_Save.UseVisualStyleBackColor = True
        '
        'ID_SupplierTextBox
        '
        Me.ID_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "ID_Shop", True))
        Me.ID_SupplierTextBox.Enabled = False
        Me.ID_SupplierTextBox.Location = New System.Drawing.Point(250, 52)
        Me.ID_SupplierTextBox.Name = "ID_SupplierTextBox"
        Me.ID_SupplierTextBox.ReadOnly = True
        Me.ID_SupplierTextBox.Size = New System.Drawing.Size(37, 20)
        Me.ID_SupplierTextBox.TabIndex = 54
        Me.ID_SupplierTextBox.TabStop = False
        Me.ID_SupplierTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BetaalWijzenTableAdapter = Nothing
        Me.TableAdapterManager.GrootboekTableAdapter = Nothing
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
        'ShopBindingNavigator
        '
        Me.ShopBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ShopBindingNavigator.BindingSource = Me.ShopBindingSource
        Me.ShopBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ShopBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ShopBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ShopBindingNavigatorSaveItem})
        Me.ShopBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ShopBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ShopBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ShopBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ShopBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ShopBindingNavigator.Name = "ShopBindingNavigator"
        Me.ShopBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ShopBindingNavigator.Size = New System.Drawing.Size(502, 25)
        Me.ShopBindingNavigator.TabIndex = 58
        Me.ShopBindingNavigator.Text = "BindingNavigator1"
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
        'ShopBindingNavigatorSaveItem
        '
        Me.ShopBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShopBindingNavigatorSaveItem.Image = CType(resources.GetObject("ShopBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ShopBindingNavigatorSaveItem.Name = "ShopBindingNavigatorSaveItem"
        Me.ShopBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ShopBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Supplier
        '
        'SH_RelationCodeTextBox
        '
        Me.SH_RelationCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "SH_RelationCode", True))
        Me.SH_RelationCodeTextBox.Location = New System.Drawing.Point(102, 105)
        Me.SH_RelationCodeTextBox.Name = "SH_RelationCodeTextBox"
        Me.SH_RelationCodeTextBox.Size = New System.Drawing.Size(274, 20)
        Me.SH_RelationCodeTextBox.TabIndex = 61
        '
        'TXT_SupplierNaam
        '
        Me.TXT_SupplierNaam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Naam", True))
        Me.TXT_SupplierNaam.Enabled = False
        Me.TXT_SupplierNaam.Location = New System.Drawing.Point(102, 82)
        Me.TXT_SupplierNaam.Name = "TXT_SupplierNaam"
        Me.TXT_SupplierNaam.Size = New System.Drawing.Size(239, 20)
        Me.TXT_SupplierNaam.TabIndex = 62
        Me.TXT_SupplierNaam.TabStop = False
        '
        'TXT_IDSupplier
        '
        Me.TXT_IDSupplier.Location = New System.Drawing.Point(347, 82)
        Me.TXT_IDSupplier.Name = "TXT_IDSupplier"
        Me.TXT_IDSupplier.Size = New System.Drawing.Size(30, 20)
        Me.TXT_IDSupplier.TabIndex = 63
        '
        'txt_IDSupplier_Shop
        '
        Me.txt_IDSupplier_Shop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShopBindingSource, "ID_Supplier", True))
        Me.txt_IDSupplier_Shop.Enabled = False
        Me.txt_IDSupplier_Shop.Location = New System.Drawing.Point(12, 52)
        Me.txt_IDSupplier_Shop.Name = "txt_IDSupplier_Shop"
        Me.txt_IDSupplier_Shop.ReadOnly = True
        Me.txt_IDSupplier_Shop.Size = New System.Drawing.Size(37, 20)
        Me.txt_IDSupplier_Shop.TabIndex = 64
        Me.txt_IDSupplier_Shop.TabStop = False
        Me.txt_IDSupplier_Shop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'F_Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 494)
        Me.Controls.Add(Me.txt_IDSupplier_Shop)
        Me.Controls.Add(Me.TXT_IDSupplier)
        Me.Controls.Add(Me.TXT_SupplierNaam)
        Me.Controls.Add(SH_RelationCodeLabel)
        Me.Controls.Add(Me.SH_RelationCodeTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ShopBindingNavigator)
        Me.Controls.Add(Me.Knop_Link)
        Me.Controls.Add(Me.Knop_Delete)
        Me.Controls.Add(Me.Knop_Save)
        Me.Controls.Add(Me.ID_SupplierTextBox)
        Me.Controls.Add(Me.Knop_Nieuw)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_opslaan)
        Me.Controls.Add(Me.GB_Shop)
        Me.Name = "F_Shop"
        Me.Text = "Shop of filiaal"
        Me.GB_Shop.ResumeLayout(False)
        Me.GB_Shop.PerformLayout()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShopBindingNavigator.ResumeLayout(False)
        Me.ShopBindingNavigator.PerformLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Shop As GroupBox
    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Knop_opslaan As Button
    Friend WithEvents Knop_Link As Button
    Friend WithEvents Knop_Delete As Button
    Friend WithEvents Knop_Save As Button
    Friend WithEvents ID_SupplierTextBox As TextBox
    Friend WithEvents DS_Supplier As DS_Supplier
    Friend WithEvents ShopBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_SupplierTableAdapters.TableAdapterManager
    Friend WithEvents ShopBindingNavigator As BindingNavigator
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
    Friend WithEvents ShopBindingNavigatorSaveItem As ToolStripButton
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
End Class

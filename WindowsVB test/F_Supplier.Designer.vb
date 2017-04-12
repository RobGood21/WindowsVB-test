<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Supplier))
        Dim ID_SupplierLabel As System.Windows.Forms.Label
        Dim SP_NaamLabel As System.Windows.Forms.Label
        Dim SP_AdresLabel As System.Windows.Forms.Label
        Dim SP_AdresXtraLabel As System.Windows.Forms.Label
        Dim SP_PostcodeLabel As System.Windows.Forms.Label
        Dim SP_PlaatsLabel As System.Windows.Forms.Label
        Dim ID_LandLabel As System.Windows.Forms.Label
        Dim SP_DebiteurKenmerkLabel As System.Windows.Forms.Label
        Dim SP_PhoneLabel As System.Windows.Forms.Label
        Dim SP_EmailLabel As System.Windows.Forms.Label
        Dim SP_WebsiteLabel As System.Windows.Forms.Label
        Dim SP_VATnumberLabel As System.Windows.Forms.Label
        Dim SP_betaalwijzeLabel As System.Windows.Forms.Label
        Dim SP_TermijnLabel As System.Windows.Forms.Label
        Dim ID_ValutaLabel As System.Windows.Forms.Label
        Dim SP_BankLabel As System.Windows.Forms.Label
        Dim SP_ShiftLabel As System.Windows.Forms.Label
        Dim SP_IBANLabel As System.Windows.Forms.Label
        Dim ID_GrootboekLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.DS_Supplier = New WindowsVB_test.DS_Supplier()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager()
        Me.SupplierBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SupplierBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.SP_NaamTextBox = New System.Windows.Forms.TextBox()
        Me.SP_AdresTextBox = New System.Windows.Forms.TextBox()
        Me.SP_AdresXtraTextBox = New System.Windows.Forms.TextBox()
        Me.SP_PostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.SP_PlaatsTextBox = New System.Windows.Forms.TextBox()
        Me.ID_LandTextBox = New System.Windows.Forms.TextBox()
        Me.SP_DebiteurKenmerkTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SP_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.SP_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SP_WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.SP_VATnumberTextBox = New System.Windows.Forms.TextBox()
        Me.SP_betaalwijzeTextBox = New System.Windows.Forms.TextBox()
        Me.SP_TermijnTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ValutaTextBox = New System.Windows.Forms.TextBox()
        Me.SP_BankTextBox = New System.Windows.Forms.TextBox()
        Me.SP_ShiftTextBox = New System.Windows.Forms.TextBox()
        Me.SP_IBANTextBox = New System.Windows.Forms.TextBox()
        Me.ID_GrootboekTextBox = New System.Windows.Forms.TextBox()
        ID_SupplierLabel = New System.Windows.Forms.Label()
        SP_NaamLabel = New System.Windows.Forms.Label()
        SP_AdresLabel = New System.Windows.Forms.Label()
        SP_AdresXtraLabel = New System.Windows.Forms.Label()
        SP_PostcodeLabel = New System.Windows.Forms.Label()
        SP_PlaatsLabel = New System.Windows.Forms.Label()
        ID_LandLabel = New System.Windows.Forms.Label()
        SP_DebiteurKenmerkLabel = New System.Windows.Forms.Label()
        SP_PhoneLabel = New System.Windows.Forms.Label()
        SP_EmailLabel = New System.Windows.Forms.Label()
        SP_WebsiteLabel = New System.Windows.Forms.Label()
        SP_VATnumberLabel = New System.Windows.Forms.Label()
        SP_betaalwijzeLabel = New System.Windows.Forms.Label()
        SP_TermijnLabel = New System.Windows.Forms.Label()
        ID_ValutaLabel = New System.Windows.Forms.Label()
        SP_BankLabel = New System.Windows.Forms.Label()
        SP_ShiftLabel = New System.Windows.Forms.Label()
        SP_IBANLabel = New System.Windows.Forms.Label()
        ID_GrootboekLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DS_Supplier
        '
        Me.DS_Supplier.DataSetName = "DS_Supplier"
        Me.DS_Supplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Supplier
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GrootboekTableAdapter = Nothing
        Me.TableAdapterManager.LandTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'SupplierBindingNavigator
        '
        Me.SupplierBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SupplierBindingNavigator.BindingSource = Me.SupplierBindingSource
        Me.SupplierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SupplierBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SupplierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SupplierBindingNavigatorSaveItem})
        Me.SupplierBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SupplierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SupplierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SupplierBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SupplierBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SupplierBindingNavigator.Name = "SupplierBindingNavigator"
        Me.SupplierBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SupplierBindingNavigator.Size = New System.Drawing.Size(617, 25)
        Me.SupplierBindingNavigator.TabIndex = 0
        Me.SupplierBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SupplierBindingNavigatorSaveItem
        '
        Me.SupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SupplierBindingNavigatorSaveItem.Image = CType(resources.GetObject("SupplierBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SupplierBindingNavigatorSaveItem.Name = "SupplierBindingNavigatorSaveItem"
        Me.SupplierBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.SupplierBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_SupplierLabel
        '
        ID_SupplierLabel.AutoSize = True
        ID_SupplierLabel.Location = New System.Drawing.Point(440, 15)
        ID_SupplierLabel.Name = "ID_SupplierLabel"
        ID_SupplierLabel.Size = New System.Drawing.Size(62, 13)
        ID_SupplierLabel.TabIndex = 1
        ID_SupplierLabel.Text = "ID Supplier:"
        '
        'ID_SupplierTextBox
        '
        Me.ID_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_Supplier", True))
        Me.ID_SupplierTextBox.Location = New System.Drawing.Point(508, 12)
        Me.ID_SupplierTextBox.Name = "ID_SupplierTextBox"
        Me.ID_SupplierTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_SupplierTextBox.TabIndex = 2
        '
        'SP_NaamLabel
        '
        SP_NaamLabel.AutoSize = True
        SP_NaamLabel.Location = New System.Drawing.Point(7, 42)
        SP_NaamLabel.Name = "SP_NaamLabel"
        SP_NaamLabel.Size = New System.Drawing.Size(38, 13)
        SP_NaamLabel.TabIndex = 3
        SP_NaamLabel.Text = "Naam:"
        '
        'SP_NaamTextBox
        '
        Me.SP_NaamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Naam", True))
        Me.SP_NaamTextBox.Location = New System.Drawing.Point(80, 39)
        Me.SP_NaamTextBox.Name = "SP_NaamTextBox"
        Me.SP_NaamTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_NaamTextBox.TabIndex = 4
        '
        'SP_AdresLabel
        '
        SP_AdresLabel.AutoSize = True
        SP_AdresLabel.Location = New System.Drawing.Point(7, 65)
        SP_AdresLabel.Name = "SP_AdresLabel"
        SP_AdresLabel.Size = New System.Drawing.Size(37, 13)
        SP_AdresLabel.TabIndex = 5
        SP_AdresLabel.Text = "Adres:"
        '
        'SP_AdresTextBox
        '
        Me.SP_AdresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Adres", True))
        Me.SP_AdresTextBox.Location = New System.Drawing.Point(80, 62)
        Me.SP_AdresTextBox.Name = "SP_AdresTextBox"
        Me.SP_AdresTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_AdresTextBox.TabIndex = 6
        '
        'SP_AdresXtraLabel
        '
        SP_AdresXtraLabel.AutoSize = True
        SP_AdresXtraLabel.Location = New System.Drawing.Point(7, 88)
        SP_AdresXtraLabel.Name = "SP_AdresXtraLabel"
        SP_AdresXtraLabel.Size = New System.Drawing.Size(0, 13)
        SP_AdresXtraLabel.TabIndex = 7
        '
        'SP_AdresXtraTextBox
        '
        Me.SP_AdresXtraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_AdresXtra", True))
        Me.SP_AdresXtraTextBox.Location = New System.Drawing.Point(80, 85)
        Me.SP_AdresXtraTextBox.Name = "SP_AdresXtraTextBox"
        Me.SP_AdresXtraTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_AdresXtraTextBox.TabIndex = 8
        '
        'SP_PostcodeLabel
        '
        SP_PostcodeLabel.AutoSize = True
        SP_PostcodeLabel.Location = New System.Drawing.Point(7, 111)
        SP_PostcodeLabel.Name = "SP_PostcodeLabel"
        SP_PostcodeLabel.Size = New System.Drawing.Size(55, 13)
        SP_PostcodeLabel.TabIndex = 9
        SP_PostcodeLabel.Text = "Postcode:"
        '
        'SP_PostcodeTextBox
        '
        Me.SP_PostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Postcode", True))
        Me.SP_PostcodeTextBox.Location = New System.Drawing.Point(80, 108)
        Me.SP_PostcodeTextBox.Name = "SP_PostcodeTextBox"
        Me.SP_PostcodeTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_PostcodeTextBox.TabIndex = 10
        '
        'SP_PlaatsLabel
        '
        SP_PlaatsLabel.AutoSize = True
        SP_PlaatsLabel.Location = New System.Drawing.Point(7, 134)
        SP_PlaatsLabel.Name = "SP_PlaatsLabel"
        SP_PlaatsLabel.Size = New System.Drawing.Size(39, 13)
        SP_PlaatsLabel.TabIndex = 11
        SP_PlaatsLabel.Text = "Plaats:"
        '
        'SP_PlaatsTextBox
        '
        Me.SP_PlaatsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Plaats", True))
        Me.SP_PlaatsTextBox.Location = New System.Drawing.Point(80, 131)
        Me.SP_PlaatsTextBox.Name = "SP_PlaatsTextBox"
        Me.SP_PlaatsTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_PlaatsTextBox.TabIndex = 12
        '
        'ID_LandLabel
        '
        ID_LandLabel.AutoSize = True
        ID_LandLabel.Location = New System.Drawing.Point(141, 261)
        ID_LandLabel.Name = "ID_LandLabel"
        ID_LandLabel.Size = New System.Drawing.Size(48, 13)
        ID_LandLabel.TabIndex = 13
        ID_LandLabel.Text = "ID Land:"
        '
        'ID_LandTextBox
        '
        Me.ID_LandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_Land", True))
        Me.ID_LandTextBox.Location = New System.Drawing.Point(195, 258)
        Me.ID_LandTextBox.Name = "ID_LandTextBox"
        Me.ID_LandTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LandTextBox.TabIndex = 14
        '
        'SP_DebiteurKenmerkLabel
        '
        SP_DebiteurKenmerkLabel.AutoSize = True
        SP_DebiteurKenmerkLabel.Location = New System.Drawing.Point(298, 42)
        SP_DebiteurKenmerkLabel.Name = "SP_DebiteurKenmerkLabel"
        SP_DebiteurKenmerkLabel.Size = New System.Drawing.Size(112, 13)
        SP_DebiteurKenmerkLabel.TabIndex = 15
        SP_DebiteurKenmerkLabel.Text = "SP Debiteur Kenmerk:"
        '
        'SP_DebiteurKenmerkTextBox
        '
        Me.SP_DebiteurKenmerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_DebiteurKenmerk", True))
        Me.SP_DebiteurKenmerkTextBox.Location = New System.Drawing.Point(416, 39)
        Me.SP_DebiteurKenmerkTextBox.Name = "SP_DebiteurKenmerkTextBox"
        Me.SP_DebiteurKenmerkTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SP_DebiteurKenmerkTextBox.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_Land", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(80, 154)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'SP_PhoneLabel
        '
        SP_PhoneLabel.AutoSize = True
        SP_PhoneLabel.Location = New System.Drawing.Point(7, 181)
        SP_PhoneLabel.Name = "SP_PhoneLabel"
        SP_PhoneLabel.Size = New System.Drawing.Size(41, 13)
        SP_PhoneLabel.TabIndex = 18
        SP_PhoneLabel.Text = "Phone:"
        '
        'SP_PhoneTextBox
        '
        Me.SP_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Phone", True))
        Me.SP_PhoneTextBox.Location = New System.Drawing.Point(80, 178)
        Me.SP_PhoneTextBox.Name = "SP_PhoneTextBox"
        Me.SP_PhoneTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_PhoneTextBox.TabIndex = 19
        '
        'SP_EmailLabel
        '
        SP_EmailLabel.AutoSize = True
        SP_EmailLabel.Location = New System.Drawing.Point(7, 204)
        SP_EmailLabel.Name = "SP_EmailLabel"
        SP_EmailLabel.Size = New System.Drawing.Size(35, 13)
        SP_EmailLabel.TabIndex = 20
        SP_EmailLabel.Text = "Email:"
        '
        'SP_EmailTextBox
        '
        Me.SP_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Email", True))
        Me.SP_EmailTextBox.Location = New System.Drawing.Point(80, 201)
        Me.SP_EmailTextBox.Name = "SP_EmailTextBox"
        Me.SP_EmailTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_EmailTextBox.TabIndex = 21
        '
        'SP_WebsiteLabel
        '
        SP_WebsiteLabel.AutoSize = True
        SP_WebsiteLabel.Location = New System.Drawing.Point(7, 227)
        SP_WebsiteLabel.Name = "SP_WebsiteLabel"
        SP_WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        SP_WebsiteLabel.TabIndex = 22
        SP_WebsiteLabel.Text = "Website:"
        '
        'SP_WebsiteTextBox
        '
        Me.SP_WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Website", True))
        Me.SP_WebsiteTextBox.Location = New System.Drawing.Point(80, 223)
        Me.SP_WebsiteTextBox.Name = "SP_WebsiteTextBox"
        Me.SP_WebsiteTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_WebsiteTextBox.TabIndex = 23
        '
        'SP_VATnumberLabel
        '
        SP_VATnumberLabel.AutoSize = True
        SP_VATnumberLabel.Location = New System.Drawing.Point(327, 232)
        SP_VATnumberLabel.Name = "SP_VATnumberLabel"
        SP_VATnumberLabel.Size = New System.Drawing.Size(83, 13)
        SP_VATnumberLabel.TabIndex = 24
        SP_VATnumberLabel.Text = "SP VATnumber:"
        '
        'SP_VATnumberTextBox
        '
        Me.SP_VATnumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_VATnumber", True))
        Me.SP_VATnumberTextBox.Location = New System.Drawing.Point(416, 229)
        Me.SP_VATnumberTextBox.Name = "SP_VATnumberTextBox"
        Me.SP_VATnumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SP_VATnumberTextBox.TabIndex = 25
        '
        'SP_betaalwijzeLabel
        '
        SP_betaalwijzeLabel.AutoSize = True
        SP_betaalwijzeLabel.Location = New System.Drawing.Point(331, 79)
        SP_betaalwijzeLabel.Name = "SP_betaalwijzeLabel"
        SP_betaalwijzeLabel.Size = New System.Drawing.Size(79, 13)
        SP_betaalwijzeLabel.TabIndex = 26
        SP_betaalwijzeLabel.Text = "SP betaalwijze:"
        '
        'SP_betaalwijzeTextBox
        '
        Me.SP_betaalwijzeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_betaalwijze", True))
        Me.SP_betaalwijzeTextBox.Location = New System.Drawing.Point(416, 76)
        Me.SP_betaalwijzeTextBox.Name = "SP_betaalwijzeTextBox"
        Me.SP_betaalwijzeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SP_betaalwijzeTextBox.TabIndex = 27
        '
        'SP_TermijnLabel
        '
        SP_TermijnLabel.AutoSize = True
        SP_TermijnLabel.Location = New System.Drawing.Point(349, 102)
        SP_TermijnLabel.Name = "SP_TermijnLabel"
        SP_TermijnLabel.Size = New System.Drawing.Size(61, 13)
        SP_TermijnLabel.TabIndex = 28
        SP_TermijnLabel.Text = "SP Termijn:"
        '
        'SP_TermijnTextBox
        '
        Me.SP_TermijnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Termijn", True))
        Me.SP_TermijnTextBox.Location = New System.Drawing.Point(416, 99)
        Me.SP_TermijnTextBox.Name = "SP_TermijnTextBox"
        Me.SP_TermijnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SP_TermijnTextBox.TabIndex = 29
        '
        'ID_ValutaLabel
        '
        ID_ValutaLabel.AutoSize = True
        ID_ValutaLabel.Location = New System.Drawing.Point(356, 128)
        ID_ValutaLabel.Name = "ID_ValutaLabel"
        ID_ValutaLabel.Size = New System.Drawing.Size(54, 13)
        ID_ValutaLabel.TabIndex = 30
        ID_ValutaLabel.Text = "ID Valuta:"
        '
        'ID_ValutaTextBox
        '
        Me.ID_ValutaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_Valuta", True))
        Me.ID_ValutaTextBox.Location = New System.Drawing.Point(416, 125)
        Me.ID_ValutaTextBox.Name = "ID_ValutaTextBox"
        Me.ID_ValutaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_ValutaTextBox.TabIndex = 31
        '
        'SP_BankLabel
        '
        SP_BankLabel.AutoSize = True
        SP_BankLabel.Location = New System.Drawing.Point(358, 154)
        SP_BankLabel.Name = "SP_BankLabel"
        SP_BankLabel.Size = New System.Drawing.Size(52, 13)
        SP_BankLabel.TabIndex = 32
        SP_BankLabel.Text = "SP Bank:"
        '
        'SP_BankTextBox
        '
        Me.SP_BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Bank", True))
        Me.SP_BankTextBox.Location = New System.Drawing.Point(416, 151)
        Me.SP_BankTextBox.Name = "SP_BankTextBox"
        Me.SP_BankTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SP_BankTextBox.TabIndex = 33
        '
        'SP_ShiftLabel
        '
        SP_ShiftLabel.AutoSize = True
        SP_ShiftLabel.Location = New System.Drawing.Point(362, 180)
        SP_ShiftLabel.Name = "SP_ShiftLabel"
        SP_ShiftLabel.Size = New System.Drawing.Size(48, 13)
        SP_ShiftLabel.TabIndex = 34
        SP_ShiftLabel.Text = "SP Shift:"
        '
        'SP_ShiftTextBox
        '
        Me.SP_ShiftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Shift", True))
        Me.SP_ShiftTextBox.Location = New System.Drawing.Point(416, 177)
        Me.SP_ShiftTextBox.Name = "SP_ShiftTextBox"
        Me.SP_ShiftTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SP_ShiftTextBox.TabIndex = 35
        '
        'SP_IBANLabel
        '
        SP_IBANLabel.AutoSize = True
        SP_IBANLabel.Location = New System.Drawing.Point(358, 206)
        SP_IBANLabel.Name = "SP_IBANLabel"
        SP_IBANLabel.Size = New System.Drawing.Size(52, 13)
        SP_IBANLabel.TabIndex = 36
        SP_IBANLabel.Text = "SP IBAN:"
        '
        'SP_IBANTextBox
        '
        Me.SP_IBANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_IBAN", True))
        Me.SP_IBANTextBox.Location = New System.Drawing.Point(416, 203)
        Me.SP_IBANTextBox.Name = "SP_IBANTextBox"
        Me.SP_IBANTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SP_IBANTextBox.TabIndex = 37
        '
        'ID_GrootboekLabel
        '
        ID_GrootboekLabel.AutoSize = True
        ID_GrootboekLabel.Location = New System.Drawing.Point(336, 258)
        ID_GrootboekLabel.Name = "ID_GrootboekLabel"
        ID_GrootboekLabel.Size = New System.Drawing.Size(74, 13)
        ID_GrootboekLabel.TabIndex = 38
        ID_GrootboekLabel.Text = "ID Grootboek:"
        '
        'ID_GrootboekTextBox
        '
        Me.ID_GrootboekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_Grootboek", True))
        Me.ID_GrootboekTextBox.Location = New System.Drawing.Point(416, 255)
        Me.ID_GrootboekTextBox.Name = "ID_GrootboekTextBox"
        Me.ID_GrootboekTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_GrootboekTextBox.TabIndex = 39
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(7, 158)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 40
        Label1.Text = "Land:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(9, 88)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 13)
        Label2.TabIndex = 41
        Label2.Text = "Adres xtra:"
        '
        'F_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 423)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ID_GrootboekLabel)
        Me.Controls.Add(Me.ID_GrootboekTextBox)
        Me.Controls.Add(SP_IBANLabel)
        Me.Controls.Add(Me.SP_IBANTextBox)
        Me.Controls.Add(SP_ShiftLabel)
        Me.Controls.Add(Me.SP_ShiftTextBox)
        Me.Controls.Add(SP_BankLabel)
        Me.Controls.Add(Me.SP_BankTextBox)
        Me.Controls.Add(ID_ValutaLabel)
        Me.Controls.Add(Me.ID_ValutaTextBox)
        Me.Controls.Add(SP_TermijnLabel)
        Me.Controls.Add(Me.SP_TermijnTextBox)
        Me.Controls.Add(SP_betaalwijzeLabel)
        Me.Controls.Add(Me.SP_betaalwijzeTextBox)
        Me.Controls.Add(SP_VATnumberLabel)
        Me.Controls.Add(Me.SP_VATnumberTextBox)
        Me.Controls.Add(SP_WebsiteLabel)
        Me.Controls.Add(Me.SP_WebsiteTextBox)
        Me.Controls.Add(SP_EmailLabel)
        Me.Controls.Add(Me.SP_EmailTextBox)
        Me.Controls.Add(SP_PhoneLabel)
        Me.Controls.Add(Me.SP_PhoneTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(SP_DebiteurKenmerkLabel)
        Me.Controls.Add(Me.SP_DebiteurKenmerkTextBox)
        Me.Controls.Add(ID_LandLabel)
        Me.Controls.Add(Me.ID_LandTextBox)
        Me.Controls.Add(SP_PlaatsLabel)
        Me.Controls.Add(Me.SP_PlaatsTextBox)
        Me.Controls.Add(SP_PostcodeLabel)
        Me.Controls.Add(Me.SP_PostcodeTextBox)
        Me.Controls.Add(SP_AdresXtraLabel)
        Me.Controls.Add(Me.SP_AdresXtraTextBox)
        Me.Controls.Add(SP_AdresLabel)
        Me.Controls.Add(Me.SP_AdresTextBox)
        Me.Controls.Add(SP_NaamLabel)
        Me.Controls.Add(Me.SP_NaamTextBox)
        Me.Controls.Add(ID_SupplierLabel)
        Me.Controls.Add(Me.ID_SupplierTextBox)
        Me.Controls.Add(Me.SupplierBindingNavigator)
        Me.Name = "F_Supplier"
        Me.Text = "Leverancier, crediteur"
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierBindingNavigator.ResumeLayout(False)
        Me.SupplierBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_Supplier As DS_Supplier
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DS_SupplierTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As DS_SupplierTableAdapters.TableAdapterManager
    Friend WithEvents SupplierBindingNavigator As BindingNavigator
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
    Friend WithEvents SupplierBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_SupplierTextBox As TextBox
    Friend WithEvents SP_NaamTextBox As TextBox
    Friend WithEvents SP_AdresTextBox As TextBox
    Friend WithEvents SP_AdresXtraTextBox As TextBox
    Friend WithEvents SP_PostcodeTextBox As TextBox
    Friend WithEvents SP_PlaatsTextBox As TextBox
    Friend WithEvents ID_LandTextBox As TextBox
    Friend WithEvents SP_DebiteurKenmerkTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SP_PhoneTextBox As TextBox
    Friend WithEvents SP_EmailTextBox As TextBox
    Friend WithEvents SP_WebsiteTextBox As TextBox
    Friend WithEvents SP_VATnumberTextBox As TextBox
    Friend WithEvents SP_betaalwijzeTextBox As TextBox
    Friend WithEvents SP_TermijnTextBox As TextBox
    Friend WithEvents ID_ValutaTextBox As TextBox
    Friend WithEvents SP_BankTextBox As TextBox
    Friend WithEvents SP_ShiftTextBox As TextBox
    Friend WithEvents SP_IBANTextBox As TextBox
    Friend WithEvents ID_GrootboekTextBox As TextBox
End Class

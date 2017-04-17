<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Supplier
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
        Dim SP_AdresXtraLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ID_GrootboekLabel As System.Windows.Forms.Label
        Dim SP_IBANLabel As System.Windows.Forms.Label
        Dim SP_ShiftLabel As System.Windows.Forms.Label
        Dim SP_BankLabel As System.Windows.Forms.Label
        Dim ID_ValutaLabel As System.Windows.Forms.Label
        Dim SP_TermijnLabel As System.Windows.Forms.Label
        Dim SP_betaalwijzeLabel As System.Windows.Forms.Label
        Dim SP_VATnumberLabel As System.Windows.Forms.Label
        Dim SP_WebsiteLabel As System.Windows.Forms.Label
        Dim SP_EmailLabel As System.Windows.Forms.Label
        Dim SP_PhoneLabel As System.Windows.Forms.Label
        Dim SP_DebiteurKenmerkLabel As System.Windows.Forms.Label
        Dim SP_PlaatsLabel As System.Windows.Forms.Label
        Dim SP_PostcodeLabel As System.Windows.Forms.Label
        Dim SP_AdresLabel As System.Windows.Forms.Label
        Dim SP_NaamLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.DS_Supplier = New WindowsVB_test.DS_Supplier()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager()
        Me.LandTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.LandTableAdapter()
        Me.ID_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.GB_Supplier = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CB_Grootboek = New System.Windows.Forms.ComboBox()
        Me.CB_Valuta = New System.Windows.Forms.ComboBox()
        Me.CB_BetaalWijzen = New System.Windows.Forms.ComboBox()
        Me.BetaalWijzenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXT_Kenmerk = New System.Windows.Forms.TextBox()
        Me.Ch_Winkel = New System.Windows.Forms.CheckBox()
        Me.Ch_Webwinkel = New System.Windows.Forms.CheckBox()
        Me.CB_Land = New System.Windows.Forms.ComboBox()
        Me.LandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_IBANTextBox = New System.Windows.Forms.TextBox()
        Me.SP_ShiftTextBox = New System.Windows.Forms.TextBox()
        Me.SP_BankTextBox = New System.Windows.Forms.TextBox()
        Me.SP_TermijnTextBox = New System.Windows.Forms.TextBox()
        Me.SP_VATnumberTextBox = New System.Windows.Forms.TextBox()
        Me.TXT_Website = New System.Windows.Forms.TextBox()
        Me.SP_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SP_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.SP_DebiteurKenmerkTextBox = New System.Windows.Forms.TextBox()
        Me.SP_PlaatsTextBox = New System.Windows.Forms.TextBox()
        Me.SP_PostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.SP_AdresXtraTextBox = New System.Windows.Forms.TextBox()
        Me.TXT_adres = New System.Windows.Forms.TextBox()
        Me.Knop_opslaan = New System.Windows.Forms.Button()
        Me.BetaalWijzenTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.BetaalWijzenTableAdapter()
        Me.ValutaTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.ValutaTableAdapter()
        Me.GrootboekTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.GrootboekTableAdapter()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_Delete = New System.Windows.Forms.Button()
        Me.Knop_Save = New System.Windows.Forms.Button()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.Knop_Link = New System.Windows.Forms.Button()
        Me.CB_NaamSupplier = New System.Windows.Forms.ComboBox()
        Me.DSSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrootboekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        SP_AdresXtraLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ID_GrootboekLabel = New System.Windows.Forms.Label()
        SP_IBANLabel = New System.Windows.Forms.Label()
        SP_ShiftLabel = New System.Windows.Forms.Label()
        SP_BankLabel = New System.Windows.Forms.Label()
        ID_ValutaLabel = New System.Windows.Forms.Label()
        SP_TermijnLabel = New System.Windows.Forms.Label()
        SP_betaalwijzeLabel = New System.Windows.Forms.Label()
        SP_VATnumberLabel = New System.Windows.Forms.Label()
        SP_WebsiteLabel = New System.Windows.Forms.Label()
        SP_EmailLabel = New System.Windows.Forms.Label()
        SP_PhoneLabel = New System.Windows.Forms.Label()
        SP_DebiteurKenmerkLabel = New System.Windows.Forms.Label()
        SP_PlaatsLabel = New System.Windows.Forms.Label()
        SP_PostcodeLabel = New System.Windows.Forms.Label()
        SP_AdresLabel = New System.Windows.Forms.Label()
        SP_NaamLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Supplier.SuspendLayout()
        CType(Me.BetaalWijzenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrootboekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_AdresXtraLabel
        '
        SP_AdresXtraLabel.AutoSize = True
        SP_AdresXtraLabel.Location = New System.Drawing.Point(7, 88)
        SP_AdresXtraLabel.Name = "SP_AdresXtraLabel"
        SP_AdresXtraLabel.Size = New System.Drawing.Size(0, 13)
        SP_AdresXtraLabel.TabIndex = 7
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(14, 65)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 13)
        Label2.TabIndex = 77
        Label2.Text = "Adres xtra:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(14, 132)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 76
        Label1.Text = "Land:"
        '
        'ID_GrootboekLabel
        '
        ID_GrootboekLabel.AutoSize = True
        ID_GrootboekLabel.Location = New System.Drawing.Point(298, 198)
        ID_GrootboekLabel.Name = "ID_GrootboekLabel"
        ID_GrootboekLabel.Size = New System.Drawing.Size(60, 13)
        ID_GrootboekLabel.TabIndex = 74
        ID_GrootboekLabel.Text = "Grootboek:"
        '
        'SP_IBANLabel
        '
        SP_IBANLabel.AutoSize = True
        SP_IBANLabel.Location = New System.Drawing.Point(298, 156)
        SP_IBANLabel.Name = "SP_IBANLabel"
        SP_IBANLabel.Size = New System.Drawing.Size(35, 13)
        SP_IBANLabel.TabIndex = 72
        SP_IBANLabel.Text = "IBAN:"
        '
        'SP_ShiftLabel
        '
        SP_ShiftLabel.AutoSize = True
        SP_ShiftLabel.Location = New System.Drawing.Point(298, 133)
        SP_ShiftLabel.Name = "SP_ShiftLabel"
        SP_ShiftLabel.Size = New System.Drawing.Size(54, 13)
        SP_ShiftLabel.TabIndex = 70
        SP_ShiftLabel.Text = "BIC, Shift:"
        '
        'SP_BankLabel
        '
        SP_BankLabel.AutoSize = True
        SP_BankLabel.Location = New System.Drawing.Point(298, 110)
        SP_BankLabel.Name = "SP_BankLabel"
        SP_BankLabel.Size = New System.Drawing.Size(35, 13)
        SP_BankLabel.TabIndex = 68
        SP_BankLabel.Text = "Bank:"
        '
        'ID_ValutaLabel
        '
        ID_ValutaLabel.AutoSize = True
        ID_ValutaLabel.Location = New System.Drawing.Point(298, 87)
        ID_ValutaLabel.Name = "ID_ValutaLabel"
        ID_ValutaLabel.Size = New System.Drawing.Size(40, 13)
        ID_ValutaLabel.TabIndex = 66
        ID_ValutaLabel.Text = "Valuta:"
        '
        'SP_TermijnLabel
        '
        SP_TermijnLabel.AutoSize = True
        SP_TermijnLabel.Location = New System.Drawing.Point(298, 65)
        SP_TermijnLabel.Name = "SP_TermijnLabel"
        SP_TermijnLabel.Size = New System.Drawing.Size(73, 13)
        SP_TermijnLabel.TabIndex = 64
        SP_TermijnLabel.Text = "Verval termijn:"
        '
        'SP_betaalwijzeLabel
        '
        SP_betaalwijzeLabel.AutoSize = True
        SP_betaalwijzeLabel.Location = New System.Drawing.Point(298, 42)
        SP_betaalwijzeLabel.Name = "SP_betaalwijzeLabel"
        SP_betaalwijzeLabel.Size = New System.Drawing.Size(63, 13)
        SP_betaalwijzeLabel.TabIndex = 62
        SP_betaalwijzeLabel.Text = "Betaalwijze:"
        '
        'SP_VATnumberLabel
        '
        SP_VATnumberLabel.AutoSize = True
        SP_VATnumberLabel.Location = New System.Drawing.Point(298, 176)
        SP_VATnumberLabel.Name = "SP_VATnumberLabel"
        SP_VATnumberLabel.Size = New System.Drawing.Size(66, 13)
        SP_VATnumberLabel.TabIndex = 60
        SP_VATnumberLabel.Text = "VATnumber:"
        '
        'SP_WebsiteLabel
        '
        SP_WebsiteLabel.AutoSize = True
        SP_WebsiteLabel.Location = New System.Drawing.Point(14, 199)
        SP_WebsiteLabel.Name = "SP_WebsiteLabel"
        SP_WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        SP_WebsiteLabel.TabIndex = 58
        SP_WebsiteLabel.Text = "Website:"
        '
        'SP_EmailLabel
        '
        SP_EmailLabel.AutoSize = True
        SP_EmailLabel.Location = New System.Drawing.Point(14, 176)
        SP_EmailLabel.Name = "SP_EmailLabel"
        SP_EmailLabel.Size = New System.Drawing.Size(35, 13)
        SP_EmailLabel.TabIndex = 56
        SP_EmailLabel.Text = "Email:"
        '
        'SP_PhoneLabel
        '
        SP_PhoneLabel.AutoSize = True
        SP_PhoneLabel.Location = New System.Drawing.Point(14, 154)
        SP_PhoneLabel.Name = "SP_PhoneLabel"
        SP_PhoneLabel.Size = New System.Drawing.Size(41, 13)
        SP_PhoneLabel.TabIndex = 54
        SP_PhoneLabel.Text = "Phone:"
        '
        'SP_DebiteurKenmerkLabel
        '
        SP_DebiteurKenmerkLabel.AutoSize = True
        SP_DebiteurKenmerkLabel.Location = New System.Drawing.Point(298, 21)
        SP_DebiteurKenmerkLabel.Name = "SP_DebiteurKenmerkLabel"
        SP_DebiteurKenmerkLabel.Size = New System.Drawing.Size(43, 13)
        SP_DebiteurKenmerkLabel.TabIndex = 51
        SP_DebiteurKenmerkLabel.Text = "Relatie:"
        '
        'SP_PlaatsLabel
        '
        SP_PlaatsLabel.AutoSize = True
        SP_PlaatsLabel.Location = New System.Drawing.Point(14, 109)
        SP_PlaatsLabel.Name = "SP_PlaatsLabel"
        SP_PlaatsLabel.Size = New System.Drawing.Size(39, 13)
        SP_PlaatsLabel.TabIndex = 49
        SP_PlaatsLabel.Text = "Plaats:"
        '
        'SP_PostcodeLabel
        '
        SP_PostcodeLabel.AutoSize = True
        SP_PostcodeLabel.Location = New System.Drawing.Point(14, 87)
        SP_PostcodeLabel.Name = "SP_PostcodeLabel"
        SP_PostcodeLabel.Size = New System.Drawing.Size(55, 13)
        SP_PostcodeLabel.TabIndex = 47
        SP_PostcodeLabel.Text = "Postcode:"
        '
        'SP_AdresLabel
        '
        SP_AdresLabel.AutoSize = True
        SP_AdresLabel.Location = New System.Drawing.Point(14, 43)
        SP_AdresLabel.Name = "SP_AdresLabel"
        SP_AdresLabel.Size = New System.Drawing.Size(37, 13)
        SP_AdresLabel.TabIndex = 44
        SP_AdresLabel.Text = "Adres:"
        '
        'SP_NaamLabel
        '
        SP_NaamLabel.AutoSize = True
        SP_NaamLabel.Location = New System.Drawing.Point(14, 21)
        SP_NaamLabel.Name = "SP_NaamLabel"
        SP_NaamLabel.Size = New System.Drawing.Size(38, 13)
        SP_NaamLabel.TabIndex = 42
        SP_NaamLabel.Text = "Naam:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(14, 223)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(64, 13)
        Label3.TabIndex = 83
        Label3.Text = "Kenmerken:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(412, 67)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(40, 13)
        Label4.TabIndex = 85
        Label4.Text = "dagen."
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
        Me.TableAdapterManager.BetaalWijzenTableAdapter = Nothing
        Me.TableAdapterManager.GrootboekTableAdapter = Me.GrootboekTableAdapter
        Me.TableAdapterManager.LandTableAdapter = Me.LandTableAdapter
        Me.TableAdapterManager.ShopTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Me.ValutaTableAdapter
        '
        'LandTableAdapter
        '
        Me.LandTableAdapter.ClearBeforeFill = True
        '
        'ID_SupplierTextBox
        '
        Me.ID_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_Supplier", True))
        Me.ID_SupplierTextBox.Enabled = False
        Me.ID_SupplierTextBox.Location = New System.Drawing.Point(466, 12)
        Me.ID_SupplierTextBox.Name = "ID_SupplierTextBox"
        Me.ID_SupplierTextBox.ReadOnly = True
        Me.ID_SupplierTextBox.Size = New System.Drawing.Size(37, 20)
        Me.ID_SupplierTextBox.TabIndex = 2
        Me.ID_SupplierTextBox.TabStop = False
        Me.ID_SupplierTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GB_Supplier
        '
        Me.GB_Supplier.Controls.Add(Me.TextBox1)
        Me.GB_Supplier.Controls.Add(Me.CB_Grootboek)
        Me.GB_Supplier.Controls.Add(Me.CB_Valuta)
        Me.GB_Supplier.Controls.Add(Label4)
        Me.GB_Supplier.Controls.Add(Me.CB_BetaalWijzen)
        Me.GB_Supplier.Controls.Add(Label3)
        Me.GB_Supplier.Controls.Add(Me.TXT_Kenmerk)
        Me.GB_Supplier.Controls.Add(Me.Ch_Winkel)
        Me.GB_Supplier.Controls.Add(Me.Ch_Webwinkel)
        Me.GB_Supplier.Controls.Add(Me.CB_NaamSupplier)
        Me.GB_Supplier.Controls.Add(Me.CB_Land)
        Me.GB_Supplier.Controls.Add(Label2)
        Me.GB_Supplier.Controls.Add(Label1)
        Me.GB_Supplier.Controls.Add(ID_GrootboekLabel)
        Me.GB_Supplier.Controls.Add(SP_IBANLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_IBANTextBox)
        Me.GB_Supplier.Controls.Add(SP_ShiftLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_ShiftTextBox)
        Me.GB_Supplier.Controls.Add(SP_BankLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_BankTextBox)
        Me.GB_Supplier.Controls.Add(ID_ValutaLabel)
        Me.GB_Supplier.Controls.Add(SP_TermijnLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_TermijnTextBox)
        Me.GB_Supplier.Controls.Add(SP_betaalwijzeLabel)
        Me.GB_Supplier.Controls.Add(SP_VATnumberLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_VATnumberTextBox)
        Me.GB_Supplier.Controls.Add(SP_WebsiteLabel)
        Me.GB_Supplier.Controls.Add(Me.TXT_Website)
        Me.GB_Supplier.Controls.Add(SP_EmailLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_EmailTextBox)
        Me.GB_Supplier.Controls.Add(SP_PhoneLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_PhoneTextBox)
        Me.GB_Supplier.Controls.Add(SP_DebiteurKenmerkLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_DebiteurKenmerkTextBox)
        Me.GB_Supplier.Controls.Add(SP_PlaatsLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_PlaatsTextBox)
        Me.GB_Supplier.Controls.Add(SP_PostcodeLabel)
        Me.GB_Supplier.Controls.Add(Me.SP_PostcodeTextBox)
        Me.GB_Supplier.Controls.Add(Me.SP_AdresXtraTextBox)
        Me.GB_Supplier.Controls.Add(SP_AdresLabel)
        Me.GB_Supplier.Controls.Add(Me.TXT_adres)
        Me.GB_Supplier.Controls.Add(SP_NaamLabel)
        Me.GB_Supplier.Location = New System.Drawing.Point(22, 38)
        Me.GB_Supplier.Name = "GB_Supplier"
        Me.GB_Supplier.Size = New System.Drawing.Size(586, 327)
        Me.GB_Supplier.TabIndex = 42
        Me.GB_Supplier.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Naam", True))
        Me.TextBox1.Location = New System.Drawing.Point(83, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 20)
        Me.TextBox1.TabIndex = 87
        '
        'CB_Grootboek
        '
        Me.CB_Grootboek.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SupplierBindingSource, "ID_Grootboek", True))
        Me.CB_Grootboek.DataSource = Me.GrootboekBindingSource
        Me.CB_Grootboek.DisplayMember = "GB_naam"
        Me.CB_Grootboek.FormattingEnabled = True
        Me.CB_Grootboek.Location = New System.Drawing.Point(374, 195)
        Me.CB_Grootboek.Name = "CB_Grootboek"
        Me.CB_Grootboek.Size = New System.Drawing.Size(141, 21)
        Me.CB_Grootboek.TabIndex = 86
        Me.CB_Grootboek.ValueMember = "ID_GrootBoek"
        '
        'CB_Valuta
        '
        Me.CB_Valuta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SupplierBindingSource, "ID_Valuta", True))
        Me.CB_Valuta.DataSource = Me.ValutaBindingSource
        Me.CB_Valuta.DisplayMember = "VT_Short"
        Me.CB_Valuta.FormattingEnabled = True
        Me.CB_Valuta.Location = New System.Drawing.Point(374, 84)
        Me.CB_Valuta.Name = "CB_Valuta"
        Me.CB_Valuta.Size = New System.Drawing.Size(141, 21)
        Me.CB_Valuta.TabIndex = 47
        Me.CB_Valuta.ValueMember = "ID_valuta"
        '
        'CB_BetaalWijzen
        '
        Me.CB_BetaalWijzen.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SupplierBindingSource, "ID_BetaalWijzen", True))
        Me.CB_BetaalWijzen.DataSource = Me.BetaalWijzenBindingSource
        Me.CB_BetaalWijzen.DisplayMember = "BW_Kort"
        Me.CB_BetaalWijzen.FormattingEnabled = True
        Me.CB_BetaalWijzen.Location = New System.Drawing.Point(374, 39)
        Me.CB_BetaalWijzen.Name = "CB_BetaalWijzen"
        Me.CB_BetaalWijzen.Size = New System.Drawing.Size(141, 21)
        Me.CB_BetaalWijzen.TabIndex = 84
        Me.CB_BetaalWijzen.ValueMember = "ID_BetaalWijzen"
        '
        'BetaalWijzenBindingSource
        '
        Me.BetaalWijzenBindingSource.DataMember = "BetaalWijzen"
        Me.BetaalWijzenBindingSource.DataSource = Me.DS_Supplier
        '
        'TXT_Kenmerk
        '
        Me.TXT_Kenmerk.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Kenmerken", True))
        Me.TXT_Kenmerk.Location = New System.Drawing.Point(17, 242)
        Me.TXT_Kenmerk.Multiline = True
        Me.TXT_Kenmerk.Name = "TXT_Kenmerk"
        Me.TXT_Kenmerk.Size = New System.Drawing.Size(253, 68)
        Me.TXT_Kenmerk.TabIndex = 12
        '
        'Ch_Winkel
        '
        Me.Ch_Winkel.AutoSize = True
        Me.Ch_Winkel.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SupplierBindingSource, "SP_IsWinkel", True))
        Me.Ch_Winkel.Location = New System.Drawing.Point(189, 222)
        Me.Ch_Winkel.Name = "Ch_Winkel"
        Me.Ch_Winkel.Size = New System.Drawing.Size(59, 17)
        Me.Ch_Winkel.TabIndex = 11
        Me.Ch_Winkel.Text = "Winkel"
        Me.Ch_Winkel.UseVisualStyleBackColor = True
        '
        'Ch_Webwinkel
        '
        Me.Ch_Webwinkel.AutoSize = True
        Me.Ch_Webwinkel.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SupplierBindingSource, "SP_IsWebshop", True))
        Me.Ch_Webwinkel.Location = New System.Drawing.Point(83, 222)
        Me.Ch_Webwinkel.Name = "Ch_Webwinkel"
        Me.Ch_Webwinkel.Size = New System.Drawing.Size(79, 17)
        Me.Ch_Webwinkel.TabIndex = 10
        Me.Ch_Webwinkel.Text = "Webwinkel"
        Me.Ch_Webwinkel.UseVisualStyleBackColor = True
        '
        'CB_Land
        '
        Me.CB_Land.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SupplierBindingSource, "ID_Land", True))
        Me.CB_Land.DataSource = Me.LandBindingSource
        Me.CB_Land.DisplayMember = "LD_Naam"
        Me.CB_Land.FormattingEnabled = True
        Me.CB_Land.Location = New System.Drawing.Point(83, 128)
        Me.CB_Land.Name = "CB_Land"
        Me.CB_Land.Size = New System.Drawing.Size(187, 21)
        Me.CB_Land.TabIndex = 6
        Me.CB_Land.ValueMember = "ID_Land"
        '
        'LandBindingSource
        '
        Me.LandBindingSource.DataMember = "Land"
        Me.LandBindingSource.DataSource = Me.DS_Supplier
        '
        'SP_IBANTextBox
        '
        Me.SP_IBANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_IBAN", True))
        Me.SP_IBANTextBox.Location = New System.Drawing.Point(374, 151)
        Me.SP_IBANTextBox.Name = "SP_IBANTextBox"
        Me.SP_IBANTextBox.Size = New System.Drawing.Size(141, 20)
        Me.SP_IBANTextBox.TabIndex = 73
        '
        'SP_ShiftTextBox
        '
        Me.SP_ShiftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Shift", True))
        Me.SP_ShiftTextBox.Location = New System.Drawing.Point(374, 129)
        Me.SP_ShiftTextBox.Name = "SP_ShiftTextBox"
        Me.SP_ShiftTextBox.Size = New System.Drawing.Size(141, 20)
        Me.SP_ShiftTextBox.TabIndex = 71
        '
        'SP_BankTextBox
        '
        Me.SP_BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Bank", True))
        Me.SP_BankTextBox.Location = New System.Drawing.Point(374, 107)
        Me.SP_BankTextBox.Name = "SP_BankTextBox"
        Me.SP_BankTextBox.Size = New System.Drawing.Size(141, 20)
        Me.SP_BankTextBox.TabIndex = 69
        '
        'SP_TermijnTextBox
        '
        Me.SP_TermijnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Termijn", True))
        Me.SP_TermijnTextBox.Location = New System.Drawing.Point(374, 62)
        Me.SP_TermijnTextBox.Name = "SP_TermijnTextBox"
        Me.SP_TermijnTextBox.Size = New System.Drawing.Size(34, 20)
        Me.SP_TermijnTextBox.TabIndex = 65
        '
        'SP_VATnumberTextBox
        '
        Me.SP_VATnumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_VATnumber", True))
        Me.SP_VATnumberTextBox.Location = New System.Drawing.Point(374, 173)
        Me.SP_VATnumberTextBox.Name = "SP_VATnumberTextBox"
        Me.SP_VATnumberTextBox.Size = New System.Drawing.Size(141, 20)
        Me.SP_VATnumberTextBox.TabIndex = 61
        '
        'TXT_Website
        '
        Me.TXT_Website.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Website", True))
        Me.TXT_Website.Location = New System.Drawing.Point(83, 195)
        Me.TXT_Website.Name = "TXT_Website"
        Me.TXT_Website.Size = New System.Drawing.Size(187, 20)
        Me.TXT_Website.TabIndex = 9
        '
        'SP_EmailTextBox
        '
        Me.SP_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Email", True))
        Me.SP_EmailTextBox.Location = New System.Drawing.Point(83, 173)
        Me.SP_EmailTextBox.Name = "SP_EmailTextBox"
        Me.SP_EmailTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_EmailTextBox.TabIndex = 8
        '
        'SP_PhoneTextBox
        '
        Me.SP_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Phone", True))
        Me.SP_PhoneTextBox.Location = New System.Drawing.Point(83, 151)
        Me.SP_PhoneTextBox.Name = "SP_PhoneTextBox"
        Me.SP_PhoneTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_PhoneTextBox.TabIndex = 7
        '
        'SP_DebiteurKenmerkTextBox
        '
        Me.SP_DebiteurKenmerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_DebiteurKenmerk", True))
        Me.SP_DebiteurKenmerkTextBox.Location = New System.Drawing.Point(374, 17)
        Me.SP_DebiteurKenmerkTextBox.Name = "SP_DebiteurKenmerkTextBox"
        Me.SP_DebiteurKenmerkTextBox.Size = New System.Drawing.Size(141, 20)
        Me.SP_DebiteurKenmerkTextBox.TabIndex = 13
        '
        'SP_PlaatsTextBox
        '
        Me.SP_PlaatsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Plaats", True))
        Me.SP_PlaatsTextBox.Location = New System.Drawing.Point(83, 106)
        Me.SP_PlaatsTextBox.Name = "SP_PlaatsTextBox"
        Me.SP_PlaatsTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_PlaatsTextBox.TabIndex = 5
        '
        'SP_PostcodeTextBox
        '
        Me.SP_PostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Postcode", True))
        Me.SP_PostcodeTextBox.Location = New System.Drawing.Point(83, 84)
        Me.SP_PostcodeTextBox.Name = "SP_PostcodeTextBox"
        Me.SP_PostcodeTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_PostcodeTextBox.TabIndex = 4
        '
        'SP_AdresXtraTextBox
        '
        Me.SP_AdresXtraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_AdresXtra", True))
        Me.SP_AdresXtraTextBox.Location = New System.Drawing.Point(83, 62)
        Me.SP_AdresXtraTextBox.Name = "SP_AdresXtraTextBox"
        Me.SP_AdresXtraTextBox.Size = New System.Drawing.Size(187, 20)
        Me.SP_AdresXtraTextBox.TabIndex = 3
        '
        'TXT_adres
        '
        Me.TXT_adres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "SP_Adres", True))
        Me.TXT_adres.Location = New System.Drawing.Point(83, 40)
        Me.TXT_adres.Name = "TXT_adres"
        Me.TXT_adres.Size = New System.Drawing.Size(187, 20)
        Me.TXT_adres.TabIndex = 2
        '
        'Knop_opslaan
        '
        Me.Knop_opslaan.Location = New System.Drawing.Point(458, 371)
        Me.Knop_opslaan.Name = "Knop_opslaan"
        Me.Knop_opslaan.Size = New System.Drawing.Size(150, 23)
        Me.Knop_opslaan.TabIndex = 46
        Me.Knop_opslaan.Text = "&Opslaan en sluiten"
        Me.Knop_opslaan.UseVisualStyleBackColor = True
        '
        'BetaalWijzenTableAdapter
        '
        Me.BetaalWijzenTableAdapter.ClearBeforeFill = True
        '
        'ValutaTableAdapter
        '
        Me.ValutaTableAdapter.ClearBeforeFill = True
        '
        'GrootboekTableAdapter
        '
        Me.GrootboekTableAdapter.ClearBeforeFill = True
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(377, 371)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 47
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_Delete
        '
        Me.Knop_Delete.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Windows_Close_Program_icon
        Me.Knop_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Delete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Knop_Delete.Location = New System.Drawing.Point(543, 6)
        Me.Knop_Delete.Name = "Knop_Delete"
        Me.Knop_Delete.Size = New System.Drawing.Size(30, 30)
        Me.Knop_Delete.TabIndex = 49
        Me.Knop_Delete.UseVisualStyleBackColor = True
        '
        'Knop_Save
        '
        Me.Knop_Save.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Save_as_icon
        Me.Knop_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Knop_Save.Location = New System.Drawing.Point(576, 6)
        Me.Knop_Save.Name = "Knop_Save"
        Me.Knop_Save.Size = New System.Drawing.Size(30, 30)
        Me.Knop_Save.TabIndex = 48
        Me.Knop_Save.UseVisualStyleBackColor = True
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(296, 371)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Nieuw.TabIndex = 50
        Me.Knop_Nieuw.Text = "&Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'Knop_Link
        '
        Me.Knop_Link.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Insert_hyperlink_icon
        Me.Knop_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Link.Location = New System.Drawing.Point(509, 6)
        Me.Knop_Link.Name = "Knop_Link"
        Me.Knop_Link.Size = New System.Drawing.Size(30, 30)
        Me.Knop_Link.TabIndex = 52
        Me.Knop_Link.UseVisualStyleBackColor = True
        '
        'CB_NaamSupplier
        '
        Me.CB_NaamSupplier.DataSource = Me.SupplierBindingSource
        Me.CB_NaamSupplier.DisplayMember = "SP_Naam"
        Me.CB_NaamSupplier.DropDownWidth = 200
        Me.CB_NaamSupplier.FormattingEnabled = True
        Me.CB_NaamSupplier.Location = New System.Drawing.Point(54, 18)
        Me.CB_NaamSupplier.Name = "CB_NaamSupplier"
        Me.CB_NaamSupplier.Size = New System.Drawing.Size(20, 21)
        Me.CB_NaamSupplier.TabIndex = 1
        Me.CB_NaamSupplier.TabStop = False
        '
        'DSSupplierBindingSource
        '
        Me.DSSupplierBindingSource.DataSource = Me.DS_Supplier
        Me.DSSupplierBindingSource.Position = 0
        '
        'ValutaBindingSource
        '
        Me.ValutaBindingSource.DataMember = "Valuta"
        Me.ValutaBindingSource.DataSource = Me.DSSupplierBindingSource
        '
        'GrootboekBindingSource
        '
        Me.GrootboekBindingSource.DataMember = "Grootboek"
        Me.GrootboekBindingSource.DataSource = Me.DS_Supplier
        '
        'F_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 421)
        Me.Controls.Add(Me.Knop_Link)
        Me.Controls.Add(Me.Knop_Nieuw)
        Me.Controls.Add(Me.Knop_Delete)
        Me.Controls.Add(Me.Knop_Save)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_opslaan)
        Me.Controls.Add(Me.GB_Supplier)
        Me.Controls.Add(SP_AdresXtraLabel)
        Me.Controls.Add(Me.ID_SupplierTextBox)
        Me.Name = "F_Supplier"
        Me.Text = "Leverancier, crediteur"
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Supplier.ResumeLayout(False)
        Me.GB_Supplier.PerformLayout()
        CType(Me.BetaalWijzenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrootboekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_Supplier As DS_Supplier
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DS_SupplierTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As DS_SupplierTableAdapters.TableAdapterManager
    Friend WithEvents ID_SupplierTextBox As TextBox
    Friend WithEvents GB_Supplier As GroupBox
    Friend WithEvents SP_IBANTextBox As TextBox
    Friend WithEvents SP_ShiftTextBox As TextBox
    Friend WithEvents SP_BankTextBox As TextBox
    Friend WithEvents SP_TermijnTextBox As TextBox
    Friend WithEvents SP_VATnumberTextBox As TextBox
    Friend WithEvents TXT_Website As TextBox
    Friend WithEvents SP_EmailTextBox As TextBox
    Friend WithEvents SP_PhoneTextBox As TextBox
    Friend WithEvents SP_DebiteurKenmerkTextBox As TextBox
    Friend WithEvents SP_PlaatsTextBox As TextBox
    Friend WithEvents SP_PostcodeTextBox As TextBox
    Friend WithEvents SP_AdresXtraTextBox As TextBox
    Friend WithEvents TXT_adres As TextBox
    Friend WithEvents LandBindingSource As BindingSource
    Friend WithEvents LandTableAdapter As DS_SupplierTableAdapters.LandTableAdapter
    Friend WithEvents Knop_opslaan As Button
    Friend WithEvents CB_Land As ComboBox
    Friend WithEvents Ch_Winkel As CheckBox
    Friend WithEvents Ch_Webwinkel As CheckBox
    Friend WithEvents TXT_Kenmerk As TextBox
    Friend WithEvents CB_BetaalWijzen As ComboBox
    Friend WithEvents BetaalWijzenBindingSource As BindingSource
    Friend WithEvents BetaalWijzenTableAdapter As DS_SupplierTableAdapters.BetaalWijzenTableAdapter
    Friend WithEvents CB_Valuta As ComboBox
    Friend WithEvents ValutaTableAdapter As DS_SupplierTableAdapters.ValutaTableAdapter
    Friend WithEvents CB_Grootboek As ComboBox
    Friend WithEvents GrootboekTableAdapter As DS_SupplierTableAdapters.GrootboekTableAdapter
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Knop_Delete As Button
    Friend WithEvents Knop_Save As Button
    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents Knop_Link As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CB_NaamSupplier As ComboBox
    Friend WithEvents ValutaBindingSource As BindingSource
    Friend WithEvents DSSupplierBindingSource As BindingSource
    Friend WithEvents GrootboekBindingSource As BindingSource
End Class

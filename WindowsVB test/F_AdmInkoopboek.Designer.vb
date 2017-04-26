<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AdmInkoopboek
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
        Dim IB_DatumLabel As System.Windows.Forms.Label
        Dim ID_SupplierLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim IB_PaidDatumLabel As System.Windows.Forms.Label
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.GB_JournaalPosten = New System.Windows.Forms.GroupBox()
        Me.TXT_DebetTotaal = New System.Windows.Forms.TextBox()
        Me.TXT_CreditTotaal = New System.Windows.Forms.TextBox()
        Me.DG_Journaal = New System.Windows.Forms.DataGridView()
        Me.AdmGBrekeningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Administratie = New WindowsVB_test.DS_Administratie()
        Me.AdmJournaalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GB_Crediteur = New System.Windows.Forms.GroupBox()
        Me.CB_Valuta = New System.Windows.Forms.ComboBox()
        Me.AdmInkoopBoekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_Supplier = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IB_Datum = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_BTW = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_WaardeEuro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Waarde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Kenmerk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GB_Betaling = New System.Windows.Forms.GroupBox()
        Me.TXT_SupBetaalWijze = New System.Windows.Forms.TextBox()
        Me.TXT_SUPValuta = New System.Windows.Forms.TextBox()
        Me.TXT_GrootboekCR = New System.Windows.Forms.TextBox()
        Me.BetaalWijzenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXT_Koers = New System.Windows.Forms.TextBox()
        Me.txt_grootboekSupplier = New System.Windows.Forms.TextBox()
        Me.CB_BetaalWijze = New System.Windows.Forms.ComboBox()
        Me.DATE_betaaldatum = New System.Windows.Forms.DateTimePicker()
        Me.Knop_Toon = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_Boeknummer = New System.Windows.Forms.TextBox()
        Me.IB_DueDatum = New System.Windows.Forms.DateTimePicker()
        Me.CH_Betaald = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_IDSupplier = New System.Windows.Forms.TextBox()
        Me.AdmInkoopBoekTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.AdmInkoopBoekTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_AdministratieTableAdapters.TableAdapterManager()
        Me.AdmJournaalTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.AdmJournaalTableAdapter()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.SupplierTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Knop_Actie = New System.Windows.Forms.Button()
        Me.Knop_herlaadForm = New System.Windows.Forms.Button()
        Me.TXT_KoersOUD = New System.Windows.Forms.TextBox()
        Me.ValutaTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.ValutaTableAdapter()
        Me.BetaalWijzenTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.BetaalWijzenTableAdapter()
        Me.AdmGBrekeningTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.AdmGBrekeningTableAdapter()
        Me.Knop_Nieuweregel = New System.Windows.Forms.Button()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_Journaal = New System.Windows.Forms.Button()
        Me.Knop_Bereken = New System.Windows.Forms.Button()
        Me.Knop_Close = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IB_DatumLabel = New System.Windows.Forms.Label()
        ID_SupplierLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        IB_PaidDatumLabel = New System.Windows.Forms.Label()
        Me.GB_JournaalPosten.SuspendLayout()
        CType(Me.DG_Journaal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmGBrekeningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmJournaalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Crediteur.SuspendLayout()
        CType(Me.AdmInkoopBoekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Betaling.SuspendLayout()
        CType(Me.BetaalWijzenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IB_DatumLabel
        '
        IB_DatumLabel.AutoSize = True
        IB_DatumLabel.Location = New System.Drawing.Point(14, 70)
        IB_DatumLabel.Name = "IB_DatumLabel"
        IB_DatumLabel.Size = New System.Drawing.Size(41, 13)
        IB_DatumLabel.TabIndex = 22
        IB_DatumLabel.Text = "Datum:"
        '
        'ID_SupplierLabel
        '
        ID_SupplierLabel.AutoSize = True
        ID_SupplierLabel.Location = New System.Drawing.Point(6, 78)
        ID_SupplierLabel.Name = "ID_SupplierLabel"
        ID_SupplierLabel.Size = New System.Drawing.Size(62, 13)
        ID_SupplierLabel.TabIndex = 35
        ID_SupplierLabel.Text = "ID Supplier:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(6, 99)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(37, 13)
        Label3.TabIndex = 38
        Label3.Text = "Koers:"
        '
        'IB_PaidDatumLabel
        '
        IB_PaidDatumLabel.AutoSize = True
        IB_PaidDatumLabel.Location = New System.Drawing.Point(12, 103)
        IB_PaidDatumLabel.Name = "IB_PaidDatumLabel"
        IB_PaidDatumLabel.Size = New System.Drawing.Size(69, 13)
        IB_PaidDatumLabel.TabIndex = 39
        IB_PaidDatumLabel.Text = "Betaaldatum:"
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(497, 404)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(134, 23)
        Me.Knop_Sluiten.TabIndex = 4
        Me.Knop_Sluiten.Text = "&Opslaan en Sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'GB_JournaalPosten
        '
        Me.GB_JournaalPosten.Controls.Add(Me.TXT_DebetTotaal)
        Me.GB_JournaalPosten.Controls.Add(Me.TXT_CreditTotaal)
        Me.GB_JournaalPosten.Controls.Add(Me.Knop_Bereken)
        Me.GB_JournaalPosten.Controls.Add(Me.DG_Journaal)
        Me.GB_JournaalPosten.Controls.Add(Me.Knop_Journaal)
        Me.GB_JournaalPosten.Controls.Add(Me.Knop_Nieuweregel)
        Me.GB_JournaalPosten.Location = New System.Drawing.Point(15, 189)
        Me.GB_JournaalPosten.Name = "GB_JournaalPosten"
        Me.GB_JournaalPosten.Size = New System.Drawing.Size(616, 209)
        Me.GB_JournaalPosten.TabIndex = 5
        Me.GB_JournaalPosten.TabStop = False
        Me.GB_JournaalPosten.Text = "Journaalposten"
        '
        'TXT_DebetTotaal
        '
        Me.TXT_DebetTotaal.Enabled = False
        Me.TXT_DebetTotaal.Location = New System.Drawing.Point(233, 176)
        Me.TXT_DebetTotaal.Name = "TXT_DebetTotaal"
        Me.TXT_DebetTotaal.Size = New System.Drawing.Size(88, 20)
        Me.TXT_DebetTotaal.TabIndex = 48
        Me.TXT_DebetTotaal.TabStop = False
        '
        'TXT_CreditTotaal
        '
        Me.TXT_CreditTotaal.Enabled = False
        Me.TXT_CreditTotaal.Location = New System.Drawing.Point(338, 176)
        Me.TXT_CreditTotaal.Name = "TXT_CreditTotaal"
        Me.TXT_CreditTotaal.Size = New System.Drawing.Size(88, 20)
        Me.TXT_CreditTotaal.TabIndex = 47
        Me.TXT_CreditTotaal.TabStop = False
        '
        'DG_Journaal
        '
        Me.DG_Journaal.AllowUserToAddRows = False
        Me.DG_Journaal.AutoGenerateColumns = False
        Me.DG_Journaal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Journaal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DG_Journaal.DataSource = Me.AdmJournaalBindingSource
        Me.DG_Journaal.Location = New System.Drawing.Point(6, 19)
        Me.DG_Journaal.MultiSelect = False
        Me.DG_Journaal.Name = "DG_Journaal"
        Me.DG_Journaal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DG_Journaal.Size = New System.Drawing.Size(425, 151)
        Me.DG_Journaal.TabIndex = 0
        '
        'AdmGBrekeningBindingSource
        '
        Me.AdmGBrekeningBindingSource.DataMember = "AdmGBrekening"
        Me.AdmGBrekeningBindingSource.DataSource = Me.DS_Administratie
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
        'GB_Crediteur
        '
        Me.GB_Crediteur.Controls.Add(Me.CB_Valuta)
        Me.GB_Crediteur.Controls.Add(Me.CB_Supplier)
        Me.GB_Crediteur.Controls.Add(Me.Knop_Annuleren)
        Me.GB_Crediteur.Controls.Add(IB_DatumLabel)
        Me.GB_Crediteur.Controls.Add(Me.IB_Datum)
        Me.GB_Crediteur.Controls.Add(Me.Label7)
        Me.GB_Crediteur.Controls.Add(Me.TXT_BTW)
        Me.GB_Crediteur.Controls.Add(Me.Label6)
        Me.GB_Crediteur.Controls.Add(Me.TXT_WaardeEuro)
        Me.GB_Crediteur.Controls.Add(Me.Label5)
        Me.GB_Crediteur.Controls.Add(Me.Label4)
        Me.GB_Crediteur.Controls.Add(Me.TXT_Waarde)
        Me.GB_Crediteur.Controls.Add(Me.Label2)
        Me.GB_Crediteur.Controls.Add(Me.TXT_Kenmerk)
        Me.GB_Crediteur.Controls.Add(Me.Label1)
        Me.GB_Crediteur.Location = New System.Drawing.Point(12, 14)
        Me.GB_Crediteur.Name = "GB_Crediteur"
        Me.GB_Crediteur.Size = New System.Drawing.Size(306, 168)
        Me.GB_Crediteur.TabIndex = 17
        Me.GB_Crediteur.TabStop = False
        Me.GB_Crediteur.Text = "Boekstuk"
        '
        'CB_Valuta
        '
        Me.CB_Valuta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AdmInkoopBoekBindingSource, "IB_Valuta", True))
        Me.CB_Valuta.DataSource = Me.ValutaBindingSource
        Me.CB_Valuta.DisplayMember = "VT_Short"
        Me.CB_Valuta.FormattingEnabled = True
        Me.CB_Valuta.Location = New System.Drawing.Point(209, 91)
        Me.CB_Valuta.Name = "CB_Valuta"
        Me.CB_Valuta.Size = New System.Drawing.Size(74, 21)
        Me.CB_Valuta.TabIndex = 30
        Me.CB_Valuta.ValueMember = "ID_valuta"
        '
        'AdmInkoopBoekBindingSource
        '
        Me.AdmInkoopBoekBindingSource.DataMember = "AdmInkoopBoek"
        Me.AdmInkoopBoekBindingSource.DataSource = Me.DS_Administratie
        '
        'ValutaBindingSource
        '
        Me.ValutaBindingSource.DataMember = "Valuta"
        Me.ValutaBindingSource.DataSource = Me.DS_Administratie
        '
        'CB_Supplier
        '
        Me.CB_Supplier.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AdmInkoopBoekBindingSource, "ID_Supplier", True))
        Me.CB_Supplier.DataSource = Me.SupplierBindingSource
        Me.CB_Supplier.DisplayMember = "SP_Naam"
        Me.CB_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Supplier.FormattingEnabled = True
        Me.CB_Supplier.Location = New System.Drawing.Point(83, 22)
        Me.CB_Supplier.MaxDropDownItems = 12
        Me.CB_Supplier.Name = "CB_Supplier"
        Me.CB_Supplier.Size = New System.Drawing.Size(200, 21)
        Me.CB_Supplier.TabIndex = 0
        Me.CB_Supplier.ValueMember = "ID_Supplier"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Administratie
        '
        'IB_Datum
        '
        Me.IB_Datum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AdmInkoopBoekBindingSource, "IB_Datum", True))
        Me.IB_Datum.Location = New System.Drawing.Point(83, 67)
        Me.IB_Datum.Name = "IB_Datum"
        Me.IB_Datum.Size = New System.Drawing.Size(200, 20)
        Me.IB_Datum.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "BTW:"
        '
        'TXT_BTW
        '
        Me.TXT_BTW.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "IB_BTW", True))
        Me.TXT_BTW.Location = New System.Drawing.Point(83, 133)
        Me.TXT_BTW.Name = "TXT_BTW"
        Me.TXT_BTW.Size = New System.Drawing.Size(73, 20)
        Me.TXT_BTW.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Waarde Euro:"
        '
        'TXT_WaardeEuro
        '
        Me.TXT_WaardeEuro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "IB_WaardeEuro", True))
        Me.TXT_WaardeEuro.Location = New System.Drawing.Point(83, 111)
        Me.TXT_WaardeEuro.Name = "TXT_WaardeEuro"
        Me.TXT_WaardeEuro.Size = New System.Drawing.Size(73, 20)
        Me.TXT_WaardeEuro.TabIndex = 26
        Me.TXT_WaardeEuro.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Valuta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Waarde:"
        '
        'TXT_Waarde
        '
        Me.TXT_Waarde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "IB_Waarde", True))
        Me.TXT_Waarde.Location = New System.Drawing.Point(83, 89)
        Me.TXT_Waarde.Name = "TXT_Waarde"
        Me.TXT_Waarde.Size = New System.Drawing.Size(73, 20)
        Me.TXT_Waarde.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Kenmerk:"
        '
        'TXT_Kenmerk
        '
        Me.TXT_Kenmerk.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "IB_Kenmerk", True))
        Me.TXT_Kenmerk.Location = New System.Drawing.Point(83, 45)
        Me.TXT_Kenmerk.Name = "TXT_Kenmerk"
        Me.TXT_Kenmerk.Size = New System.Drawing.Size(200, 20)
        Me.TXT_Kenmerk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Crediteur:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Vervaldatum:"
        '
        'GB_Betaling
        '
        Me.GB_Betaling.Controls.Add(Me.TXT_SupBetaalWijze)
        Me.GB_Betaling.Controls.Add(Me.TXT_SUPValuta)
        Me.GB_Betaling.Controls.Add(Me.TXT_GrootboekCR)
        Me.GB_Betaling.Controls.Add(Me.TXT_Koers)
        Me.GB_Betaling.Controls.Add(Me.txt_grootboekSupplier)
        Me.GB_Betaling.Controls.Add(Me.CB_BetaalWijze)
        Me.GB_Betaling.Controls.Add(IB_PaidDatumLabel)
        Me.GB_Betaling.Controls.Add(Me.DATE_betaaldatum)
        Me.GB_Betaling.Controls.Add(Me.Knop_Toon)
        Me.GB_Betaling.Controls.Add(Me.Label11)
        Me.GB_Betaling.Controls.Add(Me.TXT_Boeknummer)
        Me.GB_Betaling.Controls.Add(Me.IB_DueDatum)
        Me.GB_Betaling.Controls.Add(Me.CH_Betaald)
        Me.GB_Betaling.Controls.Add(Me.Label9)
        Me.GB_Betaling.Controls.Add(Me.Label8)
        Me.GB_Betaling.Location = New System.Drawing.Point(324, 12)
        Me.GB_Betaling.Name = "GB_Betaling"
        Me.GB_Betaling.Size = New System.Drawing.Size(307, 170)
        Me.GB_Betaling.TabIndex = 5
        Me.GB_Betaling.TabStop = False
        '
        'TXT_SupBetaalWijze
        '
        Me.TXT_SupBetaalWijze.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_BetaalWijzen", True))
        Me.TXT_SupBetaalWijze.Enabled = False
        Me.TXT_SupBetaalWijze.Location = New System.Drawing.Point(149, 141)
        Me.TXT_SupBetaalWijze.Name = "TXT_SupBetaalWijze"
        Me.TXT_SupBetaalWijze.Size = New System.Drawing.Size(40, 20)
        Me.TXT_SupBetaalWijze.TabIndex = 49
        Me.TXT_SupBetaalWijze.TabStop = False
        '
        'TXT_SUPValuta
        '
        Me.TXT_SUPValuta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_Valuta", True))
        Me.TXT_SUPValuta.Enabled = False
        Me.TXT_SUPValuta.Location = New System.Drawing.Point(105, 140)
        Me.TXT_SUPValuta.Name = "TXT_SUPValuta"
        Me.TXT_SUPValuta.Size = New System.Drawing.Size(40, 20)
        Me.TXT_SUPValuta.TabIndex = 48
        Me.TXT_SUPValuta.TabStop = False
        '
        'TXT_GrootboekCR
        '
        Me.TXT_GrootboekCR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BetaalWijzenBindingSource, "ID_Grootboek", True))
        Me.TXT_GrootboekCR.Enabled = False
        Me.TXT_GrootboekCR.Location = New System.Drawing.Point(194, 141)
        Me.TXT_GrootboekCR.Name = "TXT_GrootboekCR"
        Me.TXT_GrootboekCR.Size = New System.Drawing.Size(40, 20)
        Me.TXT_GrootboekCR.TabIndex = 47
        Me.TXT_GrootboekCR.TabStop = False
        '
        'BetaalWijzenBindingSource
        '
        Me.BetaalWijzenBindingSource.DataMember = "BetaalWijzen"
        Me.BetaalWijzenBindingSource.DataSource = Me.DS_Administratie
        '
        'TXT_Koers
        '
        Me.TXT_Koers.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ValutaBindingSource, "VT_Koers", True))
        Me.TXT_Koers.Enabled = False
        Me.TXT_Koers.Location = New System.Drawing.Point(240, 141)
        Me.TXT_Koers.Name = "TXT_Koers"
        Me.TXT_Koers.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Koers.TabIndex = 45
        Me.TXT_Koers.TabStop = False
        '
        'txt_grootboekSupplier
        '
        Me.txt_grootboekSupplier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "ID_Grootboek", True))
        Me.txt_grootboekSupplier.Enabled = False
        Me.txt_grootboekSupplier.Location = New System.Drawing.Point(59, 140)
        Me.txt_grootboekSupplier.Name = "txt_grootboekSupplier"
        Me.txt_grootboekSupplier.Size = New System.Drawing.Size(40, 20)
        Me.txt_grootboekSupplier.TabIndex = 43
        Me.txt_grootboekSupplier.TabStop = False
        '
        'CB_BetaalWijze
        '
        Me.CB_BetaalWijze.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AdmInkoopBoekBindingSource, "ID_BetaalWijzen", True))
        Me.CB_BetaalWijze.DataSource = Me.BetaalWijzenBindingSource
        Me.CB_BetaalWijze.DisplayMember = "BW_Kort"
        Me.CB_BetaalWijze.FormattingEnabled = True
        Me.CB_BetaalWijze.Location = New System.Drawing.Point(209, 77)
        Me.CB_BetaalWijze.Name = "CB_BetaalWijze"
        Me.CB_BetaalWijze.Size = New System.Drawing.Size(74, 21)
        Me.CB_BetaalWijze.TabIndex = 41
        Me.CB_BetaalWijze.ValueMember = "ID_BetaalWijzen"
        '
        'DATE_betaaldatum
        '
        Me.DATE_betaaldatum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AdmInkoopBoekBindingSource, "IB_PaidDatum", True))
        Me.DATE_betaaldatum.Location = New System.Drawing.Point(83, 99)
        Me.DATE_betaaldatum.Name = "DATE_betaaldatum"
        Me.DATE_betaaldatum.Size = New System.Drawing.Size(200, 20)
        Me.DATE_betaaldatum.TabIndex = 40
        '
        'Knop_Toon
        '
        Me.Knop_Toon.Location = New System.Drawing.Point(208, 14)
        Me.Knop_Toon.Name = "Knop_Toon"
        Me.Knop_Toon.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Toon.TabIndex = 39
        Me.Knop_Toon.TabStop = False
        Me.Knop_Toon.Text = "&Toon"
        Me.Knop_Toon.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Nummer:"
        '
        'TXT_Boeknummer
        '
        Me.TXT_Boeknummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "ID_AdmInkoopboek", True))
        Me.TXT_Boeknummer.Location = New System.Drawing.Point(83, 19)
        Me.TXT_Boeknummer.Name = "TXT_Boeknummer"
        Me.TXT_Boeknummer.Size = New System.Drawing.Size(94, 20)
        Me.TXT_Boeknummer.TabIndex = 37
        '
        'IB_DueDatum
        '
        Me.IB_DueDatum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AdmInkoopBoekBindingSource, "IB_DueDatum", True))
        Me.IB_DueDatum.Location = New System.Drawing.Point(83, 43)
        Me.IB_DueDatum.Name = "IB_DueDatum"
        Me.IB_DueDatum.Size = New System.Drawing.Size(200, 20)
        Me.IB_DueDatum.TabIndex = 36
        '
        'CH_Betaald
        '
        Me.CH_Betaald.AutoSize = True
        Me.CH_Betaald.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AdmInkoopBoekBindingSource, "IB_Paid", True))
        Me.CH_Betaald.Location = New System.Drawing.Point(83, 79)
        Me.CH_Betaald.Name = "CH_Betaald"
        Me.CH_Betaald.Size = New System.Drawing.Size(62, 17)
        Me.CH_Betaald.TabIndex = 35
        Me.CH_Betaald.Text = "Betaald"
        Me.CH_Betaald.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(146, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Betaalwijze:"
        '
        'TXT_IDSupplier
        '
        Me.TXT_IDSupplier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "ID_Supplier", True))
        Me.TXT_IDSupplier.Location = New System.Drawing.Point(74, 75)
        Me.TXT_IDSupplier.Name = "TXT_IDSupplier"
        Me.TXT_IDSupplier.Size = New System.Drawing.Size(100, 20)
        Me.TXT_IDSupplier.TabIndex = 36
        Me.TXT_IDSupplier.TabStop = False
        '
        'AdmInkoopBoekTableAdapter
        '
        Me.AdmInkoopBoekTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdmBoekTableAdapter = Nothing
        Me.TableAdapterManager.AdmGBrekeningTableAdapter = Nothing
        Me.TableAdapterManager.AdmInkoopBoekTableAdapter = Me.AdmInkoopBoekTableAdapter
        Me.TableAdapterManager.AdmJournaalTableAdapter = Me.AdmJournaalTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_AdministratieTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AdmJournaalTableAdapter
        '
        Me.AdmJournaalTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Knop_Actie)
        Me.GroupBox3.Controls.Add(Me.Knop_herlaadForm)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.TXT_KoersOUD)
        Me.GroupBox3.Controls.Add(ID_SupplierLabel)
        Me.GroupBox3.Controls.Add(Me.TXT_IDSupplier)
        Me.GroupBox3.Location = New System.Drawing.Point(814, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 409)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hulp Controls, onzichtbaar"
        '
        'Knop_Actie
        '
        Me.Knop_Actie.Location = New System.Drawing.Point(56, 47)
        Me.Knop_Actie.Name = "Knop_Actie"
        Me.Knop_Actie.Size = New System.Drawing.Size(118, 23)
        Me.Knop_Actie.TabIndex = 40
        Me.Knop_Actie.Text = "Actie"
        Me.Knop_Actie.UseVisualStyleBackColor = True
        '
        'Knop_herlaadForm
        '
        Me.Knop_herlaadForm.Location = New System.Drawing.Point(56, 18)
        Me.Knop_herlaadForm.Name = "Knop_herlaadForm"
        Me.Knop_herlaadForm.Size = New System.Drawing.Size(118, 23)
        Me.Knop_herlaadForm.TabIndex = 39
        Me.Knop_herlaadForm.TabStop = False
        Me.Knop_herlaadForm.Text = "Herlaad form"
        Me.Knop_herlaadForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Knop_herlaadForm.UseVisualStyleBackColor = True
        '
        'TXT_KoersOUD
        '
        Me.TXT_KoersOUD.Location = New System.Drawing.Point(74, 96)
        Me.TXT_KoersOUD.Name = "TXT_KoersOUD"
        Me.TXT_KoersOUD.Size = New System.Drawing.Size(100, 20)
        Me.TXT_KoersOUD.TabIndex = 37
        Me.TXT_KoersOUD.TabStop = False
        '
        'ValutaTableAdapter
        '
        Me.ValutaTableAdapter.ClearBeforeFill = True
        '
        'BetaalWijzenTableAdapter
        '
        Me.BetaalWijzenTableAdapter.ClearBeforeFill = True
        '
        'AdmGBrekeningTableAdapter
        '
        Me.AdmGBrekeningTableAdapter.ClearBeforeFill = True
        '
        'Knop_Nieuweregel
        '
        Me.Knop_Nieuweregel.Location = New System.Drawing.Point(440, 48)
        Me.Knop_Nieuweregel.Name = "Knop_Nieuweregel"
        Me.Knop_Nieuweregel.Size = New System.Drawing.Size(82, 23)
        Me.Knop_Nieuweregel.TabIndex = 41
        Me.Knop_Nieuweregel.Text = "&Xtra Regel"
        Me.Knop_Nieuweregel.UseVisualStyleBackColor = True
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(225, 136)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 42
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_Journaal
        '
        Me.Knop_Journaal.Location = New System.Drawing.Point(440, 19)
        Me.Knop_Journaal.Name = "Knop_Journaal"
        Me.Knop_Journaal.Size = New System.Drawing.Size(82, 23)
        Me.Knop_Journaal.TabIndex = 44
        Me.Knop_Journaal.Text = "&Journaal"
        Me.Knop_Journaal.UseVisualStyleBackColor = True
        '
        'Knop_Bereken
        '
        Me.Knop_Bereken.Location = New System.Drawing.Point(440, 77)
        Me.Knop_Bereken.Name = "Knop_Bereken"
        Me.Knop_Bereken.Size = New System.Drawing.Size(82, 23)
        Me.Knop_Bereken.TabIndex = 45
        Me.Knop_Bereken.Text = "&Bereken"
        Me.Knop_Bereken.UseVisualStyleBackColor = True
        '
        'Knop_Close
        '
        Me.Knop_Close.Location = New System.Drawing.Point(658, 158)
        Me.Knop_Close.Name = "Knop_Close"
        Me.Knop_Close.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Close.TabIndex = 46
        Me.Knop_Close.Text = "Close"
        Me.Knop_Close.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "&Opslaan, nieuwe invoer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_JournaalPost"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_JournaalPost"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_AdmBoek"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_AdmBoek"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_Boekstuk"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_Boekstuk"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "JP_Datum"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Grootboek"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.AdmGBrekeningBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "GB_naam"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Grootboek"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Het grootboek rekeningnummer"
        Me.DataGridViewTextBoxColumn3.ValueMember = "ID_Grootboek"
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "JP_Debet"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Debet"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "JP_Credit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Credit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'F_AdmInkoopboek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 605)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Knop_Close)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GB_Betaling)
        Me.Controls.Add(Me.GB_Crediteur)
        Me.Controls.Add(Me.GB_JournaalPosten)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Name = "F_AdmInkoopboek"
        Me.Text = "Inkoopboek, kosten boeken"
        Me.GB_JournaalPosten.ResumeLayout(False)
        Me.GB_JournaalPosten.PerformLayout()
        CType(Me.DG_Journaal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmGBrekeningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmJournaalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Crediteur.ResumeLayout(False)
        Me.GB_Crediteur.PerformLayout()
        CType(Me.AdmInkoopBoekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Betaling.ResumeLayout(False)
        Me.GB_Betaling.PerformLayout()
        CType(Me.BetaalWijzenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Knop_Sluiten As Button
    Friend WithEvents GB_JournaalPosten As GroupBox
    Friend WithEvents GB_Crediteur As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_BTW As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_WaardeEuro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Waarde As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Kenmerk As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GB_Betaling As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DS_Administratie As DS_Administratie
    Friend WithEvents AdmInkoopBoekBindingSource As BindingSource
    Friend WithEvents AdmInkoopBoekTableAdapter As DS_AdministratieTableAdapters.AdmInkoopBoekTableAdapter
    Friend WithEvents TableAdapterManager As DS_AdministratieTableAdapters.TableAdapterManager
    Friend WithEvents IB_Datum As DateTimePicker
    Friend WithEvents CB_Supplier As ComboBox
    Friend WithEvents TXT_IDSupplier As TextBox
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DS_AdministratieTableAdapters.SupplierTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXT_KoersOUD As TextBox
    Friend WithEvents Knop_herlaadForm As Button
    Friend WithEvents Knop_Actie As Button
    Friend WithEvents CB_Valuta As ComboBox
    Friend WithEvents ValutaBindingSource As BindingSource
    Friend WithEvents ValutaTableAdapter As DS_AdministratieTableAdapters.ValutaTableAdapter
    Friend WithEvents CH_Betaald As CheckBox
    Friend WithEvents IB_DueDatum As DateTimePicker
    Friend WithEvents Knop_Toon As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_Boeknummer As TextBox
    Friend WithEvents DATE_betaaldatum As DateTimePicker
    Friend WithEvents CB_BetaalWijze As ComboBox
    Friend WithEvents BetaalWijzenBindingSource As BindingSource
    Friend WithEvents BetaalWijzenTableAdapter As DS_AdministratieTableAdapters.BetaalWijzenTableAdapter
    Friend WithEvents AdmJournaalBindingSource As BindingSource
    Friend WithEvents AdmJournaalTableAdapter As DS_AdministratieTableAdapters.AdmJournaalTableAdapter
    Friend WithEvents DG_Journaal As DataGridView
    Friend WithEvents AdmGBrekeningBindingSource As BindingSource
    Friend WithEvents AdmGBrekeningTableAdapter As DS_AdministratieTableAdapters.AdmGBrekeningTableAdapter
    Friend WithEvents Knop_Nieuweregel As Button
    Friend WithEvents TXT_Koers As TextBox
    Friend WithEvents TXT_DebetTotaal As TextBox
    Friend WithEvents TXT_CreditTotaal As TextBox
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents TXT_GrootboekCR As TextBox
    Friend WithEvents Knop_Journaal As Button
    Friend WithEvents Knop_Bereken As Button
    Friend WithEvents Knop_Close As Button
    Friend WithEvents txt_grootboekSupplier As TextBox
    Friend WithEvents TXT_SupBetaalWijze As TextBox
    Friend WithEvents TXT_SUPValuta As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class

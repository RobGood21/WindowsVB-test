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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_AdmInkoopboek))
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.GB_JournaalPosten = New System.Windows.Forms.GroupBox()
        Me.AdmJournaalDataGridView = New System.Windows.Forms.DataGridView()
        Me.AdmJournaalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Administratie = New WindowsVB_test.DS_Administratie()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AdmInkoopBoekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
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
        Me.CB_BetaalWijze = New System.Windows.Forms.ComboBox()
        Me.BetaalWijzenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IB_PaidDatumDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Knop_Toon = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_Boeknummer = New System.Windows.Forms.TextBox()
        Me.IB_DueDatum = New System.Windows.Forms.DateTimePicker()
        Me.CH_Betaald = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_remarks = New System.Windows.Forms.TextBox()
        Me.AdmInkoopBoekBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AdmInkoopBoekBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.AdmInkoopBoekTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.AdmInkoopBoekTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_AdministratieTableAdapters.TableAdapterManager()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.SupplierTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Knop_Actie = New System.Windows.Forms.Button()
        Me.Knop_herlaadForm = New System.Windows.Forms.Button()
        Me.TXT_Koers = New System.Windows.Forms.TextBox()
        Me.ValutaTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.ValutaTableAdapter()
        Me.BetaalWijzenTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.BetaalWijzenTableAdapter()
        Me.AdmJournaalTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.AdmJournaalTableAdapter()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.Knop_annuleren = New System.Windows.Forms.Button()
        Me.AdmGBrekeningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmGBrekeningTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.AdmGBrekeningTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IB_DatumLabel = New System.Windows.Forms.Label()
        ID_SupplierLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        IB_PaidDatumLabel = New System.Windows.Forms.Label()
        Me.GB_JournaalPosten.SuspendLayout()
        CType(Me.AdmJournaalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmJournaalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AdmInkoopBoekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Betaling.SuspendLayout()
        CType(Me.BetaalWijzenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmInkoopBoekBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdmInkoopBoekBindingNavigator.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AdmGBrekeningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IB_DatumLabel
        '
        IB_DatumLabel.AutoSize = True
        IB_DatumLabel.Location = New System.Drawing.Point(14, 75)
        IB_DatumLabel.Name = "IB_DatumLabel"
        IB_DatumLabel.Size = New System.Drawing.Size(41, 13)
        IB_DatumLabel.TabIndex = 22
        IB_DatumLabel.Text = "Datum:"
        '
        'ID_SupplierLabel
        '
        ID_SupplierLabel.AutoSize = True
        ID_SupplierLabel.Location = New System.Drawing.Point(16, 79)
        ID_SupplierLabel.Name = "ID_SupplierLabel"
        ID_SupplierLabel.Size = New System.Drawing.Size(62, 13)
        ID_SupplierLabel.TabIndex = 35
        ID_SupplierLabel.Text = "ID Supplier:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 106)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(37, 13)
        Label3.TabIndex = 38
        Label3.Text = "Koers:"
        '
        'IB_PaidDatumLabel
        '
        IB_PaidDatumLabel.AutoSize = True
        IB_PaidDatumLabel.Location = New System.Drawing.Point(12, 104)
        IB_PaidDatumLabel.Name = "IB_PaidDatumLabel"
        IB_PaidDatumLabel.Size = New System.Drawing.Size(69, 13)
        IB_PaidDatumLabel.TabIndex = 39
        IB_PaidDatumLabel.Text = "Betaaldatum:"
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(556, 429)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Sluiten.TabIndex = 4
        Me.Knop_Sluiten.Text = "&Sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'GB_JournaalPosten
        '
        Me.GB_JournaalPosten.Controls.Add(Me.AdmJournaalDataGridView)
        Me.GB_JournaalPosten.Location = New System.Drawing.Point(15, 236)
        Me.GB_JournaalPosten.Name = "GB_JournaalPosten"
        Me.GB_JournaalPosten.Size = New System.Drawing.Size(616, 187)
        Me.GB_JournaalPosten.TabIndex = 5
        Me.GB_JournaalPosten.TabStop = False
        Me.GB_JournaalPosten.Text = "Journaalposten"
        '
        'AdmJournaalDataGridView
        '
        Me.AdmJournaalDataGridView.AutoGenerateColumns = False
        Me.AdmJournaalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdmJournaalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AdmJournaalDataGridView.DataSource = Me.AdmJournaalBindingSource
        Me.AdmJournaalDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.AdmJournaalDataGridView.Name = "AdmJournaalDataGridView"
        Me.AdmJournaalDataGridView.Size = New System.Drawing.Size(596, 148)
        Me.AdmJournaalDataGridView.TabIndex = 0
        '
        'AdmJournaalBindingSource
        '
        Me.AdmJournaalBindingSource.DataMember = "AdmJournaal"
        Me.AdmJournaalBindingSource.DataSource = Me.DS_Administratie
        '
        'DS_Administratie
        '
        Me.DS_Administratie.DataSetName = "DS_Administratie"
        Me.DS_Administratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(IB_DatumLabel)
        Me.GroupBox1.Controls.Add(Me.IB_Datum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_BTW)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_WaardeEuro)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_Waarde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_Kenmerk)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 168)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Boekstuk"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AdmInkoopBoekBindingSource, "IB_Valuta", True))
        Me.ComboBox1.DataSource = Me.ValutaBindingSource
        Me.ComboBox1.DisplayMember = "VT_Short"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(209, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.ValueMember = "ID_valuta"
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
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AdmInkoopBoekBindingSource, "ID_Supplier", True))
        Me.ComboBox2.DataSource = Me.SupplierBindingSource
        Me.ComboBox2.DisplayMember = "SP_Naam"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(83, 27)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 0
        Me.ComboBox2.ValueMember = "ID_Supplier"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Administratie
        '
        'IB_Datum
        '
        Me.IB_Datum.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AdmInkoopBoekBindingSource, "IB_Datum", True))
        Me.IB_Datum.Location = New System.Drawing.Point(83, 72)
        Me.IB_Datum.Name = "IB_Datum"
        Me.IB_Datum.Size = New System.Drawing.Size(200, 20)
        Me.IB_Datum.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "BTW:"
        '
        'TXT_BTW
        '
        Me.TXT_BTW.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "IB_BTW", True))
        Me.TXT_BTW.Location = New System.Drawing.Point(83, 138)
        Me.TXT_BTW.Name = "TXT_BTW"
        Me.TXT_BTW.Size = New System.Drawing.Size(73, 20)
        Me.TXT_BTW.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Waarde Euro:"
        '
        'TXT_WaardeEuro
        '
        Me.TXT_WaardeEuro.Location = New System.Drawing.Point(83, 116)
        Me.TXT_WaardeEuro.Name = "TXT_WaardeEuro"
        Me.TXT_WaardeEuro.Size = New System.Drawing.Size(73, 20)
        Me.TXT_WaardeEuro.TabIndex = 26
        Me.TXT_WaardeEuro.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Valuta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Waarde:"
        '
        'TXT_Waarde
        '
        Me.TXT_Waarde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "IB_Waarde", True))
        Me.TXT_Waarde.Location = New System.Drawing.Point(83, 94)
        Me.TXT_Waarde.Name = "TXT_Waarde"
        Me.TXT_Waarde.Size = New System.Drawing.Size(73, 20)
        Me.TXT_Waarde.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Kenmerk:"
        '
        'TXT_Kenmerk
        '
        Me.TXT_Kenmerk.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "IB_Kenmerk", True))
        Me.TXT_Kenmerk.Location = New System.Drawing.Point(83, 50)
        Me.TXT_Kenmerk.Name = "TXT_Kenmerk"
        Me.TXT_Kenmerk.Size = New System.Drawing.Size(200, 20)
        Me.TXT_Kenmerk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
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
        Me.GB_Betaling.Controls.Add(Me.CB_BetaalWijze)
        Me.GB_Betaling.Controls.Add(IB_PaidDatumLabel)
        Me.GB_Betaling.Controls.Add(Me.IB_PaidDatumDateTimePicker)
        Me.GB_Betaling.Controls.Add(Me.Knop_Toon)
        Me.GB_Betaling.Controls.Add(Me.Label11)
        Me.GB_Betaling.Controls.Add(Me.TXT_Boeknummer)
        Me.GB_Betaling.Controls.Add(Me.IB_DueDatum)
        Me.GB_Betaling.Controls.Add(Me.CH_Betaald)
        Me.GB_Betaling.Controls.Add(Me.Label9)
        Me.GB_Betaling.Controls.Add(Me.Label8)
        Me.GB_Betaling.Location = New System.Drawing.Point(324, 62)
        Me.GB_Betaling.Name = "GB_Betaling"
        Me.GB_Betaling.Size = New System.Drawing.Size(307, 168)
        Me.GB_Betaling.TabIndex = 5
        Me.GB_Betaling.TabStop = False
        '
        'CB_BetaalWijze
        '
        Me.CB_BetaalWijze.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AdmInkoopBoekBindingSource, "ID_BetaalWijzen", True))
        Me.CB_BetaalWijze.DataSource = Me.BetaalWijzenBindingSource
        Me.CB_BetaalWijze.DisplayMember = "BW_Kort"
        Me.CB_BetaalWijze.FormattingEnabled = True
        Me.CB_BetaalWijze.Location = New System.Drawing.Point(83, 122)
        Me.CB_BetaalWijze.Name = "CB_BetaalWijze"
        Me.CB_BetaalWijze.Size = New System.Drawing.Size(200, 21)
        Me.CB_BetaalWijze.TabIndex = 41
        Me.CB_BetaalWijze.ValueMember = "ID_BetaalWijzen"
        '
        'BetaalWijzenBindingSource
        '
        Me.BetaalWijzenBindingSource.DataMember = "BetaalWijzen"
        Me.BetaalWijzenBindingSource.DataSource = Me.DS_Administratie
        '
        'IB_PaidDatumDateTimePicker
        '
        Me.IB_PaidDatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AdmInkoopBoekBindingSource, "IB_PaidDatum", True))
        Me.IB_PaidDatumDateTimePicker.Location = New System.Drawing.Point(83, 100)
        Me.IB_PaidDatumDateTimePicker.Name = "IB_PaidDatumDateTimePicker"
        Me.IB_PaidDatumDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.IB_PaidDatumDateTimePicker.TabIndex = 40
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
        Me.CH_Betaald.Location = New System.Drawing.Point(83, 81)
        Me.CH_Betaald.Name = "CH_Betaald"
        Me.CH_Betaald.Size = New System.Drawing.Size(62, 17)
        Me.CH_Betaald.TabIndex = 35
        Me.CH_Betaald.Text = "Betaald"
        Me.CH_Betaald.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Betaalwijze:"
        '
        'TXT_remarks
        '
        Me.TXT_remarks.Location = New System.Drawing.Point(19, 315)
        Me.TXT_remarks.Multiline = True
        Me.TXT_remarks.Name = "TXT_remarks"
        Me.TXT_remarks.Size = New System.Drawing.Size(215, 40)
        Me.TXT_remarks.TabIndex = 35
        '
        'AdmInkoopBoekBindingNavigator
        '
        Me.AdmInkoopBoekBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdmInkoopBoekBindingNavigator.BindingSource = Me.AdmInkoopBoekBindingSource
        Me.AdmInkoopBoekBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdmInkoopBoekBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdmInkoopBoekBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdmInkoopBoekBindingNavigatorSaveItem})
        Me.AdmInkoopBoekBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdmInkoopBoekBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdmInkoopBoekBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdmInkoopBoekBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdmInkoopBoekBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdmInkoopBoekBindingNavigator.Name = "AdmInkoopBoekBindingNavigator"
        Me.AdmInkoopBoekBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdmInkoopBoekBindingNavigator.Size = New System.Drawing.Size(993, 25)
        Me.AdmInkoopBoekBindingNavigator.TabIndex = 22
        Me.AdmInkoopBoekBindingNavigator.Text = "BindingNavigator1"
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
        'AdmInkoopBoekBindingNavigatorSaveItem
        '
        Me.AdmInkoopBoekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdmInkoopBoekBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdmInkoopBoekBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdmInkoopBoekBindingNavigatorSaveItem.Name = "AdmInkoopBoekBindingNavigatorSaveItem"
        Me.AdmInkoopBoekBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AdmInkoopBoekBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_SupplierTextBox
        '
        Me.ID_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdmInkoopBoekBindingSource, "ID_Supplier", True))
        Me.ID_SupplierTextBox.Location = New System.Drawing.Point(84, 76)
        Me.ID_SupplierTextBox.Name = "ID_SupplierTextBox"
        Me.ID_SupplierTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_SupplierTextBox.TabIndex = 36
        Me.ID_SupplierTextBox.TabStop = False
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
        Me.TableAdapterManager.AdmJournaalTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_AdministratieTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.GroupBox3.Controls.Add(Me.TXT_remarks)
        Me.GroupBox3.Controls.Add(Me.TXT_Koers)
        Me.GroupBox3.Controls.Add(ID_SupplierLabel)
        Me.GroupBox3.Controls.Add(Me.ID_SupplierTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(648, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 361)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hulp Controls, onzichtbaar"
        '
        'Knop_Actie
        '
        Me.Knop_Actie.Location = New System.Drawing.Point(66, 48)
        Me.Knop_Actie.Name = "Knop_Actie"
        Me.Knop_Actie.Size = New System.Drawing.Size(118, 23)
        Me.Knop_Actie.TabIndex = 40
        Me.Knop_Actie.Text = "Actie"
        Me.Knop_Actie.UseVisualStyleBackColor = True
        '
        'Knop_herlaadForm
        '
        Me.Knop_herlaadForm.Location = New System.Drawing.Point(66, 19)
        Me.Knop_herlaadForm.Name = "Knop_herlaadForm"
        Me.Knop_herlaadForm.Size = New System.Drawing.Size(118, 23)
        Me.Knop_herlaadForm.TabIndex = 39
        Me.Knop_herlaadForm.TabStop = False
        Me.Knop_herlaadForm.Text = "Herlaad form"
        Me.Knop_herlaadForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Knop_herlaadForm.UseVisualStyleBackColor = True
        '
        'TXT_Koers
        '
        Me.TXT_Koers.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ValutaBindingSource, "VT_Koers", True))
        Me.TXT_Koers.Location = New System.Drawing.Point(84, 103)
        Me.TXT_Koers.Name = "TXT_Koers"
        Me.TXT_Koers.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Koers.TabIndex = 37
        Me.TXT_Koers.TabStop = False
        '
        'ValutaTableAdapter
        '
        Me.ValutaTableAdapter.ClearBeforeFill = True
        '
        'BetaalWijzenTableAdapter
        '
        Me.BetaalWijzenTableAdapter.ClearBeforeFill = True
        '
        'AdmJournaalTableAdapter
        '
        Me.AdmJournaalTableAdapter.ClearBeforeFill = True
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(17, 429)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Nieuw.TabIndex = 38
        Me.Knop_Nieuw.Text = "&Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(176, 429)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Opslaan.TabIndex = 39
        Me.Knop_Opslaan.Text = "Opslaan"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'Knop_annuleren
        '
        Me.Knop_annuleren.Location = New System.Drawing.Point(95, 429)
        Me.Knop_annuleren.Name = "Knop_annuleren"
        Me.Knop_annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_annuleren.TabIndex = 40
        Me.Knop_annuleren.Text = "Annuleren"
        Me.Knop_annuleren.UseVisualStyleBackColor = True
        '
        'AdmGBrekeningBindingSource
        '
        Me.AdmGBrekeningBindingSource.DataMember = "AdmGBrekening"
        Me.AdmGBrekeningBindingSource.DataSource = Me.DS_Administratie
        '
        'AdmGBrekeningTableAdapter
        '
        Me.AdmGBrekeningTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_JournaalPost"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 20
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_Boekstuk"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_Boekstuk"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_AdmBoek"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_AdmBoek"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
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
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "JP_Debet"
        Me.DataGridViewTextBoxColumn4.HeaderText = "JP_Debet"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "JP_Credit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "JP_Credit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "JP_Datum"
        Me.DataGridViewTextBoxColumn6.HeaderText = "JP_Datum"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'F_AdmInkoopboek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 605)
        Me.Controls.Add(Me.Knop_annuleren)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.Knop_Nieuw)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.AdmInkoopBoekBindingNavigator)
        Me.Controls.Add(Me.GB_Betaling)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_JournaalPosten)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Name = "F_AdmInkoopboek"
        Me.Text = "Inkoopboek, kosten boeken"
        Me.GB_JournaalPosten.ResumeLayout(False)
        CType(Me.AdmJournaalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmJournaalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AdmInkoopBoekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Betaling.ResumeLayout(False)
        Me.GB_Betaling.PerformLayout()
        CType(Me.BetaalWijzenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmInkoopBoekBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdmInkoopBoekBindingNavigator.ResumeLayout(False)
        Me.AdmInkoopBoekBindingNavigator.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AdmGBrekeningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Knop_Sluiten As Button
    Friend WithEvents GB_JournaalPosten As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents TXT_remarks As TextBox
    Friend WithEvents DS_Administratie As DS_Administratie
    Friend WithEvents AdmInkoopBoekBindingSource As BindingSource
    Friend WithEvents AdmInkoopBoekTableAdapter As DS_AdministratieTableAdapters.AdmInkoopBoekTableAdapter
    Friend WithEvents TableAdapterManager As DS_AdministratieTableAdapters.TableAdapterManager
    Friend WithEvents AdmInkoopBoekBindingNavigator As BindingNavigator
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
    Friend WithEvents AdmInkoopBoekBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IB_Datum As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ID_SupplierTextBox As TextBox
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DS_AdministratieTableAdapters.SupplierTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXT_Koers As TextBox
    Friend WithEvents Knop_herlaadForm As Button
    Friend WithEvents Knop_Actie As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ValutaBindingSource As BindingSource
    Friend WithEvents ValutaTableAdapter As DS_AdministratieTableAdapters.ValutaTableAdapter
    Friend WithEvents CH_Betaald As CheckBox
    Friend WithEvents IB_DueDatum As DateTimePicker
    Friend WithEvents Knop_Toon As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_Boeknummer As TextBox
    Friend WithEvents IB_PaidDatumDateTimePicker As DateTimePicker
    Friend WithEvents CB_BetaalWijze As ComboBox
    Friend WithEvents BetaalWijzenBindingSource As BindingSource
    Friend WithEvents BetaalWijzenTableAdapter As DS_AdministratieTableAdapters.BetaalWijzenTableAdapter
    Friend WithEvents AdmJournaalBindingSource As BindingSource
    Friend WithEvents AdmJournaalTableAdapter As DS_AdministratieTableAdapters.AdmJournaalTableAdapter
    Friend WithEvents AdmJournaalDataGridView As DataGridView
    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents Knop_annuleren As Button
    Friend WithEvents AdmGBrekeningBindingSource As BindingSource
    Friend WithEvents AdmGBrekeningTableAdapter As DS_AdministratieTableAdapters.AdmGBrekeningTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AdmInkoopboekLijst
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DS_Administratie = New WindowsVB_test.DS_Administratie()
        Me.AdmInkoopboekLijstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmInkoopboekLijstTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.admInkoopboekLijstTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_AdministratieTableAdapters.TableAdapterManager()
        Me.DG_AdmInkoopLijst = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_Waarde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_aantal = New System.Windows.Forms.TextBox()
        Me.CH_AlleCrediteuren = New System.Windows.Forms.CheckBox()
        Me.Knop_Details = New System.Windows.Forms.Button()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_supplier = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Administratie1 = New WindowsVB_test.DS_Administratie()
        Me.OptieBetaald = New System.Windows.Forms.RadioButton()
        Me.Optie_openstaand = New System.Windows.Forms.RadioButton()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.SupplierTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmInkoopboekLijstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_AdmInkoopLijst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Administratie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_Administratie
        '
        Me.DS_Administratie.DataSetName = "DS_Administratie"
        Me.DS_Administratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdmInkoopboekLijstBindingSource
        '
        Me.AdmInkoopboekLijstBindingSource.DataMember = "admInkoopboekLijst"
        Me.AdmInkoopboekLijstBindingSource.DataSource = Me.DS_Administratie
        '
        'AdmInkoopboekLijstTableAdapter
        '
        Me.AdmInkoopboekLijstTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdmBoekTableAdapter = Nothing
        Me.TableAdapterManager.AdmGBrekeningTableAdapter = Nothing
        Me.TableAdapterManager.AdmInkoopBoekTableAdapter = Nothing
        Me.TableAdapterManager.AdmJournaalTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_AdministratieTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'DG_AdmInkoopLijst
        '
        Me.DG_AdmInkoopLijst.AllowUserToAddRows = False
        Me.DG_AdmInkoopLijst.AllowUserToDeleteRows = False
        Me.DG_AdmInkoopLijst.AllowUserToResizeColumns = False
        Me.DG_AdmInkoopLijst.AllowUserToResizeRows = False
        Me.DG_AdmInkoopLijst.AutoGenerateColumns = False
        Me.DG_AdmInkoopLijst.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DG_AdmInkoopLijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DG_AdmInkoopLijst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5})
        Me.DG_AdmInkoopLijst.DataSource = Me.AdmInkoopboekLijstBindingSource
        Me.DG_AdmInkoopLijst.Location = New System.Drawing.Point(12, 104)
        Me.DG_AdmInkoopLijst.MultiSelect = False
        Me.DG_AdmInkoopLijst.Name = "DG_AdmInkoopLijst"
        Me.DG_AdmInkoopLijst.ReadOnly = True
        Me.DG_AdmInkoopLijst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_AdmInkoopLijst.Size = New System.Drawing.Size(677, 411)
        Me.DG_AdmInkoopLijst.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_Waarde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_aantal)
        Me.GroupBox1.Controls.Add(Me.CH_AlleCrediteuren)
        Me.GroupBox1.Controls.Add(Me.Knop_Details)
        Me.GroupBox1.Controls.Add(Me.Knop_Sluiten)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CB_supplier)
        Me.GroupBox1.Controls.Add(Me.OptieBetaald)
        Me.GroupBox1.Controls.Add(Me.Optie_openstaand)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 80)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Waarde: "
        '
        'TXT_Waarde
        '
        Me.TXT_Waarde.Location = New System.Drawing.Point(490, 45)
        Me.TXT_Waarde.Name = "TXT_Waarde"
        Me.TXT_Waarde.Size = New System.Drawing.Size(71, 20)
        Me.TXT_Waarde.TabIndex = 9
        Me.TXT_Waarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(432, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Aantal:"
        '
        'TXT_aantal
        '
        Me.TXT_aantal.Location = New System.Drawing.Point(490, 22)
        Me.TXT_aantal.Name = "TXT_aantal"
        Me.TXT_aantal.Size = New System.Drawing.Size(71, 20)
        Me.TXT_aantal.TabIndex = 7
        Me.TXT_aantal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CH_AlleCrediteuren
        '
        Me.CH_AlleCrediteuren.AutoSize = True
        Me.CH_AlleCrediteuren.Checked = True
        Me.CH_AlleCrediteuren.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CH_AlleCrediteuren.Location = New System.Drawing.Point(173, 21)
        Me.CH_AlleCrediteuren.Name = "CH_AlleCrediteuren"
        Me.CH_AlleCrediteuren.Size = New System.Drawing.Size(100, 17)
        Me.CH_AlleCrediteuren.TabIndex = 6
        Me.CH_AlleCrediteuren.Text = "Alle Crediteuren"
        Me.CH_AlleCrediteuren.UseVisualStyleBackColor = True
        '
        'Knop_Details
        '
        Me.Knop_Details.Location = New System.Drawing.Point(310, 19)
        Me.Knop_Details.Name = "Knop_Details"
        Me.Knop_Details.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Details.TabIndex = 5
        Me.Knop_Details.Text = "&Details"
        Me.Knop_Details.UseVisualStyleBackColor = True
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(595, 45)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Sluiten.TabIndex = 4
        Me.Knop_Sluiten.Text = "&Sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Crediteur:"
        '
        'CB_supplier
        '
        Me.CB_supplier.DataSource = Me.SupplierBindingSource
        Me.CB_supplier.DisplayMember = "SP_Naam"
        Me.CB_supplier.FormattingEnabled = True
        Me.CB_supplier.Location = New System.Drawing.Point(229, 43)
        Me.CB_supplier.Name = "CB_supplier"
        Me.CB_supplier.Size = New System.Drawing.Size(156, 21)
        Me.CB_supplier.TabIndex = 2
        Me.CB_supplier.ValueMember = "ID_Supplier"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Administratie1
        '
        'DS_Administratie1
        '
        Me.DS_Administratie1.DataSetName = "DS_Administratie"
        Me.DS_Administratie1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OptieBetaald
        '
        Me.OptieBetaald.AutoSize = True
        Me.OptieBetaald.Location = New System.Drawing.Point(25, 43)
        Me.OptieBetaald.Name = "OptieBetaald"
        Me.OptieBetaald.Size = New System.Drawing.Size(61, 17)
        Me.OptieBetaald.TabIndex = 1
        Me.OptieBetaald.Text = "Betaald"
        Me.OptieBetaald.UseVisualStyleBackColor = True
        '
        'Optie_openstaand
        '
        Me.Optie_openstaand.AutoSize = True
        Me.Optie_openstaand.Checked = True
        Me.Optie_openstaand.Location = New System.Drawing.Point(25, 20)
        Me.Optie_openstaand.Name = "Optie_openstaand"
        Me.Optie_openstaand.Size = New System.Drawing.Size(83, 17)
        Me.Optie_openstaand.TabIndex = 0
        Me.Optie_openstaand.TabStop = True
        Me.Optie_openstaand.Text = "Openstaand"
        Me.Optie_openstaand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Optie_openstaand.UseVisualStyleBackColor = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_AdmInkoopboek"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IB_Paid"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Betaald"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IB_Kenmerk"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kenmerk"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SP_Naam"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Crediteur"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IB_WaardeEuro"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Waarde"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IB_Datum"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IB_DueDatum"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vervalt"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'F_AdmInkoopboekLijst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 532)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DG_AdmInkoopLijst)
        Me.Name = "F_AdmInkoopboekLijst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Overzicht inkoopboek"
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmInkoopboekLijstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_AdmInkoopLijst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Administratie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_Administratie As DS_Administratie
    Friend WithEvents AdmInkoopboekLijstBindingSource As BindingSource
    Friend WithEvents AdmInkoopboekLijstTableAdapter As DS_AdministratieTableAdapters.admInkoopboekLijstTableAdapter
    Friend WithEvents TableAdapterManager As DS_AdministratieTableAdapters.TableAdapterManager
    Friend WithEvents DG_AdmInkoopLijst As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OptieBetaald As RadioButton
    Friend WithEvents Optie_openstaand As RadioButton
    Friend WithEvents Knop_Sluiten As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_supplier As ComboBox
    Friend WithEvents Knop_Details As Button
    Friend WithEvents CH_AlleCrediteuren As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_Waarde As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_aantal As TextBox
    Friend WithEvents DS_Administratie1 As DS_Administratie
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DS_AdministratieTableAdapters.SupplierTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class

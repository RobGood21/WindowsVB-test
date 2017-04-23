<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AdmGBrekening
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
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_opslaan = New System.Windows.Forms.Button()
        Me.GB_GBRekening = New System.Windows.Forms.GroupBox()
        Me.DS_Administratie = New WindowsVB_test.DS_Administratie()
        Me.AdmGBrekeningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdmGBrekeningTableAdapter = New WindowsVB_test.DS_AdministratieTableAdapters.AdmGBrekeningTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_AdministratieTableAdapters.TableAdapterManager()
        Me.AdmGBrekeningDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GB_GBRekening.SuspendLayout()
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmGBrekeningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmGBrekeningDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(323, 280)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Nieuw.TabIndex = 56
        Me.Knop_Nieuw.Text = "&Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(404, 280)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 55
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_opslaan
        '
        Me.Knop_opslaan.Location = New System.Drawing.Point(485, 280)
        Me.Knop_opslaan.Name = "Knop_opslaan"
        Me.Knop_opslaan.Size = New System.Drawing.Size(150, 23)
        Me.Knop_opslaan.TabIndex = 54
        Me.Knop_opslaan.Text = "&Opslaan en sluiten"
        Me.Knop_opslaan.UseVisualStyleBackColor = True
        '
        'GB_GBRekening
        '
        Me.GB_GBRekening.Controls.Add(Me.AdmGBrekeningDataGridView)
        Me.GB_GBRekening.Location = New System.Drawing.Point(12, 12)
        Me.GB_GBRekening.Name = "GB_GBRekening"
        Me.GB_GBRekening.Size = New System.Drawing.Size(623, 262)
        Me.GB_GBRekening.TabIndex = 57
        Me.GB_GBRekening.TabStop = False
        '
        'DS_Administratie
        '
        Me.DS_Administratie.DataSetName = "DS_Administratie"
        Me.DS_Administratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdmBoekTableAdapter = Nothing
        Me.TableAdapterManager.AdmGBrekeningTableAdapter = Me.AdmGBrekeningTableAdapter
        Me.TableAdapterManager.AdmJournaalTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_AdministratieTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AdmGBrekeningDataGridView
        '
        Me.AdmGBrekeningDataGridView.AllowUserToDeleteRows = False
        Me.AdmGBrekeningDataGridView.AutoGenerateColumns = False
        Me.AdmGBrekeningDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdmGBrekeningDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.AdmGBrekeningDataGridView.DataSource = Me.AdmGBrekeningBindingSource
        Me.AdmGBrekeningDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.AdmGBrekeningDataGridView.Name = "AdmGBrekeningDataGridView"
        Me.AdmGBrekeningDataGridView.Size = New System.Drawing.Size(602, 220)
        Me.AdmGBrekeningDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Grootboek"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Rekening"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GB_naam"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Naam"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GB_Beschrijving"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Beschrijving"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Beschrijving van de grootboekrekening"
        Me.DataGridViewTextBoxColumn3.Width = 350
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "GB_Activa"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "A/P"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ToolTipText = "Checked is Activa, bezit. Unchecked=Passiva, schuld."
        Me.DataGridViewCheckBoxColumn1.Width = 30
        '
        'F_AdmGBrekening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 325)
        Me.Controls.Add(Me.GB_GBRekening)
        Me.Controls.Add(Me.Knop_Nieuw)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_opslaan)
        Me.Name = "F_AdmGBrekening"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Grootboekrekeningen"
        Me.GB_GBRekening.ResumeLayout(False)
        CType(Me.DS_Administratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmGBrekeningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmGBrekeningDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Knop_opslaan As Button
    Friend WithEvents GB_GBRekening As GroupBox
    Friend WithEvents DS_Administratie As DS_Administratie
    Friend WithEvents AdmGBrekeningBindingSource As BindingSource
    Friend WithEvents AdmGBrekeningTableAdapter As DS_AdministratieTableAdapters.AdmGBrekeningTableAdapter
    Friend WithEvents TableAdapterManager As DS_AdministratieTableAdapters.TableAdapterManager
    Friend WithEvents AdmGBrekeningDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class

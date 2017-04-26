<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Betaalwijzen
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
        Me.DS_Supplier = New WindowsVB_test.DS_Supplier()
        Me.BetaalWijzenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BetaalWijzenTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.BetaalWijzenTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager()
        Me.DG_BetaalWijzen = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Grootboek = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AdmGBrekeningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.AdmGBrekeningTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.AdmGBrekeningTableAdapter()
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BetaalWijzenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_BetaalWijzen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmGBrekeningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_Supplier
        '
        Me.DS_Supplier.DataSetName = "DS_Supplier"
        Me.DS_Supplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BetaalWijzenBindingSource
        '
        Me.BetaalWijzenBindingSource.DataMember = "BetaalWijzen"
        Me.BetaalWijzenBindingSource.DataSource = Me.DS_Supplier
        '
        'BetaalWijzenTableAdapter
        '
        Me.BetaalWijzenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BetaalWijzenTableAdapter = Me.BetaalWijzenTableAdapter
        Me.TableAdapterManager.LandTableAdapter = Nothing
        Me.TableAdapterManager.ShopTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'DG_BetaalWijzen
        '
        Me.DG_BetaalWijzen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_BetaalWijzen.AutoGenerateColumns = False
        Me.DG_BetaalWijzen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_BetaalWijzen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.ID_Grootboek})
        Me.DG_BetaalWijzen.DataSource = Me.BetaalWijzenBindingSource
        Me.DG_BetaalWijzen.Location = New System.Drawing.Point(14, 12)
        Me.DG_BetaalWijzen.Name = "DG_BetaalWijzen"
        Me.DG_BetaalWijzen.Size = New System.Drawing.Size(549, 268)
        Me.DG_BetaalWijzen.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_BetaalWijzen"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BW_Kort"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kort"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BW_Beschrijving"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Beschrijving"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BW_Rekening"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Rekening"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'ID_Grootboek
        '
        Me.ID_Grootboek.DataPropertyName = "ID_Grootboek"
        Me.ID_Grootboek.DataSource = Me.AdmGBrekeningBindingSource
        Me.ID_Grootboek.DisplayMember = "GB_naam"
        Me.ID_Grootboek.HeaderText = "ID_Grootboek"
        Me.ID_Grootboek.Name = "ID_Grootboek"
        Me.ID_Grootboek.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID_Grootboek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ID_Grootboek.ValueMember = "ID_Grootboek"
        Me.ID_Grootboek.Width = 120
        '
        'AdmGBrekeningBindingSource
        '
        Me.AdmGBrekeningBindingSource.DataMember = "AdmGBrekening"
        Me.AdmGBrekeningBindingSource.DataSource = Me.DS_Supplier
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.AutoEllipsis = True
        Me.Knop_Annuleren.Location = New System.Drawing.Point(372, 291)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 5
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.AutoEllipsis = True
        Me.Knop_Sluiten.Location = New System.Drawing.Point(453, 291)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(111, 23)
        Me.Knop_Sluiten.TabIndex = 4
        Me.Knop_Sluiten.Text = "&Opslaan en sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'AdmGBrekeningTableAdapter
        '
        Me.AdmGBrekeningTableAdapter.ClearBeforeFill = True
        '
        'F_Betaalwijzen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 326)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Controls.Add(Me.DG_BetaalWijzen)
        Me.Name = "F_Betaalwijzen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Betaalwijzen"
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BetaalWijzenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_BetaalWijzen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmGBrekeningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_Supplier As DS_Supplier
    Friend WithEvents BetaalWijzenBindingSource As BindingSource
    Friend WithEvents BetaalWijzenTableAdapter As DS_SupplierTableAdapters.BetaalWijzenTableAdapter
    Friend WithEvents TableAdapterManager As DS_SupplierTableAdapters.TableAdapterManager
    Friend WithEvents DG_BetaalWijzen As DataGridView
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Knop_Sluiten As Button
    Friend WithEvents AdmGBrekeningBindingSource As BindingSource
    Friend WithEvents AdmGBrekeningTableAdapter As DS_SupplierTableAdapters.AdmGBrekeningTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ID_Grootboek As DataGridViewComboBoxColumn
End Class

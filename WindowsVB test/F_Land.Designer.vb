<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Land
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
        Me.DS_Supplier = New WindowsVB_test.DS_Supplier()
        Me.LandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LandTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.LandTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager()
        Me.ValutaTableAdapter = New WindowsVB_test.DS_SupplierTableAdapters.ValutaTableAdapter()
        Me.DG_Land = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ValutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Land, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_Supplier
        '
        Me.DS_Supplier.DataSetName = "DS_Supplier"
        Me.DS_Supplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LandBindingSource
        '
        Me.LandBindingSource.DataMember = "Land"
        Me.LandBindingSource.DataSource = Me.DS_Supplier
        '
        'LandTableAdapter
        '
        Me.LandTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BetaalWijzenTableAdapter = Nothing
        Me.TableAdapterManager.LandTableAdapter = Me.LandTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_SupplierTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Me.ValutaTableAdapter
        '
        'ValutaTableAdapter
        '
        Me.ValutaTableAdapter.ClearBeforeFill = True
        '
        'DG_Land
        '
        Me.DG_Land.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Land.AutoGenerateColumns = False
        Me.DG_Land.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Land.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DG_Land.Cursor = System.Windows.Forms.Cursors.Default
        Me.DG_Land.DataSource = Me.LandBindingSource
        Me.DG_Land.Location = New System.Drawing.Point(12, 12)
        Me.DG_Land.Name = "DG_Land"
        Me.DG_Land.Size = New System.Drawing.Size(676, 295)
        Me.DG_Land.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LD_Naam"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Naam"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LD_Short"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Short"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LD_Federatie"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Federatie"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LD_IDCphone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Landnummer"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_Valuta"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.ValutaBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "VT_Short"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valuta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "ID_valuta"
        '
        'ValutaBindingSource
        '
        Me.ValutaBindingSource.DataMember = "Valuta"
        Me.ValutaBindingSource.DataSource = Me.DS_Supplier
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.AutoEllipsis = True
        Me.Knop_Annuleren.Location = New System.Drawing.Point(482, 325)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 5
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.AutoEllipsis = True
        Me.Knop_Sluiten.Location = New System.Drawing.Point(563, 325)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(111, 23)
        Me.Knop_Sluiten.TabIndex = 4
        Me.Knop_Sluiten.Text = "&Opslaan en sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'F_Land
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 360)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Controls.Add(Me.DG_Land)
        Me.Name = "F_Land"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Landen"
        CType(Me.DS_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Land, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_Supplier As DS_Supplier
    Friend WithEvents LandBindingSource As BindingSource
    Friend WithEvents LandTableAdapter As DS_SupplierTableAdapters.LandTableAdapter
    Friend WithEvents TableAdapterManager As DS_SupplierTableAdapters.TableAdapterManager
    Friend WithEvents DG_Land As DataGridView
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Knop_Sluiten As Button
    Friend WithEvents ValutaTableAdapter As DS_SupplierTableAdapters.ValutaTableAdapter
    Friend WithEvents ValutaBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
End Class

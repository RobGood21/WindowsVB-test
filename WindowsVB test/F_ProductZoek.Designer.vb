<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_ProductZoek
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
        Me.TableAdapterManager = New WindowsVB_test.DS_ProjectProductsTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Knop_Sluit = New System.Windows.Forms.Button()
        Me.LBL_Zoektekst = New System.Windows.Forms.Label()
        Me.TXT_Zoektekst = New System.Windows.Forms.TextBox()
        Me.LBL_ProductGroep = New System.Windows.Forms.Label()
        Me.CB_Groep = New System.Windows.Forms.ComboBox()
        Me.GroepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.GroepTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GroepTableAdapter()
        Me.DS_ProjectProducts = New WindowsVB_test.DS_ProjectProducts()
        Me.ZoekLijstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZoeklijstTableAdapter = New WindowsVB_test.DS_ProjectProductsTableAdapters.ZoeklijstTableAdapter()
        Me.DG_products = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ProjectProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoekLijstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProjectProductsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Knop_Sluit)
        Me.GroupBox1.Controls.Add(Me.LBL_Zoektekst)
        Me.GroupBox1.Controls.Add(Me.TXT_Zoektekst)
        Me.GroupBox1.Controls.Add(Me.LBL_ProductGroep)
        Me.GroupBox1.Controls.Add(Me.CB_Groep)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 41)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Knop_Sluit
        '
        Me.Knop_Sluit.Location = New System.Drawing.Point(719, 12)
        Me.Knop_Sluit.Name = "Knop_Sluit"
        Me.Knop_Sluit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Knop_Sluit.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Sluit.TabIndex = 9
        Me.Knop_Sluit.Text = "Sluiten"
        Me.Knop_Sluit.UseVisualStyleBackColor = True
        '
        'LBL_Zoektekst
        '
        Me.LBL_Zoektekst.AutoSize = True
        Me.LBL_Zoektekst.Location = New System.Drawing.Point(248, 19)
        Me.LBL_Zoektekst.Name = "LBL_Zoektekst"
        Me.LBL_Zoektekst.Size = New System.Drawing.Size(58, 13)
        Me.LBL_Zoektekst.TabIndex = 8
        Me.LBL_Zoektekst.Text = "Zoektekst:"
        '
        'TXT_Zoektekst
        '
        Me.TXT_Zoektekst.Location = New System.Drawing.Point(312, 16)
        Me.TXT_Zoektekst.Name = "TXT_Zoektekst"
        Me.TXT_Zoektekst.Size = New System.Drawing.Size(117, 20)
        Me.TXT_Zoektekst.TabIndex = 7
        '
        'LBL_ProductGroep
        '
        Me.LBL_ProductGroep.AutoSize = True
        Me.LBL_ProductGroep.Location = New System.Drawing.Point(6, 18)
        Me.LBL_ProductGroep.Name = "LBL_ProductGroep"
        Me.LBL_ProductGroep.Size = New System.Drawing.Size(74, 13)
        Me.LBL_ProductGroep.TabIndex = 5
        Me.LBL_ProductGroep.Text = "Productgroep:"
        '
        'CB_Groep
        '
        Me.CB_Groep.DataSource = Me.GroepBindingSource
        Me.CB_Groep.DisplayMember = "GP_Naam"
        Me.CB_Groep.FormattingEnabled = True
        Me.CB_Groep.Location = New System.Drawing.Point(83, 15)
        Me.CB_Groep.Name = "CB_Groep"
        Me.CB_Groep.Size = New System.Drawing.Size(156, 21)
        Me.CB_Groep.TabIndex = 4
        Me.CB_Groep.ValueMember = "ID_Groep"
        '
        'GroepBindingSource
        '
        Me.GroepBindingSource.DataMember = "Groep"
        Me.GroepBindingSource.DataSource = Me.DS_Product
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroepTableAdapter
        '
        Me.GroepTableAdapter.ClearBeforeFill = True
        '
        'DS_ProjectProducts
        '
        Me.DS_ProjectProducts.DataSetName = "DS_ProjectProducts"
        Me.DS_ProjectProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZoekLijstBindingSource
        '
        Me.ZoekLijstBindingSource.DataMember = "ZoekLijst"
        Me.ZoekLijstBindingSource.DataSource = Me.DS_ProjectProducts
        '
        'ZoeklijstTableAdapter
        '
        Me.ZoeklijstTableAdapter.ClearBeforeFill = True
        '
        'DG_products
        '
        Me.DG_products.AllowUserToAddRows = False
        Me.DG_products.AllowUserToDeleteRows = False
        Me.DG_products.AutoGenerateColumns = False
        Me.DG_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DG_products.DataSource = Me.ZoekLijstBindingSource
        Me.DG_products.Location = New System.Drawing.Point(12, 59)
        Me.DG_products.MultiSelect = False
        Me.DG_products.Name = "DG_products"
        Me.DG_products.ReadOnly = True
        Me.DG_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_products.Size = New System.Drawing.Size(954, 413)
        Me.DG_products.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Product"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Product"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GP_Naam"
        Me.DataGridViewTextBoxColumn2.HeaderText = "GP_Naam"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MK_MerkNaam"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MK_MerkNaam"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PD_Naam"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PD_Naam"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PD_Waarde"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PD_Waarde"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PD_Voorraad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PD_Voorraad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PD_Functie"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PD_Functie"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PD_Behuizing"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PD_Behuizing"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ID_Groep"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID_Groep"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'F_ProductZoek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 499)
        Me.Controls.Add(Me.DG_products)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_ProductZoek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product opzoeken"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ProjectProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoekLijstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager As DS_ProjectProductsTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBL_ProductGroep As Label
    Friend WithEvents CB_Groep As ComboBox
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents GroepBindingSource As BindingSource
    Friend WithEvents GroepTableAdapter As DS_ProductTableAdapters.GroepTableAdapter
    Friend WithEvents LBL_Zoektekst As Label
    Friend WithEvents TXT_Zoektekst As TextBox
    Friend WithEvents Knop_Sluit As Button
    Friend WithEvents DS_ProjectProducts As DS_ProjectProducts
    Friend WithEvents ZoekLijstBindingSource As BindingSource
    Friend WithEvents ZoeklijstTableAdapter As DS_ProjectProductsTableAdapters.ZoeklijstTableAdapter
    Friend WithEvents DG_products As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class

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
        Me.DS_ProjectProducts = New WindowsVB_test.DS_ProjectProducts()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New WindowsVB_test.DS_ProjectProductsTableAdapters.DataTable1TableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProjectProductsTableAdapters.TableAdapterManager()
        Me.DG_Products = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PD_Functie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PD_Behuizing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Knop_Sluit = New System.Windows.Forms.Button()
        Me.LBL_Zoektekst = New System.Windows.Forms.Label()
        Me.TXT_Zoektekst = New System.Windows.Forms.TextBox()
        Me.LBL_ProductGroep = New System.Windows.Forms.Label()
        Me.CB_Groep = New System.Windows.Forms.ComboBox()
        Me.GroepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.GroepTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GroepTableAdapter()
        CType(Me.DS_ProjectProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_ProjectProducts
        '
        Me.DS_ProjectProducts.DataSetName = "DS_ProjectProducts"
        Me.DS_ProjectProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DS_ProjectProducts
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
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
        'DG_Products
        '
        Me.DG_Products.AllowUserToAddRows = False
        Me.DG_Products.AllowUserToDeleteRows = False
        Me.DG_Products.AllowUserToOrderColumns = True
        Me.DG_Products.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Products.AutoGenerateColumns = False
        Me.DG_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.PD_Functie, Me.DataGridViewTextBoxColumn5, Me.PD_Behuizing, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6})
        Me.DG_Products.DataSource = Me.DataTable1BindingSource
        Me.DG_Products.Location = New System.Drawing.Point(12, 59)
        Me.DG_Products.MultiSelect = False
        Me.DG_Products.Name = "DG_Products"
        Me.DG_Products.ReadOnly = True
        Me.DG_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Products.Size = New System.Drawing.Size(811, 428)
        Me.DG_Products.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Product"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GP_Naam"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Groep"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PD_Naam"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Naam"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'PD_Functie
        '
        Me.PD_Functie.DataPropertyName = "PD_Functie"
        Me.PD_Functie.HeaderText = "Functie"
        Me.PD_Functie.Name = "PD_Functie"
        Me.PD_Functie.ReadOnly = True
        Me.PD_Functie.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PD_Waarde"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Waarde"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'PD_Behuizing
        '
        Me.PD_Behuizing.DataPropertyName = "PD_Behuizing"
        Me.PD_Behuizing.HeaderText = "Behuizing"
        Me.PD_Behuizing.Name = "PD_Behuizing"
        Me.PD_Behuizing.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MK_MerkNaam"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Merk"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PD_Voorraad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Voorraad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
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
        'F_ProductZoek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 499)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DG_Products)
        Me.Name = "F_ProductZoek"
        Me.Text = "Product opzoeken"
        CType(Me.DS_ProjectProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_ProjectProducts As DS_ProjectProducts
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DS_ProjectProductsTableAdapters.DataTable1TableAdapter
    Friend WithEvents TableAdapterManager As DS_ProjectProductsTableAdapters.TableAdapterManager
    Friend WithEvents DG_Products As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBL_ProductGroep As Label
    Friend WithEvents CB_Groep As ComboBox
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents GroepBindingSource As BindingSource
    Friend WithEvents GroepTableAdapter As DS_ProductTableAdapters.GroepTableAdapter
    Friend WithEvents LBL_Zoektekst As Label
    Friend WithEvents TXT_Zoektekst As TextBox
    Friend WithEvents Knop_Sluit As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PD_Functie As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PD_Behuizing As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class

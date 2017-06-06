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
        Me.CH_TXT = New System.Windows.Forms.CheckBox()
        Me.CH_Groep = New System.Windows.Forms.CheckBox()
        Me.Knop_Sluit = New System.Windows.Forms.Button()
        Me.LBL_Zoektekst = New System.Windows.Forms.Label()
        Me.TXT_Zoektekst = New System.Windows.Forms.TextBox()
        Me.LBL_ProductGroep = New System.Windows.Forms.Label()
        Me.CB_Groep = New System.Windows.Forms.ComboBox()
        Me.GroepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.GroepTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GroepTableAdapter()
        Me.ProductZoekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductZoekTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ProductZoekTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_Products = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductZoekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Products, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.CH_TXT)
        Me.GroupBox1.Controls.Add(Me.CH_Groep)
        Me.GroupBox1.Controls.Add(Me.Knop_Sluit)
        Me.GroupBox1.Controls.Add(Me.LBL_Zoektekst)
        Me.GroupBox1.Controls.Add(Me.TXT_Zoektekst)
        Me.GroupBox1.Controls.Add(Me.LBL_ProductGroep)
        Me.GroupBox1.Controls.Add(Me.CB_Groep)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 41)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CH_TXT
        '
        Me.CH_TXT.AutoSize = True
        Me.CH_TXT.Location = New System.Drawing.Point(233, 17)
        Me.CH_TXT.Name = "CH_TXT"
        Me.CH_TXT.Size = New System.Drawing.Size(15, 14)
        Me.CH_TXT.TabIndex = 11
        Me.CH_TXT.UseVisualStyleBackColor = True
        '
        'CH_Groep
        '
        Me.CH_Groep.AutoSize = True
        Me.CH_Groep.Location = New System.Drawing.Point(7, 17)
        Me.CH_Groep.Name = "CH_Groep"
        Me.CH_Groep.Size = New System.Drawing.Size(15, 14)
        Me.CH_Groep.TabIndex = 10
        Me.CH_Groep.UseVisualStyleBackColor = True
        '
        'Knop_Sluit
        '
        Me.Knop_Sluit.Location = New System.Drawing.Point(560, 14)
        Me.Knop_Sluit.Name = "Knop_Sluit"
        Me.Knop_Sluit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Knop_Sluit.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Sluit.TabIndex = 4
        Me.Knop_Sluit.Text = "&Sluiten"
        Me.Knop_Sluit.UseVisualStyleBackColor = True
        '
        'LBL_Zoektekst
        '
        Me.LBL_Zoektekst.AutoSize = True
        Me.LBL_Zoektekst.Location = New System.Drawing.Point(248, 18)
        Me.LBL_Zoektekst.Name = "LBL_Zoektekst"
        Me.LBL_Zoektekst.Size = New System.Drawing.Size(58, 13)
        Me.LBL_Zoektekst.TabIndex = 8
        Me.LBL_Zoektekst.Text = "Zoektekst:"
        '
        'TXT_Zoektekst
        '
        Me.TXT_Zoektekst.Location = New System.Drawing.Point(312, 14)
        Me.TXT_Zoektekst.Name = "TXT_Zoektekst"
        Me.TXT_Zoektekst.Size = New System.Drawing.Size(66, 20)
        Me.TXT_Zoektekst.TabIndex = 1
        '
        'LBL_ProductGroep
        '
        Me.LBL_ProductGroep.AutoSize = True
        Me.LBL_ProductGroep.Location = New System.Drawing.Point(20, 18)
        Me.LBL_ProductGroep.Name = "LBL_ProductGroep"
        Me.LBL_ProductGroep.Size = New System.Drawing.Size(74, 13)
        Me.LBL_ProductGroep.TabIndex = 5
        Me.LBL_ProductGroep.Text = "Productgroep:"
        '
        'CB_Groep
        '
        Me.CB_Groep.DataSource = Me.GroepBindingSource
        Me.CB_Groep.DisplayMember = "GP_Naam"
        Me.CB_Groep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Groep.FormattingEnabled = True
        Me.CB_Groep.Location = New System.Drawing.Point(97, 14)
        Me.CB_Groep.Name = "CB_Groep"
        Me.CB_Groep.Size = New System.Drawing.Size(98, 21)
        Me.CB_Groep.TabIndex = 0
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
        'ProductZoekBindingSource
        '
        Me.ProductZoekBindingSource.DataMember = "ProductZoek"
        Me.ProductZoekBindingSource.DataSource = Me.DS_Product
        '
        'ProductZoekTableAdapter
        '
        Me.ProductZoekTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Product"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Product"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DG_Products
        '
        Me.DG_Products.AllowUserToAddRows = False
        Me.DG_Products.AllowUserToDeleteRows = False
        Me.DG_Products.AutoGenerateColumns = False
        Me.DG_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DG_Products.DataSource = Me.ProductZoekBindingSource
        Me.DG_Products.Location = New System.Drawing.Point(12, 59)
        Me.DG_Products.MultiSelect = False
        Me.DG_Products.Name = "DG_Products"
        Me.DG_Products.ReadOnly = True
        Me.DG_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Products.Size = New System.Drawing.Size(641, 380)
        Me.DG_Products.TabIndex = 3
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Product"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Groep"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Groep"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PD_Beschrijving(2)"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 470
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PD_Voorraad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Voorraad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'F_ProductZoek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 451)
        Me.Controls.Add(Me.DG_Products)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_ProductZoek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product opzoeken"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductZoekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Products, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProductZoekBindingSource As BindingSource
    Friend WithEvents ProductZoekTableAdapter As DS_ProductTableAdapters.ProductZoekTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DG_Products As DataGridView
    Friend WithEvents CH_Groep As CheckBox
    Friend WithEvents CH_TXT As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class

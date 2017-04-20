<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_GetOrder
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
        Dim ID_GetOrderLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_GetOrder))
        Me.GB_Supplier = New System.Windows.Forms.GroupBox()
        Me.Knop_DetailsShop = New System.Windows.Forms.Button()
        Me.CB_Shop = New System.Windows.Forms.ComboBox()
        Me.GetOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.CB_Leverancier = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GB_Products = New System.Windows.Forms.GroupBox()
        Me.GB_Advice = New System.Windows.Forms.GroupBox()
        Me.GetOrderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GetOrderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_GetOrderTextBox = New System.Windows.Forms.TextBox()
        Me.CB_Orders = New System.Windows.Forms.ComboBox()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.Knop_nieuw = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.SupplierTableAdapter()
        Me.DS_Product1 = New WindowsVB_test.DS_Product()
        Me.ShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ShopTableAdapter()
        ID_GetOrderLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GB_Supplier.SuspendLayout()
        CType(Me.GetOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetOrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GetOrderBindingNavigator.SuspendLayout()
        CType(Me.DS_Product1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_GetOrderLabel
        '
        ID_GetOrderLabel.AutoSize = True
        ID_GetOrderLabel.Location = New System.Drawing.Point(568, 31)
        ID_GetOrderLabel.Name = "ID_GetOrderLabel"
        ID_GetOrderLabel.Size = New System.Drawing.Size(70, 13)
        ID_GetOrderLabel.TabIndex = 4
        ID_GetOrderLabel.Text = "ID Get Order:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 44)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 13)
        Label1.TabIndex = 7
        Label1.Text = "Open orders:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(16, 33)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 13)
        Label2.TabIndex = 5
        Label2.Text = "Leverancier:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 55)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 13)
        Label3.TabIndex = 7
        Label3.Text = "Shop:"
        '
        'GB_Supplier
        '
        Me.GB_Supplier.Controls.Add(Me.Knop_DetailsShop)
        Me.GB_Supplier.Controls.Add(Label3)
        Me.GB_Supplier.Controls.Add(Me.CB_Shop)
        Me.GB_Supplier.Controls.Add(Label2)
        Me.GB_Supplier.Controls.Add(Me.CB_Leverancier)
        Me.GB_Supplier.Location = New System.Drawing.Point(12, 83)
        Me.GB_Supplier.Name = "GB_Supplier"
        Me.GB_Supplier.Size = New System.Drawing.Size(646, 145)
        Me.GB_Supplier.TabIndex = 0
        Me.GB_Supplier.TabStop = False
        Me.GB_Supplier.Text = "Leverancier bij wie je gaat bestellen"
        '
        'Knop_DetailsShop
        '
        Me.Knop_DetailsShop.Location = New System.Drawing.Point(299, 52)
        Me.Knop_DetailsShop.Name = "Knop_DetailsShop"
        Me.Knop_DetailsShop.Size = New System.Drawing.Size(75, 23)
        Me.Knop_DetailsShop.TabIndex = 8
        Me.Knop_DetailsShop.Text = "details"
        Me.Knop_DetailsShop.UseVisualStyleBackColor = True
        '
        'CB_Shop
        '
        Me.CB_Shop.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GetOrderBindingSource, "ID_Supplier", True))
        Me.CB_Shop.DataSource = Me.ShopBindingSource
        Me.CB_Shop.DisplayMember = "SH_Naam"
        Me.CB_Shop.FormattingEnabled = True
        Me.CB_Shop.Location = New System.Drawing.Point(86, 52)
        Me.CB_Shop.Name = "CB_Shop"
        Me.CB_Shop.Size = New System.Drawing.Size(207, 21)
        Me.CB_Shop.TabIndex = 6
        Me.CB_Shop.ValueMember = "ID_Shop"
        '
        'GetOrderBindingSource
        '
        Me.GetOrderBindingSource.DataMember = "GetOrder"
        Me.GetOrderBindingSource.DataSource = Me.DS_Product
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CB_Leverancier
        '
        Me.CB_Leverancier.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GetOrderBindingSource, "ID_Supplier", True))
        Me.CB_Leverancier.DataSource = Me.SupplierBindingSource
        Me.CB_Leverancier.DisplayMember = "SP_Naam"
        Me.CB_Leverancier.FormattingEnabled = True
        Me.CB_Leverancier.Location = New System.Drawing.Point(86, 30)
        Me.CB_Leverancier.Name = "CB_Leverancier"
        Me.CB_Leverancier.Size = New System.Drawing.Size(207, 21)
        Me.CB_Leverancier.TabIndex = 0
        Me.CB_Leverancier.ValueMember = "ID_Supplier"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DS_Product
        '
        'GB_Products
        '
        Me.GB_Products.Location = New System.Drawing.Point(12, 275)
        Me.GB_Products.Name = "GB_Products"
        Me.GB_Products.Size = New System.Drawing.Size(646, 100)
        Me.GB_Products.TabIndex = 1
        Me.GB_Products.TabStop = False
        Me.GB_Products.Text = "De artikelen die besteld zijn(Worden)"
        '
        'GB_Advice
        '
        Me.GB_Advice.Location = New System.Drawing.Point(12, 407)
        Me.GB_Advice.Name = "GB_Advice"
        Me.GB_Advice.Size = New System.Drawing.Size(646, 100)
        Me.GB_Advice.TabIndex = 2
        Me.GB_Advice.TabStop = False
        Me.GB_Advice.Text = "Producten met besteladvies (minimum te laag)"
        '
        'GetOrderBindingNavigator
        '
        Me.GetOrderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GetOrderBindingNavigator.BindingSource = Me.GetOrderBindingSource
        Me.GetOrderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GetOrderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GetOrderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GetOrderBindingNavigatorSaveItem})
        Me.GetOrderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GetOrderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GetOrderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GetOrderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GetOrderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GetOrderBindingNavigator.Name = "GetOrderBindingNavigator"
        Me.GetOrderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GetOrderBindingNavigator.Size = New System.Drawing.Size(798, 25)
        Me.GetOrderBindingNavigator.TabIndex = 3
        Me.GetOrderBindingNavigator.Text = "BindingNavigator1"
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
        'GetOrderBindingNavigatorSaveItem
        '
        Me.GetOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GetOrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("GetOrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GetOrderBindingNavigatorSaveItem.Name = "GetOrderBindingNavigatorSaveItem"
        Me.GetOrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GetOrderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_GetOrderTextBox
        '
        Me.ID_GetOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetOrderBindingSource, "ID_GetOrder", True))
        Me.ID_GetOrderTextBox.Location = New System.Drawing.Point(644, 28)
        Me.ID_GetOrderTextBox.Name = "ID_GetOrderTextBox"
        Me.ID_GetOrderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_GetOrderTextBox.TabIndex = 5
        '
        'CB_Orders
        '
        Me.CB_Orders.FormattingEnabled = True
        Me.CB_Orders.Location = New System.Drawing.Point(88, 41)
        Me.CB_Orders.Name = "CB_Orders"
        Me.CB_Orders.Size = New System.Drawing.Size(217, 21)
        Me.CB_Orders.TabIndex = 6
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DT_productTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.DT_productTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(680, 484)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Sluiten.TabIndex = 8
        Me.Knop_Sluiten.Text = "Sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'Knop_nieuw
        '
        Me.Knop_nieuw.Location = New System.Drawing.Point(680, 83)
        Me.Knop_nieuw.Name = "Knop_nieuw"
        Me.Knop_nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_nieuw.TabIndex = 9
        Me.Knop_nieuw.Text = "&Nieuw"
        Me.Knop_nieuw.UseVisualStyleBackColor = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'DS_Product1
        '
        Me.DS_Product1.DataSetName = "DS_Product"
        Me.DS_Product1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShopBindingSource
        '
        Me.ShopBindingSource.DataMember = "Shop"
        Me.ShopBindingSource.DataSource = Me.DS_Product1
        '
        'ShopTableAdapter
        '
        Me.ShopTableAdapter.ClearBeforeFill = True
        '
        'F_GetOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 560)
        Me.Controls.Add(Me.Knop_nieuw)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.CB_Orders)
        Me.Controls.Add(ID_GetOrderLabel)
        Me.Controls.Add(Me.ID_GetOrderTextBox)
        Me.Controls.Add(Me.GetOrderBindingNavigator)
        Me.Controls.Add(Me.GB_Advice)
        Me.Controls.Add(Me.GB_Products)
        Me.Controls.Add(Me.GB_Supplier)
        Me.Name = "F_GetOrder"
        Me.Text = "Bestelling maken."
        Me.GB_Supplier.ResumeLayout(False)
        Me.GB_Supplier.PerformLayout()
        CType(Me.GetOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetOrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GetOrderBindingNavigator.ResumeLayout(False)
        Me.GetOrderBindingNavigator.PerformLayout()
        CType(Me.DS_Product1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Supplier As GroupBox
    Friend WithEvents GB_Products As GroupBox
    Friend WithEvents GB_Advice As GroupBox
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents GetOrderBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents GetOrderBindingNavigator As BindingNavigator
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
    Friend WithEvents GetOrderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_GetOrderTextBox As TextBox
    Friend WithEvents CB_Orders As ComboBox
    Friend WithEvents Knop_Sluiten As Button
    Friend WithEvents Knop_nieuw As Button
    Friend WithEvents CB_Leverancier As ComboBox
    Friend WithEvents CB_Shop As ComboBox
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DS_ProductTableAdapters.SupplierTableAdapter
    Friend WithEvents Knop_DetailsShop As Button
    Friend WithEvents DS_Product1 As DS_Product
    Friend WithEvents ShopBindingSource As BindingSource
    Friend WithEvents ShopTableAdapter As DS_ProductTableAdapters.ShopTableAdapter
End Class

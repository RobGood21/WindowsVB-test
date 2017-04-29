<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_GetProductAdd
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
        Dim ID_GetProductAddLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_GetProductAdd))
        Me.TXT_Container = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Lijstaantal = New System.Windows.Forms.TextBox()
        Me.GetProductAddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.Knop_Details = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_ProductBeschrijving = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_ProductID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.Knop_NieuwProduct = New System.Windows.Forms.Button()
        Me.TXT_IDGetProduct = New System.Windows.Forms.TextBox()
        Me.GetProductAddBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GetProductAddBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_GetProductAddTextBox = New System.Windows.Forms.TextBox()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.GetProductAddTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GetProductAddTableAdapter()
        ID_GetProductAddLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GetProductAddBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GetProductAddBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_GetProductAddLabel
        '
        ID_GetProductAddLabel.AutoSize = True
        ID_GetProductAddLabel.Location = New System.Drawing.Point(20, 479)
        ID_GetProductAddLabel.Name = "ID_GetProductAddLabel"
        ID_GetProductAddLabel.Size = New System.Drawing.Size(103, 13)
        ID_GetProductAddLabel.TabIndex = 10
        ID_GetProductAddLabel.Text = "ID Get Product Add:"
        '
        'TXT_Container
        '
        Me.TXT_Container.Location = New System.Drawing.Point(99, 55)
        Me.TXT_Container.Name = "TXT_Container"
        Me.TXT_Container.Size = New System.Drawing.Size(238, 20)
        Me.TXT_Container.TabIndex = 0
        Me.TXT_Container.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Container naam:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_Lijstaantal)
        Me.GroupBox1.Controls.Add(Me.Knop_Details)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_ProductBeschrijving)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_ProductID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Toe te voegen producten"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Aantal:"
        '
        'TXT_Lijstaantal
        '
        Me.TXT_Lijstaantal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "GP_Lijst", True))
        Me.TXT_Lijstaantal.Location = New System.Drawing.Point(100, 92)
        Me.TXT_Lijstaantal.Name = "TXT_Lijstaantal"
        Me.TXT_Lijstaantal.Size = New System.Drawing.Size(238, 20)
        Me.TXT_Lijstaantal.TabIndex = 1
        '
        'GetProductAddBindingSource
        '
        Me.GetProductAddBindingSource.DataMember = "GetProductAdd"
        Me.GetProductAddBindingSource.DataSource = Me.DS_Product
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Knop_Details
        '
        Me.Knop_Details.Location = New System.Drawing.Point(344, 17)
        Me.Knop_Details.Name = "Knop_Details"
        Me.Knop_Details.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Details.TabIndex = 6
        Me.Knop_Details.Text = "Details"
        Me.Knop_Details.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product:"
        '
        'TXT_ProductBeschrijving
        '
        Me.TXT_ProductBeschrijving.Location = New System.Drawing.Point(100, 45)
        Me.TXT_ProductBeschrijving.Multiline = True
        Me.TXT_ProductBeschrijving.Name = "TXT_ProductBeschrijving"
        Me.TXT_ProductBeschrijving.Size = New System.Drawing.Size(238, 41)
        Me.TXT_ProductBeschrijving.TabIndex = 4
        Me.TXT_ProductBeschrijving.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product nummer:"
        '
        'TXT_ProductID
        '
        Me.TXT_ProductID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "ID_Product", True))
        Me.TXT_ProductID.Location = New System.Drawing.Point(100, 19)
        Me.TXT_ProductID.Name = "TXT_ProductID"
        Me.TXT_ProductID.Size = New System.Drawing.Size(238, 20)
        Me.TXT_ProductID.TabIndex = 2
        Me.TXT_ProductID.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 309)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 150)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optioneel in te vullen"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Inkoop Euro:"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "GP_BuyPriceEUR", True))
        Me.TextBox4.Location = New System.Drawing.Point(113, 61)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(83, 20)
        Me.TextBox4.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Valuta:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(268, 35)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(83, 20)
        Me.TextBox3.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Inkoop:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "GP_BuyPriceVAL", True))
        Me.TextBox2.Location = New System.Drawing.Point(113, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(83, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(339, 465)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(111, 23)
        Me.Knop_Opslaan.TabIndex = 7
        Me.Knop_Opslaan.Text = "&Opslaan en sluiten "
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'Knop_NieuwProduct
        '
        Me.Knop_NieuwProduct.Location = New System.Drawing.Point(12, 105)
        Me.Knop_NieuwProduct.Name = "Knop_NieuwProduct"
        Me.Knop_NieuwProduct.Size = New System.Drawing.Size(103, 23)
        Me.Knop_NieuwProduct.TabIndex = 8
        Me.Knop_NieuwProduct.Text = "&Nieuw product"
        Me.Knop_NieuwProduct.UseVisualStyleBackColor = True
        '
        'TXT_IDGetProduct
        '
        Me.TXT_IDGetProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "ID_GetOntvangst", True))
        Me.TXT_IDGetProduct.Location = New System.Drawing.Point(430, 51)
        Me.TXT_IDGetProduct.Name = "TXT_IDGetProduct"
        Me.TXT_IDGetProduct.Size = New System.Drawing.Size(40, 20)
        Me.TXT_IDGetProduct.TabIndex = 9
        Me.TXT_IDGetProduct.TabStop = False
        '
        'GetProductAddBindingNavigator
        '
        Me.GetProductAddBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GetProductAddBindingNavigator.BindingSource = Me.GetProductAddBindingSource
        Me.GetProductAddBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GetProductAddBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GetProductAddBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GetProductAddBindingNavigatorSaveItem})
        Me.GetProductAddBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GetProductAddBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GetProductAddBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GetProductAddBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GetProductAddBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GetProductAddBindingNavigator.Name = "GetProductAddBindingNavigator"
        Me.GetProductAddBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GetProductAddBindingNavigator.Size = New System.Drawing.Size(490, 25)
        Me.GetProductAddBindingNavigator.TabIndex = 10
        Me.GetProductAddBindingNavigator.Text = "BindingNavigator1"
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
        'GetProductAddBindingNavigatorSaveItem
        '
        Me.GetProductAddBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GetProductAddBindingNavigatorSaveItem.Image = CType(resources.GetObject("GetProductAddBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GetProductAddBindingNavigatorSaveItem.Name = "GetProductAddBindingNavigatorSaveItem"
        Me.GetProductAddBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GetProductAddBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_GetProductAddTextBox
        '
        Me.ID_GetProductAddTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetProductAddBindingSource, "ID_GetProductAdd", True))
        Me.ID_GetProductAddTextBox.Location = New System.Drawing.Point(128, 476)
        Me.ID_GetProductAddTextBox.Name = "ID_GetProductAddTextBox"
        Me.ID_GetProductAddTextBox.Size = New System.Drawing.Size(83, 20)
        Me.ID_GetProductAddTextBox.TabIndex = 11
        Me.ID_GetProductAddTextBox.TabStop = False
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(222, 465)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(74, 23)
        Me.Knop_Annuleren.TabIndex = 12
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DT_productTableAdapter = Nothing
        Me.TableAdapterManager.GetOntvangstTableAdapter = Nothing
        Me.TableAdapterManager.GetProductAddTableAdapter = Nothing
        Me.TableAdapterManager.GPA_AantalTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GetProductAddTableAdapter
        '
        Me.GetProductAddTableAdapter.ClearBeforeFill = True
        '
        'F_GetProductAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 512)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(ID_GetProductAddLabel)
        Me.Controls.Add(Me.ID_GetProductAddTextBox)
        Me.Controls.Add(Me.GetProductAddBindingNavigator)
        Me.Controls.Add(Me.TXT_IDGetProduct)
        Me.Controls.Add(Me.Knop_NieuwProduct)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Container)
        Me.Name = "F_GetProductAdd"
        Me.Text = "Producten toevoegen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GetProductAddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GetProductAddBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GetProductAddBindingNavigator.ResumeLayout(False)
        Me.GetProductAddBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Container As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_ProductBeschrijving As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_ProductID As TextBox
    Friend WithEvents Knop_Details As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Lijstaantal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents Knop_NieuwProduct As Button
    Friend WithEvents TXT_IDGetProduct As TextBox
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents GetProductAddBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents GetProductAddBindingNavigator As BindingNavigator
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
    Friend WithEvents GetProductAddBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_GetProductAddTextBox As TextBox
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GetProductAddTableAdapter As DS_ProductTableAdapters.GetProductAddTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Groep
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
        Dim GP_NaamLabel As System.Windows.Forms.Label
        Dim GP_BeschrijvingLabel As System.Windows.Forms.Label
        Dim GP_KenmerkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Groep))
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.GroepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroepTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GroepTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.GroepBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GroepBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_GroepTextBox = New System.Windows.Forms.TextBox()
        Me.LB_Groep = New System.Windows.Forms.ListBox()
        Me.GP_NaamTextBox = New System.Windows.Forms.TextBox()
        Me.GP_BeschrijvingTextBox = New System.Windows.Forms.TextBox()
        Me.GP_KenmerkTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        GP_NaamLabel = New System.Windows.Forms.Label()
        GP_BeschrijvingLabel = New System.Windows.Forms.Label()
        GP_KenmerkLabel = New System.Windows.Forms.Label()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroepBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroepBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GP_NaamLabel
        '
        GP_NaamLabel.AutoSize = True
        GP_NaamLabel.Location = New System.Drawing.Point(32, 48)
        GP_NaamLabel.Name = "GP_NaamLabel"
        GP_NaamLabel.Size = New System.Drawing.Size(38, 13)
        GP_NaamLabel.TabIndex = 4
        GP_NaamLabel.Text = "Naam:"
        '
        'GP_BeschrijvingLabel
        '
        GP_BeschrijvingLabel.AutoSize = True
        GP_BeschrijvingLabel.Location = New System.Drawing.Point(3, 130)
        GP_BeschrijvingLabel.Name = "GP_BeschrijvingLabel"
        GP_BeschrijvingLabel.Size = New System.Drawing.Size(67, 13)
        GP_BeschrijvingLabel.TabIndex = 6
        GP_BeschrijvingLabel.Text = "Beschrijving:"
        '
        'GP_KenmerkLabel
        '
        GP_KenmerkLabel.AutoSize = True
        GP_KenmerkLabel.Location = New System.Drawing.Point(18, 75)
        GP_KenmerkLabel.Name = "GP_KenmerkLabel"
        GP_KenmerkLabel.Size = New System.Drawing.Size(52, 13)
        GP_KenmerkLabel.TabIndex = 8
        GP_KenmerkLabel.Text = "Kenmerk:"
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroepBindingSource
        '
        Me.GroepBindingSource.DataMember = "Groep"
        Me.GroepBindingSource.DataSource = Me.DS_Product
        '
        'GroepTableAdapter
        '
        Me.GroepTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DT_productTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Me.GroepTableAdapter
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroepBindingNavigator
        '
        Me.GroepBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GroepBindingNavigator.BindingSource = Me.GroepBindingSource
        Me.GroepBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GroepBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GroepBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GroepBindingNavigatorSaveItem})
        Me.GroepBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GroepBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GroepBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GroepBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GroepBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GroepBindingNavigator.Name = "GroepBindingNavigator"
        Me.GroepBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GroepBindingNavigator.Size = New System.Drawing.Size(502, 25)
        Me.GroepBindingNavigator.TabIndex = 0
        Me.GroepBindingNavigator.Text = "BindingNavigator1"
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
        'GroepBindingNavigatorSaveItem
        '
        Me.GroepBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GroepBindingNavigatorSaveItem.Image = CType(resources.GetObject("GroepBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GroepBindingNavigatorSaveItem.Name = "GroepBindingNavigatorSaveItem"
        Me.GroepBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GroepBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_GroepTextBox
        '
        Me.ID_GroepTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "ID_Groep", True))
        Me.ID_GroepTextBox.Enabled = False
        Me.ID_GroepTextBox.Location = New System.Drawing.Point(224, 19)
        Me.ID_GroepTextBox.Name = "ID_GroepTextBox"
        Me.ID_GroepTextBox.ReadOnly = True
        Me.ID_GroepTextBox.Size = New System.Drawing.Size(44, 20)
        Me.ID_GroepTextBox.TabIndex = 2
        Me.ID_GroepTextBox.TabStop = False
        Me.ID_GroepTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LB_Groep
        '
        Me.LB_Groep.DataSource = Me.GroepBindingSource
        Me.LB_Groep.DisplayMember = "GP_Naam"
        Me.LB_Groep.FormattingEnabled = True
        Me.LB_Groep.Location = New System.Drawing.Point(32, 68)
        Me.LB_Groep.Name = "LB_Groep"
        Me.LB_Groep.Size = New System.Drawing.Size(153, 277)
        Me.LB_Groep.TabIndex = 0
        '
        'GP_NaamTextBox
        '
        Me.GP_NaamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "GP_Naam", True))
        Me.GP_NaamTextBox.Location = New System.Drawing.Point(76, 45)
        Me.GP_NaamTextBox.Name = "GP_NaamTextBox"
        Me.GP_NaamTextBox.Size = New System.Drawing.Size(192, 20)
        Me.GP_NaamTextBox.TabIndex = 5
        '
        'GP_BeschrijvingTextBox
        '
        Me.GP_BeschrijvingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "GP_Beschrijving", True))
        Me.GP_BeschrijvingTextBox.Location = New System.Drawing.Point(76, 127)
        Me.GP_BeschrijvingTextBox.Multiline = True
        Me.GP_BeschrijvingTextBox.Name = "GP_BeschrijvingTextBox"
        Me.GP_BeschrijvingTextBox.Size = New System.Drawing.Size(192, 83)
        Me.GP_BeschrijvingTextBox.TabIndex = 7
        '
        'GP_KenmerkTextBox
        '
        Me.GP_KenmerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "GP_Kenmerk", True))
        Me.GP_KenmerkTextBox.Location = New System.Drawing.Point(76, 72)
        Me.GP_KenmerkTextBox.Multiline = True
        Me.GP_KenmerkTextBox.Name = "GP_KenmerkTextBox"
        Me.GP_KenmerkTextBox.Size = New System.Drawing.Size(192, 49)
        Me.GP_KenmerkTextBox.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ID_GroepTextBox)
        Me.GroupBox1.Controls.Add(GP_KenmerkLabel)
        Me.GroupBox1.Controls.Add(Me.GP_KenmerkTextBox)
        Me.GroupBox1.Controls.Add(Me.GP_NaamTextBox)
        Me.GroupBox1.Controls.Add(GP_BeschrijvingLabel)
        Me.GroupBox1.Controls.Add(GP_NaamLabel)
        Me.GroupBox1.Controls.Add(Me.GP_BeschrijvingTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(207, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 235)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(370, 321)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(120, 23)
        Me.Knop_Opslaan.TabIndex = 11
        Me.Knop_Opslaan.Text = "Opslaan en sluiten"
        Me.Knop_Opslaan.UseCompatibleTextRendering = True
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(289, 321)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 12
        Me.Knop_Annuleren.Text = "Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'F_Groep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 374)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LB_Groep)
        Me.Controls.Add(Me.GroepBindingNavigator)
        Me.Name = "F_Groep"
        Me.Text = "Product groepen"
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroepBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroepBindingNavigator.ResumeLayout(False)
        Me.GroepBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents GroepBindingSource As BindingSource
    Friend WithEvents GroepTableAdapter As DS_ProductTableAdapters.GroepTableAdapter
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents GroepBindingNavigator As BindingNavigator
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
    Friend WithEvents GroepBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_GroepTextBox As TextBox
    Friend WithEvents LB_Groep As ListBox
    Friend WithEvents GP_NaamTextBox As TextBox
    Friend WithEvents GP_BeschrijvingTextBox As TextBox
    Friend WithEvents GP_KenmerkTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents Knop_Annuleren As Button
End Class

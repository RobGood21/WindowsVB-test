<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoerGebruiker
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
        Dim AP_IDLabel As System.Windows.Forms.Label
        Dim AP_TypeLabel As System.Windows.Forms.Label
        Dim GB_IDLabel As System.Windows.Forms.Label
        Dim AP_MerkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoerGebruiker))
        Me.Apparaat1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Apparaat1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AP_IDTextBox = New System.Windows.Forms.TextBox()
        Me.AP_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.GB_IDTextBox = New System.Windows.Forms.TextBox()
        Me.AP_MerkTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_Invoer = New System.Windows.Forms.TextBox()
        Me.Knop_PLaats = New System.Windows.Forms.Button()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        Me.BS_AP_Invoer = New System.Windows.Forms.BindingSource(Me.components)
        Me.OefenDbDataSet = New OefenApp.OefenDbDataSet()
        Me.TA_Invoer = New OefenApp.OefenDbDataSetTableAdapters.TA_Invoer()
        Me.TableAdapterManager = New OefenApp.OefenDbDataSetTableAdapters.TableAdapterManager()
        Me.ApparaatTableAdapter = New OefenApp.OefenDbDataSetTableAdapters.ApparaatTableAdapter()
        Me.GebruikerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GebruikerTableAdapter = New OefenApp.OefenDbDataSetTableAdapters.GebruikerTableAdapter()
        Me.OefenDbDataSet1 = New OefenApp.OefenDbDataSet()
        Me.OefenDbDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GebruikerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXT_output = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        AP_IDLabel = New System.Windows.Forms.Label()
        AP_TypeLabel = New System.Windows.Forms.Label()
        GB_IDLabel = New System.Windows.Forms.Label()
        AP_MerkLabel = New System.Windows.Forms.Label()
        CType(Me.Apparaat1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Apparaat1BindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BS_AP_Invoer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OefenDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GebruikerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OefenDbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OefenDbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GebruikerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AP_IDLabel
        '
        AP_IDLabel.AutoSize = True
        AP_IDLabel.Location = New System.Drawing.Point(28, 35)
        AP_IDLabel.Name = "AP_IDLabel"
        AP_IDLabel.Size = New System.Drawing.Size(38, 13)
        AP_IDLabel.TabIndex = 2
        AP_IDLabel.Text = "AP ID:"
        '
        'AP_TypeLabel
        '
        AP_TypeLabel.AutoSize = True
        AP_TypeLabel.Location = New System.Drawing.Point(15, 61)
        AP_TypeLabel.Name = "AP_TypeLabel"
        AP_TypeLabel.Size = New System.Drawing.Size(51, 13)
        AP_TypeLabel.TabIndex = 4
        AP_TypeLabel.Text = "AP Type:"
        '
        'GB_IDLabel
        '
        GB_IDLabel.AutoSize = True
        GB_IDLabel.Location = New System.Drawing.Point(27, 113)
        GB_IDLabel.Name = "GB_IDLabel"
        GB_IDLabel.Size = New System.Drawing.Size(39, 13)
        GB_IDLabel.TabIndex = 6
        GB_IDLabel.Text = "GB ID:"
        '
        'AP_MerkLabel
        '
        AP_MerkLabel.AutoSize = True
        AP_MerkLabel.Location = New System.Drawing.Point(15, 87)
        AP_MerkLabel.Name = "AP_MerkLabel"
        AP_MerkLabel.Size = New System.Drawing.Size(51, 13)
        AP_MerkLabel.TabIndex = 8
        AP_MerkLabel.Text = "AP Merk:"
        '
        'Apparaat1BindingNavigator
        '
        Me.Apparaat1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Apparaat1BindingNavigator.BindingSource = Me.BS_AP_Invoer
        Me.Apparaat1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Apparaat1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Apparaat1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Apparaat1BindingNavigatorSaveItem})
        Me.Apparaat1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Apparaat1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Apparaat1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Apparaat1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Apparaat1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Apparaat1BindingNavigator.Name = "Apparaat1BindingNavigator"
        Me.Apparaat1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Apparaat1BindingNavigator.Size = New System.Drawing.Size(571, 25)
        Me.Apparaat1BindingNavigator.TabIndex = 0
        Me.Apparaat1BindingNavigator.Text = "BindingNavigator1"
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
        'Apparaat1BindingNavigatorSaveItem
        '
        Me.Apparaat1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Apparaat1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Apparaat1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Apparaat1BindingNavigatorSaveItem.Name = "Apparaat1BindingNavigatorSaveItem"
        Me.Apparaat1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Apparaat1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'AP_IDTextBox
        '
        Me.AP_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_AP_Invoer, "AP_ID", True))
        Me.AP_IDTextBox.Location = New System.Drawing.Point(72, 32)
        Me.AP_IDTextBox.Name = "AP_IDTextBox"
        Me.AP_IDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AP_IDTextBox.TabIndex = 1
        '
        'AP_TypeTextBox
        '
        Me.AP_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_AP_Invoer, "AP_Type", True))
        Me.AP_TypeTextBox.Location = New System.Drawing.Point(72, 58)
        Me.AP_TypeTextBox.Name = "AP_TypeTextBox"
        Me.AP_TypeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AP_TypeTextBox.TabIndex = 2
        '
        'GB_IDTextBox
        '
        Me.GB_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_AP_Invoer, "GB_ID", True))
        Me.GB_IDTextBox.Location = New System.Drawing.Point(208, 355)
        Me.GB_IDTextBox.Name = "GB_IDTextBox"
        Me.GB_IDTextBox.Size = New System.Drawing.Size(158, 20)
        Me.GB_IDTextBox.TabIndex = 4
        '
        'AP_MerkTextBox
        '
        Me.AP_MerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_AP_Invoer, "AP_Merk", True))
        Me.AP_MerkTextBox.Location = New System.Drawing.Point(72, 84)
        Me.AP_MerkTextBox.Name = "AP_MerkTextBox"
        Me.AP_MerkTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AP_MerkTextBox.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_AP_Invoer, "GB_ID", True))
        Me.ComboBox1.DataSource = Me.GebruikerBindingSource
        Me.ComboBox1.DisplayMember = "Naam"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(72, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AP_TypeTextBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.AP_IDTextBox)
        Me.GroupBox1.Controls.Add(AP_MerkLabel)
        Me.GroupBox1.Controls.Add(AP_IDLabel)
        Me.GroupBox1.Controls.Add(Me.AP_MerkTextBox)
        Me.GroupBox1.Controls.Add(AP_TypeLabel)
        Me.GroupBox1.Controls.Add(GB_IDLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 178)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TXT_Invoer
        '
        Me.TXT_Invoer.Location = New System.Drawing.Point(33, 57)
        Me.TXT_Invoer.Name = "TXT_Invoer"
        Me.TXT_Invoer.Size = New System.Drawing.Size(132, 20)
        Me.TXT_Invoer.TabIndex = 0
        '
        'Knop_PLaats
        '
        Me.Knop_PLaats.Location = New System.Drawing.Point(172, 57)
        Me.Knop_PLaats.Name = "Knop_PLaats"
        Me.Knop_PLaats.Size = New System.Drawing.Size(75, 23)
        Me.Knop_PLaats.TabIndex = 13
        Me.Knop_PLaats.Text = "Zoek"
        Me.Knop_PLaats.UseVisualStyleBackColor = True
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(114, 267)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Opslaan.TabIndex = 14
        Me.Knop_Opslaan.Text = "Opslaan"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(33, 267)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Nieuw.TabIndex = 15
        Me.Knop_Nieuw.Text = "Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'BS_AP_Invoer
        '
        Me.BS_AP_Invoer.DataMember = "DS_Invoer"
        Me.BS_AP_Invoer.DataSource = Me.OefenDbDataSet
        '
        'OefenDbDataSet
        '
        Me.OefenDbDataSet.DataSetName = "OefenDbDataSet"
        Me.OefenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_Invoer
        '
        Me.TA_Invoer.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApparaatTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GebruikerTableAdapter = Nothing
        Me.TableAdapterManager.TA_Invoer = Me.TA_Invoer
        Me.TableAdapterManager.UpdateOrder = OefenApp.OefenDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ApparaatTableAdapter
        '
        Me.ApparaatTableAdapter.ClearBeforeFill = True
        '
        'GebruikerBindingSource
        '
        Me.GebruikerBindingSource.DataMember = "Gebruiker"
        Me.GebruikerBindingSource.DataSource = Me.OefenDbDataSet
        '
        'GebruikerTableAdapter
        '
        Me.GebruikerTableAdapter.ClearBeforeFill = True
        '
        'OefenDbDataSet1
        '
        Me.OefenDbDataSet1.DataSetName = "OefenDbDataSet"
        Me.OefenDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OefenDbDataSet1BindingSource
        '
        Me.OefenDbDataSet1BindingSource.DataSource = Me.OefenDbDataSet1
        Me.OefenDbDataSet1BindingSource.Position = 0
        '
        'GebruikerBindingSource1
        '
        Me.GebruikerBindingSource1.DataMember = "Gebruiker"
        Me.GebruikerBindingSource1.DataSource = Me.OefenDbDataSet1BindingSource
        '
        'TXT_output
        '
        Me.TXT_output.Location = New System.Drawing.Point(208, 381)
        Me.TXT_output.Name = "TXT_output"
        Me.TXT_output.Size = New System.Drawing.Size(158, 20)
        Me.TXT_output.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "FK van apparaat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "PK van gebruiker"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "navigatiesrip is niet meer nodig hier...."
        '
        'InvoerGebruiker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 460)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_output)
        Me.Controls.Add(Me.Knop_Nieuw)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.Knop_PLaats)
        Me.Controls.Add(Me.TXT_Invoer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Apparaat1BindingNavigator)
        Me.Controls.Add(Me.GB_IDTextBox)
        Me.Name = "InvoerGebruiker"
        Me.Text = "InvoerGebruiker"
        CType(Me.Apparaat1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Apparaat1BindingNavigator.ResumeLayout(False)
        Me.Apparaat1BindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BS_AP_Invoer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OefenDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GebruikerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OefenDbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OefenDbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GebruikerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OefenDbDataSet As OefenDbDataSet
    Friend WithEvents BS_AP_Invoer As BindingSource
    Friend WithEvents TA_Invoer As OefenDbDataSetTableAdapters.TA_Invoer
    Friend WithEvents TableAdapterManager As OefenDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Apparaat1BindingNavigator As BindingNavigator
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
    Friend WithEvents Apparaat1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AP_IDTextBox As TextBox
    Friend WithEvents AP_TypeTextBox As TextBox
    Friend WithEvents GB_IDTextBox As TextBox
    Friend WithEvents AP_MerkTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ApparaatTableAdapter As OefenDbDataSetTableAdapters.ApparaatTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_Invoer As TextBox
    Friend WithEvents Knop_PLaats As Button
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents GebruikerBindingSource As BindingSource
    Friend WithEvents GebruikerTableAdapter As OefenDbDataSetTableAdapters.GebruikerTableAdapter
    Friend WithEvents OefenDbDataSet1BindingSource As BindingSource
    Friend WithEvents OefenDbDataSet1 As OefenDbDataSet
    Friend WithEvents GebruikerBindingSource1 As BindingSource
    Friend WithEvents TXT_output As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

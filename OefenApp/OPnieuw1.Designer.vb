<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OPnieuw1
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
        Dim Knop_Reload As System.Windows.Forms.Button
        Dim Knop_CB1instellen As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OPnieuw1))
        Me.GebruikerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BS_Gebruiker = New System.Windows.Forms.BindingSource(Me.components)
        Me.OefenDbDataSet = New OefenApp.OefenDbDataSet()
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
        Me.GebruikerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GebruikerDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NaamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WoonplaatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeeftijdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXT_Zoektekst = New System.Windows.Forms.TextBox()
        Me.GebruikerTableAdapter = New OefenApp.OefenDbDataSetTableAdapters.GebruikerTableAdapter()
        Me.TableAdapterManager = New OefenApp.OefenDbDataSetTableAdapters.TableAdapterManager()
        Me.CB_1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BS_Gebruiker_apparaat = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApparaatTableAdapter = New OefenApp.OefenDbDataSetTableAdapters.ApparaatTableAdapter()
        Me.txt_output = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Knop_Reload = New System.Windows.Forms.Button()
        Knop_CB1instellen = New System.Windows.Forms.Button()
        CType(Me.GebruikerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GebruikerBindingNavigator.SuspendLayout()
        CType(Me.BS_Gebruiker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OefenDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GebruikerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_Gebruiker_apparaat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Knop_Reload
        '
        Knop_Reload.Location = New System.Drawing.Point(240, 304)
        Knop_Reload.Name = "Knop_Reload"
        Knop_Reload.Size = New System.Drawing.Size(75, 23)
        Knop_Reload.TabIndex = 3
        Knop_Reload.Text = "Reload"
        Knop_Reload.UseVisualStyleBackColor = True
        AddHandler Knop_Reload.Click, AddressOf Me.Knop_Reload_Click
        '
        'Knop_CB1instellen
        '
        Knop_CB1instellen.Location = New System.Drawing.Point(424, 336)
        Knop_CB1instellen.Name = "Knop_CB1instellen"
        Knop_CB1instellen.Size = New System.Drawing.Size(144, 23)
        Knop_CB1instellen.TabIndex = 6
        Knop_CB1instellen.Text = "Stel combobox in "
        Knop_CB1instellen.UseVisualStyleBackColor = True
        AddHandler Knop_CB1instellen.Click, AddressOf Me.Knop_CB1instellen_Click
        '
        'GebruikerBindingNavigator
        '
        Me.GebruikerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GebruikerBindingNavigator.BindingSource = Me.BS_Gebruiker
        Me.GebruikerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GebruikerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GebruikerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GebruikerBindingNavigatorSaveItem})
        Me.GebruikerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GebruikerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GebruikerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GebruikerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GebruikerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GebruikerBindingNavigator.Name = "GebruikerBindingNavigator"
        Me.GebruikerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GebruikerBindingNavigator.Size = New System.Drawing.Size(712, 25)
        Me.GebruikerBindingNavigator.TabIndex = 0
        Me.GebruikerBindingNavigator.Text = "BindingNavigator1"
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
        'BS_Gebruiker
        '
        Me.BS_Gebruiker.DataMember = "Gebruiker"
        Me.BS_Gebruiker.DataSource = Me.OefenDbDataSet
        '
        'OefenDbDataSet
        '
        Me.OefenDbDataSet.DataSetName = "OefenDbDataSet"
        Me.OefenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GebruikerBindingNavigatorSaveItem
        '
        Me.GebruikerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GebruikerBindingNavigatorSaveItem.Image = CType(resources.GetObject("GebruikerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GebruikerBindingNavigatorSaveItem.Name = "GebruikerBindingNavigatorSaveItem"
        Me.GebruikerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GebruikerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GebruikerDataGridView
        '
        Me.GebruikerDataGridView.AutoGenerateColumns = False
        Me.GebruikerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GebruikerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NaamDataGridViewTextBoxColumn, Me.WoonplaatsDataGridViewTextBoxColumn, Me.LeeftijdDataGridViewTextBoxColumn})
        Me.GebruikerDataGridView.DataSource = Me.BS_Gebruiker
        Me.GebruikerDataGridView.Location = New System.Drawing.Point(68, 69)
        Me.GebruikerDataGridView.Name = "GebruikerDataGridView"
        Me.GebruikerDataGridView.Size = New System.Drawing.Size(500, 220)
        Me.GebruikerDataGridView.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NaamDataGridViewTextBoxColumn
        '
        Me.NaamDataGridViewTextBoxColumn.DataPropertyName = "Naam"
        Me.NaamDataGridViewTextBoxColumn.HeaderText = "Naam"
        Me.NaamDataGridViewTextBoxColumn.Name = "NaamDataGridViewTextBoxColumn"
        '
        'WoonplaatsDataGridViewTextBoxColumn
        '
        Me.WoonplaatsDataGridViewTextBoxColumn.DataPropertyName = "Woonplaats"
        Me.WoonplaatsDataGridViewTextBoxColumn.HeaderText = "Woonplaats"
        Me.WoonplaatsDataGridViewTextBoxColumn.Name = "WoonplaatsDataGridViewTextBoxColumn"
        '
        'LeeftijdDataGridViewTextBoxColumn
        '
        Me.LeeftijdDataGridViewTextBoxColumn.DataPropertyName = "Leeftijd"
        Me.LeeftijdDataGridViewTextBoxColumn.HeaderText = "Leeftijd"
        Me.LeeftijdDataGridViewTextBoxColumn.Name = "LeeftijdDataGridViewTextBoxColumn"
        '
        'TXT_Zoektekst
        '
        Me.TXT_Zoektekst.Location = New System.Drawing.Point(68, 308)
        Me.TXT_Zoektekst.Name = "TXT_Zoektekst"
        Me.TXT_Zoektekst.Size = New System.Drawing.Size(144, 20)
        Me.TXT_Zoektekst.TabIndex = 2
        '
        'GebruikerTableAdapter
        '
        Me.GebruikerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApparaatTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GebruikerTableAdapter = Me.GebruikerTableAdapter
        Me.TableAdapterManager.UpdateOrder = OefenApp.OefenDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'CB_1
        '
        Me.CB_1.DataSource = Me.BS_Gebruiker
        Me.CB_1.DisplayMember = "Naam"
        Me.CB_1.FormattingEnabled = True
        Me.CB_1.Location = New System.Drawing.Point(424, 308)
        Me.CB_1.Name = "CB_1"
        Me.CB_1.Size = New System.Drawing.Size(144, 21)
        Me.CB_1.TabIndex = 4
        Me.CB_1.ValueMember = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Combobox"
        '
        'BS_Gebruiker_apparaat
        '
        Me.BS_Gebruiker_apparaat.DataMember = "Gebruiker_Apparaat"
        Me.BS_Gebruiker_apparaat.DataSource = Me.BS_Gebruiker
        '
        'ApparaatTableAdapter
        '
        Me.ApparaatTableAdapter.ClearBeforeFill = True
        '
        'txt_output
        '
        Me.txt_output.Location = New System.Drawing.Point(424, 366)
        Me.txt_output.Multiline = True
        Me.txt_output.Name = "txt_output"
        Me.txt_output.Size = New System.Drawing.Size(144, 76)
        Me.txt_output.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Output"
        '
        'OPnieuw1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 454)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_output)
        Me.Controls.Add(Knop_CB1instellen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_1)
        Me.Controls.Add(Knop_Reload)
        Me.Controls.Add(Me.TXT_Zoektekst)
        Me.Controls.Add(Me.GebruikerDataGridView)
        Me.Controls.Add(Me.GebruikerBindingNavigator)
        Me.Name = "OPnieuw1"
        Me.Text = "OPnieuw1"
        CType(Me.GebruikerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GebruikerBindingNavigator.ResumeLayout(False)
        Me.GebruikerBindingNavigator.PerformLayout()
        CType(Me.BS_Gebruiker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OefenDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GebruikerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_Gebruiker_apparaat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OefenDbDataSet As OefenDbDataSet
    Friend WithEvents BS_Gebruiker As BindingSource
    Friend WithEvents TableAdapterManager As OefenDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GebruikerBindingNavigator As BindingNavigator
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
    Friend WithEvents GebruikerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GebruikerDataGridView As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NaamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WoonplaatsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeeftijdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GebruikerTableAdapter As OefenDbDataSetTableAdapters.GebruikerTableAdapter
    Friend WithEvents TXT_Zoektekst As TextBox
    Friend WithEvents CB_1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BS_Gebruiker_apparaat As BindingSource
    Friend WithEvents ApparaatTableAdapter As OefenDbDataSetTableAdapters.ApparaatTableAdapter
    Friend WithEvents txt_output As TextBox
    Friend WithEvents Label2 As Label
End Class

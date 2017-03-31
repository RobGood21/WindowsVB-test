<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlleenDatagrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlleenDatagrid))
        Me.GebruikerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GebruikerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OefenDbDataSetnew = New OefenApp.OefenDbDataSetnew()
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GebruikerTableAdapter = New OefenApp.OefenDbDataSetnewTableAdapters.GebruikerTableAdapter()
        Me.TableAdapterManager = New OefenApp.OefenDbDataSetnewTableAdapters.TableAdapterManager()
        Me.KNOP_Reload = New System.Windows.Forms.Button()
        Me.TXT_Invoer = New System.Windows.Forms.TextBox()
        CType(Me.GebruikerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GebruikerBindingNavigator.SuspendLayout()
        CType(Me.GebruikerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OefenDbDataSetnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GebruikerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GebruikerBindingNavigator
        '
        Me.GebruikerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GebruikerBindingNavigator.BindingSource = Me.GebruikerBindingSource
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
        Me.GebruikerBindingNavigator.Size = New System.Drawing.Size(893, 25)
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
        'GebruikerBindingSource
        '
        Me.GebruikerBindingSource.DataMember = "Gebruiker"
        Me.GebruikerBindingSource.DataSource = Me.OefenDbDataSetnew
        '
        'OefenDbDataSetnew
        '
        Me.OefenDbDataSetnew.DataSetName = "OefenDbDataSetnew"
        Me.OefenDbDataSetnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.GebruikerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.GebruikerDataGridView.DataSource = Me.GebruikerBindingSource
        Me.GebruikerDataGridView.Location = New System.Drawing.Point(12, 55)
        Me.GebruikerDataGridView.Name = "GebruikerDataGridView"
        Me.GebruikerDataGridView.Size = New System.Drawing.Size(747, 220)
        Me.GebruikerDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Naam"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Naam"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Woonplaats"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Woonplaats"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Leeftijd"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Leeftijd"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GebruikerTableAdapter
        '
        Me.GebruikerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GebruikerTableAdapter = Me.GebruikerTableAdapter
        Me.TableAdapterManager.UpdateOrder = OefenApp.OefenDbDataSetnewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KNOP_Reload
        '
        Me.KNOP_Reload.Location = New System.Drawing.Point(162, 282)
        Me.KNOP_Reload.Name = "KNOP_Reload"
        Me.KNOP_Reload.Size = New System.Drawing.Size(75, 23)
        Me.KNOP_Reload.TabIndex = 2
        Me.KNOP_Reload.Text = "Reload"
        Me.KNOP_Reload.UseVisualStyleBackColor = False
        '
        'TXT_Invoer
        '
        Me.TXT_Invoer.Location = New System.Drawing.Point(13, 282)
        Me.TXT_Invoer.Name = "TXT_Invoer"
        Me.TXT_Invoer.Size = New System.Drawing.Size(143, 20)
        Me.TXT_Invoer.TabIndex = 3
        '
        'AlleenDatagrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 455)
        Me.Controls.Add(Me.TXT_Invoer)
        Me.Controls.Add(Me.KNOP_Reload)
        Me.Controls.Add(Me.GebruikerDataGridView)
        Me.Controls.Add(Me.GebruikerBindingNavigator)
        Me.Name = "AlleenDatagrid"
        Me.Text = "Alleen een datagrid"
        CType(Me.GebruikerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GebruikerBindingNavigator.ResumeLayout(False)
        Me.GebruikerBindingNavigator.PerformLayout()
        CType(Me.GebruikerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OefenDbDataSetnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GebruikerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OefenDbDataSetnew As OefenDbDataSetnew
    Friend WithEvents GebruikerBindingSource As BindingSource
    Friend WithEvents GebruikerTableAdapter As OefenDbDataSetnewTableAdapters.GebruikerTableAdapter
    Friend WithEvents TableAdapterManager As OefenDbDataSetnewTableAdapters.TableAdapterManager
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents KNOP_Reload As Button
    Friend WithEvents TXT_Invoer As TextBox
End Class

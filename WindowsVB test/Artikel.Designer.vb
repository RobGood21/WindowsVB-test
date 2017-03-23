<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Artikel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Artikel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KnopTest1 = New System.Windows.Forms.Button()
        Me.WMdbDataSet = New WindowsVB_test.WMdbDataSet()
        Me.ProductenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductenTableAdapter = New WindowsVB_test.WMdbDataSetTableAdapters.ProductenTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.WMdbDataSetTableAdapters.TableAdapterManager()
        Me.ProductenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.WMdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductenBindingNavigator.SuspendLayout()
        CType(Me.ProductenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'KnopTest1
        '
        resources.ApplyResources(Me.KnopTest1, "KnopTest1")
        Me.KnopTest1.Name = "KnopTest1"
        Me.KnopTest1.UseVisualStyleBackColor = True
        '
        'WMdbDataSet
        '
        Me.WMdbDataSet.DataSetName = "WMdbDataSet"
        Me.WMdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductenBindingSource
        '
        Me.ProductenBindingSource.DataMember = "Producten"
        Me.ProductenBindingSource.DataSource = Me.WMdbDataSet
        '
        'ProductenTableAdapter
        '
        Me.ProductenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductenTableAdapter = Me.ProductenTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.WMdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductenBindingNavigator
        '
        Me.ProductenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductenBindingNavigator.BindingSource = Me.ProductenBindingSource
        Me.ProductenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductenBindingNavigatorSaveItem})
        resources.ApplyResources(Me.ProductenBindingNavigator, "ProductenBindingNavigator")
        Me.ProductenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductenBindingNavigator.Name = "ProductenBindingNavigator"
        Me.ProductenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMoveFirstItem, "BindingNavigatorMoveFirstItem")
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMovePreviousItem, "BindingNavigatorMovePreviousItem")
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        resources.ApplyResources(Me.BindingNavigatorSeparator, "BindingNavigatorSeparator")
        '
        'BindingNavigatorPositionItem
        '
        resources.ApplyResources(Me.BindingNavigatorPositionItem, "BindingNavigatorPositionItem")
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        resources.ApplyResources(Me.BindingNavigatorCountItem, "BindingNavigatorCountItem")
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        resources.ApplyResources(Me.BindingNavigatorSeparator1, "BindingNavigatorSeparator1")
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMoveNextItem, "BindingNavigatorMoveNextItem")
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMoveLastItem, "BindingNavigatorMoveLastItem")
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        resources.ApplyResources(Me.BindingNavigatorSeparator2, "BindingNavigatorSeparator2")
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorAddNewItem, "BindingNavigatorAddNewItem")
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorDeleteItem, "BindingNavigatorDeleteItem")
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        '
        'ProductenBindingNavigatorSaveItem
        '
        Me.ProductenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ProductenBindingNavigatorSaveItem, "ProductenBindingNavigatorSaveItem")
        Me.ProductenBindingNavigatorSaveItem.Name = "ProductenBindingNavigatorSaveItem"
        '
        'ProductenDataGridView
        '
        Me.ProductenDataGridView.AutoGenerateColumns = False
        Me.ProductenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProductenDataGridView.DataSource = Me.ProductenBindingSource
        resources.ApplyResources(Me.ProductenDataGridView, "ProductenDataGridView")
        Me.ProductenDataGridView.Name = "ProductenDataGridView"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProduct"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductCode"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductSoort"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Merk"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4")
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Beschrijving"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn5, "DataGridViewTextBoxColumn5")
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Prijs"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn6, "DataGridViewTextBoxColumn6")
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Artikel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProductenDataGridView)
        Me.Controls.Add(Me.ProductenBindingNavigator)
        Me.Controls.Add(Me.KnopTest1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Artikel"
        CType(Me.WMdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductenBindingNavigator.ResumeLayout(False)
        Me.ProductenBindingNavigator.PerformLayout()
        CType(Me.ProductenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents KnopTest1 As Button
    Friend WithEvents WMdbDataSet As WMdbDataSet
    Friend WithEvents ProductenBindingSource As BindingSource
    Friend WithEvents ProductenTableAdapter As WMdbDataSetTableAdapters.ProductenTableAdapter
    Friend WithEvents TableAdapterManager As WMdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductenBindingNavigator As BindingNavigator
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
    Friend WithEvents ProductenBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductenDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class

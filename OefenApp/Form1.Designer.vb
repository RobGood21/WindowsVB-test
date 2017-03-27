<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.OefenDbDataSet = New OefenApp.OefenDbDataSet()
        Me.GebruikerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GebruikerTableAdapter = New OefenApp.OefenDbDataSetTableAdapters.GebruikerTableAdapter()
        Me.TableAdapterManager = New OefenApp.OefenDbDataSetTableAdapters.TableAdapterManager()
        Me.GebruikerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.OefenDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GebruikerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GebruikerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OefenDbDataSet
        '
        Me.OefenDbDataSet.DataSetName = "OefenDbDataSet"
        Me.OefenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GebruikerTableAdapter = Me.GebruikerTableAdapter
        Me.TableAdapterManager.UpdateOrder = OefenApp.OefenDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GebruikerDataGridView
        '
        Me.GebruikerDataGridView.AutoGenerateColumns = False
        Me.GebruikerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GebruikerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.GebruikerDataGridView.DataSource = Me.GebruikerBindingSource
        Me.GebruikerDataGridView.Location = New System.Drawing.Point(49, 64)
        Me.GebruikerDataGridView.Name = "GebruikerDataGridView"
        Me.GebruikerDataGridView.Size = New System.Drawing.Size(540, 220)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "opslaan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Reload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 367)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GebruikerDataGridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.OefenDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GebruikerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GebruikerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OefenDbDataSet As OefenDbDataSet
    Friend WithEvents GebruikerBindingSource As BindingSource
    Friend WithEvents GebruikerTableAdapter As OefenDbDataSetTableAdapters.GebruikerTableAdapter
    Friend WithEvents TableAdapterManager As OefenDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GebruikerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

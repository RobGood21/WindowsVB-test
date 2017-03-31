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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NaamLabel As System.Windows.Forms.Label
        Dim WoonplaatsLabel As System.Windows.Forms.Label
        Dim LeeftijdLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TXT1 = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.GebruikerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OefenDbDataSet = New OefenApp.OefenDbDataSet()
        Me.NaamTextBox = New System.Windows.Forms.TextBox()
        Me.WoonplaatsTextBox = New System.Windows.Forms.TextBox()
        Me.LeeftijdTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GebruikerTableAdapter = New OefenApp.OefenDbDataSetTableAdapters.GebruikerTableAdapter()
        Me.TableAdapterManager = New OefenApp.OefenDbDataSetTableAdapters.TableAdapterManager()
        Me.TXTNAAM = New System.Windows.Forms.TextBox()
        Me.TXTPLAATS = New System.Windows.Forms.TextBox()
        Me.TXTLeeftijd = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.CB_KiesRecord = New System.Windows.Forms.ComboBox()
        Me.GebruikerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LB_Lijstkies = New System.Windows.Forms.ListBox()
        Me.DG_oefen = New System.Windows.Forms.DataGridView()
        Me.OefenDbDataSetnew = New OefenApp.OefenDbDataSetnew()
        IDLabel = New System.Windows.Forms.Label()
        NaamLabel = New System.Windows.Forms.Label()
        WoonplaatsLabel = New System.Windows.Forms.Label()
        LeeftijdLabel = New System.Windows.Forms.Label()
        CType(Me.GebruikerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OefenDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GebruikerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_oefen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OefenDbDataSetnew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(119, 45)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 4
        IDLabel.Text = "ID:"
        '
        'NaamLabel
        '
        NaamLabel.AutoSize = True
        NaamLabel.Location = New System.Drawing.Point(102, 71)
        NaamLabel.Name = "NaamLabel"
        NaamLabel.Size = New System.Drawing.Size(38, 13)
        NaamLabel.TabIndex = 5
        NaamLabel.Text = "Naam:"
        '
        'WoonplaatsLabel
        '
        WoonplaatsLabel.AutoSize = True
        WoonplaatsLabel.Location = New System.Drawing.Point(73, 97)
        WoonplaatsLabel.Name = "WoonplaatsLabel"
        WoonplaatsLabel.Size = New System.Drawing.Size(67, 13)
        WoonplaatsLabel.TabIndex = 7
        WoonplaatsLabel.Text = "Woonplaats:"
        '
        'LeeftijdLabel
        '
        LeeftijdLabel.AutoSize = True
        LeeftijdLabel.Location = New System.Drawing.Point(96, 123)
        LeeftijdLabel.Name = "LeeftijdLabel"
        LeeftijdLabel.Size = New System.Drawing.Size(44, 13)
        LeeftijdLabel.TabIndex = 9
        LeeftijdLabel.Text = "Leeftijd:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "opslaan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Reload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TXT1
        '
        Me.TXT1.Location = New System.Drawing.Point(362, 42)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.Size = New System.Drawing.Size(201, 20)
        Me.TXT1.TabIndex = 4
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GebruikerBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(146, 42)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(190, 20)
        Me.IDTextBox.TabIndex = 5
        '
        'GebruikerBindingSource
        '
        Me.GebruikerBindingSource.DataMember = "Gebruiker"
        Me.GebruikerBindingSource.DataSource = Me.OefenDbDataSet
        '
        'OefenDbDataSet
        '
        Me.OefenDbDataSet.DataSetName = "OefenDbDataSet"
        Me.OefenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NaamTextBox
        '
        Me.NaamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GebruikerBindingSource, "Naam", True))
        Me.NaamTextBox.Location = New System.Drawing.Point(146, 68)
        Me.NaamTextBox.Name = "NaamTextBox"
        Me.NaamTextBox.Size = New System.Drawing.Size(190, 20)
        Me.NaamTextBox.TabIndex = 6
        '
        'WoonplaatsTextBox
        '
        Me.WoonplaatsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GebruikerBindingSource, "Woonplaats", True))
        Me.WoonplaatsTextBox.Location = New System.Drawing.Point(146, 94)
        Me.WoonplaatsTextBox.Name = "WoonplaatsTextBox"
        Me.WoonplaatsTextBox.Size = New System.Drawing.Size(190, 20)
        Me.WoonplaatsTextBox.TabIndex = 8
        '
        'LeeftijdTextBox
        '
        Me.LeeftijdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GebruikerBindingSource, "Leeftijd", True))
        Me.LeeftijdTextBox.Location = New System.Drawing.Point(146, 120)
        Me.LeeftijdTextBox.Name = "LeeftijdTextBox"
        Me.LeeftijdTextBox.Size = New System.Drawing.Size(190, 20)
        Me.LeeftijdTextBox.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(146, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(228, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
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
        'TXTNAAM
        '
        Me.TXTNAAM.Location = New System.Drawing.Point(362, 68)
        Me.TXTNAAM.Name = "TXTNAAM"
        Me.TXTNAAM.Size = New System.Drawing.Size(201, 20)
        Me.TXTNAAM.TabIndex = 13
        '
        'TXTPLAATS
        '
        Me.TXTPLAATS.Location = New System.Drawing.Point(362, 94)
        Me.TXTPLAATS.Name = "TXTPLAATS"
        Me.TXTPLAATS.Size = New System.Drawing.Size(201, 20)
        Me.TXTPLAATS.TabIndex = 14
        '
        'TXTLeeftijd
        '
        Me.TXTLeeftijd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GebruikerBindingSource, "Leeftijd", True))
        Me.TXTLeeftijd.Location = New System.Drawing.Point(362, 120)
        Me.TXTLeeftijd.Name = "TXTLeeftijd"
        Me.TXTLeeftijd.Size = New System.Drawing.Size(201, 20)
        Me.TXTLeeftijd.TabIndex = 15
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(362, 161)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Laad robsQ"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(331, 13)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Nieuw"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'CB_KiesRecord
        '
        Me.CB_KiesRecord.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GebruikerBindingSource, "Naam", True))
        Me.CB_KiesRecord.DataSource = Me.GebruikerBindingSource
        Me.CB_KiesRecord.DisplayMember = "Naam"
        Me.CB_KiesRecord.FormattingEnabled = True
        Me.CB_KiesRecord.Location = New System.Drawing.Point(590, 161)
        Me.CB_KiesRecord.Name = "CB_KiesRecord"
        Me.CB_KiesRecord.Size = New System.Drawing.Size(190, 21)
        Me.CB_KiesRecord.TabIndex = 18
        '
        'GebruikerBindingSource1
        '
        Me.GebruikerBindingSource1.DataSource = Me.OefenDbDataSetnew
        Me.GebruikerBindingSource1.Filter = ""
        Me.GebruikerBindingSource1.Position = 0
        '
        'LB_Lijstkies
        '
        Me.LB_Lijstkies.DataSource = Me.GebruikerBindingSource
        Me.LB_Lijstkies.DisplayMember = "Naam"
        Me.LB_Lijstkies.FormattingEnabled = True
        Me.LB_Lijstkies.Location = New System.Drawing.Point(590, 32)
        Me.LB_Lijstkies.Name = "LB_Lijstkies"
        Me.LB_Lijstkies.Size = New System.Drawing.Size(190, 108)
        Me.LB_Lijstkies.TabIndex = 19
        '
        'DG_oefen
        '
        Me.DG_oefen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_oefen.Location = New System.Drawing.Point(146, 278)
        Me.DG_oefen.Name = "DG_oefen"
        Me.DG_oefen.Size = New System.Drawing.Size(634, 150)
        Me.DG_oefen.TabIndex = 20
        '
        'OefenDbDataSetnew
        '
        Me.OefenDbDataSetnew.DataSetName = "OefenDbDataSetnew"
        Me.OefenDbDataSetnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 503)
        Me.Controls.Add(Me.DG_oefen)
        Me.Controls.Add(Me.LB_Lijstkies)
        Me.Controls.Add(Me.CB_KiesRecord)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TXTLeeftijd)
        Me.Controls.Add(Me.TXTPLAATS)
        Me.Controls.Add(Me.TXTNAAM)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(LeeftijdLabel)
        Me.Controls.Add(Me.LeeftijdTextBox)
        Me.Controls.Add(WoonplaatsLabel)
        Me.Controls.Add(Me.WoonplaatsTextBox)
        Me.Controls.Add(NaamLabel)
        Me.Controls.Add(Me.NaamTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.TXT1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GebruikerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OefenDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GebruikerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_oefen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OefenDbDataSetnew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OefenDbDataSet As OefenDbDataSet
    Friend WithEvents GebruikerTableAdapter As OefenDbDataSetTableAdapters.GebruikerTableAdapter
    Friend WithEvents TableAdapterManager As OefenDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GebruikerBindingSource As BindingSource
    Friend WithEvents TXT1 As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NaamTextBox As TextBox
    Friend WithEvents WoonplaatsTextBox As TextBox
    Friend WithEvents LeeftijdTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TXTNAAM As TextBox
    Friend WithEvents TXTPLAATS As TextBox
    Friend WithEvents TXTLeeftijd As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents CB_KiesRecord As ComboBox
    Friend WithEvents GebruikerBindingSource1 As BindingSource
    Friend WithEvents LB_Lijstkies As ListBox
    Friend WithEvents DG_oefen As DataGridView
    Friend WithEvents OefenDbDataSetnew As OefenDbDataSetnew
End Class

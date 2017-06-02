<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Locatie
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
        Dim LH_BeschrijvingLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_HolderCode = New System.Windows.Forms.TextBox()
        Me.LocatieHolderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_Rij = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_locatieCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_kolom = New System.Windows.Forms.TextBox()
        Me.TXT_Vak = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_holder = New System.Windows.Forms.ComboBox()
        Me.Knop_Sluiten = New System.Windows.Forms.Button()
        Me.TXT_LocatieID = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.LocatieHolderTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.LocatieHolderTableAdapter()
        Me.LH_BeschrijvingTextBox = New System.Windows.Forms.TextBox()
        Me.LocatieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocatieTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.LocatieTableAdapter()
        LH_BeschrijvingLabel = New System.Windows.Forms.Label()
        CType(Me.LocatieHolderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LocatieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LH_BeschrijvingLabel
        '
        LH_BeschrijvingLabel.AutoSize = True
        LH_BeschrijvingLabel.Location = New System.Drawing.Point(16, 64)
        LH_BeschrijvingLabel.Name = "LH_BeschrijvingLabel"
        LH_BeschrijvingLabel.Size = New System.Drawing.Size(67, 13)
        LH_BeschrijvingLabel.TabIndex = 17
        LH_BeschrijvingLabel.Text = "Beschrijving:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kast, holder:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Code:"
        '
        'TXT_HolderCode
        '
        Me.TXT_HolderCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieHolderBindingSource, "LH_Code", True))
        Me.TXT_HolderCode.Location = New System.Drawing.Point(85, 110)
        Me.TXT_HolderCode.Name = "TXT_HolderCode"
        Me.TXT_HolderCode.Size = New System.Drawing.Size(174, 20)
        Me.TXT_HolderCode.TabIndex = 2
        '
        'LocatieHolderBindingSource
        '
        Me.LocatieHolderBindingSource.DataMember = "LocatieHolder"
        Me.LocatieHolderBindingSource.DataSource = Me.DS_Product
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rij:"
        '
        'TXT_Rij
        '
        Me.TXT_Rij.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieBindingSource, "LK_Rij", True))
        Me.TXT_Rij.Location = New System.Drawing.Point(40, 16)
        Me.TXT_Rij.Name = "TXT_Rij"
        Me.TXT_Rij.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Rij.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Vak:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Locatiecode:"
        '
        'TXT_locatieCode
        '
        Me.TXT_locatieCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieBindingSource, "LK_Code", True))
        Me.TXT_locatieCode.Location = New System.Drawing.Point(123, 249)
        Me.TXT_locatieCode.Name = "TXT_locatieCode"
        Me.TXT_locatieCode.Size = New System.Drawing.Size(134, 20)
        Me.TXT_locatieCode.TabIndex = 9
        Me.TXT_locatieCode.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Kolom:"
        '
        'TXT_kolom
        '
        Me.TXT_kolom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieBindingSource, "LK_Kolom", True))
        Me.TXT_kolom.Location = New System.Drawing.Point(82, 44)
        Me.TXT_kolom.Name = "TXT_kolom"
        Me.TXT_kolom.Size = New System.Drawing.Size(40, 20)
        Me.TXT_kolom.TabIndex = 5
        '
        'TXT_Vak
        '
        Me.TXT_Vak.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieBindingSource, "LK_Vaknummer", True))
        Me.TXT_Vak.Location = New System.Drawing.Point(121, 70)
        Me.TXT_Vak.Name = "TXT_Vak"
        Me.TXT_Vak.Size = New System.Drawing.Size(40, 20)
        Me.TXT_Vak.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_kolom)
        Me.GroupBox1.Controls.Add(Me.TXT_Vak)
        Me.GroupBox1.Controls.Add(Me.TXT_Rij)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 101)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'CB_holder
        '
        Me.CB_holder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieHolderBindingSource, "LH_Naam", True))
        Me.CB_holder.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LocatieBindingSource, "ID_LocatieHolder", True))
        Me.CB_holder.DataSource = Me.LocatieHolderBindingSource
        Me.CB_holder.DisplayMember = "LH_Naam"
        Me.CB_holder.FormattingEnabled = True
        Me.CB_holder.Location = New System.Drawing.Point(86, 38)
        Me.CB_holder.Name = "CB_holder"
        Me.CB_holder.Size = New System.Drawing.Size(173, 21)
        Me.CB_holder.TabIndex = 0
        Me.CB_holder.ValueMember = "ID_LocatieHolder"
        '
        'Knop_Sluiten
        '
        Me.Knop_Sluiten.Location = New System.Drawing.Point(181, 276)
        Me.Knop_Sluiten.Name = "Knop_Sluiten"
        Me.Knop_Sluiten.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Sluiten.TabIndex = 16
        Me.Knop_Sluiten.Text = "&Sluiten"
        Me.Knop_Sluiten.UseVisualStyleBackColor = True
        '
        'TXT_LocatieID
        '
        Me.TXT_LocatieID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieBindingSource, "ID_Locatie", True))
        Me.TXT_LocatieID.Location = New System.Drawing.Point(219, 12)
        Me.TXT_LocatieID.Name = "TXT_LocatieID"
        Me.TXT_LocatieID.Size = New System.Drawing.Size(40, 20)
        Me.TXT_LocatieID.TabIndex = 17
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DT_productTableAdapter = Nothing
        Me.TableAdapterManager.GetOntvangstTableAdapter = Nothing
        Me.TableAdapterManager.GetProductAddTableAdapter = Nothing
        Me.TableAdapterManager.GPA_AantalTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.LocatieHolderTableAdapter = Me.LocatieHolderTableAdapter
        Me.TableAdapterManager.LocatieTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.PicturesTableAdapter = Nothing
        Me.TableAdapterManager.ProductInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
        '
        'LocatieHolderTableAdapter
        '
        Me.LocatieHolderTableAdapter.ClearBeforeFill = True
        '
        'LH_BeschrijvingTextBox
        '
        Me.LH_BeschrijvingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocatieHolderBindingSource, "LH_Beschrijving", True))
        Me.LH_BeschrijvingTextBox.Location = New System.Drawing.Point(86, 61)
        Me.LH_BeschrijvingTextBox.Multiline = True
        Me.LH_BeschrijvingTextBox.Name = "LH_BeschrijvingTextBox"
        Me.LH_BeschrijvingTextBox.Size = New System.Drawing.Size(173, 43)
        Me.LH_BeschrijvingTextBox.TabIndex = 18
        Me.LH_BeschrijvingTextBox.TabStop = False
        '
        'LocatieBindingSource
        '
        Me.LocatieBindingSource.DataMember = "Locatie"
        Me.LocatieBindingSource.DataSource = Me.DS_Product
        '
        'LocatieTableAdapter
        '
        Me.LocatieTableAdapter.ClearBeforeFill = True
        '
        'F_Locatie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 431)
        Me.Controls.Add(LH_BeschrijvingLabel)
        Me.Controls.Add(Me.LH_BeschrijvingTextBox)
        Me.Controls.Add(Me.TXT_LocatieID)
        Me.Controls.Add(Me.Knop_Sluiten)
        Me.Controls.Add(Me.CB_holder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_locatieCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_HolderCode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F_Locatie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Locatie van producten"
        CType(Me.LocatieHolderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LocatieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_HolderCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_Rij As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_locatieCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_kolom As TextBox
    Friend WithEvents TXT_Vak As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_holder As ComboBox
    Friend WithEvents Knop_Sluiten As Button
    Friend WithEvents TXT_LocatieID As TextBox
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents LocatieHolderBindingSource As BindingSource
    Friend WithEvents LocatieHolderTableAdapter As DS_ProductTableAdapters.LocatieHolderTableAdapter
    Friend WithEvents LH_BeschrijvingTextBox As TextBox
    Friend WithEvents LocatieBindingSource As BindingSource
    Friend WithEvents LocatieTableAdapter As DS_ProductTableAdapters.LocatieTableAdapter
End Class

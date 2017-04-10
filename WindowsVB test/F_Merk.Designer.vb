<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Merk
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
        Dim LB_Merk As System.Windows.Forms.ListBox
        Dim MK_BeschrijvingLabel As System.Windows.Forms.Label
        Dim MK_MerkNaamLabel As System.Windows.Forms.Label
        Me.MerkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.TXT_Zoektekst = New System.Windows.Forms.TextBox()
        Me.MerkTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.MerkTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.ProductTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.ProductTableAdapter()
        Me.FKProductMerkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Knop_Save = New System.Windows.Forms.Button()
        Me.MK_BeschrijvingTextBox = New System.Windows.Forms.TextBox()
        Me.TXT_Merknaam = New System.Windows.Forms.TextBox()
        Me.ID_MerkTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_Nieuw = New System.Windows.Forms.Button()
        LB_Merk = New System.Windows.Forms.ListBox()
        MK_BeschrijvingLabel = New System.Windows.Forms.Label()
        MK_MerkNaamLabel = New System.Windows.Forms.Label()
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKProductMerkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LB_Merk
        '
        LB_Merk.DataSource = Me.MerkBindingSource
        LB_Merk.DisplayMember = "MK_MerkNaam"
        LB_Merk.FormattingEnabled = True
        LB_Merk.Location = New System.Drawing.Point(12, 51)
        LB_Merk.Name = "LB_Merk"
        LB_Merk.Size = New System.Drawing.Size(136, 303)
        LB_Merk.TabIndex = 8
        LB_Merk.TabStop = False
        '
        'MerkBindingSource
        '
        Me.MerkBindingSource.DataMember = "Merk"
        Me.MerkBindingSource.DataSource = Me.DS_Product
        '
        'DS_Product
        '
        Me.DS_Product.DataSetName = "DS_Product"
        Me.DS_Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MK_BeschrijvingLabel
        '
        MK_BeschrijvingLabel.AutoSize = True
        MK_BeschrijvingLabel.Location = New System.Drawing.Point(12, 77)
        MK_BeschrijvingLabel.Name = "MK_BeschrijvingLabel"
        MK_BeschrijvingLabel.Size = New System.Drawing.Size(67, 13)
        MK_BeschrijvingLabel.TabIndex = 16
        MK_BeschrijvingLabel.Text = "Beschrijving:"
        '
        'MK_MerkNaamLabel
        '
        MK_MerkNaamLabel.AutoSize = True
        MK_MerkNaamLabel.Location = New System.Drawing.Point(12, 55)
        MK_MerkNaamLabel.Name = "MK_MerkNaamLabel"
        MK_MerkNaamLabel.Size = New System.Drawing.Size(60, 13)
        MK_MerkNaamLabel.TabIndex = 14
        MK_MerkNaamLabel.Text = "Merknaam:"
        '
        'TXT_Zoektekst
        '
        Me.TXT_Zoektekst.Location = New System.Drawing.Point(13, 25)
        Me.TXT_Zoektekst.Name = "TXT_Zoektekst"
        Me.TXT_Zoektekst.Size = New System.Drawing.Size(135, 20)
        Me.TXT_Zoektekst.TabIndex = 0
        '
        'MerkTableAdapter
        '
        Me.MerkTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DT_productTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Me.MerkTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'FKProductMerkBindingSource
        '
        Me.FKProductMerkBindingSource.DataMember = "FK_Product_Merk"
        Me.FKProductMerkBindingSource.DataSource = Me.MerkBindingSource
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Knop_Save)
        Me.GroupBox1.Controls.Add(MK_BeschrijvingLabel)
        Me.GroupBox1.Controls.Add(Me.MK_BeschrijvingTextBox)
        Me.GroupBox1.Controls.Add(MK_MerkNaamLabel)
        Me.GroupBox1.Controls.Add(Me.TXT_Merknaam)
        Me.GroupBox1.Controls.Add(Me.ID_MerkTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(154, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 313)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Knop_Save
        '
        Me.Knop_Save.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Save_as_icon
        Me.Knop_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Knop_Save.Location = New System.Drawing.Point(15, 16)
        Me.Knop_Save.Name = "Knop_Save"
        Me.Knop_Save.Size = New System.Drawing.Size(31, 30)
        Me.Knop_Save.TabIndex = 17
        Me.Knop_Save.UseVisualStyleBackColor = True
        '
        'MK_BeschrijvingTextBox
        '
        Me.MK_BeschrijvingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerkBindingSource, "MK_Beschrijving", True))
        Me.MK_BeschrijvingTextBox.Location = New System.Drawing.Point(15, 93)
        Me.MK_BeschrijvingTextBox.Multiline = True
        Me.MK_BeschrijvingTextBox.Name = "MK_BeschrijvingTextBox"
        Me.MK_BeschrijvingTextBox.Size = New System.Drawing.Size(279, 84)
        Me.MK_BeschrijvingTextBox.TabIndex = 2
        '
        'TXT_Merknaam
        '
        Me.TXT_Merknaam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerkBindingSource, "MK_MerkNaam", True))
        Me.TXT_Merknaam.Location = New System.Drawing.Point(78, 52)
        Me.TXT_Merknaam.Name = "TXT_Merknaam"
        Me.TXT_Merknaam.Size = New System.Drawing.Size(216, 20)
        Me.TXT_Merknaam.TabIndex = 1
        '
        'ID_MerkTextBox
        '
        Me.ID_MerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MerkBindingSource, "ID_Merk", True))
        Me.ID_MerkTextBox.Enabled = False
        Me.ID_MerkTextBox.Location = New System.Drawing.Point(256, 19)
        Me.ID_MerkTextBox.Name = "ID_MerkTextBox"
        Me.ID_MerkTextBox.Size = New System.Drawing.Size(38, 20)
        Me.ID_MerkTextBox.TabIndex = 13
        Me.ID_MerkTextBox.TabStop = False
        Me.ID_MerkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Zoek tekst"
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(352, 331)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(109, 23)
        Me.Knop_Opslaan.TabIndex = 18
        Me.Knop_Opslaan.Text = "&Opslaan en sluiten"
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(250, 331)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 19
        Me.Knop_Annuleren.TabStop = False
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_Nieuw
        '
        Me.Knop_Nieuw.Location = New System.Drawing.Point(169, 331)
        Me.Knop_Nieuw.Name = "Knop_Nieuw"
        Me.Knop_Nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Nieuw.TabIndex = 20
        Me.Knop_Nieuw.TabStop = False
        Me.Knop_Nieuw.Text = "&Nieuw"
        Me.Knop_Nieuw.UseVisualStyleBackColor = True
        '
        'F_Merk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 402)
        Me.Controls.Add(Me.Knop_Nieuw)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(LB_Merk)
        Me.Controls.Add(Me.TXT_Zoektekst)
        Me.KeyPreview = True
        Me.Name = "F_Merk"
        Me.Text = "Merken"
        CType(Me.MerkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKProductMerkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_Zoektekst As TextBox
    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents MerkBindingSource As BindingSource
    Friend WithEvents MerkTableAdapter As DS_ProductTableAdapters.MerkTableAdapter
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents ProductTableAdapter As DS_ProductTableAdapters.ProductTableAdapter
    Friend WithEvents FKProductMerkBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MK_BeschrijvingTextBox As TextBox
    Friend WithEvents TXT_Merknaam As TextBox
    Friend WithEvents ID_MerkTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Knop_Nieuw As Button
    Friend WithEvents Knop_Save As Button
End Class

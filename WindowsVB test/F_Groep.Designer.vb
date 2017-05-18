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
        Dim Label1 As System.Windows.Forms.Label
        Dim LBL_Perc As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.DS_Product = New WindowsVB_test.DS_Product()
        Me.GroepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroepTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.GroepTableAdapter()
        Me.TableAdapterManager = New WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager()
        Me.ID_GroepTextBox = New System.Windows.Forms.TextBox()
        Me.LB_Groep = New System.Windows.Forms.ListBox()
        Me.GP_NaamTextBox = New System.Windows.Forms.TextBox()
        Me.GP_BeschrijvingTextBox = New System.Windows.Forms.TextBox()
        Me.GP_KenmerkTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BTWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knop_Save = New System.Windows.Forms.Button()
        Me.Knop_Opslaan = New System.Windows.Forms.Button()
        Me.Knop_Annuleren = New System.Windows.Forms.Button()
        Me.Knop_nieuw = New System.Windows.Forms.Button()
        Me.BTWTableAdapter = New WindowsVB_test.DS_ProductTableAdapters.BTWTableAdapter()
        GP_NaamLabel = New System.Windows.Forms.Label()
        GP_BeschrijvingLabel = New System.Windows.Forms.Label()
        GP_KenmerkLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        LBL_Perc = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BTWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GP_NaamLabel
        '
        GP_NaamLabel.AutoSize = True
        GP_NaamLabel.Location = New System.Drawing.Point(9, 48)
        GP_NaamLabel.Name = "GP_NaamLabel"
        GP_NaamLabel.Size = New System.Drawing.Size(38, 13)
        GP_NaamLabel.TabIndex = 4
        GP_NaamLabel.Text = "Naam:"
        '
        'GP_BeschrijvingLabel
        '
        GP_BeschrijvingLabel.AutoSize = True
        GP_BeschrijvingLabel.Location = New System.Drawing.Point(9, 147)
        GP_BeschrijvingLabel.Name = "GP_BeschrijvingLabel"
        GP_BeschrijvingLabel.Size = New System.Drawing.Size(67, 13)
        GP_BeschrijvingLabel.TabIndex = 6
        GP_BeschrijvingLabel.Text = "Beschrijving:"
        '
        'GP_KenmerkLabel
        '
        GP_KenmerkLabel.AutoSize = True
        GP_KenmerkLabel.Location = New System.Drawing.Point(9, 91)
        GP_KenmerkLabel.Name = "GP_KenmerkLabel"
        GP_KenmerkLabel.Size = New System.Drawing.Size(52, 13)
        GP_KenmerkLabel.TabIndex = 8
        GP_KenmerkLabel.Text = "Kenmerk:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 70)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(62, 13)
        Label1.TabIndex = 21
        Label1.Text = "BTWgroep:"
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
        Me.TableAdapterManager.GetOntvangstTableAdapter = Nothing
        Me.TableAdapterManager.GetProductAddTableAdapter = Nothing
        Me.TableAdapterManager.GPA_AantalTableAdapter = Nothing
        Me.TableAdapterManager.GroepTableAdapter = Me.GroepTableAdapter
        Me.TableAdapterManager.LocatieHolderTableAdapter = Nothing
        Me.TableAdapterManager.LocatieTableAdapter = Nothing
        Me.TableAdapterManager.MerkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsVB_test.DS_ProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValutaTableAdapter = Nothing
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
        Me.LB_Groep.Location = New System.Drawing.Point(15, 18)
        Me.LB_Groep.Name = "LB_Groep"
        Me.LB_Groep.Size = New System.Drawing.Size(153, 251)
        Me.LB_Groep.TabIndex = 3
        Me.LB_Groep.TabStop = False
        '
        'GP_NaamTextBox
        '
        Me.GP_NaamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "GP_Naam", True))
        Me.GP_NaamTextBox.Location = New System.Drawing.Point(76, 45)
        Me.GP_NaamTextBox.Name = "GP_NaamTextBox"
        Me.GP_NaamTextBox.Size = New System.Drawing.Size(192, 20)
        Me.GP_NaamTextBox.TabIndex = 0
        '
        'GP_BeschrijvingTextBox
        '
        Me.GP_BeschrijvingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "GP_Beschrijving", True))
        Me.GP_BeschrijvingTextBox.Location = New System.Drawing.Point(76, 144)
        Me.GP_BeschrijvingTextBox.Multiline = True
        Me.GP_BeschrijvingTextBox.Name = "GP_BeschrijvingTextBox"
        Me.GP_BeschrijvingTextBox.Size = New System.Drawing.Size(192, 62)
        Me.GP_BeschrijvingTextBox.TabIndex = 2
        '
        'GP_KenmerkTextBox
        '
        Me.GP_KenmerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroepBindingSource, "GP_Kenmerk", True))
        Me.GP_KenmerkTextBox.Location = New System.Drawing.Point(76, 88)
        Me.GP_KenmerkTextBox.Multiline = True
        Me.GP_KenmerkTextBox.Name = "GP_KenmerkTextBox"
        Me.GP_KenmerkTextBox.Size = New System.Drawing.Size(192, 55)
        Me.GP_KenmerkTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(LBL_Perc)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Knop_Save)
        Me.GroupBox1.Controls.Add(Me.ID_GroepTextBox)
        Me.GroupBox1.Controls.Add(GP_KenmerkLabel)
        Me.GroupBox1.Controls.Add(Me.GP_KenmerkTextBox)
        Me.GroupBox1.Controls.Add(Me.GP_NaamTextBox)
        Me.GroupBox1.Controls.Add(GP_BeschrijvingLabel)
        Me.GroupBox1.Controls.Add(GP_NaamLabel)
        Me.GroupBox1.Controls.Add(Me.GP_BeschrijvingTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GroepBindingSource, "ID_BTW", True))
        Me.ComboBox1.DataSource = Me.BTWBindingSource
        Me.ComboBox1.DisplayMember = "BTW_Kort"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(76, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "ID_BTW"
        '
        'BTWBindingSource
        '
        Me.BTWBindingSource.DataMember = "BTW"
        Me.BTWBindingSource.DataSource = Me.DS_Product
        '
        'Knop_Save
        '
        Me.Knop_Save.BackgroundImage = Global.WindowsVB_test.My.Resources.Resources.Save_as_icon
        Me.Knop_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Knop_Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Knop_Save.Location = New System.Drawing.Point(6, 12)
        Me.Knop_Save.Name = "Knop_Save"
        Me.Knop_Save.Size = New System.Drawing.Size(31, 30)
        Me.Knop_Save.TabIndex = 18
        Me.Knop_Save.UseVisualStyleBackColor = True
        '
        'Knop_Opslaan
        '
        Me.Knop_Opslaan.Location = New System.Drawing.Point(353, 246)
        Me.Knop_Opslaan.Name = "Knop_Opslaan"
        Me.Knop_Opslaan.Size = New System.Drawing.Size(120, 23)
        Me.Knop_Opslaan.TabIndex = 2
        Me.Knop_Opslaan.Text = "&Opslaan en sluiten"
        Me.Knop_Opslaan.UseCompatibleTextRendering = True
        Me.Knop_Opslaan.UseVisualStyleBackColor = True
        '
        'Knop_Annuleren
        '
        Me.Knop_Annuleren.Location = New System.Drawing.Point(272, 245)
        Me.Knop_Annuleren.Name = "Knop_Annuleren"
        Me.Knop_Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Knop_Annuleren.TabIndex = 12
        Me.Knop_Annuleren.TabStop = False
        Me.Knop_Annuleren.Text = "&Annuleren"
        Me.Knop_Annuleren.UseVisualStyleBackColor = True
        '
        'Knop_nieuw
        '
        Me.Knop_nieuw.Location = New System.Drawing.Point(190, 245)
        Me.Knop_nieuw.Name = "Knop_nieuw"
        Me.Knop_nieuw.Size = New System.Drawing.Size(75, 23)
        Me.Knop_nieuw.TabIndex = 13
        Me.Knop_nieuw.TabStop = False
        Me.Knop_nieuw.Text = "&Nieuw"
        Me.Knop_nieuw.UseVisualStyleBackColor = True
        '
        'BTWTableAdapter
        '
        Me.BTWTableAdapter.ClearBeforeFill = True
        '
        'LBL_Perc
        '
        LBL_Perc.AutoSize = True
        LBL_Perc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BTWBindingSource, "BTW_Perc", True))
        LBL_Perc.Location = New System.Drawing.Point(139, 70)
        LBL_Perc.Name = "LBL_Perc"
        LBL_Perc.Size = New System.Drawing.Size(21, 13)
        LBL_Perc.TabIndex = 22
        LBL_Perc.Text = "[%]"
        LBL_Perc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(152, 70)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(15, 13)
        Label2.TabIndex = 23
        Label2.Text = "%"
        '
        'F_Groep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 284)
        Me.Controls.Add(Me.Knop_nieuw)
        Me.Controls.Add(Me.Knop_Annuleren)
        Me.Controls.Add(Me.Knop_Opslaan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LB_Groep)
        Me.Name = "F_Groep"
        Me.Text = "Product groepen"
        CType(Me.DS_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BTWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_Product As DS_Product
    Friend WithEvents GroepBindingSource As BindingSource
    Friend WithEvents GroepTableAdapter As DS_ProductTableAdapters.GroepTableAdapter
    Friend WithEvents TableAdapterManager As DS_ProductTableAdapters.TableAdapterManager
    Friend WithEvents ID_GroepTextBox As TextBox
    Friend WithEvents LB_Groep As ListBox
    Friend WithEvents GP_NaamTextBox As TextBox
    Friend WithEvents GP_BeschrijvingTextBox As TextBox
    Friend WithEvents GP_KenmerkTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Knop_Opslaan As Button
    Friend WithEvents Knop_Annuleren As Button
    Friend WithEvents Knop_nieuw As Button
    Friend WithEvents Knop_Save As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BTWBindingSource As BindingSource
    Friend WithEvents BTWTableAdapter As DS_ProductTableAdapters.BTWTableAdapter
End Class

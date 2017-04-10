Public Class F_Product
    Dim ProductID As Integer

    Public Sub ToolTipsInstellen()

        ' Create the ToolTip and associate with the Form container.
        Dim TT_Product As New ToolTip()

        ' Set up the delays for the ToolTip.
        TT_Product.AutoPopDelay = 5000
        TT_Product.InitialDelay = 100
        TT_Product.ReshowDelay = 50
        ' Force the ToolTip text to be displayed whether or not the form is active.
        TT_Product.ShowAlways = True
        ' Set up the ToolTip text for the Button and Checkbox.
        TT_Product.SetToolTip(Me.TXT_Verkoopprijs, "Verkoopprijs incl. BTW")
        TT_Product.SetToolTip(Me.TXT_Inkoopwaarde, "Gestelde inkoop- of voorraadwaarde excl.BTW")
        TT_Product.SetToolTip(Me.TXT_Laatste_inkoop_Datum, "Datum, laatste ontvangst van dit product")
        TT_Product.SetToolTip(Me.TXT_LaatsteInkoop_Waarde, "Betaalde bedrag in € ex.BTW")

        ' toolTip1.SetToolTip(Me.Button1, "My button1")
        'toolTip1.SetToolTip(Me.checkBox1, "My checkBox1")

    End Sub



    Private Sub Knop_OpslaanSluiten_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub DT_productBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DT_productBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Product)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            ' Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(IDProductToolStripTextBox.Text, Integer))
            Me.LoadProduct()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ID_ProductTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ID_ProductLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub F_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.ToolTipsInstellen()
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep) 'laad groepen in groep combobox




        'TODO: This line of code loads data into the 'DS_Product.Merk' table. You can move, or remove it, as needed.
        'Me.MerkTableAdapter.Fill(Me.DS_Product.Merk)
        'TODO: This line of code loads data into the 'DS_Product.Groep' table. You can move, or remove it, as needed.
        '

    End Sub

    Public Sub LoadProduct()
        'LET OP volgorde van laden is hier belangrijk
        Me.MerkTableAdapter.Fill(Me.DS_Product.Merk, "%")
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
        ' Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(IDProductToolStripTextBox.Text, Integer))
        Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, ProductID)
    End Sub



    Private Sub TXT_Productnummer_Leave(sender As Object, e As EventArgs) Handles TXT_Productnummer.Leave

        If IsNumeric(Me.TXT_Productnummer.Text) = True Then
            ' Me.TXT_Productnummer.Text = 0
            ProductID = CType(Me.TXT_Productnummer.Text, Integer)
            LoadProduct()
        Else
            MsgBox("Voer een geldig productnummer in", vbExclamation, "Productnummer invoeren")

        End If



    End Sub

    Private Sub Knop_ZoekProduct_Click(sender As Object, e As EventArgs) Handles Knop_ZoekProduct.Click
        F_ProductZoek.ShowDialog()
        ProductID = IDPRODUCT
        Me.TXT_Productnummer.Text = ProductID
        LoadProduct()

    End Sub

    Private Sub PD_Sale_PrijsLabel_MouseHover(sender As Object, e As EventArgs)
        'ToolTip.Show(text:=" tekstje")

    End Sub

    Private Sub PD_Sale_PrijsTextBox_TextChanged(sender As Object, e As EventArgs) Handles TXT_Verkoopprijs.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub txt_Beschrijving1_TextChanged(sender As Object, e As EventArgs) Handles txt_Beschrijving1.TextChanged

    End Sub
    Private Sub OPSLAAN()
        Me.Validate()
        Me.DT_productBindingSource.EndEdit()
        Me.DT_productTableAdapter.Update(DS_Product)

    End Sub

    Private Sub Knop_Delete_Click(sender As Object, e As EventArgs) Handles Knop_Delete.Click
        Dim JaNee As Integer
        JaNee = MsgBox("Weet je zeker dat je dit product wilt verwijderen?", vbYesNo, " Product verwijderen.")
        If JaNee = 6 Then
            Me.DT_productBindingSource.RemoveCurrent()
            OPSLAAN()
            Me.Knop_ZoekProduct.Select()
        End If
    End Sub

    Private Sub Knop_Save_Click(sender As Object, e As EventArgs) Handles Knop_Save.Click
        OPSLAAN()
    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        LoadProduct()
    End Sub

    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        OPSLAAN()
        Me.Close()

    End Sub

    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        Me.DT_productBindingSource.AddNew()
    End Sub
End Class
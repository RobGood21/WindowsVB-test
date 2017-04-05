Public Class F_Product
    Private Sub Knop_OpslaanSluiten_Click(sender As Object, e As EventArgs) Handles Knop_OpslaanSluiten.Click
        Me.Close()

    End Sub

    Private Sub DT_productBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DT_productBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DT_productBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Product)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            ' Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(IDProductToolStripTextBox.Text, Integer))
            Me.LoadProduct()


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ID_ProductTextBox_TextChanged(sender As Object, e As EventArgs) Handles ID_ProductTextBox.TextChanged

    End Sub

    Private Sub ID_ProductLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub F_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Product.Merk' table. You can move, or remove it, as needed.
        'Me.MerkTableAdapter.Fill(Me.DS_Product.Merk)
        'TODO: This line of code loads data into the 'DS_Product.Groep' table. You can move, or remove it, as needed.
        'Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)

    End Sub

    Private Sub Knop_DetailsGroep_Click(sender As Object, e As EventArgs) Handles Knop_DetailsGroep.Click
        Try
            IDGROEP = Me.CB_Groep.SelectedValue
            F_Groep.Show()

        Catch ex As Exception
            MsgBox(ErrorToString)


        End Try





    End Sub

    Public Sub LoadProduct()
        'LET OP volgorde van laden is hier belangrijk
        Me.MerkTableAdapter.Fill(Me.DS_Product.Merk)
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
        Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(IDProductToolStripTextBox.Text, Integer))
    End Sub
End Class
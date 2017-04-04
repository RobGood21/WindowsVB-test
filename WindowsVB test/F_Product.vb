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
            Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(IDProductToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ID_ProductTextBox_TextChanged(sender As Object, e As EventArgs) Handles ID_ProductTextBox.TextChanged

    End Sub

    Private Sub ID_ProductLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
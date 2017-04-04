Public Class F_Groep
    Private Sub GroepBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GroepBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GroepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Product)

    End Sub

    Private Sub F_Groep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Product.Groep' table. You can move, or remove it, as needed.
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)

    End Sub
End Class
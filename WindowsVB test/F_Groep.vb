Public Class F_Groep
    Private Sub GroepBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GroepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Product)
    End Sub
    Private Sub F_Groep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BTWTableAdapter.Fill(Me.DS_Product.BTW)
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
    End Sub
    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        OPSLAAN()
        Me.Close()
    End Sub
    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
    End Sub
    Private Sub Knop_nieuw_Click(sender As Object, e As EventArgs) Handles Knop_nieuw.Click
        Me.GroepBindingSource.AddNew()
    End Sub
    Private Sub Knop_Save_Click(sender As Object, e As EventArgs) Handles Knop_Save.Click
        OPSLAAN()
    End Sub
    Private Sub OPSLAAN()
        Me.Validate()
        Me.GroepBindingSource.EndEdit()
        Me.GroepTableAdapter.Update(Me.DS_Product)
    End Sub
End Class
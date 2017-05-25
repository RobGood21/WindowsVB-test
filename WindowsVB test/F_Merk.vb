Public Class F_Merk
    Private Sub F_Merk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LaadMerk("%")
    End Sub
    Private Sub MerkBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.DS_Product)
    End Sub
    Private Sub Opslaan()
        Me.Validate()
        Me.MerkBindingSource.EndEdit()
        Me.MerkTableAdapter.Update(DS_Product.Merk)
    End Sub
    Private Sub LaadMerk(ZT As String)
        Me.MerkTableAdapter.Fill(Me.DS_Product.Merk, ZT)
    End Sub
    Private Sub TXT_Zoektekst_TextChanged(sender As Object, e As EventArgs) Handles TXT_Zoektekst.TextChanged
        Dim z As String
        z = "%" & Me.TXT_Zoektekst.Text & "%"
        LaadMerk(z)
    End Sub
    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        Opslaan()
        Me.Close()
    End Sub
    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        Me.TXT_Zoektekst.Text = ""
        LaadMerk("%")
    End Sub
    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        Me.MerkBindingSource.AddNew()
        Me.TXT_Merknaam.Select()
    End Sub
    Private Sub Knop_Save_Click(sender As Object, e As EventArgs) Handles Knop_Save.Click
        Opslaan()
        Me.TXT_Merknaam.Select()
    End Sub
End Class
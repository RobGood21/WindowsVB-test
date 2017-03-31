Public Class AlleenDatagrid
    Private Sub GebruikerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GebruikerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GebruikerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSetnew)

    End Sub

    Private Sub AlleenDatagrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OefenDbDataSetnew.Gebruiker' table. You can move, or remove it, as needed.
        Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSetnew.Gebruiker, Me.TXT_Invoer.Text)

    End Sub

    Private Sub KNOP_Reload_Click(sender As Object, e As EventArgs) Handles KNOP_Reload.Click
        Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSetnew.Gebruiker, Me.TXT_Invoer.Text)
    End Sub
End Class
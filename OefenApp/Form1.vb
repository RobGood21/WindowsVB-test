Public Class Form1
    Private Sub GebruikerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GebruikerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OefenDbDataSet.Gebruiker' table. You can move, or remove it, as needed.
        Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet.Gebruiker)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Validate()
        Me.GebruikerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet.Gebruiker)
    End Sub
End Class

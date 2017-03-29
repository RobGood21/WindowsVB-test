Public Class OPnieuw1
    Private Sub GebruikerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GebruikerBindingNavigatorSaveItem.Click

        Try


            Me.Validate()
            Me.GebruikerBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSet)

        Catch ex As Exception
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub OPnieuw1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OefenDbDataSet.Gebruiker' table. You can move, or remove it, as needed.
        Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet.Gebruiker)

    End Sub
End Class
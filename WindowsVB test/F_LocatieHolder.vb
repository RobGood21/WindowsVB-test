Public Class F_LocatieHolder
    Private Sub LocatieHolderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub F_LocatieHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Product.LocatieHolder' table. You can move, or remove it, as needed.
        Me.LocatieHolderTableAdapter.Fill(Me.DS_Product.LocatieHolder)

    End Sub

    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        OPslaan()
        Me.Close()
    End Sub

    Private Sub OPslaan()
        Try
            Me.Validate()
            Me.LocatieHolderBindingSource.EndEdit()
            Me.LocatieHolderTableAdapter.Update(DS_Product.LocatieHolder)
            'Me.TableAdapterManager.UpdateAll(Me.DS_Product)
        Catch ex As Exception
            MsgBox(ErrorToString,, "Opslaan()")
        End Try


    End Sub
End Class
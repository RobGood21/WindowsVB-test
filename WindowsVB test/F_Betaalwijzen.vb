Public Class F_Betaalwijzen
    Private Sub BetaalWijzenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BetaalWijzenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Supplier)

    End Sub

    Private Sub F_Betaalwijzen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Supplier.BetaalWijzen' table. You can move, or remove it, as needed.
        Me.BetaalWijzenTableAdapter.Fill(Me.DS_Supplier.BetaalWijzen)

    End Sub

    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click

        Opslaan()
        Me.Close()

    End Sub

    Private Sub Opslaan()
        Try
            Me.Validate()
            Me.BetaalWijzenBindingSource.EndEdit()
            Me.BetaalWijzenTableAdapter.Update(Me.DS_Supplier.BetaalWijzen)
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try


    End Sub


End Class
Public Class F_Land
    Private Sub LandBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LandBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Supplier)

    End Sub

    Private Sub F_Land_Load(sender As Object, e As EventArgs) Handles MyBase.Load







        'TODO: This line of code loads data into the 'DS_Supplier.Valuta' table. You can move, or remove it, as needed.
        Me.ValutaTableAdapter.Fill(Me.DS_Supplier.Valuta)
        'TODO: This line of code loads data into the 'DS_Supplier.Land' table. You can move, or remove it, as needed.
        Me.LandTableAdapter.Fill(Me.DS_Supplier.Land)

    End Sub

    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Try
            Me.Validate()
            Me.LandBindingSource.EndEdit()
            Me.LandTableAdapter.Update(Me.DS_Supplier.Land)
            Me.Close()
        Catch ex As Exception
            MsgBox(ErrorToString)

        End Try




    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        Try
            Me.LandTableAdapter.Fill(Me.DS_Supplier.Land)
        Catch ex As Exception

        End Try
    End Sub



End Class
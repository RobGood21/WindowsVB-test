Public Class F_Valuta
    Private Sub ValutaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ValutaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Supplier)

    End Sub

    Private Sub F_Valuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Supplier.Valuta' table. You can move, or remove it, as needed.
        Me.ValutaTableAdapter.Fill(Me.DS_Supplier.Valuta)

    End Sub

    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Try
            Me.Validate()
            Me.ValutaBindingSource.EndEdit()
            Me.ValutaTableAdapter.Update(Me.DS_Supplier.Valuta)
            Me.Close()
        Catch ex As Exception
            MsgBox("Opslaan van aanpassingen in valuta is mislukt", vbCritical)

        End Try


    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        Me.ValutaTableAdapter.Fill(Me.DS_Supplier.Valuta)
    End Sub
End Class
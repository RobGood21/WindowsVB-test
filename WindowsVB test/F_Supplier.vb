Public Class F_Supplier
    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SupplierBindingNavigatorSaveItem.Click
        Opslaan()


    End Sub

    Private Sub F_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.GrootboekTableAdapter.Fill(Me.DS_Supplier1.Grootboek)
        Me.ValutaTableAdapter.Fill(Me.DS_Supplier1.Valuta)
        Me.BetaalWijzenTableAdapter.Fill(Me.DS_Supplier.BetaalWijzen)
        Me.LandTableAdapter.Fill(Me.DS_Supplier.Land)
        'TODO: This line of code loads data into the 'DS_Supplier.Supplier' table. You can move, or remove it, as needed.
        'Me.SupplierTableAdapter.Fill(Me.DS_Supplier.Supplier)
        LaadData()


    End Sub

    Private Sub Knop_opslaan_Click(sender As Object, e As EventArgs) Handles Knop_opslaan.Click
        Opslaan()
        Me.Close()
    End Sub

    Private Sub Opslaan()
        Try

            Me.Validate()
            Me.SupplierBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DS_Supplier)

        Catch ex As Exception

            MsgBox(ErrorToString)


        End Try

    End Sub


    Private Sub CB_NaamSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_NaamSupplier.SelectionChangeCommitted
        'Me.txt_ID_LAND_test.Text = Me.txt_ID_LandTextBox.Text
    End Sub

    Private Sub LaadData()

        Me.SupplierTableAdapter.Fill(Me.DS_Supplier.Supplier)

    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        laaddata
    End Sub

    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        Me.SupplierBindingSource.AddNew()
    End Sub
End Class
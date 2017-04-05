Public Class F_Groep
    Private Sub GroepBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GroepBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GroepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Product)

    End Sub

    Private Sub F_Groep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Product.Groep' table. You can move, or remove it, as needed.
        MsgBox(IDGROEP)

        If IsDBNull(IDGROEP) = True Or IDGROEP < 1 Then 'form opent alle records

            Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
        Else 'form opent  1 record
            Me.GroepTableAdapter.FillBy(Me.DS_Product.Groep, IDGROEP)

        End If




    End Sub

    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        IDGROEP = -1 'reset publieke variabele
        Me.Close()

    End Sub
End Class
Public Class F_Groep
    Private Sub GroepBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GroepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Product)

    End Sub

    Private Sub F_Groep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Product.BTW' table. You can move, or remove it, as needed.
        Me.BTWTableAdapter.Fill(Me.DS_Product.BTW)
        'TODO: This line of code loads data into the 'DS_Product.Groep' table. You can move, or remove it, as needed.
        ' MsgBox(IDGROEP)



        ' If IsDBNull(IDGROEP) = True Or IDGROEP < 1 Then 'form opent alle records

        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
        ' Else 'form opent  1 record
        ' Me.GroepTableAdapter.FillBy(Me.DS_Product.Groep, IDGROEP)

        ' End If

    End Sub

    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        'IDGROEP = -1 'reset publieke variabele
        OPSLAAN()

        Me.Close()

    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        Dim IX As Integer 'onthoudt waar de lijst op stond. 
        IX = Me.LB_Groep.SelectedIndex

        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)

        Me.LB_Groep.Select()
        Me.LB_Groep.SelectedIndex = IX 'plaatst lijst keuze weer terug
    End Sub

    Private Sub Knop_nieuw_Click(sender As Object, e As EventArgs) Handles Knop_nieuw.Click
        Me.GroepBindingSource.AddNew()
    End Sub

    Private Sub Knop_Save_Click(sender As Object, e As EventArgs) Handles Knop_Save.Click
        OPSLAAN()

    End Sub
    Private Sub OPSLAAN()
        Me.Validate()
        Me.GroepBindingSource.EndEdit()
        Me.GroepTableAdapter.Update(Me.DS_Product)

    End Sub
End Class
Public Class F_AdmGBrekening
    Private Sub AdmGBrekeningBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdmGBrekeningBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Administratie)

    End Sub

    Private Sub F_AdmGBrekening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Administratie.AdmGBrekening' table. You can move, or remove it, as needed.
        Me.AdmGBrekeningTableAdapter.Fill(Me.DS_Administratie.AdmGBrekening)

    End Sub

    Private Sub Knop_opslaan_Click(sender As Object, e As EventArgs) Handles Knop_opslaan.Click
        opslaan()
    End Sub
    Public Sub opslaan()
        Dim janee As Integer
        janee = MsgBox("Wil je de gemaakte aanpassingen opslaan?", vbYesNoCancel, "Opties bij Formulier sluiten. ")
        Select Case janee 'antwoorden op de vraag wil je opslaan
            Case 2 'annuleren, helemaal niks doen

            Case 7 'nee, niks opslaan en form sluiten
                Me.Close()
            Case 6 'ja, opslaan en form sluiten
                Me.Validate()
                Me.AdmGBrekeningBindingSource.EndEdit()
                Me.AdmGBrekeningTableAdapter.Update(DS_Administratie.AdmGBrekening)
                Me.Close()

        End Select
    End Sub

    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        Me.AdmGBrekeningBindingSource.AddNew()
    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        Me.AdmGBrekeningTableAdapter.Fill(Me.DS_Administratie.AdmGBrekening)
    End Sub
End Class
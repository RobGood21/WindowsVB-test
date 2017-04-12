Public Class F_ProductErbij
    Private Sub CB_Hoeontvangen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Hoeontvangen.SelectedIndexChanged
        'MsgBox(Me.CB_Hoeontvangen.SelectedIndex)
        Select Case Me.CB_Hoeontvangen.SelectedIndex
            Case 0
                Me.GB_Crediteur.Enabled = False
            Case 1
                Me.GB_Crediteur.Enabled = False
            Case 2 'op factuur
                Me.GB_Crediteur.Enabled = True
        End Select

    End Sub

    Private Sub F_ProductErbij_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VeldenInstellen()


    End Sub
    Private Sub VeldenInstellen()
        Me.GB_Crediteur.Enabled = False



    End Sub


End Class
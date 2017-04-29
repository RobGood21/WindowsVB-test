Public Class F_Locatie
    Private Sub LoadForm()
        'wordt uitgevoerd bij opening formulier
        'Twee mogelijkheden, bestaande locatie aanpassen, of nieuwe locatie
        'gebruik IDLOCATIE
        Try
            Me.LocatieHolderTableAdapter.Fill(Me.DS_Product.LocatieHolder)
            If IDLOCATIE < 2 Then 'locatie niet bepaald
                Me.LocatieBindingSource.AddNew()
            Else 'locatie wel bepaald 
                Me.LocatieTableAdapter.Fill(Me.DS_Product.Locatie, IDLOCATIE)
            End If
        Catch ex As Exception
            MsgBox(ErrorToString,, "Loadform()")
        End Try

    End Sub
    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Try
            Me.Validate()
            Me.LocatieBindingSource.EndEdit()
            Me.LocatieTableAdapter.Update(DS_Product.Locatie)
            IDLOCATIE = Me.TXT_LocatieID.Text 'gemaakte locatie doorgeven
            Me.Close()
        Catch ex As Exception
            MsgBox(ErrorToString,, "KNop sluiten")

        End Try

    End Sub
    Private Sub F_Locatie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub MaakCode()
        Dim TeksT As String
        Try
            TeksT = Mid(Me.TXT_HolderCode.Text, 1, 2) & "-R" & Me.TXT_Rij.Text & "-K" & Me.TXT_kolom.Text & "-V" & Me.TXT_Vak.Text
            Me.TXT_locatieCode.Text = TeksT
        Catch ex As Exception
            MsgBox(ErrorToString,, "MaakCode")
        End Try
    End Sub
    Private Sub TXT_Rij_TextChanged(sender As Object, e As EventArgs) Handles TXT_Rij.TextChanged
        MaakCode()
    End Sub
    Private Sub TXT_kolom_TextChanged(sender As Object, e As EventArgs) Handles TXT_kolom.TextChanged
        MaakCode()
    End Sub
    Private Sub TXT_Vak_TextChanged(sender As Object, e As EventArgs) Handles TXT_Vak.TextChanged
        MaakCode()
    End Sub
    Private Sub TXT_HolderCode_TextChanged(sender As Object, e As EventArgs) Handles TXT_HolderCode.TextChanged
        MaakCode()
    End Sub
End Class
Public Class F_Locatie
    Private Sub LoadForm()


        Try
            Me.LocatieHolderTableAdapter.Fill(Me.DS_Product.LocatieHolder)

            If IDLOCATIE < 2 Then 'locatie niet bepaald
                Me.LocatieBindingSource.AddNew()
            Else 'locatie wel bepaald 
                Me.LocatieTableAdapter.Fill(DS_Product.Locatie, IDLOCATIE)
                'MsgBox(IDLOCATIE)
            End If
        Catch ex As Exception
            MsgBox(ErrorToString,, "Loadform()")
        End Try
    End Sub
    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Me.Validate()
        Me.LocatieBindingSource.EndEdit()
        Me.LocatieTableAdapter.Update(DS_Product.Locatie)
        IDLOCATIE = Me.TXT_LocatieID.Text 'gemaakte locatie doorgeven
        Me.Close()
    End Sub
    Private Sub F_Locatie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub MaakCode()
        Dim TeksT As String
        Dim TR As String = Nothing
        Dim TK As String = Nothing
        Dim TV As String = Nothing

        If IsNumeric(Me.TXT_Rij.Text) = True Then
            If Me.TXT_Rij.Text >= 0 Then TR = Trim("-R" & Me.TXT_Rij.Text)
        End If

        If IsNumeric(Me.TXT_kolom.Text) = True Then
            If Me.TXT_kolom.Text >= 0 Then TK = Trim("-K" & Me.TXT_kolom.Text)
        End If

        If IsNumeric(Me.TXT_Vak.Text) = True Then
            If Me.TXT_Vak.Text >= 0 Then TV = Trim("-V" & Me.TXT_Vak.Text)
        End If

        Try
            'TeksT = Mid(Me.TXT_HolderCode.Text, 1, 2) & "-R" & Me.TXT_Rij.Text & "-K" & Me.TXT_kolom.Text & "-V" & Me.TXT_Vak.Text
            TeksT = Trim(Me.TXT_HolderCode.Text) & TR & TK & TV
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
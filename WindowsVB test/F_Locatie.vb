Public Class F_Locatie
    Private UZ As Boolean = False
    Private Sub LoadForm()
        UZ = True
        Try
            Me.LocatieHolderTableAdapter.Fill(Me.DS_Product.LocatieHolder)
            Me.LocatieTableAdapter.Fill(DS_Product.Locatie, IDLOCATIE)
        Catch ex As Exception
            MsgBox(ErrorToString,, "Loadform()")
        End Try
        UZ = False
    End Sub
    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        IDLOCATIE = Me.TXT_LocatieID.Text 'gemaakte locatie doorgeven
        If IDLOCATIE <> LOCATIESTART Then 'voorkomen dat start locatie wordt aangepast
            Me.Validate()
            Me.LocatieBindingSource.EndEdit()
            Me.LocatieTableAdapter.Update(DS_Product.Locatie)
            IDLOCATIE = Me.TXT_LocatieID.Text
        End If
        Me.Close()
    End Sub
    Private Sub F_Locatie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub MaakCode(van As String)

        ' MsgBox(UZ & "  " & van)
        Dim TeksT As String
        Dim TR As String = Nothing
        Dim TK As String = Nothing
        Dim TV As String = Nothing

        If UZ = False Then


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
        End If
    End Sub
    Private Sub TXT_Rij_TextChanged(sender As Object, e As EventArgs) Handles TXT_Rij.TextChanged
        MaakCode("rij")
    End Sub

    Private Sub TXT_kolom_TextChanged(sender As Object, e As EventArgs) Handles TXT_kolom.TextChanged
        MaakCode("kolom")
    End Sub
    Private Sub TXT_Vak_TextChanged(sender As Object, e As EventArgs) Handles TXT_Vak.TextChanged
        MaakCode("vak")
    End Sub
    Private Sub TXT_HolderCode_TextChanged(sender As Object, e As EventArgs) Handles TXT_HolderCode.TextChanged
        MaakCode("code")
    End Sub
    Private Sub Knop_nieuw_Click(sender As Object, e As EventArgs) Handles Knop_nieuw.Click
        Me.LocatieBindingSource.AddNew()
        Me.CB_holder.SelectedValue = LOCATIEHOLDERSTART
        Me.CB_holder.Select()
    End Sub
End Class
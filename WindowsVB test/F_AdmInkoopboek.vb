Public Class F_AdmInkoopboek
    Public Sub ToolTipsInstellen()
        ' Create the ToolTip and associate with the Form container.
        Dim TT_Kosten As New ToolTip()



        ' Set up the delays for the ToolTip.
        TT_Kosten.AutoPopDelay = 5000
        TT_Kosten.InitialDelay = 100
        TT_Kosten.ReshowDelay = 50
        ' Force the ToolTip text to be displayed whether or not the form is active.
        TT_Kosten.ShowAlways = True

        With TT_Kosten
            'Knoppen
            .SetToolTip(Me.Knop_Toon, "Toon bewijsstuk van boeking, factuur")

            'Txt boxen
            .SetToolTip(Me.TXT_Kenmerk, "Factuurnummer, of ander kenmerk van de crediteur")


        End With


    End Sub




    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Me.Close()
    End Sub

    Private Sub AdmInkoopBoekBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdmInkoopBoekBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdmInkoopBoekBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Administratie)

    End Sub



    Public Sub LoadForm()

        ToolTipsInstellen()


        Me.ValutaTableAdapter.Fill(Me.DS_Administratie.Valuta)
        Me.SupplierTableAdapter.Fill(Me.DS_Administratie.Supplier)
        Me.AdmInkoopBoekTableAdapter.Fill(Me.DS_Administratie.AdmInkoopBoek)


    End Sub

    Private Sub F_AdmInkoopboek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Administratie.AdmGBrekening' table. You can move, or remove it, as needed.
        Me.AdmGBrekeningTableAdapter.Fill(Me.DS_Administratie.AdmGBrekening)
        'TODO: This line of code loads data into the 'DS_Administratie.AdmJournaal' table. You can move, or remove it, as needed.
        Me.AdmJournaalTableAdapter.Fill(Me.DS_Administratie.AdmJournaal)
        'TODO: This line of code loads data into the 'DS_Administratie.BetaalWijzen' table. You can move, or remove it, as needed.
        Me.BetaalWijzenTableAdapter.Fill(Me.DS_Administratie.BetaalWijzen)
        'TODO: This line of code loads data into the 'DS_Administratie.Valuta' table. You can move, or remove it, as needed.
        Me.ValutaTableAdapter.Fill(Me.DS_Administratie.Valuta)
        LoadForm()

    End Sub

    Private Sub FormatControls()
        'ff wachten hiermee
        'FormatNumber(Me.TXT_Waarde.Text, , , , TriState.False)
        TXT_Waarde.Text = FormatCurrency(TXT_Waarde.Text)


    End Sub
    Private Sub BerekenWaardeEuro()

        Me.TXT_WaardeEuro.Text = Me.TXT_Waarde.Text * Me.TXT_Koers.Text

        If Me.TXT_Koers.Text = 1 Then
            Me.TXT_BTW.Text = Me.TXT_Waarde.Text / 121 * 21
        Else
            Me.TXT_BTW.Text = 0

        End If
    End Sub

    Private Sub TXT_Waarde_Validated(sender As Object, e As EventArgs) Handles TXT_Waarde.Validated
        BerekenWaardeEuro()
    End Sub



    Private Sub Knop_herlaadForm_Click(sender As Object, e As EventArgs) Handles Knop_herlaadForm.Click
        LoadForm()
    End Sub

    Private Sub Knop_Actie_Click(sender As Object, e As EventArgs) Handles Knop_Actie.Click
        'FormatControls()
    End Sub

    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs)

        Me.AdmInkoopBoekBindingSource.AddNew()
        ClearControls()

    End Sub
    Private Sub ClearControls()
        'gebruik om teksten in controls en dergelijke een beginwaarde te geven
        Me.TXT_WaardeEuro.Text = 0
    End Sub

    Private Sub berekeningen()

    End Sub

    Private Sub Knop_annuleren_Click(sender As Object, e As EventArgs)
        ClearControls()
        Me.AdmInkoopBoekTableAdapter.Fill(Me.DS_Administratie.AdmInkoopBoek)
    End Sub

    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs)
        Opslaan()

    End Sub
    Private Sub Opslaan()
        Me.Validate()
        Me.AdmInkoopBoekBindingSource.EndEdit()
        Me.AdmInkoopBoekTableAdapter.Update(DS_Administratie.AdmInkoopBoek)
    End Sub

    Private Sub Knop_Toon_Click(sender As Object, e As EventArgs) Handles Knop_Toon.Click
        MsgBox("met deze knop een document openen, bewijs stuk, scan of pdf van de facuur")
    End Sub
End Class
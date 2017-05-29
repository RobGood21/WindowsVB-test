Public Class F_Supplier
    Public Sub ToolTipsInstellen()
        ' Create the ToolTip and associate with the Form container.
        Dim TT_Supplier As New ToolTip()
        ' Set up the delays for the ToolTip.
        TT_Supplier.AutoPopDelay = 5000
        TT_Supplier.InitialDelay = 100
        TT_Supplier.ReshowDelay = 50
        ' Force the ToolTip text to be displayed whether or not the form is active.
        TT_Supplier.ShowAlways = True
        ' Set up the ToolTip text for the Button and Checkbox.
        'Knoppen
        With TT_Supplier
            'Knoppen
            .SetToolTip(Me.Knop_opslaan, "Alle invoer en aanpassingen opslaan en formulier sluiten")
            'Textboxes en comboos
            .SetToolTip(Me.CB_Grootboek, "Geef het standaard grootboek catagorie van deze leverancier")
            'óverige
            TT_Supplier.SetToolTip(CH_Actief, "Deze leverancier zichtbaar in lijsten en comboboxen")

            'TT_Supplier.SetToolTip(Me.TXT_Laatste_inkoop_Datum, "Datum, laatste ontvangst van dit product")
            'TT_Supplier.SetToolTip(Me.TXT_LaatsteInkoop_Waarde, "Betaalde bedrag in € ex.BTW")

            ' TT_Supplier.SetToolTip(Me.Button1, "My button1")
            'TT_Supplier.SetToolTip(Me.checkBox1, "My checkBox1")
        End With
    End Sub
    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Opslaan()
    End Sub
    Private Sub F_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTipsInstellen()
        Me.ValutaTableAdapter.Fill(Me.DS_Supplier.Valuta)
        Me.BetaalWijzenTableAdapter.Fill(Me.DS_Supplier.BetaalWijzen)
        Me.LandTableAdapter.Fill(Me.DS_Supplier.Land)
        Me.AdmGBrekeningTableAdapter.Fill(Me.DS_Supplier.AdmGBrekening)
        LaadData()
    End Sub
    Private Sub Knop_opslaan_Click(sender As Object, e As EventArgs) Handles Knop_opslaan.Click
        Dim janee As Integer = 6
        If CH_Actief.Checked = False Then
            janee = MsgBox("Zichtbaar is uit." & Chr(13) & "Leverancier is straks niet meer terug te vinden. Weet je zeker dat je deze leverancier wilt verwijderen?", vbYesNo, "Leverancier verwijderen?")
        End If
        If janee = 6 Then
            Opslaan()
            Me.Close()
        End If
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
        '  MsgBox(OPSUPPLIER)
        Select Case OPSUPPLIER
            Case 1
                Me.SupplierTableAdapter.FillByIDSUPPLIER(Me.DS_Supplier.Supplier, CType(IDSUPPLIER, Integer))
            Case Else
                Me.SupplierTableAdapter.Fill(Me.DS_Supplier.Supplier)
        End Select
    End Sub
    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs)
        LaadData()
    End Sub
    Private Sub Knop_Link_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub CB_NaamSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_NaamSupplier.SelectedIndexChanged
    End Sub
    Private Sub CB_Grootboek_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Grootboek.SelectedIndexChanged
    End Sub
    Private Sub Knop_Delete_Click(sender As Object, e As EventArgs)
        Dim janee As Integer
        janee = MsgBox("Weet je zeker dat je deze leverancier uit de lijst leveranciers wilt verwijderen?", vbYesNo, "Verwijderen leverancier bevestigen.")
    End Sub
    Private Sub Knop_alleSuppliers_Click(sender As Object, e As EventArgs)
        Me.SupplierTableAdapter.Fill(Me.DS_Supplier.Supplier)
    End Sub
    Private Sub Tknop_Sluit_Click(sender As Object, e As EventArgs) Handles Tknop_Sluit.Click
        Dim jn As Integer
        jn = MsgBox("Venster sluiten zonder de veranderingen op te slaan?", vbQuestion + vbYesNo, "veranderingen of invoer niet opslaan...")
        If jn = 6 Then Me.Close()
    End Sub
    Private Sub Tknop_nieuw_Click(sender As Object, e As EventArgs) Handles Tknop_nieuw.Click
        Me.SupplierBindingSource.AddNew()
        Me.Ch_Webwinkel.Checked = False
        Me.Ch_Winkel.Checked = False
        Me.CH_Actief.Checked = False
        Me.CH_Actief.Checked = True
    End Sub
    Private Sub Tknop_Annuleren_Click(sender As Object, e As EventArgs) Handles Tknop_Annuleren.Click
        LaadData()
    End Sub
    Private Sub Tknop_Opslaan_Click(sender As Object, e As EventArgs) Handles Tknop_Opslaan.Click
        Opslaan()
    End Sub
    Private Sub Tknop_Website_Click(sender As Object, e As EventArgs) Handles Tknop_Website.Click
        Dim HyperLink As String
        HyperLink = Me.TXT_Website.Text
        System.Diagnostics.Process.Start(HyperLink)
    End Sub
End Class
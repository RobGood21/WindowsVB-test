Public Class F_AdmInkoopboek
    'Variabelen definieren
    Private DEBETT As Decimal = 0
    Private CREDITT As Decimal = 0
    Private IDGO As Integer = 0
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
            .SetToolTip(Me.Knop_Journaal, "Maak journaalposten automatisch")
            .SetToolTip(Me.Knop_Nieuweregel, "Voeg een nieuwe journaalpost in")
            .SetToolTip(Me.Knop_Bereken, "Bereken en pas automatisch de waardes in de journaalposten aan")
            .SetToolTip(Me.Knop_Close, "Sluit het formulier, er wordt niets opgeslagen")
            .SetToolTip(Me.Knop_Sluiten, "Veranderingen opslaan en formulier sluiten")
            .SetToolTip(Me.Knop_Annuleren, "Veranderinge en invoer wissen")
            .SetToolTip(Me.Knop_Nieuw, "Veranderingen opslaan, nieuwe invoer ")

            'Txt boxen
            .SetToolTip(Me.TXT_Kenmerk, "Factuurnummer, of ander kenmerk van de crediteur")
            .SetToolTip(Me.TXT_GrootboekCR, "Grootboekrekening van betaalwijze")

        End With


    End Sub
    Private Sub AdmInkoopBoekBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdmInkoopBoekBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Administratie)

    End Sub
    Public Sub LoadTables()
        Me.AdmGBrekeningTableAdapter.Fill(Me.DS_Administratie.AdmGBrekening)
        Me.BetaalWijzenTableAdapter.Fill(Me.DS_Administratie.BetaalWijzen)
        Me.ValutaTableAdapter.Fill(Me.DS_Administratie.Valuta)
    End Sub
    Public Sub LoadForm()
        Try
            ToolTipsInstellen()
            JourNaalInstellen() 'opmaak van het datagridview
            'Me.AdmInkoopBoekTableAdapter.Fill(Me.DS_Administratie.AdmInkoopBoek, -1)
            LoadTables()

            Select Case OPADMINKOOP
                Case 1 'van form getontvangst NIeuw, dsnog geen inkoopboek record aan deze ontvangst
                    Me.AdmInkoopBoekBindingSource.AddNew()
                    Me.SupplierTableAdapter.Fill(Me.DS_Administratie.Supplier) 'alle suppliers in de combobox
                    'MsgBox(Me.AdmInkoopBoekBindingSource.Count)
                    Me.CB_Supplier.SelectedValue = IDSUPPLIER
                    ClearControls()
                    'nieuwe record direct vastleggen
                    Me.Validate()
                    Me.AdmInkoopBoekBindingSource.EndEdit()
                    Me.AdmInkoopBoekTableAdapter.Update(DS_Administratie.AdmInkoopBoek)

                    'data van parentform halen
                    IDGO = F_GetProduct.CB_Ontvangen.SelectedValue

                    'parent form direct aanpassen
                    F_GetProduct.TXT_AdmInkoop.Text = Me.TXT_Boeknummer.Text
                    F_GetProduct.Validate()
                    F_GetProduct.GetOntvangstBindingSource.EndEdit()
                    F_GetProduct.GetOntvangstTableAdapter.Update(F_GetProduct.DS_Product.GetOntvangst)
                    'F_GetProduct.TXT_Boekwaarde.Text = Me.TXT_WaardeEuro.Text
                    IDADMINKOOP = Me.TXT_Boeknummer.Text 'publieke variable aanpassen
                    Me.AdmJournaalTableAdapter.Fill(Me.DS_Administratie.AdmJournaal, IDADMINKOOP) 'journaalposten laden

                Case 2 'van form getontvangst, idadminkoop = nu bepaald
                    Me.SupplierTableAdapter.Fill(Me.DS_Administratie.Supplier) 'alle suppliers laden
                    Me.AdmInkoopBoekTableAdapter.Fill(Me.DS_Administratie.AdmInkoopBoek, IDADMINKOOP)
                    'Me.CB_Supplier.Enabled = False
                    Me.CB_Supplier.DropDownStyle = ComboBoxStyle.Simple
                    Me.AdmJournaalTableAdapter.Fill(Me.DS_Administratie.AdmJournaal, IDADMINKOOP)
                    JournaalTotaal()
                    Me.TXT_DebetTotaal.Text = DEBETT
                    Me.TXT_CreditTotaal.Text = CREDITT
                    ' LoadTables()
                    CheckBoxLoad() 'velden instellen afhankelijk van betaald
                    Me.Knop_Nieuw.Enabled = False 'nieuw record aanmaken onmogelijk maken
                    Me.Knop_Annuleren.Enabled = False
                    'Gegevens op Parentform aanpassen
                    'F_GetProduct.TXT_Boekwaarde.Text = Me.TXT_WaardeEuro.Text

                    'data van parentform halen
                    IDGO = F_GetProduct.CB_Ontvangen.SelectedValue

                Case 3 'openen met een vooraf bepaald adminkoopnummer, dus na een zoekactie

                Case Else 'openen als nieuwe invoer, niet afhankelijk van getproduct(ontvangst)
                    NieuweInkoop()
            End Select

        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub
    Public Sub NieuweInkoop()
        Me.AdmInkoopBoekBindingSource.AddNew()
        Me.SupplierTableAdapter.Fill(Me.DS_Administratie.Supplier) 'alle suppliers in de combobox
        LoadTables()
        Me.CB_Supplier.SelectedValue = -1
        'Me.CB_BetaalWijze.SelectedValue = -1
        'Me.CB_Valuta.SelectedValue = -1
        ClearControls()
        Me.CB_Supplier.Select()
        Me.AdmJournaalTableAdapter.Fill(Me.DS_Administratie.AdmJournaal, 0)
    End Sub
    Public Sub JourNaalInstellen()
        Me.DG_Journaal.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DG_Journaal.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DG_Journaal.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DG_Journaal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DG_Journaal.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DG_Journaal.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Public Sub JournaalTotaal()
        'berekend de totalen ingevoerd in journaalposten
        Dim i As Integer
        DEBETT = 0
        CREDITT = 0
        For i = 0 To Me.DG_Journaal.Rows.Count - 1
            Me.DG_Journaal.Rows(i).Selected = False
            DEBETT = DEBETT + Me.DG_Journaal.Rows(i).Cells(5).Value
            CREDITT = CREDITT + Me.DG_Journaal.Rows(i).Cells(6).Value
        Next
    End Sub
    Private Sub F_AdmInkoopboek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub BerekenWaardeEuro()
        Try
            If IsNumeric(Me.TXT_Waarde.Text) = True Then
                Me.TXT_WaardeEuro.Text = ((Me.TXT_Waarde.Text * Me.TXT_Koers.Text).ToString("c"))
                If Me.TXT_Koers.Text = 1 Then
                    Me.TXT_BTW.Text = ((Me.TXT_Waarde.Text / 121 * 21).ToString("c"))
                Else
                    Me.TXT_BTW.Text = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ErrorToString,, "berekenwaardeEuro")
        End Try



    End Sub
    Private Sub Knop_Actie_Click(sender As Object, e As EventArgs)
        'FormatControls()
    End Sub
    Private Sub ClearControls()
        'gebruik om teksten in controls en dergelijke een beginwaarde te geven bij aanmaak NIEUW record
        Me.IB_Datum.Value = Now
        Me.IB_DueDatum.Value = Now
        Me.IB_betaaldatum.Value = Me.IB_betaaldatum.MinDate

        Me.TXT_Waarde.Text = 0
        Me.TXT_WaardeEuro.Text = 0
        Me.TXT_BTW.Text = 0

        Me.CH_Betaald.Checked = False
    End Sub
    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        OpslaanAlles(True)
    End Sub
    Public Sub OpslaanAlles(Sluiten As Boolean)

        'dit slaat alles op, en sluit het formulier

        If Valideer() = True Then 'alles opslaan en form sluiten

            Me.Validate()
            Me.AdmInkoopBoekBindingSource.EndEdit()
            Me.AdmJournaalBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DS_Administratie)

            If Sluiten = True Then
                Me.Close()
                F_GetProduct.TXT_Boekwaarde.Text = Me.TXT_WaardeEuro.Text
            Else 'nieuw invoer aanmaken
                NieuweInkoop()
            End If
        End If

    End Sub
    Private Function OpslaanInkoop() As Integer
        'Slaat de factuur, kenmerk op (dus niet het journaal)
        Try
            OpslaanInkoop = False

            If Me.CB_Supplier.SelectedValue > 0 Then
                If Len(Me.TXT_Kenmerk.Text) > 0 Then
                    If Len(txt_grootboekSupplier.Text) > 0 And Len(TXT_SUPValuta.Text) > 0 Then
                        If Me.TXT_WaardeEuro.Text <> 0 Then
                            Me.Validate()
                            Me.AdmInkoopBoekBindingSource.EndEdit()
                            Me.AdmInkoopBoekTableAdapter.Update(DS_Administratie.AdmInkoopBoek)
                            OpslaanInkoop = True
                        Else
                            MsgBox("De bedragen zijn niet juist ingevuld.", vbExclamation, "Opslaan in inkoopboek niet mogelijk ")
                        End If
                    Else
                        MsgBox("Er ontbreken noodzakelijke gegevens van deze leverancier, crediteur" & Chr(13) & Chr(13) & "Vul op het formulier leverancier, supplier de gegevens verder in", vbExclamation, "Opslaan in inkoopboek niet mogelijk")
                    End If
                Else
                    MsgBox("Kenmerk van de factuur moet worden ingevuld", vbExclamation, "Opslaan in inkoopboek niet mogelijk")
                End If
            Else
                MsgBox("Er is geen leverancier, crediteur gekozen", vbExclamation, "Opslaan in inkoopboek niet mogelijk")
                Me.CB_Supplier.Select()
            End If


        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
        Return OpslaanInkoop

    End Function
    Private Sub Knop_Toon_Click(sender As Object, e As EventArgs) Handles Knop_Toon.Click
        MsgBox("met deze knop een document openen, bewijs stuk, scan of pdf van de facuur")
    End Sub
    Private Sub Knop_Nieuweregel_Click(sender As Object, e As EventArgs) Handles Knop_Nieuweregel.Click

        If Me.DG_Journaal.Rows.Count > 1 Then

            JN_Regel(0, 0, 0)

        Else
            MsgBox("Je kan geen regels toevoegen.",, " Lijst Is leeg")

        End If



    End Sub
    Private Sub JN_Regel(GB As Integer, DB As Decimal, CR As Decimal) '1=automatisch, 2=handmatig
        Dim Rij As Integer

        'maakt regel in journaal posten
        'Cells 0=id 1=soort boek (1=inkoop (crediteuren) boek 2=Boekstuknummer (deze factuur dus) 3=datum 4= grootboekrekening 5 =debet bedrag 6 = credit bedrag
        'Merk op dat inkoopboek NIET uit DB komt dus zorg dat deze waarde niet veranderd in de dbtabel admboek

        'hoeveel rows zijn er al?
        Rij = Me.DG_Journaal.Rows.Count

        'ID_getontvangst aan Journaal meegeven om journaals zicht baat te keijgen in getontvangst

        Try
            Me.AdmJournaalBindingSource.AddNew()
            DG_Journaal.Rows(Rij).Cells(1).Value = 1 'journaalpost hoort bij administratief boek 'Inkoopboek'
            DG_Journaal.Rows(Rij).Cells(2).Value = Me.TXT_Boeknummer.Text
            DG_Journaal.Rows(Rij).Cells(3).Value = Now()
            DG_Journaal.Rows(Rij).Cells(4).Value = GB
            DG_Journaal.Rows(Rij).Cells(5).Value = DB
            DG_Journaal.Rows(Rij).Cells(6).Value = CR
            DG_Journaal.Rows(Rij).Cells(7).Value = IDGO 'geef het onderliggende getontvangst nummer mee aan ieder journaalpost (of een 0)

            DEBETT = DEBETT + DB
            CREDITT = CREDITT + CR

            Me.TXT_DebetTotaal.Text = DEBETT
            Me.TXT_CreditTotaal.Text = CREDITT

        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub
    Private Sub JN_Boeken() 'maakt alle standaard journaalboekingen aan 
        If DG_Journaal.Rows.Count = 0 Then
            DEBETT = 0
            CREDITT = 0
            Dim GB As Integer
            Dim DB As Decimal
            Dim CR As Decimal
            '1e regel totaal ex.btw aan grootboek van crediteur
            GB = Me.txt_grootboekSupplier.Text
            DB = ((Me.TXT_Waarde.Text * TXT_Koers.Text - TXT_BTW.Text).ToString("C2"))
            CR = 0
            JN_Regel(GB, DB, CR)
            '2e regel BTW alleen als er BTW is.
            If TXT_BTW.Text <> 0 Then
                GB = 1520
                DB = Me.TXT_BTW.Text
                CR = 0
                JN_Regel(GB, DB, CR)
            End If
            '3e regel
            If Me.CH_Betaald.Checked = False Then 'journaa post crediteuren maken (te betalen) = grootboek 1610

                JN_Regel(1610, 0, Me.TXT_WaardeEuro.Text)
            Else 'is betaald, grootboekrekenng die is meegegeven met betaalwijze
                JN_Regel(Me.TXT_GrootboekCR.Text, 0, TXT_WaardeEuro.Text)
            End If

        Else
            MsgBox("je kunt niet automatisch de posten aanmaken.",, "Lijst is niet leeg")
        End If

    End Sub
    Private Sub CH_Betaald_CheckedChanged(sender As Object, e As EventArgs) Handles CH_Betaald.CheckedChanged
        CheckBoxLoad()
    End Sub
    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        NieuweInkoop()
    End Sub
    Private Sub Knop_Journaal_Click(sender As Object, e As EventArgs) Handles Knop_Journaal.Click
        Try
            If OpslaanInkoop() = True Then 'inkooprecord, dus crediteur en waardes vastleggen in db
                JN_Boeken()
            End If
        Catch ex As Exception
            MsgBox(ErrorToString,, "knop_journaal click")
        End Try


    End Sub
    Private Sub Knop_Bereken_Click(sender As Object, e As EventArgs) Handles Knop_Bereken.Click
        Bereken()

    End Sub
    Private Sub DG_Journaal_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Journaal.CellValidated
        Bereken()
    End Sub
    Private Sub Bereken()
        DEBETT = 0
        CREDITT = 0
        'herberekenen van de ingevoerde journaalposten. 
        'Teveel aan Debet wordt afgehaald van eerste post, meestal voorraad.
        Dim i As Integer
        For i = 0 To Me.DG_Journaal.Rows.Count - 1
            DEBETT = DEBETT + Me.DG_Journaal.Rows(i).Cells(5).Value
            CREDITT = CREDITT + Me.DG_Journaal.Rows(i).Cells(6).Value
        Next

        Me.DG_Journaal.Rows(0).Cells(5).Value = DG_Journaal.Rows(0).Cells(5).Value - (DEBETT - CREDITT)

        Me.TXT_DebetTotaal.Text = DEBETT
        Me.TXT_CreditTotaal.Text = CREDITT

    End Sub
    Private Function Valideer() As Integer
        Valideer = True

        'BELANGRIJK zet de current cell in de eerste rij
        'Me.DG_Journaal.CurrentCell = Me.DG_Journaal(0, 7)

        Me.DG_Journaal.EndEdit()
        JournaalTotaal()
        If (DEBETT <> CREDITT) Or Me.DG_Journaal.Rows.Count < 1 Then
            MsgBox("Journaalposten zijn niet correct ingevoerd", vbCritical, "Fout in journaalposten")
            Valideer = False
            Exit Function
        End If

    End Function
    Private Sub Knop_Close_Click(sender As Object, e As EventArgs) Handles Knop_Close.Click
        Dim janee As Integer
        janee = MsgBox("Formulier wordt afgesloten, zonder de veranderingen op te slaan" & Chr(13) & Chr(13) & "Weet je zeker dat je het formulier wilt sluiten?", vbYesNo, "Formulier sluiten...")
        If janee = 6 Then Me.Close()
    End Sub
    Private Sub F_AdmInkoopboek_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Zorgen dat de open status wordt gereset.
        OPADMINKOOP = 0
    End Sub
    Public Sub CheckBoxLoad()
        If CH_Betaald.Checked = True Then
            Me.CB_BetaalWijze.Enabled = True
            Me.IB_betaaldatum.Enabled = True
        Else
            Me.CB_BetaalWijze.Enabled = False
            Me.IB_betaaldatum.Enabled = False

        End If

    End Sub
    Private Sub TXT_Waarde_Validated(sender As Object, e As EventArgs) Handles TXT_Waarde.Validated
        BerekenWaardeEuro()
    End Sub
    Private Sub CB_Valuta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Valuta.SelectedIndexChanged
        ' BerekenWaardeEuro()
    End Sub
    Private Sub TXT_Koers_TextChanged(sender As Object, e As EventArgs)
        BerekenWaardeEuro()
    End Sub
    Private Sub CB_Supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Supplier.SelectedIndexChanged

    End Sub
    Private Sub TXT_SUPValuta_TextChanged(sender As Object, e As EventArgs) Handles TXT_SUPValuta.TextChanged
        Select Case IDADMINKOOP
            Case 2
                CB_Valuta.SelectedValue = Me.TXT_SUPValuta.Text
        End Select

    End Sub
    Private Sub TXT_SupBetaalWijze_TextChanged(sender As Object, e As EventArgs) Handles TXT_SupBetaalWijze.TextChanged
        Try
            Select Case IDADMINKOOP
                Case 1
                Case 2
                    CB_BetaalWijze.SelectedValue = Me.TXT_SupBetaalWijze.Text
                Case 3
                Case Else

            End Select

        Catch ex As Exception
            MsgBox(ErrorToString,, "TXT_subbetaalwijze_text enz")
        End Try

    End Sub
    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        OpslaanAlles(False)
    End Sub
End Class
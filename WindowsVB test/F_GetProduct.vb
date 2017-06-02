Public Class F_GetProduct
    'Opmerkingen:
    '    productlijst, uit tabel getontvangst (naam is een drama, getlijst? getproducten? maar goed is dus getontvangst geworden, erg verwarrend mee eens...) 
    '    heeft items uit tabel getproductadd, deze productlijst Is om te zetten naar een bestelling Of ontvangst
    '    tabel Is te vullen met handmatig toevoegen, of kiezen uit bestelde producten, door klanten bestelde producten of adviesen door minimale voorraad.
    '    Het veld In de productlijst, getontvangst, status dan zetten. 1=inbehandelng 2=Bestelling (bij leverancer) 3=Ontvangen in voorraad.
    'Volgorde van colums in de datagrids is essentieel. 
    'DG_lijst (0) = IDGetproductadd (1)= IDproduct(2)=IDgetontvangst (3)= Ontvangen aantal (4)= besteld aantal 
    '(5)=Lijstaantal (6) =Product (beschrijving) (7)= locatie  (8) = inkoop (9)= voorraad 
    'status veld GV_status  =record 1=inbehandeling 2=bestelling bij leverancier 3=ontvangst aan voorraad 4=verkoop, gebruik 5=Project

    ' verwijderen uit datagridview  DG_Lijst.Rows.Remove(DG_Lijst.Rows(DG_Lijst.SelectedCells.Item(0).RowIndex))
    Dim BeVat As Boolean = False
    Dim STATUS As Integer = 1 'als boven 
    Public Sub ToolTipsInstellen()
        Dim TT_GetProduct As New ToolTip()
        ' Set up the delays for the ToolTip.
        TT_GetProduct.AutoPopDelay = 5000
        TT_GetProduct.InitialDelay = 100
        TT_GetProduct.ReshowDelay = 50
        ' Force the ToolTip text to be displayed whether or not the form is active.
        TT_GetProduct.ShowAlways = True
        ' Set up the ToolTip text for the Button and Checkbox.
        'Knoppen
        With TT_GetProduct
            'Knoppen
            .SetToolTip(Me.Knop_Nieuw, "Maak een nieuwe productlijst")
            '.SetToolTip(Me.Knop_Opslaan, "Productlijst tussendoor opslaan")
            .SetToolTip(Me.Knop_Project_bereken, "Bereken de totalen in de velden")
            '.SetToolTip(Me.Knop_Annuleren, "alle invoer ongedaan maken")
            '.SetToolTip(Me.Knop_Opslaan, "Alle invoer en aanpassingen opslaan en formulier sluiten")
            '.SetToolTip(Me.Knop_Save, "Alle invoer (tussentijds) opslaan.")
            'voor push
            .SetToolTip(Me.Knop_Push_Bereken, "Bereken de totalen van de productlijst")


            'Textboxes en comboos
            .SetToolTip(Me.TXT_NaamGet, "Het kenmerk van deze productlijst")
            .SetToolTip(Me.TXT_Project_Max, "Het aantal projecten wat met de huidige voorraad maximaal kan worden samengesteld")
            .SetToolTip(Me.TXT_Project_Voorraad, "Het voorraad aantal van dit project")
            .SetToolTip(Me.TXT_Project_AantalMaak, "Geef hoeveel je van dit project wilt samenstellen.")

            'Overige
            .SetToolTip(Me.CB_Ontvangen, "Kies een productlijst in behandeling")
        End With
    End Sub
    Private Sub INITvelden()
        Me.TB_Products.SelectTab(0)
        Me.TB_Doel.SelectTab(0)
        Me.txt_Status.Text = 1 'statusveld naar 1 (in behandeling)
        Me.Optie_Open.Checked = True
        Me.CH_AlleBestel.Checked = True
        Me.CH_AlleOntvangst.Checked = True
        INITkosten()
        Me.CB_Push_soort.SelectedIndex = 0
    End Sub
    Private Sub INITkosten()
        Me.TXT_Boekwaarde.Text = FormatNumber(0, -1)
        'Me.TXT_Lijstwaarde.Text = FormatNumber(0, -1)
        Me.BeVat = False
    End Sub
    Private Sub F_GetProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTipsInstellen()
        LaadForm()
    End Sub
    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Me.Close()
    End Sub
    Public Sub Opslaan()
        'slaat het parent record op getontvangen, dus de container van het geheel. 
        Try
            Me.Validate()
            Me.GetOntvangstBindingSource.EndEdit()
            Me.GetOntvangstTableAdapter.Update(Me.DS_Product.GetOntvangst) 'Alleen de GETONTVANGST updaten voorkomt ongewenste aanpassingen
            ' direct gegevens weer terugladen NEE geen goed idee 7/5/2017
            'Me.GetOntvangstTableAdapter.Fill(Me.DS_Product.GetOntvangst)
            ' LaadProductList()
        Catch ex As Exception
            MsgBox(ErrorToString,, "Opslaan()")
        End Try
    End Sub
    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs)
        'knop straks weghalen.... is onnodig en onwenselijk

        Opslaan()
        'Me.GetOntvangstTableAdapter.Fill(Me.DS_Product.GetOntvangst) 'opnieuw combo productlijsten laden, is niet een goed idee...
    End Sub
    Private Sub Knop_Herlaad_Click(sender As Object, e As EventArgs)
        LaadForm()

    End Sub
    Public Sub LaadForm()
        Try
            Me.SupplierTableAdapter.Fill(Me.DS_Product.Supplier)

            Me.LaadShop(1)
            LaadGetOntvangst(1)

            INITvelden()
            OpmaakJournaal() 'opmaak van datagrid journaal

            ' MsgBox("laadform")
            'LaadProductList()


        Catch ex As Exception
            MsgBox(ErrorToString,, "Laadform")
        End Try
    End Sub
    Private Sub LaadGetOntvangst(STATUS As Integer)
        'Laad in het zoekvak container records (getontvangst) per sectie 
        '1=inbehandeling(ope) 2=bestelling bij leverancier(besteld) 3=ontvangst aan voorraad(onvangst) 4=verkoop, gebruik(verbruik) 5=Project
        Me.GetOntvangstTableAdapter.Fill(Me.DS_Product.GetOntvangst, STATUS)
        Select Case STATUS
            Case 5
                'productenlijst herladen
                LaadProductList()
        End Select
    End Sub
    Private Sub LaadProduct()
        'laad de product gegevens (voor project)
        If IsNumeric(Me.TXT_Project_ProductID.Text) = True Then
            Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, Me.TXT_Project_ProductID.Text)
        End If
    End Sub
    Public Sub LaadShop(Hoe As Integer) '1=van Detailknop 2 = van cb_supplier change
        'laad de mogelijke keuzes in de shop combobox 
        Select Case Hoe
            Case 1
                'volledige 'Shoptabel lade
                Me.ShopTableAdapter.Fill(DS_Product.Shop)

            Case 2
                Me.ShopTableAdapter.FillBySUPPLIER(DS_Product.Shop, Me.CB_Supplier.SelectedValue)
        End Select
    End Sub
    Public Sub LaadProductList()
        Select Case Me.TB_Products.SelectedIndex
            Case 0 'productlijst
                Me.GetProductListTableAdapter.Fill(Me.DS_Product.GetProductList, Me.CB_Ontvangen.SelectedValue)
                If Me.DG_Lijst.Rows.Count > 0 Then
                    BerekenProject()
                Else
                    Me.TXT_Lijstwaarde.Text = FormatNumber(0, -1)
                End If
            Case 1 'ontvangenlijst
                'laad de data in de datagridview ontvangen producten DG_ontvangen
                If Me.CH_AlleOntvangst.Checked = True Then
                    Me.GPA_OntvangenLijstTableAdaptor_.Fill(DS_Product.GPA_OntvangenLijst_, Me.CB_Supplier.SelectedValue)
                Else
                    Me.GPA_OntvangenLijstTableAdaptor_.FillByIDGO(DS_Product.GPA_OntvangenLijst_, Me.CB_Supplier.SelectedValue, Me.TXT_getontvangstid.Text)
                End If
            Case 2 'besteld
                Dim IDSUP As Integer = 0
                'MsgBox("Nu blad gekozen, hier nu de bestelling lijst maken en vullen")
                If Me.CH_AlleBestel.Checked = True Then
                    Me.GPA_BesteldTableAdapter.Fill(Me.DS_Product.GPA_Besteld, Me.CB_Supplier.SelectedValue)
                Else
                    'denkbaar dat er geen supplier is bepaald, dit uitvangen
                    If IsNumeric(Me.CB_Supplier.SelectedValue) = False Then
                        IDSUP = 0
                    Else
                        IDSUP = Me.CB_Supplier.SelectedValue
                    End If
                    If IsNumeric(Me.TXT_getontvangstid.Text) = True Then Me.GPA_BesteldTableAdapter.FillByIDGO(Me.DS_Product.GPA_Besteld, IDSUP, Me.TXT_getontvangstid.Text)
                End If
            Case 3 'verbruikt
                Me.JN_LijstDatatable.Fill(DS_Administratie.JN_Lijst, Me.CB_Ontvangen.SelectedValue)
        End Select
    End Sub
    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        GetOntvangstBindingSource.AddNew() 'nieuwe order, ontvangst aanmaken
        Me.DA_Datum.Value = Now() 'aanmaakdatum instellen
        INITvelden()
        Me.TXT_NaamGet.Select()
    End Sub
    Private Sub CB_Supplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Supplier.SelectionChangeCommitted

    End Sub
    Private Sub TXT_getontvangstid_TextChanged(sender As Object, e As EventArgs) Handles TXT_getontvangstid.TextChanged
        LaadProductList()
    End Sub
    Private Sub CB_Shop_Enter(sender As Object, e As EventArgs) Handles CB_Shop.Enter
        LaadShop(2)
    End Sub
    Private Sub CB_Shop_Leave(sender As Object, e As EventArgs) Handles CB_Shop.Leave
        Dim tempID As Integer
        tempID = Me.CB_Shop.SelectedValue
        LaadShop(1)
        Me.CB_Shop.SelectedValue = tempID
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LaadForm()
    End Sub
    Private Sub EditGrid()

        '13mei2017 ?? Wat is dit nakijken of het wel wordt gebruikt...
        Dim I As Integer, a As Integer, b As Integer
        Try
            For I = 0 To DG_Lijst.Rows.Count - 1

                Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(DG_Lijst.Rows(I).Cells(2).Value, Integer))
                Me.GPA_AantalTableAdapter.Fill(Me.DS_Product.GPA_Aantal, DG_Lijst.Rows(I).Cells(1).Value)

                a = Me.TXT_Voorraad.Text
                b = Me.TXT_LijstAantal.Text
                Me.TXT_Voorraad.Text = a + b
                Me.TXT_LijstAantal.Text = 0


                Me.Validate()
                Me.DT_productBindingSource.EndEdit()
                Me.GPA_AantalBindingSource.EndEdit()
                Me.DT_productTableAdapter.Update(DS_Product.DT_product)
                Me.GPA_AantalTableAdapter.Update(DS_Product.GPA_Aantal)

                'Me.TXT_LijstAantal.Text = DG_List.Rows(I).Cells(2).Value

                ' DG_List.Rows(I).Cells(1).Value = DG_List.Rows(I).Cells(1).Value + 10
                '  I = I + 1

                MsgBox(DG_Lijst.Rows(I).Cells(1).Value & "' " & DG_Lijst.Rows(I).Cells(3).Value)
            Next
            LaadProductList()
            'op = DG_List.Rows(1).Cells(2).Value
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
        ' MsgBox(op)
    End Sub
    Private Sub Knop_update_Click(sender As Object, e As EventArgs)

        MsgBox(Me.TB_Doel.SelectedIndex)

    End Sub
    Private Sub Knop_OpslaanDB_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.GetProductListBindingSource.EndEdit()
        Me.GetOntvangstBindingSource.EndEdit()
        'Me.GetProductListTableAdapter.update(DS_Product.GetProductList)
        Me.GetOntvangstTableAdapter.Update(DS_Product.GetOntvangst)

    End Sub
    Private Sub DG_List_Click(sender As Object, e As EventArgs)  ' ByVal sender As Object, ByVal e As System.EventArgs)_Handles selectedRowsButton.Click
        'wat is dit? kan weg ...

        Dim selectedRowCount As Integer =
            DG_Lijst.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount - 1

                sb.Append("Row: ")
                sb.Append(DG_Lijst.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)

            Next i

            sb.Append("Total: " + selectedRowCount.ToString())

            'MessageBox.Show(sb.ToString(), "Selected Rows")
        End If
    End Sub
    Private Sub Knop_Supplier_Click(sender As Object, e As EventArgs) Handles Knop_Supplier.Click
        OPSUPPLIER = 1
        IDSUPPLIER = Me.CB_Supplier.SelectedValue

        F_Supplier.ShowDialog()
        OPSUPPLIER = 0 'netjes achterlaten
    End Sub
    Private Sub BerekenLijstWaarde()
        'berekend waardes om te controleren of boeken als ontvangst toegestaan is
        Dim i As Integer, W As Decimal
        BeVat = False
        Try
            For i = 0 To Me.DG_Lijst.Rows.Count - 1
                If IsNumeric(Me.DG_Lijst.Rows(i).Cells(5).Value) = True And IsNumeric(Me.DG_Lijst.Rows(i).Cells(8).Value) = True Then
                    W = W + ((Me.DG_Lijst.Rows(i).Cells(5).Value) * (Me.DG_Lijst.Rows(i).Cells(8).Value))
                End If

                If IsNumeric(Me.DG_Lijst.Rows(i).Cells(5).Value) = True Then
                    If (Me.DG_Lijst.Rows(i).Cells(5).Value) <> 0 Then BeVat = True
                End If
            Next
            Me.TXT_Lijstwaarde.Text = FormatNumber(W, -1)
        Catch ex As Exception
            MsgBox(ErrorToString,, "berekenlijstwaarde (F_getproduct)")
        End Try

    End Sub
    Private Sub BerekenProject()
        'bereken de velden voor een project, of totalen in verbruik
        'optellingen maken van inhoud van cells in de datagrid. 
        'Volgorde van de cells in een row even vastleggen in variablene, aan te passen als de volgeorde veranderd
        Dim CA As Integer = 5 'aantal
        Dim CI As Integer = 8 'inkoopprijs
        Dim CV As Integer = 9 'verkoopprijs
        Dim CS As Integer = 7 'huidige voorraad

        Dim i As Integer 'teller
        Dim L As Integer 'de te selecteren rij bij verlaten deze sub
        Dim msg As Integer

        Dim Aantalparts As Integer 'som van items 
        Dim Inkoop As Decimal 'totaal inkoop waarde
        Dim verkoop As Decimal 'som verkoop van de product
        Dim Max As Integer = 10000  'maximaal te maken projecten
        Dim MaxTEMP As Integer

        For i = 0 To Me.DG_Lijst.Rows.Count - 1
            Aantalparts = Aantalparts + (Me.DG_Lijst.Rows(i).Cells(CA).Value)
            If IsNumeric(Me.DG_Lijst.Rows(i).Cells(CS).Value) = True Then
                'is de voorraadwaarde bepaald
                MaxTEMP = Int(Me.DG_Lijst.Rows(i).Cells(CS).Value / Me.DG_Lijst.Rows(i).Cells(CA).Value)
                If Max > MaxTEMP Then
                    Max = MaxTEMP
                    L = i
                End If

            Else
                msg = 1
                L = i
                GoTo Verlaat
            End If

            If IsNumeric(Me.DG_Lijst.Rows(i).Cells(CI).Value) = True Then
                Inkoop = Inkoop + (Me.DG_Lijst.Rows(i).Cells(CA).Value * Me.DG_Lijst.Rows(i).Cells(CI).Value)
            Else
                msg = 2
                L = i
                GoTo Verlaat
            End If

            If IsNumeric(Me.DG_Lijst.Rows(i).Cells(CV).Value) = True Then
                verkoop = verkoop + (Me.DG_Lijst.Rows(i).Cells(CA).Value * Me.DG_Lijst.Rows(i).Cells(CV).Value)
            Else
                msg = 3
                L = i
                GoTo Verlaat
            End If
        Next
        'gevonden waardes op formulier tonen
        Select Case Me.TB_Doel.SelectedIndex
            Case 0 'ontvangst
                Me.TXT_Lijstwaarde.Text = FormatNumber(Inkoop, -1)

            Case 3 'bij verbruik
                Me.TXT_Push_Verkoop.Text = FormatNumber(verkoop, -1)
                Me.TXT_Push_Inkoop.Text = FormatNumber(Inkoop, -1)
                Me.TXT_Push_Omzet.Text = FormatNumber(verkoop, -1)
                'standaard kas onvangst instellen
                Me.TXT_Push_Kas.Text = Me.TXT_Push_Verkoop.Text
                Me.TXT_Push_Bank.Text = FormatNumber(0, -1)



            Case 2 'bij project
                Me.TXT_Project_AantalParts.Text = Aantalparts
                Me.TXT_Project_SomInkoop.Text = Inkoop
                Me.TXT_Project_SomVerkoop.Text = verkoop
                Me.TXT_Project_Max.Text = Max

        End Select

Verlaat:
        'als er in de optelling iets niet klopt
        Select Case msg
            Case 1
                MsgBox("Voor het product in rij: " & i + 1 & " is geen voorraadwaarde bepaald. Bepaal een voorraad. (Mag ook 0 zijn....).", vbExclamation, "Voorraadwaarde is niet bepaald")
            Case 2 ' Niet alle inkoopprijzen bekend
                MsgBox("De inkoopprijs van het product in rij: " & i + 1 & " is niet bekend. Bepaal voor dit product een inkoopprijs.", vbExclamation, "Inkoopprijs niet bekend.")

            Case 3 'niet alle verkoopprijzen bekend.  
                MsgBox("De verkoopprijs van het product in rij: " & i + 1 & " is niet bekend. Bepaal voor dit product een verkoopprijs.", vbExclamation, "Verkoopprijs niet bekend.")
            Case 4
        End Select
        If Me.DG_Lijst.Rows.Count > 0 Then Me.DG_Lijst.Rows(L).Selected = True

    End Sub
    Private Sub BerekenBTWVerbruik()
        Me.TXT_Push_BTW.Text = FormatNumber((Me.TXT_Push_Omzet.Text / (Me.LBL_Push_Btw.Text + 100)) * LBL_Push_Btw.Text, -1)
    End Sub
    Private Sub Knop_BoekOntvangst_Click(sender As Object, e As EventArgs) Handles Knop_BoekOntvangst.Click
        BoekOntvangst()
    End Sub
    Private Sub WaardesMove(Prijs As Decimal)
        Dim L As Integer = 0
        Dim V As Integer = 0 'Zorgen dat de text velden WAARDES gaan bevatten en geen teksten

        Try
            If IsNumeric(Me.TXT_LijstAantal.Text) = True Then L = Int(Me.TXT_LijstAantal.Text)
            If IsNumeric(Me.TXT_Voorraad.Text) = True Then V = Int(Me.TXT_Voorraad.Text)
            Me.TXT_ontvangen.Text = L
            Me.TXT_Voorraad.Text = Int(L + V)
            ' MsgBox(TXT_Voorraad.Text)
            Me.TXT_Prijs.Text = Prijs
        Catch ex As Exception
            MsgBox(ErrorToString,, "Waardesmove")
        End Try
    End Sub
    Private Sub OPslaanTables()
        'gebruikt voor tussendoor opslaan van de datatables
        Try
            Me.Validate()
            Me.GPA_AantalBindingSource.EndEdit()
            Me.DT_productBindingSource.EndEdit()
            Me.GPA_AantalTableAdapter.Update(DS_Product.GPA_Aantal) 'Nee aanpassen lijst niet wenselijk
            Me.DT_productTableAdapter.Update(DS_Product.DT_product)
        Catch ex As Exception
            MsgBox(ErrorToString,, "OPslaan tables")
        End Try
    End Sub
    Private Sub Opslaanproduct()
        Me.Validate()
        Me.DT_productBindingSource.EndEdit()
        Me.DT_productTableAdapter.Update(DS_Product.DT_product)
    End Sub
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ProductTonen()
        If Me.DG_Lijst.Rows.Count > 0 Then 'alleen als er al een item in de lijst staat.

            Dim ID As Integer
            Dim i As Integer
            For i = 0 To Me.DG_Lijst.Rows.Count - 1
                If Me.DG_Lijst.Rows(i).Selected = True Then 'geselcteerde lijst zoeken
                    ID = Me.DG_Lijst.Rows(i).Cells(0).Value
                    GoTo Eindeloop
                End If
            Next
Eindeloop:
            'MsgBox(ID)
            IDGETPRODUCTADD = ID
            If ValidatieProductPlus() = True Then
                OPGETPRODUCTADD = 2
            Else
                OPGETPRODUCTADD = 3 'aanpassen van het getproductadd record niet meer mogelijk
            End If


            IDGETONTVANGST = Me.TXT_getontvangstid.Text
            F_GetProductAdd.ShowDialog()
            'Productlijst herladen
            LaadProductList()

        End If

    End Sub
    Private Sub DG_Lijst_DoubleClick(sender As Object, e As EventArgs) Handles DG_Lijst.DoubleClick
        ProductTonen()
    End Sub
    Private Sub Knop_DetailsShop_Click(sender As Object, e As EventArgs) Handles Knop_DetailsShop.Click
        IDSUPPLIER = Me.CB_Supplier.SelectedValue
        IDSHOP = Me.CB_Shop.SelectedValue
        F_Shop.ShowDialog()
        LaadShop(1)
        Me.CB_Shop.SelectedValue = IDSHOP
    End Sub
    Private Sub Knop_Kosten_Click(sender As Object, e As EventArgs) Handles Knop_Kosten.Click
        BoekKosten()
    End Sub
    Private Sub Knop_Toon_Click(sender As Object, e As EventArgs) Handles Knop_Toon.Click
        ProductTonen()
    End Sub
    Private Sub Knop_Bestelling_Click(sender As Object, e As EventArgs) Handles Knop_Bestelling.Click
        If ValidatieBestel() = True Then
            'Opslaan() 'gegevens van container-record (getontvangst) opslaan (niet nodig gedaan bij Leave groupbox)
            Dim jn As Integer
            jn = MsgBox("Wil je de producten als in de lijst omzetten naar een bestelling bij deze leverancier?", vbQuestion + vbYesNo, "Bestelling aanmaken bevestigen...")
            If jn = 6 Then
                BoekBesteld()
            End If
        End If
    End Sub
    Private Function ValidatieCommon() As Boolean
        'valideerd standaard invoer die voor alle boekfuncties gelden
        Dim jn As Boolean = False
        'Is er wel een geldig record in getontvangst???? en is dit niet al in gebruik
        If IsNumeric(txt_Status.Text) = True Then 'is er wel een geldig getontvangst record?
            If Me.txt_Status.Text = 1 Then
                If Len(Me.TXT_NaamGet.Text) > 1 Then
                    jn = True
                Else
                    MsgBox("Geef een naam aan deze productlijst." & Chr(13) & "Naam kun je later weer aanpassen.", vbExclamation, "Productlijst heeft geen naam...")
                    Me.TXT_NaamGet.Select()
                End If
            Else
                MsgBox("Deze productlijst kun je niet gebruiken.", vbExclamation, "Productlijst wordt ergens anders voor gebruikt...")
            End If
        Else
            MsgBox("Getontvangst record is niet goed ingesteld. Sluit het formulier en probeer opnieuw.", vbCritical, "Er is een probleem....")
        End If
        Return jn
    End Function
    Private Function ValidatieCommonIO() As Boolean
        Dim jn As Boolean = False
        'valideerd de algemene velden nodig voor ontvangsten en bestellingen
        If ValidatieCommon() = True Then 'is er wel een actief record in de container (getontvangst)
            'leverancier verplicht
            If IsNumeric(Me.CB_Supplier.SelectedValue) = True Then
                If Me.CB_Supplier.SelectedValue > 0 Then
                    'producten in de lijst verplicht
                    If Me.DG_Lijst.Rows.Count > 0 Then
                        jn = True
                    Else
                        MsgBox("Er staan geen producten in de lijst", vbExclamation, "Geen producten")
                    End If
                Else
                    MsgBox("Bepaal een leverancier", vbExclamation, "Leverancier is nodig ...")
                    Me.CB_Supplier.Select()
                End If
            Else
                MsgBox("Bepaal een leverancier", vbExclamation, "Kies een leverancier...")
                Me.CB_Supplier.Select()
            End If
        End If
        Return jn
    End Function
    Private Function ValidatieBestel() As Boolean
        'valideert de specifieke velden voor bestellingen
        Dim jn As Boolean = False        'status getontvangst verplicht op 0 (dus een nieuwe invoer) 
        If ValidatieCommonIO() = True Then 'algemene zaken valideren
            'validatie specifiek bestellingen

            jn = True
        End If
        Return jn
    End Function
    Private Function ValidatieINKOOP() As Boolean
        'Valideer specifiek voor de inkoop, dus kosten boeken (knop...)
        Dim jn As Boolean = False
        If ValidatieCommonIO() = True Then
            'hier kunnen nog speficieke validaties.
            jn = True
        End If
        Return jn
    End Function
    Private Function ValidatieOntvangst() As Boolean
        Dim jn As Boolean = False
        Dim msg As Integer
        'check commen validatie
        If ValidatieCommonIO() = True Then
            If IsNumeric(Me.TXT_Boekwaarde.Text) = True Then
                If Me.TXT_Boekwaarde.Text <> 0 Then
                    jn = True
                Else
                    msg = 1
                End If
            Else
                msg = 1
            End If
        End If

        'onderstaand gaat nu dubbel wordt gedaan in validatiecommonio
        'is er een leverancier bepaald? dit wordt nu anders geregeld, misschien anders meer centraal regelen? Nog te doen?
        'zit nu in enabllen van knoppen en waardes in verlden kijk in boekontvangst en boekkosten
        'zijn er kosten geboekt?  (zelfde verhaal als boven.)
        If jn = False Then
            Select Case msg
                Case 1
                    MsgBox("Er moeten kosten worden geboekt om producten als ontvangst te kunnen boeken", vbExclamation, "Boek eerst de kosten...")
            End Select
        End If

        Return jn
    End Function
    Private Function ValidatieOntvangBesteld() As Boolean
        Dim jn As Boolean 'valideerd of een product uit de bestelling naar de ontvangst kan worden geladen

        If ValidatieCommon() = True Then
            jn = True
        End If
        Return jn
    End Function
    Private Function ValidatieProjectBuild() As Boolean
        '' valideerd of er projecten kunnen worden gemaakt, dus producten samenvoegen tot een project product
        Dim jn As Boolean = False
        Dim msg As Integer = 0
        If Me.DG_Lijst.Rows.Count > 0 Then
            If IsNumeric(Me.TXT_Project_AantalMaak.Text) = True Then
                'Moet een product gekoppeld zijn.
                If Me.TXT_Project_AantalMaak.Text > 0 Then
                    If IsNumeric(Me.txt_Status.Text) = True Then
                        If Me.txt_Status.Text = 5 Then
                            If IsNumeric(Me.TXT_Project_Max.Text) = True Then
                                If Me.TXT_Project_Max.Text >= Me.TXT_Project_AantalMaak.Text Then
                                    jn = True
                                Else
                                    MsgBox("Er is onvoldoende voorraad aan producten om zoveel projecten aan te maken", vbExclamation, "Onvoldoende voorraad...")
                                End If
                            Else
                                MsgBox("Druk op [bereken] om het maximaal aantal te maken projecten te berekenen", vbExclamation, "Gegevens van de lijst niet berekend...")
                            End If
                        Else
                            msg = 1
                        End If
                    Else
                        msg = 1
                    End If
                Else
                    msg = 2
                End If
            Else
                msg = 2
            End If
        Else
            msg = 3
        End If

        Select Case msg
            Case 1
                MsgBox("Er moet eerst een project worden aangemaakt, voordat je de producten kan groeperen", vbExclamation, "Geen project bepaald...")
            Case 2
                MsgBox("Geef hoeveel projecten er moeten worden samengesteld", vbExclamation, "Geen aantal opgegeven...")
            Case 3
                MsgBox("Er staan geen producten in de lijst", vbExclamation, "Productlijst is leeg...")
        End Select
        Return jn
    End Function
    Private Function ValidatieProject() As Boolean
        'Valideerd of een container record getontvangst als een Project kan worden ingesteld
        Dim jn As Boolean = False
        Dim msg As Integer 'voor de boodschap bij failed
        If ValidatieCommon() = True Then
            'check of er een product is bepaald, dit product is dan het project
            If IsNumeric(TXT_Project_ProductID.Text) = True Then
                If TXT_Project_ProductID.Text > 0 Then
                    jn = True
                Else
                    msg = 1 'geen product bepaald
                End If
            Else
                msg = 1
            End If
            If jn = False Then
                Select Case msg
                    Case 1
                        MsgBox("Er is geen (project)product bepaald waarin de producten uit de lijst moeten worden gegroepeerd", vbExclamation, "Kies een Project-product vor dit project..")
                        Me.Knop_Project_Product.Select()
                End Select
            End If
        End If
        Return jn
    End Function
    Private Function ValidatieVerbruik() As Boolean
        Dim jn As Boolean = False
        Dim msg As Integer
        If ValidatieCommon() = True Then
            'er moeten product regels zijn, ?? echt waar?
            If DG_Lijst.Rows.Count > 0 Then
                If IsNumeric(Me.TXT_Push_Omzet.Text) = True Then
                    If Me.TXT_Push_Omzet.Text <> 0 Then
                        jn = True
                    Else
                        msg = 2
                    End If
                Else
                    msg = 2
                End If
            Else
                msg = 1
            End If
            'Alle producten moeten een waarde hebben, wordt gedaan in berekenproject
            'omzet moet ongelijk zijn aan 0
        End If
        Select Case msg
            Case 1 'geen productregels
                MsgBox("Er staan geen producten in de lijst", vbExclamation, "Lijst is leeg...")
            Case 2 'geen omzet geboekt
                MsgBox("Er moet een bedrag als omzet worden ingevoerd", vbExclamation, "Geen te boeken omzet...")
                'Me.TXT_Push_Omzet.Select()
        End Select
        Return jn
    End Function
    Private Function ValidatieProductPlus() As Boolean
        Dim jn As Integer = False

        Select Case Me.txt_Status.Text
            Case 1 'producten toevoegn mogelijk
                jn = True
            Case 5
                jn = True
            Case Else
                jn = False
        End Select
        If jn = False Then MsgBox("Toevoegen of aanpassen van een product in deze lijst is niet meer mogelijk", vbExclamation, "Lijst is al afgesloten..")
        Return jn
    End Function
    Private Sub BoekOntvangst()
        'maakt van de lijst een ontvangst (dus producten ingekocht)
        'gebruikt worden 3 cellen in de datagridview Bij fouten CHECK of dit klopt...
        Dim GPA As Integer = 0 'getproductadd id
        Dim PD As Integer = 2 'Id van product
        Dim IK As Integer = 8 'de inkoopprijs

        If ValidatieOntvangst() = True Then
            Dim jn As Integer
            jn = MsgBox("Wil je de poducten in de productlijst in de voorraad bijboeken?", vbQuestion + vbYesNo, "Bijboeken ontvangst bevestigen...")
            If jn = 6 Then
                'Dit werkt alleen als de volgorde van cellen in de datgrid juist is 0=idgetproductadd 1=Idproduct 8=getbuyingprice
                Dim i As Integer
                Dim IDGPA As Integer, IDP As Integer 'GPA=getproductadd IDP=ID product
                Dim BP As Decimal
                Try
                    For i = 0 To Me.DG_Lijst.Rows.Count - 1
                        'Verkrijg IDgetproductadd en idProduct
                        IDGPA = Me.DG_Lijst.Rows(i).Cells(GPA).Value 'id van Getproductadd van deze regel
                        IDP = Me.DG_Lijst.Rows(i).Cells(PD).Value 'id van product van deze regel
                        'vul de beide datatables 
                        Me.GPA_AantalTableAdapter.Fill(Me.DS_Product.GPA_Aantal, IDGPA)
                        Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, IDP)

                        If IsNumeric(Me.DG_Lijst.Rows(i).Cells(IK).Value) = True Then
                            BP = Me.DG_Lijst.Rows(i).Cells(IK).Value
                        Else
                            BP = 0
                        End If
                        'zet de waardes over
                        WaardesMove(BP)
                        'update de beide datatables... 
                        OPslaanTables()
                    Next
                    'áanpassingen maken in getontvangst (de container) 
                    Me.txt_Status.Text = 3 'status 3 geeft aan dat de container nu een ontvangstrecord is. 
                    Opslaan() 'gegevens in de getontvangst (container) updatten

                    'Datagridview herladen
                    Me.Optie_Ontvangst.Checked = True
                    Me.CH_AlleOntvangst.Checked = False
                    Me.TB_Products.SelectTab(1)
                    LaadProductList()

                    'Me.GB_Get.Select() '??? wat is dit 24mei uit
                    'BerekenLijstWaarde() '?? waarom 24mei uit

                Catch ex As Exception
                    MsgBox(ErrorToString,, "Knop Boekontvangst")
                End Try

            End If 'voor "wil je het boeken
        Else
            'MsgBox("Validatie failed")
        End If 'voor validatieOntvangst
    End Sub
    Private Sub BoekBesteld()
        'Maakt van de lijst een bestelling
        'MsgBox("jo, we maken een bestelling")
        Dim i As Integer 'teller
        Dim GPAID As Integer 'id van de regel in de lijst
        For i = 0 To Me.DG_Lijst.Rows.Count - 1
            'Laad regel i in tabeladaptor
            GPAID = Me.DG_Lijst.Rows(i).Cells(0).Value
            Me.GPA_AantalTableAdapter.Fill(DS_Product.GPA_Aantal, GPAID)
            'verplaats lijstwaarde naar besteld
            Me.TXT_besteld.Text = Me.TXT_LijstAantal.Text
            ' Me.TXT_LijstAantal.Text = 0 ' niet doen lijst leegmaken is niet nodig
            Me.Validate()
            Me.GPA_AantalBindingSource.EndEdit()
            Me.GPA_AantalTableAdapter.Update(DS_Product.GPA_Aantal)
        Next

        'aanpassingen in container record getontvangst
        Me.txt_Status.Text = 2 'status 2 = bestelling
        Opslaan()
        Me.CH_AlleBestel.Checked = False
        Me.TB_Products.SelectTab(2) 'toont tabblad bestelling
        Me.Optie_besteld.Checked = True
    End Sub
    Private Sub BoekKosten()
        If ValidatieINKOOP() = True Then
            Try
                'Opslaan() 'Op dit moment de Getontvangst record updaten of opslaan (knop opslaan kan dus weg...) NIET NODIG gedaan in leave groupbox
                If Me.TXT_getontvangstid.Text > 0 Then 'alleen als getontvangst al in de db is gezet
                    ' IDADMINKOOP = Me.TXT_AdmInkoop.Text
                    ' MsgBox("hier")
                    If Len(Me.TXT_AdmInkoop.Text) > 0 Then
                        IDADMINKOOP = Me.TXT_AdmInkoop.Text
                        OPADMINKOOP = 2
                    Else
                        OPADMINKOOP = 1
                        IDADMINKOOP = -1
                    End If
                    IDSUPPLIER = Me.CB_Supplier.SelectedValue
                    F_AdmInkoopboek.ShowDialog()
                    'verkregen gegevens inschrijven
                    'BerekenLijstWaarde()
                    If Len(Me.TXT_Boekwaarde.Text) > 0 And BeVat = True Then 'bevat is of er een item in de lijst staat met lijstaantal <> 0
                        Me.Knop_BoekOntvangst.Enabled = True
                    End If
                End If
            Catch ex As Exception
                MsgBox(ErrorToString,, "knop_kosten enz ")
            End Try
        End If
    End Sub
    Private Sub Boekprojecten()
        Dim i As Integer
        'Groepeerd de in de lijst staande producten tot het aantal opgegeven producten als project
        ' werkt alle voorraden bij van project-producten en alle daaruit bestaande producten
        'maakt geen administratieve boekingen omdat de Inkoopwaarde van het project-product gelijk blijft de som van de samengevoegde producten

        'volgorde van de kollomen in de datagrid zijn essentieel gerbruiken van een variabele om eenvoudiger te kunnen aanpassen
        Dim LA As Integer = 5 'Aantal
        Dim LIDP As Integer = 2 'ID van het product


        'eerst project-product bijwerken, deze is op dit moment al geladen. 
        Me.TXT_Project_Voorraad.Text = Int(Me.TXT_Project_Voorraad.Text) + Int(Me.TXT_Project_AantalMaak.Text)
        'inkoopwaarde is al ingevoerd
        Opslaanproduct()

        'van alle producten in de lijst de voorraden aanpassen
        'merk op dit is dezelfde tableadaptor als van het project-product kan problemen geven na afloop project-product weer laden

        For i = 0 To Me.DG_Lijst.Rows.Count - 1

            Me.DT_productTableAdapter.Fill(DS_Product.DT_product, Me.DG_Lijst.Rows(i).Cells(LIDP).Value)
            Me.TXT_Voorraad.Text = Int(Me.TXT_Voorraad.Text) - Int((Me.DG_Lijst.Rows(i).Cells(LA).Value * Me.TXT_Project_AantalMaak.Text))
            Opslaanproduct()
            LaadProductList()
            BerekenProject()
        Next
        'projectpoduct weer terugladen
        LaadProduct()
    End Sub
    Private Sub Tpage_Product_Ontvang_Enter(sender As Object, e As EventArgs) Handles Tpage_Product_Ontvang.Enter
        'als tabblad ontvangen wordt getoond nu de datable vullen met ontvangsten van deze leverancier
        LaadProductList()
    End Sub
    Private Sub Tpage_Product_Besteld_Enter(sender As Object, e As EventArgs) Handles Tpage_Product_Besteld.Enter
        LaadProductList()
    End Sub
    Private Sub MaakVerbruik()
        'Maakt deze getontvangst record container tot een verbruik, verkoop. 
        'Status aanpassen naar gekozen soort verbruik : 4=Standaard = verkoop 40=Naar inventaris 41= Verlies 42= ? who knows?
        Select Case Me.CB_Push_soort.SelectedIndex
            Case 0 'status=naar 4 verkoop
                STATUS = 4
            Case 1 'status naar 40 inventaris
                STATUS = 40
            Case 2 'Status naar 41 verlies
                STATUS = 41
        End Select
        Me.txt_Status.Text = STATUS
        Opslaan()

        'formulier achterlaten dit ergens in een select case doen voor alle opties
        LaadGetOntvangst(STATUS)
        Me.Optie_Verbruik.Select()
        Me.TB_Doel.SelectTab(3)
        LaadProductList()

    End Sub
    Private Sub GB_Get_Leave(sender As Object, e As EventArgs) Handles GB_Get.Leave
        'als groupbox wordt verlaten, automatisch veranderingen opslaan
        Opslaan()
    End Sub
    Private Sub Optie_besteld_Click(sender As Object, e As EventArgs) Handles Optie_besteld.Click
        'MsgBox("besteld")
        LaadGetOntvangst(2)
        Me.TB_Doel.SelectTab(1)
        Me.TB_Products.SelectTab(2)
        STATUS = 2
        LaadProductList()

    End Sub
    Private Sub Optie_Open_Click(sender As Object, e As EventArgs) Handles Optie_Open.Click
        'MsgBox("open")
        LaadGetOntvangst(1)
        STATUS = 1
        Me.TB_Doel.SelectTab(0)
        Me.TB_Products.SelectTab(0)
        LaadProductList()
    End Sub
    Private Sub Optie_Ontvangst_Click(sender As Object, e As EventArgs) Handles Optie_Ontvangst.Click
        'MsgBox("Ontvangst")
        LaadGetOntvangst(3)
        Me.TB_Doel.SelectTab(0)
        Me.TB_Products.SelectTab(1)
        STATUS = 3
        'MsgBox("optieontvangst")
        LaadProductList()

    End Sub
    Private Sub Optie_Verbruik_Click(sender As Object, e As EventArgs) Handles Optie_Verbruik.Click
        'MsgBox("Ontvangst")
        LaadGetOntvangst(4)
        Me.TB_Doel.SelectTab(3)
        Me.TB_Products.SelectTab(0)
        STATUS = 4
        Me.CB_Push_soort.SelectedIndex = 0
        LaadProductList()

    End Sub
    Private Sub Optie_Project_Click(sender As Object, e As EventArgs) Handles Optie_Project.Click
        'MsgBox("Project")
        LaadGetOntvangst(5)
        Me.TB_Doel.SelectTab(2)
        Me.TB_Products.SelectTab(0)
        LaadProductList()
    End Sub
    Private Sub CH_AlleBestel_CheckedChanged(sender As Object, e As EventArgs) Handles CH_AlleBestel.CheckedChanged
        LaadProductList()
    End Sub
    Private Sub CH_AlleOntvangst_CheckedChanged(sender As Object, e As EventArgs) Handles CH_AlleOntvangst.CheckedChanged
        LaadProductList()
    End Sub
    Private Sub Knop_Project_Product_Click(sender As Object, e As EventArgs) Handles Knop_Project_Product.Click
        Dim N As Boolean = False
        Dim jn As Integer
        If IsNumeric(Me.TXT_Project_ProductID.Text) = True Then 'product niet bepaald
            If Me.TXT_Project_ProductID.Text > 0 Then
                N = True
            End If
        End If
        If N = True Then 'dus er is al een product bepaald
            IDPRODUCT = Me.TXT_Project_ProductID.Text
        Else 'dus product niet bepaald
            IDPRODUCT = 0
        End If
        OPPRODUCT = 1
        F_Product.ShowDialog()

        'extra vragen bij veranderd nummer, terugkeer van f_product
        If N = True Then
            If Me.TXT_Project_ProductID.Text <> IDPRODUCT Then 'product is veranderd
                jn = MsgBox("Weet je zeker dat je voor dit project een ander product wilt instellen?", vbQuestion + vbYesNo, "Product is veranderd....")
                If jn = 6 Then
                    'MsgBox("product opslaan")
                    N = False
                End If
            End If

        End If
        If N = False Then
            Me.TXT_Project_ProductID.Text = IDPRODUCT
            Me.Knop_project_maak.Enabled = True
        End If


    End Sub
    Private Sub Knop_Project_Build_Click(sender As Object, e As EventArgs) Handles Knop_Project_Build.Click
        Dim jn As Integer
        'nu worden projecten gemaakt. 
        'samen voegen van producten tot 1 of meerdere projecten. 
        'eerst kijken of alle gegevens er zijn:
        If ValidatieProjectBuild() = True Then
            jn = MsgBox(Me.TXT_Project_AantalMaak.Text & " Projecten aanmaken en de voorraden van de producten in de lijst aanpassen? ", vbQuestion + vbYesNo, "bevestigen aanmaken projecten..")
            If jn = 6 Then
                Boekprojecten()
            End If
        Else
            'MsgBox("validatie failed")

        End If
    End Sub
    Private Sub Knop_ProductPLus_Click(sender As Object, e As EventArgs) Handles Knop_ProductPLus.Click
        If ValidatieProductPlus() = True Then
            Try
                IDGETONTVANGST = Me.CB_Ontvangen.SelectedValue
                OPGETPRODUCTADD = 1
                IDPRODUCT = -1
                F_GetProductAdd.ShowDialog()
                LaadProductList()
                BerekenProject()

            Catch ex As Exception
                MsgBox(ErrorToString,, "Knop productplus")

            End Try
        End If

    End Sub
    Private Sub knop_OpslaanLijst_Click(sender As Object, e As EventArgs)

        Me.Validate()
        'Me.GetProductListBindingSource.EndEdit()
        'Me.GetProductListTableAdapter.Update(DS_Product.GetProductAdd)

    End Sub
    Private Sub Knop_Push_Maak_Click(sender As Object, e As EventArgs) Handles Knop_Push_Maak.Click
        Dim jn As Integer
        If ValidatieVerbruik() = True Then
            jn = MsgBox("De getoonde productlijst verwerken in de voorraad en administratie bijwerken?", vbQuestion + vbYesNo, "Bevestig omzet of verbruik boeking....")
            'VOLGORDE belangrijk
            'getontvangst als verbruik instellen, status wordt hier ingesteld 
            If jn = 6 Then 'moet 6 worden

                'journaalposten aanmaken
                Journaalverbruik()
                VerbruikVoorraad()
                MaakVerbruik()
            Else
                'MsgBox("efkens nog nie boeken...")
            End If
        End If
    End Sub
    Private Sub Knop_Project_bereken_Click(sender As Object, e As EventArgs) Handles Knop_Project_bereken.Click
        BerekenProject()
    End Sub
    Private Sub Knop_Push_Bereken_Click(sender As Object, e As EventArgs) Handles Knop_Push_Bereken.Click
        BerekenProject()
    End Sub
    Private Sub Knop_Bestel_Ontvangst_Click(sender As Object, e As EventArgs) Handles Knop_Bestel_Ontvangst.Click
        ToonBesteld()
    End Sub
    Private Sub TXT_Project_ProductID_TextChanged(sender As Object, e As EventArgs) Handles TXT_Project_ProductID.TextChanged
        'productdetails nu laden?
        LaadProduct()
    End Sub
    Private Sub TXT_project_maak_Click(sender As Object, e As EventArgs) Handles Knop_project_maak.Click
        'project maken
        'dus product koppelen aan getontvangst
        'getontvangst status naar 5
        If ValidatieProject() = True Then
            'GetOntvangst record bijwerken
            Me.txt_Status.Text = 5
            Opslaan()
            'focus verplaatsen
            Me.TXT_Project_AantalMaak.Select()
            Me.Knop_project_maak.Enabled = False
        End If
    End Sub
    Private Sub VerbruikVoorraad()
        'werkt voorraden bij
        'in alle voorkomenende gevallen binnen verbuik wordt de lijst aantal afgetrokken van de voorraad en de lijstwaarde op nul gesteld
        'id's halen we uit de datagrid, alleen productid = van belang
        Dim i As Integer
        Dim idP As Integer 'id van product
        Dim idG As Integer 'id van getproductadd
        For i = 0 To Me.DG_Lijst.Rows.Count - 1
            idP = Me.DG_Lijst.Rows(i).Cells(2).Value
            idG = Me.DG_Lijst.Rows(i).Cells(0).Value
            'datatables vullen
            Me.GPA_AantalTableAdapter.Fill(DS_Product.GPA_Aantal, idG)
            Me.DT_productTableAdapter.Fill(DS_Product.DT_product, idP)
            'waardes aanpassen
            Me.TXT_Voorraad.Text = Int(Me.TXT_Voorraad.Text) - Int(Me.TXT_LijstAantal.Text)
            'Me.TXT_LijstAantal.Text = 0 NEE niet de lijst gewoon intact laten
            'datatables updatten
            Me.Validate()
            'Me.GPA_AantalBindingSource.EndEdit() 'niet 
            Me.DT_productBindingSource.EndEdit()
            'Me.GPA_AantalTableAdapter.Update(DS_Product.GPA_Aantal) 'niet
            Me.DT_productTableAdapter.Update(DS_Product.DT_product)
        Next
    End Sub
    Private Sub Journaalverbruik()
        'maakt journaalposten voor verbruik
        'vaste velden : id_Admboek =5 (verbruikboek?) jp_datum=da_datum.value  id_boekstuk=TXT_getontvangstid.text  ID_getontvangst= TXT_getontvangstid.text
        Dim db As Decimal
        Dim cr As Decimal
        Dim ib As Integer = 5
        Dim dt As Date = Me.DA_Datum.Value
        Dim go As Integer = Me.TXT_getontvangstid.Text

        Dim Bank As Decimal
        Dim Kas As Decimal
        Dim inkoop As Decimal
        Dim btw As Decimal

        If IsNumeric(Me.TXT_Push_Bank.Text) = True Then
            Bank = Me.TXT_Push_Bank.Text
        Else
            Bank = 0
        End If

        If IsNumeric(Me.TXT_Push_Kas.Text) = True Then
            Kas = Me.TXT_Push_Kas.Text
        Else
            Kas = 0
        End If

        If IsNumeric(Me.TXT_Push_Inkoop.Text) = True Then
            inkoop = Me.TXT_Push_Inkoop.Text
        Else
            inkoop = 0
        End If

        If IsNumeric(Me.TXT_Push_BTW.Text) = True Then
            btw = Me.TXT_Push_BTW.Text
        Else
            btw = 0
        End If

        Select Case Me.CB_Push_soort.SelectedIndex
            Case 0 'omzet door verkoop
                'journaal aan bank (1120)
                db = Bank
                cr = 0
                If db <> 0 Then Me.AdmJournaalTableAdapter.Insert(ib, 1120, dt, go, db, cr, go)
                'journaal aan kas (1020)
                db = Kas
                cr = 0
                If db <> 0 Then Me.AdmJournaalTableAdapter.Insert(ib, 1020, dt, go, db, cr, go)
                'journaal aan voorraad (netto inkoopwaarde) (3010)
                db = 0
                cr = inkoop
                Me.AdmJournaalTableAdapter.Insert(ib, 3010, dt, go, db, cr, go)
                'journaal aan btw te verrekenen (1510)
                db = 0
                cr = btw
                Me.AdmJournaalTableAdapter.Insert(ib, 1510, dt, go, db, cr, go)
                'journaal aan opbrengst (8020)
                db = 0
                cr = Bank + Kas - inkoop - btw
                Me.AdmJournaalTableAdapter.Insert(ib, 8020, dt, go, db, cr, go)

            Case 1 'voorraad correctie naar inventaris 
                'Journaal aan voorraad (3010)
                db = 0
                cr = inkoop
                Me.AdmJournaalTableAdapter.Insert(ib, 3010, dt, go, db, cr, go)
                'journaal aan inventaris (0070)
                db = inkoop
                cr = 0
                Me.AdmJournaalTableAdapter.Insert(ib, 70, dt, go, db, cr, go)
            Case 2 'Voorraad correctie aan verlies 
                'journaal aan voorraad (3010)
                db = 0
                cr = inkoop
                Me.AdmJournaalTableAdapter.Insert(ib, 3010, dt, go, db, cr, go)
                'journaal aan verlies ev.(7020)
                db = inkoop
                cr = 0
                Me.AdmJournaalTableAdapter.Insert(ib, 7020, dt, go, db, cr, go)
        End Select
    End Sub
    Private Sub CB_Push_soort_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Push_soort.SelectionChangeCommitted
        'instellen getontvangst voor opzoeken de diverse verbruiken
        Dim s As Integer = Me.txt_Status.Text
        Dim st As Integer
        If s = 4 Or s = 40 Or s = 41 Or s = 42 Then s = 4 'enz

        If s = 4 Then 'is dus al een verbruik ingesteld
            Select Case Me.CB_Push_soort.SelectedIndex
                Case 0 'verkoop
                    st = 4
                Case 1 'naar inventaris
                    st = 40
                Case 2 'naar verlies
                    st = 41
                Case 3
                    st = 42
            End Select
            'sTATUS = st
            LaadGetOntvangst(st)
        End If
        ' Me.TXT_Push_Omzet.Select()
        ' Me.Knop_Push_Maak.Enabled = False
    End Sub
    Private Sub txt_Status_TextChanged(sender As Object, e As EventArgs) Handles txt_Status.TextChanged
        Select Case Me.txt_Status.Text
            Case 1
                ' Me.Knop_Push_Maak.Enabled = True
            Case Else
                '  Me.Knop_Push_Maak.Enabled = False
        End Select
    End Sub
    Private Sub TXT_Push_Omzet_Validated(sender As Object, e As EventArgs) Handles TXT_Push_Omzet.Validated
        Me.TXT_Push_Omzet.Text = FormatNumber(Me.TXT_Push_Omzet.Text, -1)
        BerekenBTWVerbruik()
    End Sub
    Private Sub TB_Doel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TB_Doel.SelectedIndexChanged
        Select Case Me.TB_Doel.SelectedIndex
            Case 0
            Case 1
            Case 2
            Case 3
                Me.BTWTableAdapter.FillHoog(Me.DS_Product.BTW)
                'MsgBox(LBL_Push_Btw.Text)
                BerekenProject()
                BerekenBTWVerbruik()

        End Select
    End Sub
    Private Sub TXT_Push_Bank_Validated(sender As Object, e As EventArgs) Handles TXT_Push_Bank.Validated
        Me.TXT_Push_Omzet.Text = FormatNumber(CDec(Me.TXT_Push_Kas.Text) + CDec(Me.TXT_Push_Bank.Text), -1)
        Me.TXT_Push_Bank.Text = FormatNumber(Me.TXT_Push_Bank.Text, -1)
        BerekenBTWVerbruik()
    End Sub
    Private Sub TXT_Push_Kas_Validated(sender As Object, e As EventArgs) Handles TXT_Push_Kas.Validated
        Me.TXT_Push_Omzet.Text = FormatNumber(CDec(Me.TXT_Push_Kas.Text) + CDec(Me.TXT_Push_Bank.Text), -1)
        Me.TXT_Push_Kas.Text = FormatNumber(Me.TXT_Push_Kas.Text, -1)
        BerekenBTWVerbruik()
    End Sub
    Private Sub TB_Products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TB_Products.SelectedIndexChanged
        LaadProductList()
    End Sub

    Private Sub OpmaakJournaal()
        'verzorgt de opmaak van de datagrid journaal
        'Me.DG_Journaal.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DG_Journaal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
    End Sub
    Private Sub CB_Ontvangen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Ontvangen.SelectionChangeCommitted
        LaadProductList()
    End Sub
    Private Sub ToonBesteld()
        If ValidatieOntvangBesteld() = True Then
            Dim i As Integer
            If Me.DG_Besteld.Rows.Count > 0 Then
                For i = 0 To Me.DG_Besteld.Rows.Count - 1
                    If Me.DG_Besteld.Rows(i).Selected = True Then
                        IDGETPRODUCTADD = Me.DG_Besteld.Rows(i).Cells(6).Value
                        GoTo GeVonden
                    End If
                Next
            End If
GeVonden:
            OPGETPRODUCTADD = 4
            F_GetProductAdd.ShowDialog()
            Me.TB_Products.SelectTab(0)
            LaadProductList()
        End If
    End Sub
    Private Sub DG_Besteld_DoubleClick(sender As Object, e As EventArgs) Handles DG_Besteld.DoubleClick
        ToonBesteld()
    End Sub
    Private Sub GB_Sectie_Validated(sender As Object, e As EventArgs) Handles GB_Sectie.Validated
        BlokSupplier()
    End Sub
    Private Sub BlokSupplier()
        'uitvogelen welke optie is ingedrukt
        Dim N As String = ""

        For Each control In Me.GB_Sectie.Controls
            If control.checked = True Then
                'MsgBox(control.name)
                N = control.name
            End If
        Next

        Select Case N
            Case "Optie_Open"
                Me.CB_Supplier.DropDownStyle = ComboBoxStyle.DropDown

            Case Else
                Me.CB_Supplier.DropDownStyle = ComboBoxStyle.Simple
        End Select
    End Sub
End Class
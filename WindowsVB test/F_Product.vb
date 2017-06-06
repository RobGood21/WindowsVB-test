Public Class F_Product
    Public NUZ As Boolean = False 'nuz=nieuw uitzondering
    Public LUZ As Boolean = False 'laden uitzonderng, vooral om txtchange even uit te schakelen
    Public Sub ToolTipsInstellen()
        ' Create the ToolTip and associate with the Form container.
        Dim TT_Product As New ToolTip()

        With TT_Product
            ' Set up the delays for the ToolTip.
            .AutoPopDelay = 5000
            .InitialDelay = 100
            .ReshowDelay = 50
            ' Force the ToolTip text to be displayed whether or not the form is active.
            .ShowAlways = True
            ' Set up the ToolTip text for the Button and Checkbox.
            'Teksten
            .SetToolTip(Me.TXT_Verkoopprijs, "Verkoopprijs incl. BTW")
            .SetToolTip(Me.TXT_Inkoopwaarde, "Gestelde inkoop- of voorraadwaarde excl.BTW")
            .SetToolTip(Me.TXT_BTW, "Datum, laatste ontvangst van dit product")
            '.SetToolTip(Me.TXT_LaatsteInkoop_Waarde, "Betaalde bedrag in € ex.BTW")
            .SetToolTip(Me.TXT_Productnummer, "Voer een productnummer in om product te zoeken")
            'Knoppen
            .SetToolTip(Me.Knop_Locatie, "Bepaal de standaard locatie voor dit product")
            '.SetToolTip(Me.Knop_PlaatsProduct, "Zoek en plaats het  product met ingevoerd productnummmer")

        End With
        ' toolTip1.SetToolTip(Me.Button1, "My button1")
        'toolTip1.SetToolTip(Me.checkBox1, "My checkBox1")
    End Sub
    Private Sub Knop_OpslaanSluiten_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub DT_productBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DT_productBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Product)
    End Sub
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            ' Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(IDProductToolStripTextBox.Text, Integer))
            Me.LoadProduct()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BerekenPrijzen()
        'berekend de diverse prijzen en stelt juiste format in
        If IsNumeric(Me.TXT_Verkoopprijs.Text) = True Then
            TXT_Verkoopprijs.Text = FormatNumber(TXT_Verkoopprijs.Text, -1)
            'btw berekenen
            ' MsgBox("nu")
            If IsNumeric(Me.LBL_BTWperc.Text) = True Then
                Me.TXT_BTW.Text = FormatNumber(Me.TXT_Verkoopprijs.Text / (100 + Me.LBL_BTWperc.Text) * Me.LBL_BTWperc.Text, -1)
                Me.TXT_prijsexBTW.Text = FormatNumber(Me.TXT_Verkoopprijs.Text - Me.TXT_BTW.Text, -1)
            End If
        Else
            Me.TXT_Verkoopprijs.Text = FormatNumber(0, -1)
            Me.TXT_BTW.Text = FormatNumber(0, -1)
        End If


    End Sub
    Private Sub F_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GroepPDTableAdapter.Fill(Me.DS_Product.GroepPD)
        Me.ToolTipsInstellen()
        LoadProduct()
    End Sub
    Private Sub LaadMutLijst(S As Integer)
        'MsgBox(IDPRODUCT)
        MutLijstKolom(S)
        Select Case S
            Case 1 'alles laden
                Me.ProductMutTableAdapter.Fill(Me.DS_Product.ProductMut, IDPRODUCT)
            Case 2 'alleen ontvangsten
                Me.ProductMutTableAdapter.FillByStatus(Me.DS_Product.ProductMut, IDPRODUCT, 2)
            Case 3 'Alleen nog in bestelling
                Me.ProductMutTableAdapter.FillByStatus(Me.DS_Product.ProductMut, IDPRODUCT, 3)
            Case 4 'Alleen verbruik, verkoop
                Me.ProductMutTableAdapter.FillByStatus(Me.DS_Product.ProductMut, IDPRODUCT, 4)
        End Select

    End Sub
    Private Sub MutLijstKolom(S As Integer)
        Select Case S
            Case 1 'alles
                Me.DG_Mutaties.Columns(5).Visible = True
                Me.DG_Mutaties.Columns(6).Visible = False
                Me.DG_Mutaties.Columns(7).Visible = False
                Me.DG_Mutaties.Columns(8).Visible = True
                Me.DG_Mutaties.Columns(9).Visible = True
                Me.DG_Mutaties.Columns(10).Visible = True
            Case 2 'besteld
                Me.DG_Mutaties.Columns(5).Visible = True
                Me.DG_Mutaties.Columns(6).Visible = False
                Me.DG_Mutaties.Columns(7).Visible = True
                Me.DG_Mutaties.Columns(8).Visible = True
                Me.DG_Mutaties.Columns(9).Visible = True
                Me.DG_Mutaties.Columns(10).Visible = True
            Case 3 'ontvangen
                Me.DG_Mutaties.Columns(5).Visible = False
                Me.DG_Mutaties.Columns(6).Visible = True
                Me.DG_Mutaties.Columns(7).Visible = False
                Me.DG_Mutaties.Columns(8).Visible = True
                Me.DG_Mutaties.Columns(9).Visible = True
                Me.DG_Mutaties.Columns(10).Visible = True
            Case 4 'verbruik
                Me.DG_Mutaties.Columns(5).Visible = True
                Me.DG_Mutaties.Columns(6).Visible = False
                Me.DG_Mutaties.Columns(7).Visible = False
                Me.DG_Mutaties.Columns(8).Visible = False
                Me.DG_Mutaties.Columns(9).Visible = False
                Me.DG_Mutaties.Columns(10).Visible = False
        End Select

    End Sub
    Public Sub LoadProduct()
        'MsgBox(OPPRODUCT)
        Try
            INITBerekend()
            LaadDatatables()

            Select Case OPPRODUCT
                Case 1 'bestaand product
                    LUZ = True
                    If IDPRODUCT < 0 Then 'is dus Geen product bepaald
                        Me.TXT_Productnummer.Text = "[Geen Product}"
                    Else
                        Me.TXT_Productnummer.Text = IDPRODUCT
                    End If
                    BerekenPrijzen()
                Case 2 'nieuw product invoeren.

                Case Else 'opening vrij
                    If IDPRODUCT = 0 Then
                        LUZ = True
                        Me.TXT_Productnummer.Text = "[Geen Product]"
                    End If
                    Me.TXT_Productnummer.Select()
            End Select

            LaadTB()
        Catch ex As Exception
            MsgBox(ErrorToString,, "Loadproduct (F_product)")
        End Try
    End Sub
    Private Sub LaadDatatables()
        'aanroep vanuit form load
        Me.MerkTableAdapter.Fill(Me.DS_Product.Merk, "%") 'alle merken laden
        Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, IDPRODUCT)
        If IsNumeric(TXT_locatie_id.Text) = False Then Me.TXT_locatie_id.Text = LOCATIESTART
        IDLOCATIE = TXT_locatie_id.Text
        Laadlocatie()
        'locatie laden
        'als dit veranderd?? dan 

    End Sub
    Private Sub Laadlocatie()
        Me.LocatieTableAdapter.Fill(DS_Product.Locatie, IDLOCATIE)
    End Sub
    Private Sub Knop_ZoekProduct_Click(sender As Object, e As EventArgs) Handles Knop_ZoekProduct.Click
        F_ProductZoek.ShowDialog()
        Me.TXT_Productnummer.Text = IDPRODUCT
        'LoadProduct() ' dit gaat vanzelf vanwege de changetext op bovenstaand veld
    End Sub
    Private Sub OPSLAAN()
        'NoEmpty()
        Me.Validate()
        Me.DT_productBindingSource.EndEdit()
        Me.DT_productTableAdapter.Update(DS_Product.DT_product)

        If IsNumeric(Me.TXT_Productnummer.Text) = False Then Me.TXT_Productnummer.Text = Me.TXT_IDP.Text


    End Sub
    Private Sub Knop_Delete_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        'save alle aanpassingen geef actief record door en sluit formulier af
        Dim jn As Integer
        Try
            If ValiDatie() = True Then
                OPSLAAN()
                If IsNumeric(Me.TXT_IDP.Text) = True Then IDPRODUCT = Me.TXT_IDP.Text
                Me.Close()
            Else
                jn = MsgBox("De gegevens kunnen niet worden opgeslagen." & Chr(13) & Chr(13) & "Wil je het formulier wel sluiten?", vbCritical + vbYesNo, "Opslaan niet mogelijk..")
                If jn = 6 Then
                    Me.Close()
                Else
                    Me.CB_Groep.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ErrorToString,, "Öpslaan() F_product")
        End Try
    End Sub
    Private Sub NoEmpty()
        'voorkomt dat lege teksten in de velden komen
        'kromme constructie maar concat functie lopen erop vast met gevolg lege velden in de lijsten
        If Len(Me.TXT_Naam.Text) < 1 Then Me.TXT_Naam.Text = " "
        If Len(Me.TXT_functie.Text) < 1 Then Me.TXT_functie.Text = " "
        If Len(Me.TXT_waarde.Text) < 1 Then Me.TXT_waarde.Text = " "
        If Len(Me.TXT_behuizing.Text) < 1 Then Me.TXT_behuizing.Text = " "
    End Sub
    Private Sub INITNieuw()
        'stelt alles in voor een nieuwe invoer.
        'knoppen
        Me.Knop_Opslaan.Enabled = True
        'velden
        With Me
            NUZ = True
            IDLOCATIE = LOCATIESTART
            .TXT_locatie_id.Text = IDLOCATIE
            .TXT_Productnummer.Text = Nothing
            .TXT_Verkoopprijs.Text = FormatNumber(0, -1)
            .TXT_Inkoopwaarde.Text = FormatNumber(0, -1)
            .TXT_Voorraad.Text = 0
            .TXT_Minimal.Text = 0

            Laadlocatie()
            Me.CB_Groep.Select()
        End With
    End Sub
    Private Sub INITBerekend()
        'berekende velden even 'schonen'
        Me.TXT_BTW.Text = FormatNumber(0, -1)
        Me.TXT_prijsexBTW.Text = FormatNumber(0, -1)
    End Sub
    Private Sub Knop_Locatie_Click(sender As Object, e As EventArgs) Handles Knop_Locatie.Click
        IDLOCATIE = Me.TXT_locatie_id.Text
        F_Locatie.ShowDialog()
        Me.TXT_locatie_id.Text = IDLOCATIE 'dit veld is in tabel product
        Laadlocatie()
    End Sub
    Private Sub TXT_Productnummer_TextChanged(sender As Object, e As EventArgs) Handles TXT_Productnummer.TextChanged
        If LUZ = False Then 'voorkomt dat als het idproduct wordt ingeschreven opnieuw het product wordt geladen
            PLaatsProduct()
        End If
        LUZ = False
    End Sub
    Private Sub PLaatsProduct()
        If NUZ = False Then 'als de knop nieuw is gebruikt 
            If IsNumeric(Me.TXT_Productnummer.Text) = True Then
                IDPRODUCT = Me.TXT_Productnummer.Text
                LoadProduct()
                BerekenPrijzen()
                If ValiDatie() = True Then
                    Me.Knop_Opslaan.Enabled = True
                End If
            Else
                MsgBox("Voer een geldig productnummer in", vbExclamation, "Productnummer invoeren")
            End If
        End If
        NUZ = False
    End Sub
    Private Function ValiDatie() As Boolean
        Dim JN As Boolean = False
        'txt.ipd MOet nummeriek zijn en een waarde bevatten
        If IsNumeric(Me.TXT_IDP.Text) = True Then JN = True
        'volgende alleen testen als jn =true
        If JN = True Then
            JN = False
            If IsNumeric(Me.CB_Groep.SelectedValue) = True Then
                If Me.CB_Groep.SelectedValue > 0 Then JN = True
            End If
        End If
        'volgende alleen testen als jn =true
        If JN = True Then
            JN = False

            If Len(Me.TXT_Naam.Text) > 0 Then JN = True
        End If
        Return JN
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.TB_Product.SelectTab(1)
    End Sub
    Private Sub TXT_Productnummer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Productnummer.KeyPress
        'snelkoppelingen voor allerlei functies op het artikelnummervak 
        If IsNumeric(e.KeyChar) = False Then
            Select Case e.KeyChar
                Case "z"
                    e.KeyChar = Nothing
                    PLaatsProduct()
                Case vbBack
                Case Else
                    e.KeyChar = Nothing
            End Select
        End If
    End Sub
    Private Sub OmSchrijVing()
        'maakt een enkele text wat het product beschrijft, wordt gebruikt in diverse zoek acties
        Dim T As String
        T = Me.TXT_Naam.Text & " " & Me.TXT_functie.Text & " " & Me.TXT_waarde.Text & " " & Me.TXT_behuizing.Text
        Me.TXT_Beschrijving2.Text = T
    End Sub
    Private Sub TXT_Naam_TextChanged(sender As Object, e As EventArgs) Handles TXT_Naam.TextChanged
        OmSchrijVing()
    End Sub
    Private Sub TXT_functie_TextChanged(sender As Object, e As EventArgs) Handles TXT_functie.TextChanged
        OmSchrijVing()
    End Sub
    Private Sub TXT_waarde_TextChanged(sender As Object, e As EventArgs) Handles TXT_waarde.TextChanged
        OmSchrijVing()
    End Sub
    Private Sub TXT_behuizing_TextChanged(sender As Object, e As EventArgs) Handles TXT_behuizing.TextChanged
        OmSchrijVing()
    End Sub
    Private Sub TXT_Verkoopprijs_Validated(sender As Object, e As EventArgs) Handles TXT_Verkoopprijs.Validated
        BerekenPrijzen()
    End Sub
    Private Sub TXT_Inkoopwaarde_Validated(sender As Object, e As EventArgs) Handles TXT_Inkoopwaarde.Validated
        If IsNumeric(TXT_Inkoopwaarde.Text) = True Then TXT_Inkoopwaarde.Text = FormatNumber(Me.TXT_Inkoopwaarde.Text, -1)
    End Sub
    Private Sub Knop_Merk_Click(sender As Object, e As EventArgs) Handles Knop_Merk.Click
        F_Merk.ShowDialog()
        Me.MerkTableAdapter.Fill(Me.DS_Product.Merk, "%") 'alle merken laden
    End Sub
    Private Sub TB_Product_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TB_Product.SelectedIndexChanged
        LaadTB()
    End Sub
    Private Sub LaadTB() 'laad de verschillende velden op de tabbladen 
        Dim T As Integer 'tag voor welke optie gekozen
        Select Case TB_Product.SelectedIndex
            Case 0 'Beschrijving
            Case 1 'Lijst, ontvangen, besteld, verbuikt
                For Each control In GB_Mutaties.Controls
                    If control.checked = True Then T = control.tag
                Next
                LaadMutLijst(T)
            Case 2 'pictures
                Me.PicturesTableAdapter.Fill(DS_Product.Pictures, IDPRODUCT)
            Case 3
                Me.ProductInfoTableAdapter.Fill(DS_Product.ProductInfo, IDPRODUCT)
            Case 4 'not used 27mei2017
        End Select
        'MsgBox(Me.TB_Product.SelectedIndex)
    End Sub
    Private Sub Optie_Mutatie_alles_Click(sender As Object, e As EventArgs) Handles Optie_Mutatie_alles.Click
        LaadMutLijst(1)
    End Sub
    Private Sub Optie_Mutatie_Ontvang_Click(sender As Object, e As EventArgs) Handles Optie_Mutatie_Ontvang.Click
        LaadMutLijst(3)
    End Sub
    Private Sub OPtie_Mutatie_Besteld_Click(sender As Object, e As EventArgs) Handles OPtie_Mutatie_Besteld.Click
        LaadMutLijst(2)
    End Sub
    Private Sub Optie_mutatie_Verbuik_Click(sender As Object, e As EventArgs) Handles Optie_mutatie_Verbuik.Click
        LaadMutLijst(4)
    End Sub
    Private Sub TKnop_Sluiten_Click(sender As Object, e As EventArgs) Handles TKnop_Sluiten.Click
        Dim jn As Integer
        jn = MsgBox("Wil je dit formulier sluiten, en alle gemaakte toevoegingen en veranderingen ongedaan maken?", vbQuestion + vbYesNo, "Afsluiten en annuleren?")
        If jn = 6 Then Me.Close()
    End Sub
    Private Sub Tknop_Nieuw_Click(sender As Object, e As EventArgs) Handles Tknop_Nieuw.Click
        Me.DT_productBindingSource.AddNew()
        INITNieuw()
    End Sub
    Private Sub Tknop_Opslaan_Click(sender As Object, e As EventArgs) Handles Tknop_Opslaan.Click
        OPSLAAN()
    End Sub
    Private Sub Tknop_annuleren_Click(sender As Object, e As EventArgs) Handles Tknop_annuleren.Click
        LoadProduct()
    End Sub
    Private Sub Tknop_Kopieer_Click(sender As Object, e As EventArgs) Handles Tknop_Kopieer.Click
        'kopieert het getoonde product naar een nieuw product, maakt nieuw record aan
        Dim jn As Integer
        If IsNumeric(Me.TXT_Productnummer.Text) = True Then
            If Me.TXT_Productnummer.Text > 0 Then
                jn = MsgBox("Kopie na aanmaken opzoeken, heet: Kopie laatst gemaakt." & Chr(13) & Chr(13) & "Het getoonde product kopieëren naar een nieuw product?", vbQuestion + vbYesNo, "Kopieëren bevestigen...")
                If jn = 6 Then
                    Me.DT_productTableAdapter.Insert(Me.CB_Groep.SelectedValue, Me.CB_Groep.SelectedValue, Me.TXT_Naam.Text & "(kopie)", Me.TXT_functie.Text, Me.TXT_waarde.Text, Me.TXT_behuizing.Text, "", "Kopie laatst gemaakt", Me.TXT_Verkoopprijs.Text, 0, 0, 0, 0)
                    Me.DT_productBindingSource.MoveLast()
                End If
            End If
        End If
    End Sub
    Private Sub Tknop_Delete_Click(sender As Object, e As EventArgs) Handles Tknop_Delete.Click
        Dim JaNee As Integer
        JaNee = MsgBox("Weet je zeker dat je dit product wilt verwijderen?", vbYesNo, " Product verwijderen.")
        If JaNee = 6 Then
            Me.DT_productBindingSource.RemoveCurrent()
            OPSLAAN()
            Me.Knop_ZoekProduct.Select()
        End If
    End Sub
    Private Sub Knop_Pics_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Pics_Opslaan.Click
        Me.Validate()
        Me.PicturesBindingSource.EndEdit()
        Me.PicturesTableAdapter.Update(DS_Product.Pictures)
    End Sub
    Private Sub Knop_Pics_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Pics_Nieuw.Click
        If Me.TXT_Productnummer.Text = True Then
            Me.PicturesBindingSource.AddNew()
            Me.TXT_Pics_Idproduct.Text = Me.TXT_Productnummer.Text
            Me.TXT_Pics_Naam.Select()
        Else
            MsgBox("Product is niet bepaald.", vbExclamation, "Geen product gekozen")
        End If

    End Sub
    Private Sub Knop_Pics_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Pics_Annuleren.Click
        LaadTB()
    End Sub
    Private Sub TXT_Pics_Url_TextChanged(sender As Object, e As EventArgs) Handles TXT_Pics_Url.TextChanged
        Me.Pic_Pic.ImageLocation = Me.TXT_Pics_Url.Text
    End Sub
    Private Sub Knop_links_opslaan_Click(sender As Object, e As EventArgs) Handles Knop_links_opslaan.Click
        Me.Validate()
        Me.ProductInfoBindingSource.EndEdit()
        Me.ProductInfoTableAdapter.Update(DS_Product.ProductInfo)
    End Sub
    Private Sub Knop_Links_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Links_Annuleren.Click
        LaadTB()
    End Sub
    Private Sub Knop_Links_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Links_Nieuw.Click
        If Me.TXT_Productnummer.Text = True Then
            Me.ProductInfoBindingSource.AddNew()
            Me.TXT_Links_IDproduct.Text = Me.TXT_Productnummer.Text
            Me.txt_Links_Naam.Select()
        Else
            MsgBox("Product is niet bepaald.", vbExclamation, "Geen product gekozen")
        End If
    End Sub
    Private Sub Knop_Links_Toon_Click(sender As Object, e As EventArgs) Handles Knop_Links_Toon.Click
        Dim HyperLink As String
        HyperLink = Me.TXT_Links_URL.Text
        System.Diagnostics.Process.Start(HyperLink)
    End Sub
    Private Sub DG_Mutaties_DoubleClick(sender As Object, e As EventArgs) Handles DG_Mutaties.DoubleClick
        Dim i As Integer
        Dim ID As Integer
        Dim Oid As Integer
        Oid = IDGETONTVANGST
        If Me.DG_Mutaties.Rows.Count > 0 Then
            For i = 0 To Me.DG_Mutaties.Rows.Count - 1
                If Me.DG_Mutaties.Rows(i).Selected = True Then ID = Me.DG_Mutaties.Rows(i).Cells(1).Value
            Next
        End If
        MsgBox("Getontvangst=: " & ID & ". Maar volgens mij heb je hier echt niks aan, ga hier niet mee verder, getontvangst formulier exclusief voor 1 record openen is echt een hele toer en volgens mij 3 juni heb je der niks aan", vbEmpty, "???")

    End Sub
    Private Sub TB_Product_Enter(sender As Object, e As EventArgs) Handles TB_Product.Enter
        'automatisch oslaan nieuw artikel
        If Me.TXT_IDP.Text < 0 Then
            OPSLAAN()
        End If
    End Sub
    Private Sub TXT_Verkoopprijs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Verkoopprijs.KeyPress
        e.KeyChar = PuntKomma(e.KeyChar)
        'MsgBox(e.KeyChar)
        '  If e.KeyChar = "." Then
        ' e.KeyChar = ","
        '  End If
    End Sub
    Private Sub TXT_Inkoopwaarde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Inkoopwaarde.KeyPress
        e.KeyChar = PuntKomma(e.KeyChar)
    End Sub
    Private Sub TXT_locatie_id_TextChanged(sender As Object, e As EventArgs) Handles TXT_locatie_id.TextChanged

    End Sub

    Private Sub TXT_Naam_Enter(sender As Object, e As EventArgs) Handles TXT_Naam.Enter
        If IsNumeric(Me.TXT_IDP.Text) = False Then
            MsgBox("Er is geen product bepaald." & Chr(13) & "Zoek een product of druk op nieuw (ALT+N) voor een nieuw product", vbExclamation, "Geen product bepaald")
        End If
    End Sub
End Class
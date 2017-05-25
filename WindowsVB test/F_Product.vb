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
        'berekend de diverse prijzen en steld juiste format in
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
        'TODO: This line of code loads data into the 'DS_Product.ProductMut' table. You can move, or remove it, as needed.
        Me.ProductMutTableAdapter.Fill(Me.DS_Product.ProductMut)
        'TODO: This line of code loads data into the 'DS_Product.GroepPD' table. You can move, or remove it, as needed.
        Me.GroepPDTableAdapter.Fill(Me.DS_Product.GroepPD)
        'TODO: This line of code loads data into the 'DS_Product1.GroepPD' table. You can move, or remove it, as needed.
        'Me.GroepPDTableAdapter.Fill(Me.DS_Product1.GroepPD)
        Me.ToolTipsInstellen()
        LoadProduct()
    End Sub
    Public Sub LoadProduct()
        Try
            LoadTables()
            Select Case OPPRODUCT
                Case 1 'bestaand product
                    Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, IDPRODUCT)
                    LUZ = True
                    Me.TXT_Productnummer.Text = IDPRODUCT

                    'If IDPRODUCT > 0 Then Me.Knop_Opslaan.Enabled = True
                Case 2 'nieuw product invoeren.

                Case Else 'opening vrij
                    Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, IDPRODUCT)
                    'Me.Knop_Opslaan.Enabled = False
                    Me.TXT_Productnummer.Select()
            End Select
        Catch ex As Exception
            MsgBox(ErrorToString,, "Loadproduct (F_product)")
        End Try
    End Sub
    Private Sub LoadTables()
        Me.MerkTableAdapter.Fill(Me.DS_Product.Merk, "%") 'alle merken laden
        Me.LocatieTableAdapter.FillByALL(Me.DS_Product.Locatie)
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
            .TXT_Productnummer.Text = Nothing
            .TXT_Verkoopprijs.Text = FormatNumber(0, -1)
            .TXT_Inkoopwaarde.Text = FormatNumber(0, -1)
            .TXT_Voorraad.Text = 0
            .TXT_Minimal.Text = 0
            .CB_Locatie.SelectedValue = 1
            Me.CB_Groep.Select()
        End With
    End Sub
    Private Sub Knop_Locatie_Click(sender As Object, e As EventArgs) Handles Knop_Locatie.Click
        Try
            IDLOCATIE = Me.CB_Locatie.SelectedValue
            F_Locatie.ShowDialog()
            Me.LocatieTableAdapter.FillByALL(Me.DS_Product.Locatie) 'combobox opnieuw laden, requery zeg maar ...
            Me.CB_Locatie.SelectedValue = IDLOCATIE
        Catch ex As Exception
            MsgBox(ErrorToString,, "Knop_locatie")
        End Try
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
    Private Sub TSM_Opslaan_Click(sender As Object, e As EventArgs) Handles TSM_Opslaan.Click
        OPSLAAN()
    End Sub
    Private Sub AnnulerenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnulerenToolStripMenuItem.Click
        LoadProduct()
    End Sub
    Private Sub SluitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SluitenToolStripMenuItem.Click
        Dim jn As Integer
        jn = MsgBox("Wil je dit formulier sluiten, en alle gemaakte toevoegingen en veranderingen ongedaan maken?", vbQuestion + vbYesNo, "Afsluiten en annuleren?")
        If jn = 6 Then Me.Close()
    End Sub
    Private Sub NieuwProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NieuwProductToolStripMenuItem.Click
        Me.DT_productBindingSource.AddNew()
        INITNieuw()
    End Sub
    Private Sub ProductWissenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductWissenToolStripMenuItem.Click
        Dim JaNee As Integer
        JaNee = MsgBox("Weet je zeker dat je dit product wilt verwijderen?", vbYesNo, " Product verwijderen.")
        If JaNee = 6 Then
            Me.DT_productBindingSource.RemoveCurrent()
            OPSLAAN()
            Me.Knop_ZoekProduct.Select()
        End If
    End Sub
    Private Sub Knop_Merk_Click(sender As Object, e As EventArgs) Handles Knop_Merk.Click
        F_Merk.ShowDialog()
        Me.MerkTableAdapter.Fill(Me.DS_Product.Merk, "%") 'alle merken laden
    End Sub
    Private Sub TXT_Productnummer_Validated(sender As Object, e As EventArgs) Handles TXT_Productnummer.Validated
        'PLaatsProduct()
    End Sub
    Private Sub TB_Product_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TB_Product.SelectedIndexChanged
        MsgBox(Me.TB_Product.SelectedIndex)
    End Sub
End Class
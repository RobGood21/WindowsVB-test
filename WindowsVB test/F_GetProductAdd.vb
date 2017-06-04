Public Class F_GetProductAdd
    Private UP As Boolean = False 'UP= uitzondering prijs, voorkomt het aanpassen van de inkoopprijs. Bij txtchange
    Private UID As Boolean = False ' laad uitzondering als product wordt opgezocht of bij laden al meegekregen. TXT_change van IDproduct
    Private Sub F_GetProductAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTips()
        Me.ValutaTableAdapter.Fill(Me.DS_Product.Valuta)
        LoadForm()
    End Sub
    Private Sub LoadForm()
        Try
            'gegevens uit parentform
            Me.TXT_GetPA_parent.Text = F_GetProduct.TXT_getontvangstid.Text
            Me.TXT_ProductLijst.Text = F_GetProduct.TXT_NaamGet.Text
            'MsgBox(OPGETPRODUCTADD)
            Select Case OPGETPRODUCTADD
                Case 1 'openen met nieuw aan de lijst toe te voegen product
                    Me.GetProductAddBindingSource.AddNew()
                    LoadProduct() 'dit is JUIST, laden met lege waardes
                    Me.Knop_Zoek.Select()
                    Me.TXT_aantal.Text = 0
                Case 2, 3, 4 'Openen met een bestaande getProductadd
                    '3=opslaan niet mogelijk 4 = openen vanuit een besteld artikel
                    'dus het BESTEL getontvangstadd nu laden... bij het opslaan een NIEUW record voor de ontvangst aanmaken.
                    Me.GetProductAddTableAdapter.Fill(Me.DS_Product.GetProductAdd, IDGETPRODUCTADD)
                    'Me.TXT_aantal.Text = Me.TXT_LijstAAntal.Text
                    Me.TXT_aantal.Select()
            End Select
        Catch ex As Exception
            MsgBox(ErrorToString,, "loadform (getproductadd)")
        End Try
    End Sub
    Private Sub ToolTips()
        Dim TT_GetProductADD As New ToolTip()
        ' Set up the delays for the ToolTip.
        TT_GetProductADD.AutoPopDelay = 5000
        TT_GetProductADD.InitialDelay = 100
        TT_GetProductADD.ReshowDelay = 50
        ' Force the ToolTip text to be displayed whether or not the form is active.
        TT_GetProductADD.ShowAlways = True
        ' Set up the ToolTip text for the Button and Checkbox.
        'Knoppen
        With TT_GetProductADD
            'Knoppen
            .SetToolTip(Me.Knop_Reset, "Reset inkoopprijs naar de inkoopprijs als bepaald in het product.")
            '.SetToolTip(Me.Knop_Opslaan, "Productlijst tussendoor opslaan")
            '.SetToolTip(Me.Knop_Annuleren, "alle invoer ongedaan maken")
            '.SetToolTip(Me.Knop_Opslaan, "Alle invoer en aanpassingen opslaan en formulier sluiten")
            '.SetToolTip(Me.Knop_Save, "Alle invoer (tussentijds) opslaan.")

            'Textboxes en comboos
            .SetToolTip(Me.CB_valuta, "Valuta alleen voor berekening inkoopprijs, wordt hier niet opgeslagen")
            .SetToolTip(Me.TXT_TotaalBetaaldVAL, "Kies de valuta, het aantal en vul het totaal betaalde bedrag in om de inkoopprijs per stuk te berekenen.")

            'Overige
            '.SetToolTip(Me.CB_Ontvangen, "Kies een productlijst in behandeling")
        End With
    End Sub
    Private Sub LoadProduct()
        'MsgBox("loadproduct?")
        Dim VP As Boolean = False 'vp=verander prijs
        Try
            UID = True
            Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, IDPRODUCT)
            'inkoopprijs 
            If IsNumeric(Me.TXT_Prijs.Text) = True Then 'is dus een nummer
                If Me.TXT_Prijs.Text = 0 Then VP = True
            Else
                VP = True
            End If
            If IsNumeric(TXT_Product_Inkoop.Text) = True And VP = True Then 'er is een inkoopprijs voor dit product
                Me.TXT_Prijs.Text = Me.TXT_Product_Inkoop.Text 'inkoopprijs overnemen uit productgegevens
            End If
        Catch ex As Exception
            MsgBox(ErrorToString,, "Loadproduct() Getproductadd")
        End Try
    End Sub
    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        Opslaan()
        afsluiten()
    End Sub
    Private Sub afsluiten()
        'bij afsluiten diverse txtvelden even initialiseren. 
        'Me.TXT_ProductID.Text = -1
        'Me.TXT_LijstAAntal.Text = -1
        'Me.TXT_Besteld.Text = -1
        Me.Close()

    End Sub
    Private Sub Knop_Details_Click(sender As Object, e As EventArgs) Handles Knop_Details.Click
        'is er een product al bepaald? 
        Dim J As Boolean = False
        If IsNumeric(Me.TXT_ProductID.Text) = True Then 'staat er een nummer in het veld ID van het product
            If Me.TXT_ProductID.Text > 0 Then J = True
        End If

        If J = True Then
            OPPRODUCT = 1
            IDPRODUCT = Me.TXT_ProductID.Text
        Else
            OPPRODUCT = 1
            IDPRODUCT = -1
        End If

        F_Product.ShowDialog()
        Me.TXT_ProductID.Text = IDPRODUCT
        LoadProduct()
    End Sub
    Private Sub GetProductAddBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Opslaan()
    End Sub
    Private Sub GPAUpdate()
        'MsgBox("gaupupdate")
        'opslaan van getproductadd record
        Me.Validate()
        Me.GetProductAddBindingSource.EndEdit()
        Me.GetProductAddTableAdapter.Update(Me.DS_Product.GetProductAdd)
    End Sub
    Public Sub Opslaan()
        Dim jn As Integer
        Try
            If Validatie() = True Then
                Select Case OPGETPRODUCTADD
                    Case 1, 2 'nieuw of besteaand uit productlijst
                        'getontvangstID koppelen aan dit form
                        Me.TXT_IDONTV.Text = IDGETONTVANGST
                        ' Me.TXT_LijstAAntal.Text = Me.TXT_aantal.Text
                        GPAUpdate()
                   ' Case 3 'niet toegestaan iets op te slaan

                    Case 4 'besteld product naar ontvangst zetten
                        'nieuw record aanmaken voor ontvangen spullejes
                        MsgBox(Me.TXT_aantal.Text)
                        Me.GetProductAddTableAdapter.Insert(Me.TXT_GetPA_parent.Text, Me.TXT_ProductID.Text, 0, Me.TXT_Prijs.Text, 0, Me.TXT_aantal.Text, 0)
                        'parent of het getproductadd waarnee form is geladen aanpassen. (besteld aantal)
                        Me.TXT_Besteld.Text = Int(Me.TXT_Besteld.Text) - Int(Me.TXT_aantal.Text) 'bereken rest wat nog in bestelling staat
                        GPAUpdate()
                End Select

                If TXT_Product_Inkoop.Text <> Me.TXT_Prijs.Text Then jn = MsgBox("Wil je deze inkoopprijs ook in de product gegevens opslaan?", vbQuestion + vbYesNo, "Inkoopprijs verschilt van bekende product inkoopprijs...")
                If jn = 6 Then
                    Me.TXT_Product_Inkoop.Text = Me.TXT_Prijs.Text
                    'MsgBox("nu product record updatten")
                    Me.DT_productBindingSource.EndEdit()
                    Me.DT_productTableAdapter.Update(DS_Product.DT_product)
                End If

            Else
                MsgBox("Invoer of verandering is niet opgeslagen.", vbExclamation, "Opslaan niet mogelijk")
            End If
        Catch ex As Exception
            MsgBox(ErrorToString,, "Opslaan (getproductadd) ")
        End Try
    End Sub
    Private Function Validatie() As Boolean
        'controleren of er kan worden opgeslagen
        Dim JN As Boolean
        JN = False
        If OPGETPRODUCTADD = 3 Then 'opslaan nu niet mogelijk
            JN = False
        Else
            If IsNumeric(Me.TXT_aantal.Text) = True Then
                If Me.TXT_aantal.Text <> 0 Then
                    If IsNumeric(TXT_ProductID.Text) = True Then
                        If (Me.TXT_ProductID.Text) > 0 Then JN = True
                    End If
                End If
            End If
        End If
        Return JN
    End Function
    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        afsluiten()
    End Sub
    Private Sub F_GetProductAdd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'reset publieke variabelen bij verlaten form.
        OPGETPRODUCTADD = 0
        IDGETPRODUCTADD = 0
    End Sub
    Private Sub TXT_ProductID_TextChanged(sender As Object, e As EventArgs) Handles TXT_ProductID.TextChanged
        If UID = False Then
            If IsNumeric(Me.TXT_ProductID.Text) = True Then
                IDPRODUCT = Me.TXT_ProductID.Text
                LoadProduct()
            End If
        Else
            UID = False
        End If
    End Sub
    Private Sub Knop_NieuwProduct_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Knop_Zoek_Click(sender As Object, e As EventArgs) Handles Knop_Zoek.Click
        F_ProductZoek.ShowDialog()
        LoadProduct()
        UID = True
        Me.TXT_ProductID.Text = IDPRODUCT
        Me.TXT_aantal.Select()
    End Sub
    Private Sub TXT_TotaalBetaaldVAL_Validated(sender As Object, e As EventArgs) Handles TXT_TotaalBetaaldVAL.Validated
        bereken(1)
    End Sub
    Private Sub bereken(Control As Integer) '1=totaal betaald valuta
        Try
            Select Case Control
                Case 1 'vanuit de totaal betaald vreemde valuta
                    Me.TXT_TotaalBetaaldEur.Text = FormatNumber(Me.TXT_TotaalBetaaldVAL.Text * TXT_Koers.Text, -1)
                    Me.TXT_TotaalBetaaldVAL.Text = FormatNumber(Me.TXT_TotaalBetaaldVAL.Text, -1)

                Case 2 '


                Case 3
            End Select
            If IsNumeric(Me.TXT_aantal.Text) = True Then Me.TXT_Prijs.Text = FormatNumber(TXT_TotaalBetaaldEur.Text / Me.TXT_aantal.Text, -1)
            'prijs is veranderd dus vlag naar true, bij sluiten inkoopprijs in product aanpassen
            'Vprijs = True
        Catch ex As Exception
            ' MsgBox(ErrorToString,, "Bereken")
        End Try

    End Sub
    Private Sub TXT_Koers_TextChanged(sender As Object, e As EventArgs) Handles TXT_Koers.TextChanged
        bereken(1)
    End Sub
    Private Sub TXT_aantal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_aantal.KeyPress
        'MsgBox("key")
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "-" And e.KeyChar <> vbBack Then
            e.KeyChar = Nothing
            'MsgBox(e.KeyChar)
        End If
    End Sub
    Private Sub Knop_Verwijder_Click(sender As Object, e As EventArgs) Handles Knop_Verwijder.Click
        Select Case OPGETPRODUCTADD
            Case 3 'opslaan verwijderen niet toegestaan
                MsgBox("Deze productlijst is al afgesloten, verwijderen van een product uit de lijst is niet meer mogelijk.", vbExclamation, "Verwijderen niet mogelijk...")
            Case Else
                Dim jn As Integer
                jn = MsgBox("weet je zeker dat je dit product van de productlijst af wilt?" & Chr(13) & "(Product wordt niet verwijderd, alleen uit de lijst gehaald.)", vbExclamation + vbYesNo, "Product uit de lijst halen?")
                If jn = 6 Then
                    Me.GetProductAddBindingSource.RemoveCurrent()
                    Me.Validate()
                    Me.GetProductAddBindingSource.EndEdit()
                    Me.GetProductAddTableAdapter.Update(DS_Product.GetProductAdd)
                    Me.Close()
                End If
        End Select
    End Sub
    Private Sub Knop_Reset_Click(sender As Object, e As EventArgs) Handles Knop_Reset.Click
        If IsNumeric(Me.TXT_Product_Inkoop.Text) = True Then Me.TXT_Prijs.Text = Me.TXT_Product_Inkoop.Text
    End Sub
    Private Sub TXT_Besteld_TextChanged(sender As Object, e As EventArgs) Handles TXT_Besteld.TextChanged
        If OPGETPRODUCTADD = 4 Then Me.TXT_aantal.Text = Me.TXT_Besteld.Text
    End Sub
    Private Sub TXT_aantal_Validated(sender As Object, e As EventArgs) Handles TXT_aantal.Validated
        If IsNumeric(Me.TXT_aantal.Text = True) Then
            Select Case OPGETPRODUCTADD
                Case 1, 2
                    Me.TXT_LijstAAntal.Text = Me.TXT_aantal.Text
                Case 4

            End Select
            bereken(1)
        End If

    End Sub
    Private Sub TXT_LijstAAntal_TextChanged(sender As Object, e As EventArgs) Handles TXT_LijstAAntal.TextChanged

        Select Case OPGETPRODUCTADD
            Case 2, 3, 4
                'MsgBox("text changed")
                Me.TXT_aantal.Text = Me.TXT_LijstAAntal.Text
        End Select
    End Sub
End Class
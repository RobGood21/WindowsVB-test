Public Class F_GetProduct
    'Opmerkingen:
    '    productlijst, uit tabel getontvangst (naam is een drama, getlijst? getproducten? maar goed is dus getontvangst geworden, erg verwarrend mee eens...) 
    '    heeft items uit tabel getproductadd, deze productlijst Is om te zetten naar een bestelling Of ontvangst
    '    tabel Is te vullen met handmatig toevoegen, of kiezen uit bestelde producten, door klanten bestelde producten of adviesen door minimale voorraad.
    '    Het veld In de productlijst, getontvangst, status dan zetten. 1=inbehandelng 2=Bestelling (bij leverancer) 3=Ontvangen in voorraad.
    'Volgorde van colums in de datagrids is essentieel. 
    'DG_lijst (0) = IDGetproductadd (1)= IDproduct(2)=IDgetontvangst (3)= Ontvangen aantal (4)= besteld aantal 
    '(5)=Lijstaantal (6) =Product (beschrijving) (7)= locatie  (8) = inkoop (9)= voorraad 

    ' verwijderen uit datagridview  DG_Lijst.Rows.Remove(DG_Lijst.Rows(DG_Lijst.SelectedCells.Item(0).RowIndex))
    Dim BeVat As Boolean = False
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
            .SetToolTip(Me.Knop_Opslaan, "Productlijst tussendoor opslaan")
            '.SetToolTip(Me.Knop_Annuleren, "alle invoer ongedaan maken")
            '.SetToolTip(Me.Knop_Opslaan, "Alle invoer en aanpassingen opslaan en formulier sluiten")
            '.SetToolTip(Me.Knop_Save, "Alle invoer (tussentijds) opslaan.")

            'Textboxes en comboos
            .SetToolTip(Me.TXT_NaamGet, "Het kenmerk van deze productlijst")

            'Overige
            .SetToolTip(Me.CB_Ontvangen, "Kies een productlijst in behandeling")
        End With
    End Sub
    Private Sub INITvelden()
        Me.TB_Products.SelectTab(0)
        Me.DA_Datum.Value = Now() 'aanmaakdatum instellen
        Me.txt_Status.Text = 1 'statusveld naar 1 (in behandeling)
        Me.Knop_BoekOntvangst.Enabled = False
        INITkosten()
    End Sub
    Private Sub INITkosten()
        Me.TXT_Boekwaarde.Text = FormatNumber(0, -1)
        Me.TXT_Lijstwaarde.Text = FormatNumber(0, -1)
        Me.BeVat = False
    End Sub
    Private Sub F_GetProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTipsInstellen()
        'TODO: This line of code loads data into the 'DS_Product.GetProductAdd' table. You can move, or remove it, as needed.
        ' Me.GetProductAddTableAdapter.Fill(Me.DS_Product.GetProductAdd)
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
        Catch ex As Exception
            MsgBox(ErrorToString,, "Opslaan()")
        End Try
    End Sub
    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
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
            Me.GetOntvangstTableAdapter.Fill(Me.DS_Product.GetOntvangst)
            LaadProductList()


        Catch ex As Exception
            MsgBox(ErrorToString,, "Laadform")
        End Try





    End Sub
    Private Sub CB_Supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Supplier.SelectedIndexChanged
        'LaadShop(2)
        ' IDSUPPLIER = Me.CB_Supplier.SelectedValue

    End Sub
    Private Sub Knop_DetailsShop_Click(sender As Object, e As EventArgs) Handles Knop_DetailsShop.Click

        IDSUPPLIER = Me.CB_Supplier.SelectedValue
        IDSHOP = Me.CB_Shop.SelectedValue
        F_Shop.ShowDialog()
        LaadShop(1)
        Me.CB_Shop.SelectedValue = IDSHOP

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
        Try
            'Me.GetProductListTableAdapter.Fill(Me.DS_Product.GetProductList, New System.Nullable(Of Integer)(CType(Me.CB_Ontvangen.SelectedValue, Integer)))
            Me.GetProductListTableAdapter.Fill(Me.DS_Product.GetProductList, Me.CB_Ontvangen.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        GetOntvangstBindingSource.AddNew() 'nieuwe order, ontvangst aanmaken
        INITvelden()
    End Sub
    Private Sub CB_Supplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Supplier.SelectionChangeCommitted

    End Sub
    Private Sub CB_Ontvangen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Ontvangen.SelectedIndexChanged
        'MsgBox("nu??")
        INITvelden()
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
    Private Sub ProductLoad()
        Try
            'Me.GetProductListTableAdapter.Fill(Me.DS_Product.GetProductList, New System.Nullable(Of Integer)(CType(IDGOPToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LaadForm()
    End Sub
    Private Sub EditGrid()
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
    Private Sub Knop_update_Click(sender As Object, e As EventArgs) Handles Knop_update.Click
        Me.DG_Lijst.Update()
    End Sub
    Private Sub Knop_OpslaanDB_Click(sender As Object, e As EventArgs) Handles Knop_OpslaanDB.Click

        Me.Validate()
        Me.GetProductListBindingSource.EndEdit()
        Me.GetOntvangstBindingSource.EndEdit()
        'Me.GetProductListTableAdapter.update(DS_Product.GetProductList)
        Me.GetOntvangstTableAdapter.Update(DS_Product.GetOntvangst)

    End Sub
    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            '  Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(IDProductToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

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
    Private Sub Knop_Kosten_Click(sender As Object, e As EventArgs) Handles Knop_Kosten.Click
        If ValidatieINKOOP() = True Then
            Try

                Opslaan() 'Op dit moment de Getontvangst record updaten of opslaan (knop opslaan kan dus weg...)

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
                    BerekenLijstWaarde()
                    If Len(Me.TXT_Boekwaarde.Text) > 0 And BeVat = True Then 'bevat is of er een item in de lijst staat met lijstaantal <> 0
                        Me.Knop_BoekOntvangst.Enabled = True
                    End If


                End If
            Catch ex As Exception
                MsgBox(ErrorToString,, "knop_kosten enz ")
            End Try
        End If

    End Sub
    Private Function ValidatieINKOOP() As Boolean
        Dim jn As Boolean = False
        If Me.CB_Supplier.SelectedValue > 1 Then
            jn = True
        Else
            MsgBox("Er moet een leverancier, supplier worden bepaald om de kosten voor deze ontvangst te boeken.", vbCritical, "Geen leverancier gekozen...")
        End If


        Return jn
    End Function
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
    Private Sub Knop_BoekOntvangst_Click(sender As Object, e As EventArgs) Handles Knop_BoekOntvangst.Click
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
                    IDGPA = Me.DG_Lijst.Rows(i).Cells(0).Value 'id van Getproductadd van deze regel
                    IDP = Me.DG_Lijst.Rows(i).Cells(1).Value 'id van product van deze regel
                    'vul de beide datatables 
                    Me.GPA_AantalTableAdapter.Fill(Me.DS_Product.GPA_Aantal, IDGPA)
                    Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, IDP)

                    If IsNumeric(Me.DG_Lijst.Rows(i).Cells(8).Value) = True Then
                        BP = Me.DG_Lijst.Rows(i).Cells(8).Value
                    Else
                        BP = 0
                    End If

                    'zet de waardes over
                    WaardesMove(BP)
                    'update de beide datatables... 
                    OPslaanTables()
                Next
                'Datagridview herladente
                LaadProductList()
                Me.GB_Get.Select()
                BerekenLijstWaarde()

            Catch ex As Exception
                MsgBox(ErrorToString,, "Knop Boekontvangst")
            End Try

        End If 'voor de jn vraag
    End Sub
    Private Sub WaardesMove(Prijs As Decimal)
        Dim L As Integer = 0
        Dim V As Integer = 0 'Zorgen dat de text velden WAARDES gaan bevatten en geen teksten

        Try
            If IsNumeric(Me.TXT_LijstAantal.Text) = True Then L = Me.TXT_LijstAantal.Text
            If IsNumeric(Me.TXT_Voorraad.Text) = True Then V = Me.TXT_Voorraad.Text

            Me.TXT_ontvangen.Text = L
            Me.TXT_Voorraad.Text = L + V
            Me.TXT_Prijs.Text = Prijs
            Me.TXT_LijstAantal.Text = 0

        Catch ex As Exception
            MsgBox(ErrorToString,, "Waardesmove")
        End Try
    End Sub
    Private Sub OPslaanTables()
        'gebruikr voor ussendoor opalssn van de datatables
        Try
            Me.Validate()
            Me.GPA_AantalBindingSource.EndEdit()
            Me.DT_productBindingSource.EndEdit()
            Me.GPA_AantalTableAdapter.Update(DS_Product.GPA_Aantal)
            Me.DT_productTableAdapter.Update(DS_Product.DT_product)
        Catch ex As Exception
            MsgBox(ErrorToString,, "OPslaan tables")
        End Try
    End Sub
    Private Sub knop_OpslaanLijst_Click(sender As Object, e As EventArgs)

        Me.Validate()
        'Me.GetProductListBindingSource.EndEdit()
        'Me.GetProductListTableAdapter.Update(DS_Product.GetProductAdd)

    End Sub
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Tpage_Leveren_Enter(sender As Object, e As EventArgs) Handles Tpage_Leveren.Enter
        Try
            'MsgBox("enter")
            Me.GPA_OntvangenLijstTableAdaptor_.Fill(DS_Product.GPA_OntvangenLijst_, Me.CB_Supplier.SelectedValue)
        Catch ex As Exception
            MsgBox(ErrorToString,, " Tpage_advies leveren enter")

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
            OPGETPRODUCTADD = 2
            IDGETONTVANGST = Me.TXT_getontvangstid.Text
            F_GetProductAdd.ShowDialog()
            'Productlijst herladen
            LaadProductList()

        End If

    End Sub
    Private Sub DG_Lijst_DoubleClick(sender As Object, e As EventArgs) Handles DG_Lijst.DoubleClick
        ProductTonen()
    End Sub
    Private Sub Knop_ProductPLus_Click(sender As Object, e As EventArgs) Handles Knop_ProductPLus.Click
        Try
            IDGETONTVANGST = Me.CB_Ontvangen.SelectedValue
            OPGETPRODUCTADD = 1
            IDPRODUCT = -1
            ' MsgBox(IDGETONTVANGST)
            F_GetProductAdd.ShowDialog()
            LaadProductList()
        Catch ex As Exception
            MsgBox(ErrorToString,, "Knop productplus")

        End Try

    End Sub
    Private Sub Knop_Toon_Click(sender As Object, e As EventArgs) Handles Knop_Toon.Click
        ProductTonen()
    End Sub

    Private Sub Knop_Bestelling_Click(sender As Object, e As EventArgs) Handles Knop_Bestelling.Click
        Dim jn As Integer
        jn = MsgBox("Wil je de producten als in de lijst omzetten naar een bestelling bij deze leverancier?", vbQuestion + vbYesNo, "Bestelling aanmaken bevestigen...")
        If jn = 6 Then

        End If
    End Sub
End Class
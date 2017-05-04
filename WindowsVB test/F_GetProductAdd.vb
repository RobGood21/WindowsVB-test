Public Class F_GetProductAdd
    Private Sub F_GetProductAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ValutaTableAdapter.Fill(Me.DS_Product.Valuta)
        LoadForm()

    End Sub
    Private Sub LoadForm()
        Try
            Me.TXT_ProductLijst.Text = F_GetProduct.TXT_NaamGet.Text


            Select Case OPGETPRODUCTADD
                Case 1 'openen met nieuw aan de lijst toe te voegen product
                    Me.GetProductAddBindingSource.AddNew()
                    INITvelden()
                    LoadProduct() 'dit is JUIST, laden met lege waardes
                Case 2 'Openen met een bestaande getProductadd
                    Me.GetProductAddTableAdapter.Fill(Me.DS_Product.GetProductAdd, IDGETPRODUCTADD)

                    'MsgBox(IDGETPRODUCTADD)
                    'LoadProduct()
            End Select
        Catch ex As Exception
            MsgBox(ErrorToString,, "loadform (getproductadd)")
        End Try
    End Sub
    Private Sub INITvelden()

        Me.TXT_PDnaam.Text = ""
        Me.TXT_PDfunctie.Text = ""
        Me.TXT_PDwaarde.Text = ""
        Me.TXT_PDbehuizing.Text = ""

    End Sub
    Private Sub LoadProduct()
        Try
            'MsgBox(IDPRODUCT)
            Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, IDPRODUCT)
        Catch ex As Exception
            MsgBox(ErrorToString,, "Loadproduct() Getproductadd")
        End Try
    End Sub
    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        Opslaan()
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
    End Sub
    Private Sub GetProductAddBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Opslaan()
    End Sub
    Public Sub Opslaan()
        Try
            If Validatie() = True Then
                'getontvangstID koppelen aan dit form
                Me.TXT_IDONTV.Text = IDGETONTVANGST
                Me.Validate()
                Me.GetProductAddBindingSource.EndEdit()
                Me.GetProductAddTableAdapter.Update(Me.DS_Product.GetProductAdd)
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
        If IsNumeric(Me.TXT_aantal.Text) = True Then
            If Me.TXT_aantal.Text <> 0 Then
                If IsNumeric(TXT_ProductID.Text) = True Then
                    If (Me.TXT_ProductID.Text) > 0 Then JN = True
                End If
            End If
        End If
        Return JN
    End Function
    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        Me.GetProductAddBindingSource.EndEdit()
        Me.Validate()
        Me.Close()
    End Sub
    Private Sub F_GetProductAdd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'reset publieke variabelen bij verlaten form.
        OPGETPRODUCTADD = 0
        IDGETPRODUCTADD = 0
    End Sub
    Private Sub TXT_ProductID_TextChanged(sender As Object, e As EventArgs) Handles TXT_ProductID.TextChanged
        If IsDBNull(TXT_ProductID.Text) = False And IsNumeric(Me.TXT_ProductID.Text) = True Then
            IDPRODUCT = Me.TXT_ProductID.Text
            LoadProduct()
        End If
    End Sub
    Private Sub Knop_NieuwProduct_Click(sender As Object, e As EventArgs) Handles Knop_NieuwProduct.Click
        Me.Close()
    End Sub
    Private Sub Knop_Zoek_Click(sender As Object, e As EventArgs) Handles Knop_Zoek.Click
        F_ProductZoek.ShowDialog()
        Me.TXT_ProductID.Text = IDPRODUCT
        LoadProduct()
    End Sub
    Private Sub TXT_Prijs_TextChanged(sender As Object, e As EventArgs) Handles TXT_Prijs.TextChanged
        'MsgBox("textchanged")

    End Sub
    Private Sub TXT_Prijs_Validated(sender As Object, e As EventArgs) Handles TXT_Prijs.Validated
        Try
            TXT_Prijs.Text = FormatNumber(TXT_Prijs.Text, -1)
        Catch ex As Exception
            MsgBox(ErrorToString,, "TXT_Prijs_Validated")
        End Try


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(Validatie())


    End Sub
    Private Sub TXT_TotaalBetaaldVAL_Validated(sender As Object, e As EventArgs) Handles TXT_TotaalBetaaldVAL.Validated
        bereken(1)
    End Sub
    Private Sub bereken(Control As Integer) '1=totaal betaald valuta
        Try
            Select Case Control
                Case 1 'vanuit de totaal betaald vreemde valuta
                    Me.TXT_TotaalBetaaldEur.Text = FormatNumber(Me.TXT_TotaalBetaaldVAL.Text / TXT_Koers.Text, -1)
                    Me.TXT_TotaalBetaaldVAL.Text = FormatNumber(Me.TXT_TotaalBetaaldVAL.Text, -1)

                Case 2 '


                Case 3
            End Select
            If IsNumeric(Me.TXT_aantal.Text) = True Then Me.TXT_Prijs.Text = FormatNumber(TXT_TotaalBetaaldEur.Text / Me.TXT_aantal.Text, -1)

        Catch ex As Exception
            ' MsgBox(ErrorToString,, "Bereken")
        End Try

    End Sub
    Private Sub TXT_Lijstaantal_Validated(sender As Object, e As EventArgs) Handles TXT_aantal.Validated
        If IsNumeric(Me.TXT_TotaalBetaaldVAL.Text) = True Then bereken(1)
    End Sub
    Private Sub TXT_Koers_TextChanged(sender As Object, e As EventArgs) Handles TXT_Koers.TextChanged

        bereken(1)

    End Sub
    Private Sub TXT_aantal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_aantal.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "-" And e.KeyChar <> vbBack Then
            e.KeyChar = Nothing
            'MsgBox(e.KeyChar)
        End If
    End Sub

    Private Sub Knop_Verwijder_Click(sender As Object, e As EventArgs) Handles Knop_Verwijder.Click
        Dim jn As Integer
        jn = MsgBox("weet je zeker dat je dit product van de productlijst af wilt?" & Chr(13) & "(Product wordt niet verwijderd, alleen uit de lijst gehaald.)", vbExclamation + vbYesNo, "Product uit de lijst halen?")
        If jn = 6 Then
            Me.GetProductAddBindingSource.RemoveCurrent()
            Me.Validate()
            Me.GetProductAddBindingSource.EndEdit()
            Me.GetProductAddTableAdapter.Update(DS_Product.GetProductAdd)
            Me.Close()
        End If

    End Sub
End Class
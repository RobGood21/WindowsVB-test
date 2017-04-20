Public Class F_Shop
    Private Sub ShopBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ShopBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Supplier)

    End Sub

    Private Sub F_Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LaadForm()


    End Sub


    Private Sub Knop_Link_Click(sender As Object, e As EventArgs) Handles Knop_Link.Click
        Dim HyperLink As String
        HyperLink = Me.TXT_Website.Text
        System.Diagnostics.Process.Start(HyperLink)
    End Sub

    Private Sub Knop_opslaan_Click(sender As Object, e As EventArgs) Handles Knop_opslaan.Click

        OPslaanShop()
        IDSHOP = Me.TXT_IDSHOP.Text
        Me.Close()

    End Sub
    Public Sub LaadForm()
        'let op volgorde van laden van de tableadaptors is belangrijk
        Me.LandTableAdapter.Fill(Me.DS_Supplier.Land)
        Me.TXT_IDSupplier.Text = IDSUPPLIER 'vul veld met id van de supplier, de holding van deze shop
        Me.SupplierTableAdapter.Fill_Suppliernaam(Me.DS_Supplier.Supplier, IDSUPPLIER) 'haal ALLEEN de naam op van de supplier

        'áls idshop > 0 is er al een shop bepaald
        Me.ShopTableAdapter.Fill(Me.DS_Supplier.Shop, IDSHOP)
        Try

        Catch ex As Exception
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub Knop_Save_Click(sender As Object, e As EventArgs) Handles Knop_Save.Click
        'te gebruiken om tijdens editing gegevens vast te leggen.
        OPslaanShop()

    End Sub

    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        'Maakt een nieuwe shop aan
        Me.ShopBindingSource.AddNew()
        Me.txt_IDSupplier_Shop.SelectedText = IDSUPPLIER


    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        'Opnieuw beginnen, alle veranderingen ongedaan maken
        LaadForm()

    End Sub

    Private Sub Knop_Delete_Click(sender As Object, e As EventArgs) Handles Knop_Delete.Click
        Dim janee As Integer
        janee = MsgBox("Wil je deze shop verwijderen?", vbYesNo, "verwijderen bevestigen..")
        If janee = 6 Then
            Me.ShopBindingSource.RemoveCurrent()
            OPslaanShop()
            Me.Close()

        End If

    End Sub

    Public Sub OPslaanShop()

        Me.Validate()
        Me.ShopBindingSource.EndEdit()
        Me.ShopTableAdapter.Update(DS_Supplier.Shop)

    End Sub
End Class
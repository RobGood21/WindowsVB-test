Public Class F_GetProduct
    Private Sub GetOntvangstBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GetOntvangstBindingNavigatorSaveItem.Click

    End Sub

    Private Sub F_GetProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LaadForm()

    End Sub

    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Me.Close()

    End Sub

    Public Sub Opslaan()

        Me.Validate()
        Me.GetOntvangstBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DS_Product)
        Me.GetOntvangstTableAdapter.Update(Me.DS_Product) 'Alleen de GETONTVANGST updaten voorkomt ongewenste aanpassingen

    End Sub

    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        Opslaan()
    End Sub

    Private Sub Knop_Herlaad_Click(sender As Object, e As EventArgs) Handles Knop_Herlaad.Click
        LaadForm()

    End Sub
    Public Sub LaadForm()
        Me.SupplierTableAdapter.Fill(Me.DS_Product.Supplier)
        Me.GetOntvangstTableAdapter.Fill(Me.DS_Product.GetOntvangst)


    End Sub

    Private Sub CB_Supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Supplier.SelectedIndexChanged
        IDSUPPLIER = Me.CB_Supplier.SelectedValue
        LaadShop()


        TXT()

    End Sub

    Private Sub CB_Shop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Shop.SelectedIndexChanged
        IDSHOP = Me.CB_Shop.SelectedValue
        TXT()


    End Sub

    Public Sub TXT()
        TXT_output.Text = "IDSupplier = " & IDSUPPLIER & "  IDshop= " & IDSHOP
    End Sub

    Private Sub Knop_DetailsShop_Click(sender As Object, e As EventArgs) Handles Knop_DetailsShop.Click

        F_Shop.ShowDialog()
        LaadShop()


    End Sub
    Public Sub LaadShop()
        'laad de mogelijke keuzes in de shop combobox 
        Dim TempShop As Integer 'fill reset selected value=id_shop. Dus huidige shop even vastleggen en na de fill weer terug zetten
        TempShop = IDSHOP
        Me.ShopTableAdapter.Fill(DS_Product.Shop, IDSUPPLIER)
        IDSHOP = TempShop
        Me.CB_Shop.SelectedValue = IDSHOP

    End Sub
End Class
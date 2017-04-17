Public Class F_GetOrder


    Private Sub F_GetOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Product1.Shop' table. You can move, or remove it, as needed.
        'Me.ShopTableAdapter.Fill(Me.DS_Product1.Shop,)

        'TODO: This line of code loads data into the 'DS_Product.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DS_Product.Supplier)



    End Sub


    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Me.Close()

    End Sub

    Private Sub Knop_nieuw_Click(sender As Object, e As EventArgs) Handles Knop_nieuw.Click
        Me.GetOrderBindingSource.AddNew()
    End Sub

    Private Sub CB_Leverancier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Leverancier.SelectedIndexChanged
        IDSUPPLIER = Me.CB_Leverancier.SelectedValue




        'MsgBox(IDSUPPLIER)

    End Sub

    Private Sub Knop_DetailsShop_Click(sender As Object, e As EventArgs) Handles Knop_DetailsShop.Click
        F_Shop.ShowDialog()

    End Sub

    Private Sub CB_Shop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Shop.SelectedIndexChanged
        IDSHOP = Me.CB_Shop.SelectedValue


    End Sub
End Class
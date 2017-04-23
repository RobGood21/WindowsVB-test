Public Class F_GetProduct
    Private Sub GetOntvangstBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub F_GetProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Product.GetProductAdd' table. You can move, or remove it, as needed.
        Me.GetProductAddTableAdapter.Fill(Me.DS_Product.GetProductAdd)

        LaadForm()

    End Sub

    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Me.Close()
    End Sub

    Public Sub Opslaan()
        'MsgBox(Me.CB_Shop.SelectedValue)


        Me.Validate()
        Me.GetOntvangstBindingSource.EndEdit()
        Me.GetOntvangstTableAdapter.Update(Me.DS_Product) 'Alleen de GETONTVANGST updaten voorkomt ongewenste aanpassingen

    End Sub

    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        Opslaan()
    End Sub

    Private Sub Knop_Herlaad_Click(sender As Object, e As EventArgs)
        LaadForm()

    End Sub
    Public Sub LaadForm()

        Me.SupplierTableAdapter.Fill(Me.DS_Product.Supplier)
        Me.LaadShop(1)
        Me.GetOntvangstTableAdapter.Fill(Me.DS_Product.GetOntvangst)
        LaadProductList()



    End Sub

    Private Sub CB_Supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Supplier.SelectedIndexChanged
        'LaadShop(2)
        ' IDSUPPLIER = Me.CB_Supplier.SelectedValue

    End Sub

    Private Sub CB_Shop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Shop.SelectedIndexChanged
        'MsgBox("CB_Shop")


        TXT()
    End Sub

    Public Sub TXT()
        TXT_output.Text = "IDSupplier = " & IDSUPPLIER & "  IDshop= " & IDSHOP
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
        TXT()
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


    End Sub

    Private Sub CB_Supplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Supplier.SelectionChangeCommitted

    End Sub

    Private Sub CB_Ontvangen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Ontvangen.SelectedIndexChanged
        'MsgBox("nu??")
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

    Private Sub Knop_ProductPlus_Click(sender As Object, e As EventArgs) Handles Knop_ProductPlus.Click
        Try
            IDGETONTVANGST = Me.CB_Ontvangen.SelectedValue
            OPGETPRODUCTADD = 1
            MsgBox(IDGETONTVANGST)
            F_GetProductAdd.ShowDialog()
            LaadProductList()

            'MsgBox(IDGETONTVANGST)
        Catch ex As Exception
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub ProductLoad()
        Try
            'Me.GetProductListTableAdapter.Fill(Me.DS_Product.GetProductList, New System.Nullable(Of Integer)(CType(IDGOPToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LaadForm()
    End Sub

    Private Sub Knop_Actie_Click(sender As Object, e As EventArgs) Handles Knop_Actie.Click
        EditGrid()
        ' EditDAtatable()

    End Sub
    Private Sub EditGrid()
        Dim I As Integer, a As Integer, b As Integer
        Try
            For I = 0 To DG_List.Rows.Count - 1



                Me.DT_productTableAdapter.Fill(Me.DS_Product.DT_product, CType(DG_List.Rows(I).Cells(2).Value, Integer))
                Me.GPA_AantalTableAdapter.Fill(Me.DS_Product.GPA_Aantal, DG_List.Rows(I).Cells(1).Value)

                a = Me.TXT_Voorraad.Text
                b = Me.TXT_LijstAantal.Text
                Me.TXT_Voorraad.Text = a + b
                Me.TXT_LijstAantal.Text = 0


                Me.Validate()
                Me.DT_productBindingSource.EndEdit()
                Me.GPAAantalBindingSource.EndEdit()
                Me.DT_productTableAdapter.Update(DS_Product.DT_product)
                Me.GPA_AantalTableAdapter.Update(DS_Product.GPA_Aantal)




                'Me.TXT_LijstAantal.Text = DG_List.Rows(I).Cells(2).Value

                ' DG_List.Rows(I).Cells(1).Value = DG_List.Rows(I).Cells(1).Value + 10
                '  I = I + 1

                MsgBox(DG_List.Rows(I).Cells(1).Value & "' " & DG_List.Rows(I).Cells(3).Value)


            Next

            LaadProductList()
            'op = DG_List.Rows(1).Cells(2).Value
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try



        ' MsgBox(op)

    End Sub

    Private Sub EditDAtatable()



    End Sub


    Private Sub Knop_update_Click(sender As Object, e As EventArgs) Handles Knop_update.Click
        Me.DG_List.Update()
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

    Private Sub DG_List_Click(sender As Object, e As EventArgs) Handles DG_List.Click ' ByVal sender As Object, ByVal e As System.EventArgs)_Handles selectedRowsButton.Click

        Dim selectedRowCount As Integer =
            DG_List.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then

            Dim sb As New System.Text.StringBuilder()

            Dim i As Integer
            For i = 0 To selectedRowCount - 1

                sb.Append("Row: ")
                sb.Append(DG_List.SelectedRows(i).Index.ToString())
                sb.Append(Environment.NewLine)

            Next i

            sb.Append("Total: " + selectedRowCount.ToString())

            'MessageBox.Show(sb.ToString(), "Selected Rows")
            Me.TXT_output.Text = sb.ToString()
        End If
    End Sub

    Private Sub Knop_Supplier_Click(sender As Object, e As EventArgs) Handles Knop_Supplier.Click
        OPSUPPLIER = 1
        IDSUPPLIER = Me.CB_Supplier.SelectedValue

        F_Supplier.ShowDialog()
        OPSUPPLIER = 0 'netjes achterlaten
        TXT()


    End Sub

    Private Sub Knop_Kosten_Click(sender As Object, e As EventArgs) Handles Knop_Kosten.Click

    End Sub
End Class
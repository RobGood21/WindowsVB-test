Public Class F_Supplier
    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SupplierBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_Supplier)

    End Sub

    Private Sub F_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Supplier.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DS_Supplier.Supplier)

    End Sub
End Class
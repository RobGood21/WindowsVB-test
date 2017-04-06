Public Class TestGrid


    Private Sub TestGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_ProjectProducts.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DS_ProjectProducts.DataTable1)

    End Sub

    Private Sub DataTable1DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)



    End Sub

    Private Sub DataTable1DataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles DataTable1DataGridView.SelectionChanged

    End Sub

    Private Sub DataTable1DataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataTable1DataGridView.RowHeaderMouseClick
        PLaatsKeuze()

    End Sub


    Public Sub PLaatsKeuze()
        Try

            Dim keuze As String
            keuze = Me.DataTable1DataGridView.SelectedRows.Item(0).Cells(0).Value

            MsgBox(keuze)

        Catch ex As Exception

            MsgBox(ErrorToString)

        End Try
    End Sub
End Class
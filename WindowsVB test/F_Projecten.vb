Public Class F_Projecten
    Private Sub F_Projecten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_ProjectProducts.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DS_ProjectProducts.DataTable1)

    End Sub

    Private Sub DG_Products_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Products.SelectionChanged
        PLaatsKeuze()


    End Sub

    Public Sub PLaatsKeuze()
        Try

            Dim keuze As String
            'If Me.DG_Products.in Then
            keuze = Me.DG_Products.SelectedRows.Item(0).Cells(0).Value

            Me.TXT_result.Text = keuze

        Catch ex As Exception

            MsgBox(ErrorToString)

        End Try
    End Sub

    Private Sub DG_Products_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Products.RowHeaderMouseClick
        'PLaatsKeuze()
    End Sub

    Private Sub DG_Products_Click(sender As Object, e As EventArgs) Handles DG_Products.Click
        'PLaatsKeuze()

    End Sub
End Class
Public Class F_ProductZoek
    Private Sub F_Projecten_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ZoekTXT As String = "%"

        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
        'LaadLijst(1)
    End Sub
    Private Sub PLaatsKeuze()
        Dim keuze As String
        Try
            keuze = Me.DG_products.SelectedRows.Item(0).Cells(0).Value
            IDPRODUCT = keuze 'Me.DG_Products.SelectedRows.Item(0).Cells(0).Value
            'MsgBox(IDPRODUCT)
        Catch ex As ArgumentOutOfRangeException
            'deze fout niet melden
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub CB_Groep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Groep.SelectedIndexChanged
        'MsgBox("CB_Groep_SelectedIndexChanged") ''
        LaadLijst(1)

    End Sub
    Private Sub TXT_Zoektekst_TextChanged(sender As Object, e As EventArgs) Handles TXT_Zoektekst.TextChanged
        Me.CB_Groep.SelectedValue = 0
        LaadLijst(2)
    End Sub
    Private Sub Knop_Sluit_Click(sender As Object, e As EventArgs) Handles Knop_Sluit.Click
        Me.Close()
    End Sub
    Public Sub LaadLijst(T As Integer)
        'T geeft aan hoe de lijst laden 1= op groep, 2 = op text
        Select Case T
            Case 1
                Me.ZoeklijstTableAdapter.Fill(Me.DS_ProjectProducts.ZoekLijst, Me.CB_Groep.SelectedValue)
            Case 2
                'gesloopt opnieuw maken...
                Dim txtZoek As String
                txtZoek = "%" & Me.TXT_Zoektekst.Text & "%"
                Me.CB_Groep.SelectedIndex = IDGROEPINDEX
        End Select

    End Sub
    Private Sub CB_Groep_Enter(sender As Object, e As EventArgs) Handles CB_Groep.Enter
        Me.TXT_Zoektekst.Text = ""
    End Sub

    Private Sub DG_products_SelectionChanged(sender As Object, e As EventArgs) Handles DG_products.SelectionChanged
        PLaatsKeuze()
    End Sub
End Class
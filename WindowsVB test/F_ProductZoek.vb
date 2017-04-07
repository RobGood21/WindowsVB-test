Public Class F_ProductZoek
    Private Private_IDgroep As Integer


    Private Sub F_Projecten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ZoekTXT As String = "%"
        'TODO: This line of code loads data into the 'DS_Product.Groep' table. You can move, or remove it, as needed.
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
        'TODO: This line of code loads data into the 'DS_ProjectProducts.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DS_ProjectProducts.DataTable1, ZoekTXT, Private_IDgroep)
    End Sub

    Private Sub DG_Products_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Products.SelectionChanged
        PLaatsKeuze()
    End Sub

    Private Sub ZoekTekst()
        Dim txtZoek As String
        txtZoek = "%" & Me.TXT_Zoektekst.Text & "%"
        'me.DataTable1TableAdapter.Fill(Me.DS_ProjectProducts.DataTable1, txtZoek, Private_IDgroep)
        LaadLijst()
    End Sub

    Private Sub PLaatsKeuze()
        Try
            Dim keuze As String
            'If Me.DG_Products.in Then
            keuze = Me.DG_Products.SelectedRows.Item(0).Cells(0).Value

            IDPRODUCT = Me.DG_Products.SelectedRows.Item(0).Cells(0).Value


        Catch ex As ArgumentOutOfRangeException

            'deze fout niet melden

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DG_Products_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Products.RowHeaderMouseClick
        'PLaatsKeuze()
    End Sub

    Private Sub DG_Products_Click(sender As Object, e As EventArgs) Handles DG_Products.Click
        'PLaatsKeuze()

    End Sub

    Private Sub CB_Groep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Groep.SelectedIndexChanged
        LaadLijst()
    End Sub

    Private Sub TXT_Zoektekst_TextChanged(sender As Object, e As EventArgs) Handles TXT_Zoektekst.TextChanged
        LaadLijst()

    End Sub

    Private Sub Knop_Sluit_Click(sender As Object, e As EventArgs) Handles Knop_Sluit.Click

        Me.Close()

    End Sub

    Public Sub LaadLijst()

        Dim txtZoek As String
        txtZoek = "%" & Me.TXT_Zoektekst.Text & "%"

        Private_IDgroep = Me.CB_Groep.SelectedValue
        Me.TXT_Groepid.Text = Me.Private_IDgroep

        ' If Private_IDgroep > 1 Then
        Me.DataTable1TableAdapter.Fill(Me.DS_ProjectProducts.DataTable1, txtZoek, Private_IDgroep)
        ' Else
        ' Me.DataTable1TableAdapter.Fill(Me.DS_ProjectProducts.DataTable1, txtZoek, Private_IDgroep)
        ' End If

    End Sub
End Class
Public Class F_ProductZoek
    Private Private_IDgroep As Integer
    Private BijLaden As Boolean

    Private Sub F_Projecten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Private_IDgroep = IDGROEP
        Dim ZoekTXT As String = "%"
        BijLaden = True

        'TODO: This line of code loads data into the 'DS_Product.Groep' table. You can move, or remove it, as needed.
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)
        'TODO: This line of code loads data into the 'DS_ProjectProducts.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.DS_ProjectProducts.DataTable1, ZoekTXT, Private_IDgroep)
        LaadLijst()
    End Sub

    Private Sub DG_Products_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Products.SelectionChanged
        PLaatsKeuze()
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


    Private Sub CB_Groep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Groep.SelectedIndexChanged
        'MsgBox("CB_Groep_SelectedIndexChanged") ''
        If BijLaden = False Then 'verzorgt dat bij formulier laden de IDgroep niet wordt veranderd.
            Private_IDgroep = Me.CB_Groep.SelectedValue
            IDGROEPINDEX = Me.CB_Groep.SelectedIndex
            LaadLijst()
        End If
    End Sub

    Private Sub TXT_Zoektekst_TextChanged(sender As Object, e As EventArgs) Handles TXT_Zoektekst.TextChanged
        'MsgBox("TXT_zoektekst")
        LaadLijst()
    End Sub

    Private Sub Knop_Sluit_Click(sender As Object, e As EventArgs) Handles Knop_Sluit.Click
        Me.Close()
        IDGROEP = Private_IDgroep
    End Sub

    Public Sub LaadLijst()
        'MsgBox(BijLaden)
        Dim txtZoek As String
        txtZoek = "%" & Me.TXT_Zoektekst.Text & "%"
        Me.DataTable1TableAdapter.Fill(Me.DS_ProjectProducts.DataTable1, txtZoek, Private_IDgroep)
        If BijLaden = True Then
            Me.CB_Groep.SelectedIndex = IDGROEPINDEX
            BijLaden = False
        End If

    End Sub


End Class
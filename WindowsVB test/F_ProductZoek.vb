Public Class F_ProductZoek
    Private Sub F_Projecten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim ZoekTXT As String = "%"
        Me.GroepTableAdapter.Fill(Me.DS_Product.Groep)

        Me.CH_Groep.Checked = ZOEKGROEPCH
        Me.CH_TXT.Checked = ZOEKTXTCH
        Me.TXT_Zoektekst.Text = ZOEKTXT
        Me.CB_Groep.SelectedValue = ZOEKGROEP

        LijstOPmaak()
        LaadLijst(3)

    End Sub
    Private Sub LijstOPmaak()
        'Me.DG_Journaal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Me.DG_Journaal.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ' Me.DG_Products.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ''  Me.DG_Products.Rows(2).ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'DG_Products.Dock = DockStyle.Fill
        DG_Products.BackgroundColor = Color.LightGray

        DG_Products.BorderStyle = BorderStyle.Fixed3D

        Me.DG_Products.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red


        Me.DG_Products.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DG_Products.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
        LaadLijst(1)
    End Sub
    Private Sub TXT_Zoektekst_TextChanged(sender As Object, e As EventArgs) Handles TXT_Zoektekst.TextChanged
        LaadLijst(2)
    End Sub
    Private Sub Knop_Sluit_Click(sender As Object, e As EventArgs) Handles Knop_Sluit.Click
        sluiten()
    End Sub
    Public Sub sluiten()
        ZOEKGROEPCH = Me.CH_Groep.Checked
        ZOEKTXTCH = Me.CH_TXT.Checked
        ZOEKGROEP = CB_Groep.SelectedValue
        ZOEKTXT = Me.TXT_Zoektekst.Text
        Me.Close()
    End Sub
    Public Sub LaadLijst(T As Integer)
        'T geeft aan hoe de lijst laden 1= op groep, 2 = op text 3 = bij laden formulier
        Dim ZT As String
        ZT = "%" & Me.TXT_Zoektekst.Text & "%"

        Select Case T
            Case 1 'zoeken na aanpassing groep
                If Me.CH_TXT.Checked = True Then
                    Me.ProductZoekTableAdapter.FillT(DS_Product.ProductZoek, ZT)
                Else
                    Me.ProductZoekTableAdapter.Fill(DS_Product.ProductZoek, Me.CB_Groep.SelectedValue)
                End If

            Case 2 'zoek na aanpassing text
                If Me.CH_Groep.Checked = True Then
                    Me.ProductZoekTableAdapter.FiLLGT(DS_Product.ProductZoek, Me.CB_Groep.SelectedValue, ZT)
                Else
                    Me.ProductZoekTableAdapter.FillT(DS_Product.ProductZoek, ZT)
                End If
            Case 3 'bij openen vorm
                If Me.CH_TXT.Checked = True Then

                    If CH_Groep.Checked = True Then
                        Me.ProductZoekTableAdapter.FiLLGT(DS_Product.ProductZoek, Me.CB_Groep.SelectedValue, ZT)
                    Else
                        Me.ProductZoekTableAdapter.FillT(DS_Product.ProductZoek, ZT)
                    End If

                Else
                    If Me.CH_Groep.Checked = True Then Me.ProductZoekTableAdapter.Fill(DS_Product.ProductZoek, Me.CB_Groep.SelectedValue)
                    Me.TXT_Zoektekst.Enabled = False
                End If


        End Select

    End Sub
    Private Sub DG_Products_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Products.SelectionChanged
        PLaatsKeuze()
    End Sub
    Private Sub CH_Groep_CheckedChanged(sender As Object, e As EventArgs) Handles CH_Groep.CheckedChanged
        If CH_Groep.Checked = True Then
            Me.CB_Groep.Enabled = True
        Else
            Me.CB_Groep.Enabled = False
        End If
        LaadLijst(3)
    End Sub
    Private Sub CH_TXT_CheckedChanged(sender As Object, e As EventArgs) Handles CH_TXT.CheckedChanged
        If Me.CH_TXT.Checked = True Then
            Me.TXT_Zoektekst.Enabled = True
        Else
            Me.TXT_Zoektekst.Enabled = False
        End If
        LaadLijst(3)
    End Sub

    Private Sub DG_Products_DoubleClick(sender As Object, e As EventArgs) Handles DG_Products.DoubleClick
        sluiten()
    End Sub
End Class
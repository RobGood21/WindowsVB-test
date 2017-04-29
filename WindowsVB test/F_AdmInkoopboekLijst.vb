Public Class F_AdmInkoopboekLijst
    Private Sub F_AdmInkoopboekLijst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Administratie1.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DS_Administratie1.Supplier)
        'TODO: This line of code loads data into the 'DS_Administratie.admInkoopboekLijst' table. You can move, or remove it, as needed.


        LoadLijst()

    End Sub

    Private Sub Knop_Sluiten_Click(sender As Object, e As EventArgs) Handles Knop_Sluiten.Click
        Me.Close()

    End Sub

    Public Sub Bereken()
        'berekend de waardes
        Try
            Me.TXT_aantal.Text = Me.DG_AdmInkoopLijst.Rows.Count
            Dim T As Decimal
            Dim i As Integer
            For i = 0 To Me.DG_AdmInkoopLijst.Rows.Count - 1


                If IsDBNull(Me.DG_AdmInkoopLijst.Rows(i).Cells(4).Value) = False Then T = T + Me.DG_AdmInkoopLijst.Rows(i).Cells(4).Value


            Next
            Me.TXT_Waarde.Text = T
        Catch ex As Exception
            MsgBox(ErrorToString,, "bereken()")
        End Try


    End Sub

    Public Sub LoadLijst()
        Try
            If Me.CH_AlleCrediteuren.Checked = True Then
                Me.AdmInkoopboekLijstTableAdapter.Fill(Me.DS_Administratie.admInkoopboekLijst, Me.OptieBetaald.Checked)
            Else
                Me.AdmInkoopboekLijstTableAdapter.FillBy(Me.DS_Administratie.admInkoopboekLijst, Me.OptieBetaald.Checked, Me.CB_supplier.SelectedValue)
            End If



            Bereken()

        Catch ex As Exception
            MsgBox(ErrorToString,, "Loadlijst()")
        End Try


    End Sub

    Private Sub Optie_openstaand_CheckedChanged(sender As Object, e As EventArgs) Handles Optie_openstaand.CheckedChanged
        LoadLijst()

    End Sub

    Private Sub CB_supplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_supplier.SelectionChangeCommitted
        LoadLijst()
    End Sub

    Private Sub CH_AlleCrediteuren_CheckedChanged(sender As Object, e As EventArgs) Handles CH_AlleCrediteuren.CheckedChanged
        Select Case Me.CH_AlleCrediteuren.Checked
            Case True
                Me.CB_supplier.Enabled = False


            Case False
                Me.CB_supplier.Enabled = True


        End Select
        LoadLijst()

    End Sub

    Private Sub Knop_Details_Click(sender As Object, e As EventArgs) Handles Knop_Details.Click
        ShowDetails()

    End Sub

    Private Sub DG_AdmInkoopLijst_DoubleClick(sender As Object, e As EventArgs) Handles DG_AdmInkoopLijst.DoubleClick
        ShowDetails()
    End Sub
    Public Sub ShowDetails()
        Dim i As Integer
        Dim ID As Integer
        Dim tekst As String = ""

        For i = 0 To Me.DG_AdmInkoopLijst.Rows.Count
            If Me.DG_AdmInkoopLijst.Rows(i).Selected = True Then
                ID = Me.DG_AdmInkoopLijst.Rows(i).Cells(0).Value
                GoTo eruit
            End If
        Next
eruit:

        IDADMINKOOP = ID
        OPADMINKOOP = 2
        F_AdmInkoopboek.ShowDialog()


    End Sub
End Class
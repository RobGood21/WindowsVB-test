Public Class F_Opening
    Private Sub F_Opening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = F_Wisselmotor
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Knop_Sluit_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Knop_afsluiten_Click(sender As Object, e As EventArgs) Handles Knop_afsluiten.Click
        F_Wisselmotor.Close()

    End Sub
End Class
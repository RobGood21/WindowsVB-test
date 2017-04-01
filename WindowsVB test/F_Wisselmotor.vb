Public Class F_Wisselmotor
    Private Sub ProductenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductenToolStripMenuItem.Click
        F_Product.Show()
        F_Product.BringToFront()


    End Sub

    Private Sub F_Wisselmotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        F_Opening.Show()

    End Sub

    Private Sub OpeningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpeningToolStripMenuItem.Click
        F_Opening.Show()
        F_Opening.BringToFront()


    End Sub
End Class
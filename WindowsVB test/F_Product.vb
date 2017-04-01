Public Class F_Product
    Private Sub F_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set dit form als een child van wisselmotor,dus binnen dit kader.
        Me.MdiParent = F_Wisselmotor
        Me.WindowState = FormWindowState.Maximized





        'TODO: This line of code loads data into the 'WMdbDataSet.Product' table. You can move, or remove it, as needed.
        'Me.ProductTableAdapter.Fill(Me.WMdbDataSet.Product)


    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub KN_Sluit_Click(sender As Object, e As EventArgs) Handles KN_Sluit.Click
        Me.Close()
    End Sub
End Class
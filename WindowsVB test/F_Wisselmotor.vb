Public Class F_Wisselmotor
    Private Sub ProductenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        F_Product.MdiParent = Me
        F_Product.Show()
        F_Product.BringToFront()
    End Sub
    Private Sub F_Wisselmotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        F_Opening.Show()
        'Publieke variabelen laden, bij starten project
        ZOEKGROEP = 0
        ZOEKTXT = ""
        ZOEKGROEPCH = True
        ZOEKTXTCH = False
    End Sub
    Private Sub OpeningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpeningToolStripMenuItem.Click
        F_Opening.Show()
        F_Opening.BringToFront()
    End Sub
    Private Sub ProductgroepenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductgroepenToolStripMenuItem.Click
        ' MsgBox("nu")
        F_Groep.ShowDialog()
    End Sub
    Private Sub MerkenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MerkenToolStripMenuItem.Click
        F_Merk.ShowDialog()
    End Sub
    Private Sub ValutaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        F_Valuta.ShowDialog()
    End Sub
    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        F_Supplier.MdiParent = Me
        F_Supplier.Show()
        F_Supplier.BringToFront()
    End Sub
    Private Sub AfsluitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfsluitenToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub GrootboekrekeningenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrootboekrekeningenToolStripMenuItem.Click
        F_AdmGBrekening.MdiParent = Me
        F_AdmGBrekening.Show()
        F_AdmGBrekening.BringToFront()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        F_AdmInkoopboek.MdiParent = Me
        F_AdmInkoopboek.Show()
        F_AdmInkoopboek.BringToFront()

    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        F_AdmInkoopboekLijst.MdiParent = Me
        F_AdmInkoopboekLijst.Show()
        F_AdmInkoopboekLijst.BringToFront()

    End Sub
    Private Sub OpbergersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpbergersToolStripMenuItem.Click
        'F_LocatieHolder.MdiParent = Me
        F_LocatieHolder.ShowDialog()
        'F_LocatieHolder.BringToFront()
    End Sub
    Private Sub ProductenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductenToolStripMenuItem.Click
        F_Product.MdiParent = Me
        F_Product.Show()
        F_Product.BringToFront()

    End Sub
    Private Sub ProductLijstToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductLijstToolStripMenuItem.Click
        ShowGetproducts()
    End Sub
    Private Sub ShowGetproducts()
        F_GetProduct.MdiParent = Me
        F_GetProduct.Show()
        F_GetProduct.BringToFront()
    End Sub

    Private Sub ValutaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ValutaToolStripMenuItem.Click
        F_Valuta.ShowDialog()
    End Sub

    Private Sub BetaalWijzenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BetaalWijzenToolStripMenuItem.Click
        F_Betaalwijzen.ShowDialog()
    End Sub
    Private Sub LandenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LandenToolStripMenuItem.Click
        F_Land.ShowDialog()
    End Sub
End Class
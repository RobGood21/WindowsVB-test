﻿Public Class F_Wisselmotor
    Private Sub ProductenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        F_Product.MdiParent = Me

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

    Private Sub ProductgroepenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductgroepenToolStripMenuItem.Click

        F_Groep.ShowDialog()
    End Sub

    Private Sub MerkenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MerkenToolStripMenuItem.Click
        F_Merk.ShowDialog()

    End Sub

    Private Sub ValutaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        F_Valuta.ShowDialog()

    End Sub

    Private Sub LandenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        F_Land.ShowDialog()

    End Sub



    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        F_Supplier.MdiParent = Me
        F_Supplier.Show()

    End Sub

    Private Sub AfsluitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfsluitenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GrootboekrekeningenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrootboekrekeningenToolStripMenuItem.Click
        F_AdmGBrekening.MdiParent = Me
        F_AdmGBrekening.Show()

    End Sub

    Private Sub BetaalWijzenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BetaalWijzenToolStripMenuItem.Click
        F_Betaalwijzen.ShowDialog()
    End Sub
End Class
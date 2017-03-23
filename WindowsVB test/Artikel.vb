Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.SqlClient




Public Class Artikel





    Private Sub Artikel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WMdbDataSet.Producten' table. You can move, or remove it, as needed.
        Me.ProductenTableAdapter.Fill(Me.WMdbDataSet.Producten)
        ' LijstP.Items.Add("Eerste regel")
        '  LijstP.Items.Add("Tweede regel")
        'LijstP.DataSource = "select * from producten;"



    End Sub

    Private Sub KnopTest1_Click(sender As Object, e As EventArgs) Handles KnopTest1.Click
        MsgBox("Hallo ik snap der niks van")

    End Sub

    Private Sub ProductenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WMdbDataSet)

    End Sub
End Class


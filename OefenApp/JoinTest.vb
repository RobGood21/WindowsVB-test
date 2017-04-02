Public Class JoinTest
    Private Sub JoinTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetJoin.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSetJoin.DataTable1)
        'TODO: This line of code loads data into the 'JoinDataset.Apparaat' table. You can move, or remove it, as needed.
        'Me.ApparaatTableAdapter.Fill(Me.JoinDataset.Apparaat)
        'TODO: This line of code loads data into the 'JoinDataset.Apparaat' table. You can move, or remove it, as needed.
        Me.ApparaatTableAdapter.FillBy(Me.JoinDataset.Apparaat)
        'TODO: This line of code loads data into the 'JoinDataset.Gebruiker' table. You can move, or remove it, as needed.

        'Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet.Gebruiker)
    End Sub
End Class
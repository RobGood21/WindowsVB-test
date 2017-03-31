Public Class Form1
    Private Sub GebruikerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GebruikerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OefenDbDataSet.Gebruiker' table. You can move, or remove it, as needed.
        'Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet.Gebruiker)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ópslaan van de aanpassingen
        Try

            Me.Validate()
            Me.GebruikerBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSet)

            MsgBox("opgeslagen")

        Catch ex As Exception

            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'Me.DG_oefen.DataSource = GebruikerBindingSource1
            Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet.Gebruiker)

            'TXTID.Text = Me.GebruikerTableAdapter.GetData.NaamColumn
        Catch ex As Exception

            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.GebruikerBindingSource.MovePrevious()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.GebruikerBindingSource.MoveNext()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.GebruikerBindingSource.AddNew()

    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.DG_oefen.DataSource = GebruikerBindingSource1
            MsgBox("ïngesteld")
        Catch ex As Exception
            MsgBox(ErrorToString
                    )
        End Try


    End Sub


End Class

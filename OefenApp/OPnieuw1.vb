Public Class OPnieuw1
    Private Sub GebruikerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GebruikerBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.BS_Gebruiker.EndEdit() 'naam is automatisch aangepast, was gebruikerbindingsource
            Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSet)

        Catch ex As Exception
            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub OPnieuw1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OefenDbDataSet.Apparaat' table. You can move, or remove it, as needed.
        'Me.ApparaatTableAdapter.Fill(Me.OefenDbDataSet.Apparaat)
        'TODO: This line of code loads data into the 'OefenDbDataSet.Gebruiker' table. You can move, or remove it, as needed.

        ' Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet.Gebruiker)
        STELVAKIN()


    End Sub

    Private Sub Knop_Reload_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub CB_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_1.SelectedIndexChanged
        Try
            Dim tekst As String
            Dim IDwaarde As Int16
            IDwaarde = CB_1.SelectedValue
            tekst = IDwaarde
            txt_output.Text = tekst

        Catch ex As Exception
            MsgBox(ErrorToString
                   )
        End Try



        ' MsgBox(tekst)
    End Sub

    Private Sub Knop_CB1instellen_Click(sender As Object, e As EventArgs)

        Try


            Dim TeksT As String, Tekst2 As String

            Dim selectedIndex As Integer
            selectedIndex = CB_1.SelectedIndex
            Dim selectedItem As Object
            selectedItem = CB_1.SelectedItem

            TeksT = ("Selected Item Text: " & selectedItem.ToString() & Microsoft.VisualBasic.Constants.vbCrLf &
                                "Index: " & selectedIndex.ToString())
            Tekst2 = CB_1.SelectedValue


            txt_output.Text = Tekst2
        Catch ex As Exception
            txt_output.Text = ErrorToString()
        End Try

    End Sub

    Private Sub TXT_Zoektekst_TextChanged(sender As Object, e As EventArgs) Handles TXT_Zoektekst.TextChanged
        STELVAKIN()
    End Sub

    Private Sub STELVAKIN()

        Dim Zoektxt As String
        Zoektxt = "%" & TXT_Zoektekst.Text & "%"
        Me.GebruikerTableAdapter.Q_naam(Me.OefenDbDataSet.Gebruiker, Zoektxt)
    End Sub

End Class
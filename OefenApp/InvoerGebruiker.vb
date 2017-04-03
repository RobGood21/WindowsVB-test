Public Class InvoerGebruiker
    Private Sub InvoerGebruiker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OefenDbDataSet1.Gebruiker' table. You can move, or remove it, as needed.
        Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet1.Gebruiker)
        'TODO: This line of code loads data into the 'OefenDbDataSet.Gebruiker' table. You can move, or remove it, as needed.
        Me.GebruikerTableAdapter.Fill(Me.OefenDbDataSet.Gebruiker)
        'TODO: This line of code loads data into the 'OefenDbDataSet.Apparaat' table. You can move, or remove it, as needed.

        'dit wordt automatisch aangemaakt bij het inslepen van een dataveld. Is niet nodig
        'Me.ApparaatTableAdapter.Fill(Me.OefenDbDataSet.Apparaat) 'hele tabel apparaat wordt geladen????
        Me.TXT_Invoer.Text = 0
        OPzoeken()



    End Sub

    Private Sub Apparaat1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Apparaat1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BS_AP_Invoer.EndEdit() 'bs=bindingsource ap=apparaat invoer is formuliernaam....renamed

        ' Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSet) 'hele db wordt geupdate??? wat een waanzin...

        Me.TableAdapterManager.TA_Invoer.Update(Me.OefenDbDataSet) 'dit update volgens mij alleen deze tabel adaptor TA_Invoer

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.TA_Invoer.Fill(Me.OefenDbDataSet.DS_Invoer, CType(IDApparaatToolStripTextBox.Text, Integer)) 'ds_invoer is renamed dataset invoer.
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub OPzoeken()
        Try
            Me.TA_Invoer.Fill(Me.OefenDbDataSet.DS_Invoer, CType(Me.TXT_Invoer.Text, Integer))

        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub

    Private Sub Knop_PLaats_Click(sender As Object, e As EventArgs) Handles Knop_PLaats.Click
        OPzoeken()
    End Sub

    Private Sub TXT_Invoer_TextChanged(sender As Object, e As EventArgs) Handles TXT_Invoer.TextChanged
        'OPzoeken()
    End Sub

    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        BS_AP_Invoer.AddNew()

    End Sub

    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        OPSLAAN()

    End Sub

    Private Sub OPSLAAN()
        Try
            Me.Validate()
            Me.BS_AP_Invoer.EndEdit() 'bs=bindingsource ap=apparaat invoer is formuliernaam....renamed
            ' Me.TableAdapterManager.UpdateAll(Me.OefenDbDataSet) 'hele db wordt geupdate??? wat een waanzin...

            Me.TableAdapterManager.TA_Invoer.Update(Me.OefenDbDataSet) 'dit update volgens mij alleen deze tabel adaptor TA_Invoer

        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub

    Private Sub TXT_Invoer_Leave(sender As Object, e As EventArgs) Handles TXT_Invoer.Leave
        OPzoeken()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Me.TXT_output.Text = Me.ComboBox1.SelectedValue
            'Me.GB_IDTextBox.Text = Me.TXT_output.Text





        Catch ex As Exception
            MsgBox(ErrorToString)

        End Try



    End Sub
End Class
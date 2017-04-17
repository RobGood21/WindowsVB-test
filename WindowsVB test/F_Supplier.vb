Public Class F_Supplier


    Public Sub ToolTipsInstellen()
        ' Create the ToolTip and associate with the Form container.
        Dim TT_Supplier As New ToolTip()



        ' Set up the delays for the ToolTip.
        TT_Supplier.AutoPopDelay = 5000
        TT_Supplier.InitialDelay = 100
        TT_Supplier.ReshowDelay = 50
        ' Force the ToolTip text to be displayed whether or not the form is active.
        TT_Supplier.ShowAlways = True

        ' Set up the ToolTip text for the Button and Checkbox.

        'Knoppen
        With TT_Supplier
            'Knoppen
            .SetToolTip(Me.Knop_Link, "Bezoek website")
            .SetToolTip(Me.Knop_Nieuw, "Leverancier toevoegen.")
            .SetToolTip(Me.Knop_Annuleren, "alle invoer ongedaan maken")
            .SetToolTip(Me.Knop_opslaan, "Alle invoer en aanpassingen opslaan en formulier sluiten")
            .SetToolTip(Me.Knop_Delete, "Getoonde leverancier wissen.")
            .SetToolTip(Me.Knop_Save, "Alle invoer (tussentijds) opslaan.")

            'Textboxes en comboos
            .SetToolTip(Me.CB_Grootboek, "Geef het standaard grootboek catagorie van deze leverancier")

            'TT_Supplier.SetToolTip(Me.TXT_adres, "Adres van de leverancier")



            'TT_Supplier.SetToolTip(Me.TXT_Laatste_inkoop_Datum, "Datum, laatste ontvangst van dit product")
            'TT_Supplier.SetToolTip(Me.TXT_LaatsteInkoop_Waarde, "Betaalde bedrag in € ex.BTW")

            ' TT_Supplier.SetToolTip(Me.Button1, "My button1")
            'TT_Supplier.SetToolTip(Me.checkBox1, "My checkBox1")
        End With


    End Sub

    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Opslaan()
    End Sub

    Private Sub F_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTipsInstellen()

        Me.GrootboekTableAdapter.Fill(Me.DS_Supplier.Grootboek)
        Me.ValutaTableAdapter.Fill(Me.DS_Supplier.Valuta)
        Me.BetaalWijzenTableAdapter.Fill(Me.DS_Supplier.BetaalWijzen)
        Me.LandTableAdapter.Fill(Me.DS_Supplier.Land)
        'TODO: This line of code loads data into the 'DS_Supplier.Supplier' table. You can move, or remove it, as needed.
        'Me.SupplierTableAdapter.Fill(Me.DS_Supplier.Supplier)
        LaadData()



    End Sub

    Private Sub Knop_opslaan_Click(sender As Object, e As EventArgs) Handles Knop_opslaan.Click
        Opslaan()
        Me.Close()
    End Sub

    Private Sub Opslaan()
        Try

            Me.Validate()
            Me.SupplierBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DS_Supplier)

        Catch ex As Exception

            MsgBox(ErrorToString)


        End Try

    End Sub


    Private Sub CB_NaamSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_NaamSupplier.SelectionChangeCommitted
        'Me.txt_ID_LAND_test.Text = Me.txt_ID_LandTextBox.Text
    End Sub

    Private Sub LaadData()

        Me.SupplierTableAdapter.Fill(Me.DS_Supplier.Supplier)

    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        LaadData()
    End Sub

    Private Sub Knop_Nieuw_Click(sender As Object, e As EventArgs) Handles Knop_Nieuw.Click
        Me.SupplierBindingSource.AddNew()
    End Sub


    Private Sub Knop_Link_Click(sender As Object, e As EventArgs) Handles Knop_Link.Click
        Dim HyperLink As String
        HyperLink = Me.TXT_Website.Text
        System.Diagnostics.Process.Start(HyperLink)
    End Sub

    Private Sub CB_NaamSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_NaamSupplier.SelectedIndexChanged

    End Sub

    Private Sub CB_Grootboek_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Grootboek.SelectedIndexChanged

    End Sub
End Class
Public Class F_GetProductAdd
    Private Sub F_GetProductAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'tijdelijk even idgetontvangst instellen, verwijst naar onderliggende betselling of ontvangst
        'let op getproduct en getontvangst zijn hetzelfde , getproduct het form getontvangst de dbtabel

        'IDGETONTVANGST = 2 'id van dan de getontvangst/ getproduct waar deze product record aan moet worden toegevoegd
        'OPGETPRODUCTADD = 1 'Manier hoe het gormulier te opene 1=nieuw 2= bestaand


        ' Me.TXT_IDGetProduct.Text = IDGETONTVANGST

        Me.GetProductAddTableAdapter.Fill(Me.DS_Product.GetProductAdd)

        Select Case OPGETPRODUCTADD
            Case 1 'openen met nieuw aan de lijst toe te voegen product

                Me.GetProductAddBindingSource.AddNew()
                MsgBox("nu    " & IDGETONTVANGST)

                Me.TXT_IDGetProduct.Text = IDGETONTVANGST
                Me.TXT_Container.Text = F_GetProduct.TXT_NaamGet.Text

                MsgBox(Me.TXT_IDGetProduct.Text)

            Case 2

        End Select

    End Sub

    Private Sub Knop_Opslaan_Click(sender As Object, e As EventArgs) Handles Knop_Opslaan.Click
        Opslaan()
        Me.Close()
    End Sub

    Private Sub Knop_Details_Click(sender As Object, e As EventArgs) Handles Knop_Details.Click
        'in run time idgetproduct, dus de container koppelen. dit is een mooie plek ervoor 
        Me.TXT_IDGetProduct.Text = IDGETONTVANGST


        F_Product.ShowDialog()
        Me.TXT_ProductID.Text = IDPRODUCT

        ' MsgBox(IDPRODUCT)
    End Sub

    Private Sub GetProductAddBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GetProductAddBindingNavigatorSaveItem.Click

        Opslaan()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub Opslaan()
        Try
            Me.Validate()
            Me.GetProductAddBindingSource.EndEdit()
            'Me.TableAdapterManager.UpdateAll(Me.DS_Product)
            Me.GetProductAddTableAdapter.Update(Me.DS_Product)
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try


    End Sub

    Private Sub Knop_Annuleren_Click(sender As Object, e As EventArgs) Handles Knop_Annuleren.Click
        Me.GetProductAddBindingSource.EndEdit()
        Me.Validate()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
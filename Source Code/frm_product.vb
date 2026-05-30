Public Class frm_product_a187795

    Private Sub frm_product_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "select * from TBL_PRODUCTS_A187795"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_product.DataSource = mytable

    End Sub

    Private Sub frm_product_a187795_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_mainmenu.Click
        frm_mainmenu_a187795.Show()
        Me.Hide()

    End Sub
End Class
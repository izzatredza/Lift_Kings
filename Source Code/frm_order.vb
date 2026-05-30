Public Class frm_order_a187795
    Private Sub frm_order_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "select * from TBL_ORDER"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_order.DataSource = mytable
    End Sub

    Private Sub frm_order_a187795_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub



    Private Sub grd_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_order.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        grd_order.DataSource = run_select("select * from TBL_ORDER")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_insertorder.Show()
        Me.Hide()
    End Sub
End Class
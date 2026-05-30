Public Class frm_customerdetail_a187795
    Private Sub frm_customerdetail_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "select CUSTOMER_ID from TBL_CUSTOMER order by CUSTOMER_ID"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        lst_customerid.DataSource = mytable
        lst_customerid.DisplayMember = "CUSTOMER_ID"

        refresh_text(lst_customerid.Text)
    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "select * from TBL_CUSTOMER where CUSTOMER_ID ='" & id & "'"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        txt_customerid.Text = mytable.Rows(0).Item("CUSTOMER_ID")
        txt_namecustomer.Text = mytable.Rows(0).Item("CUSTOMER_NAME")
        txt_tel.Text = mytable.Rows(0).Item("CUSTOMER_TEL")
        txt_address.Text = mytable.Rows(0).Item("Address")





    End Sub

    Private Sub lst_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_customerid.MouseClick

        refresh_text(lst_customerid.Text)
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frm_insertcustomer_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        frm_updatecustomer_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lst_customerid.DataSource = run_select("select * from TBL_CUSTOMER")
    End Sub

End Class
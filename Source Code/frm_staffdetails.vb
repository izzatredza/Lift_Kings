Public Class frm_staffdetails_a187795
    Private Sub frm_staffdetails_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "select STAFF_ID from TBL_STAFF order by STAFF_ID"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        lst_staffid.DataSource = mytable
        lst_staffid.DisplayMember = "STAFF_ID"

        refresh_text(lst_staffid.Text)
    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "select * from TBL_STAFF where STAFF_ID ='" & id & "'"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        txt_staffid.Text = mytable.Rows(0).Item("STAFF_ID")
        txt_namestaff.Text = mytable.Rows(0).Item("STAFF_NAME")
        txt_tel.Text = mytable.Rows(0).Item("STAFF_TEL")

    End Sub

    Private Sub lst_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_staffid.MouseClick

        refresh_text(lst_staffid.Text)
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frm_insertstaff_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub frm_staffdetails_a187795_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        frm_updatestaff_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lst_staffid.DataSource = run_select("select * from TBL_STAFF")

    End Sub

    Private Sub lst_staffid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_staffid.SelectedIndexChanged

    End Sub
End Class
Public Class frm_insertcustomer_a187795
    Private Sub frm_insertcustomer_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_staff.DataSource = run_select("select * from TBL_CUSTOMER")

        txt_customerid.Text = generate_id()
    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_select("select max(CUSTOMER_ID) as maxid from TBL_CUSTOMER").Rows(0).Item("maxid")

        Dim nextid As String = "C00" & (Mid(lastid, 2) + 1)

        Return nextid
    End Function
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        'Dim mysql As String = "insert into TBL_PRODUCTS_A187795 values ('S041',' Hello ' '43 ' 'Maxx ' 'dumbell '', 'Hello',)"
        Dim mysql As String = "insert into TBL_CUSTOMER values ('" & txt_customerid.Text & "','" & txt_namecustomer.Text & "', '" & txt_tel.Text & "', '" & txt_address.Text & "')"

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)



        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()

            txt_namecustomer.Text = ""
            txt_address.Text = ""
            txt_tel.Text = ""

        Catch ex As Exception

            Beep()
            MsgBox("ERROR: " & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_customerdetail_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        refresh_grid()
    End Sub
End Class
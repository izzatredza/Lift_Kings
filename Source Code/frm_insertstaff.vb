Public Class frm_insertstaff_a187795
    Private Sub frm_insertstaff_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_staff.DataSource = run_select("select * from TBL_STAFF")
        txt_staffid.Text = generate_id()

    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_select("select max(STAFF_ID) as maxid from TBL_STAFF").Rows(0).Item("maxid")

        Dim nextid As String = "A00" & (Mid(lastid, 2) + 1)

        Return nextid
    End Function
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        'Dim mysql As String = "insert into TBL_PRODUCTS_A187795 values ('S041',' Hello ' '43 ' 'Maxx ' 'dumbell '', 'Hello',)"
        Dim mysql As String = "insert into TBL_STAFF values ('" & txt_staffid.Text & "','" & txt_namestaff.Text & "','" & txt_tel.Text & "')"

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)



        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()

            txt_namestaff.Text = ""
            txt_tel.Text = ""

        Catch ex As Exception

            Beep()
            MsgBox("ERROR: " & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub



    Private Sub frm_insertstaff_a187795_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_staffdetails_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        refresh_grid()
    End Sub
End Class

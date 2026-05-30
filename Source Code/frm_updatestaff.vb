Public Class frm_updatestaff_a187795

    Dim current_code As String
    Private Sub frm_updatestaff_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_staff.DataSource = run_select("select * from TBL_STAFF")

        get_current_code()


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_update.Click


        run_command("update TBL_STAFF set staff_name ='" & txt_namestaff.Text & "', staff_tel = '" & txt_tel.Text & "' where staff_id = '" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated id '" & current_code & " '")
        refresh_grid()

    End Sub




    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick

        get_current_code()

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_code = grd_staff(0, current_row).Value

        txt_staffid.Text = current_code
        txt_namestaff.Text = grd_staff(1, current_row).Value
        txt_tel.Text = grd_staff(2, current_row).Value

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you want to DELETE THE ID '" & current_code & "'?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("delete from TBL_STAFF where staff_id = '" & current_code & "'")

            Beep()
            MsgBox(" the ID '" & current_code & "'has been successfully deleted")

            refresh_grid()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_staffdetails_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        refresh_grid()
    End Sub
End Class
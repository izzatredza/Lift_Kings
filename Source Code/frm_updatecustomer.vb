Public Class frm_updatecustomer_a187795

    Dim current_code As String

    Private Sub frm_updatecustomer_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()


    End Sub

    Private Sub refresh_grid()

        grd_staff.DataSource = run_select("select * from TBL_CUSTOMER")

        get_current_code()


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_update.Click


        run_command("update TBL_CUSTOMER set customer_name ='" & txt_namecustomer.Text & "', customer_tel = '" & txt_tel.Text & "', address = '" & txt_address.Text & "' where customer_id = '" & current_code & "'")

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

        txt_customerid.Text = current_code
        txt_namecustomer.Text = grd_staff(1, current_row).Value
        txt_tel.Text = grd_staff(2, current_row).Value
        txt_address.Text = grd_staff(3, current_row).Value

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you want to DELETE THE ID '" & current_code & "'?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("delete from TBL_CUSTOMER where customer_id = '" & current_code & "'")

            Beep()
            MsgBox(" the ID '" & current_code & "'has been successfully deleted")

            refresh_grid()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_customerdetail_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        refresh_grid()
    End Sub
End Class
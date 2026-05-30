Public Class frm_updateproduct_a187795

    Dim current_code As String
    Private Sub frm_updateproduct_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        refresh_grid()


    End Sub

    Private Sub refresh_grid()

        grd_product.DataSource = run_select("select * from TBL_PRODUCTS_A187795")

        get_current_code()


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_update.Click


        run_command("update TBL_PRODUCTS_A187795 set fld_product_name ='" & txt_nameproduct.Text & "', fld_price = '" & txt_price.Text & "', fld_brand = '" & txt_brand.Text & "', fld_type = '" & txt_type.Text & "', fld_quantity = '" & txt_quantity.Text & "', fld_description = '" & txt_description.Text & "' where fld_product_id = '" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated id '" & current_code & " '")
        refresh_grid()

    End Sub




    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick

        get_current_code()

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_product.CurrentRow.Index

        current_code = grd_product(0, current_row).Value

        txt_product.Text = current_code
        txt_nameproduct.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_brand.Text = grd_product(3, current_row).Value
        txt_type.Text = grd_product(4, current_row).Value
        txt_quantity.Text = grd_product(5, current_row).Value
        txt_description.Text = grd_product(6, current_row).Value

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you want to DELETE THE ID '" & current_code & "'?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("delete from TBL_PRODUCTS_A187795 where fld_product_id = '" & current_code & "'")

            Beep()
            MsgBox(" the ID '" & current_code & "'has been successfully deleted")

            refresh_grid()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_productdetails_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        refresh_grid()
    End Sub
End Class
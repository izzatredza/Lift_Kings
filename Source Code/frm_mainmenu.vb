Public Class frm_mainmenu_a187795



    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click

        frm_productdetails_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click

        frm_staffdetails_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click

        frm_order_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click

        frm_customerdetail_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub btn_lists_Click(sender As Object, e As EventArgs) Handles btn_lists.Click

        frm_lists_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub frm_mainmenu_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

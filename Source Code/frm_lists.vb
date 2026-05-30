
Public Class frm_lists_a187795

    Dim total As Double

    Private Sub frm_lists_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'grd_lists.DataSource = run_select("select products_id, fld_product_name, fld_product_number, fld_product_price from TBL_LISTS")

        'grd_lists.Columns(0).HeaderText = "Product ID"
        'grd_lists.Columns(1).HeaderText = "Product Name"
        'grd_lists.Columns(2).HeaderText = "Quantity"
        'grd_lists.Columns(3).HeaderText = "Price (RM)"

        cmb_order.DataSource = run_select("select * from tbl_order")
        cmb_order.DisplayMember = "order_num"
        Dim text As String = cmb_order.Text

        refresh_text(text)
    End Sub

    Private Sub frm_lists_a187795_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "select products_id, fld_product_name, fld_product_number, fld_product_price from tbl_lists where order_num='" & id & "'"
        'Dim mysql As String = "select * from tbl_lists where order_num='" & id & "'"


        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_lists.DataSource = mytable

        grd_lists.Columns(0).HeaderText = "Product ID"
        grd_lists.Columns(1).HeaderText = "Product Name"
        grd_lists.Columns(2).HeaderText = "Quantity"
        grd_lists.Columns(3).HeaderText = "Price (RM)"

        grd_lists(0, 0).Value = mytable.Rows(0).Item("PRODUCTS_ID")
        grd_lists(1, 0).Value = mytable.Rows(0).Item("FLD_PRODUCT_NAME")
        grd_lists(2, 0).Value = mytable.Rows(0).Item("FLD_PRODUCT_NUMBER")
        grd_lists(3, 0).Value = mytable.Rows(0).Item("FLD_PRODUCT_PRICE")

        total = 0

        For Each row As DataGridViewRow In grd_lists.Rows
            total += row.Cells(3).Value
        Next

        txt_total.Text = total

    End Sub


    Private Sub cmb_order_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_order.SelectedIndexChanged

        Dim text As String = cmb_order.Text

        Try
            refresh_text(cmb_order.Text)

        Catch ex As Exception

        End Try

    End Sub

End Class
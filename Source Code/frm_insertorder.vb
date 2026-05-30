Public Class frm_insertorder

    Dim total As Double
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_order_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub frm_insertorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'cmb_staff.Items.Add("A001")
        'cmb_staff.Items.Add("A002")
        'cmb_staff.Items.Add("A003")
        'cmb_staff.SelectedIndex = 0

        cmb_staff.DataSource = run_select("select staff_id from tbl_staff order by staff_id ")
        cmb_staff.DisplayMember = "staff_id"

        cmb_customer.DataSource = run_select("select customer_id from tbl_customer order by customer_id ")
        cmb_customer.DisplayMember = "customer_id"
        refresh_grid()

        lst_productid.DataSource = run_select("select * from TBL_PRODUCTS_A187795")
        lst_productid.DisplayMember = "FLD_PRODUCT_ID"
        refreshproduct_text(lst_productid.Text)

    End Sub

    Private Sub refresh_grid()

        grd_order.ColumnCount = 4

        grd_order.Columns(0).HeaderText = "Product ID"
        grd_order.Columns(1).HeaderText = "Product Name"
        grd_order.Columns(2).HeaderText = "Quantity"
        grd_order.Columns(3).HeaderText = "Price (RM)"

        'lst_productid.DataSource = run_select("select * from TBL_PRODUCTS_A187795")
        'lst_productid.DisplayMember = "fld_product_id"

        txt_orderid.Text = generate_id()

        grd_order.Rows.Clear()
    End Sub

    Private Sub refreshproduct_text(id As String)

        Dim mysql As String = "select * from TBL_PRODUCTS_A187795 where FLD_PRODUCT_ID ='" & id & "'"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        txt_product.Text = mytable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_nameproduct.Text = mytable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mytable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mytable.Rows(0).Item("FLD_BRAND")
        txt_type.Text = mytable.Rows(0).Item("FLD_TYPE")


        Try
            pic_product.BackgroundImage = Image.FromFile("Pictures/" & id & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("Pictures/no_photo.jpg")
        End Try
    End Sub

    Private Sub lst_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productid.MouseClick

        refreshproduct_text(lst_productid.Text)
        txt_quantity.Text = "0"
        txt_subtotal.Text = "0"

    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_select("select max(ORDER_NUM) as maxid from TBL_ORDER").Rows(0).Item("maxid")

        Dim nextid As String = "OR0" & (Mid(lastid, 3) + 1)

        Return nextid
    End Function
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If txt_quantity.Text = "" Then
            Beep()
            MsgBox("Please type appropirate quantity")
        Else

            grd_order.RowCount = grd_order.RowCount + 1

            Dim lastrow As Integer = grd_order.RowCount - 1

            grd_order(0, lastrow).Value = txt_product.Text
            grd_order(1, lastrow).Value = txt_nameproduct.Text
            grd_order(2, lastrow).Value = txt_quantity.Text
            grd_order(3, lastrow).Value = txt_subtotal.Text

            total = 0

            For Each row As DataGridViewRow In grd_order.Rows
                total += row.Cells(3).Value
            Next

            txt_total.Text = total
        End If

    End Sub

    Private Function calculate_subtotal(A As Double, B As Double)

        Return A * B

    End Function

    Private Sub txt_quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_quantity.TextChanged

        If IsNumeric(txt_quantity.Text) Then
            txt_subtotal.Text = calculate_subtotal(txt_price.Text, txt_quantity.Text)
        Else
            txt_subtotal.Text = "0"
        End If

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim mytransaction As OleDb.OleDbTransaction
        Dim mytransaction2 As OleDb.OleDbTransaction
        Dim lastrow As Integer = grd_order.RowCount



        Try
            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction

            Dim order As String = txt_orderid.Text
            Dim staff As String = cmb_staff.Text
            Dim customer As String = cmb_customer.Text

            'Dim mysql As String = "insert intot tbl_order values('order','cusomter','staff')"
            Dim mysql As String = "insert into tbl_order values('" & order & "','" & customer & "','" & staff & "')"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
            mywriter.ExecuteNonQuery()

            mytransaction.Commit()
            myconnection2.Close()

            myconnection2.Open()
            mytransaction2 = myconnection2.BeginTransaction
            For i As Integer = 0 To lastrow - 1

                Dim product As String = grd_order(0, i).Value
                Dim nameproduct As String = grd_order(1, i).Value
                Dim quantity As String = grd_order(2, i).Value
                Dim subtotal As String = grd_order(3, i).Value


                'Dim mysql2 As String = "insert into tbl_lists values('product','order','nameproduct','quantity','subtotal')"
                Dim mysql2 As String = "insert into tbl_lists values('" & product & "','" & order & "','" & nameproduct & "','" & quantity & "','" & subtotal & "')"

                Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction2)
                mywriter2.ExecuteNonQuery()
            Next

            mytransaction2.Commit()
            myconnection2.Close()

            refresh_grid()

        Catch ex As Exception

            Beep()
            MsgBox("There is a problem with your transaction:" & vbCrLf & ex.Message)

            mytransaction.Rollback()
            myconnection2.Close()

        End Try

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        refresh_grid()
    End Sub

End Class
Public Class frm_productdetails_a187795
    Private Sub frm_productdetails_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "select  FLD_PRODUCT_ID from TBL_PRODUCTS_A187795 order by FLD_PRODUCT_ID"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        lst_productid.DataSource = mytable
        lst_productid.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_productid.Text)
    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "select * from TBL_PRODUCTS_A187795 where FLD_PRODUCT_ID ='" & id & "'"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        txt_product.Text = mytable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_nameproduct.Text = mytable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mytable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mytable.Rows(0).Item("FLD_BRAND")
        txt_type.Text = mytable.Rows(0).Item("FLD_TYPE")
        txt_quantity.Text = mytable.Rows(0).Item("FLD_QUANTITY")
        txt_description.Text = mytable.Rows(0).Item("FLD_DESCRIPTION")

        Try
            pic_product.BackgroundImage = Image.FromFile("Pictures/" & id & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("Pictures/no_photo.jpg")
        End Try

    End Sub

    Private Sub lst_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productid.MouseClick

        refresh_text(lst_productid.Text)
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frm_insertproduct_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub frm_productdetails_a187795_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        frm_updateproduct_a187795.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lst_productid.DataSource = run_select("select * from TBL_PRODUCTS_A187795")
    End Sub

End Class
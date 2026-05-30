Public Class frm_insertproduct_a187795

    Dim defaultpicture As String = Application.StartupPath & "\Pictures\no_photo.jpg"

    Private Sub frm_insertproduct_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_product.DataSource = run_select("select * from TBL_PRODUCTS_A187795")

        txt_product.Text = generate_id()

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_select("select max(FLD_PRODUCT_ID) as maxid from TBL_PRODUCTS_A187795").Rows(0).Item("maxid")

        Dim nextid As String = "S0" & (Mid(lastid, 2) + 1)

        Return nextid
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        'Dim mysql As String = "insert into TBL_PRODUCTS_A187795 values ('S041',' Hello ' '43 ' 'Maxx ' 'dumbell '', 'Hello',)"
        Dim mysql As String = "insert into TBL_PRODUCTS_A187795 values ('" & txt_product.Text & "','" & txt_nameproduct.Text & "', '" & txt_price.Text & "', '" & txt_brand.Text & "', '" & txt_type.Text & "', '" & txt_quantity.Text & "', '" & txt_description.Text & "')"

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)



        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "Pictures\" & txt_product.Text & ".jpg")

            refresh_grid()

            txt_nameproduct.Text = ""
            txt_price.Text = ""
            txt_brand.Text = ""
            txt_type.Text = ""
            txt_quantity.Text = ""
            txt_description.Text = ""

        Catch ex As Exception

            Beep()
            MsgBox("ERROR: " & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub



    Private Sub frm_insertproduct_a187795_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()


        If (OpenFileDialog1.FileName = "") Then
            OpenFileDialog1.FileName = defaultpicture
        End If

        txt_picture.Text = OpenFileDialog1.FileName
        pic_product.BackgroundImage = Image.FromFile(txt_picture.Text)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_productdetails_a187795.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        refresh_grid()
    End Sub


End Class
Public Class frm_staff_a187795
    Private Sub frm_staff_a187795_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "select * from TBL_STAFF"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_staff.DataSource = mytable
    End Sub

    Private Sub frm_staff_a187795_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_mainmenu.Click
        frm_mainmenu_a187795.Show()
        Me.Hide()

    End Sub
End Class
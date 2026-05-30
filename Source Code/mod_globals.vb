Module mod_globals_a188795

    Public myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=DB_Lift_King_A187795.accdb;Persist Security Info=False;"

    Public myconnection2 As New OleDb.OleDbConnection(myconnection)

    Public Function run_select(mysql As String) As DataTable

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        Return mytable
    End Function

    Public Sub run_command(mysql As String)

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()



        Catch ex As Exception

            Beep()
            MsgBox("ERROR: " & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub
End Module

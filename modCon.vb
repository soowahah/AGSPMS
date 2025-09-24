
Module modCon

    Public con As Odbc.OdbcConnection
    Public Sub vbconnection()
        Try
            con = New Odbc.OdbcConnection("dsn=users")
            con.Open()
            MsgBox("Connected", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub



    
End Module

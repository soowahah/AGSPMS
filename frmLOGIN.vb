Public Class frmLOGIN


    
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
         

            Dim sql As String = "SELECT userID, uname, fullname, roleName, pw FROM vw_user WHERE uname = ? AND pw = ?"
            Dim cmd As New Odbc.OdbcCommand(sql, con)

            With cmd.Parameters
                .AddWithValue("?", Trim(txtun.Text))
                .AddWithValue("?", Trim(txtpw.Text))
            End With


            Using dr As Odbc.OdbcDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim uname As String = dr("uname").ToString()
                    Dim role As String = dr("roleName").ToString()
                    Dim fullname As String = dr("fullname").ToString()

                    MessageBox.Show("Welcome, " & fullname & " (" & role & ")")

                    Select Case role
                        Case "Admin"

                            frmAdminDashboard.Show()
                            'Case "Faculty"
                            ' Faculty.Show()
                        Case "Student"
                            frmStudentDashboard.LoggedInUser = fullname
                            frmStudentDashboard.Show()


                            'Case Else
                            'MessageBox.Show("Role not recognized.")
                    End Select

                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
            GC.Collect()

        End Try
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        frmWELCOME.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
End Class

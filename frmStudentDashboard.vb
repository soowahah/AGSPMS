Public Class frmStudentDashboard

    Public Property LoggedInUser As String

    Public currentUserID As Integer  ' this will be set from login form

    Private Sub frmStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblwelcome.Text = "Welcome, " & LoggedInUser & "!"
    End Sub

    Private Sub lblwelcome_Click(sender As Object, e As EventArgs) Handles lblwelcome.Click

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ContextMenuStrip1.Show(btnMenu, 0, btnMenu.Height)
    End Sub
    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Logout"
                Me.Close()          ' close the current form (Admin Dashboard)
                frmLOGIN.Show()     ' show your login form again
        End Select
    End Sub

End Class


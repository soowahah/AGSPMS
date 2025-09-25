Public Class frmAdminDashboard

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLOGIN.Close()
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(frmUserManagement)
    End Sub

    Sub switchPanel(panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub


 

    Private Sub btnAdminDB_Click(sender As Object, e As EventArgs) Handles btnAdminDB.Click
        switchPanel(frmAdminHome)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(frmStudentInfo)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(frmDepartment)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        switchPanel(frmSubject)
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ContextMenuStrip1.Show(btnMenu, 0, btnMenu.Height)
    End Sub
    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Logout"
                Me.Close()          ' close the current form (Admin Dashboard)
                frmLOGIN.Show()     ' show your login form again
        End Select
    End Sub
    Private Sub MakePictureBoxCircular(pic As PictureBox)
        Dim gp As New Drawing2D.GraphicsPath()
        gp.AddEllipse(0, 0, pic.Width - 1, pic.Height - 1)
        pic.Region = New Region(gp)
    End Sub

    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakePictureBoxCircular(PictureBox3) ' replace with your PictureBox name
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(frmSection)
    End Sub
End Class
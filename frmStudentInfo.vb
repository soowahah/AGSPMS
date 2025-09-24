Public Class frmStudentInfo

    Private Sub frmStudentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        ContextMenuStrip2.Show(btnDept, 0, btnDept.Height)

    End Sub

    Private Sub btnyr_Click(sender As Object, e As EventArgs) Handles btnyr.Click
        ContextMenuStrip1.Show(btnyr, 0, btnyr.Height)
    End Sub
End Class
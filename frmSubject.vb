Public Class frmSubject

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnyr.Click
        ContextMenuStrip1.Show(btnyr, 0, btnyr.Height)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        ContextMenuStrip2.Show(btnDept, 0, btnDept.Height)
    End Sub
End Class
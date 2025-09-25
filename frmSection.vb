Public Class frmSection

    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        ContextMenuStrip2.Show(btnDept, 0, btnDept.Height)

    End Sub

    Private Sub btnyr_Click(sender As Object, e As EventArgs) Handles btnyr.Click
        ContextMenuStrip1.Show(btnDept, 0, btnDept.Height)

    End Sub
End Class
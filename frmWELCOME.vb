Public Class frmWELCOME

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLOGIN.Show()
        Me.Hide()

    End Sub

    Private Sub frmWELCOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call vbconnection()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
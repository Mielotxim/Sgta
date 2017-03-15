Public Class Menu

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Jokatu_Click(sender As Object, e As EventArgs) Handles Jokatu.Click
        Dim form As Form2
        form = New Form2
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Itxi_Click(sender As Object, e As EventArgs) Handles Itxi.Click
        Me.Close()
    End Sub
End Class

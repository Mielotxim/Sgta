Public Class Tablero

    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For I As Integer = 1 To 10
            Dim b As New Button()
            b.Text = "Texto " & I
            b.Height = Me.Height / 10
            b.Left = botoiaJarri(I)
            b.Width = 100
            b.Top = (I - 1) * (b.Height)
            Me.Controls.Add(b)
        Next I
    End Sub

    Private Function botoiaJarri(ByVal i As Integer)
        Dim eran As Integer = 100
        If i > 5 Then
            eran = eran * 2
        End If
        Return eran
    End Function
End Class
Public Class Tablero

    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim z As Integer
        z = 1
        For I As Integer = 1 To 25
            Dim b As New Button()
            If z = 5 Then
                z = 1
            End If
            b.Text = "Texto " & I
            b.Height = Me.Height / 10
            b.Left = botoiaJarri(I)
            b.Width = 100
            b.Top = z * (b.Height)
            Me.Controls.Add(b)
            z = z + 1
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
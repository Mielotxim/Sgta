Public Class Tablero

    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For altuera As Integer = 1 To 23
            For zabalera As Integer = 1 To 45
                Dim b As New Button()
                b.Height = 40
                b.Width = 40
                b.Left = 40 * zabalera + 10
                b.Top = 40 * altuera - 10
                If zabalera = 20 Or zabalera = 21 Or zabalera = 22 Then
                    b.BackgroundImage = sgta.jokoa.My.Resources.water
                Else
                    b.BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If

                Me.Controls.Add(b)
            Next
        Next

        'For I As Integer = 1 To 25
        'Dim b As New Button()
        'If z = 5 Then
        'z = 1
        'End If
        'b.Text = "Texto " & I
        'b.Height = Me.Height / 10
        'b.Left = botoiaJarri(I)
        'b.Width = 100
        'b.Top = z * (b.Height)
        'Me.Controls.Add(b)
        'z = z + 1
        'Next I
    End Sub

    'Private Function botoiaJarri(ByVal i As Integer)
    'Dim eran As Integer = 100
    '   If i > 5 Then
    '      eran = eran * 2
    ' End If
    'Return eran
    'End Function
End Class
Public Class Tablero
    Dim aux(23, 45) As Button
    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For altuera As Integer = 1 To 12
            For zabalera As Integer = 1 To 23
                Dim b As New Button()
                b.Height = 40
                b.Width = 40
                b.Left = 40 * zabalera + 10
                b.Top = 40 * altuera - 10
                If zabalera = 14 Or zabalera = 13 Or zabalera = 15 Then
                    b.BackgroundImage = sgta.jokoa.My.Resources.water
                Else
                    b.BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If
                aux(altuera, zabalera) = b
                Me.Controls.Add(b)
            Next
        Next
    End Sub

    'Private Function botoiaJarri(ByVal i As Integer)
    'Dim eran As Integer = 100
    '   If i > 5 Then
    '      eran = eran * 2
    ' End If
    'Return eran
    'End Function
End Class
Public Class Tablero
    Dim aux(23, 45) As Button
    Dim aldaketa As Boolean
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

    Private Sub clikatuta(zabalera As Integer, altuera As Integer)
        If aldaketa Then
            aux(zabalera, altuera).BackgroundImage = sgta.jokoa.My.Resources.water
            altuera = False
        Else
            aux(zabalera, altuera).BackgroundImage = sgta.jokoa.My.Resources.water
            altuera = True
        End If

    End Sub

End Class
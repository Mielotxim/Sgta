Public Class Tablero
    Dim aux(100, 100) As PictureBox
    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For altuera As Integer = 1 To 10
            For zabalera As Integer = 1 To 10
                Dim b As New PictureBox()
                b.Height = 40
                b.Width = 40
                b.Left = 40 * zabalera
                b.Top = 40 * altuera - 10
                b.BorderStyle = BorderStyle.FixedSingle
                b.Name = altuera.ToString
                AddHandler b.Click, AddressOf OnbClick
                If zabalera = 14 Or zabalera = 13 Or zabalera = 15 Then
                    b.BackgroundImage = sgta.jokoa.My.Resources.water
                Else
                    b.BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If
                aux(altuera, zabalera) = b
                Panel2.Controls.Add(b)

            Next
        Next

        Label1.Text = "TU PERSONAJE"

        Button1.Text = "Gulag"

    End Sub

    Private Sub OnbClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        sender.BackgroundImage = sgta.jokoa.My.Resources.water
        Label1.Text = sender.name
        Dim a As Integer
        a = sender.name
        aux(a, a).BackgroundImage = sgta.jokoa.My.Resources.water
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aux(10, 10).BackgroundImage = sgta.jokoa.My.Resources.water
    End Sub

End Class

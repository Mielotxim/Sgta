Imports sgta.logika

Public Class ITablero
    'Dim taula(Sistema.getTable().getAltuera, Sistema.getTable().getZabalera) As PictureBox
    Dim taula(100, 100) As PictureBox
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
                taula(altuera, zabalera) = b
                Panel2.Controls.Add(b)
            Next
        Next

        lblName.Text = "TU PERSONAJE"
        
        Button1.Text = "Gulag"
    End Sub

    Private Sub OnbClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        sender.BackgroundImage = sgta.jokoa.My.Resources.water
        lblName.Text = sender.name
        Dim a As Integer
        a = sender.name
        taula(a, a).BackgroundImage = sgta.jokoa.My.Resources.water
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        taula(10, 10).BackgroundImage = sgta.jokoa.My.Resources.water
    End Sub

    Private Sub setColorRed(ByVal altuera As Integer, ByVal zabalera As Integer, ByVal dis As Integer)
        'hay que averiguar como cambiar el color (o poner una nueva imagen en su lugar)
        Dim auxZ As Integer = 0
        Dim auxA As Integer = dis
        While auxA >= 0
            If Not (auxA = 0) Then
                If (altuera - auxA >= 0) Then
                    taula(altuera - auxA, zabalera).BackColor = Color.Red
                End If
                If (altuera + auxA <= Sistema.getTable.getAltuera()) Then
                    taula(altuera + auxA, zabalera).BackColor = Color.Red
                End If
            End If
            While (auxA + auxZ <= dis)
                taula(altuera + auxA, zabalera - auxZ).BackColor = Color.Red
                taula(altuera + auxA, zabalera + auxZ).BackColor = Color.Red
                taula(altuera - auxA, zabalera - auxZ).BackColor = Color.Red
                taula(altuera - auxA, zabalera + auxZ).BackColor = Color.Red
                auxZ += 1
            End While
            auxZ = 0
            auxA -= 1
        End While
    End Sub
End Class

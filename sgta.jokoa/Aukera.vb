Imports sgta.logika

Public Class Aukera

    Dim per(8) As Pertsonaia

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        per(0) = New Pertsonaia("Shinzō Abe", 100, 10, 10, 2)
        per(1) = New Pertsonaia("Kim Yong Un", 100, 10, 10, 2)
        per(2) = New Pertsonaia("Xi Jinping", 100, 10, 10, 2)
        per(3) = New Pertsonaia("Hilary Clinton", 100, 10, 10, 2)
        per(4) = New Pertsonaia("Donald Trump", 100, 10, 10, 2)
        per(5) = New Pertsonaia("chino cudeiro", 100, 10, 10, 2)
        per(6) = New Pertsonaia("Vladimir Putin", 100, 10, 10, 2)
        per(7) = New Pertsonaia("chino cudeiro", 100, 10, 10, 2)

        Label5.Text = per(0).getHp
        Label4.Text = per(0).getAtk
        Label2.Text = per(0).getDef
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MsgBox("QUE TE PETEN !!!")
    End Sub



    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.GreenYellow

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Green
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As Tablero
        form = New Tablero
        form.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Label7.BringToFront()
        Label7.Text = "Shinzō Abe"
        Label7.Visible = True
        Threading.Thread.Sleep(500)
        Label7.Visible = False
    End Sub
End Class
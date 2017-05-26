Imports sgta.logika

Public Class Aukera



    Dim per(5) As Jokalari

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        per(0) = New Jokalari("Shinzō Abe", 100, 10, 10, 2)
        per(1) = New Jokalari("Kim Yong Un", 101, 10, 10, 2)
        per(2) = New Jokalari("Xi Jinping", 102, 10, 10, 2)
        per(3) = New Jokalari("Donald Trump", 103, 10, 10, 2)
        per(4) = New Jokalari("Vladimir Putin", 104, 10, 10, 2)
        ComboBox1.Items.Add("Shinzō Abe")
        ComboBox1.Items.Add("Kim Yong Un")
        ComboBox1.Items.Add("Xi Jinping")
        ComboBox1.Items.Add("Donald Trump")
        ComboBox1.Items.Add("Vladimir Putin")

        Label5.Text = per(0).getHp
        Label4.Text = per(0).getAtk
        Label2.Text = per(0).getDef
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        MsgBox("QUE TE PETEN !!!")
    End Sub



    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.GreenYellow

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Green
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jokalariak As New JokalariZerrenda
        Dim aux As Jokalari
        aux = bilatuJokalaria()
        MsgBox(aux.getIzena)
        jokalariak.addJokalari(aux)
        Sistema.jokoaHasi("Erraza", jokalariak)
        Dim form As ITablero
        form = New ITablero
        form.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedItem.ToString = per(0).getIzena() Then
            PictureBox1.BackgroundImage = sgta.jokoa.My.Resources.Chino
            Label5.Text = per(0).getHp
            Label4.Text = per(0).getAtk
            Label2.Text = per(0).getDef

        ElseIf ComboBox1.SelectedItem.ToString = per(1).getIzena() Then
            PictureBox1.BackgroundImage = sgta.jokoa.My.Resources.Koreano
            Label5.Text = per(1).getHp
            Label4.Text = per(1).getAtk
            Label2.Text = per(1).getDef

        ElseIf ComboBox1.SelectedItem.ToString = per(2).getIzena() Then
            PictureBox1.BackgroundImage = sgta.jokoa.My.Resources.Japones
            Label5.Text = per(2).getHp
            Label4.Text = per(2).getAtk
            Label2.Text = per(2).getDef

        ElseIf ComboBox1.SelectedItem.ToString = per(3).getIzena() Then
            PictureBox1.BackgroundImage = sgta.jokoa.My.Resources.Trump
            Label5.Text = per(3).getHp
            Label4.Text = per(3).getAtk
            Label2.Text = per(3).getDef

        ElseIf ComboBox1.SelectedItem.ToString = per(4).getIzena() Then
            PictureBox1.BackgroundImage = sgta.jokoa.My.Resources.Putin1
            Label5.Text = per(4).getHp
            Label4.Text = per(4).getAtk
            Label2.Text = per(4).getDef
        End If
    End Sub

    Private Function bilatuJokalaria() As Jokalari
        Dim aux As Jokalari
        Dim bukatuta As Boolean
        Dim i As Integer
        i = 0
        bukatuta = False
        aux = Nothing
        While Not bukatuta And i < per.Length
            If per(i).getIzena = ComboBox1.SelectedItem.ToString Then
                aux = per(i)
                bukatuta = True
            Else
                i = i + 1
            End If
        End While
        MsgBox(aux.getIzena)
        Return aux
    End Function
End Class
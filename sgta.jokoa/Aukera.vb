Imports sgta.logika
Imports sgta.db
Imports MySql.Data.MySqlClient

Public Class Aukera

    'Private per(5) As Jokalari
    Private jok As ArrayList
    Private jz As JokalariZerrenda

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = Image.FromFile("../../../argazkiak/select_character.jpg")
        jz = New JokalariZerrenda
        datuBasea.Konektatu()
        Dim dr As MySqlDataReader = datuBasea.PertsonaiakLortu()
        jok = New ArrayList
        While dr.Read
            Dim iz As String = dr.Item(0)
            Dim tal As String = dr.Item(1)
            Dim hp As Integer = dr.Item(2)
            Dim atk As Integer = dr.Item(3)
            Dim def As Integer = dr.Item(4)
            Dim mov As Integer = dr.Item(5)
            Dim alk As Integer = dr.Item(6)
            Dim j As New Jokalari(iz, hp, tal, atk, def, mov, alk)
            jok.Add(j)
            ComboBox1.Items.Add(j.getIzena)
        End While
        datuBasea.ItxiKonexioa()
        ComboBox2.Items.Add("Erraza")
        ComboBox2.Items.Add("Normala")
        ComboBox2.Items.Add("Zaila")
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub



    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.GreenYellow

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Green
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If jz.getKop < 2 Then
            MsgBox("Jokalariak falta dira")
        Else
            Sistema.jokoaHasi(ComboBox2.SelectedItem.ToString, jz)
            Dim form As ITablero
            form = New ITablero
            form.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim aur As Boolean = False
        Dim i As Integer = 0

        While Not aur And i < jok.Count
            Dim j As Jokalari = jok(i)
            If ComboBox1.SelectedItem.ToString.Equals(j.getIzena) Then
                aur = True
                lblHp.Text = j.getHp
                lblTaldea.Text = j.getTaldea
                lblAtk.Text = j.getAtk
                lblDef.Text = j.getDef
                lblMov.Text = j.getMov
                lblAlk.Text = j.getAlk
                If j.getIzena = "Donald Trump" Then
                    PictureBox1.BackgroundImage = Image.FromFile("../../../argazkiak/Trump.png")
                End If
                If j.getIzena = "Kim Yong Un" Then
                    PictureBox1.BackgroundImage = Image.FromFile("../../../argazkiak/Koreano.png")
                End If
                If j.getIzena = "Shinzo Abe" Then
                    PictureBox1.BackgroundImage = Image.FromFile("../../../argazkiak/Japones.png")
                End If
                If j.getIzena = "Vladimir Putin" Then
                    PictureBox1.BackgroundImage = Image.FromFile("../../../argazkiak/Putin.png")
                End If
                If j.getIzena = "Xi Jinping" Then
                    PictureBox1.BackgroundImage = Image.FromFile("../../../argazkiak/Chino.png")
                End If
            End If
            i += 1
        End While
    End Sub

    Private Function bilatuJokalaria() As Jokalari
        Dim aux As Jokalari
        Dim bukatuta As Boolean
        Dim i As Integer
        i = 0
        bukatuta = False
        aux = Nothing
        While Not bukatuta And i < jok.Count
            If jok(i).getIzena = ComboBox1.SelectedItem.ToString Then
                aux = jok(i)
                bukatuta = True
            Else
                i = i + 1
            End If
        End While
        MsgBox(aux.getIzena)
        Return aux
    End Function

    Private Sub btnPl1_Click(sender As Object, e As EventArgs) Handles btnPl1.Click
        'falta mirar que los personajes no se repitan
        Dim aur As Boolean = False
        Dim i As Integer = 0
        Dim j As Jokalari = Nothing
        While Not aur And i < jok.Count
            j = jok(i)
            If ComboBox1.SelectedItem.ToString.Equals(j.getIzena) Then
                aur = True
            End If
            i += 1
        End While
        jz.addJokalari(j, 0)
        btnPl1.Enabled = False
    End Sub

    Private Sub btnPl2_Click(sender As Object, e As EventArgs) Handles btnPl2.Click
        'falta mirar que los personajes no se repitan
        Dim aur As Boolean = False
        Dim i As Integer = 0
        Dim j As Jokalari = Nothing
        While Not aur And i < jok.Count
            j = jok(i)
            If ComboBox1.SelectedItem.ToString.Equals(j.getIzena) Then
                aur = True
            End If
            i += 1
        End While
        jz.addJokalari(j, 1)
        btnPl2.Enabled = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem.ToString = "Zaila" Then
            MsgBox("Si no tienes un ordenador de la nasa ten cuidado, no nos hacemos responsables de tu ordenador :) ")
        End If
    End Sub
End Class
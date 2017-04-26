Imports sgta.logika

Public Class Aukera

    Dim per(3) As Pertsonaia




    Private Sub btnPersonaje_Click(sender As Object, e As EventArgs) Handles btnPersonaje.Click
        txtName.Text = per(0).getIzena
        txtHp.Text = per(0).getHp
        txtAtk.Text = per(0).getAtk
        txtDef.Text = per(0).getDef
        txtMov.Text = per(0).getMov
        txtName.Visible = True
        lblHp.Visible = True
        txtHp.Visible = True
        lblAtk.Visible = True
        txtAtk.Visible = True
        lblDef.Visible = True
        txtDef.Visible = True
        lblMov.Visible = True
        txtMov.Visible = True
        btnPlay.Visible = True
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim form As Tablero
        form = New Tablero
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Aukera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        per(0) = New Pertsonaia("Stalin", 100, 10, 10, 2)
        per(1) = New Pertsonaia("Jitler", 100, 11, 10, 2)
        per(2) = New Pertsonaia("JFK", 100, 12, 10, 2)
        txtName.Text = per(1).getIzena
        txtHp.Text = per(1).getHp
        txtAtk.Text = per(1).getAtk
        txtDef.Text = per(1).getDef
        txtMov.Text = per(1).getMov
        txtName.Visible = True
        lblHp.Visible = True
        txtHp.Visible = True
        lblAtk.Visible = True
        txtAtk.Visible = True
        lblDef.Visible = True
        txtDef.Visible = True
        lblMov.Visible = True
        txtMov.Visible = True
        btnPlay.Visible = True
    End Sub

    Private Sub btnPersonaje2_Click(sender As Object, e As EventArgs) Handles btnPersonaje2.Click

        txtName.Text = per(2).getIzena
        txtHp.Text = per(2).getHp
        txtAtk.Text = per(2).getAtk
        txtDef.Text = per(2).getDef
        txtMov.Text = per(2).getMov
        txtName.Visible = True
        lblHp.Visible = True
        txtHp.Visible = True
        lblAtk.Visible = True
        txtAtk.Visible = True
        lblDef.Visible = True
        txtDef.Visible = True
        lblMov.Visible = True
        txtMov.Visible = True
        btnPlay.Visible = True
    End Sub

    Private Sub btnPersonaje3_Click(sender As Object, e As EventArgs) Handles btnPersonaje3.Click
        txtName.Text = per(1).getIzena
        txtHp.Text = per(1).getHp
        txtAtk.Text = per(1).getAtk
        txtDef.Text = per(1).getDef
        txtMov.Text = per(1).getMov
        txtName.Visible = True
        lblHp.Visible = True
        txtHp.Visible = True
        lblAtk.Visible = True
        txtAtk.Visible = True
        lblDef.Visible = True
        txtDef.Visible = True
        lblMov.Visible = True
        txtMov.Visible = True
        btnPlay.Visible = True
    End Sub
End Class
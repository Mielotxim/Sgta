Imports sgta.logika

Public Class Aukera

    Dim per As Pertsonaia

    Private Sub btnPersonaje_Click(sender As Object, e As EventArgs) Handles btnPersonaje.Click
        per = New Pertsonaia("Stallin", 100, 10, 10, 2)
        txtName.Text = per.getIzena
        txtHp.Text = per.getHp
        txtAtk.Text = per.getAtk
        txtDef.Text = per.getDef
        txtMov.Text = per.getMov
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
End Class
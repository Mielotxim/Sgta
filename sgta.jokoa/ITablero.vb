Imports sgta.logika

Public Class ITablero
    Dim taula(Sistema.getTable().getAltuera - 1, Sistema.getTable().getZabalera - 1) As PictureBox
    'Dim taula(100, 100) As PictureBox
    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFase.Text = "Hasierako Fasea"
        For altuera As Integer = 0 To (Sistema.getTable().getAltuera - 1)
            For zabalera As Integer = 0 To (Sistema.getTable().getZabalera - 1)
                Dim b As New PictureBox()
                b.Height = 40
                b.Width = 40
                b.Left = 40 * (zabalera + 1)
                b.Top = 40 * (altuera + 1) - 10
                b.BorderStyle = BorderStyle.FixedSingle
                b.Name = altuera.ToString + "/" + zabalera.ToString
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
        lblTxanda.Text = Sistema.getJokalariAktibo().getIzena()
    End Sub

    Private Sub OnbClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim a As String
        Dim b(1) As String
        a = sender.name
        b = a.Split("/")
        taula(b(0), b(1)).BackgroundImage = sgta.jokoa.My.Resources.water
        'no se para que es el codigo anterior asi que lo dejo cuando no sirva lo borras y listo
        'aqui empezamos ya con los turnos 
        Select Case Sistema.getFase()
            Case "Hasierako Fasea"
                pertsonaiarenDatuak(b(0), b(1))
            Case "Mugimendu Fasea"
                If Sistema.currentDu() Then
                    'aqui significa que el rombo esta a la vista y tocaria moverse
                    mugimendua(b(0), b(1))
                Else
                    'aqui mirariamos si hay persona y despues dibujariamos el rombo
                    pertsonaiarenMugimenduaBistaratu(b(0), b(1))
                End If
            Case "Eraso Fasea"
                If Sistema.currentDu() Then
                    'esta el robo de ataque mirariamos a ver si se puede atacar a la casilla indicada
                Else
                    'aqui mirariamos si hay persona y despues dibujariamos el rombo
                    pertsonaiarenErasoaBistaratu(b(0), b(1))
                End If
            Case Else
                MsgBox("Error en las fases")
        End Select
    End Sub

    Private Sub setColorBlue(altuera As String, zabalera As String, p3 As Integer)
        Throw New NotImplementedException
        'lo mismo que el red pero en azul
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
                If (altuera - auxA >= 0) And (zabalera - auxZ >= 0) Then
                    taula(altuera - auxA, zabalera - auxZ).BackColor = Color.Red
                End If
                If (altuera - auxA >= 0) And (zabalera + auxZ >= Sistema.getTable.getZabalera()) Then
                    taula(altuera - auxA, zabalera + auxZ).BackColor = Color.Red
                End If
                If (altuera + auxA >= Sistema.getTable.getAltuera()) And (zabalera - auxZ >= 0) Then
                    taula(altuera + auxA, zabalera - auxZ).BackColor = Color.Red
                End If
                If (altuera + auxA >= Sistema.getTable.getAltuera()) And (zabalera + auxZ >= Sistema.getTable.getZabalera()) Then
                    taula(altuera + auxA, zabalera + auxZ).BackColor = Color.Red
                End If
                auxZ += 1
            End While
            auxZ = 0
            auxA -= 1
        End While
    End Sub

    Private Sub quitColors(ByVal altuera As Integer, ByVal zabalera As Integer, ByVal dis As Integer)
        'pone floresiñas en los que habia cambiado el color
        'en los siguientes pasos se pondra el perosnaje asi que no deberia solaparse
        Dim auxZ As Integer = 0
        Dim auxA As Integer = dis
        While auxA >= 0
            If Not (auxA = 0) Then
                If (altuera - auxA >= 0) Then
                    taula(altuera - auxA, zabalera).BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If
                If (altuera + auxA <= Sistema.getTable.getAltuera()) Then
                    taula(altuera + auxA, zabalera).BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If
            End If
            While (auxA + auxZ <= dis)
                If (altuera - auxA >= 0) And (zabalera - auxZ >= 0) Then
                    taula(altuera - auxA, zabalera - auxZ).BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If
                If (altuera - auxA >= 0) And (zabalera + auxZ >= Sistema.getTable.getZabalera()) Then
                    taula(altuera - auxA, zabalera + auxZ).BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If
                If (altuera + auxA >= Sistema.getTable.getAltuera()) And (zabalera - auxZ >= 0) Then
                    taula(altuera + auxA, zabalera - auxZ).BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If
                If (altuera + auxA >= Sistema.getTable.getAltuera()) And (zabalera + auxZ >= Sistema.getTable.getZabalera()) Then
                    taula(altuera + auxA, zabalera + auxZ).BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                End If
                auxZ += 1
            End While
            auxZ = 0
            auxA -= 1
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fase As String = "Mugimendu Fasea"
        lblFase.Text = fase
        Sistema.faseAldatu(fase)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fase As String = "Eraso Fasea"
        lblFase.Text = fase
        Sistema.faseAldatu(fase)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblFase.Text = "Hasierako Fasea"
        Sistema.txandaAldatu()
        lblTxanda.Text = Sistema.getJokalariAktibo().getIzena()
    End Sub

    Private Sub pertsonaiarenDatuak(ByVal altuera As Integer, ByVal zabalera As Integer)
        If Sistema.pertsonairikDu(altuera, zabalera) Then
            Dim per As Pertsonaia = Sistema.getPertsonaia(altuera, zabalera)
            lblHp.Text = per.getHp.ToString
            lblTeam.Text = per.getTaldea
            lblAlk.Text = per.getAtk.ToString
            lblDef.Text = per.getDef.ToString
            lblMov.Text = per.getMov.ToString
            lblAlk.Text = per.getAlk.ToString
            If per.GetType().Equals(GetType(Jokalari)) Then
                lblName.Text = DirectCast(per, Jokalari).getIzena
            ElseIf per.GetType().Equals(GetType(Soldadu)) Then
                lblName.Text = DirectCast(per, Soldadu).getMota
            End If
            statPanel.Visible = True
        Else
            lblHp.Text = ""
            lblAlk.Text = ""
            lblDef.Text = ""
            lblMov.Text = ""
            lblAlk.Text = ""
            lblAlk.Name = ""
            lblTeam.Text = ""
            statPanel.Visible = False
        End If
    End Sub

    Private Sub pertsonaiarenMugimenduaBistaratu(ByVal altuera As Integer, zabalera As Integer)
        If Sistema.pertsonaiAktiboaDu(altuera, zabalera) Then
            setColorBlue(altuera, zabalera, Sistema.getPertsonaia(altuera, zabalera).getMov)
        Else
            pertsonaiarenDatuak(altuera, zabalera)
        End If
    End Sub

    Private Sub pertsonaiarenErasoaBistaratu(ByVal altuera As Integer, ByVal zabalera As Integer)
        If Sistema.pertsonaiAktiboaDu(altuera, zabalera) Then
            setColorRed(altuera, zabalera, Sistema.getPertsonaia(altuera, zabalera).getMov)
        Else
            pertsonaiarenDatuak(altuera, zabalera)
        End If
    End Sub

    Private Sub mugimendua(ByVal altuera As Integer, ByVal zabalera As Integer)
        Dim k As Kasilla = Sistema.getCurrent
        Dim koordenadak() As Integer = k.getKoordenadak
        If k.getPertsonaia.mugimenduaHeltzenDa(koordenadak(0), koordenadak(1), altuera, zabalera) Then
            quitColors(koordenadak(0), koordenadak(1), k.getPertsonaia.getMov)
            Sistema.mugitu(koordenadak(0), koordenadak(1), altuera, zabalera)
            'aqui habria que cambiar al personaje de casilla
        End If
    End Sub

    Private Sub erasoa(ByVal altuera As Integer, ByVal zabalera As Integer)
        Dim k As Kasilla = Sistema.getCurrent
        Dim koordenadak() As Integer = k.getKoordenadak
        If k.getPertsonaia.erasoaHeltzenDa(koordenadak(0), koordenadak(1), altuera, zabalera) Then
            quitColors(koordenadak(0), koordenadak(1), k.getPertsonaia.getAlk)
            Sistema.eraso(altuera, zabalera)
            If Not Sistema.pertsonairikDu(altuera, zabalera) Then
                'aqui habria que quitar al personaje de dicha casilla si se ha muerto
                taula(altuera, zabalera).BackgroundImage = sgta.jokoa.My.Resources.floresiñas
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Sistema.cancelCurrent()
    End Sub

End Class

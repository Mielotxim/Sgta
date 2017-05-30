Imports sgta.logika
Imports System
Imports System.IO
Imports sgta.db
Imports MySql.Data.MySqlClient

Public Class ITablero

    Dim taula(Sistema.getTable().getAltuera - 1, Sistema.getTable().getZabalera - 1) As PictureBox
    'Dim taula(100, 100) As PictureBox
    Dim s As System.Media.SoundPlayer

    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ruta As String
        ruta = My.Application.Info.DirectoryPath
        s = New System.Media.SoundPlayer(ruta + "\song1.wav")
        s.Play()

        PictureBox1.BackgroundImage = Image.FromFile("../../../argazkiak/foto.png")
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

                b.BackgroundImage = sgta.jokoa.My.Resources.floresiñas

                taula(altuera, zabalera) = b
                Panel2.Controls.Add(b)
            Next
        Next
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2, 1, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2, 1))
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2 + 1, 0, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2 + 1, 0))
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2 - 1, 0, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2 - 1, 0))
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2 + 1, 2, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2 + 1, 2))
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2 - 1, 2, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2 - 1, 2))

        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2, Sistema.getTable.getZabalera - 2, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2, Sistema.getTable.getZabalera - 2))
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2 + 1, Sistema.getTable.getZabalera - 1, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2 + 1, Sistema.getTable.getZabalera - 1))
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2 - 1, Sistema.getTable.getZabalera - 1, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2 - 1, Sistema.getTable.getZabalera - 1))
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2 + 1, Sistema.getTable.getZabalera - 3, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2 + 1, Sistema.getTable.getZabalera - 3))
        pertsonaiaKokatu(Sistema.getTable.getAltuera() / 2 - 1, Sistema.getTable.getZabalera - 3, Sistema.getPertsonaia(Sistema.getTable.getAltuera() / 2 - 1, Sistema.getTable.getZabalera - 3))

        lblTxanda.Text = Sistema.getJokalariAktibo().getIzena()
        lblAkzio.Text = Sistema.getAkzio()
    End Sub

    Private Sub OnbClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim a As String
        Dim b(1) As String
        a = sender.name
        b = a.Split("/")
        'no se para que es el codigo anterior asi que lo dejo cuando no sirva lo borras y listo
        'aqui empezamos ya con los turnos 
        Select Case Sistema.getFase()
            Case "Hasierako Fasea"
                pertsonaiarenDatuak(b(0), b(1))
            Case "Mugimendu Fasea"
                If Sistema.getAkzio = 0 Then
                    MsgBox("Sentitzen dugu, baina ez zaizkizu mugumendurik gelditzen. Txanda hurrengo jokalarira pasako da.")
                    txandaAldaketa()
                Else
                    If Sistema.currentDu() Then
                        'aqui significa que el rombo esta a la vista y tocaria moverse
                        mugimendua(b(0), b(1))
                    Else
                        'aqui mirariamos si hay persona y despues dibujariamos el rombo
                        pertsonaiarenMugimenduaBistaratu(b(0), b(1))
                    End If
                    lblAkzio.Text = Sistema.getAkzio()
                End If
            Case "Eraso Fasea"
                If Sistema.getAkzio = 0 Then
                    MsgBox("Sentitzen dugu, baina ez zaizkizu mugumendurik gelditzen. Txanda hurrengo jokalarira pasako da.")
                    txandaAldaketa()
                Else
                    If Sistema.currentDu() Then
                        'esta el robo de ataque mirariamos a ver si se puede atacar a la casilla indicada
                        erasoa(b(0), b(1))
                    Else
                        'aqui mirariamos si hay persona y despues dibujariamos el rombo
                        pertsonaiarenErasoaBistaratu(b(0), b(1))
                    End If
                    lblAkzio.Text = Sistema.getAkzio()
                End If
            Case Else
                MsgBox("Error en las fases")
        End Select
    End Sub

    Private Sub setColorBlue(altuera As String, zabalera As String, dis As Integer)
        Dim auxZ As Integer = 0
        Dim auxA As Integer = dis
        While auxA >= 0
            While (auxA + auxZ <= dis)
                If (altuera - auxA >= 0) And (zabalera - auxZ >= 0) _
                And (altuera - auxA <> altuera Or zabalera - auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera - auxA, zabalera - auxZ) Then
                        taula(altuera - auxA, zabalera - auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas_azul.png")
                    End If
                End If
                If (altuera - auxA >= 0) And (zabalera + auxZ < Sistema.getTable.getZabalera()) _
                And (altuera - auxA <> altuera Or zabalera + auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera - auxA, zabalera + auxZ) Then
                        taula(altuera - auxA, zabalera + auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas_azul.png")
                    End If
                End If
                If (altuera + auxA < Sistema.getTable.getAltuera()) And (zabalera - auxZ >= 0) _
                And (altuera + auxA <> altuera Or zabalera - auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera + auxA, zabalera - auxZ) Then
                        taula(altuera + auxA, zabalera - auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas_azul.png")
                    End If
                End If
                If (altuera + auxA < Sistema.getTable.getAltuera()) And (zabalera + auxZ < Sistema.getTable.getZabalera()) _
                And (altuera + auxA <> altuera Or zabalera + auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera + auxA, zabalera + auxZ) Then
                        taula(altuera + auxA, zabalera + auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas_azul.png")
                    End If
                End If
                auxZ += 1
            End While
            auxZ = 0
            auxA -= 1
        End While
    End Sub

    Private Sub setColorRed(ByVal altuera As Integer, ByVal zabalera As Integer, ByVal dis As Integer)
        'hay que averiguar como cambiar el color (o poner una nueva imagen en su lugar)
        Dim auxZ As Integer = 0
        Dim auxA As Integer = dis
        While auxA >= 0
            While (auxA + auxZ <= dis)
                If (altuera - auxA >= 0) And (zabalera - auxZ >= 0) _
                And (altuera - auxA <> altuera Or zabalera - auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera - auxA, zabalera - auxZ) Then
                        taula(altuera - auxA, zabalera - auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas_rojas.png")
                    End If
                End If
                If (altuera - auxA >= 0) And (zabalera + auxZ < Sistema.getTable.getZabalera()) _
                And (altuera - auxA <> altuera Or zabalera + auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera - auxA, zabalera + auxZ) Then
                        taula(altuera - auxA, zabalera + auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas_rojas.png")
                    End If
                End If
                If (altuera + auxA < Sistema.getTable.getAltuera()) And (zabalera - auxZ >= 0) _
                And (altuera + auxA <> altuera Or zabalera - auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera + auxA, zabalera - auxZ) Then
                        taula(altuera + auxA, zabalera - auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas_rojas.png")
                    End If
                End If
                If (altuera + auxA < Sistema.getTable.getAltuera()) And (zabalera + auxZ < Sistema.getTable.getZabalera()) _
                And (altuera + auxA <> altuera Or zabalera + auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera + auxA, zabalera + auxZ) Then
                        taula(altuera + auxA, zabalera + auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas_rojas.png")
                    End If
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
            While (auxA + auxZ <= dis)
                If (altuera - auxA >= 0) And (zabalera - auxZ >= 0) _
                And (altuera - auxA <> altuera Or zabalera - auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera - auxA, zabalera - auxZ) Then
                        taula(altuera - auxA, zabalera - auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas.png")
                    End If
                End If
                If (altuera - auxA >= 0) And (zabalera + auxZ < Sistema.getTable.getZabalera()) _
                And (altuera - auxA <> altuera Or zabalera + auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera - auxA, zabalera + auxZ) Then
                        taula(altuera - auxA, zabalera + auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas.png")
                    End If
                End If
                If (altuera + auxA < Sistema.getTable.getAltuera()) And (zabalera - auxZ >= 0) _
                And (altuera + auxA <> altuera Or zabalera - auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera + auxA, zabalera - auxZ) Then
                        taula(altuera + auxA, zabalera - auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas.png")
                    End If
                End If
                If (altuera + auxA < Sistema.getTable.getAltuera()) And (zabalera + auxZ < Sistema.getTable.getZabalera()) _
                And (altuera + auxA <> altuera Or zabalera + auxZ <> zabalera) Then
                    If Not Sistema.pertsonairikDu(altuera + auxA, zabalera + auxZ) Then
                        taula(altuera + auxA, zabalera + auxZ).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas.png")
                    End If
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
        Button1.Enabled = False
        Dim fase As String = "Eraso Fasea"
        lblFase.Text = fase
        Sistema.faseAldatu(fase)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txandaAldaketa()
    End Sub

    Private Sub txandaAldaketa()
        Button1.Enabled = True
        Button2.Enabled = True
        If Sistema.currentDu() Then
            Dim k As Kasilla = Sistema.getCurrent
            Dim koordenadak() As Integer = k.getKoordenadak
            quitColors(koordenadak(0), koordenadak(1), k.getPertsonaia.getMov)
        End If
        lblFase.Text = "Hasierako Fasea"
        Sistema.txandaAldatu()
        lblTxanda.Text = Sistema.getJokalariAktibo().getIzena()
        lblAkzio.Text = Sistema.getAkzio()
    End Sub

    Private Sub pertsonaiarenDatuak(ByVal altuera As Integer, ByVal zabalera As Integer)
        If Sistema.pertsonairikDu(altuera, zabalera) Then
            Dim per As Pertsonaia = Sistema.getPertsonaia(altuera, zabalera)
            lblHp.Text = per.getHp.ToString
            lblTeam.Text = per.getTaldea
            lblAtk.Text = per.getAtk.ToString
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
            setColorRed(altuera, zabalera, Sistema.getPertsonaia(altuera, zabalera).getAlk)
        Else
            pertsonaiarenDatuak(altuera, zabalera)
        End If
    End Sub

    Private Sub mugimendua(ByVal altuera As Integer, ByVal zabalera As Integer)
        Dim k As Kasilla = Sistema.getCurrent
        Dim koordenadak() As Integer = k.getKoordenadak
        If k.getPertsonaia.mugimenduaHeltzenDa(koordenadak(0), koordenadak(1), altuera, zabalera) Then
            quitColors(koordenadak(0), koordenadak(1), k.getPertsonaia.getMov)
            pertsonaiaKokatu(altuera, zabalera, k.getPertsonaia)
            Sistema.mugitu(koordenadak(0), koordenadak(1), altuera, zabalera)
            taula(koordenadak(0), koordenadak(1)).BackgroundImage = Image.FromFile("../../../argazkiak/floresiñas.png")
            'aqui habria que cambiar al personaje de casilla
        End If
    End Sub

    Private Sub erasoa(ByVal altuera As Integer, ByVal zabalera As Integer)
        Dim k As Kasilla = Sistema.getCurrent
        Dim koordenadak() As Integer = k.getKoordenadak
        'MsgBox(k.getPertsonaia.erasoaHeltzenDa(koordenadak(0), koordenadak(1), altuera, zabalera).ToString)
        'MsgBox(Sistema.pertsonairikDu(altuera, zabalera).ToString)
        'MsgBox((Not Sistema.pertsonairikDu(altuera, zabalera)).ToString)
        If k.getPertsonaia.erasoaHeltzenDa(koordenadak(0), koordenadak(1), altuera, zabalera) _
        And Sistema.pertsonairikDu(altuera, zabalera) _
        And Not Sistema.pertsonaiAktiboaDu(altuera, zabalera) Then
            quitColors(koordenadak(0), koordenadak(1), k.getPertsonaia.getAlk)
            Sistema.eraso(altuera, zabalera)
            If Not Sistema.pertsonairikDu(altuera, zabalera) Then
                'aqui habria que quitar al personaje de dicha casilla si se ha muerto
                taula(altuera, zabalera).BackgroundImage = sgta.jokoa.My.Resources.floresiñas
                Threading.Thread.Sleep(500)
                If Sistema.getBukatu() Then
                    MsgBox("JOKOA BUKATU EGIN DA!")
                    Close()
                    sgta.jokoa.Menu.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim k As Kasilla = Sistema.getCurrent
        If Not k Is Nothing Then
            Dim koordenadak() As Integer = k.getKoordenadak
            If Sistema.getFase.Equals("Mugimendu Fasea") Then
                quitColors(koordenadak(0), koordenadak(1), k.getPertsonaia.getMov)
            ElseIf Sistema.getFase.Equals("Eraso Fasea") Then
                quitColors(koordenadak(0), koordenadak(1), k.getPertsonaia.getAlk)
            End If
            Sistema.cancelCurrent()
        End If
    End Sub

    Private Sub pertsonaiaKokatu(ByVal altuera As Integer, ByVal zabalera As Integer, ByRef p As Pertsonaia)
        Dim img As String = ""
        datuBasea.Konektatu()
        Dim dr As MySqlDataReader
        If p.GetType().Equals(GetType(Jokalari)) Then
            dr = datuBasea.PertsonaiaLortu(DirectCast(p, Jokalari).getIzena())
            If dr.Read Then
                img = dr.Item(7)
            End If
        Else
            dr = datuBasea.SoldaduakLortu(DirectCast(p, Soldadu).getTaldea(), DirectCast(p, Soldadu).getMota())
            If dr.Read Then
                img = dr.Item(7)
            End If
        End If
        taula(altuera, zabalera).BackgroundImage = Image.FromFile("../../../argazkiak/" + img + ".png")
        datuBasea.ItxiKonexioa()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Musika Kendu" Then
            s.Stop()
            Button4.Text = "Musika Jarri"
        Else
            s.Play()
            Button4.Text = "Musika Kendu"
        End If
    End Sub
End Class

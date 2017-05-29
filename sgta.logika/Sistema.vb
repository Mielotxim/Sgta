Public Class Sistema
    'AT
    Private Shared tablero As Tablero
    Private Shared jokalari As JokalariZerrenda
    Private Shared txanda As Integer
    Private Shared txandaKop As Integer
    Private Shared bukatu As Boolean
    Private Shared currentK As Kasilla
    Private Shared fasea As String
    Private Shared akzio As Integer

    'Eraikizailea
    Private Sub New()
    End Sub

    'Metodoak
    Public Shared Sub jokoaHasi(ByVal mota As String, ByVal j As JokalariZerrenda)
        tablero = TableroFactory.tableroaSortu(mota)
        tablero.bete()
        jokalari = j
        tablero.jokalariakSartu(jokalari)
        txandaKop = 0
        akzio = 3
        txandaAldatu()
        bukatu = False
    End Sub

    Public Shared Sub txandaAldatu()
        fasea = "Hasierako Fasea"
        akzio = 3
        txanda = txandaKop Mod jokalari.getKop()
        txandaKop += 1
        currentK = Nothing
    End Sub

    Public Shared Function getTable() As Tablero
        Return tablero
    End Function

    Public Shared Function getJokalariAktibo() As Jokalari
        Return jokalari.getJokalari(txanda)
    End Function

    Public Shared Function getOponeteAktibo() As Jokalari
        If txanda = 0 Then
            Return jokalari.getJokalari(1)
        Else
            Return jokalari.getJokalari(0)
        End If
    End Function

    Public Shared Sub jokoaBukatu()
        'insertar aqui avisos para la interfaz de ser necesario
        bukatu = True
    End Sub

    Public Shared Function getBukatu() As Boolean
        Return bukatu
    End Function

    Public Shared Sub setCurrentK(ByVal alt As Integer, ByVal zab As Integer)
        currentK = tablero.getKasilla(alt, zab)
    End Sub

    Public Shared Function getFase() As String
        Return fasea
    End Function

    Public Shared Sub faseAldatu(ByVal fase As String)
        fasea = fase
    End Sub

    Public Shared Function pertsonairikDu(ByVal altuera As Integer, ByVal zabalera As Integer) As Boolean
        Return tablero.pertsonairikDu(altuera, zabalera)
    End Function

    Public Shared Function pertsonaiAktiboaDu(ByVal altuera As Integer, ByVal zabalera As Integer) As Boolean
        If pertsonairikDu(altuera, zabalera) Then
            Dim per As Pertsonaia = getPertsonaia(altuera, zabalera)
            If per.ekintzaEginDezake() Then
                currentK = tablero.getKasilla(altuera, zabalera)
                Return True
            Else : Return False
            End If
        Else : Return False
        End If
    End Function

    Public Shared Function currentDu() As Boolean
        Return Not IsNothing(currentK)
    End Function

    Public Shared Function getPertsonaia(ByVal altuera As Integer, ByVal zabalera As Integer) As Pertsonaia
        Return tablero.getPertsonaia(altuera, zabalera)
    End Function

    Public Shared Function getCurrent() As Kasilla
        Return currentK
    End Function

    Public Shared Sub mugitu(ByVal altS As Integer, ByVal zabS As Integer, ByVal altI As Integer, ByVal zabI As Integer)
        Dim p As Pertsonaia = currentK.getPertsonaia
        akzio = akzio - 1
        tablero.getKasilla(altS, zabS).pertsonaiaKendu()
        tablero.getKasilla(altI, zabI).pertsonaiaSartu(p)
        currentK = Nothing
    End Sub

    Public Shared Sub eraso(ByVal altI As Integer, ByVal zabI As Integer)
        If Not pertsonaiAktiboaDu(altI, zabI) Then
            akzio = akzio - 1
            Dim p As Pertsonaia = currentK.getPertsonaia
            tablero.getKasilla(altI, zabI).eraso(p.getAtk)
            currentK = Nothing
        End If
    End Sub

    Public Shared Sub cancelCurrent()
        currentK = Nothing
    End Sub

    Public Shared Function getAkzio() As Integer
        Return akzio
    End Function

End Class

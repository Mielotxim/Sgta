Public Class Sistema
    'AT
    Private Shared tablero As Tablero
    Private Shared jokalari As JokalariZerrenda
    Private Shared txanda As Integer
    Private Shared txandaKop As Integer
    Private Shared bukatu As Boolean
    Private Shared currentK As Kasilla
    Private Shared fasea As String

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
        txandaAldatu()
        bukatu = False
    End Sub

    Public Shared Sub txandaAldatu()
        fasea = "Hasierako Fasea"
        txanda = txandaKop Mod jokalari.getKop()
        txandaKop += 1
    End Sub

    Public Shared Function getTable() As Tablero
        Return tablero
    End Function

    Public Shared Function getJokalariAktibo() As Jokalari
        Return jokalari.getJokalari(txanda)
    End Function

    Public Shared Sub jokoaBukatu()
        'insertar aqui avisos para la interfaz de ser necesario
        bukatu = True
    End Sub

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

    Public Shared Function currentDu() As Boolean
        Return Not IsNothing(currentK)
    End Function
End Class

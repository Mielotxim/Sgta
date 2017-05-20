Public Class Sistema
    'AT
    Private Shared tablero As Tablero
    Private Shared jokalari As JokalariZerrenda
    Private Shared txanda As Integer
    Private Shared txandaKop As Integer
    Private Shared bukatu As Boolean

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
        'jokatu()
    End Sub

    Public Shared Sub txandaAldatu()
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

End Class

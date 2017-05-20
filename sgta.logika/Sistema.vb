Public Class Sistema
    'AT
    Private Shared tablero As Tablero
    Private Shared jokalari As JokalariZerrenda
    Private Shared txanda As Integer
    Private Shared txandaKop As Integer

    'Eraikizailea
    Private Sub New()
    End Sub

    'Metodoak
    Public Shared Sub jokoaHasi(ByVal mota As String, ByVal j As JokalariZerrenda)
        tablero = TableroFactory.tableroaSortu(mota)
        tablero.bete()
        jokalari = j
        txandaKop = 1
        txandaAldatu()
    End Sub

    Public Shared Sub txandaAldatu()
        txanda = txandaKop Mod jokalari.getKop()
        txandaKop += 1
    End Sub

    Public Shared Function getTable() As Tablero
        Return tablero
    End Function

End Class

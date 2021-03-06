﻿Public Class Tablero
    'AT
    Private nireTablero()() As Kasilla

    'ERaikitzailea
    Public Sub New(ByVal altuera As Integer, ByVal zabalera As Integer)
        ReDim nireTablero(altuera)
        For i = 0 To altuera
            ReDim nireTablero(i)(zabalera)
        Next
    End Sub

    'Metodoak
    Public Function getAltuera() As Integer
        Return nireTablero.Length
    End Function

    Public Function getZabalera() As Integer
        Return nireTablero(0).Length
    End Function

    Public Sub bete()
        For altuera = 0 To getAltuera() - 1
            For zabalera = 0 To getZabalera() - 1
                'falta poner tipos de casillas

                nireTablero(altuera)(zabalera) = New Kasilla(altuera, zabalera)
            Next
        Next
    End Sub

    Public Sub jokalariakSartu(jokalari As JokalariZerrenda)
        'los situamos cada uno a un lado, tambien podria usarse un random para hacerlo mas aleatorio
        nireTablero(getAltuera() / 2)(1).pertsonaiaSartu(jokalari.getJokalari(0))
        nireTablero(getAltuera() / 2 + 1)(2).pertsonaiaSartu(jokalari.getJokalari(0).getArmada.getSoldadua(0))
        nireTablero(getAltuera() / 2 - 1)(2).pertsonaiaSartu(jokalari.getJokalari(0).getArmada.getSoldadua(1))
        nireTablero(getAltuera() / 2 + 1)(0).pertsonaiaSartu(jokalari.getJokalari(0).getArmada.getSoldadua(2))
        nireTablero(getAltuera() / 2 - 1)(0).pertsonaiaSartu(jokalari.getJokalari(0).getArmada.getSoldadua(3))

        nireTablero(getAltuera() / 2)(getZabalera() - 2).pertsonaiaSartu(jokalari.getJokalari(1))
        nireTablero(getAltuera() / 2 + 1)(getZabalera() - 3).pertsonaiaSartu(jokalari.getJokalari(1).getArmada.getSoldadua(0))
        nireTablero(getAltuera() / 2 - 1)(getZabalera() - 3).pertsonaiaSartu(jokalari.getJokalari(1).getArmada.getSoldadua(1))
        nireTablero(getAltuera() / 2 + 1)(getZabalera() - 1).pertsonaiaSartu(jokalari.getJokalari(1).getArmada.getSoldadua(2))
        nireTablero(getAltuera() / 2 - 1)(getZabalera() - 1).pertsonaiaSartu(jokalari.getJokalari(1).getArmada.getSoldadua(3))
    End Sub

    Function getKasilla(alt As Integer, zab As Integer) As Kasilla
        Return nireTablero(alt)(zab)
    End Function

    Function pertsonairikDu(altuera As Integer, zabalera As Integer) As Boolean
        Return nireTablero(altuera)(zabalera).pertsonaiaDu()
    End Function

    Function getPertsonaia(altuera As Integer, zabalera As Integer) As Pertsonaia
        Return nireTablero(altuera)(zabalera).getPertsonaia()
    End Function

End Class

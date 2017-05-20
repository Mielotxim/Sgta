﻿Public Class Tablero
    'AT
    Private nireTablero()() As Kasilla

    'ERaikitzailea
    Public Sub New(ByVal altuera As Integer, ByVal zabalera As Integer)
        Array.Resize(nireTablero, altuera)
        For i = 0 To altuera
            Array.Resize(nireTablero(i), zabalera)
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
        For altuera = 0 To getAltuera()
            For zabalera = 0 To getAltuera()
                'falta poner tipos de casillas
                nireTablero(altuera)(zabalera) = New Kasilla()
            Next
        Next
    End Sub

    Public Sub jokalariakSartu(jokalari As JokalariZerrenda)
        'los situamos cada uno a un lado, tambien podria usarse un random para hacerlo mas aleatorio
        nireTablero(getAltuera() / 2)(1).pertsonaiaSartu(jokalari.getJokalari(0))
        nireTablero(getAltuera() / 2)(getZabalera() - 1).pertsonaiaSartu(jokalari.getJokalari(1))
    End Sub

End Class

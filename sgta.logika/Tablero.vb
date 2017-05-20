Public Class Tablero
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

    Public Sub soldaduBerriaKokatu(ByVal soldaten As Soldadu)

    End Sub
End Class

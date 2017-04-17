Public Class Pertsonaia
    'AT'
    Private izena As String
    Private hp As Integer
    Private atk As Integer
    Private def As Integer
    Private mov As Integer
    Private arm As New Armada
    Public Sub New(ByVal iz As String, ByVal h As Integer, ByVal a As Integer, ByVal d As Integer, ByVal m As Integer)
        izena = iz
        hp = h
        atk = a
        def = d
        mov = m
    End Sub

    Public Function getIzena() As String
        Return izena
    End Function

    Public Function getHp() As Integer
        Return hp
    End Function

    Public Function getDef() As Integer
        Return def
    End Function

    Public Function getAtk() As Integer
        Return atk
    End Function

    Public Function getMov() As Integer
        Return mov
    End Function

    Public Function getArmada() As Armada
        Return arm
    End Function

End Class

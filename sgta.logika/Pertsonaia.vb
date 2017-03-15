Public Class Pertsonaia
    'AT'
    Private izena As String
    Private hp As Integer
    Private atk As Integer
    Private def As Integer

    Public Sub New(ByVal iz As String, ByVal h As Integer, ByVal a As Integer, ByVal d As Integer)
        izena = iz
        hp = h
        atk = a
        def = d
    End Sub

    Public Function getAtk() As Integer
        Return atk
    End Function

End Class

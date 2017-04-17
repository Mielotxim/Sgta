Public Class Soldadu
    Private hp As Integer
    Private atk As Integer
    Private mov As Integer
    Private mota As String
    Private alk As Integer

    Public Sub New(ByVal mot As String, ByVal h As Integer, ByVal a As Integer, ByVal al As Integer, ByVal m As Integer)
        mota = mot
        hp = h
        atk = a
        alk = al
        mov = m
    End Sub
End Class

Public Class Soldadu
    Inherits Pertsonaia

    Private mota As String

    Public Sub New(ByVal mot As String, ByVal h As Integer, ByVal a As Integer, ByVal al As Integer, ByVal m As Integer)
        MyBase.New(h, a, al, m)
        mota = m
    End Sub

End Class

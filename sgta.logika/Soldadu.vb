Public Class Soldadu
    Inherits Pertsonaia

    Private hp As Integer
    Private def As Integer
    Private atk As Integer
    Private mov As Integer
    Private mota As String
    Private alk As Integer

    Public Sub New(ByVal mot As String, ByVal h As Integer, ByVal a As Integer, ByVal al As Integer, ByVal m As Integer)
        MyBase.New(mot, h, a, al, m)
    End Sub

    Public Function getAtk() As Integer
        Return atk
    End Function

    Public Function getDef() As Integer
        Return def
    End Function

    Public Sub setAtk(ByVal a As Integer)
        atk = a
    End Sub

    Public Sub setDef(ByVal d As Integer)
        def = d
    End Sub

End Class

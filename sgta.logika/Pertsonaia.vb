Public MustInherit Class Pertsonaia
    'AT'
    Private hp As Integer
    Private def As Integer
    Private atk As Integer
    Private mov As Integer
    Private alk As Integer
    Public Sub New(ByVal h As Integer, ByVal a As Integer, ByVal d As Integer, ByVal m As Integer)
        hp = h
        atk = a
        def = d
        mov = m
    End Sub

    'cambiar los set por un atkGehitu()???
    Public Sub setDf(ByVal d As Integer)
        def = d
    End Sub
    Public Sub setAtk(ByVal a As Integer)
        atk = a
    End Sub

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

    Public Sub erasoaJaso(ByVal atkR As Integer)
        'formula provisional
        'hace falta testear el daño para hacerlo justo
        Dim var As Integer = (Math.Floor((100 - 75 + 1) * Rnd()) + 50) / 100
        hp -= (var * (25 * atkR / (def * 1.4)))
    End Sub

    Public MustOverride Function ekintzaEginDezake() As Boolean

    Public Function erasoaHeltzenDa(ByRef KasillaS As Kasilla, ByRef kasillaI As Kasilla) As Boolean
        
    End Function

End Class

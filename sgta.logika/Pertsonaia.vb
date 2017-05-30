Public MustInherit Class Pertsonaia
    'AT'
    Protected hp As Integer
    Protected taldea As String
    Protected def As Integer
    Protected atk As Integer
    Protected mov As Integer
    Protected alk As Integer

    'Eraikitzailea
    Public Sub New(ByVal h As Integer, ByVal t As String, ByVal a As Integer, ByVal d As Integer, ByVal m As Integer, ByVal al As Integer)
        hp = h
        taldea = t
        atk = a
        def = d
        mov = m
        alk = al
    End Sub

    'cambiar los set por un atkGehitu()???
    Public Sub setDf(ByVal d As Integer)
        def = d
    End Sub

    Public Function getTaldea() As String
        Return taldea
    End Function

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

    Public Function getAlk() As Integer
        Return alk
    End Function

    Public Overridable Sub erasoaJaso(ByVal atkR As Integer)
        'formula provisional
        'hace falta testear el daño para hacerlo justo
        Dim var As Integer = (Math.Floor((100 - 75 + 1) * Rnd()) + 50) / 100
        hp -= (var * (25 * atkR / (def * 1.6)))
        If hp <= 0 Then
            hp = 0
        End If
    End Sub

    Public MustOverride Function ekintzaEginDezake() As Boolean

    Public Function erasoaHeltzenDa(ByVal altS As Integer, ByVal zabS As Integer, ByVal altI As Integer, ByVal zabI As Integer) As Boolean
        If (altI >= 0 And altI <= Sistema.getTable().getAltuera()) And (zabI >= 0 And zabI <= Sistema.getTable().getZabalera()) _
        And Not (altS = altI And zabS = zabI) Then
            Dim altAux As Integer = Math.Abs(altS - altI)
            Dim zabAux As Integer = Math.Abs(zabS - zabI)
            If (altAux + zabAux <= alk) Then
                Return True
            Else : Return False
            End If
        Else
            'aqui habria que poner una excepcion
            Return False
        End If
    End Function

    Public Function mugimenduaHeltzenDa(ByVal altS As Integer, ByVal zabS As Integer, ByVal altI As Integer, ByVal zabI As Integer) As Boolean
        If (altI >= 0 And altI <= Sistema.getTable().getAltuera()) And (zabI >= 0 And zabI <= Sistema.getTable().getZabalera()) _
        And Not (altS = altI And zabS = zabI) Then
            If Not Sistema.pertsonairikDu(altI, zabI) Then
                Dim altAux As Integer = Math.Abs(altS - altI)
                Dim zabAux As Integer = Math.Abs(zabS - zabI)
                If (altAux + zabAux <= mov) Then
                    Return True
                Else : Return False
                End If
            Else : Return False
            End If
        Else
            'aqui habria que poner una excepcion
            Return False
        End If
    End Function

End Class

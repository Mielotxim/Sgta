Public Class Kasilla
    'AT
    Private per As Pertsonaia
    Private mota As String
    Private alt As Integer
    Private zab As Integer

    'Eraikitzailea
    Public Sub New(ByVal a As Integer, ByVal z As Integer)
        alt = a
        zab = z
    End Sub

    'Metodoak
    Public Sub kofre()
        If mota = "kofre" Then
            If Not per.Equals(Nothing) Then
                per.setAtk((per.getAtk + 10))
                per.setDf((per.getDef + 10))
            End If
        End If
    End Sub

    Public Sub kanpamendua(ByVal aukera As String)
        If mota = "kanpamendua" And per.GetType().Equals(GetType(Jokalari)) Then
            'Dim armada As Armada
            'hace falta un casting aqui
            'armada = CType(per, Jokalari).getArmada()
            DirectCast(per, Jokalari).soldaduaGehitu(aukera)
        End If
    End Sub

    Public Sub pertsonaiaSartu(ByVal p As Pertsonaia)
        per = p
    End Sub

    Public Function pertsonaiaDu() As Boolean
        Return Not IsNothing(per)
    End Function

    Public Function getPertsonaia() As Pertsonaia
        Return per
    End Function

    Public Function getKoordenadak() As Integer()
        Dim em(1) As Integer
        em(0) = alt
        em(1) = zab
        Return em
    End Function

    Public Sub pertsonaiaKendu()
        per = Nothing
    End Sub

    Sub eraso(ByVal atk As Integer)
        per.erasoaJaso(atk)
        If per.getHp = 0 Then
            pertsonaiaKendu()
        End If
    End Sub

End Class

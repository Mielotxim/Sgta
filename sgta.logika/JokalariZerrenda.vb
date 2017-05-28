Public Class JokalariZerrenda
    'AT
    Private jokalari(1) As Jokalari
    Private jokaKop As Integer

    'Eraikitzailea
    Public Sub New()
        jokaKop = 0
    End Sub

    'Metodoak
    Public Sub addJokalari(ByVal j As Jokalari, ByVal pos As Integer)
        If jokaKop < 2 And pos < 2 And pos > -1 Then
            jokaKop += 1
            jokalari(pos) = j
        End If
    End Sub

    Public Function getKop() As Integer
        Return jokaKop
    End Function

    Public Function getJokalari(ByVal i As Integer) As Jokalari
        If i < jokaKop Then
            Return jokalari(i)
        Else : Return Nothing
        End If
    End Function

End Class

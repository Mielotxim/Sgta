Public Class JokalariZerrenda
    'AT
    Private jokalari(1) As Jokalari
    Private jokaKop As Integer

    'Eraikitzailea
    Public Sub New()
        jokaKop = 0
    End Sub

    'Metodoak
    Public Sub addJokalari(ByVal j As Jokalari)
        '  If jokaKop < 2 Then
        'MsgBox(2)
        'jokalari(jokaKop) = j
        'MsgBox(3)
        jokaKop += 1

        'End If
        jokalari(0) = j
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

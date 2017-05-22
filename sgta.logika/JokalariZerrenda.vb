﻿Public Class JokalariZerrenda
    'AT
    Private jokalari() As Jokalari
    Private jokaKop As Integer

    'Eraikitzailea
    Public Sub New()
        jokaKop = 0
    End Sub

    'Metodoak
    Public Sub addJokalari(ByRef j As Jokalari)
        If jokaKop < 2 Then
            jokalari(jokaKop) = j
            jokaKop += 1
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

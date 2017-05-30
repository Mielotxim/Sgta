
Public Class Armada
    Private a As New SoldaduFactory
    Private listaSoldadu(9) As Soldadu 'una losta del 0 al 9 son 10 soldados
    Private solKop As Integer

    Public Sub New(ByVal taldea As String)
        listaSoldadu(0) = a.soldaduaSortu("mele", taldea)
        listaSoldadu(1) = a.soldaduaSortu("mele", taldea)
        listaSoldadu(2) = a.soldaduaSortu("sniper", taldea)
        listaSoldadu(3) = a.soldaduaSortu("tank", taldea)
        solKop = 4
    End Sub

    Public Function getSoldadua(ByVal a As Integer) As Soldadu
        If a < solKop Then
            Return listaSoldadu(a)
        Else
            Return Nothing
        End If
    End Function

    Public Sub soldaduaGehitu(ByVal s As String, ByVal taldea As String)
        If solKop < 10 Then
            Dim soldaten As Soldadu
            soldaten = a.soldaduaSortu(s, taldea)
            listaSoldadu(solKop) = soldaten
            'Tablero.soldaduBerriaKokatu(soldaten)
            solKop += 1
        End If
    End Sub

    Function soldaduaDu(ByRef soldadu As Soldadu) As Boolean
        For i = 0 To solKop - 1
            If listaSoldadu(i).Equals(soldadu) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub soldaduaKendu(ByRef sol As Soldadu)
        Dim i As Integer = 0
        Dim aurk As Boolean = False
        While i < solKop
            If listaSoldadu(i).Equals(sol) Then
                aurk = True
            End If
            If aurk Then
                If Not listaSoldadu(i + 1) Is Nothing Then
                    listaSoldadu(i) = listaSoldadu(i + 1)
                Else
                    listaSoldadu(i) = Nothing
                End If
            End If
            i += 1
        End While
        solKop -= 1
    End Sub

End Class

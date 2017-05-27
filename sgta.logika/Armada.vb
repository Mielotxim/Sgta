
Public Class Armada
    Private a As New SoldaduFactory
    Private listaSoldadu(9) As Soldadu 'una losta del 0 al 9 son 10 soldados
    Private solKop As Integer

    Public Sub New()
        listaSoldadu(0) = a.soldaduaSortu("mele")
        listaSoldadu(1) = a.soldaduaSortu("mele")
        listaSoldadu(2) = a.soldaduaSortu("sniper")
        listaSoldadu(3) = a.soldaduaSortu("tank")
        solKop = 4
    End Sub

    Public Sub soldaduaGehitu(ByVal s As String)
        If solKop < 10 Then
            Dim soldaten As Soldadu
            soldaten = a.soldaduaSortu(s)
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

    End Sub

End Class

Imports sgta.logika.SoldaduFactory
Imports sgta.logika.Tablero
Public Class Armada
    Private a As New SoldaduFactory
    Private listaSoldadu(10) As Soldadu

    Public Sub New()
        listaSoldadu(0) = a.soldaduaSortu("mele")
        listaSoldadu(1) = a.soldaduaSortu("mele")
        listaSoldadu(2) = a.soldaduaSortu("sniper")
        listaSoldadu(3) = a.soldaduaSortu("tank")
    End Sub

    Public Sub soldaduaGehitu(ByVal s As String)
        Dim aux As Boolean
        Dim index As Integer
        aux = False
        While Not aux
            If Not listaSoldadu(index).Equals(Nothing) Then
                Dim soldaten As Soldadu
                soldaten = a.soldaduaSortu(s)
                listaSoldadu(index) = soldaten
                'Tablero.soldaduBerriaKokatu(soldaten)
            End If
        End While
    End Sub
End Class

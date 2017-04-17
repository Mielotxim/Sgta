Public Class Armada
    Private a As New SoldaduFactory
    Private listaSoldadu(10) As Soldadu

    Public Sub New()
        listaSoldadu(0) = a.soldaduaSortu("mele")
        listaSoldadu(1) = a.soldaduaSortu("mele")
        listaSoldadu(2) = a.soldaduaSortu("sniper")
        listaSoldadu(3) = a.soldaduaSortu("tank")
    End Sub

End Class

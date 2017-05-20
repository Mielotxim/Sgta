Public Class Kasilla
    'AT
    Private per As Pertsonaia
    Private mota As String

    'Eraikitzailea
    Public Sub New()
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
        If mota = "kanpamendua" And TypeOf per Is Jokalari Then
            Dim armada As Armada
            'hace falta un casting aqui
            'armada = CType(per, Jokalari).getArmada()
            armada = DirectCast(per, Jokalari).getArmada()
            armada.soldaduaGehitu(aukera)
        End If
    End Sub

    Public Sub pertsonaiaSartu(ByVal p As Pertsonaia)
        per = p
    End Sub

End Class

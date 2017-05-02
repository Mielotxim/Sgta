Public Class Kasilla

    Private per As Pertsonaia
    Private sol As Soldadu
    Private mota As String

    Public Sub New()
    End Sub

    Public Sub kofre()
        If mota = "kofre" Then
            If Not per.Equals(Nothing) Then
                per.setAtk((per.getAtk + 10))
                per.setDf((per.getDef + 10))
            ElseIf Not sol.Equals(Nothing) Then
                sol.setAtk((sol.getAtk + 5))
                sol.setDef((sol.getDef + 5))
            End If
        End If
    End Sub

    Public Sub kanpamendua(ByRef aukera As String)
        If mota = "kanpamendua" Then
            Dim armada As Armada
            armada = per.getArmada
            armada.soldaduaGehitu(aukera)
        End If
    End Sub

End Class

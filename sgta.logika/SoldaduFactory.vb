Public Class SoldaduFactory
    Public Sub New()
    End Sub

    Public Function soldaduaSortu(ByVal mota As String) As Soldadu
        Dim s As Soldadu

        If mota = "mele" Then
            s = New Soldadu("mele", 20, 10, 1, 2)
        ElseIf mota = "sniper" Then
            s = New Soldadu("sniper", 15, 20, 15, 5)
        Else
            s = New Soldadu("tank", 50, 15, 4, 3)
        End If
        Return s
    End Function
End Class

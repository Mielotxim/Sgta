Public Class SoldaduFactory
    Public Sub New()
    End Sub

    Public Function soldaduaSortu(ByVal mota As String, ByVal taldea As String) As Soldadu
        Dim s As Soldadu
        If mota = "mele" Then
            s = New Soldadu("mele", 20, taldea, 10, 1, 2, 2)
        ElseIf mota = "sniper" Then
            s = New Soldadu("sniper", 15, taldea, 20, 15, 5, 2)
        Else
            s = New Soldadu("tank", 50, taldea, 15, 4, 3, 2)
        End If
        Return s
    End Function
End Class

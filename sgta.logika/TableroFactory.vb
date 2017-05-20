Public Class TableroFactory

    Private Sub New()
    End Sub

    Public Shared Function tableroaSortu(ByVal mota As String) As Tablero
        Dim t As Tablero = Nothing
        'medidas temporales
        Select Case mota
            Case "Erraza"
                t = New Tablero(10, 10)
            Case "Normala"
                t = New Tablero(30, 30)
            Case "Zaila"
                t = New Tablero(50, 50)
        End Select
        Return t
    End Function
End Class

Imports sgta.db, MySql.Data.MySqlClient
Public Class SoldaduFactory
    Public Sub New()
    End Sub

    Public Function soldaduaSortu(ByVal mota As String, ByVal taldea As String) As Soldadu
        datuBasea.Konektatu()
        Dim dr As MySqlDataReader = datuBasea.SoldaduakLortu(taldea, mota)
        Dim j As Soldadu = Nothing
        If dr.Read Then
            Dim iz As String = dr.Item(0)
            Dim tal As String = dr.Item(1)
            Dim hp As Integer = dr.Item(2)
            Dim atk As Integer = dr.Item(3)
            Dim def As Integer = dr.Item(4)
            Dim mov As Integer = dr.Item(5)
            Dim alk As Integer = dr.Item(6)
            j = New Soldadu(iz, hp, tal, atk, def, mov, alk)
        End If
        datuBasea.ItxiKonexioa()
        Return j
    End Function
End Class

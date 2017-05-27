Public Class Jokalari
    Inherits Pertsonaia
    'AT
    Private izena As String
    Private arm As New Armada

    'Eraikitzailea
    Public Sub New(ByVal iz As String, ByVal h As Integer, ByVal a As Integer, ByVal d As Integer, ByVal m As Integer)
        MyBase.New(h, a, d, m)
        izena = iz
    End Sub

    Public Function getIzena() As String
        Return izena
    End Function

    Public Function nireSoldaduaDa(ByRef soldadu As Soldadu) As Boolean
        Return arm.soldaduaDu(soldadu)
    End Function

    Public Overrides Function ekintzaEginDezake() As Boolean
        Return Me.Equals(Sistema.getJokalariAktibo())
    End Function

    Public Overloads Function Equals(ByRef jok As Jokalari) As Boolean
        Return jok.izena.Equals(Me.izena)
    End Function

    Public Sub soldaduaGehitu(ByVal aukera As String)
        arm.soldaduaGehitu(aukera)
    End Sub

    Public Sub soldaduaKendu(ByVal sol As Soldadu)
        arm.soldaduaKendu(sol)
    End Sub

    Public Overrides Sub erasoaJaso(ByVal atkR As Integer)
        'formula provisional
        'hace falta testear el daño para hacerlo justo
        MyBase.erasoaJaso(atkR)
        If hp = 0 Then
            Sistema.jokoaBukatu()
        End If
    End Sub

End Class

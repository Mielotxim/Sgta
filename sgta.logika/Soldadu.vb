﻿Public Class Soldadu
    Inherits Pertsonaia

    Private mota As String

    Public Sub New(ByVal mot As String, ByVal h As Integer, ByVal t As String, ByVal a As Integer, ByVal d As Integer, ByVal m As Integer, ByVal al As Integer)
        MyBase.New(h, t, a, d, m, al)
        mota = mot
    End Sub

    Public Overrides Function ekintzaEginDezake() As Boolean
        Return Sistema.getJokalariAktibo().nireSoldaduaDa(Me)
    End Function

    Public Function getMota() As String
        Return mota
    End Function

    Public Overrides Sub erasoaJaso(ByVal atkR As Integer)
        'formula provisional
        'hace falta testear el daño para hacerlo justo
        MyBase.erasoaJaso(atkR)
        If hp = 0 Then
            Sistema.getOponeteAktibo().soldaduaKendu(Me)
        End If
    End Sub

End Class

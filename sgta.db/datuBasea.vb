Imports System.Data.SqlClient

Public Class datuBasea

    Private Shared conn As SqlConnection

    Private Sub New()
    End Sub

    Public Shared Sub Konektatu()
        Dim strcon As String =
            "Server=127.0.0.1;Database=sgtaforce;Integrated Security=False;Uid=root;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
        Console.WriteLine(strcon)
        Try
            conn = New SqlConnection(strcon)
            Console.WriteLine("konektatzen...")
            conn.Open()
            Console.WriteLine("konektatuta")
        Catch ex As Exception
            Console.WriteLine("konekzio errorea")
            Throw New ErroreaKonektatzean()
        End Try
        Console.WriteLine("bukatuta")
    End Sub

    Public Shared Sub ItxiKonexioa()
        conn.Close()
    End Sub

    Public Shared Function PertsonaiakLortu() As SqlDataReader
        Dim cmdPertsonaiak As SqlCommand
        Dim strSQL = "SELECT * FROM Pertsonaia"
        cmdPertsonaiak = New SqlCommand(strSQL, conn)
        Return (cmdPertsonaiak.ExecuteReader())
    End Function
End Class

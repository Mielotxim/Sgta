Imports MySql.Data.MySqlClient

Public Class datuBasea

    Private Shared conn As MySqlConnection

    Private Sub New()
    End Sub

    Public Shared Sub Konektatu()
        Dim strcon As String =
            "Server=127.0.0.1;DataBase=sgtaforce;uid=root;pwd="
        Console.WriteLine(strcon)
        Try
            conn = New MySqlConnection(strcon)
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

    Public Shared Function PertsonaiakLortu() As MySqlDataReader
        Dim cmdPertsonaiak As MySqlCommand
        Dim strSQL = "SELECT * FROM Pertsonaia"
        cmdPertsonaiak = New MySqlCommand(strSQL, conn)
        Return (cmdPertsonaiak.ExecuteReader())
    End Function
End Class

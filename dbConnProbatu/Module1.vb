Imports sgta.db
Imports System.Data.SqlClient

Module Module1

    Sub Main()
        Console.WriteLine("konexioa zabaltzen....")
        datuBasea.Konektatu()
        Console.WriteLine("konexioa zabalduta")
        Dim pertsonaia As SqlDataReader = datuBasea.PertsonaiakLortu()
        pertsonaia.Read()
        Console.WriteLine(pertsonaia.Item(1).ToString)
        pertsonaia.Close()
        datuBasea.ItxiKonexioa()
    End Sub

End Module

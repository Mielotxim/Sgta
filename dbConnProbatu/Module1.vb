Imports sgta.db
Imports MySql.Data.MySqlClient

Module Module1

    Sub Main()
        Console.WriteLine("konexioa zabaltzen....")
        datuBasea.Konektatu()
        Console.WriteLine("konexioa zabalduta")
        Dim pertsonaia As MySqlDataReader = datuBasea.PertsonaiakLortu()
        pertsonaia.Read()
        Console.WriteLine(pertsonaia.Item(0).ToString)
        Console.WriteLine("sakatu enter jarraitzeko")
        Console.ReadLine()
        pertsonaia.Close()
        datuBasea.ItxiKonexioa()
    End Sub

End Module

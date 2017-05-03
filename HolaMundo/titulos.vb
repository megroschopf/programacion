Module titulos
    Sub main()
        Dim fecha As Date = Date.Now
        Console.WriteLine("Dia del año: " & fecha.Day())
        Console.WriteLine("Mes del año: " & fecha.Month())
        Console.WriteLine("Hora: " & fecha.Hour())
        Console.WriteLine("Minuto: " & fecha.Minute)
        Console.ReadKey()
    End Sub
End Module

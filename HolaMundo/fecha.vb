Module fecha
    Sub main()
        Dim fecha As Date = Date.MinValue
        Dim dias As UShort = 0
        Console.WriteLine("Ingrese una fecha: ")
        fecha = Console.ReadLine
        Console.WriteLine("ingrese cantidad de dias a sumar: ")
        dias = Console.ReadLine
        Console.WriteLine("Nueva fecha: " & DateAdd(DateInterval.Day, dias, fecha))
        Console.ReadKey()
    End Sub
End Module

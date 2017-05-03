Module SumarFecha
    Sub main()
        Dim fecha As Date = Date.MinValue
        Dim dias As Integer = 0
        Console.WriteLine("Ingrese Fecha: ")
        fecha = Console.ReadLine
        Console.WriteLine("Ingrese Dias: ")
        dias = Console.ReadLine
        Console.WriteLine("Nueva Fecha: " & sumarfechas(fecha, dias))
        Console.ReadKey()
    End Sub
    Function sumarfechas(fecha As Date, dias As Integer) As Date
        Return fecha.AddDays(dias)
    End Function
End Module

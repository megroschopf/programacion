Module fecha2
    Enum dias_de_semana
        Domingo = 0
        Lunes = 1
        Martes = 2
        Miercoles = 3
        Jueves = 4
        Viernes = 5
        Sabado = 6
    End Enum
    Sub main()
        Dim fecha As Date = Date.MinValue
        Dim dias As UShort = 0
        Dim dia_semana As dias_de_semana
        Dim dia_semana_nombre As String = ""
        Console.WriteLine("Ingrese una fecha: ")
        fecha = Console.ReadLine
        Console.WriteLine("ingrese cantidad de dias a sumar: ")
        dias = Console.ReadLine
        fecha = DateAdd(DateInterval.Day, dias, fecha)
        dia_semana = fecha.DayOfWeek
        'dia_semana_nombre = dia_semana.ToString
        Console.WriteLine("Nueva fecha: {0} {1} de {2} de {3}", dia_semana.ToString, fecha.Day, fecha.Month, fecha.Year)
        Console.ReadKey()
    End Sub
End Module

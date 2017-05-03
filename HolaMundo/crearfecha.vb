Module crearfecha
    Sub main()
        Dim dia, hora As Byte
        Console.WriteLine("Ingrese un numero de dias: ")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese un numero de horas: ")
        hora = Console.ReadLine()
        Dim fecha As New Date(Today.Year, Today.Month, dia, hora, Today.Minute, Today.Second)
        Console.WriteLine("Fecha completa: " & fecha)
        Console.ReadKey()
    End Sub
End Module

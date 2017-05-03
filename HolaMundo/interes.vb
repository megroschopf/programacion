Module interes
    Sub main()
        Dim m, r, t As Integer
        Dim i As Single
        Console.WriteLine("Introduzca un monto: ")
        m = Console.ReadLine()
        Console.WriteLine("Introduzca el interes anual: ")
        r = Console.ReadLine()
        Console.WriteLine("Introduzca cantidad de dias: ")
        t = Console.ReadLine()
        i = (m * r * t) / (360 * 100)
        Console.WriteLine("El interes es de: " & i)
        Console.WriteLine("El capital acumulado es: " & (m + (i / 100 * m)))
        Console.ReadKey()
    End Sub
End Module

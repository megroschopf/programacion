Module aproximacion
    Sub main()
        Dim numero As Double
        Console.WriteLine("Ingrese un numero: ")
        numero = Console.ReadLine()
        Console.WriteLine("Valor aproximado por exceso: " & Math.Abs(numero - Math.Ceiling(numero)))
        Console.WriteLine("Valor aproximado por definicion: " & Math.Abs(numero - Math.Floor(numero)))
        Console.WriteLine("Redondeo por exceso: " & Math.Ceiling(numero))
        Console.WriteLine("Redondeo por definicion: " & Math.Floor(numero))
        Console.WriteLine("Redondeo: " & Math.Round(numero))
        Console.ReadKey()
    End Sub
End Module

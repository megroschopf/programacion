Module Suma
    Sub main()
        'Dim numero As Integer = 0
        'For x = 1 To 4
        '    Console.WriteLine("Ingrese un numero: ")
        '    numero += Console.ReadLine
        'Next
        Dim numero1, numero2, numero3, numero4 As Integer
        Console.WriteLine("Ingrese un numero1: ")
        numero1 += Console.ReadLine
        Console.WriteLine("Ingrese un numero2: ")
        numero2 += Console.ReadLine
        Console.WriteLine("Ingrese un numero3: ")
        numero3 += Console.ReadLine
        Console.WriteLine("Ingrese un numero4: ")
        numero4 += Console.ReadLine
        Console.WriteLine("Suma de todos los numeros: " & numero1 + numero2 + numero3 + numero4)
        Console.WriteLine("La media de esos numeros es: " & (numero1 + numero2 + numero3 + numero4) / 2)
        Console.ReadKey()
    End Sub
End Module

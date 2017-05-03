Module maximo
    Sub main()
        Dim numero1, numero2, numero3 As Integer
        Console.WriteLine("Ingrese un numero: ")
        numero1 = Console.ReadLine()
        Console.WriteLine("Ingrese un segundo numero: ")
        numero2 = Console.ReadLine()
        Console.WriteLine("Ingrese un tercer numero numero: ")
        numero3 = Console.ReadLine()
        Console.WriteLine("El mayor de los tres numeros ingresados es: " & (Math.Max(numero3, (Math.Max(numero1, numero2)))))
        Console.ReadKey()
    End Sub
End Module

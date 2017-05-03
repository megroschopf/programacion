Module absoluto
    Sub main()
        Dim numero As Integer
        Console.WriteLine("Ingrese un numero: ")
        numero = Console.ReadLine()
        numero = Math.Abs(numero)
        Console.WriteLine("El valor absoluto del numero ingresado es: " & numero)
        Console.WriteLine("El valor de la decima potencia de {0} es: " & (numero ^ 10), numero)
        Console.WriteLine("El valor de la raiz cuadrada de {0} es: " & Math.Sqrt(numero), numero)
        Console.ReadKey()
    End Sub
End Module

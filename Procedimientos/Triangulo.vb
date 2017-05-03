Module Triangulo
    Sub main()
        'hola
        Dim numero1, numero2 As Single
        Console.WriteLine("Ingese el valor del lado A: ")
        numero1 = Console.ReadLine
        numero1 = validar_valor(numero1, "A")
        Console.WriteLine("Ingese el valor del lado B: ")
        numero2 = Console.ReadLine
        numero2 = validar_valor(numero2, "B")
        Console.WriteLine("El valor de la Hipotenusa(C) es: " & calcular(numero1, numero2))
        Console.ReadKey()
    End Sub
    Function validar_valor(numero As Single, lado As String) As Integer
        Do Until numero > 0 And numero = Int(numero)
            Console.WriteLine("Valor incorrecto {0}. Ingese un nuevo numero que sea positivo entero: ", lado)
            numero = Console.ReadLine
        Loop
        Return numero
    End Function
    Function calcular(numero1 As Single, numero2 As Single) As Single
        Return Math.Sqrt(Math.Pow(numero1, 2) + Math.Pow(numero2, 2))
    End Function
End Module

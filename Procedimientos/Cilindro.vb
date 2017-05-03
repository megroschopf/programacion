Module Cilindro
    Sub main()
        Dim base, altura As Single
        Console.WriteLine("Ingese base: ")
        base = Console.ReadLine
        validar_valor(base, "Base")
        Console.WriteLine("Ingese altura: ")
        altura = Console.ReadLine
        validar_valor(altura, "Altura")
        Console.WriteLine("El volumen de cilindro es es: " & calcular(base, altura))
        Console.ReadKey()
    End Sub
    Sub validar_valor(ByRef numero As Single, lado As String) ' As Integer
        Do Until numero > 0
            Console.WriteLine("Valor incorrecto {0}. Ingese un nuevo numero que sea positivo entero: ", lado)
            numero = Console.ReadLine
        Loop
        'Return numero
    End Sub
    Function calcular(numero1 As Single, numero2 As Single) As Single
        Return Math.PI * Math.Pow(numero1, 2) * numero2
    End Function
End Module

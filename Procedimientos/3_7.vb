Module _3_7
    Enum operaciones
        Suma = 1
        Resta = 2
        Multiplicacion = 3
        Division = 4
    End Enum
    Sub main()
        Console.WriteLine("Resultado: " & calcular(operaciones.Division, 1, 2))
        Console.WriteLine("Resultado: " & calcular(operaciones.Resta, 1, 2, 3))
        Console.WriteLine("Resultado: " & calcular(operaciones.Multiplicacion, 1, 2, 3, 4))
        Console.WriteLine("Resultado: " & calcular(1, 2))
        Console.WriteLine("Resultado: " & calcular(1, 2, 3))
        Console.WriteLine("Resultado: " & calcular(1, 2, 3, 4))
        Console.ReadKey()
    End Sub
    Private Function calcular(operacion As operaciones, numero1 As Single, numero2 As Single) As Single
        Dim resultado As Single
        Select Case operacion
            Case Is = 1
                Return numero1 + numero2
            Case Is = 2
                Return numero1 - numero2
            Case Is = 3
                Return numero1 * numero2
            Case Is = 4
                Return numero1 / numero2
        End Select
        Return resultado
    End Function
    Private Function calcular(operacion As operaciones, numero1 As Single, numero2 As Single, numero3 As Single) As Single
        Dim resultado As Single
        Select Case operacion
            Case Is = 1
                Return calcular(operacion, numero1, numero2) + numero3
            Case Is = 2
                Return calcular(operacion, numero1, numero2) - numero3
            Case Is = 3
                Return calcular(operacion, numero1, numero2) * numero3
            Case Is = 4
                Return calcular(operacion, numero1, numero2) / numero3
        End Select
        'Return resultado
    End Function
    Private Function calcular(operacion As operaciones, numero1 As Single, numero2 As Single, numero3 As Single, numero4 As Single) As Single
        Dim resultado As Single
        Select Case operacion
            Case Is = 1
                Return calcular(operacion, numero1, numero2, numero3) + numero4
            Case Is = 2
                Return calcular(operacion, numero1, numero2, numero3) - numero4
            Case Is = 3
                Return calcular(operacion, numero1, numero2, numero3) * numero4
            Case Is = 4
                Return calcular(operacion, numero1, numero2, numero3) / numero4
        End Select
        Return resultado
    End Function
    Private Function calcular(numero1 As Single, numero2 As Single) As Single
        Return calcular(operaciones.Suma, numero1, numero2)
    End Function
    Private Function calcular(numero1 As Single, numero2 As Single, numero3 As Single) As Single
        Return calcular(operaciones.Suma, numero1, numero2, numero3)
    End Function
    Private Function calcular(numero1 As Single, numero2 As Single, numero3 As Single, numero4 As Single) As Single
        Return calcular(operaciones.Suma, numero1, numero2, numero3, numero4)
    End Function
End Module

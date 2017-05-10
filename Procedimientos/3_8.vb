Module _3_8
    Enum operaciones
        Suma = 1
        Resta = 2
        Multiplicacion = 3
        Division = 4
    End Enum
    Sub main()
        mostrar_operacion(operaciones.Division, 1, 2)
        mostrar_operacion(operaciones.Resta, 1, 2, 3)
        mostrar_operacion(operaciones.Multiplicacion, 1, 2, 3, 4)
        mostrar_operacion(1, 2)
        mostrar_operacion(1, 2, 3)
        mostrar_operacion(1, 2, 3, 4)
        Console.ReadKey()
    End Sub
    Private Function calcular(operacion As operaciones, numero1 As Single, numero2 As Single) As Single
        ' Dim resultado As Single
        Select Case operacion
            Case Is = 1
                Return numero1 + numero2
            Case Is = 2
                Return numero1 - numero2
            Case Is = 3
                Return numero1 * numero2
            Case Is = 4
                Return numero1 / numero2
            Case Else
                Return Nothing
        End Select
        '  Return resultado
    End Function
    Private Function calcular(operacion As operaciones, numero1 As Single, numero2 As Single, numero3 As Single) As Single
        'Dim resultado As Single
        Select Case operacion
            Case Is = 1
                Return calcular(operacion, numero1, numero2) + numero3
            Case Is = 2
                Return calcular(operacion, numero1, numero2) - numero3
            Case Is = 3
                Return calcular(operacion, numero1, numero2) * numero3
            Case Is = 4
                Return calcular(operacion, numero1, numero2) / numero3
            Case Else
                Return Nothing
        End Select
        ' Return resultado
    End Function
    Private Function calcular(operacion As operaciones, numero1 As Single, numero2 As Single, numero3 As Single, numero4 As Single) As Single
        ' Dim resultado As Single
        Select Case operacion
            Case Is = 1
                Return calcular(operacion, numero1, numero2, numero3) + numero4
            Case Is = 2
                Return calcular(operacion, numero1, numero2, numero3) - numero4
            Case Is = 3
                Return calcular(operacion, numero1, numero2, numero3) * numero4
            Case Is = 4
                Return calcular(operacion, numero1, numero2, numero3) / numero4
            Case Else
                Return Nothing
        End Select
        '  Return resultado
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
    Private Sub mostrar_operacion(operacion As operaciones, numero1 As Single, numero2 As Single)
        Select Case operacion
            Case Is = 1
                Console.WriteLine(" {0} + {1} = {2} ", numero1, numero2, (calcular(operacion, numero1, numero2)))
            Case Is = 2
                Console.WriteLine(" {0} - {1} = {2}", numero1, numero2, (calcular(operacion, numero1, numero2)))
            Case Is = 3
                Console.WriteLine(" {0} * {1} = {2}", numero1, numero2, (calcular(operacion, numero1, numero2)))
            Case Is = 4
                Console.WriteLine(" {0} / {1} = {2}", numero1, numero2, (calcular(operacion, numero1, numero2)))
        End Select
    End Sub
    Private Sub mostrar_operacion(operacion As operaciones, numero1 As Single, numero2 As Single, numero3 As Single)
        Select Case operacion
            Case Is = 1
                Console.WriteLine(" {0} + {1} + {2} = {3} ", numero1, numero2, numero3, (calcular(operacion, numero1, numero2, numero3)))
            Case Is = 2
                Console.WriteLine(" {0} - {1} - {2} = {3}", numero1, numero2, numero3, (calcular(operacion, numero1, numero2, numero3)))
            Case Is = 3
                Console.WriteLine(" {0} * {1} * {2} = {3}", numero1, numero2, numero3, (calcular(operacion, numero1, numero2, numero3)))
            Case Is = 4
                Console.WriteLine(" {0} / {1} / {2} = {3}", numero1, numero2, numero3, (calcular(operacion, numero1, numero2, numero3)))
        End Select
    End Sub
    Private Sub mostrar_operacion(operacion As operaciones, numero1 As Single, numero2 As Single, numero3 As Single, numero4 As Single)
        Select Case operacion
            Case Is = 1
                Console.WriteLine(" {0} + {1} + {2} + {3} = {4}", numero1, numero2, numero3, numero4, (calcular(operacion, numero1, numero2, numero3, numero4)))
            Case Is = 2
                Console.WriteLine(" {0} - {1} - {2} - {3} = {4}", numero1, numero2, numero3, numero4, (calcular(operacion, numero1, numero2, numero3, numero4)))
            Case Is = 3
                Console.WriteLine(" {0} * {1} * {2} * {3} = {4}", numero1, numero2, numero3, numero4, (calcular(operacion, numero1, numero2, numero3, numero4)))
            Case Is = 4
                Console.WriteLine(" {0} / {1} / {2} / {3} = {4}", numero1, numero2, numero3, numero4, (calcular(operacion, numero1, numero2, numero3, numero4)))
        End Select
    End Sub
    Private Sub mostrar_operacion(numero1 As Single, numero2 As Single)
        Console.WriteLine(" {0} + {1} = {2} ", numero1, numero2, (calcular(operaciones.Suma, numero1, numero2)))
    End Sub
    Private Sub mostrar_operacion(numero1 As Single, numero2 As Single, numero3 As Single)
        Console.WriteLine(" {0} + {1} + {2} = {3}", numero1, numero2, numero3, (calcular(operaciones.Suma, numero1, numero2, numero3)))
    End Sub
    Private Sub mostrar_operacion(numero1 As Single, numero2 As Single, numero3 As Single, numero4 As Single)
        Console.WriteLine(" {0} + {1} + {2} + {3} = {4}", numero1, numero2, numero3, numero4, (calcular(operaciones.Suma, numero1, numero2, numero3, numero4)))
    End Sub
End Module

Module Fibonacci
    Sub main()
        Dim numero1, numero2, resultado As UShort
        For contador = 1 To 20
            If contador = 1 Then
                numero1 = 0
                Console.WriteLine(numero1)
            ElseIf contador = 2 Then
                numero2 = 1
                Console.WriteLine(numero2)
            Else
                resultado = numero1 + numero2
                Console.WriteLine(resultado)
                numero1 = numero2
                numero2 = resultado
            End If
        Next
        Console.ReadKey()
    End Sub
End Module

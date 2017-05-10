Module _3_6
    Sub main()
        Dim numero As Integer
        Dim sumatoria As Integer
        Console.WriteLine("Ingrese numero entero positivo: ")
        numero = ingresar_numero()
        sumar(sumatoria, numero)
        Console.WriteLine("La sumatoria es: " & sumatoria)
        Console.ReadKey()
    End Sub
    Private Function ingresar_numero() As Integer
        Dim numero As Single
        Do
            numero = Console.ReadLine()
        Loop Until validar_numero(numero)
        Return numero
    End Function
    Private Function validar_numero(numero As Single) As Boolean
        Return numero > 0 And numero = Int(numero)
    End Function
    Private Sub sumar(ByRef sumatoria As Integer, ByVal numero As Integer)
        For contador As Integer = 1 To numero
            sumatoria += Math.Pow(contador, 2)
        Next
    End Sub
End Module

Module _3_9
    Sub main()
        Dim numero1, numero2, numero3 As Single
        numero1 = ingresar_numero()
        Console.WriteLine(calcular_area(numero1))
        numero2 = ingresar_numero()
        Console.WriteLine(calcular_area(numero1, numero2))
        numero3 = ingresar_numero()
        Console.WriteLine(calcular_area(numero1, numero2, numero3))
        Console.ReadKey()
    End Sub
    Private Function ingresar_numero() As Single
        mostrar_mensaje("ingrese un numero: ")
        Return Console.ReadLine()
    End Function
    Private Sub mostrar_mensaje(mensaje As String)
        Console.WriteLine(mensaje)
    End Sub
    Private Function calcular_area(lado As Single) As Single
        mostrar_titulo(1)
        Return lado * lado
    End Function
    Private Function calcular_area(base As Single, altura As Single) As Single
        mostrar_titulo(2)
        Return base * altura
    End Function
    Private Function calcular_area(base As Single, techo As Single, altura As Single) As Single
        mostrar_titulo(3)
        Return (base + techo) / 2 * altura
    End Function
    Private Sub mostrar_titulo(operacion As Byte)
        Select Case operacion
            Case 1
                mostrar_mensaje("Cuadrado")
            Case 2
                mostrar_mensaje("Rectangulo")
            Case 3
                mostrar_mensaje("Trapecio")
        End Select
    End Sub
End Module

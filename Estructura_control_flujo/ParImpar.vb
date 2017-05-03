Module ParImpar
    Sub main()
        Dim numero, par, impar As Integer
        Console.WriteLine("Ingrese un numero o 0(cero) para salir: ")
        Do
            numero = Console.ReadLine()
            If numero <> 0 Then
                If numero > 0 Then
                    If numero Mod 2 = 0 Then
                        par = par + 1
                    Else
                        impar = impar + 1
                    End If
                End If
            End If
        Loop Until numero = 0
        If impar = 0 Then
            Console.WriteLine("Todos los numeros son pares.")
            'Console.WriteLine("Cantidad de pares: " & par)
        ElseIf par = 0 Then
            Console.WriteLine("Todos los numeros son impares.")
            'Console.WriteLine("Cantidad de impares: " & impar)
        Else
            Console.WriteLine("Cantidad de pares: " & par)
            Console.WriteLine("Cantidad de impares: " & impar)
        End If
        Console.ReadKey()
    End Sub
End Module

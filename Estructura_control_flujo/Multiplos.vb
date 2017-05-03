Module Multiplos
    Sub main()
        Dim numero1, inicio, numero2, cantidad As Integer
        Console.WriteLine("Ingrese primer numero: ")
        numero1 = Console.ReadLine
        Console.WriteLine("Ingrese segundo numero: ")
        numero2 = Console.ReadLine
        inicio = numero1
        cantidad = 0
        Do While inicio <= numero2
            If inicio Mod 5 = 0 Then
                cantidad = cantidad + 1
            End If
            inicio = inicio + 1
        Loop
        Console.WriteLine("Cantidad de numeros multiplos de 5: " & cantidad)
        inicio = numero1
        cantidad = 0
        Do Until inicio > numero2
            If inicio Mod 5 = 0 Then
                cantidad = cantidad + 1
            End If
            inicio = inicio + 1
        Loop
        Console.WriteLine("Cantidad de numeros multiplos de 5: " & cantidad)
        inicio = numero1
        cantidad = 0
        Do
            If inicio Mod 5 = 0 Then
                cantidad = cantidad + 1
            End If
            inicio = inicio + 1
        Loop While inicio <= numero2
        Console.WriteLine("Cantidad de numeros multiplos de 5: " & cantidad)
        inicio = numero1
        cantidad = 0
        Do
            If inicio Mod 5 = 0 Then
                cantidad = cantidad + 1
            End If
            inicio = inicio + 1
        Loop Until inicio > numero2
        Console.WriteLine("Cantidad de numeros multiplos de 5: " & cantidad)
        Console.ReadKey()
    End Sub
End Module

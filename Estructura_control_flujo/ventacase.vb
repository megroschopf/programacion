Module ventacase
    Sub main()
        Dim cantidad As Integer
        Dim precio_unitario, descuento, subtotal, monto_descuento As Single
        Console.WriteLine("Ingrese cantidad: ")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese precio unitario: ")
        precio_unitario = Console.ReadLine()
        subtotal = cantidad * precio_unitario
        Select cantidad
            Case 10 To 50
                descuento = 5
            Case 51 To 250
                descuento = 10
            Case Is >= 251
                descuento = 20
        End Select
        Console.WriteLine("Subtotal: " & (cantidad * precio_unitario))
        Console.WriteLine("El porcentaje de descuento es: {0}%", descuento)
        monto_descuento = subtotal * descuento / 100
        Console.WriteLine("Monto del descuento: " & monto_descuento)
        Console.WriteLine("Total: " & (subtotal - monto_descuento))
        'Console.WriteLine("Monto del descuento: " & ((cantidad * precio_unitario) * descuento / 100))
        'Console.WriteLine("Total: " & (cantidad * precio_unitario - (cantidad * precio_unitario) * descuento / 100))
        Console.ReadKey()
    End Sub
End Module

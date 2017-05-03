Module VentaLoop
    Sub main()
        Dim cantidad As Integer
        Dim precio_unitario, descuento, subtotal, monto_descuento, total_descuento, total_cobrar As Single
        Do
            Console.WriteLine("Ingrese cantidad: ")
            cantidad = Console.ReadLine()
            If cantidad <> 0 Then
                Console.WriteLine("Ingrese precio unitario: ")
                precio_unitario = Console.ReadLine()
                subtotal = cantidad * precio_unitario
                If cantidad >= 10 And cantidad <= 50 Then
                    descuento = 5
                ElseIf cantidad >= 51 And cantidad <= 250 Then
                    descuento = 10
                ElseIf cantidad >= 251 Then
                    descuento = 20
                End If
                Console.WriteLine("Subtotal: " & (cantidad * precio_unitario))
                Console.WriteLine("El porcentaje de descuento es: {0}%", descuento)
                monto_descuento = subtotal * descuento / 100
                Console.WriteLine("Monto del descuento: " & monto_descuento)
                Console.WriteLine("Total: " & (subtotal - monto_descuento))
                Console.WriteLine("-----------------------------------------------")
                total_descuento = total_descuento + monto_descuento
                total_cobrar = total_cobrar + subtotal
            End If
        Loop Until cantidad = 0
        Console.WriteLine("-----------------------------------------------")
        If subtotal <> 0 Then
            Console.WriteLine("Total Monto de descuento: " & total_descuento)
            Console.WriteLine("Total a cobrar: " & total_cobrar - total_descuento)
        Else
            Console.WriteLine("No se realizo compra.")
        End If
        'Console.WriteLine("Monto del descuento: " & ((cantidad * precio_unitario) * descuento / 100))
        'Console.WriteLine("Total: " & (cantidad * precio_unitario - (cantidad * precio_unitario) * descuento / 100))
        Console.ReadKey()
    End Sub
End Module

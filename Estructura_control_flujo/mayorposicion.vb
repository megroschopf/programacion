Module mayorposicion
    Enum posicion
        Primero = 1
        Segundo = 2
        Tercero = 3
        Cuarto = 4
        Quinto = 5
    End Enum
    Sub Main()
        Dim numero1, mayor As Integer
        Dim posicion As posicion
        Console.WriteLine("Ingrese el primer numero: ")
        numero1 = Console.ReadLine()
        mayor = numero1
        posicion = 1
        Console.WriteLine("Ingrese el segundo numero: ")
        numero1 = Console.ReadLine()
        If numero1 > mayor Then
            mayor = numero1
            posicion = 2
        End If
        Console.WriteLine("Ingrese el tercer numero: ")
        numero1 = Console.ReadLine()
        If numero1 > mayor Then
            mayor = numero1
            posicion = 3
        End If
        Console.WriteLine("Ingrese el cuarto numero: ")
        numero1 = Console.ReadLine()
        If numero1 > mayor Then
            mayor = numero1
            posicion = 4
        End If
        Console.WriteLine("Ingrese el quinto numero: ")
        numero1 = Console.ReadLine()
        If numero1 > mayor Then
            mayor = numero1
            posicion = 5
        End If
        Console.WriteLine("El {0} es el mayor valor", posicion.ToString)
        Console.ReadKey()
    End Sub
End Module

Module Aritmetica
    Sub main()
        Dim numero_entero1, numero_entero2 As Integer
        Dim numero_flotante1, numero_flotante2 As Single
        Console.WriteLine("Ingrese primer Numero Entero")
        numero_entero1 = Console.ReadLine
        Console.WriteLine("Ingrese segundo Numero Entero")
        numero_entero2 = Console.ReadLine
        Console.WriteLine("Ingrese primer Numero Flotante")
        numero_flotante1 = Console.ReadLine
        Console.WriteLine("Ingrese segundo Numero Flotante")
        numero_flotante2 = Console.ReadLine
        Console.WriteLine("-------------------------------------------")
        Console.WriteLine("Suma de Entero 1 y Entero 2")
        Console.WriteLine(numero_entero1 + numero_entero2)
        Console.WriteLine("Suma de Entero 2 y Flotante 1")
        Console.WriteLine(numero_entero2 + numero_flotante1)
        Console.WriteLine("Suma de Flotante 1 y Flotante 2")
        Console.WriteLine(numero_flotante1 + numero_flotante2)
        Console.WriteLine("Multiplicacion de Entero 2 y Flotante 1")
        Console.WriteLine(numero_entero2 * numero_flotante1)
        Console.WriteLine("Divicion de Entero 2 y Flotante 1")
        Console.WriteLine(numero_entero2 / numero_flotante1)
        Console.ReadKey()
    End Sub
End Module

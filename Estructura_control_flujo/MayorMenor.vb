Module MayorMenor

    Sub Main()
        Dim numero1, numero2 As Integer
        Console.WriteLine("Ingrese el primer numero: ")
        numero1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero: ")
        numero2 = Console.ReadLine()
        If numero1 < numero2 Then
            Console.WriteLine("El segundo numero es mayor")
        ElseIf numero1 > numero2 Then
            Console.WriteLine("El primer numero es mayor")
        Else
            Console.WriteLine("Los dos numeros son iguales")
        End If
        Console.ReadKey()
    End Sub

End Module

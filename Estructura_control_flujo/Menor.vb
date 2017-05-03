Module Menor
    Sub Main()
        Dim numero1, numero2, numero3, menor As Integer
        Console.WriteLine("Ingrese el primer numero: ")
        numero1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero: ")
        numero2 = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer numero: ")
        numero3 = Console.ReadLine()
        If numero1 < numero2 Then
            menor = numero1
        Else
            menor = numero2
        End If
        If numero3 < menor Then
            menor = numero3
        End If
        Console.WriteLine("El menor de los tres numeros es: " & menor)
        Console.ReadKey()
    End Sub

End Module

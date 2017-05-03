Module Potencia
    Sub main()
        Dim numero As Integer
        Console.WriteLine("Ingrese Numero: ")
        numero = Console.ReadLine
        Console.WriteLine("Potencias: ")
        For potencia = 1 To 5
            Console.WriteLine("{0}^{1}= {2}", numero, potencia + 1, calcular_potencia(numero, potencia))
        Next
        Console.ReadKey()
    End Sub
    Function calcular_potencia(numero As Integer, potencia As Byte) As Integer
        Return Math.Pow(numero, potencia + 1)
    End Function
End Module

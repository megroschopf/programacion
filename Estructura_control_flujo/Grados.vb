Module Grados
    Sub main()
        Dim grados As UShort
        Console.WriteLine("Ingrese numero de grados(de 0 a 360): ")
        grados = Console.ReadLine
        Select Case grados
            Case 0 To 89
                Console.WriteLine("El angulo es Agudo")
            Case 90
                Console.WriteLine("El angulo es Recto")
            Case 91 To 179
                Console.WriteLine("El angulo es Obtuso")
            Case 180
                Console.WriteLine("El angulo es Llano")
            Case 181 To 360
                Console.WriteLine("El angulo es Concavo")
            Case Else
                Console.WriteLine("Numero de grados incorrecto")
        End Select
        Console.ReadKey()
    End Sub
End Module

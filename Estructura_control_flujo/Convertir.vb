Module Convertir
    Sub main()
        Dim opcion As Byte
        Dim pie, yarda, pulgada, metro, centimetro As Single
        Console.WriteLine("Ingrese la medide que desea convertir")
        Console.WriteLine("1-Pie   2-Yarda   3-Pulgada   4-Metros  5-Centimetros")
        opcion = Console.ReadLine
        Select Case opcion
            Case 1
                Console.WriteLine("Ingrese cantidad de pies: ")
                pie = Console.ReadLine()
                pulgada = pie * 12
                yarda = pie / 3
                centimetro = pulgada * 2.54
                metro = centimetro / 100
                Console.WriteLine("Pulgadas: {0} Yarda: {1} Centimetro: {2} Metro: {3} ", pulgada, yarda, centimetro, metro)
            Case 2
                Console.WriteLine("Ingrese cantidad de yardas: ")
                yarda = Console.ReadLine()
                pie = yarda * 3
                pulgada = pie * 12
                centimetro = pulgada * 2.54
                metro = centimetro / 100
                Console.WriteLine("Pulgadas: {0} Pies: {1} Centimetro: {2} Metro: {3} ", pulgada, pie, centimetro, metro)
            Case 3
                Console.WriteLine("Ingrese cantidad de pulgada: ")
                pulgada = Console.ReadLine()
                pie = pulgada / 12
                yarda = pie / 3
                centimetro = pulgada * 2.54
                metro = centimetro / 100
                Console.WriteLine("Pies: {0} Yarda: {1} Centimetro: {2} Metro: {3} ", pie, yarda, centimetro, metro)
            Case 4
                Console.WriteLine("Ingrese cantidad de metros: ")
                metro = Console.ReadLine()
                centimetro = metro * 100
                pulgada = centimetro / 2.54
                pie = pulgada / 12
                yarda = pie / 3
                Console.WriteLine("Pulgadas: {0} Yarda: {1} Centimetro: {2} Pies: {3} ", pulgada, yarda, centimetro, pie)
            Case 5
                Console.WriteLine("Ingrese cantidad de centimetros: ")
                centimetro = Console.ReadLine()
                metro = centimetro / 100
                pulgada = centimetro / 2.54
                pie = pulgada / 12
                yarda = pie / 3
                Console.WriteLine("Pulgadas: {0} Yarda: {1} Centimetro: {2} Pies: {3} ", pulgada, yarda, centimetro, pie)
            Case Else
                Console.WriteLine("Opcion Incorrecta.")
        End Select
        Console.ReadKey()
    End Sub
End Module

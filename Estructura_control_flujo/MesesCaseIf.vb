Enum Meses
    Enero = 1
    Febrero = 2
    Marzo = 3
    Abril = 4
    Mayo = 5
    Junio = 6
    Julio = 7
    Agosto = 8
    Septiembre = 9
    Octubre = 10
    Nobiembre = 11
    Diciembre = 12
End Enum
Module MesesCaseIf
    Sub main()
        Dim mes As Meses
        Dim año As UShort
        Console.WriteLine("Ingrese el numero de un mes(de 1 a 12): ")
        mes = Console.ReadLine
        Select Case mes.ToString
            Case "Enero"
                Console.WriteLine("El mes tiene 31 dias.")
            Case "Febrero"
                Console.WriteLine("Ingrese el año.")
                año = Console.ReadLine()
                If año Mod 4 = 0 And año Mod 100 <> 0 Then
                    Console.WriteLine("El mes tiene 29 dias.")
                Else
                    Console.WriteLine("El mes tiene 28 dias.")
                End If
            Case "Marzo"
                Console.WriteLine("El mes tiene 31 dias.")
            Case "Abril"
                Console.WriteLine("El mes tiene 30 dias.")
            Case "Mayo"
                Console.WriteLine("El mes tiene 31 dias.")
            Case "Junio"
                Console.WriteLine("El mes tiene 30 dias.")
            Case "Julio"
                Console.WriteLine("El mes tiene 31 dias.")
            Case "Agosto"
                Console.WriteLine("El mes tiene 31 dias.")
            Case "Septiembre"
                Console.WriteLine("El mes tiene 30 dias.")
            Case "Octubre"
                Console.WriteLine("El mes tiene 31 dias.")
            Case "Noviembre"
                Console.WriteLine("El mes tiene 30 dias.")
            Case "Diciembre"
                Console.WriteLine("El mes tiene 31 dias.")
            Case Else
                Console.WriteLine("Numero de mes incorrecto")
        End Select
        Console.ReadKey()
    End Sub
End Module

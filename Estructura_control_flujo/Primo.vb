Module Primo
    Sub main()
        Dim cantidad As UShort
        For contador = 1 To 1000
            For contadorauxiliar = 1 To contador
                If contador Mod contadorauxiliar = 0 Then
                    cantidad = cantidad + 1
                End If
            Next
            If cantidad = 2 Then
                Console.WriteLine(contador)
            End If
            cantidad = 0

        Next
        Console.ReadKey()
    End Sub
End Module

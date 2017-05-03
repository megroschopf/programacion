Module FechayHora
    Sub Main()
        imprimirfecha()
        Console.WriteLine("Hora: " & obtenerhora())
        Console.ReadKey()
    End Sub
    Sub imprimirfecha()
        Console.WriteLine("Fecha: " & Date.Today)
    End Sub
    Function obtenerhora() As Date
        Return TimeOfDay
    End Function
End Module

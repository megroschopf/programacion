Module semanas
    Const dias_del_año As UShort = 365
    Const dias_laborales As UShort = 269
    Const dias_de_semana As Byte = 7
    Sub main()
        Console.WriteLine("Cantidad de semanas que tiene el año: " & Convert.ToSingle(dias_del_año / dias_de_semana))
        Console.WriteLine("Cantidad de semanas laborales que tiene el año: " & Convert.ToSingle(dias_laborales / dias_de_semana))
        Console.ReadKey()
    End Sub
End Module

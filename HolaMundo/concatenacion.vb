Module concatenacion
    Sub main()
        Dim nombre_empresa, nombre_calle As String
        Dim altura_calle As UShort = 2528
        Dim fecha_inicio_actividades As Date = #1/19/1990#
        nombre_empresa = "Empresa"
        nombre_calle = "Calle"
        Console.WriteLine("Nombre de la Empresa: " & nombre_empresa & " Calle: " & nombre_calle & " Altura: " & altura_calle & " Fecha inicio de actividades" & fecha_inicio_actividades)
        Console.WriteLine("Nombre de la Empresa: " & nombre_empresa & " Calle: " & nombre_calle & " Altura: " & Convert.ToString(altura_calle) & " Fecha inicio de actividades" & Convert.ToString(fecha_inicio_actividades))
        Console.ReadKey()
    End Sub
End Module

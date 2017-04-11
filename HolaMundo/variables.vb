Module variables
    Public nombre As String
    Friend tipo_de_doc As String
    Friend numero_de_doc As UInteger
    Friend fecha_nacimiento As Date
    Private tipo_documento, localidad, estado_civil As String
    Private argentino As Boolean
    Private altura As Byte
    Sub Main()
        Dim edad As Byte
        nombre = "Matias Groschopf"
        tipo_documento = "DNI"
        localidad = "Posadas"
        estado_civil = "Soltero"
        numero_de_doc = 34450782
        fecha_nacimiento = #1/19/1990#
        edad = 27
        altura = 180
        argentino = True
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Tipo de Doc: " & tipo_documento)
        Console.WriteLine("Numero de doc: " & numero_de_doc)
        Console.WriteLine("Localidad: " & localidad)
        Console.WriteLine("Estado Civil: " & estado_civil)
        Console.WriteLine("Fecha de nacimiento: " & fecha_nacimiento)
        Console.WriteLine("Edad: " & edad & "años")
        Console.WriteLine("Altura: " & altura & "cm")
        If argentino Then
            Console.WriteLine("Es Argentino")
        Else
            Console.WriteLine("No es Argentino")
        End If
        Console.ReadKey()

    End Sub

End Module

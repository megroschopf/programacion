Module Deposito
    Const interes As Byte = 36
    Sub main()
        Dim meses As Byte
        Dim capital, porc_interes, monto_interes, saldo As Single
        Console.WriteLine("ingrese cantidad a depositar: ")
        capital = Console.ReadLine()
        Console.WriteLine("ingrese cantidad de meses a depositar: ")
        meses = Console.ReadLine()
        porc_interes = interes / meses
        Console.WriteLine("MES  CAPITAL     INTERES     SALDO       ")
        For contador = 1 To meses
            monto_interes = capital * porc_interes / 100
            saldo = capital + monto_interes
            Console.WriteLine("{0}      {1}     {2}     {3}", contador, capital, monto_interes, saldo)
            capital = saldo
        Next
        Console.ReadKey()
    End Sub
End Module

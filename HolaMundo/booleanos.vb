﻿Module booleanos
    Const verdad As Boolean = True
    Const falso As Boolean = False
    Sub main()
        Console.WriteLine("         And         ")
        Console.WriteLine("     V       F       R")
        Console.WriteLine("     {0}     {1}     " & (verdad And verdad), verdad, verdad)
        Console.WriteLine("     {0}     {1}     " & (verdad And falso), verdad, falso)
        Console.WriteLine("     {0}     {1}     " & (falso And verdad), falso, verdad)
        Console.WriteLine("     {0}     {1}     " & (falso And falso), falso, falso)
        Console.ReadKey()
        Console.Clear()
        Console.WriteLine("         Or         ")
        Console.WriteLine("     V       F       R")
        Console.WriteLine("     {0}     {1}     " & (verdad Or verdad), verdad, verdad)
        Console.WriteLine("     {0}     {1}     " & (verdad Or falso), verdad, falso)
        Console.WriteLine("     {0}     {1}     " & (falso Or verdad), falso, verdad)
        Console.WriteLine("     {0}     {1}     " & (falso Or falso), falso, falso)
        Console.ReadKey()
        Console.Clear()
        Console.WriteLine("         Xor         ")
        Console.WriteLine("     V       F       R")
        Console.WriteLine("     {0}     {1}     " & (verdad Xor verdad), verdad, verdad)
        Console.WriteLine("     {0}     {1}     " & (verdad Xor falso), verdad, falso)
        Console.WriteLine("     {0}     {1}     " & (falso Xor verdad), falso, verdad)
        Console.WriteLine("     {0}     {1}     " & (falso Xor falso), falso, falso)
        Console.ReadKey()
        Console.Clear()
        Console.WriteLine("         Not         ")
        Console.WriteLine("     V      R")
        Console.WriteLine("     {0}   " & (Not verdad), verdad)
        Console.WriteLine("     {0}   " & (Not falso), falso)
        Console.ReadKey()
    End Sub
End Module

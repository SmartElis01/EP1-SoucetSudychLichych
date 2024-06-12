Imports System

Module Program
  Sub Main(args As String())
        Dim cislo, cislo2 As String
        Dim cisl, cisl2, vysledek As Integer

        Console.WriteLine("Napiš ¨èíslo")
            cislo = Console.ReadLine
            Console.WriteLine("Napiš další èíslo")
            cislo2 = Console.ReadLine
            vysledek = cislo + cislo2
        Console.WriteLine($"Výsledek je {vysledek}")


    End Sub
End Module

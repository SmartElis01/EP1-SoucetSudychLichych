Imports System

Module Program
  Sub Main(args As String())
        Dim cislo, cislo2 As String
        Dim cisl, cisl2, vysledek As Integer

        Console.WriteLine("Napi� ���slo")
            cislo = Console.ReadLine
            Console.WriteLine("Napi� dal�� ��slo")
            cislo2 = Console.ReadLine
            vysledek = cislo + cislo2
        Console.WriteLine($"V�sledek je {vysledek}")


    End Sub
End Module

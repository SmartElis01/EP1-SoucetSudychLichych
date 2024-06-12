Imports System

Module Program
  Sub Main(args As String())
        Dim cislo, cislo2 As String
        Dim cisloo, cisloo2, vysled As Integer

        Console.WriteLine("Napiš èíslo")
            cislo = Console.ReadLine
            Console.WriteLine("Napiš další èíslo")
            cislo2 = Console.ReadLine
            vysled = cislo + cislo2
            Console.WriteLine($"Výsledek je {vysled}")
            If Integer.TryParse(cislo, cisloo) And
                    Integer.TryParse(cislo2, cisloo2) Then
                If cisloo >= 0 And cisloo2 >= 0 Then
                    vysled = cisloo + cisloo2
                    Console.WriteLine($"Výsledek je: {vysled}")
                Else
                    Console.WriteLine(" pouze celá èísla :)")
                End If
            End If


    End Sub
End Module

Module Module1

    Sub Main()

        Dim str1, str2, thisChar, AlphaStr, DigitStr As String
        Dim count, aCount, dCount, oCount As Integer

        AlphaStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        DigitStr = "0123456789"
        aCount = 0
        dCount = 0

        Console.Write("Input string to be processed: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            thisChar = Mid(str1, count, 1)

            If InStr(AlphaStr, UCase(thisChar)) Then
                aCount = aCount + 1
            ElseIf InStr(DigitStr, thisChar) Then
                dCount = dCount + 1

            End If
        Next

        oCount = Len(str1) - aCount - dCount

        Console.WriteLine("Number of characters in string=" & Len(str1))
        Console.WriteLine("Number of alphabets in string=" & aCount)
        Console.WriteLine("Number of digits in string=" & dCount)
        Console.WriteLine("Number of other characters in string=" & oCount)

        Console.ReadKey()





    End Sub

End Module

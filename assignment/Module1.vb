Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim firstc As String
        Dim Lastc As String

        str1 = ""
        str2 = ""
        firstc = ""
        Lastc = ""

        Console.Write("please enter sentance:")
        str1 = Console.ReadLine

        If Len(str1) < 2 Then
            Console.WriteLine(str1)
            Console.ReadLine()

        Else
            firstc = Right(str1, 2)
            Lastc = Left(str1, 2)

            Console.WriteLine(Lastc & firstc)
            Console.ReadLine()


        End If
    End Sub

End Module

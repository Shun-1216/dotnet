Module Program
    Sub Main(args As String())
        '•Ï”éŒ¾
        Dim month As Integer = Date.Now.Month
        Dim message As String = ""
        '•ªŠò
        Select Case month
            Case 1, 3, 5, 7, 8, 10, 12
                message = "¡Œ‚ÍA‚R‚P“ú‚ ‚è‚Ü‚·"
            Case 2
                message = "¡Œ‚ÍA‚Q‚W“ú‚Ü‚½‚Í‚Q‚X“ú‚ ‚è‚Ü‚·"
            Case 4, 6, 9, 11
                message = "¡Œ‚ÍA‚R‚O“ú‚ ‚è‚Ü‚·"
        End Select
        'o—Í
        Console.WriteLine("ˆ—‚Ég—p‚·‚é’l‚ğ•\¦‚µ‚Ü‚·")
        Console.WriteLine("ŒF" & month)
        Console.WriteLine(message)
        Console.ReadLine()

    End Sub
End Module

Module Program
    Sub Main(args As String())
        '変数宣言
        Dim month As Integer = Date.Now.Month
        Dim message As String = ""
        '分岐
        Select Case month
            Case 1, 3, 5, 7, 8, 10, 12
                message = "今月は、３１日あります"
            Case 2
                message = "今月は、２８日または２９日あります"
            Case 4, 6, 9, 11
                message = "今月は、３０日あります"
        End Select
        '出力
        Console.WriteLine("処理に使用する値を表示します")
        Console.WriteLine("月：" & month)
        Console.WriteLine(message)
        Console.ReadLine()

    End Sub
End Module

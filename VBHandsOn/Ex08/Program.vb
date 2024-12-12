Module Program
    Sub Main(args As String())
        '変数宣言
        Dim minute As Integer = Date.Now.Minute
        Dim second As Integer = Date.Now.Second
        Dim message As String
        '条件分岐　
        If (minute > second) Then
            message = "分の方が大きい"
        ElseIf (minute = second) Then
            message = "分と秒は等しい"
        Else
            message = "秒の方が大きい"
        End If
        '出力
        Console.WriteLine("演算に使用する値を表示します")
        Console.WriteLine("分：" & minute)
        Console.WriteLine("秒：" & second)
        Console.WriteLine(message)
        Console.ReadLine()

    End Sub
End Module

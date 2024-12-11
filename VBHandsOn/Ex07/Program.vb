Module Program
    Sub Main(args As String())
        '変数宣言
        Dim price As Integer = 700
        Dim volume As Integer = 30
        Dim discount As Double = 0.15
        '計算
        Dim amount As Integer = price * volume
        Dim discountamount As Integer = amount * (1 - discount)

        '表示
        Console.WriteLine("金額計算を行います")
        Console.WriteLine("金額計算に使用する値を表示します")
        Console.WriteLine("単価=" & price)
        Console.WriteLine("個数=" & volume)
        Console.WriteLine("割引率=" & discount)
        Console.WriteLine("正価=" & amount.ToString("c"))
        Console.WriteLine("割引後の金額=" & discountamount.ToString("c"))
        Console.ReadLine()
    End Sub
End Module

Imports System

Module Program
    Sub Main(args As String())
        '変数宣言
        Dim val1 As Double = 3.14
        Dim val2 As Integer = 123456
        Dim val3 As String = "Hello"
        Dim val4 As Long = 12345678901
        Dim val5 As Date = Date.Now
        Const con1 As Integer = 5
        '表示
        Console.WriteLine("変数の値を表示します")
        Console.WriteLine(val1)
        Console.WriteLine(val2)
        Console.WriteLine(val3)
        Console.WriteLine(val4)
        Console.WriteLine(val5)
        Console.WriteLine("定数の値を表示します")
        Console.WriteLine(con1)
        Console.ReadLine()
    End Sub
End Module

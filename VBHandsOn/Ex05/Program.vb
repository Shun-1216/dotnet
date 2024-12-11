Module Program
    Sub Main(args As String())
        '変数宣言
        Dim array1() = {"春", "夏", "秋", "冬"}
        Dim array2(2) As Integer

        array2(2) = 50
        '表示
        Console.WriteLine("配列の要素数を表示します")
        Console.WriteLine("配列1の要素数" & array1.Length)
        Console.WriteLine("配列2の要素数" & array2.Length)
        Console.WriteLine()
        Console.WriteLine("配列の要素の値を表示します")
        Console.WriteLine("配列１の要素の値")
        Console.WriteLine(array1(0))
        Console.WriteLine(array1(1))
        Console.WriteLine(array1(2))
        Console.WriteLine(array1(3))
        Console.WriteLine("配列２の要素の値")
        Console.WriteLine(array2(0))
        Console.WriteLine(array2(1))
        Console.WriteLine(array2(2))
        Console.ReadLine()


    End Sub
End Module

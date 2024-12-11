Module Program
    Sub Main(args As String())
        Dim x = 2000, y = 10, z = 4

        Console.WriteLine("演算に使用する値を表示します")
        Console.WriteLine("x=" & x)
        Console.WriteLine("y=" & y)
        Console.WriteLine("z=" & z)
        Console.WriteLine()
        Console.WriteLine("四則演算を行います")
        Console.WriteLine("加算：" & (x + y + z))
        Console.WriteLine("減算：" & (x - y - z))
        Console.WriteLine("乗算：" & (x * y * z))
        Console.WriteLine("除算：" & (x / y / z))
        Console.ReadLine()
    End Sub
End Module

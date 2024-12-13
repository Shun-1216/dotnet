Public Class Sales
    Inherits Employee
    'フィールド
    Dim customerCount As Integer

    'コンストラクタ
    Public Sub New()

    End Sub
    Public Sub New(lname As String, fname As String, n As Integer, count As Integer)
        MyBase.New(lname, fname, n)
        customerCount = count
    End Sub

    'メソッド
    Public Overrides Sub PrintInfo()
        MyBase.PrintInfo()
        Console.WriteLine("顧客数：" & customerCount)
    End Sub

End Class

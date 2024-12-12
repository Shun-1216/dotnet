Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("会社名：" & Employee.companyName)
        Employee.ClassInfo()
        Console.WriteLine()

        Dim emp1 As Employee = New Employee()
        emp1.PrintInfo()
        Console.Writeline()
        Dim emp2 As Employee = New Employee("豊洲", "太郎", 28)
        emp2.PrintInfo()
        Console.Writeline("フルネームは" & emp2.GetFullName() & "さんです")

        Console.WriteLine()
        Console.Writeline("オーバーロードしたメソッドを呼び出します")
        Console.Writeline("フルネームは" & emp2.GetFullName("　") & "さんです")

        Console.Writeline()
        Console.Writeline("プロパティを使用して値の取得、設定を行います")
        Console.Writeline("変更前のフルネームは" & emp2.Lastname & emp2.Firstname & "です")
        emp2.Lastname = "川崎"
        Console.Writeline("変更後のフルネームは" & emp2.Lastname & emp2.Firstname & "です")

        Console.Readline()
    End Sub
End Module


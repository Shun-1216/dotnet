Imports System

Module Program
    Sub Main(args As String())
        Dim val1 As Integer = 10
        Dim val2 As Integer = 0
        Try
            Dim answer As Integer = val1 \ val2
        Catch ex As DivideByZeroException
            Console.WriteLine("除算の処理を見直してください")
            Console.WriteLine(ex.ToString())
        Finally
            Console.WriteLine("処理を終了します")
        End Try

    End Sub
End Module

Module Program
    Sub Main(args As String())
        Dim modresult As Integer
        Dim message As String
        For i As Integer = 1 To 15
            modresult = i Mod 3
            If modresult = 0 Then
                message = i.ToString & "���R�Ŋ����" & (i / 3) & "�ł�"
            Else
                message = i.ToString
            End If
            Console.WriteLine(message)
        Next
        Console.ReadLine()
    End Sub
End Module

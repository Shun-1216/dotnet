Module Program
    Sub Main(args As String())
        '�ϐ��錾
        Dim month As Integer = Date.Now.Month
        Dim message As String = ""
        '����
        Select Case month
            Case 1, 3, 5, 7, 8, 10, 12
                message = "�����́A�R�P������܂�"
            Case 2
                message = "�����́A�Q�W���܂��͂Q�X������܂�"
            Case 4, 6, 9, 11
                message = "�����́A�R�O������܂�"
        End Select
        '�o��
        Console.WriteLine("�����Ɏg�p����l��\�����܂�")
        Console.WriteLine("���F" & month)
        Console.WriteLine(message)
        Console.ReadLine()

    End Sub
End Module

Module Program
    Sub Main(args As String())
        '�ϐ��錾
        Dim minute As Integer = Date.Now.Minute
        Dim second As Integer = Date.Now.Second
        Dim message As String
        '��������@
        If (minute > second) Then
            message = "���̕����傫��"
        ElseIf (minute = second) Then
            message = "���ƕb�͓�����"
        Else
            message = "�b�̕����傫��"
        End If
        '�o��
        Console.WriteLine("���Z�Ɏg�p����l��\�����܂�")
        Console.WriteLine("���F" & minute)
        Console.WriteLine("�b�F" & second)
        Console.WriteLine(message)
        Console.ReadLine()

    End Sub
End Module

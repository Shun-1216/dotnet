Module Program
    Sub Main(args As String())
        '�ϐ��錾
        Dim price As Integer = 700
        Dim volume As Integer = 30
        Dim discount As Double = 0.15
        '�v�Z
        Dim amount As Integer = price * volume
        Dim discountamount As Integer = amount * (1 - discount)

        '�\��
        Console.WriteLine("���z�v�Z���s���܂�")
        Console.WriteLine("���z�v�Z�Ɏg�p����l��\�����܂�")
        Console.WriteLine("�P��=" & price)
        Console.WriteLine("��=" & volume)
        Console.WriteLine("������=" & discount)
        Console.WriteLine("����=" & amount.ToString("c"))
        Console.WriteLine("������̋��z=" & discountamount.ToString("c"))
        Console.ReadLine()
    End Sub
End Module

Module Program
    Sub Main(args As String())
        '�ϐ��錾
        Dim array1() = {"�t", "��", "�H", "�~"}
        Dim array2(2) As Integer

        array2(2) = 50
        '�\��
        Console.WriteLine("�z��̗v�f����\�����܂�")
        Console.WriteLine("�z��1�̗v�f��" & array1.Length)
        Console.WriteLine("�z��2�̗v�f��" & array2.Length)
        Console.WriteLine()
        Console.WriteLine("�z��̗v�f�̒l��\�����܂�")
        Console.WriteLine("�z��P�̗v�f�̒l")
        Console.WriteLine(array1(0))
        Console.WriteLine(array1(1))
        Console.WriteLine(array1(2))
        Console.WriteLine(array1(3))
        Console.WriteLine("�z��Q�̗v�f�̒l")
        Console.WriteLine(array2(0))
        Console.WriteLine(array2(1))
        Console.WriteLine(array2(2))
        Console.ReadLine()


    End Sub
End Module

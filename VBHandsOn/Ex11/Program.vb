Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("��Ж��F" & Employee.companyName)
        Employee.ClassInfo()
        Console.WriteLine()

        Dim emp1 As Employee = New Employee()
        emp1.PrintInfo()
        Console.Writeline()
        Dim emp2 As Employee = New Employee("�L�F", "���Y", 28)
        emp2.PrintInfo()
        Console.Writeline("�t���l�[����" & emp2.GetFullName() & "����ł�")

        Console.WriteLine()
        Console.Writeline("�I�[�o�[���[�h�������\�b�h���Ăяo���܂�")
        Console.Writeline("�t���l�[����" & emp2.GetFullName("�@") & "����ł�")

        Console.Writeline()
        Console.Writeline("�v���p�e�B���g�p���Ēl�̎擾�A�ݒ���s���܂�")
        Console.Writeline("�ύX�O�̃t���l�[����" & emp2.Lastname & emp2.Firstname & "�ł�")
        emp2.Lastname = "���"
        Console.Writeline("�ύX��̃t���l�[����" & emp2.Lastname & emp2.Firstname & "�ł�")

        Console.Readline()
    End Sub
End Module


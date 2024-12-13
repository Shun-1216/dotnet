Public Class Employee
    'フィールド定義
    Private lastnameValue As String
    Private firstnameValue As String
    Private age As Integer
    Public Shared companyName As String = "ビプ商事"

    'プロパティ定義
    Public Property Lastname() As String
        Get
            Return lastnameValue
        End Get
        Set(value As String)
            If Not String.IsNullOrEmpty(value) Then
                lastnameValue = value
            End If
        End Set
    End Property
    Public ReadOnly Property Firstname() As String
        Get
            Return firstnameValue
        End Get
    End Property

    'コンストラクター定義
    Public Sub New()
        lastnameValue = "姓なし"
        firstnameValue = "名なし"
        age = 20
    End Sub
    Public Sub New(lname As String, fname As String, n As Integer)
        lastnameValue = lname
        firstnameValue = fname
        age = n
    End Sub

    'メソッド定義
    Public Function GetFullName() As String
        Return Lastname & Firstname
    End Function
    Public Function GetFullName(delim As String) As String
        Return Lastname & delim & Firstname
    End Function
    Public Overridable Sub PrintInfo()
        Console.WriteLine("姓名：" & Lastname & Firstname)
        Console.WriteLine("年齢：" & age)
    End Sub

    Shared Sub ClassInfo()
        Console.WriteLine("Employeeクラスです")
    End Sub
End Class

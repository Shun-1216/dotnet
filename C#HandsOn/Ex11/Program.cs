using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11-9
            Sales sales = new Sales("千葉","花子",24,15);
            sales.PrintInfo();
            Console.WriteLine();
            
            //11-8 
            Console.WriteLine("会社名："+Employee.CompanyName);
            Employee.ClassInfo();
            Console.WriteLine();

            Employee obj1 = new();
            obj1.PrintInfo();

            Console.WriteLine();
            Employee obj2 = new("豊洲","太郎",28);
            obj2.PrintInfo();
            Console.WriteLine("フルネームは"+obj2.GetFullName()+"さんです");

            Console.WriteLine();
            Console.WriteLine("オーバーロードしたメソッドを呼び出します");
            Console.WriteLine("フルネームは"+obj2.GetFullName(" ")+"さんです");

            //11-7
            Console.WriteLine();
            Console.WriteLine("プロパティを使用して値の取得、設定を行います");
            Console.WriteLine("変更前のフルネームは"+obj2.Lastname+obj2.Firstname+"さんです");
            obj2.Lastname = "川崎";
            Console.WriteLine("変更後のフルネームは"+obj2.GetFullName()+"さんです");
        }
    }
}
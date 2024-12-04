using System;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //変数定義
            double val1 = 3.14;
            int val2 = 123456;
            string val3 = "Hello";
            long val4 = 12345678901;
            DateTime val5 = DateTime.Now;
            const int con1 = 5;
            //出力
            Console.WriteLine("変数の値を表示します");
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.WriteLine(val3);
            Console.WriteLine(val4);
            Console.WriteLine(val5);
            Console.WriteLine("定数の値を表示します");
            Console.WriteLine(con1);
        } 
    }
}
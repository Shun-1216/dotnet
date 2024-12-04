using System;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //変数宣言
            int x = 2000, y = 10, z = 4;
            Console.WriteLine("演算に使用する値を表示します");
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("z=" + z);
            Console.WriteLine();
            //計算
            Console.WriteLine("四則演算を行います");
            Console.WriteLine("加算："+ (x+y+z));
            Console.WriteLine("減算："+ (x-y-z));
            Console.WriteLine("乗算："+ (x*y*z));
            Console.WriteLine("除算："+ (x/y/z));
        }
        
    }
}
using System;
using System.Globalization;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //変数宣言
            int price = 700;
            int value = 30;
            double per = 0.15;

            Console.WriteLine("金額計算を行います");
            Console.WriteLine("金額計算に使用する値を表示します");
            Console.WriteLine("単価 = " + price);
            Console.WriteLine("個数 = " + value);
            Console.WriteLine("割引率 = " + per);
            Console.WriteLine("正価 = " + (price * value).ToString("C"));
            Console.WriteLine("割引後の金額 = " + (price*value*(1-per)).ToString("C"));

        }
    }
}
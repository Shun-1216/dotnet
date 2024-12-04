using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //配列宣言
            string[] array1 = {"春","夏","秋","冬"};
            int[] array2 = new int[3];

            //値設定
            array2[2] = 50;

            //出力
            Console.WriteLine("配列の要素数を表示します");
            Console.WriteLine("配列１の要素数" + array1.Length);
            Console.WriteLine("配列２の要素数" + array2.Length);

            Console.WriteLine("配列の要素の値を表示します");
            Console.WriteLine("配列１の要素の値");
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[3]);
            Console.WriteLine("配列２の要素の値");
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);            
        }
    }
}

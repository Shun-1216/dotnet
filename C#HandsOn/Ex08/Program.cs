using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[]args)
        {
            string message;
            //日時取得
            DateTime dateTime = DateTime.Now;
            int minutes = dateTime.Minute;
            int seconds = dateTime.Second;
            Console.WriteLine("演算に使用する値を表示します");
            Console.WriteLine("分：" + minutes);
            Console.WriteLine("秒：" + seconds);

            //比較
            if(minutes > seconds)
            {
                message = "分のほうが大きい";
            }
            else if(minutes == seconds)
            {
                message = "分と秒は等しい";
            }
            else
            {
                message = "秒のほうが大きい";
            }
            Console.WriteLine(message);
        }
    }
}
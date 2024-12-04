using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[]args)
        {
            for(int i=1;i<=15;i++)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine(i+"を3で割ると"+i/3+"です");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
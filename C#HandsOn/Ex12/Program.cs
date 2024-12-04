using System;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1 = 10;
            int val2 = 0;
            
            //12-2
            try
            {
                int answer = val1 / val2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("除算の処理を見直してください");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("処理を終了します");
            }
            
        }
    }
}
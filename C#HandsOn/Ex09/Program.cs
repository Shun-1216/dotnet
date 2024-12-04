using System;

namespace Ex09
{
    internal class Program 
    {
        static void Main(string[]args)
        {
            string message = string.Empty;
            //月取得
            int month = DateTime.Now.Month;

            //分岐
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    message = "今月は、３１日あります";
                    break;
                case 2:
                    message = "今月は、２８日または２９日あります";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    message = "今月は、３０日あります";
                    break;
            }
            
            Console.WriteLine(message);
        }
    }
}
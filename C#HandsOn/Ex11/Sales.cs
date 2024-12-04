using System;

namespace Ex11
    {
        public class Sales :Employee
        {
            //変数宣言
            int customerCount = 0;

            public Sales()
            {
                
            }
            public Sales(string lname,string fname,int n,int count) 
                : base(lname,fname,n)
            {
                customerCount = count;
            }

            public override void PrintInfo()
            {
                base.PrintInfo();
                Console.WriteLine("顧客数："+ customerCount);
            }
    }
    }

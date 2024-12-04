using System;

namespace Ex11
{

    public class Employee
    {
        //性
        private string lastname;
        //名
        private string firstname;
        //年齢
        private int age;

        //11-8
        static public string CompanyName = "ビプ商事";

        public static void ClassInfo()
        {
            Console.WriteLine("Employeeクラスです");
        }
        
        //プロパティ
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    lastname = value;
                }
            }
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
        }
        
        /*----------------------------------*/
        //コンストラクタ
         //引数なし
        public Employee()
        {
            lastname = "姓なし";
            firstname = "名なし";
            age = 20;
        }
         //引数あり
        public Employee(string lname,string fname,int n)
        {
            lastname = lname;
            firstname = fname;
            age = n;
        }   
        //メソッド
        public string GetFullName()
        {
            return lastname + firstname;
        }
        public string GetFullName(string delim)
        {
            return lastname + delim + firstname;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("姓名：" + lastname + firstname);
            Console.WriteLine("年齢" + age);
        }


    }
} 

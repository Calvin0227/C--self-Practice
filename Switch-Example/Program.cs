using System;

namespace Switch_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double salary = 5000;
            bool b = true;
            Console.WriteLine("输入等级");
            string Dengji = Console.ReadLine();
            switch (Dengji) 
            {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary +=200;
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:  Console.WriteLine("You enter wrong");
                    b = false;
                    break;

            }
            if(b) 
            { 
            Console.WriteLine("工资是 : {0}", salary);
            Console.ReadKey();
            }


        }
    }
}

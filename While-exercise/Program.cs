using System;

namespace While_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many students you want count?");
            int count = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 1;
            int avg = 0;
             
            
                while (i <= count)
            {
                Console.WriteLine("Please Enter their grade");
                int grade = Convert.ToInt32(Console.ReadLine());
                sum += grade;
                avg = sum / count;
                i++;
            }

            
            Console.WriteLine("You are calculate {0} Total Score is : {1} Average is : {2}" , count, sum,avg);
            Console.ReadKey();
        }

            catch 
            { 
                Console.WriteLine("You enter wrong shit");
            }

        }
    }
}

using System;

namespace While_exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num = 80000;
            int Year = 2006;
            while (Num < 200000) 
            {
                Num = Num + (Num * 0.25);
                Year++;
            }

            Console.WriteLine(" 现在是   {0}  年", Year);
        }
    }
}

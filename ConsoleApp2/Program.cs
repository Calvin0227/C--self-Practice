using System;

namespace Try_Catch_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            int Number = 0;
            Console.WriteLine("Please Enter a Number");
            try 
            {
                Number = Convert.ToInt32(Console.ReadLine());
                b = true;
            }
            catch 
            {
                Console.WriteLine("Nah, you enter wrong shit");

            }
            if (b) 
            {
                Console.WriteLine(Number);
            }
            
            Console.ReadKey();

            
        }
    }
}

using System;

namespace While_exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 这道题 你会做了吗？ (Yes/No)");
            String Answer = "";
            try
            {
                Answer = Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("请输入 正确的信息");

            }
                int count = 0;
                if (Answer == "Yes")
                {
                    Console.WriteLine("牛逼，你可以走了 ");
                }
                else
                {
                    while (Answer == "No" && count < 10)
                    {
                        Console.WriteLine("老师 讲解中");
                        Console.WriteLine("你会做了吗？ （Yes/No）");
                        Answer = Console.ReadLine();
                        if (Answer == "Yes")
                        {
                            Console.WriteLine("你终于会了 你可以放学了");
                            break;
                        }
                        count++;
                    }
                }
        }
    }
}

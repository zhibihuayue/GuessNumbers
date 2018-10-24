using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GuessChance = 7;

            while (true)
            {
                Console.WriteLine("*********************欢迎来到猜数字*********************\n");

                //生成一个随机数.
                int targetNum = new Random().Next(1, 101);

                for (int i = 1; i <= GuessChance; i++)
                {
                    //输入猜想.
                    Console.Write("请输入猜想 {0}: ", i);
                    int guessNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("猜想 {0}: {1}", i, guessNum);

                    //判断猜大了还是猜小了.
                    if (guessNum > targetNum)
                    {
                        Console.WriteLine("猜大了!");
                    }

                    if (guessNum < targetNum)
                    {
                        Console.WriteLine("猜小了!");
                    }

                    //猜中了.
                    if (guessNum == targetNum)
                    {
                        Console.WriteLine("恭喜你猜中了!");
                        Console.WriteLine();
                        break;
                    }

                    Console.WriteLine();
                }

                //是否继续游戏的判断.
                Console.WriteLine("是否再来一次游戏？y/n");
                string comfirm = Console.ReadLine();
                if (comfirm == "y" || comfirm == "Y")
                {
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("游戏结束！");
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}

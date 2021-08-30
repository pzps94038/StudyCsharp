using System;
using static System.Console;
namespace Ex0412
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter, sum = 0;
            for (counter = 0; counter <= 20; counter++) 
            {
                //如果進入迴圈counter能%2沒餘數代表不是奇數直接在進入迴圈
                if (counter % 2 == 0)//找出奇數
                {
                    continue;
                }
                //是奇數才會跑下面這段
                sum += counter;
                if (sum > 60) 
                {
                    break;
                }
                WriteLine($"Counter = {counter}, Sum = {sum}");
            }
            ReadKey();
        }
    }
}

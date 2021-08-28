using System;
using static System.Console;
namespace E0408
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            for (; ; ) 
            {
                Write("請輸入數值");
                int number = int.Parse(ReadLine());
                count++;
                sum += number;
                Write("還要繼續嗎Y/N");
                string endkey = ReadLine();
                if (endkey == "y" || endkey == "Y")
                {
                    continue;//繼續進入迴圈
                }
                else if (endkey == "n" || endkey == "N")
                {
                    break;
                }
            }
            WriteLine($"輸入{count}個數值，總計{sum}");
            ReadKey();
        }
    }
}

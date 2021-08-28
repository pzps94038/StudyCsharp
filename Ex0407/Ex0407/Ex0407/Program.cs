using System;
using static System.Console;
namespace Ex0407
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            // i從1開始 道條件滿足等於大於10跳出迴圈
            for (int i = 1; i <= 10; i++)
            {
                WriteLine($"i={i:d2}, sum={sum += i:d2}");
            }
            ReadKey();
        }
    }
}

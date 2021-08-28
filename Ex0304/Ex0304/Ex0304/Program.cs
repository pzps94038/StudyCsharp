using System;
using static System.Console;
namespace Ex0304
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 120; //宣告變數並給初值
            int num2 = 42_578;
            WriteLine($"數值一:{num1}，數值二:{num2}");
            WriteLine($"兩數相加:{(num1+num2):N0}");
            ReadKey();
        }
    }
}

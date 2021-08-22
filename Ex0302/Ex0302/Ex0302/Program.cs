using System;
using static System.Console;
namespace Ex0302
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果宣告float及decimal需加後置字元
            float num1 = 1.2233445566778899F;
            double num2 = 1.2233445566778899;
            decimal num3 = 1.2233445566778899M;
            WriteLine($"Float :{num1}");
            WriteLine($"Double :{num2}");
            WriteLine($"Decimal :{num3}");
            //輸出4位小數的數值
            WriteLine($"Float:{num1:f4}");
            ReadKey();
        }
    }
}

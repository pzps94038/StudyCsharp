using System;
using static System.Console;
namespace Ex0314
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25, b = 147, c = 67;
            WriteLine($"a = {a},b = {b},c = {c}");
            bool result = (a + b) > (a + c);
            WriteLine($"(a + b) > (a + c), 回傳{result}");
            result = (b - c) < (c - a);
            WriteLine($"(b - c) < (c - a), 回傳{result}");
            result = a == 25;
            WriteLine($" a == 25, 回傳 {result}");
            result = b != 25;
            WriteLine($"b !=25, 回傳{result}");
            ReadKey();
        }
    }
}

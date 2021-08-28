using System;
using static System.Console;
namespace Ex0315
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25, b = 55, c = 147, d = 223;
            WriteLine($"a={a}, b={b}, c={c}, d={d}");
            //&&需兩邊的運算式都成立
            bool result = (b > a) && (d > c);
            WriteLine($"(a>b) && (c>d) = {result}");
            result = (a > b) || (c > d);
            WriteLine($"(a > b) || (c > d) = {result}");
            result = !(a > b);
            WriteLine($"!(a > b) = {result}");
            ReadKey();
        }
    }
}

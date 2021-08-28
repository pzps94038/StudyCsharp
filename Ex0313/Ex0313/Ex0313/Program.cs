using System;
using static System.Console;
namespace Ex0313
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 52.00F;
            float num2 = 123_788.655F;
            WriteLine($"num1 = {num1}, num2 = {num2}");
            //n3 = 小數位三
            WriteLine($"num1 += num2, num1 = {num1 += num2:n3}");
            WriteLine($"num1 -= num2, num1 = {num1 -= num2:n3}");
            WriteLine($"num1 *= num2, num1 = {num1 *= num2:n3}");
            num1 = 123_788.655F; num2 = 52.0F;
            WriteLine($"num1 /= num2, num1 = {num1 /= num2:n5}");
            WriteLine($"num1 %= num2, num1 = {num1 %= num2:n3}");
            ReadKey();
        }
    }
}

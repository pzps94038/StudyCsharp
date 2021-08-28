using System;
using static System.Console;
namespace Ex0308
{
    class AutoChange
    {
        static void Main(string[] args)
        {
            // num1自動轉換float
            int num1 = 125;
            float num2 = 64.78F;
            float result = num1 + num2;            
            WriteLine($"{ num1 }+{ num2} = {result}");
            ReadKey();
        }
    }
}

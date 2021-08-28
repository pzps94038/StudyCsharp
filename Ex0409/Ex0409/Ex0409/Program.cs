using System;
using static System.Console;
namespace Ex0409
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("輸入兩個整數值，求取最大公因數");
            Write("輸入第一個數值");
            int number1 = int.Parse(ReadLine());
            int diveded = number1;
            Write("輸入第二個數值");
            int number2 = int.Parse(ReadLine());
            int divisor = number2;
            while (diveded != 0) 
            {
                int remain = divisor % diveded;
                divisor = diveded;
                diveded = remain;
            }
            WriteLine($"{number1}與 {number2} 的最大公因數{divisor}");
        }
    }
}

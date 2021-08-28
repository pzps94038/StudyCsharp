using System;
using static System.Console;
namespace Ex0406
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("請輸入你的節稅額");
            decimal result = decimal.Parse(ReadLine());
            if (result > 4400000)
            {
                //使用了decimal要配合使用後置字元
                result = result * 0.4M - 805000;
                WriteLine($"稅率40%，繳交稅額 = {result:N0}");
            }
            else if (result > 2350000)
            {
                result = result * 0.3M - 365000;
                WriteLine($"稅率30%，繳交稅額 = {result:N0}");
            }
            else 
            {
                result *= 0.05M;
                WriteLine($"稅率5%，繳交稅額 = {result:N0}");
            }
            ReadKey();
        }
    }
}

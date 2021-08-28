using System;
using static System.Console;
namespace Ex0309
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const double Pound = 2.20462D;//宣告常數
            Write("請輸入公斤:");
            int weight = int.Parse(ReadLine());
            WriteLine($"{weight}公斤 = {weight * Pound}磅");
            ReadKey();
        }
    }
}

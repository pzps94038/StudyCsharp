using System;
using static System.Console;
namespace Ex0509
{
    class Program
    {
        static void Main(string[] args)
        {
            //隱含型別 宣告的對象是不嚴格的型別
            var number = new[] 
            {
                new[]{ 68, 135, 83},
                new[]{ 75, 64, 211, 37}
            };
            WriteLine("讀取隱含的不規則陣列:");
            foreach (var item in number) 
            {
                foreach (int i in item) 
                {
                    Write($"{i,6}");
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}

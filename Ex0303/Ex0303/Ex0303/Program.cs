using System;
using static System.Console;

namespace Ex0303
{
    class Program
    {
        static void Main(string[] args)
        {
            char chM = 'M';
            int num1 = (int)chM;
            int num2 = 78;
            char chN = Convert.ToChar(78);
            //輸出結果
            //字元轉換ASCII碼
            WriteLine($"字元{chM}，ASCII值 = {num1}");
            //ASCII碼轉換字元
            WriteLine($"ASCII{num2}，字元{chN}");
            ReadKey();
        }
    }
}

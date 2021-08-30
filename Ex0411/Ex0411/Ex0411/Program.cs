using System;
using static System.Console;
namespace Ex0411
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)//外層for控制層數總共5層
            {
                for (int y = 1; y <= i; y++)//內層控制輸出數目
                {
                    Write("*");
                }
                WriteLine();//斷行
            }
            ReadKey();
        }
    }
}

using System;
using static System.Console;
namespace Ex0510
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "This is my favorite programming!";
            int index;//先宣告使用變數
            for (index = 0; index < 6; index++) 
            {
                WriteLine($"第{index+1}個字元是:{word[index]}");
            }
            WriteLine($"總共有{word.Length}個字元");
            ReadKey();
        }
    }
}

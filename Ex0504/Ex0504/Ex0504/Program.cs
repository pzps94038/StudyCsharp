using System;
using static System.Console;
namespace Ex0504
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "molly","eric", "john" ,"janet", "iron"};
            int[] age = { 25, 26, 27, 26, 28 };
            //第一個參數是要找的陣列第二個參數是符合條件的
            int index = Array.IndexOf(age, 26);
            WriteLine("符合條件26歲的:");
            //要滿足條件才會進入迴圈
            while (index >= 0)
            {
                Write($"{name[index],6}");
                //第一個參數是要找的陣列第二個參數是符合條件的第三個參數是起始值
                //找到之後往下個參數開始繼續找
                index = Array.IndexOf(age, 26, index + 1);
            }
            ReadKey();

        }
    }
}

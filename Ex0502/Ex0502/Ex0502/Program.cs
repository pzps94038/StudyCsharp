using System;
using static System.Console;
namespace Ex0502
{
    class Program
    {
        //sort排序
        static void Main(string[] args)
        {
            int[] number = { 56, 78, 9, 354 };
            Write("排序前:");
            foreach (int item in number) 
            {
                Write($"{item,3}");
            }
            //使用array的方法Sort排序\n斷行
            Array.Sort(number);
            //陣列反轉
            //Array.Reverse(number);
            Write("\n排序後");
            //{number[i],3}預留三個位數,不足前方保留空白
            for (int i = 0; i < number.Length; i++)
            {
                Write($"{number[i],3} ");
            }
            ReadKey();
        }
    }
}

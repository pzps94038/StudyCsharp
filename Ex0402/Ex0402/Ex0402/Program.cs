using System;
using static System.Console;
namespace Ex0402
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("請輸入分數:");
            int grade = int.Parse(ReadLine());
            if (grade >= 60)//條件成立
            {
                WriteLine("考試通過...");
            }
            else//條件不成立
            {
                WriteLine("請多加油...");
            }
            ReadKey();
        }
    }
}

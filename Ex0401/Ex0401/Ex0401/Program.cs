using System;
using static System.Console;
namespace Ex0401
{
    class Program
    {
        //單一條件
        static void Main(string[] args)
        {
            Write("請輸入分數:");
            //將輸入數值轉換int
            int score = int.Parse(ReadLine());
            // 分數大於或等於60才會顯示passing代表及格
            if (score >= 60) 
            {
                WriteLine("Passing...");
            }
            ReadKey();
        }
    }
}

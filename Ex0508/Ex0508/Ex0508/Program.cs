using System;
using static System.Console;
namespace Ex0508
{
    class Program
    {
        static void Main(string[] args)
        {
            //宣告subject主題變數
            //讓記憶體分配三個陣列空間出來
            string[][] subject = new string[3][];
            subject[0] = new string[]
            { 
                "Tomas","國文","英文會話","程式設計"
            };
            subject[1] = new string[]
            {
                "Molly","國文","計算機概論"
            };
            subject[2] = new string[]
            {
                "Eric","英文","多媒體論","應用文"
            };
            foreach (string[] curriculum in subject) 
            {
                Write("課表:");
                foreach (string item in curriculum) 
                {
                    Write($"{item,6}");
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}

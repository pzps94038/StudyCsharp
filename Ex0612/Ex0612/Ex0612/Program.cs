using System;
using static System.Console;
namespace Ex0612
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle Circle = new Circle();
            WriteLine("請選擇1.計算圓周長 2.計算圓面積");
            string wd = ReadLine();
            switch (wd) 
            {
                case "1":
                    WriteLine("請輸入直徑");
                    double caliber = Circle.calcPeriphery(ReadLine());
                    WriteLine($"圓周長 = {caliber:N5}");
                    break;
                case "2":
                    WriteLine("請輸入半徑");
                    double ridus = Circle.CalcArea(ReadLine());
                    WriteLine($"圓面積 = {ridus:N5}");                    
                    break;
                default:
                    WriteLine("選擇錯誤");
                    break;
            }
            ReadKey();
                
        }
    }
}

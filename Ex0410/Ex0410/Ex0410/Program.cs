using System;
using static System.Console;
namespace Ex0410
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool guess = false;//判斷基準
            Random rnd = new Random();//隨機模組
            int value = rnd.Next(1, 101);//隨機數字1~100
            int counter = 0;//計算次數用
            //先至少做一次
            do
            {
                counter++;
                WriteLine("請輸入1~100整數:");
                int keyin = int.Parse(ReadLine());
                if (keyin > value)
                {
                    WriteLine($"{keyin},輸入數字太大了");
                }
                else if (keyin < value)
                {
                    WriteLine($"{keyin},輸入數字太小了");
                }
                else
                {
                    WriteLine($"答對了數字為{value}，總共猜了{counter}次");
                    guess = true;
                }
            } while (!guess);
        }
    }
}

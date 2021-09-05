using System;
using static System.Console;
namespace Ex0603
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ron = new Person();
            WriteLine("請輸入姓名");
            //設置title = readline;
            Ron.title = ReadLine();
            //呼叫函式
            Ron.Display();
            ReadKey();
        }
    }
}

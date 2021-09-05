using System;
using static System.Console;
namespace Ex0604
{
    class Program
    {
        static void Main(string[] args)
        {
            Student CallA = new Student();
            WriteLine("請輸入姓名");
            CallA.Title = ReadLine();
            WriteLine("請輸入年齡");
            CallA.Ages = short.Parse(ReadLine());
            CallA.ShowMessage();
            ReadKey();

        }
    }
}

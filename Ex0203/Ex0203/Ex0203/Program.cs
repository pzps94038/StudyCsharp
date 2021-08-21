using System;
//匯入靜態類別console
using static System.Console;
namespace Ex0203
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("請輸入你的姓名");
            string name = ReadLine();            
            WriteLine("Good Day! {0}", name);
            ReadKey();
        }
    }
}

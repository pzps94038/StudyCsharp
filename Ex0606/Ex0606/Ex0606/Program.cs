using System;
using static System.Console;
namespace Ex0606
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("請輸入姓名");
            string title = ReadLine();
            WriteLine("請輸入號碼");
            int number = int.Parse(ReadLine());
            Student Ron = new Student(title, number);
            Ron.judgeFrom(); ;
            ReadKey();
        }
    }
}

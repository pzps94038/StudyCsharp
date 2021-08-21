using System;
using static System.Console;
namespace Ex0204
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("請輸入姓名");
            string Name = ReadLine();
            WriteLine("請輸入提款金額");
            int Money = Convert.ToInt32(ReadLine());
            //第一種方式呈現
            //WriteLine("HI!{0},提款金額為{1}",Name,Money);
            //第二種方式呈現
            WriteLine($"HI!{Name},提款金額為{Money:C0}");
            ReadKey();
        }
    }
}

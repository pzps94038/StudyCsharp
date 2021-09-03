using System;
using static System.Console;
namespace Ex0601
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tomas = new Student();
            tomas.name = "Tomas";
            Student emily = new Student();
            emily.name = "Emily VanCamp";
            WriteLine($"第一個學生名稱{tomas.name}");
            WriteLine($"第二個學生名稱{emily.name}");
            ReadKey();
        }
    }
}

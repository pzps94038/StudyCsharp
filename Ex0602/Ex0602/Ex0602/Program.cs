using System;
using static System.Console;
namespace Ex0602
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tomas = new Student();
            Student emily = new Student();
            tomas.ShowName("Tomas Dalton");
            emily.ShowName("Emily VanCamp");
            WriteLine($"第一個學生{tomas.InputName()}");
            WriteLine($"第二個學生{emily.InputName()}");
            ReadKey();
        }
    }
}

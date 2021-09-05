using System;
using static System.Console;
namespace Ex0611
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"沒有實體化第{Student.Count}個學生");
            Student Ron = new Student("Ron", 18);
            Student Apple = new Student("Apple", 8);
            Student Cash = new Student("Cash", 30);
            ReadKey();
        }
    }
}

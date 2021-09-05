using System;

namespace Ex0609
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mary");
            Student Mary = new Student(78, 69);
            Console.Write("Ron");
            Student Ron = new Student(78, 69, 80);
            Console.ReadKey();
        }
    }
}

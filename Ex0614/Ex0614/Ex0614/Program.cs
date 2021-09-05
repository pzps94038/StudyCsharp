using System;

namespace Ex0614
{
    class Program
    {
        static void Main(string[] args)
        {
            AnyNumber.randnum();
            Console.WriteLine($"currentNum = {AnyNumber.currentNum}");
            Console.ReadKey();

        }
    }
}

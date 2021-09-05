using System;

namespace Ex0610
{
    class Program
    {
        static void Main(string[] args)
        {
            //設定初值
            Student Ron = new Student { English = 80 , Math = 78};
            Console.WriteLine("Ron:");
            Console.WriteLine($"英文:{Ron.English}");
            Console.WriteLine($"數學:{Ron.Math}");            
            Ron.Total();
            Student Tomas = new Student { English = 60, Math = 50, Comp = 88 };
            Console.WriteLine("Tomas:");
            Console.WriteLine($"英文:{Tomas.English}");
            Console.WriteLine($"數學:{Tomas.Math}");
            Console.WriteLine($"計概:{Tomas.Comp}");
            Tomas.Total();
            Console.ReadKey();
        }
    }
}

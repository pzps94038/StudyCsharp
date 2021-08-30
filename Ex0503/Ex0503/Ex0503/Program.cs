using System;
using static System.Console;
namespace Ex0503
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 56, 78, 9, 354 };
            string[] name = { "mary", "judy", "tomas", "molly"};
            WriteLine("排序前:");
            for (int i = 0; i < number.Length; i++) 
            {
                Write($"{number[i],6}");
            }
            Write("\n");
            for (int i = 0; i < name.Length; i++)
            {
                Write($"{name[i],6}");
            }
            WriteLine("排序後:");
            Array.Sort(number, name);
            WriteLine("排序前:");
            for (int i = 0; i < number.Length; i++)
            {
                Write($"{number[i],6}");
            }
            Write("\n");
            for (int i = 0; i < name.Length; i++)
            {
                Write($"{name[i],6}");
            }
            ReadKey();
        }
    }
}

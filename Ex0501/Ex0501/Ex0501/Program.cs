using System;
using static System.Console;
namespace Ex0501
{
    class Program
    {
        static void Main(string[] args)
        {
            //宣告 int的陣列 但還沒配置記憶體            
            int[] grade;
            grade = new int[] { 78, 65, 92, 85};
            int index = 0;
            foreach (int item in grade) 
            {
                WriteLine($"{index} - {item}");
                index++;
            }
            ReadKey();
        }
    }
}

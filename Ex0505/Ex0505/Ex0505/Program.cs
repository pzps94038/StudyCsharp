using System;
using static System.Console;
namespace Ex0505
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = { "orange", "apple", "banana", "grape"};
            Write("原來的陣列元素");
            foreach (string item in fruit)
            {
                Write($"{item}  ");
            }
            Write("\n改變後的陣列元素");
            //ref關鍵字家在陣列前做為呼叫參考
            Array.Resize(ref fruit, fruit.Length + 2);
            //加入陣列元素
            fruit[4] = "waterlemon";
            fruit[5] = "strawberry";
            foreach (string item in fruit) 
            {
                Write($"{item}  ");
            }
            //變小的陣列元素
            Write("\n變小後的陣列元素");
            Array.Resize(ref fruit, fruit.Length -1);
            foreach (string item in fruit)
            {
                Write($"{item}  ");
            }
            ReadKey();
        }
    }
}

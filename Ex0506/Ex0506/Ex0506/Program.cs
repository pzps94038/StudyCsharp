using System;
using static System.Console;
namespace Ex0506
{
    class Program
    {
        static void Main(string[] args)
        {
            //copyto and copy方法
            string[] fruit = { "orange", "apple", "lemon", "pineapple", "papaya", "guava"};
            //produce是新空的字串陣列長度為fruit
            string[] produce = new string[fruit.Length];
            string[] product = new string[4];
            fruit.CopyTo(produce, 0);
            WriteLine("使用copyTo方法");
            foreach (string item in produce) 
            {                
                Write($"{item}  ");
            }
            WriteLine("\n使用copy方法");
            Array.Copy(fruit, product, 4);
            //複製前四個
            foreach (string item in product)
            {
                Write($"{item}  ");
            }
            ReadKey();
        }
    }
}

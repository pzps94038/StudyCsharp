using System;
using static System.Console;
namespace Ex0507
{
    class Program
    {
        static void Main(string[] args)
        {
            // score代表的是{ 75, 64, 96 } = 第1次考試成績 "Mary", "Tomas", "John"分別對應;考了4次
            int[,] score = { { 75, 64, 96 }, { 55, 67, 39 }, { 45, 92, 85 }, { 71, 69, 81 } };
            int[] sum = new int[3];
            string[] name = { "Mary", "Tomas", "John"};
            foreach (string item in name)
            {
                Write("{0,7}", item);
            }
            WriteLine();
            // score row = 一維陣列長度 , column = 二維陣列長度;
            int row = score.GetLength(0);
            int column = score.GetLength(1);
            for (int outer = 0; outer < row; outer++) 
            { 
                for (int inner = 0; inner < column; inner++) 
                {
                    Write($"{score[outer, inner],7}");
                }
                WriteLine();     
                sum[0] += score[outer, 0];                
                sum[1] += score[outer, 1];                
                sum[2] += score[outer, 2];                
            }
            WriteLine("------------------------");
            WriteLine($"Sum: {sum[0]} {sum[1],5} {sum[2],6}");
            ReadKey();
        }
    }
}

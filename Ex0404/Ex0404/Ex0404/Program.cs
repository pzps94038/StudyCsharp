using System;
using static System.Console;
namespace Ex0404
{
    class Program
    {
        //巢狀if
        static void Main(string[] args)
        {
            Write("請輸入分數");
            ushort score = ushort.Parse(ReadLine());
            if (score >= 60) 
            {
                if (score >= 70)
                {
                    if (score >= 80)
                    {
                        // 三元運算
                        WriteLine( score >=90 ? $"分數{score}A級" : $"分數{score}B級");
                    }
                    else 
                    {
                        WriteLine($"分數{score}C級");
                    }
                }
                else 
                {
                    WriteLine($"分數{score}D級");
                }
            }
            else
            {
                WriteLine($"分數{score}E級");
            }
            ReadKey();
        }
    }
}

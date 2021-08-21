using System;
using static System.Console;
namespace Ex0301
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1_23_456;//任意底線
            long num2 = 456_789_123L;//長整數加後置字元L
            long max = Int64.MaxValue;
            long min = Int64.MinValue;
            int num3 = 0b1011_110; //二進位
            int num4 = 0b_1111_1010; //0b 2進位
            int num5 = 0x_FB12; //0x 16進位
            WriteLine($"Number:{num1:N0},{num1:n0}");
            WriteLine($"二進位變十進位{num3:D5},{num4:d5}");
            //確認型別
            WriteLine($".Net framework型別: {num1.GetType()}");
            WriteLine($"最大值:{max},\n最小值:{min}");
            ReadKey();
        }
    }
}

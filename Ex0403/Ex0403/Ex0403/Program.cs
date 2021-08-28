using System;
using static System.Console;
namespace Ex0403
{
    class Program
    {
        static void Main(string[] args)
        {
            //ushort最小值是0，最大值是65535。
            ushort guess = 79;
            Write("請輸入0~100數字");
            ushort result = ushort.Parse(ReadLine());
            //三元運算if/else
            //前面必須要有一個判斷式
            WriteLine(result > guess ? 
                $"{result} 大於 {guess}" ://true
                $"{result} 小於 {guess}");//false
            WriteLine(result > guess ? 
                $"{guess}平方根 = {Math.Sqrt(guess):f6}" ://true
                $"{result}的三次方 =  {Math.Pow(result, 3):N0}");//false
            ReadKey();
        }
    }
}

using System;
using static System.Console;
namespace Ex0305
{
    class Program
    {
        static void Main(string[] args)
        {
            // const 資料型別 常數名稱 = 常數值
            // 希望值不變
            const float Square = 3.0579F;
            float area;
            Write("請輸入坪數");
            area = float.Parse(ReadLine());
            WriteLine($"{area} = {Square * area}平方公尺");
            ReadKey();
        }
    }
}

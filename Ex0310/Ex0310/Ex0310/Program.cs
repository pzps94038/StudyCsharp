using System;
using static System.Console;
namespace Ex0310
{
    class Program
    {
        static void Main(string[] args)
        {
            string thisDay, birth;
            //DateTime物件
            DateTime special, Atonce;
            Write("請輸入你的生日");
            birth = ReadLine();
            special = Convert.ToDateTime(birth);
            Atonce = DateTime.Now;
            thisDay = Convert.ToString(Atonce);
            WriteLine($"今天是{thisDay},你的生日是{special}");
            ReadKey();
        }
    }
}

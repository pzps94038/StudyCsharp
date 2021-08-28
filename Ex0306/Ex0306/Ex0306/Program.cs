using System;
using static System.Console;
namespace Ex0306
{
    class Program
    {
        //列舉City 指定型別short短整數
        enum City :short{
            Kaohsiung = 800,
            Tainan = 700,
            Sinjhu =300,
            Taijhong = 400,
            Taipei = 100
        }
        static void Main(string[] args)
        {
            //宣告列舉變數
            City zone1, zone2;
            short pt1, pt2;
            //存取列舉成員
            zone1 = City.Kaohsiung;
            zone2 = City.Tainan;
            //輸入常數值指定型別轉換
            pt1 = (short)City.Sinjhu;
            pt2 = (short)City.Taijhong;
            WriteLine($"城市:{zone1}, {zone2}");
            WriteLine($"新竹、台中的郵遞區號:{pt1},{pt2}");
            ReadKey();
        }
    }
}

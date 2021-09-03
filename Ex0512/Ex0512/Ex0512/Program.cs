using System;
using static System.Console;
namespace Ex0512
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Visual C# programming";//原始字串
            bool start = str.StartsWith("visual");
            WriteLine($"比對\"visual\"字串開頭結果:{(start ? "有" : "沒有")}");
            bool finish = str.EndsWith("programming");
            WriteLine($"比對\"programming\"字串結尾結果:{(finish ? "有" : "沒有")}");
            int begin = str.IndexOf("g");
            WriteLine($"比對\"g\"開始字串索引編號:{begin}");
            int last = str.LastIndexOf("g");
            WriteLine($"比對\"g\"結束字串索引編號:{last}"); 
            string secoundStr = str.Substring(begin);
            WriteLine($"子字串{secoundStr}");
            ReadKey();
        }
    }
}

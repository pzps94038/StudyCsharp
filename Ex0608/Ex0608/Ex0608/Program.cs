using System;
using static System.Console;
namespace Ex0608
{
    class Program
    {
        static void Main(string[] args)
        {

            Timeinfo time = new Timeinfo();            
            //取得現在時間
            DateTime Nowtime = DateTime.Now;
            //取得現在時間的小時
            int hr = Nowtime.Hour;
            time.ShowTime(hr);
            ReadKey();
        }
    }
}

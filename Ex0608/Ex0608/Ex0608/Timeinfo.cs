using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Ex0608
{
    class Timeinfo
    {
        public Timeinfo() { WriteLine("呼叫時間"); }
        ~Timeinfo() { WriteLine("解構函式啟用..."); }
        public int Hrs { get; set; }
        public void ShowTime(int tm) 
        {
            Hrs = tm;
            if (Hrs > 12)
            {
                WriteLine($"現在是下午:{Hrs}點");
            }
            else
            {
                WriteLine($"現在是上午:{Hrs}點");
            };
        }

    }
}

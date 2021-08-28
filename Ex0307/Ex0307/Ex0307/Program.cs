using System;
using static System.Console;
namespace Ex0307
{
    class Program
    {
        //結構變數
        struct Computer
        {
            public int price;
            public string serial;
            public DateTime madeDate;
        }
        static void Main(string[] args)
        {
            //產生結構變數
            Computer personPC;
            //設定結構變數初值
            personPC.price = 23_750;
            personPC.madeDate = DateTime.Today;
            personPC.serial = "ZCT-20180309B";
            WriteLine($"電腦價格{personPC.price:c0}"+$"\n製造日期{personPC.madeDate}"+$"\n序號{personPC.serial}");
            ReadKey();
        }
    }
}

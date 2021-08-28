using System;
using static System.Console;
namespace Ex0405
{
    class Program
    {   
         enum Weeks 
         {
                Sunday,
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday
         }
        static void Main(string[] args)
        {
            
            Write("輸入0~6數值");
            int days = int.Parse(ReadLine());
            switch (days)
            {
                case 0:
                    WriteLine($"{Weeks.Sunday}是星期天");
                    break;
                case 1:
                    WriteLine($"{Weeks.Monday}是星期一");
                    break;
                case 2:
                    WriteLine($"{Weeks.Tuesday}是星期二");
                    break;
                case 3:
                    WriteLine($"{Weeks.Wednesday}是星期三");
                    break;
                case 4:
                    WriteLine($"{Weeks.Thursday}是星期四");
                    break;
                case 5:
                    WriteLine($"{Weeks.Friday}是星期五");
                    break;
                case 6:
                    WriteLine($"{Weeks.Saturday}是星期六");
                    break;
                default:
                    WriteLine("輸入數值錯誤");
                    break;                    
            }
            ReadKey();
        }
    }
}

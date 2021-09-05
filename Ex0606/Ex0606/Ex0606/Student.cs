using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Ex0606
{
    class Student
    {
        public string Name { get; set; }
        public int Number { get; set; }
        //設定初值得建構函式
        public Student(string title, int score) 
        {
            Name = title;
            Number = score;
            WriteLine("呼叫建構函式");
        }
        //函式
        public void judgeFrom()
        {
            Write($"Hi! {Name}, ");

            if (Number >= 90)   //多重條件前斷
                WriteLine($"分數 {Number}, 表現優良！");
            else if (Number >= 80)
                WriteLine($"分數 {Number}, 表現不錯！");
            else if (Number >= 70)
                WriteLine($"分數 {Number}, 成績尚可！");
            else if (Number >= 60)
                WriteLine($"分數 {Number}, 通過考核！");
            else
                WriteLine($"分數 {Number},要多多努力...");
        }
    }
}

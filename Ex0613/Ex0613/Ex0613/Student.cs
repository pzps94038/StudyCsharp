using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Ex0613
{
    class Student
    {
        static readonly DateTime startTime;
        public static int Count { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        static Student() 
        {
            startTime = DateTime.Now;
            WriteLine($"靜態建構函式執行的時間:{startTime.ToLongTimeString()}");
        }
        public Student(string stuName, int stuAge)
        {
            TimeSpan initTime = DateTime.Now - startTime;
            Name = stuName;
            Age = stuAge;
            Count++;
            WriteLine($"第{Count}個學生,時隔{initTime.TotalMilliseconds}\n姓名:{Name}\n年齡{Age}");
        }
        ~Student() { }

    }
}

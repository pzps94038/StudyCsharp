using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0611
{
    class Student
    {
        public static int Count { get; private set; }
        //自動實作成員屬性
        public string Name { get; set; }
        public int Age { get; set; }
        //建構函式
        public Student(string stuName, int stuAge) 
        {
            Name = stuName;
            Age = stuAge;
            Count++;
            Console.WriteLine($"第{Count}個學生,姓名:{Name,-8},年齡{Age,3}");
        }
        //解構函式
        ~Student() {  }
    }
}

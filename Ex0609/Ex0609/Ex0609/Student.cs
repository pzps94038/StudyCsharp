using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0609
{
    class Student
    {
        private int math { get; set; }
        private int eng { get; set; }
        private int comp { get; set; }
        //跟類別相同名稱為建構函式
        public Student(int sb1, int sb2)
        {
            math = sb1;
            eng = sb2;
            int sum = sb1 + sb2;
            Total(sum);
        }
        public Student(int sb1, int sb2, int sb3)
        {
            math = sb1;
            eng = sb2;
            comp = sb3;
            int sum = sb1 + sb2 + sb3;
            Total(sum);
        }
        public void Total(int result) =>
            Console.WriteLine($"總分為:{result}");               
            
    }
}

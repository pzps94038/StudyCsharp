using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0610
{
    class Student
    {
        public int Math { get; set; }
        public int English { get; set; }
        public int Comp { get; set; }
        public void Total() =>
            Console.WriteLine($"總分為: {Math + English + Comp}");
    }
}

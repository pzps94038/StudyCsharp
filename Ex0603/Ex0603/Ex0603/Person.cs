using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Ex0603
{
    class Person
    {
        private string name;
        public string title
        {
            get { return name; }
            set { name = value; }
        }
        public void Display() =>
            WriteLine($"Hi,{title}");
    }
}

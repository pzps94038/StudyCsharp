using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Ex0604
{
    class Student
    {
        public string Title { get; set; }
        public short Ages { get; set; }
        public void ShowMessage() =>
            WriteLine($"Hello,{Title,6}你的年齡:{Ages}");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0602
{
    class Student
    {
        private string name;
        //呼叫這個方法時把帶入的字串寫入name
        public void ShowName(string title) => name = title;
        //呼叫這個函式回傳name
        public string InputName() => name;
    }
}

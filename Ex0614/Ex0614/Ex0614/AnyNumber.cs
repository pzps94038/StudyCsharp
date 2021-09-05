using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0614
{
    class AnyNumber
    {
        private AnyNumber() { }
        public static int currentNum;
        static Random rand = new Random();
        public static int randnum() 
        {
            currentNum = rand.Next();
            return currentNum;
        }
    }
}

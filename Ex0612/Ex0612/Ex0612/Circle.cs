using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0612
{
    class Circle
    {
        //回傳double型態
        public static double calcPeriphery(string one) 
        {
            double periphery = double.Parse(one);
            double result = periphery * Math.PI;
            return result;
        }
        public static double CalcArea(string two) 
        {
            double area = double.Parse(two);
            double circleArea = 2 * area * area * Math.PI;
            return circleArea;
        }
    }
}

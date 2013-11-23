using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06InTheCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
            Console.WriteLine("Enter \"x\" and \"y\" coordinates:");
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            int circleRadius = 5;
            Console.WriteLine((x*x + y*y <= circleRadius*circleRadius) ? "The given coordinates are within the circle " : "The given coordinates are outside the circle");
        }
    }
}

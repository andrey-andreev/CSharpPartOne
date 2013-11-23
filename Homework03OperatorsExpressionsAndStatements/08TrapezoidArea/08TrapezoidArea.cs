using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h.
            Console.WriteLine("Enter base A:");
            double baseA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter base B:");
            double baseB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of trapezoid:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid's area is " + (((baseA + baseB) / 2) * height));
        }
    }
}

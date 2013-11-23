using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CalculateCircleParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area.
            Console.WriteLine("Hello, this program reads the radius r of a circle and prints its perimeter and area.");
            Console.WriteLine();
            Console.WriteLine("Enter the radius r:");
            double radius = double.Parse(Console.ReadLine());
            double area =  Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("area = {0}", area);
            Console.WriteLine("circumference = {0}", circumference);
        }
    }
}

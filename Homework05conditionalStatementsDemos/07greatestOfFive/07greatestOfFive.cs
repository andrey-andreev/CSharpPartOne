using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07greatestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the greatest of given 5 variables.
            Console.WriteLine("Hello, this program finds the greatest of given 5 variables.");
            Console.WriteLine();
            Console.WriteLine("Enter 5 numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            if ((a > b) && (a > c) && (a > d) && (a > e))
            {
                Console.WriteLine("The first number ({0}) is the biggest.", a);
            }
            else if ((b > c) && (b > d) && (b > e))
            {
                Console.WriteLine("The second number ({0}) is the biggest.", b);
            }
            else if ((c > d) && (c > e))
            {
                Console.WriteLine("The third number ({0}) is the biggest.", c);
            }
            else if ((d > e))
            {
                Console.WriteLine("The fourth number ({0}) is the biggest.", d);
            }
            else
            {
                Console.WriteLine("The fifth number ({0}) is the biggest.", e);
            }
        }
    }
}

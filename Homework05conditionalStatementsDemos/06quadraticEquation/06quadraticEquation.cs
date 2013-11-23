using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06quadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters the coefficients a, b and c of a quadratic equation
		    //a*x2 + b*x + c = 0
		    //and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
            Console.WriteLine("Hello, this program reads the coefficients a, b and c of a quadratic equation and calculates and prints its real roots.");
            Console.WriteLine();
            Console.WriteLine("Enter the value of coefficients a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of coefficients b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of coefficients c:");
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            double x1;
            double x2;
            if (a == 0)
            {
                Console.WriteLine("This is not a quadratic equation.");
            }
            else
            {
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("The roots of this quadratic equation are :");
                    Console.WriteLine("x1={0}", x1);
                    Console.WriteLine("x2={0}", x2);
                }
                else if (d == 0)
                {
                    x1 = (-1 * b) / (2 * a);
                    Console.WriteLine("The discriminant of this equation is 0 and x1 and x2 are equal to {0}.", x1);
                }
                else
                {
                    Console.WriteLine("The discriminant is lower than zero and this equation does not have real roots.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05compareTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
            Console.WriteLine("Hello, this program reads two numbers from console and prints the greater one.");
            Console.WriteLine();
            Console.WriteLine("Enter first number  :");
            double a = double.Parse (Console.ReadLine());
            Console.WriteLine("Enter second number :");
            double b = double.Parse(Console.ReadLine());
            // first solution 
            Console.WriteLine("The greater number is {0}.", ((a > b) ? a : b));
            // second solution 
            Console.WriteLine("The greater number is {0}.", Math.Max(a, b));
        }
    }
}

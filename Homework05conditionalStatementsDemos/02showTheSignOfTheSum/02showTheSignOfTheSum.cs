using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02showTheSignOfTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
            //Use a sequence of if statements.
            Console.WriteLine("Hello this program shows the sign (+ or -) of the product of three real numbers without calculating it. ");
            Console.WriteLine("Enter the first  number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third  number:");
            double c = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product is 0.");
            }
            if ((a > 0 && b > 0) || (a < 0 && b < 0))
            {
                if (c > 0)
                {
                    Console.WriteLine("The product has positive sign.");
                }
                else
                {
                    Console.WriteLine("The product has negative sign.");
                }
            }
            if (c > 0)
            {
                Console.WriteLine("The product has negative sign.");
            }
            else
            {
                Console.WriteLine("The product has positive sign.");
            }
        }
    }
}

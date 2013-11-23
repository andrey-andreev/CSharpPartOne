using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to print the first 100 members of the 
            //sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            Console.WriteLine("Hello, this program prints the first 100 members of the sequence of Fibonacci.");
            Console.WriteLine();
            ulong a = 0;
            ulong b = 1;
            ulong sum = a + b;
            Console.Write("{0},{1},",a ,b);
            for (ulong i = 3; i <= 100; i++)
            {
                Console.Write("{0},", sum);
                a = b;
                b = sum;
                sum = a + b;
            }
        }
    }
}

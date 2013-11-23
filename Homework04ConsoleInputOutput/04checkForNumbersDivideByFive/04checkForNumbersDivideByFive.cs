using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04checkForNumbersDivideByFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two positive integer numbers and prints how many numbers p 
            //exist between them such that the reminder of the division by 5 is 0 (inclusive). 
            //Example: p(17,25) = 2.
            Console.WriteLine("Hello, this is a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive).");
            Console.WriteLine();
            Console.WriteLine("Enter the first  integer number a=");
            uint a = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer number b=");
            uint b = uint.Parse(Console.ReadLine());
            uint count = 0;
            uint min = Math.Min(a, b);
            uint max = Math.Max(a, b);
            for (uint i = min; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("The integer numbers between {0} and {1} which can be divide without reminder are {2}", a, b, count);
        }
    }
}

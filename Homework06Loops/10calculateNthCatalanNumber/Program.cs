using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10calculateNthCatalanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 09. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula.0
            // 10. Write a program to calculate the Nth Catalan number by given N.
            Console.WriteLine("Hello, this program calculates the Nth Catalan number by given N.");
            Console.WriteLine("Enter n:");
            uint n = uint.Parse(Console.ReadLine());
            uint numerator = 1;
            uint denominator = 1;
            // Catalan numbers: 1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796....
            //           n =    0, 1, 2, 3,  4,  5,   6,   7,    8,    9,    10....
            // 
            // 1 < (n + 1) < 2n
            // (2n)! / (n + 1)!*n! = (n + 1)! * ((n + 2)...2n) / (n + 1)!*n!
            // (2n)! / (n + 1)!*n! = (n + 2)...2n / n!
            for (uint i = (n + 2); i <= 2*n; i++)
            {
                numerator *= i;
            }
            for (uint i = 1; i <= n; i++)
			{
                denominator *= i;
			}
            Console.WriteLine("Nth Catalan number is {0}", numerator / denominator);
        }
    }
}

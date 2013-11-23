using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13calculatesTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
            // N = 10  N! = 3628800 -> 2
            // N = 20  N! = 2432902008176640000 -> 4
            // Does your program work for N = 50 000?
            // Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
            Console.WriteLine("Hello, this program calculates for given N how many trailing zeros present at the end of the number N!.");
            Console.Write("Enter N: ");
            uint n = uint.Parse(Console.ReadLine());
            ushort zeros = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 5 == 0)
                {
                    zeros++;
                }
            }
            Console.WriteLine("{0}! have {1} trailing zeros.", n, zeros);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12printMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console a positive integer number N (N < 20) and outputs a 
            // matrix like the following:
            // N = 3
            // 123
            // 234
            // 345
            Console.WriteLine("Enter n (n<20):");
            uint n = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0} ", i + j - 1);
                    
                }
                Console.WriteLine(" ");
            }
        }
    }
}

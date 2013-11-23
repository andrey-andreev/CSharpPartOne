using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06calculateExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
            Console.WriteLine("Hello, this program calculates the sumS = 1 + 1!/X + 2!/X^2 + ... + N!/X^N");
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x: ");
            double x = int.Parse(Console.ReadLine());
            double sum = 1;
            double factorial = 1;
            double denominator = 1;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;
                denominator *= x;
                sum = sum + factorial / denominator ;
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}

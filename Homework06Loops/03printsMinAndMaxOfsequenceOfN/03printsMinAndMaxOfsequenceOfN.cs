using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03printsMinAndMaxOfsequenceOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
            Console.WriteLine("Hello, this program reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.");
            Console.WriteLine("Enter the value of \"N\": ");
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number: ");
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber <= min)
                {
                    min = inputNumber;
                }
                if (inputNumber >= max)
                {
                    max = inputNumber;
                }
            }
            Console.WriteLine("The minimun and maximum values of [1,{0}] are {1} and {2}.", n, min, max);

        }
    }
}

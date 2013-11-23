using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02printOneToNwithoutDivisibleBy3and7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
            Console.WriteLine("Hello, this program prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.");
            Console.WriteLine("Enter the value of \"N\": ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n ; i++)
            {
                if (i % 21 == 0)
                {
                    continue;
                }
                Console.Write(i + ",");
            }
        }
    }
}

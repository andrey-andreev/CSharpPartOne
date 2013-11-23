using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01printOneToNnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints all the numbers from 1 to N.
            Console.WriteLine("Hello, this program prints all the numbers from 1 to N.");
            Console.WriteLine("Enter the value of \"N\": ");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while (counter < n)
            {
                counter++;
                Console.WriteLine(counter);
            }
        }
    }
}

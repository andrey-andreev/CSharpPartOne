using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08printFrom1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer number n from the console and prints all the numbers 
            //in the interval [1..n], each on a single line.
            Console.WriteLine("Hello, this program read number \"n\" and print all numbers from 1 to n.");
            Console.WriteLine();
            Console.Write("Enter integer number \"n\":");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

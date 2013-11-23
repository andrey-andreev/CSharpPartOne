using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ReadAndPrintSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum.
            Console.WriteLine("Hello, this program reads 3 integer numbers from the console and prints their sum.");
            Console.WriteLine();
            Console.Write("Enter the first integer number  a=");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer number b=");
            int secondInt = int.Parse(Console.ReadLine());
            Console.Write("Enter the third integer number  c=");
            int thirdInt = int.Parse(Console.ReadLine());
            Console.WriteLine("a+b+c={0}", firstInt + secondInt + thirdInt);

        }
    }
}

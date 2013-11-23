using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03findTheBiggestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three integers using nested if statements.
            Console.WriteLine("Hello, this program finds the biggest of three integers using nested if statements.");
            Console.WriteLine("Enter the first  one integer:");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second one integer:");
            int secondInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third  one integer:");
            int thirdInt = int.Parse(Console.ReadLine());
            if (firstInt > secondInt)
            {
                if (firstInt > thirdInt)
                {
                    Console.WriteLine("The first integer is the biggest.");
                }
            }
            else
            {
                if (secondInt > thirdInt)
                {
                    Console.WriteLine("The second integer is the biggest.");
                }
                else
                {
                    Console.WriteLine("The third integer is the biggest.");
                }
            }
        }
    }
}

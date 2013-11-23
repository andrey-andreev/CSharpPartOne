using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08calculatesGCDofTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
            Console.WriteLine("Hello, this program calculates the greatest common divisor (GCD) of given two numbers.");
            Console.WriteLine("Enter the first  integer: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int secondInt = int.Parse(Console.ReadLine());
            int smallerInt = Math.Min(firstInt, secondInt);
            int biggerInt = Math.Max(firstInt, secondInt);
            int a = biggerInt % smallerInt;
            int partitionResult = 0;
            while (biggerInt % smallerInt != 0)
            {
                partitionResult = biggerInt % smallerInt;
                biggerInt = smallerInt;
                smallerInt = partitionResult;
            }
            if (partitionResult == 0)
            {
                Console.WriteLine("GCD ({0},{1})={2}", firstInt, secondInt, smallerInt);
            }
            else if (partitionResult > 1)
            {
                Console.WriteLine("GCD ({0},{1})={2}", firstInt, secondInt, partitionResult);
            }
            else
            {
                Console.WriteLine("({0} and {1}) doesn't have GCD.", firstInt, secondInt);
            }
        }
    }
}

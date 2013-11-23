using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07calcSumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
            Console.WriteLine("Hello, this program calculates the sum of n numbers.");
            Console.WriteLine();
            Console.WriteLine("Enter how many numbers \"n\" you want to entered:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number:");
                int inputNum = int.Parse(Console.ReadLine());
                sum += inputNum;
            }
            Console.WriteLine("The sum of all {0} numbers is {1}.",n ,sum);
        }
    }
}

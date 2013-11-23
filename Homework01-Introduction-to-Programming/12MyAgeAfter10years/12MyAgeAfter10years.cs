using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MyAgeAfter10years
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read your age from the console and print how old you will be after 10 years.
            Console.WriteLine("Enter your age:");
            int currentAge = int.Parse (Console.ReadLine());
            Console.WriteLine("After ten years your age will be " + (currentAge + 10));
        }
    }
}

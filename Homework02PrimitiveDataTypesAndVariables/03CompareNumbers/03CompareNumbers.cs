using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CompareFloatingPointNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that safely compares floating-point numbers 
            //with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  
            //(5.00000001 ; 5.00000003)  true
            Console.WriteLine("Please type the first number:");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please type the second number:");
            decimal num2 = decimal.Parse(Console.ReadLine());
            bool compare = Math.Abs(num1 - num2) <= 0.000001m;
            if (compare)
            {
                Console.WriteLine("The two numbers are equal with precision of 0.000001");
            }
            else
            {
                Console.WriteLine("The two numbers are not equal");
            }
        }
    }
}

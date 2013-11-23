using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints an isosceles triangle of 9 copyright 
            //symbols ©. Use Windows Character Map to find the Unicode code of 
            //the © symbol. Note: the © symbol may be displayed incorrectly.

            Console.OutputEncoding = Encoding.UTF8; //without this row the copyright symbol doesn't print right in console
            Console.WriteLine("Enter the leg length of the triangle:");
            int leg = int.Parse(Console.ReadLine());
            for (int i = 1; i <= leg; i++)
            {
                Console.Write(new string(' ', (leg - i)));
                Console.Write(new string('©', 2 * i - 1));
                Console.WriteLine();
            }
        }
    }
}

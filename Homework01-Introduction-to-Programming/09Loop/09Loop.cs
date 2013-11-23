using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints the first 10 members of the 
            //sequence: 2, -3, 4, -5, 6, -7, ...
            for (int i = 2;  i<= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                }
                else 
                {
                    Console.Write(-1 * i);
                }
                Console.Write(", ");
            }
        }
    }
}

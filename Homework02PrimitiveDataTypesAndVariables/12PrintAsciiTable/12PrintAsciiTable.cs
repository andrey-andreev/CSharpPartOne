using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12PrintAsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII (American Standard Code 
            //for Information Interchange) and write a program that prints the 
            //entire ASCII table of characters on the console.
            
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine("{0} - {1}", i, (char)i);
            }
        }
    }
}

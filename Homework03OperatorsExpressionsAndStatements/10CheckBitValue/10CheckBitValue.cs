using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CheckBitValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a boolean expression that returns if the bit at position p (counting from 0) in a 
            //given integer number v has value of 1. Example: v=5; p=1  false.
            Console.WriteLine ("Enter an integer \"v\":");
            int v = int.Parse (Console.ReadLine());
            Console.WriteLine ("Enter the bit position \"p\":");
            byte p = byte.Parse (Console.ReadLine());
            Console.WriteLine ("Your integer is {0} ({1})",v ,Convert.ToString (v, 2));
            bool isOne = (((v >> p) & 1) == 1);
            Console.WriteLine ("The bit in position {0} is 1 -> {1}", p , isOne);
            
        }
    }
}

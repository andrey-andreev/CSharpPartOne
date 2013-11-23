using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ChangeBitValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of 
            //operators that modifies n to hold the value v at the position p from the binary representation of n.
	        //Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	        //n = 5 (00000101), p=2, v=0  1 (00000001)
            Console.WriteLine ("Enter an integer \"n\":");
            int n = int.Parse (Console.ReadLine());
            Console.WriteLine ("Enter a bit value \"v\"(0 or 1):");
            byte v = byte.Parse (Console.ReadLine());
            Console.WriteLine ("Enter the position of the bit \"p\" (from 0 to 31):");
            int p = int.Parse (Console.ReadLine());
            Console.WriteLine ("before n = {0}", n);
            Console.WriteLine("{0}", Convert.ToString(n, 2).PadLeft((p+1), '0'));
            if (v == 1)
            {
	            n = n | (1 << p);
            }
            else
            {
	            n = n & (~(1 << p));
            }
            Console.WriteLine("after  n = {0}", n);
            Console.WriteLine("{0}",Convert.ToString(n, 2));
        }
    }
}

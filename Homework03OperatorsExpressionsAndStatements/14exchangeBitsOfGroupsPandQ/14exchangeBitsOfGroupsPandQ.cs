using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14exchangeBitsOfGroupsPandQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
            Console.WriteLine ("Enter integer number \"n\":");
            int n = int.Parse (Console.ReadLine());
            Console.WriteLine ("Enter the 1st bit position \"p\" (0-30):");
            int p = int.Parse (Console.ReadLine());
            Console.WriteLine ("Enter the numbers of bit positions for exchange \"k\" (1-{0}):", (31-p)/2 );
            int k = int.Parse (Console.ReadLine());
            Console.WriteLine ("Enter the 1st bit position \"q\" ({0}-{1}):", p+k, 31-k);
            int q = int.Parse (Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("before n = {0}", n);
            Console.WriteLine("{0}", Convert.ToString(n, 2).PadLeft((q + k + 1), '0'));

            for (int i = 0; i <= k-1; i++)
            {
                int tempValueGroupP = ((n >> p+i) & 1);
                int tempValueGroupQ = ((n >> q+i) & 1);
                if (tempValueGroupP == 1)
                {
                    n = n | (1 << q + i);
                }
                else
                {
                    n = n & (~(1 << q + i));
                }
                if (tempValueGroupQ == 1)
                {
                    n = n | (1 << p + i);
                }
                else
                {
                    n = n & (~(1 << p + i));
                }
            }
            Console.WriteLine("after  n = {0}", n);
            Console.WriteLine("{0}", Convert.ToString(n, 2).PadLeft((q + k + 1), '0'));
        }
    }
}

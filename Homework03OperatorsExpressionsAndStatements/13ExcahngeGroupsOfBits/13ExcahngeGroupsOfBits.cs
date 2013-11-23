using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ExcahngeGroupsOfBits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

            Console.WriteLine ("Enter an integer \"n\":");
            int n = int.Parse (Console.ReadLine());
            Console.WriteLine("before n = {0}", n);
            Console.WriteLine("{0}", Convert.ToString(n, 2).PadLeft(31, '0'));
            int pos3 = ((n >> 3) & 1);
            int pos4 = ((n >> 4) & 1);
            int pos5 = ((n >> 5) & 1);
            int pos24 = ((n >> 24) & 1);
            int pos25 = ((n >> 25) & 1);
            int pos26 = ((n >> 26) & 1);

            if (pos3 == 1)
            {
                n = n | (1 << 24);
            }
            else
            {
                n = n & (~(1 << 24));
            }
            if (pos4 == 1)
            {
                n = n | (1 << 25);
            }
            else
            {
                n = n & (~(1 << 25));
            }
            if (pos5 == 1)
            {
                n = n | (1 << 26);
            }
            else
            {
                n = n & (~(1 << 26));
            }
            if (pos24 == 1)
            {
                n = n | (1 << 3);
            }
            else
            {
                n = n & (~(1 << 3));
            }
            if (pos25 == 1)
            {
                n = n | (1 << 4);
            }
            else
            {
                n = n & (~(1 << 4));
            }
            if (pos26 == 1)
            {
                n = n | (1 << 5);
            }
            else
            {
                n = n & (~(1 << 5));
            }
            Console.WriteLine("after  n = {0}", n);
            Console.WriteLine("{0}", Convert.ToString(n, 2).PadLeft(31, '0'));
        }
    }
}

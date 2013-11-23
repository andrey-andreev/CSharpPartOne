using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04divideFactorialNandFactorialK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!/K! for given N and K (1<K<N).
            Console.WriteLine("Hello, this program calculates N!/K! for given N and K (1<K<N).");
            Console.WriteLine("Enter the value of \"N\": ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of \"K\" (1<K<N): ");
            uint k = uint.Parse(Console.ReadLine());
            BigInteger result = 1;
            // N!/K! = (1...K...N)/(1...K)
            // N!/K! = (K+1)(K+2)...N
            for (uint i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("The result of {0}!/{1}! is {2}.",n ,k ,result);
        }
    }
}

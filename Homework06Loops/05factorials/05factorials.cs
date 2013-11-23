using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
            Console.WriteLine("Hello, this program calculates N!*K! / (K-N)! for given N and K (1<N<K).");
            Console.WriteLine("Enter the value of \"K\": ");
            uint k = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of \"N\" (1<N<K): ");
            uint n = uint.Parse(Console.ReadLine());
            BigInteger result = 1;
            // N!*K! / (K-N)! = N!*(1...(K-N)...K)!  / (K-N)!
            // N!*K! / (K-N)! = N!*(K-N)!*(K-N+1)*(K-N+2)...K  / (K-N)!
            // N!*K! / (K-N)! = ( N!*(K-N)!*(K-N+1)*(K-N+2)...K ) / (K-N)!
            // N!*K! / (K-N)! = (N!*(K-N+1)*(K-N+2)...K
            for (uint i = k - n + 1; i <= k; i++)
            {
                result *= i;
            }
            for (uint i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("The result of {0}!*{1}!/({0}-{1})! is {2}.", n, k, result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given positive integer number n (n ≤ 100) 
            //is prime. E.g. 37 is prime.
            Console.Write("Enter a positive integer \"n\" (n <= 100):");
            byte n = byte.Parse(Console.ReadLine());
            bool isPrime = true;
            for (byte i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("The number {0} is a prime number.", n);
            }
            else
            {
                Console.WriteLine("The number {0} isn't a prime number.", n);
            }
        }
    }
}

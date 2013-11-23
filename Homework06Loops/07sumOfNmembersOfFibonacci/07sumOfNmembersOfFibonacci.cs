using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07sumOfNmembersOfFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number N and calculates the sum of the first N members of the sequence 
            //of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            //Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
            Console.WriteLine("Hello this program reads a number N and calculates the sum of the first N members of the sequence of Fibonacci.");
            Console.WriteLine("Enter n: ");
            uint n = uint.Parse(Console.ReadLine());
            uint memberA = 0;
            uint memberB = 1;
            uint memberC = memberA + memberB;
            uint sum = memberA + memberB;
            for (int i = 3; i <= n; i++)
            {
                sum += memberC;
                memberA = memberB;
                memberB = memberC;
                memberC = memberA + memberB;
                
            }
            Console.WriteLine("The sum of the first {0} members of Fibonacci senquence is {1}", n, sum);
        }
    }
}

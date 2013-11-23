using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given integer is odd or even.

            Console.WriteLine("Enter an integer:");
            int int1 = int.Parse(Console.ReadLine());
            if (( int1 % 2 ) == 0)
            {
                Console.WriteLine("The integer you entered is even.");
            }
            else
            {
                Console.WriteLine("The integer you entered is odd.");
            }
        }
    }
}

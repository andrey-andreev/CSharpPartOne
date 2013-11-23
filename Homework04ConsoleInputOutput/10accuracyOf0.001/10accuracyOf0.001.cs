using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10accuracyOf0._001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
            Console.WriteLine("Hello, this program calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...");
            Console.WriteLine();
            float sum = 1;
            //After the denominator is bigger than 10000 the accuracy (0.001) of the sum does not change.
            for (float i = 2; i <= 10000; i += 2)   
            {
                sum = sum + (1 / i) - 1 / (i + 1);
            }
            Console.WriteLine("The sum is {0:0.000}", sum);
        }
    }
}

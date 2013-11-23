using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DivideByFiveAndSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a boolean expression that checks for given integer if it 
            //can be divided (without remainder) by 7 and 5 in the same time.
            Console.WriteLine("Enter an integer:");
            int integer = int.Parse(Console.ReadLine());
            bool divideByFive = ((integer % 5) == 0);
            bool divideBySeven = ((integer % 7) == 0);
            if ((divideByFive && divideBySeven) == true)
            {
                Console.WriteLine("The integer you entered can be divide by 5 and 7.");
            }
            else
            {
                Console.WriteLine("The integer you entered can't be divide by 5 and 7.");
            }
        }
    }
}

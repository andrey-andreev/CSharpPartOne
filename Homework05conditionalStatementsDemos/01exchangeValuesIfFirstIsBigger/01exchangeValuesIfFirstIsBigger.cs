using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01exchangeValuesIfFirstIsBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
            Console.WriteLine("Hello, this program examines two integer variables and exchanges their values if the first one is greater than the second one.");
            Console.WriteLine("Enter the first  one integer:");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second one integer:");
            int secondInt = int.Parse(Console.ReadLine());
            int tempInt = 0;
            if (firstInt > secondInt)
            {
                tempInt = firstInt;
                firstInt = secondInt;
                secondInt = tempInt;
                Console.WriteLine("First  integer now is {0}.", firstInt);
                Console.WriteLine("Second integer now is {0}.", secondInt);
            }
            else
            {
                Console.WriteLine("The first integer is bigger than the second one.");
            }
        }
    }
}

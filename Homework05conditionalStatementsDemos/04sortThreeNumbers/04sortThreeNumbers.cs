using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04sortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort 3 real values in descending order using nested if statements.
            Console.WriteLine("Hello, this program sorts 3 real numbers in descending order.");
            Console.WriteLine("Enter the first  number:");
            double firstInt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double secondInt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third  number:");
            double thirdInt = double.Parse(Console.ReadLine());
            if (firstInt > secondInt)
            {
                if (firstInt > thirdInt)
                {
                    if (secondInt > thirdInt)
                    {
                        Console.WriteLine("The numbers in descending order {0}, {1}, {2}", firstInt, secondInt, thirdInt);
                    }
                    else
                    {
                        Console.WriteLine("The numbers in descending order {0}, {1}, {2}", firstInt, thirdInt, secondInt);
                    }
                }
                else
                {
                    Console.WriteLine("The numbers in descending order {0}, {1}, {2}", thirdInt, firstInt, secondInt);
                }
            }
            else
            {
                if (thirdInt> secondInt)
                {
                    Console.WriteLine("The numbers in descending order {0}, {1}, {2}", thirdInt, secondInt, firstInt);
                }
                else
                {
                    if (firstInt > thirdInt)
                    {
                        Console.WriteLine("The numbers in descending order {0}, {1}, {2}", secondInt, firstInt, thirdInt);
                    }
                    else
                    {
                        Console.WriteLine("The numbers in descending order {0}, {1}, {2}", secondInt, thirdInt, firstInt);
                    }
                }
            }
        }
    }
}

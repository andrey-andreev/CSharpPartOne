using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11numberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Write a program that converts a number in the range [0...999] to a text corresponding 
            //to its English pronunciation. Examples:
            //0  "Zero"
            //273  "Two hundred seventy three"
            //400  "Four hundred"
            //501  "Five hundred and one"
            //711  "Seven hundred and eleven"
            Console.WriteLine("Hello, this program converts a number in the range [0...999] to a text corresponding to its English pronunciation");
            Console.WriteLine();
            Console.WriteLine("Enter a number in the range [0...999].");
            int inputNum = int.Parse(Console.ReadLine());
            int ones = inputNum % 10;
            int tens = (inputNum / 10) % 10;
            int hundreds = inputNum / 100;
            
            switch (hundreds)
            {
                case 0: break;
                case 1: 
                    Console.Write("one hundred"); 
                    break;
                case 2: 
                    Console.Write("two hundreds"); 
                    break;
                case 3: 
                    Console.Write("three hundreds"); 
                    break;
                case 4: 
                    Console.Write("four hundreds"); 
                    break;
                case 5: 
                    Console.Write("five hundreds"); 
                    break;
                case 6: 
                    Console.Write("six hundreds"); 
                    break;
                case 7: 
                    Console.Write("seven hundreds"); 
                    break;
                case 8: 
                    Console.Write("eight hundreds"); 
                    break;
                case 9: 
                    Console.Write("nine hundreds"); 
                    break;
            }
            if ((hundreds != 0) && ((tens != 0) || (ones != 0)))
            {
                Console.Write(" and ");
            }
            switch (tens)
            {
                case 2: 
                    Console.Write("twenty"); 
                    break;
                case 3: 
                    Console.Write("thirty"); 
                    break;
                case 4: 
                    Console.Write("fourty"); 
                    break;
                case 5: 
                    Console.Write("fifty"); 
                    break;
                case 6: 
                    Console.Write("sixty"); 
                    break;
                case 7: 
                    Console.Write("seventy"); 
                    break;
                case 8: 
                    Console.Write("eighty"); 
                    break;
                case 9: 
                    Console.Write("ninety"); 
                    break;
            }
            if ((tens != 0) && (tens != 1) && (ones != 0))
            {
                Console.Write("-");
            }
            switch (inputNum % 100)
            {
                case 10:
                    Console.Write("ten");
                    break;
                case 11:
                    Console.Write("eleven");
                    break;
                case 12:
                    Console.Write("twelve");
                    break;
                case 13:
                    Console.Write("thirteen");
                    break;
                case 14:
                    Console.Write("fourteen");
                    break;
                case 15:
                    Console.Write("fifteen");
                    break;
                case 16:
                    Console.Write("sixteen");
                    break;
                case 17:
                    Console.Write("seventeen");
                    break;
                case 18:
                    Console.Write("eighteen");
                    break;
                case 19:
                    Console.Write("nineteen");
                    break;
            }
            if (tens != 1)
            {
                switch (ones)
                {
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                }
            }
            
            Console.WriteLine();
        }
    }
}

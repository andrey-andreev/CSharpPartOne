using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11print52CardsDesck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
            //The cards should be printed with their English names. Use nested for loops and switch-case.
            Console.WriteLine("Hello, this program prints all possible cards from a standard deck of 52 cards (without jokers).");
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.Write("Two of ");
                            break;
                        case 1:
                            Console.Write("Three of ");
                            break;
                        case 2:
                            Console.Write("Four of ");
                            break;
                        case 3:
                            Console.Write("Five of ");
                            break;
                        case 4:
                            Console.Write("Six of ");
                            break;
                        case 5:
                            Console.Write("Seven of ");
                            break;
                        case 6:
                            Console.Write("Eight of ");
                            break;
                        case 7:
                            Console.Write("Nine of ");
                            break;
                        case 8:
                            Console.Write("Ten of ");
                            break;
                        case 9:
                            Console.Write("Jack of ");
                            break;
                        case 10:
                            Console.Write("Queen of ");
                            break;
                        case 11:
                            Console.Write("King of ");
                            break;
                        case 12:
                            Console.Write("Ace of ");
                            break;
                    }
                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("clubs");
                            break;
                        case 1:
                            Console.WriteLine("diamonds");
                            break;
                        case 2:
                            Console.WriteLine("hearts");
                            break;
                        case 3:
                            Console.WriteLine("spades");
                            break;
                    }
                }
            }
        }
    }
}

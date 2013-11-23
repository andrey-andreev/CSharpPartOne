using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08dataTypeChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the user's choice inputs int, double or string variable. If the 
            //variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
            //The program must show the value of that variable as a console output. Use switch statement.
            Console.WriteLine("What kind of data type you want to input? (1 for integer; 2 for double; 3 for string)");
            byte dataTypeChoice = byte.Parse(Console.ReadLine());
            switch (dataTypeChoice)
            {
                case 1:
                    Console.WriteLine("Enter an integer number: ");
                    int inputInt = int.Parse(Console.ReadLine());
                    inputInt += 1;
                    Console.WriteLine(inputInt);
                    break;
                case 2:
                    Console.WriteLine("Enter a real number: ");
                    double inputDouble = double.Parse(Console.ReadLine());
                    inputDouble += 1;
                    Console.WriteLine(inputDouble);
                    break;
                case 3:
                    Console.WriteLine("Enter a string: ");
                    string inputString = Console.ReadLine();
                    Console.WriteLine(inputString + "*");
                    break;
                default: 
                    Console.WriteLine("Wrong input!"); 
                    break;
            }
        }
    }
}

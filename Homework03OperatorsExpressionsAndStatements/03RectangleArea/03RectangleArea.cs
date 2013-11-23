using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates rectangle’s area by given 
            //width and height.
            Console.WriteLine("Enter width of the rectagle:");
            decimal rectangleWigth = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of the rectagle:");
            decimal rectangleHeight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The area of the rectagle is : " + ( rectangleWigth * rectangleHeight));
        }
    }
}

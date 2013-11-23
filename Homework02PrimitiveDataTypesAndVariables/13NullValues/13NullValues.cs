using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13NullValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that assigns null values to an integer and to 
            //double variables. Try to print them on the console, try to add 
            //some values or the null literal to them and see the result.
            
            //Declare variables
            int? a = null;
            double? b = null;
            
            //Print a,b with null literals
            Console.WriteLine("Result when a and b have null literals:");
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
            
            //Add values
            a = 7;
            b = 13;
            //Print a,b after add some values
            Console.WriteLine("Result after we add some values to a and b:");
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare  two integer variables and assign them with 5 and 10 
            //and after that exchange their values.

            //Declare variables
            int x = 5;
            int y = 10;
            //Print results
            Console.WriteLine("x= {0}", x);
            Console.WriteLine("y= {0}", y);
            
            //Exchange values
            y = y - x;
            x = y + x;
            //Print results after exchange
            Console.WriteLine();
            Console.WriteLine("After exchange:");
            Console.WriteLine("x= {0}", x);
            Console.WriteLine("y= {0}", y);
        }
    }
}

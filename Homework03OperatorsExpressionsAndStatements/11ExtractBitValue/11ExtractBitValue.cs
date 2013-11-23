using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ExtractBitValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that extracts from a given integer i the value of a given bit 
            //number b. Example: i=5; b=2  value=1.
            Console.WriteLine ("Enter an integer \"i\":");
            int i = int.Parse (Console.ReadLine());
            Console.WriteLine ("Enter a bit number \"p\":");
            int bitNum = int.Parse (Console.ReadLine());
            Console.WriteLine ("Your integer is {0} ({1})",i ,Convert.ToString (i, 2));
            Console.WriteLine (((i >> bitNum) & 1) == 1 ? "The value of the bit is 1." : "The value of the bit is 0.");
        }
    }
}

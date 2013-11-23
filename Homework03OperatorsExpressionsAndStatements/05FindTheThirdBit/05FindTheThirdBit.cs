using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05FindTheThirdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a boolean expression for finding if the bit 3 (counting from 0) of a 
            //given integer is 1 or 0.
            Console.WriteLine ("Enter an integer:");
            int i = int.Parse (Console.ReadLine());
            Console.WriteLine ("i={0} ({1})", i, Convert.ToString (i, 2) );
            Console.WriteLine (((i >> 3) & 1) == 1 ? "The bit 3 is 1." : "The bit 3 is 0.");

        }
    }
}

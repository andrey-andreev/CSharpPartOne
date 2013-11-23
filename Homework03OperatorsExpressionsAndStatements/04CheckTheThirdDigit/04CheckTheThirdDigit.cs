using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CheckTheThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given integer if its third 
            //digit (right-to-left) is 7. E. g. 1732  true.
            Console.WriteLine ("Enter an integer:");
            int i = int.Parse (Console.ReadLine());
            Console.WriteLine(((i / 100) % 10) == 7 ? "The third digit (right-to-left) of integer you have entered is 7" : "The third digit (right-to-left) of integer you have entered isn't 7");
        }
    }
}

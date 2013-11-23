using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a character variable and assign it with the symbol that 
            //has Unicode code 72. Hint: first use the Windows Calculator to 
            //find the hexadecimal representation of 72.
            char ch = '\u0048';
            Console.WriteLine("Symbol Unicode code 72 (hex 48) is {0} ", ch);
        }
    }
}

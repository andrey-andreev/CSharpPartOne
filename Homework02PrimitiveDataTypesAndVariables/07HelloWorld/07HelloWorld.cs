using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare two string variables and assign them with “Hello” and “World”. 
            //Declare an object variable and assign it with the concatenation of the 
            //first two variables (mind adding an interval). Declare a third string 
            //variable and initialize it with the value of the object variable (you 
            //should perform type casting).

            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;
            string str3 = (string)obj;
            Console.WriteLine("First string variable: " + str1);
            Console.WriteLine("Second string variable: " + str2);
            Console.WriteLine("Object variable: " + obj);
            Console.WriteLine("Third string variable: " + str3);
        }
    }
}

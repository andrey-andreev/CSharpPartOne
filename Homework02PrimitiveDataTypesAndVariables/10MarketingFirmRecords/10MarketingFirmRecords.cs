using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10MarketingFirmRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            //A marketing firm wants to keep record of its employees. Each 
            //record would have the following characteristics – first name, 
            //family name, age, gender (m or f), ID number, unique employee 
            //number (27560000 to 27569999). Declare the variables needed to 
            //keep the information for a single employee using appropriate 
            //data types and descriptive names.

            //Declare first name
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();  
            //Declare family name
            Console.WriteLine("Enter family name:");
            string familyName = Console.ReadLine(); 
            //Declare age
            Console.WriteLine("Enter age:");
            byte age = byte.Parse(Console.ReadLine());
            //Declare gender
            Console.WriteLine("Enter gender(\"m\" or \"f\")");
            char gender = char.Parse(Console.ReadLine());
            //Declare ID number
            Console.WriteLine("Enter ID number:");
            ulong idNumber = ulong.Parse(Console.ReadLine()); 
            //Declare unique number
            Console.WriteLine("Enter unique employee number(between 27560000-27569999):");
            uint uniqueNumber = uint.Parse(Console.ReadLine());             


            //Print results
            Console.WriteLine();
            Console.WriteLine("Employee record:");
            Console.WriteLine("Name: {0} {1}", firstName, familyName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("ID number: {0}", idNumber);
            Console.WriteLine("Unique employee number: {0}", uniqueNumber);
        }
    }
}

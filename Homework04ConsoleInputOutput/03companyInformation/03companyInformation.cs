using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03companyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //A company has name, address, phone number, fax number, web site and manager. 
            //The manager has first name, last name, age and a phone number. Write a program 
            //that reads the information about a company and its manager and prints them on the console.
            Console.WriteLine("Hello, this program reads and prints information about a company and it's manager.");
            Console.WriteLine();
            Console.WriteLine("Enter company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter company address:");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Enter company phone number:");
            string companyPhone = Console.ReadLine();
            Console.WriteLine("Enter company fax number:");
            string companyFax = Console.ReadLine();
            Console.WriteLine("Enter company web site:");
            string companyWeb = Console.ReadLine();
            Console.WriteLine("Enter manager first name:");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Enter manager last name:");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Enter manager age:");
            string managerAge = Console.ReadLine();
            Console.WriteLine("Enter manager phone number:");
            string managerPhoneNum = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Company information");
            Console.WriteLine("Name               : {0}", companyName);
            Console.WriteLine("Address            : {0}", companyAddress);
            Console.WriteLine("Phone number       : {0}", companyPhone);
            Console.WriteLine("Fax number         : {0}", companyFax);
            Console.WriteLine("Web site           : {0}", companyWeb);
            Console.WriteLine("");
            Console.WriteLine("Manager information");
            Console.WriteLine("Name               : {0} {1}", managerFirstName, managerLastName);
            Console.WriteLine("Age                : {0}", managerAge);
            Console.WriteLine("Phone number       : {0}", managerPhoneNum);
        }
    }
}

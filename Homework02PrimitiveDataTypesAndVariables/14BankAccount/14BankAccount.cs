using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //A bank account has a holder name (first name, middle name and 
            //last name), available amount of money (balance), bank name, 
            //IBAN, BIC code and 3 credit card numbers associated with the 
            //account. Declare the variables needed to keep the information 
            //for a single bank account using the appropriate data types and 
            //descriptive names.
            
            //Declare variables
            string firstName = "Ivan";
            string midName = "Ivanov";
            string lastName = "Ivanov";
            decimal balance = 123456789.1234578m;
            string bankName = "FIB";
            string iban = "BG12FINV91501234123412";
            string bic = "FINVBGSF";
            ulong creditCardOne = 4000111111111111u;
            ulong creditCardTwo = 4000222222222222u;
            ulong creditCardThree = 4033333333333333u;

            //Print results
            Console.WriteLine();
            Console.WriteLine("Holder name: {0} {1} {2}", firstName, midName, lastName);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("BIC code: {0}", bic);
            Console.WriteLine("Credit card 1: {0:0000 0000 0000 0000}", creditCardOne);
            Console.WriteLine("Credit card 2: {0:0000 0000 0000 0000}", creditCardTwo);
            Console.WriteLine("Credit card 3: {0:0000 0000 0000 0000}", creditCardThree);
        }
    }
}

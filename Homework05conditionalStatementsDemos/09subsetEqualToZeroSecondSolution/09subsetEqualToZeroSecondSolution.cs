using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09subsetEqualToZeroSecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given 5 integer numbers. Write a program that checks if the sum of some subset 
            //of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
            Console.WriteLine("Hello, this program checks if the sum of some subset of them is 0.");
            Console.WriteLine();
            Console.Write("Enter the count of integers:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            bool isFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter an integer: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int subset = 1; subset < Math.Pow(2, n); subset++)
            {
                int sum = 0;
                string subsetStr = string.Empty;
                for (int pos = 0; pos < n; pos++)
                {

                    bool isOne = (((subset >> pos) & 1) == 1);
                    if (isOne == true)
                    {
                        sum += arr[pos];
                        subsetStr += arr[pos] + ",";
                    }
                }
                if (sum == 0)
                {
                    isFound = true;
                    Console.WriteLine(subsetStr);
                }
            }
            if (isFound)
            {
                Console.WriteLine("These are all the subsets sums equal to zero.");
            }
            else
            {
                Console.WriteLine("There is no subset with sum equal to zero.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14printSpiral
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a positive integer number N (N < 20) from console and outputs in the console 
            // the numbers 1 ... N numbers arranged as a spiral.
		    // Example for N = 4
            //  1  2  3  4
            // 12 13 14  5
            // 11 16 15  6
            // 10  9  8  7
            
            //check for correct input
            Console.WriteLine("Enter positive integer number N (N < 20)");
            int n = 0;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input is incorrect.Try again.");
                }
            }
            //declare variables
            int[,] mat = new int[n,n];
            int col = 0;
            int row = 0;
            int maxCol = n;
            int maxRow = n;
            int value = 1;

            while (value <= n * n)
            {
                //right
                for (int i = col; i < maxCol; i++)
                {
                    mat[row, i] = value;
                    value++;
                }
                row++;
                //down
                for (int i = row; i < maxRow; i++)
                {
                    mat[i, maxCol - 1] = value;
                    value++;
                }
                maxCol--;
                //left
                for (int i = maxCol - 1; i >= col; i--)
                {
                    mat[maxRow - 1, i] = value;
                    value++;
                }
                maxRow--;
                //up
                for (int i = maxRow - 1; i >= row; i--)
                {
                    mat[i, col] = value;
                    value++;
                }
                col++;
            }
            //print the matrix
            for (int printRow = 0; printRow < n; printRow++)
            {
                for (int printCol = 0; printCol < n; printCol++)
                {
                    Console.Write("{0,4}", mat[printRow, printCol]); ;
                }
                Console.WriteLine();
            }

        }
    }
}

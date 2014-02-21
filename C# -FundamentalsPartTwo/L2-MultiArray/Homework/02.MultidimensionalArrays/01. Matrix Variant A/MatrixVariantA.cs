/*
* 1. Write a program that fills and prints a matrix of size (n, n) as shown below:
* (examples for n = 4)
* 
* 1  5   9  13
* 2  6  10  14
* 3  7  11  15
* 4  8  12  16
* 
*/

using System;
class MatrixVariantA
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number N (size of square): ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //initialize
        int[,] arr = new int[n, n];

        //fill with elements
        for (int row = 0; row < n; row++)
        {
           int count = 1 + row;
            for (int col = 0; col < n; col++)
            {
                arr[row, col] = count;
                count += n;
            }
        }

        //print result
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(Convert.ToString(arr[row, col]).PadLeft(n - 1, ' '));
            }
            Console.WriteLine("\n");
        }
    }
}

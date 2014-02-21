/*
* 1. Write a program that fills and prints a matrix of size (n, n) as shown below:
* (examples for n = 4)
* 
* 7  11  14  16
* 4   8  12  15
* 2   5   9  13
* 1   3   6  10
* 
*/
using System;

class MatrixVariantC
{
    static void Main()
    {
        Console.Write("Enter a number N (size of square): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        
        int count = 1;

        for (int index = 0; index < n; index++)
        {
            int row = n - index -1;
            int col = 0;
          
            for (int repeat = 0; repeat <= index; repeat++)
            {
                matrix[row++, col++] = count++;
            }
        }

        for (int index = 0; index < n-1; index++)
        {
            int row = 0;
            int col = index+1;

            for (int repeat = n-1; repeat > 0 + index; repeat--)
            {
                matrix[row++, col++] = count++;
            }
        }

        
        // Prints matrix
        Console.WriteLine();
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4} ", matrix[row, col]);
            }

            Console.WriteLine("\n");
        }
    }
}
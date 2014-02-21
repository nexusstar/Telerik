/*
* 5. Write a program that reads a text file containing a square
* matrix of numbers and finds in the matrix an area of size 2 x 2
* with a maximal sum of its elements. The first line in the input
* file contains the size of matrix N. Each of the next N lines
* contain N numbers separated by space. The output should be a
* single number in a separate text file.
*  Used matrix
*
*     5   
*  |  1 1 1 1 1
*  |  4 5 5 4 1
*  |  4 5 5 4 1 ---> 20 
*  |  4 4 4 4 1
*  |  2 2 2 2 1
*  
*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MaxSumOfSquareMatrix
{
    static void Main()
    {
        string path = @"..\..\Files\matrix.txt";
        StreamReader reader = new StreamReader(path);
        int[,] matrix;

        Console.WriteLine("Loading..");

        using (reader)
        {
            int n = int.Parse(reader.ReadLine().Trim());
            matrix = new int[n, n];
            int row = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] tokens = line.Split(null as char[], 
                    StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(tokens[col]);
                }
                row++;
            }
        }
        Console.WriteLine("Success reading file..");

        PrintMatrix(matrix);
        int bestRow = 0;
        int bestCol = 0;
        int bestSum = 0;

        FindBestSquare(matrix, ref bestRow, ref bestCol, ref bestSum);
        PrintBestSquare(matrix, bestRow, bestCol, bestSum);


    }

    static void FindBestSquare(int[,] matrix, ref int bestRow, ref int bestCol, ref int bestSum)
    {
        for (int row = 0; row < matrix.GetLongLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1) - 2; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] +
                                  matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("Matrix:\n");
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
                Console.Write("{0,4}", matrix[row, col]);
            Console.WriteLine();
        }
    }
   
    static void PrintBestSquare(int[,] matrix, int bestRow, int bestCol, int bestSum)
    {
        Console.WriteLine("\nBest square with sum {0}: \n", bestSum);
        for (int i = bestRow; i < bestRow + 2; i++)
        {
            for (int j = bestCol; j < bestCol + 2; j++)
                Console.Write("{0,4}", matrix[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

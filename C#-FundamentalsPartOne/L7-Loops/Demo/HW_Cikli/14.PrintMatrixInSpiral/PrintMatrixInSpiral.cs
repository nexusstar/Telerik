﻿/* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
		Example for N = 4
 * 1    2   3   4
 * 12   13  14  5
 * 11   16  15  6
 * 10   9   8   7

*/
using System;

class PrintMatrixInSpiral
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int row = 0, col = -1;
        string direction = "right";

        Console.WriteLine();
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right")
            {
                if (matrix[row, ++col] == 0) matrix[row, col] = i; // if for the same row but the next column the value is 0 put value of i
                if (col + 1 >= n || matrix[row, col + 1] != 0) direction = "down"; //otherwize change direction
            }
            else if (direction == "down")
            {
                if (matrix[++row, col] == 0) matrix[row, col] = i; //keep column, increase row, check if value is 0 and put value of i
                if (row + 1 >= n || matrix[row + 1, col] != 0) direction = "left";
            }
            else if (direction == "left")
            {
                if (matrix[row, --col] == 0) matrix[row, col] = i;
                if (col - 1 < 0 || matrix[row, col - 1] != 0) direction = "up";
            }
            else if (direction == "up")
            {
                if (matrix[--row, col] == 0) matrix[row, col] = i;
                if (row - 1 < 0 || matrix[row - 1, col] != 0) direction = "right";
            }
        }

        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
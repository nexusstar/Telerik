/*
* 1. Write a program that fills and prints a matrix of size (n, n) as shown below:
* (examples for n = 4)
* 
* 1 12 11 10
* 2 13 16  9
* 3 14 15  8
* 4  5  6  7
* 
*/
using System;

class MatrixVariantD
{
    static void Main()
    {
        Console.Write("Enter a number N (size of square): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        string direction = "down";
        int row = -1, col = 0;

        for (int count = 1; count <= n * n; count++)
        {
            if (direction == "down")
            {
                if (matrix[++row, col] == 0) matrix[row, col] = count;
                if (!IsInsideBounds(matrix,row + 1, col)) direction = "right";
            }
            else if (direction == "right")
            {
                if (matrix[row, ++col] == 0) matrix[row, col] = count;
                if (!IsInsideBounds(matrix,row, col + 1)) direction = "up";
            }
            else if (direction == "up")
            {
                if (matrix[--row, col] == 0) matrix[row, col] = count;
                if (!IsInsideBounds(matrix, row - 1, col)) direction = "left";
            }
            else if (direction == "left")
            {
                if (matrix[row, --col] == 0) matrix[row, col] = count;
                if (!IsInsideBounds(matrix, row, col - 1)) direction = "down";
            }
        }

        Console.WriteLine();
        PrintMatrix(matrix);

    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4} ", matrix[row, col]);
            }
            Console.WriteLine("\n");
        }
    }
    static bool IsInsideBounds(int[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLength(0) &&
               col >= 0 && col < matrix.GetLength(1) && matrix[row, col] == 0;
    }
}

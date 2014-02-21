/*
* 2. Write a program that reads a rectangular matrix of size
* N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/
using System;

class MaxSumOfSqure
{
    static void Main()
    {
        Console.Write("Please enter number N (matrix rows): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter number M (matrix columns): ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        //If you want to enter matrix values
        //uncomment following method call
        //matrix = (int[,])FillUpMatrix(n, m).Clone();
        
        //OR use generated values from [0-100) randomly
        matrix = (int[,])FillUpMatrixRandom(n, m).Clone();
        
        //OR use TEST case:
        //matrix = new int[,]
        //{
        //    { 1, 1, 1, 1, 1 },
        //    { 1, 1, 1, 1, 1 },
        //    { 1, 2, 2, 2, 1 },
        //    { 1, 2, 2, 2, 1 },
        //    { 1, 2, 2, 2, 1 },
        //    { 1, 1, 1, 1, 1 },
        //    { 1, 1, 1, 1, 1 }
        //};

        PrintMatrix(matrix);

        int bestSum = 0; 
        int bestCol = 0;
        int bestRow = 0;

        //search for best 3x3 sum
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                 matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                 matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestCol = col;
                    bestRow = row;
                }
            }
        }
        Console.WriteLine("Found best sum: {0} ", bestSum);
        Console.WriteLine("Sum found from the following elements: ");
        Console.WriteLine();
        for (int row = bestRow; row <= bestRow + 2; row++)
        {
            for (int col = bestCol; col <= bestCol+2; col++)
            {
                Console.Write("{0,4} ", matrix[row,col]);
            }
            Console.WriteLine("\n");
        }
    }

    //helper method for reading values
    private static int[,] FillUpMatrix(int n, int m)
    {
        int[,] matrix = new int[n, m];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}:{1} = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    //helper method to randomly generate matrix values
    private static int[,] FillUpMatrixRandom(int n, int m)
    {
        Random random = new Random();

        int[,] matrix = new int[n, m];
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = random.Next(0, 100);
            }
        }
        
        return matrix;
    }
    
    //helper method to print matrix values
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
}

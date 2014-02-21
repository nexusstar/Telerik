/*
* 7. *Write a program that finds the largest area of equal neighbor elements in a rectangular
*    matrix and prints its size. 
*/

using System;
using System.Collections.Generic;
using System.Linq;


class LargestArea
{
    static int currentLength, bestLength = 0;
    static int bestNumber, currentNumber = 0;
    static int[,] matrix;

    static void Main()
    {
       
       matrix = new int[,]
        {
            { 1, 3, 2, 2, 2, 4 },
            { 3, 3, 3, 2, 4, 4 },
            { 4, 3, 1, 2, 3, 3 },
            { 4, 3, 1, 3, 3, 1 },
            { 4, 3, 3, 3, 1, 1 }
        };

       PrintMatrix(matrix);

       
       
       for (int row = 0; row < matrix.GetLength(0); row++)
       {
           bestLength = bestNumber = 0;
           for (int col = 0; col < matrix.GetLength(1); col++)
           {
               currentNumber = matrix[row, col];
               FindLongestArea(row, col);
               if (currentLength > bestLength)
               {
                   bestLength = currentLength;
                   bestNumber = matrix[row, col];
               }
           }
           Console.WriteLine("Best Area of number {0} -> {1} times\n", bestNumber, bestLength);  
       }
     

    }
    static void FindLongestArea( int row, int col){
        
        if (IsInsideBounds(row,col)
            && matrix[row, col] == currentNumber)
        {
            currentLength++;
            matrix[row, col] = 0;

            FindLongestArea(row + 1, col);
            FindLongestArea(row - 1, col);
            FindLongestArea(row, col + 1);
            FindLongestArea(row, col - 1);
        }
        else
        {
            return;
        }
       
    }
    static bool IsInsideBounds( int row, int col )
    {
        if (row<0 || row >= matrix.GetLength(0) || col<0 || col>=matrix.GetLength(1))
        {
            return false;  
        }
        else
        {
            return true;
        }
    }
    //helper method to find LongestArea
    
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

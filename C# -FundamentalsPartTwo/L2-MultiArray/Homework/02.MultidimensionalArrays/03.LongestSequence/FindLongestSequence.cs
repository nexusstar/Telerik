/*
* 3. We are given a matrix of strings of size N x M. Sequences in the
* matrix we define as sets of several neighbor elements located on the
* same line, column or diagonal. Write a program that finds the
* longest sequence of equal strings in the matrix.
* 
*        Example:         |        Example:
*   ------------------    |    ----------------
*   | ha  fi  ho  hi |    |    |   ss qq ss   |
*   | fo  ha  hi  xx |    |    |   pp pp ss   |
*   | xx  ho  ha  xx |    |    |   pp qq ss   |
*   ------------------    |    ----------------
*   Output: ha, ha, ha    |   Output: ss, ss, ss
*                         |
*/
using System;
using System.Linq;
using System.Text;


class FindLongestSequence
{
    static void Main()
    {
        string[,] matrix = 
        {
            { "ha", "fi", "ho", "hi" },
            { "fo", "ha", "sp", "xx" },
            { "xx", "ho", "ha", "xx" }
        };

        PrintMatrix(matrix);
        int bestCount = 0;
        string bestMatch = string.Empty;
            
            
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int nextRow = row;
                int nextCol = col;
                int currentCount = 1;
                while (IsInsideBoundsAndEqual(matrix,row,col, nextRow,nextCol+1)) //right
                {
                    currentCount++;
                    nextCol++;
                }
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestMatch = matrix[row, col];
                }
                currentCount = 1;
                nextRow = row;
                nextCol = col;
                while (IsInsideBoundsAndEqual(matrix, row,col, nextRow+1,nextCol+1)) //down diagonal
                {
                    currentCount++;
                    nextRow++;
                    nextCol++;
                }
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestMatch = matrix[row, col];
                }
                currentCount = 1;
                nextCol = col;
                nextRow = row;

                while (IsInsideBoundsAndEqual(matrix,row,col,nextRow-1,nextCol+1)) //up diagonal
                {
                    currentCount++;
                    nextRow --;
                    nextCol++;
                }
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestMatch = matrix[row, col];
                }
                currentCount = 1;
                nextCol = col;
                nextRow = row;
                    
                while (IsInsideBoundsAndEqual(matrix,row,col, nextRow+1, nextCol)) // down
                {
                    currentCount++;
                    nextRow++;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestMatch = matrix[row, col];
                }
                currentCount = 1;
                nextCol = col;
                nextRow = row;
                    
            }
        }
        Console.WriteLine("\nResult -> {0}({1} times)\n",
        String.Concat(Enumerable.Repeat(bestMatch + " ", bestCount)), bestCount);
    }


    static bool IsInsideBoundsAndEqual(string[,] matrix, int row, int col, int nextRow, int nextCol)
    {
        if (nextRow >= 0 && nextRow < matrix.GetLength(0) &&
            nextCol >= 0 && nextCol < matrix.GetLength(1) &&
            matrix[row, col] == matrix[nextRow, nextCol]   )
            return true;
        {
            return false;
                
        }
    }

    //helper method to print matrix values
    private static void PrintMatrix(string[,] matrix)
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
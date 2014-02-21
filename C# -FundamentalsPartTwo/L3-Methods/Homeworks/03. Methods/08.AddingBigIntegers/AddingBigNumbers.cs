/*
 * 08. Excercise - using matrix 
 * Write a method that adds two positive integer numbers represented as 
 * arrays of digits (each array element arr[i] contains a digit;
 * the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.
 * 
 */

using System;
using System.Collections.Generic;

class AddingBigNumbers
{
    static void Main()
    {
        int[] numArrayOne = { 9,9,9};
        int[] numArrayTwo = {9,9 };
        int[] result = AddingArrays(numArrayOne, numArrayTwo);
        Console.WriteLine(string.Join("",result));

    }

    static int[] AddingArrays(int[] firstArr, int[] secondArr)
    {
        List<int> result = new List<int>();
        int[,] addMatrix = new int[2, Math.Max(firstArr.Length, secondArr.Length)];
        int firstL = firstArr.Length-1;
        int secondL = secondArr.Length-1;

        for (int col = addMatrix.GetLength(1) - 1; col >=0; col--)
        {
            if (firstL >= 0)
            {
                addMatrix[0, col] = firstArr[firstL];
                firstL--;
            }
            if (secondL >=0)
            {
                addMatrix[1, col] = secondArr[secondL];
                secondL--;
            }
                       
        }
        bool isMoreThanTen = false;
        for (int col = addMatrix.GetLength(1) - 1; col >= 0; col--)
        {
            int addition = addMatrix[0, col] + addMatrix[1, col];
            if (isMoreThanTen)
            {
                addition++;  
            }
            result.Add(addition % 10);

            if (addition >= 10)
            {
                isMoreThanTen = true;
            }
            else
            {
                isMoreThanTen = false;
            }

        }
        if (isMoreThanTen)
        {
            result.Add(1);
        }
        int[] resultInt = result.ToArray();
        Array.Reverse(resultInt);
        return resultInt;
    }
}

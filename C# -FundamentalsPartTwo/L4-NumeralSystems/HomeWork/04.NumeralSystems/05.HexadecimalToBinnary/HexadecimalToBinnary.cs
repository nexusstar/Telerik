/*
 * 05.
 * Write a program to convert hexadecimal numbers to binary numbers (directly).
 * 
 */

using System;
using System.Collections.Generic;

class HexadecimalToBinnary
{
    static void Main()
    {
        Console.Write("\nEnter hexadecimal number: ");

        string hexNumber = Console.ReadLine();

        string result = ConvertHexadecimalToBinary(hexNumber);
        Console.WriteLine("\n{0} converted to binary is: ", hexNumber);
        Console.WriteLine(result);
        
    }

    private static string ConvertHexadecimalToBinary(string hexNumber)
    {
        
        string[,] hexBinaryMatrix = 
        {
            {"0000", "0001", "0010", "0011", 
             "0100", "0101", "0110", "0111", 
             "1000", "1001", "1010", "1011", 
             "1100", "1101", "1110", "1111"},
            {"0", "1", "2", "3",
             "4", "5", "6", "7", 
             "8", "9", "A", "B",
             "C", "D", "E", "F" }
        };

        string result = string.Empty;

        //find the hex value in matrix and return its binary equivalent directly
        for (int ch = 0; ch < hexNumber.Length; ch++)
        {
            for (int col = 0; col < hexBinaryMatrix.GetLength(1); col++)
            {
                if (hexNumber[ch].ToString() == hexBinaryMatrix[1, col])
                {
                    result += hexBinaryMatrix[0, col] + " ";
                    break;
                }
            }
        }

        return result;
    }
}


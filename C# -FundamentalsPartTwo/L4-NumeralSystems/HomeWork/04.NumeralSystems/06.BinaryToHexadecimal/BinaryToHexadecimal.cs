using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("\nEnter binary number: ");
        string binNumber = Console.ReadLine();

        string result = ConvertBinaryToHexadecimal(binNumber);
        Console.WriteLine("\n{0} converted to hexadecimal is: ", binNumber);
        Console.WriteLine(result);
    }

    //Convert binary strting to its hexadecimal string representation
    //separating string to pairs by four and check them with ready values
    private static string ConvertBinaryToHexadecimal(string binNumber)
    {
        string[,] hexBinaryMatrix = 
        {
           {"0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"},
           {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"}
        };

        if (binNumber.Length % 4 != 0)
        {
            binNumber = string.Empty.PadLeft(4 - binNumber.Length % 4, '0') + binNumber;
        }

        string result = string.Empty;

        string fourByFour = string.Empty;
        int count = 0;
        for (int i = 0; i < binNumber.Length / 4; i++)
        {
            for (int col = 0; col < hexBinaryMatrix.GetLength(1); col++)
            {
                if (binNumber.Substring(i + count, 4).Equals(hexBinaryMatrix[0, col]))
                {
                    result += hexBinaryMatrix[1, col];
                    count += 3;
                    break;
                }
            }
        }

        return result;
    }
}

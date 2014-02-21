/*
 * 02.
 * Write a program to convert binary numbers to their decimal representation.
 *
 */
using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("\nEnter binary number: ");
        
        string binaryNum = Console.ReadLine();

        long decimalNumber = ConvertToDecimal(binaryNum);

        Console.WriteLine("{0} to decimal -> {1}", binaryNum, decimalNumber);
    }

    //converts binary number to decimaal one
    private static long ConvertToDecimal(string binaryNum)
    {
        long decimalNumber = 0;
        for (int i = binaryNum.Length - 1, power = 1; i >= 0; i--, power *= 2)
        {
            decimalNumber += (binaryNum[i] - '0') * power;
        }
        return decimalNumber;
    }
}

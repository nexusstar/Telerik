/*
 * 03.
 * Write a program to convert decimal numbers to their hexadecimal representation.
 * 
 */

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        
        int number;
        do
        {
          Console.Write("Enter a number (positive): ");
        } while (!int.TryParse(Console.ReadLine(), out number) && number >= 0);
        Console.WriteLine("{0} to hexadecimal -> {1}", number, ConvertToHexadecimal(number)); 
    }

    private static string ConvertToHexadecimal(int number)
    {
        string hexadecimal = string.Empty;
        while (number > 0)
        {
            char remainder;
            if (number % 16 >= 10)
            {
                remainder = (char)('A' + number % 16 - 10);
            }
            else
            {
                remainder = (char)('0' + number % 16);
            }
            hexadecimal = remainder + hexadecimal;
            number /= 16;
        }
        return hexadecimal;
    }
}
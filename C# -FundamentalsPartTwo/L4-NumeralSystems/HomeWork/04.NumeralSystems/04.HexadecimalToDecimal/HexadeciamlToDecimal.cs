/*
 * 04.
 * Write a program to convert hexadecimal numbers to their decimal representation.
 * 
 */

using System;

class HexadeciamlToDecimal
{
    static void Main()
    {
        Console.Write("\nEnter hexadecimal number: ");

        string hexNumber = Console.ReadLine();

        long decimalNumber = ConvertToDecimal(hexNumber);

        Console.WriteLine("{0} to decimal -> {1}", hexNumber, decimalNumber);
    }

    //converts hexadecimal number to decimal one
    private static long ConvertToDecimal(string hex)
    {
        long decimalNumber = 0;
        for (int i = hex.Length - 1, power = 1; i >= 0; i--, power *= 16)
        {
            if (hex[i]>='0' && hex[i] <= '9')
            {
                decimalNumber += (hex[i] - '0') * power;
            }
            else if(hex[i]>='A' && hex[i] <= 'F')
            {
                decimalNumber += (hex[i] - 'A' + 10) * power;
            }
            
        }
        return decimalNumber;
    }
}

/*
 * 
 * 07. Excercise
 * Write a method that reverses the digits of given decimal number. Example: 256 -> 652
 * 
 */

using System;

class ReversingDigits
{
    static void Main()
    {
        Console.Write("Please enter a decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("{0}->{1}",number, ReverseDigitsInNumber(number));
    }
    
    static decimal ReverseDigitsInNumber(decimal number)
    {
        char[] numberDigits = number.ToString().ToCharArray();
        Array.Reverse(numberDigits);
        
        return decimal.Parse(string.Join("", numberDigits));
    }
}


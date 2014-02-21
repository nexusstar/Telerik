/*
 * 08. Excercise
 * Write a method that adds two positive integer numbers represented as 
 * arrays of digits (each array element arr[i] contains a digit;
 * the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;

class AddingBigNumbersTwo
{
    static void Main()
    {
        
        Console.WriteLine("\nTest with user numbers: ");
        
        Console.Write("Enter first non-negative number: ");
        string userFirst = Console.ReadLine();

        Console.Write("Enter second non-negative number: ");
        string userSecond = Console.ReadLine();

        int[] a = userFirst.Select(ch => ch - '0').ToArray();
        int[] b = userSecond.Select(ch => ch - '0').ToArray();

        int[] userResult = SumArrays(a, b);
        Console.WriteLine(string.Join("", userResult));

    }

    static int[] SumArrays(int[] first, int[] second)
    {
        Stack<int> addNumbers = new Stack<int>();

        int maxLength = Math.Max(first.Length, second.Length);

        //getting arrays lengths equal by shallow copy them to two new ones
        int[] a = new int[maxLength];
        int[] b = new int[maxLength];
        Array.Copy(first, 0, a, maxLength - first.Length, first.Length);
        Array.Copy(second, 0, b, maxLength - second.Length, second.Length);

        //calculating sum
        int carry = 0;
        for (int i = maxLength - 1; i >= 0; i--)
        {
            addNumbers.Push((a[i] + b[i] + carry) % 10);
            carry = (a[i] + b[i] + carry) / 10;
        }

        //adding last remainder
        if (carry > 0)
            addNumbers.Push(carry);

        return addNumbers.ToArray();
    }
}





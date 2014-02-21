/*
 * 
 * Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number
 * represented as array of digits by given integer number.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Factorial
{
    static void Main()
    {
        int[] factorial = { 1 };
        
        Console.WriteLine("0 -> 1");
        for (int i = 1; i <= 100; i++)
        {
            factorial = Multiplay(factorial, i);
            Console.Write("{0} -> ",i);
            Console.Write(string.Join("", factorial));
            Console.WriteLine();
        }
    }

    //adding Arrays from exc. 8
    static int[] SumArrays(int[] first, int[] second)
    {
        Stack<int> addNumbers = new Stack<int>();

        int maxLength = Math.Max(first.Length, second.Length);

        // getting arrays lengths equal by shallow copy them to two new ones
        int[] a = new int[maxLength];
        int[] b = new int[maxLength];
        Array.Copy(first, 0, a, maxLength - first.Length, first.Length);
        Array.Copy(second, 0, b, maxLength - second.Length, second.Length);

        // calculating sum
        int carry = 0;
        for (int i = maxLength - 1; i >= 0; i--)
        {
            addNumbers.Push((a[i] + b[i] + carry) % 10);
            carry = (a[i] + b[i] + carry) / 10;
        }

        // adding last remainder
        if (carry > 0)
            addNumbers.Push(carry);

        return addNumbers.ToArray();
    }

    // Multiplication represented as addition 3 * x = x + x + x
    static int[] Multiplay(int[] array, int x)
    {
        int[] result = { 0 };
        for (int i = 0; i < x; i++)
        {
            result = SumArrays(result, array);
        }
        return result;

    }
}

/*
 * 01
 * Write a program to convert decimal numbers to their binary representation.
 * 
 * Note: if number is negative result is represented as 32 bit (negative int type)
 */

using System;
using System.Collections.Generic;


class DecimalToBinary
{
    static void Main()
    {
        Console.Write("\nEnter decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        int[] resultInt = ConvertDecimaltoBinary(decNum);
        Console.WriteLine("\nResult:");
        Console.WriteLine("{0} -> {1}\n", decNum, string.Join("", resultInt));

    }

    //Converts base 10 number to base 2 if negative to int negative
    private static int[] ConvertDecimaltoBinary(int decNum)
    {
        bool negative = false;
        if (decNum < 0)
        {
            decNum = ~decNum;
            negative = true;
        }

        List<int> result = new List<int>();
        while (decNum != 0)
        {
            result.Add(decNum % 2);
            decNum = decNum / 2;
        }

        int[] resultInt = result.ToArray();

        //represent number as 32 bit negative
        if (negative)
        {
            int[] a = new int[32];
            for (int i = 0; i < a.Length; i++)
            {
                if (i < resultInt.Length)
                {
                    a[i] = resultInt[i] == 0 ? 1 : 0;
                }
                else
                {
                    a[i] = 1;
                }
            }
            Reverse(a);
            return a;
        }

        Reverse(resultInt);
        return resultInt;
    }

    //Reverse array values
    static void Reverse(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
    }

}
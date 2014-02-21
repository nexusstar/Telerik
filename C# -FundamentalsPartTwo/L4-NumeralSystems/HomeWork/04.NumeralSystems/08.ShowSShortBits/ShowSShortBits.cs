/*
 * 08.
 * Write a program that shows the binary representation of given 16-bit signed integer number (the C# type sshort).
 */

using System;
using System.Collections.Generic;

class ShowSShortBits
{
    static void Main()
    {
        Console.Write("\nEnter decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        int[] resultInt = ConvertDecimaltoBinary(decNum);
        Console.WriteLine("\nResult:");
        
        Console.WriteLine("{0} -> {1}\n", decNum, 
            string.Join("", resultInt).PadLeft(16, '0')); //padding left to 16
    }

    //Convert decimal number to its binary representation for 1 word
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

        //represent number as 16 bit negative
        if (negative)
        {
            int[] a = new int[16];
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

/*
* 11.  
 * Write a method that adds two polynomials. Represent them as
* arrays of their coefficients as in the example below:
* x2 + 5 = 1x2 + 0x + 5 -> |5| |0| |1|
* 
* 12. 
* Extend the program to support also subtraction and multiplication of polynomials.
*/
using System;

    class Program
    {
        static void Main()
        {
            int[] arr = {0, 4, 2};
            int[] arr2 = { -7, 10, 6 };
            PrintPolynomials(arr);
            PrintPolynomials(arr2);
            PrintPolynomials(AddPolynomials(arr, arr2));
            PrintPolynomials(SubPolynomials(arr, arr2));

        }

        static int[] AddPolynomials(int[] first, int[] second)
        {
            //make length equal
            //getting arrays lengths equal by shallow copy them to two new ones
            int maxLength = Math.Max(first.Length, second.Length);
            int[] a = new int[maxLength];
            int[] b = new int[maxLength];
            Array.Copy(first, 0, a, maxLength - first.Length, first.Length);
            Array.Copy(second, 0, b, maxLength - second.Length, second.Length);
            int[] result = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                result[i] = a[i] + b[i];
            }
            return result;
        }

        static int[] SubPolynomials(int[] first, int[] second)
        {
            //make length equal
            //getting arrays lengths equal by shallow copy them to two new ones
            int maxLength = Math.Max(first.Length, second.Length);
            int[] a = new int[maxLength];
            int[] b = new int[maxLength];
            Array.Copy(first, 0, a, maxLength - first.Length, first.Length);
            Array.Copy(second, 0, b, maxLength - second.Length, second.Length);
            int[] result = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                result[i] = a[i] - b[i];
            }
            return result;
        }

        static int[] MultiplayPolynomials(int[] first, int[] second)
        {
            int[] result = new int[first.Length + second.Length - 1];

            for (int i = 0; i < first.Length; i++)
                for (int j = 0; j < second.Length; j++)
                    result[i + j] += first[i] * second[j];

            return result;

        }

        static void PrintPolynomials(int[] arr)
        {
            for (int index = arr.Length-1; index >= 0; index--)
            {
                
                    Console.Write("{0,3}*x^{1}", arr[index], index);
                    if (index!=0)
                        Console.Write(" + ");    
            }
            Console.WriteLine();
        }
    }

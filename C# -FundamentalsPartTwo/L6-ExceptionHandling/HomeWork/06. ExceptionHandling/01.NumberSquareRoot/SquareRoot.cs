/*
 * 01.
 * Write a program that reads an integer number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally.
 */

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a integer number: ");
            ushort number = ushort.Parse(Console.ReadLine());

            Console.WriteLine("\nSquare root of number {0} is {1}\n", number, Math.Sqrt(number));
        }
        catch (ArgumentNullException an)
        {

            Console.WriteLine("\nEntered number is invalid!\n-> {0}\n", an.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("\nEntered number is invalid!\n-> {0}\n", fe.Message);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine("\nEntered number is invalid!\n-> {0}\n", oe.Message);
        }
        finally
        {
            Console.WriteLine("\nGood bye!\n");
        }
    }
}


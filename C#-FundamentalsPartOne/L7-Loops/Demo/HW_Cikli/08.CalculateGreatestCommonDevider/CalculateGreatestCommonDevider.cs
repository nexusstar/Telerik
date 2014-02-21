/*Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
 * http://introcs.cs.luc.edu/html/gcdexamples.html 
*/
using System;

class CalculateGreatestCommonDevider
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers:");
        Console.Write(" 1: "); uint a = uint.Parse(Console.ReadLine());
        Console.Write(" 2: "); uint b = uint.Parse(Console.ReadLine());

        while (a != b)
        {
            while (a > b)
            {
                a = a - b;               
            }
            while(b > a)
            {
                b = b - a;               
            }
        }
        Console.WriteLine("\nThe Greatest common divisor is: {0}\n", a);
    }
}

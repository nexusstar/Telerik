using System;
using System.Numerics; // in order to use BigInteger we need this reference
class FibonacciSequence
{
    /// <summary>
    /// ex 9 -Write a program to print the first 100 members of the sequence of Fibonacci: 
    /// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
    /// 
    /// Note: In mathematical terms, the sequence Fn of Fibonacci numbers is defined by the recurrence relation
    /// F_n = F_{n-1} + F_{n-2} 
    ///with seed values F_0 = 0,\; F_1= 1.
    /// as we still did not lear recursion with c# will use stright the formula
    /// </summary>
    static void Main()
    {
        BigInteger twoBefore = 0;
        BigInteger oneBefore = 1;
        BigInteger currentPlace;
        int counter = 0;
        while (counter < 99) // first 100 numbers
        {
            if (counter == 0)
            {
                Console.Write("Seed 0: "+ twoBefore + ", " + "Seed 1: " + oneBefore + ", "); 
            }
            currentPlace = oneBefore + twoBefore;
            Console.Write("({0}) = {1} ", counter + 2, currentPlace);
            twoBefore = oneBefore;
            oneBefore = currentPlace;
            counter++;
            
        }
    }
}

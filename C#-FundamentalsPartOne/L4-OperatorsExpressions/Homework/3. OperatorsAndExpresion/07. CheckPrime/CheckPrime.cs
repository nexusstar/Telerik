using System;
class CheckPrime
{
    /// <summary>
    /// ex. 7 - Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
    /// A: Check all numbers from 0 to Math.Sqrt of checked number
    /// </summary>
    static void Main()
    {
        Console.Write("Write an int in the range 0 - 100: ");
        int givenInt = int.Parse(Console.ReadLine());
        bool isPrime = false;
        for (int num = 1; num <= Math.Sqrt(givenInt) ; num++)
        {
            if (givenInt%num == 0)
            {
                isPrime = true;
                break;
            }
            
        }
        if (isPrime)
        {
            Console.WriteLine("The number " + givenInt + " IS prime");
        }
        else
        {
            Console.WriteLine("The number " + givenInt + " IS NOT prime");
        }

        Console.ReadKey();
    }
}


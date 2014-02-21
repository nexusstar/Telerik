/*
 * 
 * 15.  Write a program that finds all prime numbers in the range [1...10 000 000]. 
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
 * 
 */

using System;

class EratostheneSieve
{
    static void Main()
    {
        bool[] primeNumbers = new bool[121];
        for (int pos = 2; pos < Math.Sqrt(primeNumbers.Length); pos++)
        {
            if (primeNumbers[pos] == false)
            {
                for (int i = pos*pos; i < primeNumbers.Length; i += pos)
                {
                    primeNumbers[i] = true;
                }
            }
        }
        for (int index = 2; index < primeNumbers.Length; index++)
        {
            if (!primeNumbers[index])
            {
                Console.Write(index + " ");
            }
        }
    }
}

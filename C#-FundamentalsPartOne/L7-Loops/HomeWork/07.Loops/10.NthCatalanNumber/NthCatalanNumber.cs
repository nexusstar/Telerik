using System;
using System.Numerics;
class NthCatalanNumber
{
    /// <summary>
    /// ex 10 - Write a program to calculate the Nth Catalan number by given N.
    /// note from Wikipedia:
    /// The first Catalan numbers for n = 0, 1, 2, 3, … are
    /// 1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796, 58786
    /// </summary>
    static void Main()
    {
        int userN;
        do
        {
            Console.Write("Enter number (n>=0):");   
        } while (!int.TryParse(Console.ReadLine(), out userN));
        BigInteger nThCatalanNumber = 1;
        if (userN < 2)
        {
            nThCatalanNumber = 1;
        }
        else
        {
            for(BigInteger num = 0; num< userN; num++)
            {
                nThCatalanNumber = (2 * (2 * num + 1) * nThCatalanNumber) / (num + 2);
            }
        }
        Console.WriteLine("The {0} Catalan Number is: {1} ",userN , nThCatalanNumber);
    }
}

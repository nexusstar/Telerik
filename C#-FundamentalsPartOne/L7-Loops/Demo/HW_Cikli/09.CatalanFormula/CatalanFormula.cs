/*In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
(2n)! / (n+1)!n!
*/
using System;

class CatalanFormula
{
    static void Main()
    {
        uint n;

        Console.Write("Please enter a number: ");
        bool isNValid = uint.TryParse(Console.ReadLine(), out n);

        if (isNValid)
        {
            Console.WriteLine("\nC({0}) = {1}\n", n, CalculateFactorial(2 * n) / (CalculateFactorial(n + 1) * CalculateFactorial(n)));
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }
    static uint CalculateFactorial(uint n)
    {
        if (n < 1) return 1;

        return n * CalculateFactorial(n - 1);
    }
}

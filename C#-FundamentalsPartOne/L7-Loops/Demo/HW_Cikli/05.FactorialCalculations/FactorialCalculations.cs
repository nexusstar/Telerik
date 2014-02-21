/*Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K). 
 3!*5!/(5-3)! = 360;
 3.2.1*5.4.3.(2.1) / 2.1 = 360; start from (K - N + 1) i.e. (3.4.5) because (K-N)! i.e.( 2.1) is excluded
 */
using System;

class FactorialCalculations
{
    static void Main()
    {
        int N, K;
        int factorial = 1;

        Console.WriteLine("Plesae enter number N:");
        bool isNValid = int.TryParse(Console.ReadLine(), out N);

        Console.WriteLine("Please enter number K:");
        bool isKValid = int.TryParse(Console.ReadLine(), out K);

        if (isNValid && isKValid && (N < K) && (N > 1) && (K > 1))
        {
            for (int i = K - N + 1; i <= K; i++)
            {
                factorial = factorial * i; // factorial of K!, as we start from (K - N + 1) because (K-N)! is excluded

                if (i == K)
                {
                    i = 2;
                    while (i <= N)
                    {
                        factorial = factorial * i; // add * factorial of N! to K!
                        i++;
                    }
                    break;
                }
            }
            Console.WriteLine("\nResult: {0}!*{1}!/({1}-{0})! = {2}\n", N, K, factorial);
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }
}

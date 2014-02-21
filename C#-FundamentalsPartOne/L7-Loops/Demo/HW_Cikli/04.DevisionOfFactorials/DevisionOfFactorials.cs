/*Write a program that calculates N!/K! for given N and K (1<K<N). */
using System;

class DevisionOfFactorials
{
    static void Main(string[] args)
    {
        int N, K;
        int factorial = 1;        

        Console.WriteLine("Plesae enter number N:");
        bool isNValid = int.TryParse(Console.ReadLine(), out N);

        Console.WriteLine("Please enter number K:");
        bool isKValid = int.TryParse(Console.ReadLine(), out K);

        if (isNValid && isKValid && (N > K) && (N > 1) && (K > 1))
        {
            for (int i = K + 1; i <= N; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(" {0}!/{1}! = {2}", N, K, factorial);
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }
}

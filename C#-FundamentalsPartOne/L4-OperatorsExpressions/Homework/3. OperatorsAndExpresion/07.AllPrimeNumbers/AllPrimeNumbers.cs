using System;
using System.Collections.Generic;

    class AllPrimeNumbers
    {
        /// <summary>
        /// Write all the prime numbers in given range.
        /// </summary>
        static void Main()
        {
            List<int> primeList = new List<int>();
            primeList.Add(2);
            Console.Write("All the prime numbers to: ");
            int rangeNum = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int num = 2; num < rangeNum; num++)
            {
                foreach (int prime in primeList)
                {
                    if (num % prime == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    primeList.Add(num);  
                }
                isPrime = true;
            }
            foreach (int prime in primeList)
            {
                Console.Write(" " + prime);
                
            }
            Console.WriteLine();
        }
    }

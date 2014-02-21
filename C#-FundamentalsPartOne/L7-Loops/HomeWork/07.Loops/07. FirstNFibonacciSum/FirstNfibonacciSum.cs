using System;
using System.Numerics;

namespace _07.FirstNFibonacciSum
{
    class FirstNfibonacciSum
    {
        /// <summary>
        /// ex.7 - Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        /// </summary>
        static void Main()
        {
            
            int userN;
            do
            {
                Console.Write("Please enter how many member to sum: ");
            } while (!int.TryParse(Console.ReadLine(),out userN) || userN < 1);
            BigInteger fibOne = 0;
            BigInteger fibTwo = 1;
            BigInteger fibNumber = 0;
            BigInteger sum = 0;
            for (int count = 0; count < userN; count++)
            {
                sum += fibNumber;
                fibNumber = (count == 1 ? 1 : fibOne + fibTwo);
                fibOne = fibTwo;
                fibTwo = fibNumber;      
            }
            Console.WriteLine("The sum of first {0} members of Fibonacci numbers is:{1} ", userN, sum);

        }
    }
}

/*
 * Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
 * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 * 
 */

namespace _06.DivisibleBy7And3
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] num = new int[] { 13, 32, 30, 21, 70, 623, 213, 700, 35, 245, 63, 35, 140 };

            Console.WriteLine(string.Join(", ", num));

            Console.WriteLine("\nUsing Lambda: ");

            var numbsDivisableBy7And3Lambda = num.Where(n => n % 35 == 0);

            Console.WriteLine(string.Join(", ", numbsDivisableBy7And3Lambda));

            Console.WriteLine("\nUsing LINQ: ");

            var numbsDivisableBy7And3Linq = from n in num
                                            where n % 35 == 0
                                            select n;

            Console.WriteLine(string.Join(", ", numbsDivisableBy7And3Linq));
        }
    }
}

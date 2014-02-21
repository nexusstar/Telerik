/*
 * 02.
 * Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;

class RandomValues
{
    static void Main()
    {
        Random rand = new Random();
        for (int count = 0; count < 10; count++)
        {
            int nextRandom = rand.Next(100,201);
            Console.WriteLine("{0,2} -> {1}", count+1, nextRandom );
        }
    }
}

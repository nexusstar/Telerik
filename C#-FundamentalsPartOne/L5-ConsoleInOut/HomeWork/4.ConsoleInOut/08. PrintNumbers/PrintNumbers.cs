using System;

class PrintNumbers
{
    /// <summary>
    /// ex. 8 -Write a program that reads 
    /// an integer number n from the console and prints all the numbers in the interval 
    /// [1..n], each on a single line.
    /// </summary>
    static void Main()
    {
        Console.Write("Enter the end of interval [1 .. n]: ");
        string userInt;
        int n;
        do
        {
            userInt = Console.ReadLine();
        } while (!int.TryParse(userInt,out n));
        if (n > 0)
        {
            for (int num = 1; num <= n; num++)
            {
                Console.WriteLine(num);                
            }
        }
        else
        {
            for (int num = 1; num >= n; num--)
            {
                Console.WriteLine(num);
            }
        }

    }
}
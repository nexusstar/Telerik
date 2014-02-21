using System;

class NumberMatrix
{
    /// <summary>
    /// ex. 12 - Write a program that reads from the console a positive integer number N [N  20) and outputs a matrix 
    /// like the following:
    /// </summary>
    static void Main()
    {
         byte userN;

        do
        {
            Console.Write("Enter number in interval [2, 20): ");
           
        }
        while (!Byte.TryParse(Console.ReadLine(), out userN) || userN < 2 || userN >= 20);

        for (int i = 0; i < userN; i++)
        {
            for (int j = i + 1; j < i + userN + 1; j++)
            {
                Console.Write(" {0,2}", j);
            }

            Console.WriteLine();
        }
    }
}
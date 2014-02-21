/*Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
* N = 3	
* 1 2 3
* 2 3 4
* 3 4 5
* N = 4
* 1 2 3 4
* 2 3 4 5
* 3 5 6 7
* 4 5 6 7
*/
using System;

class PrintMatrix
{
    static void Main()
    {
        uint n;

        Console.Write("Please enter a number 0 < N < 20: ");
        bool isNValid = uint.TryParse(Console.ReadLine(), out n);

        if (isNValid)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= row + n - 1; col++)
                {
                    Console.Write("{0,5}", col);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }
}

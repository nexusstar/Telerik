using System;

class ThreeInt
{
    /// <summary>
    /// ex. 1 - Write a program that reads 3 integer numbers from the console and prints their sum.
    /// </summary>
    static void Main()
    {
        int result = 0;
        for (int num = 0; num < 3; num++)
        {
            Console.Write("Please enter an int: ");
            int givenInt = int.Parse(Console.ReadLine());
            result = result + givenInt;            
        }
        Console.WriteLine("Sum of numbers is  : " + result);

        Console.WriteLine();
        
        //solution Two
        int counter = 3;
        result = 0;
        do
        {
            Console.Write("Please enter an int: ");
            int givenInt = int.Parse(Console.ReadLine());
            result = result + givenInt;
            counter--;
            
        } while (counter>0);
        Console.WriteLine("Sum of numbers is  : " + result);
    }
}
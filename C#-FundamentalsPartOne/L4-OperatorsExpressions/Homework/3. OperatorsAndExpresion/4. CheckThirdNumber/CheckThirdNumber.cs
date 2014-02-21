using System;

class CheckThirdNumber
{
    /// <summary>
    /// ex. 4 Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("This program checks if third digit(right-to-left) is 7");
        Console.Write("Please enter integer number for checking: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        int givenNumber = int.Parse(Console.ReadLine());
       
        if ((Math.Abs(givenNumber % 1000) - 700) >= 100 || (Math.Abs(givenNumber % 1000) - 700) < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(false + " acording to this test");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(true + " acording to this test");
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
}


using System;

class CheckOddEvenNumber
{
    /// <summary>
    /// Ex. 1 - Write an expression that checks if given integer is odd or even.
    /// </summary>
    static void Main()
    {
        int givenInteger;

        //Using infinite while loop combined with int.TryParse until the entered value is integer
        while (true)
        {
            Console.Write("Please enter integer value: ");
            if (int.TryParse(Console.ReadLine(), out givenInteger))
            {
                if (givenInteger % 2 == 0)
                {
                    Console.Write("Your entered number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(givenInteger + " is even.");
                    
                }
                else
                {
                    Console.Write("Your entered number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(givenInteger + " is odd.");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Thank you!");
                Console.ReadKey(); //This way even if you build the whole app it will wait for a key to exit
                break; // This is the only break in the application so it will loop until the value entered is integer
            }
            else
            {
                Console.WriteLine("Entered value from you is not integer please try again!\n");
            }
        }
        
    }
}
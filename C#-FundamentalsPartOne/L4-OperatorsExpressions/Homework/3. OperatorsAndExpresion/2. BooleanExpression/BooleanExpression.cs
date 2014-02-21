using System;

class BooleanExpression
{
    /// <summary>
    /// Write a boolean expression that checks for given integer
    /// if it can be divided (without remainder) by 7 and 5 in the same time.
    /// </summary>
    static void Main()
    {
        int givenInteger;
        
        while (true)
        {
            Console.Write("Please enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out givenInteger))
            {
                if (givenInteger % 5 == 0 && givenInteger % 7 == 0) //boolean expresion that checks if number is divisable by 5 and 7
                {
                    Console.WriteLine("True enterd number " + givenInteger + " IS divisable to 5 and 7 in the same time");
                }
                else
                {
                    Console.WriteLine("False entered number " + givenInteger + " IS NOT divisable to 5 and 7 in the same time");
                }
                break;
            }
            else
            {
                Console.WriteLine("Entered value is not integer");
            }
        }
    }
}

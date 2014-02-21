using System;

class NumbersFromOneToN
{
    /// <summary>
    /// ex. 2 - Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
    /// note:
    /// De Morgan 1st law  - "not (A and B)" is the same as "(not A) or (not B)"
    /// 
    /// </summary>
    static void Main()
    {
        int userN;
        do
        {
            Console.Write("Enter an integer: ");
        } while (!int.TryParse(Console.ReadLine(), out userN));
        if (userN >= 1)
        {
            for (int num = 1; num <= userN; num++)
            {
                if (!(num % 7 == 0 && num % 3 == 0)) //or could also be (num % 7 !== 0 || num % 3 !== 0) De Morgan 1st law
                {
                    Console.Write(num + " ");
                }
                
            }
        }
        else
        {
            for (int num = userN; num <= 1; num++)
            {
                if (!(num % 7 == 0 && num % 3 == 0))
                {
                    Console.Write(num + " ");
                }
            }
        }
        Console.WriteLine();
   

    }
}

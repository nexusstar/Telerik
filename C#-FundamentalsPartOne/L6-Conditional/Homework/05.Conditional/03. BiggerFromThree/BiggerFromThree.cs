using System;

class BiggerFromThree
{
    /// <summary>
    /// ex 3- Write a program that finds the biggest of three integers using nested if statements.
    /// </summary>
    static void Main()
    {
        string firstValue;
        int a;
        do
        {
            Console.Write("Enter first int: ");
            firstValue = Console.ReadLine();
        } while (!int.TryParse(firstValue, out a));
        string secondValue;
        int b;
        do
        {
            Console.Write("Enter second int: ");
            secondValue = Console.ReadLine();
        } while (!int.TryParse(secondValue,out b));
        string thirdValue;
        int c;
        do
	    {
             Console.Write("Enter third int: ");
	          thirdValue = Console.ReadLine();   
	    } while (!int.TryParse(thirdValue, out c));

        if (a >= b)
        {
            if (b >= c)
            {
                Console.WriteLine("The {0} is greatest", a); 
            }
            else if (a >= c)
            {
                Console.WriteLine("The {0} is greates", a);
            }
            else 
            {
                Console.WriteLine("The {0} is greates", c);
            }
        }
        else if (b >= c)
        {
            Console.WriteLine("The {0} is greatest", b);
        }
        else
        {
            Console.WriteLine("The {0} is greatest", c);
        }
    }
}

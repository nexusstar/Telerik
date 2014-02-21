using System;

class DescendingOrder
{
    /// <summary>
    /// ex. 4 Sort 3 real values in descending order using nested if statements.
    /// </summary>
    static void Main()
    {
        string firstValue;
        double a;
        do
        {
            Console.Write("Enter first number: ");
            firstValue = Console.ReadLine();
        } while (!double.TryParse(firstValue, out a));
        string secondValue;
        double b;
        do
        {
            Console.Write("Enter second number: ");
            secondValue = Console.ReadLine();
        } while (!double.TryParse(secondValue, out b));
        string thirdValue;
        double c;
        do
        {
            Console.Write("Enter third number: ");
            thirdValue = Console.ReadLine();
        } while (!double.TryParse(thirdValue, out c));

        if (a >= b)
        {
            if (b >= c)
            {
                Console.WriteLine("The order is {0} , {1}, {2}", a, b, c);
            }
            else if (a >= c)
            {
                Console.WriteLine("The order is {0} , {1}, {2}", a, c, b);
            }
            else
            {
                Console.WriteLine("The order is {0} , {1}, {2}", c, a, b);
            }
        }
        else if (b >= c)
        {
            if (c >= a)
            {
                Console.WriteLine("The order is {0} , {1}, {2}", b, c, a);
            }
            else
            {
                Console.WriteLine("The order is {0} , {1}, {2}", b, a, c);
            }
            
        }
        else
        {
            Console.WriteLine("The order is {0} , {1}, {2}", c, b, a);
        }
    }
}

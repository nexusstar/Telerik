using System;

class FloatingTypeComparison

{
    /// <summary>
    /// Write a program that safely compares 
    /// floating-point numbers with precision of 0.000001.
    /// Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003) > true
    /// Assumptions: The numbers are entered correctly as floating point numbers
    /// </summary>
    static void Main()
    {
        double firstNumber;
        double secondNumber;
        Console.Write("Enter your first number:");
        
        //check if first entered value could be parsed to floating point number
        if (double.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.WriteLine("The First Number entered is {0}", firstNumber);
        }
        else
        {
            Console.WriteLine("This is not a number, the value could not be parsed!");
        }
        
        Console.Write("Enter your second number:");
        
        //check if second entered value could be parsed to floating point number
        if (double.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("The Second Number entered is {0}", secondNumber);
        }
        else
        {
            Console.WriteLine("This is not a number, the value could not be parsed!");
        }

        //compare the two values with precision 0.000001
        if (Math.Abs(firstNumber - secondNumber) < 1e-6)
        {
            Console.WriteLine("This two ({0},{1}) numbers are equal with precision 0,000001", firstNumber, secondNumber);

        }
        else
        {
            Console.WriteLine("This two numbers are not equal");
        }
    }
}


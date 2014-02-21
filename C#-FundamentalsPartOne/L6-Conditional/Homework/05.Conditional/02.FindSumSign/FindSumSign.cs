using System;

class FindSumSign
{
    /// <summary>
    /// ex. 2 Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
    /// Use a sequence of if statements.
    /// </summary>
    static void Main()
    {
        string numValue;
        double a;
        do
        {
            Console.Write("Enter first number: ");
            numValue = Console.ReadLine();
        } while (!double.TryParse(numValue, out a));
        string numValueTwo;
        double b;
        do
        {
            Console.Write("Enter second number: ");
            numValueTwo=Console.ReadLine();
        } while (!double.TryParse(numValueTwo, out b));
        string numValueThree;
        double c;
        do
        {
          Console.Write("enter third number: ");
            numValueThree = Console.ReadLine();
        } while (!double.TryParse(numValueThree, out c));
        
        // True XOR False XOR False = True and True XOR TRUE XOR False = True but True XOR True XOR True = False 
        if ((a<0) ^ (b<0) ^ (c<0)) 
	    {
		  Console.WriteLine("The product will be negative");
	    }
        else
        {
           Console.WriteLine("The product will be positive");
        }
    }
}

using System;

class UserChoice
{
    /// <summary>
    /// Write a program that, depending on the user's choice inputs
    /// int, double or string variable. 
    /// If the variable is integer or double, increases it with 1. 
    /// If the variable is string, appends "*" at its end. 
    /// The program must show the value of that variable as a console output. Use switch statement.
    /// </summary>
    static void Main()
    {
        Console.Write("Pleace enter \"integer\", \" double \", or \" string \": ");
        string userChoice = Console.ReadLine();
        userChoice = userChoice.ToLower(); // convert all the input to lower case
        switch (userChoice)
        {
            case "string":
                string userString;
                Console.Write("Enter your string: ");
                userString = Console.ReadLine();
                Console.WriteLine("Result: " + userString +"*");
                break;

            case "double":
                string userDouble;
                double userDoubleNumber;
                do
                {
                    Console.Write("Enter your double value: ");
                    userDouble = Console.ReadLine();
                } while (!double.TryParse(userDouble, out userDoubleNumber));
                Console.WriteLine("Result: " + (userDoubleNumber + 1.0) );
                break;

            case "integer":
                string userInt;
                int userIntNumber;
                do
                {
                    Console.Write("Enter your integer value: ");
                    userInt = Console.ReadLine();
                } while (!int.TryParse(userInt, out userIntNumber));
                Console.WriteLine("Result: "+ (userIntNumber + 1));
                break;


            default:
                Console.WriteLine("Entered value is not one of \"integer\", \"double\" or \"string\"");
                break;
        }
    }
}
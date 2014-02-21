/*
 * 03. Excercise
 * Write a method that returns the last digit of given integer as an English word. 
 * Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".
 * 
 */

using System;

class VerbalLastDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();

        Console.WriteLine("{0} -> {1}",userInput, ReturnLastDigitAsWord(userInput));

    }

    static string ReturnLastDigitAsWord(string number)
    {
        switch (number[number.Length-1])
        {
            case '0':
                return ("zero");
            case '1':
                return ("one");
            case '2':
                return("two");
            case '3':
                return("three");
            case '4':
                return("four");
            case '5':
                return("five");
            case '6':
                return("six");
            case '7':
                return("seven");
            case '8':
                return ("eight");
            case '9':
                return ("nine");

            default:
                return ("This " + number[number.Length-1] + " is not a digit (0 to 9)");
        }
    }

}
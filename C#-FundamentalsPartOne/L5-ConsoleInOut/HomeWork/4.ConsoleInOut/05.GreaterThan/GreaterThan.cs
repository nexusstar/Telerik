using System;
class GreaterThan
{
    /// <summary>
    /// ex. 5 Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
    /// </summary>
    static void Main()
    {
        //geting numbers assuming doubles
        string firstNum;
        double firstUserNumber;
        do
        {
            Console.Write("Write your first number:");
            firstNum = Console.ReadLine();
        } while (!double.TryParse(firstNum,out firstUserNumber));

        string secondNum;
        double secondUserNumber;
        do
        {
            Console.Write("write your second number:");
            secondNum = Console.ReadLine();
        } while (!double.TryParse(secondNum, out secondUserNumber));

        //First Solution using the thernary ?: conditional operator
        Console.WriteLine((firstUserNumber>secondUserNumber)?
            "The ( " + firstUserNumber+ " ) number is max":
            "The second ( "+ secondUserNumber +" )number is max");

        //Second Solution using bitwise operators
        int firstUserInt = (int)firstUserNumber;
        int secondUserInt = (int)secondUserNumber;
        int maxNumber = firstUserInt - ((firstUserInt-secondUserInt)&((firstUserInt-secondUserInt)>>31));
        
        //little cheat using ?: operator to display the max number
        Console.WriteLine(
            (firstUserNumber%maxNumber == 0)?
            "The ( " + firstUserNumber+ " ) number is max":
            "The second ( "+ secondUserNumber +" )number is max");
        
        //Third Solution using Math.Max method
        Console.WriteLine("The Max Number is: " + Math.Max(firstUserNumber,secondUserNumber));
        
    }
}
/*
 * 02. Excercise 
 * Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from the console and prints the biggest of them
 * using the method GetMax().
 * 
 */

using System;

class GetMaxNumber
{
    static void Main()
    {
        Console.Write("First number: ");
        int numOne = int.Parse(Console.ReadLine());
        
        Console.Write("Second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        
        Console.Write("Third number ");
        int numThree = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBiggest number is: " +
            GetMax(GetMax(numOne, numTwo), numThree));

        TestMethod(); //<-Test Method
    }

    static int GetMax(int firstNum, int secondNum){
        if (firstNum > secondNum)
            return firstNum;
        else
            return secondNum;
    }

    static void TestMethod() {

        Console.WriteLine(new string('-', 40) + "\n");
        Console.WriteLine("Test cases:\n");
        Console.WriteLine(new string('-', 40) + "\n");
        
        Console.WriteLine("Bigger from 1 and 2: " + GetMax(1,2));
        
        Console.WriteLine("Bigger from -1 and 1: " + GetMax(1, -1));

        Console.WriteLine("Bigger from 0 and 0: " + GetMax(0, 0));
    }
}


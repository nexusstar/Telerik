/*
 * 
 * 03. Excercise
 * Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is working correctly.
 * 
 */

using System;

class CountNumberInArray
{
    static void Main()
    {
        

        int[] numbersArray = EnterValuesOfArray();
        
        Console.Write("\nEnter a searched number: ");
        int givenNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();
        
        Console.WriteLine(string.Join(" ", numbersArray));

        Console.WriteLine("\nCounting appearance of {0}\n", givenNumber);

        Console.WriteLine("Result -> {0}", CountNumber(numbersArray,givenNumber) );
        
        Console.WriteLine();
        TestMethod();

    }

    static int CountNumber(int[] numArray, int countedNumber)
    {
       int[] result =  Array.FindAll(numArray, x => x==countedNumber);
       return result.Length;
    }
   
    static int[] EnterValuesOfArray()
    {
        Console.Write("Enter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        return numbers;
    }

    static void TestMethod()
    {
        Console.WriteLine("Tests:");
        int[] arrOne = { 1, 2, 3, 1, 2, 3, 1, 2, 3 };
        int result = CountNumber(arrOne, 1);
        Console.WriteLine("Expected 3 result ->{0}",result);

        int[] arrTwo = { 1, 2, 3 };
        result = CountNumber(arrTwo, 1);
        Console.WriteLine("Expected 1 result ->{0}", result);

        int[] arrThree = { 2, 3 };
        result = CountNumber(arrThree, 1);
        Console.WriteLine("Expected 0 result ->{0}", result);

        int[] arrFour = new int[0];
        result = CountNumber(arrFour, 1);
        Console.WriteLine("Expected 0 result ->{0}", result);
    }
}

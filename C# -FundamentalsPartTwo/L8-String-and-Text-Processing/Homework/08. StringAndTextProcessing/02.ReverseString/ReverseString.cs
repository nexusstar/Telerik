/*
 * 
 * 02. Write a program that reads a string, reverses it and prints the result at the console.
 * Example: "sample"-> "elpmas".
 */



using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        string exampleTest = ReverseStringInput("sample");

        Console.Write("YourString: ");
        string input = Console.ReadLine();
        Console.WriteLine("\nResult:");
        Console.WriteLine("{0} --> {1}", input, ReverseStringInput(input));

    }

    //reverse string characters
    static string ReverseStringInput(string input)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++) result.Insert(0, input[i]);//insert current char at 0

        return result.ToString();
    }
}

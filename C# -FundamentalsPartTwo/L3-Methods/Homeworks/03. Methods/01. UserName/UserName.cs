/*
 * 01. Excercise 
 * Write a method that asks the user for his name and prints “Hello, <name>” 
 * (for example, “Hello, Peter!”). Write a program to test this method.
 * 
 */

using System;

class UserName
{
    static void Main()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        
        GreetingUser(userName);
        
        TestMethod(); // <- TEST METHOD

    }

    static void GreetingUser(string name)
    {
        Console.WriteLine("Hello {0}!", name);
    }

    static void TestMethod()
    {
        Console.WriteLine(new string('-', 40) + "\n");
        Console.WriteLine("Test cases:\n");
        Console.WriteLine(new string('-', 40) + "\n");
        GreetingUser("Peter");
        GreetingUser("Peter Doe");
        GreetingUser("Joe" + 10);
    }
}

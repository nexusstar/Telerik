using System;

class SwapValues
{
    /// <summary>
    /// 11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values
    /// </summary>
    static void Main()
    {
        int valueOne = 5;
        int valueTwo = 10;
        Console.WriteLine("First var value: {0}", valueOne);
        Console.WriteLine("Second var value: {0}", valueTwo);
        valueOne = valueOne + valueTwo;
        valueTwo = valueOne - valueTwo;
        valueOne = valueOne - valueTwo;
        
        //checking values
        Console.WriteLine("Changed first var value: {0}", valueOne);
        Console.WriteLine("Changed second var value: {0}", valueTwo);

    }
}

using System;

class QuoteedString
{
    /// <summary>
    /// Declare two string variables and assign them with following value:
    /// The "use" of quotations causes difficulties.
	///Do the above in two different ways: with and without using quoted strings.
    /// </summary>
    static void Main()
    {
        //using escape charackter \
        string firstStrint = "The \"use\" of quotations ";
        string secondString = "causes difficulties.";
        string resString = firstStrint + secondString;
        Console.WriteLine(resString);
        
        //using verbatim string litteral @
        string firstStringTwo = @"The ""use"" of quatations";
        string secondStringTwo = " causes difficulties.";
        Console.WriteLine(firstStringTwo + secondStringTwo);
    }
}


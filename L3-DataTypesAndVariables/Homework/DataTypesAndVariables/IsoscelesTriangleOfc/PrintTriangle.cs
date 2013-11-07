using System;

class PrintTriangle
{
    /// <summary>
    /// Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
    /// Use Windows Character Map to find the Unicode code of the © symbol. 
    /// Note: the © symbol may be displayed incorrectly.
    /// </summary>
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;              

        char copyrightSymbol = (char)0xA9;
        

        string line = string.Empty;
        int lineCount = 3;

        //universal solution for any number of lines
        for (int count = 0; count < lineCount; count++)
        {
            line = new string(copyrightSymbol, 2 * count + 1);
            Console.WriteLine(line.PadLeft(lineCount+count));
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;
class ASCIITAblePrint
{
    /// <summary>
    /// 12. Find online more information about ASCII (American Standard Code for Information Interchange)
    /// and write a program that prints the entire ASCII table of characters on the console.
    /// 
    /// The ASCII character code charts contain the decimal and hexadecimal values of the extended ASCII 
    /// (American Standards Committee for Information Interchange) character set. 
    /// The extended character set includes the ASCII character set and 128 other 
    /// characters for graphics and line drawing, often called the "IBM character set."
    /// </summary>
    static void Main()
    {
        
        
        for (int i = 0; i <= 255; i++)
        {
           char Letter  = (char)i;
           Console.WriteLine("{0:D3} = {1}", i, Letter);
          


        }
    }
}

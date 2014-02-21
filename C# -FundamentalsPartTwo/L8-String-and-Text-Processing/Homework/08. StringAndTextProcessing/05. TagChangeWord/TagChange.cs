/*
* 5. You are given a text. Write a program that changes the text in all regions
* surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
* 
* Example: 
* We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
* 
* The expected result:
* We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.TagChangeWord
{
    class TagChange
    {
        static void Main()
        {
            string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string result = UpdateTextWithTag(text);
            Console.WriteLine(result);

        }

        private static string UpdateTextWithTag(string text)
        {
            return Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper());
        }

    }
}

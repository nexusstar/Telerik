/*
* 10. Write a program that extracts from given XML file all the text without the tags. 
* 
*     Example:                                    
*    <?xml version="1.0"?>                
*    <student>                            
*        <name>Pesho</name>                       Pesho   
*        <age>21</age>                            21      
*        <interests count="3">            --->    Games   
*            <interest>Games</interest>           C#      
*            <interest>C#</interest>              Java    
*            <interest>Java</interest>    
*        </interests>                     
*    </student>                           
*/


using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class RemoveXMLTags
{
    static void Main()
    {
        //Using input file 
        string pathInput = @"..\..\Files\input.xml";

        ExtractTextFromXML(pathInput);
        

    }

    static void ExtractTextFromXML(string inputPath)
    {
        StringBuilder output = new StringBuilder();
        

        using (StreamReader sr = new StreamReader(inputPath))
        {
            while (!sr.EndOfStream)
            {
                for (int i; (i = sr.Read()) != -1; ) // Read char by char
                {
                    if (i == '>') // Inside text node
                    {
                        string text = String.Empty;

                        while ((i = sr.Read()) != -1 && i != '<') text += (char)i;

                        if (!String.IsNullOrWhiteSpace(text)) Console.WriteLine(text); 
                    }
                }
            }
        }
    }
}
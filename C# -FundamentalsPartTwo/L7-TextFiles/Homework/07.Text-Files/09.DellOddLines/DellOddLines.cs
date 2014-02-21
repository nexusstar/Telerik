/*
 * 09.
 * Write a program that deletes from given text file all odd lines. The result should be in the same file.
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class DellOddLines
{
    static void Main()
    {
        //Using temp file 
        string pathInput = @"..\..\Files\Start.txt";

        //RemoveOddLinesWithList(pathInput);
        RemoveOddLinesWithTempFile(pathInput);
    }

    //Solution ONE without temporary files
    private static void RemoveOddLinesWithList(string pathInput)
    {
        
        var linesToKeep = File.ReadLines(pathInput).Where((l, index) => index % 2 != 0).ToList();
        File.Delete(pathInput);
        File.WriteAllLines(pathInput, linesToKeep.ToArray());
    }

    //Solution TWO with temporary files for large files
    private static void RemoveOddLinesWithTempFile(string pathInput)
    {
        
        var tempFile = Path.GetTempFileName(); 
        var linesToKeep = File.ReadLines(pathInput).Where((l, i) => i % 2 != 0); //index lines and keep only even ones
        File.WriteAllLines(tempFile, linesToKeep); //writes linesToKeep on tempfile
        File.Delete(pathInput);
        File.Move(tempFile, pathInput);
        
    }
}

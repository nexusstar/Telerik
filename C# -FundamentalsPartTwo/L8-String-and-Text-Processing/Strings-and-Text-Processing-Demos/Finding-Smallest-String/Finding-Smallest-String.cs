using System;
using System.IO;

class ReadingPrintingStrings
{
    static void Main()
    {
        string[] towns = {"01", "ab", "ab01",
			"abc", "02", "03", "abc01"};
        string firstTown = towns[0];
        for (int i = 1; i < towns.Length; i++)
        {
            char a = 'A';
            string currentTown = towns[i];
            if (string.Compare(currentTown, firstTown) < 0)
            {
                firstTown = currentTown;
            }
        }
        Console.WriteLine("First town: {0}", firstTown);
        char n = Path.DirectorySeparatorChar;
    }
}

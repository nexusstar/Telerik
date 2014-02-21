using System;
using System.Diagnostics;
using System.Text;

class StringBuilderDemo
{
    public static string ReverseIt(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }

    public static string ExtractCapitals(string s)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (Char.IsUpper(ch))
            {
                result.Append(ch);
            }
        }
        return result.ToString();
    }

    public static string DupChar(char ch, int count)
    {
        StringBuilder result = new StringBuilder(count);
        for (int i = 0; i < count; i++)
        {
            result.Append(ch);
        }
        return result.ToString();
    }

    static void Main()
    {
        string s = "Telerik Academy";

        string reversed = ReverseIt(s);
        Console.WriteLine(reversed);

        string capitals = ExtractCapitals(s);
        Console.WriteLine(capitals);
        Stopwatch sw = new Stopwatch();
        sw.Start();
        DateTime startTime = DateTime.Now;
		Console.WriteLine("Concatenation 200 000 chars...");
		DupChar('a', 200000);
        sw.Stop();
		DateTime endTime = DateTime.Now;
        long milliSec = sw.ElapsedMilliseconds;
        Console.WriteLine(milliSec);
		Console.WriteLine("... done in {0} seconds", endTime - startTime);
        

        
	}
}

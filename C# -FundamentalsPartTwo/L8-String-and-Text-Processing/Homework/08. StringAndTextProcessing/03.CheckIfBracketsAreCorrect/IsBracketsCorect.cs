using System;

class IsBracketsCorect
{
    static void Main(string[] args)
    {
        Console.Write("Enter an expression: ");
        string exp = Console.ReadLine();

        Console.WriteLine("\nThe expression is {0}!\n", IsValidExpression(exp) ? "correct" : "incorrect");
    }

    private static bool IsValidExpression(string exp)
    {
        if (exp.Contains("()"))
        {
            return false;
        }
        int bracketsCount = 0;
        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == '(')
            {
                bracketsCount++;
            }
            else if (exp[i] == ')')
            {
                bracketsCount--;
            }
            if (bracketsCount < 0)
            {
                return false;
            }
        }
        if (bracketsCount!=0)
        {
            return false;
        }
        return true;
    }
}


using System;

class DrunkenNumbers
{
    static void Main()
    {
        int numRounds = int.Parse(Console.ReadLine());
        string[] drunkenNumbers = new string[numRounds];
        for (int round = 0; round < drunkenNumbers.Length; round++)
        {
            string currentStr = (string)Console.ReadLine();
            string tempStr = "";
            for (int cNum = 0; cNum < currentStr.Length; cNum++)
            {
                if (currentStr[cNum] != '0' || cNum > 0)
                {
                    tempStr += currentStr[cNum];
                }
            }
            if (tempStr.Length % 2 != 0)
            {
                tempStr = tempStr.Substring(0, tempStr.Length / 2 + 1) + tempStr.Substring(tempStr.Length / 2, tempStr.Length / 2 + 1);

            }
            drunkenNumbers[round] = tempStr;
        }
        int mitkoB = 0;
        int vladkoB = 0;
        for (int rounds = 0; rounds < drunkenNumbers.Length; rounds++)
        {
            for (int currentRound = 0; currentRound < drunkenNumbers[rounds].Length; currentRound++)
            {
                if (currentRound < drunkenNumbers[rounds].Length / 2)
                {
                    mitkoB += int.Parse(drunkenNumbers[rounds][currentRound].ToString());
                }
                else
                {
                    vladkoB += int.Parse(drunkenNumbers[rounds][currentRound].ToString());
                }
            }
        }
        if (mitkoB > vladkoB)
        {
            Console.WriteLine("M " + (mitkoB - vladkoB));

        }
        else if (vladkoB > mitkoB)
        {
            Console.WriteLine("V " + (vladkoB - mitkoB));
        }
        else
        {
            Console.WriteLine("No " + (mitkoB + vladkoB));
        }


    }
}

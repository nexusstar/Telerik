using System;

class Fire
{


    static void Main()
    {
        int givenNumber = 8;
        string tempStr = "";
        for (int i = 0; i < givenNumber / 2; i++)
        {
            for (int n = 0; n < givenNumber / 2; n++)
            {
                if (n == givenNumber / 2 - i - 1)
                {
                    tempStr = tempStr + "#";
                }
                else
                {
                    tempStr = tempStr + ".";
                }
            }

            for (int n = 0; n < givenNumber / 2; n++)
            {
                if (n == i)
                {
                    tempStr = tempStr + "#";
                }
                else
                {
                    tempStr = tempStr + ".";
                }
            }

            Console.WriteLine(tempStr);
            tempStr = "";
        }

        for (int secN = 0; secN < givenNumber / 4; secN++)
        {

            for (int n = 0; n < givenNumber / 2; n++)
            {
                if (n == secN)
                {
                    tempStr = tempStr + "#";
                }
                else
                {
                    tempStr = tempStr + ".";
                }
            }
            for (int n = 0; n < givenNumber / 2; n++)
            {
                if (n == givenNumber / 2 - secN - 1)
                {
                    tempStr = tempStr + "#";
                }
                else
                {
                    tempStr = tempStr + ".";
                }
            }
            Console.WriteLine(tempStr);
            tempStr = "";
        }
        for (int i = 0; i < givenNumber; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();



    }
}
using System;
using System.Collections.Generic;


namespace _01.MultiverseCommunication
{
    class FromOneToOther
    {
        static int strExtrract = 3;
        static int baseNum = 13;
        static List<string> alphabet = new List<string> { 
            "CHU",
            "TEL",
            "OFT",
            "IVA",
            "EMY",
            "VNB",
            "POQ",
            "ERI",
            "CAD",
            "K-A",
            "IIA",
            "YLO",
            "PLA"

        };
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();


            long decimalRepresentation = 0;

            for (int i = 0; i < input.Length; i += strExtrract)
            {

                string digitBase = input.Substring(i, strExtrract);

                long decimalValue = alphabet.IndexOf(digitBase);

                decimalRepresentation *= baseNum;

                decimalRepresentation += decimalValue;
            }

            Console.WriteLine(decimalRepresentation);

        }

    }
}


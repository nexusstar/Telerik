using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


class CheckSubsetClean
{
    /// <summary>
    /// ex.9 - We are given 5 integer numbers. 
    /// Write a program that checks if the sum of some subset of them is 0. 
    /// Example: 3, -2, 1, 1, 8  1+1-2=0.
    /// </summary>

    static void Main()
    {

        int[] userInts = new int[5];

        for (int num = 0; num < userInts.Length; num++)
        {
            string userValue;
            int userNumber;
            do
            {
                Console.Write("Enter {0} value: ", num + 1);
                userValue = Console.ReadLine();
            } while (!int.TryParse(userValue, out userNumber));
            userInts[num] = userNumber;
        }

        int subsetCount = (int)Math.Pow(2, userInts.Length);
        for (int subsetItem = 1; subsetItem < subsetCount; subsetItem++)
        {
            List<int> currentList = new List<int>(); 

            string s = Convert.ToString(subsetItem, 2);

            byte[] bits = s.PadLeft(userInts.Length, '0')
                         .Select(c => byte.Parse(c.ToString()))
                         .ToArray();

            for (int bitPosition = 0; bitPosition < bits.Length; bitPosition++)
            {
                if (bits[bitPosition] == 1)
                {
                    currentList.Add(userInts[bitPosition]);
                }
            }
            if (currentList.Sum() == 0)
            {
                Console.Write("This subset sum:{");
                foreach (int item in currentList)
                {
                    Console.Write(item + " ");
                }
                Console.Write("} equals Zero ");
                Console.WriteLine();
            }

        }

    }
}

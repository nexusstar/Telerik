using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


class CheckSubsetIsZero
{
    /// <summary>
    /// ex.9 - We are given 5 integer numbers. 
    /// Write a program that checks if the sum of some subset of them is 0. 
    /// Example: 3, -2, 1, 1, 8  1+1-2=0.
    /// </summary>
    /// 
 
    static void Main()
    {
        
        int[] userInts = new int[5];

        //getting user numbers
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

        // There will be 2^n subsets for a given set, where N is the cardinality (number of items) of that set.
        // For example, there will be 2^5 = 32 subsets for the set {1, 2, 3, 4, 5}.
        // see more at: http://www.mathsisfun.com/activity/subsets.html
        // The binary representation of each number 'i' in the range 0 to (2N - 1) is used to find the corresponding ith subset. 
        // Each '1' in the binary representation indicates an item in that position. 
        // For example, the binary representation of number 5 is 00101 which in turn represents the subset {3, 5} of the set {1, 2, 3, 4, 5}.

        int subsetCount = (int)Math.Pow(2, userInts.Length);
        for (int subsetItem = 1; subsetItem < subsetCount; subsetItem++) // we skip empty subset 0 {00000}
        {
            List<int> currentList = new List<int>(); // local list for subset

            
            //little cheat convert number to bit represenatation and after that store it to array of 1 and 0
            string s = Convert.ToString(subsetItem, 2);
            
            byte[] bits = s.PadLeft(userInts.Length, '0') //add 0 from left desired positions
                         .Select(c => byte.Parse(c.ToString()))//convet each char to byte
                         .ToArray();

            for (int bitPosition = 0; bitPosition < bits.Length; bitPosition++)
            {
                if (bits[bitPosition] == 1)
                {
                    currentList.Add(userInts[bitPosition]); //this adds the item on position where we have 1
                }
            }
            
            //Check if current subset is == 0 and prints it 
            if (currentList.Sum() == 0)
            {
                Console.Write("This subset sum:{");
                foreach (int item in currentList)
                {
                    Console.Write(item + " ");
                }
                Console.Write( "} equals Zero ");
            }
            
            //optionaly print current subsets - uncoment bellow
            //Console.Write("{");
            //for (int i = 0; i < currentList.Count; i++)
            //{
            //    Console.Write(currentList[i] + " ");
            //}
            //Console.Write("}");
            //Console.WriteLine();
        }

    }
}

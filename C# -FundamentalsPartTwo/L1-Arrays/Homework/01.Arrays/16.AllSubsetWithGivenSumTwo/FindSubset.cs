/*
* 16. We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
*	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)
 *	
 * note: Originaly this is my solution to excercise 9 from conditional homework from c# part I
 * it is similar to the other solution but this one is more array/List oriented :-)
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


class FindSubset
{

    static void Main()
    {
        Console.Write("Enter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a searched Sum: ");
        int sum = int.Parse(Console.ReadLine());

        int[] numArray = new int[n];
        Console.WriteLine("Enter a {0} number(s) to array: ", n);
        for (int i = 0; i < numArray.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numArray[i] = int.Parse(Console.ReadLine());
        }

        bool isFoundSubset = false;

        //TEST
        //int[] numArray = {2, 1, 2, 4, 3, 5, 2, 6};
        //int sum = 14;

        // There will be 2^n subsets for a given set, where N is the cardinality (number of items) of that set.
        // For example, there will be 2^5 = 32 subsets for the set {1, 2, 3, 4, 5}.
        // see more at: http://www.mathsisfun.com/activity/subsets.html
        // The binary representation of each number 'i' in the range 0 to (2N - 1) is used to find the corresponding ith subset. 
        // Each '1' in the binary representation indicates an item in that position. 
        // For example, the binary representation of number 5 is 00101 which in turn represents the subset {3, 5} of the set {1, 2, 3, 4, 5}.

        int subsetCount = (int)Math.Pow(2, numArray.Length);
        for (int subsetItem = 1; subsetItem < subsetCount; subsetItem++) // we skip empty subset 0 {00000}
        {
            List<int> currentList = new List<int>(); // local list for subset


            //little cheat convert number to bit represenatation and after that store it to array of 1 and 0
            string s = Convert.ToString(subsetItem, 2);

            byte[] bits = s.PadLeft(numArray.Length, '0') //add 0 from left desired positions
                         .Select(c => byte.Parse(c.ToString()))//convet each char to byte
                         .ToArray();

            for (int bitPosition = 0; bitPosition < bits.Length; bitPosition++)
            {
                if (bits[bitPosition] == 1)
                {
                    currentList.Add(numArray[bitPosition]); //this adds the item on position where we have 1
                }
            }

            //Check if current subset is == Sum and prints it 
            if (currentList.Sum() == sum)
            {
                Console.Write("This subset sum:(");
                foreach (int item in currentList)
                {
                    Console.Write(item + " ");
                }
                Console.Write(") == {0}\n", sum);
                isFoundSubset = true;
            }

            //optionaly print current subsets for all subsets - uncoment bellow
            //Console.Write("{");
            //for (int i = 0; i < currentList.Count; i++)
            //{
            //    Console.Write(currentList[i] + " ");
            //}
            //Console.Write("}");
            //Console.WriteLine();
            
        }
        Console.WriteLine(!isFoundSubset ? "- There are no subsets with Sum " + sum + "\n" : "");

    }
}

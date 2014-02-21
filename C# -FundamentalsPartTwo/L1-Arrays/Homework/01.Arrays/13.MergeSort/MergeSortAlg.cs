/*
* 13. Write a program that sorts an array of integers using
* the merge sort algorithm.
* Example: { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5 } -> { -5, -4, -3, -2, -1, 1, 2, 3, 4, 5}
*/

using System;

class MergeSortAlg
{
    static void Main()
    {
        int[] numArray = {1, -10,20,100,2,4,5,8,29,2};
        //{ 1, -1, 2, -2, 3, -3, 4, -4, 5, -5 }
            
        Console.WriteLine("Before sorting: \n{0}", string.Join(" ", numArray));

        //sorting
        MergeSort(numArray, 0, numArray.Length - 1);

        Console.WriteLine("After sorting: \n{0}", string.Join(" ", numArray));

    }

    public static void MergeSort(int[] inputArray, int left, int right)
    {
        if (left < right)
        {
            int md = (left + right) / 2;

            MergeSort(inputArray, left, md);
            MergeSort(inputArray, md + 1, right);

            //Merge
            int[] leftArray = new int[md - left + 1];
            int[] rightArray = new int[right - md];

            Array.Copy(inputArray, left, leftArray, 0, md - left + 1);
            Array.Copy(inputArray, md + 1, rightArray, 0, right - md);

            int lIndex = 0;
            int rIndex = 0;
            for (int index = left; index <= right; index++)
            {
                if (lIndex == leftArray.Length) //do we have 0 elements
                {
                    inputArray[index] = rightArray[rIndex];
                    rIndex++;
                }
                else if (rIndex == rightArray.Length) // do we have 0 elements
                {
                    inputArray[index] = leftArray[lIndex];
                    lIndex++;
                }
                else if (leftArray[lIndex] <= rightArray[rIndex])
                {
                    inputArray[index] = leftArray[lIndex];
                    lIndex++;
                }
                else
                {
                    inputArray[index] = rightArray[rIndex];
                    rIndex++;
                }
            }
        }
    }      
}

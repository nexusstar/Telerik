/*
 * Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
 * this is the most useful explanation of QuickSort I found: 
 * https://d19vezwu8eufl6.cloudfront.net/algs4partI/recoded_videos%2Falgs4partI-35.mp4
 * 
 * Note: in this impleamentation I assume that cAsE is not important in string
 */
using System;
class QuickSortAlg
{
    static void Main(string[] args)
    {

        string[] strArray =  //{ "This", "is", "Telerik", "academy", "C#", "2", "QuickSort", "exccercise" }; 

                            // { "g", "f", "e", "d", "c", "b", "a" };
            { "a", "b", "c", "d", "e", "f", "g" };
            // { "a", "b", "c", "d","r","r","a","b","c","d","r","r"}; 
            // { "g", "G", "a", "A", "a", "b", "B" }; 



        Console.WriteLine("Before sorting: ");
        Console.WriteLine(string.Join(" ", strArray));

        QuickSort(strArray, 0, strArray.Length - 1);


        Console.WriteLine("After sorting: ");
        Console.WriteLine(string.Join(" ", strArray));

    }

    private static int[] PartitioningElements(string[] testStrArray, int lo, int hi)
    {
        int[] positionsAfterPartition = new int[2];
        int lessThanKey = lo; //partitioning item
        int greaterThanKey = hi;
        int iKey = lo + 1;
        while (true)
        {
            // String.Compare(StrA,StrB, true) returns regardlles cAsE
            //-1 if strA is less than strB
            // 1 if strA is greather than strB
            // 0 when strA is equal to strB
            int compareResult = String.Compare(testStrArray[lessThanKey], testStrArray[iKey], true);
            if (compareResult > 0)
            {
                if (iKey >= greaterThanKey) { break; }
                //swap elements
                var temp = testStrArray[iKey];
                testStrArray[iKey] = testStrArray[lessThanKey];
                testStrArray[lessThanKey] = temp;
                iKey++;
                lessThanKey++;
            }

            else if (compareResult < 0)
            {
                if (iKey >= greaterThanKey) { break; }
                //swap elements
                var temp = testStrArray[iKey];
                testStrArray[iKey] = testStrArray[greaterThanKey];
                testStrArray[greaterThanKey] = temp;
                greaterThanKey--;

            }
            else
            {
                if (iKey >= greaterThanKey) { break; }
                //when elements are equal just increment iKey
                iKey++;


            }

        }


        positionsAfterPartition[0] = lessThanKey;
        positionsAfterPartition[1] = greaterThanKey;

        return positionsAfterPartition;
    }
    private static void QuickSort(string[] testStrArray, int lo, int hi)
    {
        if (hi <= lo)
        {
            return;
        }

        int[] leftRightPosition = new int[2];
        Array.Copy(PartitioningElements(testStrArray, lo, hi), leftRightPosition, 2);

        QuickSort(testStrArray, lo, leftRightPosition[0] - 1);
        QuickSort(testStrArray, leftRightPosition[1], hi);
    }
}
